using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Data;
using System.Data.SqlClient;
using Inventory.DataModels;
using Inventory.DataObjects.DAO;

namespace Inventory.Process.Data
{
    public class ImportProcess
    {
        private SqlCommand objCmd;
        private string strSeparate = ", ";
        private string strAnd = " and ";
        private int intImportOption = 0;

        public SqlCommand DBCommand
        {
            get { return objCmd; }
            set { objCmd = value; }
        }

        public int ImportOption
        {
            get { return intImportOption; }
            set { intImportOption = value; }
        }

        public int ImportData(string tableName, DataTable table)
        {
            // ignore the Timestamp column
            if (table.Columns.Contains("Timestamp"))
            {
                table.Columns.Remove("Timestamp");
            }  

            // get empty data table for storing import data
            DataTable dtData = Mediator.GetInstance().GetEmptyTableForFilter(tableName);
            if (dtData.Columns.Contains("Timestamp")) // ignore the Timestamp column
            {
                dtData.Columns.Remove("Timestamp");
            }  

            // Reload data from file to dtData for restoring the format of data
            // (ex. format of DateTime may be changed when export/import with Xml).
            foreach(DataRow dr in table.Rows)
            {
                // copy data row, do not use LoadDataRow function
                // because the columns of tables may be different.
                DataRow rowData = dtData.NewRow();
                foreach (DataColumn dc in table.Columns)
                {
                    rowData[dc.ColumnName] = dr[dc.ColumnName];
                }

                dtData.Rows.Add(rowData);
            }

            for (int i = dtData.Columns.Count - 1; i >= 0; i--)
            {
                string strName = dtData.Columns[i].ColumnName;
                if (!table.Columns.Contains(strName))
                {
                    dtData.Columns.Remove(strName);
                }
            }

            if (tableName.Contains(" "))
            {
                tableName = "[" + tableName + "]";
            }

            string strCheck = this.GetCheckSql(tableName, dtData);
            string strInsert = this.GetInsertSql(tableName, dtData);
            string strUpdate = this.GetUpdateSql(tableName, dtData);

            foreach (DataRow dr in dtData.Rows)
            {
                if (this.CheckExistedData(strCheck, tableName, dr))
                {
                    if (intImportOption == 0)
                    {
                        return 0; // stop if data existed
                    }
                    else if (intImportOption == 1)
                    {
                        continue; // skip existing data
                    }
                    else
                    {
                        this.UpdateRowData(strUpdate, dr, dtData); // override existing data
                        continue;
                    }
                }

                this.InsertRowData(strInsert, dr, dtData);
            }

            return 3; // not care about data is skip or override
        }

        #region Import DataRow

        private int InsertRowData(string sqlInsert, DataRow dr, DataTable dtData)
        {
            objCmd.Parameters.Clear();
            objCmd.CommandText = sqlInsert;

            foreach (DataColumn dc in dtData.Columns)
            {
                string strValue = dc.ColumnName;
                if (strValue.Contains(" "))
                {
                    strValue = strValue.Replace(" ", "_");
                }

                objCmd.Parameters.Add(new SqlParameter("@" + strValue, dr[dc]));
            }

            return objCmd.ExecuteNonQuery();
        }

        private int UpdateRowData(string sqlUpdate, DataRow dr, DataTable dtData)
        {
            objCmd.Parameters.Clear();
            objCmd.CommandText = sqlUpdate;

            foreach (DataColumn dc in dtData.Columns)
            {
                string strValue = dc.ColumnName;
                if (strValue.Contains(" "))
                {
                    strValue = strValue.Replace(" ", "_");
                }

                objCmd.Parameters.Add(new SqlParameter("@" + strValue, dr[dc]));
            }

            return objCmd.ExecuteNonQuery();
        }

        private bool CheckExistedData(string sqlCheck, string tableName, DataRow dr)
        {
            objCmd.Parameters.Clear();
            objCmd.CommandText = sqlCheck;

            ArrayList arrPKs = this.GetPKColumns(tableName);
            foreach (string strPK in arrPKs)
            {
                string strName = strPK;
                if (strName.Contains(" "))
                {
                    strName = "[" + strName + "]";
                }

                objCmd.Parameters.Add(new SqlParameter("@" + strName, dr[strPK]));
            }

            int intCount = Convert.ToInt32(objCmd.ExecuteScalar());
            if (intCount > 0)
            {
                return true; // data existed
            }

            return false;
        }

        #endregion

        #region Get Import Sql

        private string GetInsertSql(string tableName, DataTable dtData)
        {
            //string strSql = "Insert into {0} ({1}) values ({2}}";
            
            string strListColumns = "";
            string strListValues = "";
            foreach(DataColumn col in dtData.Columns)
            {
                string strName = col.ColumnName;
                string strValue = col.ColumnName;
                if (strName.Contains(" "))
                {
                    strName = "[" + strName + "]";
                    strValue = strValue.Replace(" ", "_");
                }

                strListColumns += strName + strSeparate;
                strListValues += "@" + strValue + strSeparate;
            }

            if(strListColumns.EndsWith(strSeparate))
            {
                strListColumns = strListColumns.Substring(0, strListColumns.Length - strSeparate.Length);
            }

            if (strListValues.EndsWith(strSeparate))
            {
                strListValues = strListValues.Substring(0, strListValues.Length - strSeparate.Length);
            }

            return "Insert into " + tableName + " (" + strListColumns + ") " + "Values(" + strListValues + ")";
            //return string.Format(strSql, tableName, strListColumns, strListValues);
        }

        private string GetUpdateSql(string tableName, DataTable dtData)
        {
            //string strSql = "Update {0} set ({1})";
            string strList = "";
            foreach(DataColumn dc in dtData.Columns)
            {
                string strName = dc.ColumnName;
                string strValue = dc.ColumnName;
                if (strName.Contains(" "))
                {
                    strName = "[" + strName + "]";
                    strValue = strValue.Replace(" ", "_");
                }

                strList += strName + " = @" + strValue + strSeparate;
            }

            if (strList.EndsWith(strSeparate))
            {
                strList = strList.Substring(0, strList.Length - strSeparate.Length);
            }

            string strCondition = "";
            ArrayList arrPKs = this.GetPKColumns(tableName);
            foreach (string strPK in arrPKs)
            {
                string strName = strPK;
                string strValue = strPK;
                if (strName.Contains(" "))
                {
                    strName = "[" + strName + "]";
                    strValue = strValue.Replace(" ", "_");
                }

                strCondition += strName + " = @" + strValue + strAnd;
            }

            if (strCondition.EndsWith(strAnd))
            {
                strCondition = strCondition.Substring(0, strCondition.Length - strAnd.Length);
            }
            
            return "Update " + tableName + " Set " + strList + " Where " + strCondition;
            //return string.Format(strSql, tableName, strList);
        }

        private string GetCheckSql(string tableName, DataTable dtData)
        {
            //string strSql = "Check {0} set ({1})";
            string strList = "";
            ArrayList arrPKs = this.GetPKColumns(tableName);
            foreach (string strPK in arrPKs)
            {
                string strName = strPK;
                string strValue = strPK;
                if (strPK.Contains(" "))
                {
                    strName = "[" + strName + "]";
                    strValue = strValue.Replace(" ", "_");
                }

                strList += strName + " = @" + strValue + strAnd;
            }

            if (strList.EndsWith(strAnd))
            {
                strList = strList.Substring(0, strList.Length - strAnd.Length);
            }

            return "Select count(*) From " + tableName + " Where " + strList;
            //return string.Format(strSql, tableName, strList);
        }

        private ArrayList GetPKColumns(string tableName)
        {
            string strSql = "select c.name as COLUMN_NAME from sys.key_constraints as k join sys.tables as t on t.object_id = k.parent_object_id join sys.schemas as s on s.schema_id = t.schema_id join sys.index_columns as ic on ic.object_id = t.object_id and ic.index_id = k.unique_index_id join sys.columns as c on c.object_id = t.object_id and c.column_id = ic.column_id where k.type = 'PK' and t.name = '" + tableName + "'";

            DataTable dtPKs = Mediator.GetInstance().GetTableForFilter(strSql);

            ArrayList arrPKs = new ArrayList();
            foreach (DataRow dr in dtPKs.Rows)
            {
                if (dr["COLUMN_NAME"] != DBNull.Value)
                {
                    arrPKs.Add(dr["COLUMN_NAME"].ToString());
                }
            }

            return arrPKs;
        }

        #endregion
    }
}
