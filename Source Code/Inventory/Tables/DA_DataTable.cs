/*******************************************************************
*UserGroups interaction
* Created by DuongNT (g8 company)
* Date: Friday, June 29, 2007
*******************************************************************/
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
namespace Inventory
{
    public class DA_DataTable : DataTable
    {   
      
   
        #region Contructer
        public DA_DataTable():base()
        {

        }
        
        public DA_DataTable(string procedureName)
            : base()
        {
            ProcessDatabase(procedureName, true);
        }
        public DA_DataTable(string procedureName, Dictionary<string, object> dicKeyValue)
            : base()
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            SqlCommand comm = new SqlCommand(procedureName, conn);

            foreach (string para in dicKeyValue.Keys)
            {
                SqlParameter sqlPara = new SqlParameter(para, dicKeyValue[para]);
                comm.Parameters.Add(sqlPara);
            }
            comm.CommandType = CommandType.StoredProcedure;

            adapter = new SqlDataAdapter(comm);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
            //Insert command
            adapter.InsertCommand = cmdBuilder.GetInsertCommand();
            //Update command
            adapter.UpdateCommand = cmdBuilder.GetUpdateCommand();
            //Delete command
            adapter.DeleteCommand = cmdBuilder.GetDeleteCommand();
            adapter.Fill(this);

        }
        public DA_DataTable(string procedureName, bool isProcedure)
            : base()
        {
            ProcessDatabase(procedureName, isProcedure);
        }
        #endregion 
        #region Variable
        private SqlDataAdapter adapter;
        #endregion
        #region Method
        public void ReSelect(string strSQL)
        {
            this.Clear();
            adapter.SelectCommand.CommandText = strSQL;
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.Fill(this);
        }
        private void ProcessDatabase(string procedureName, bool isProcedure)
        {
            try
            {
                if (isProcedure)
                {
                    SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
                    SqlCommand comm = new SqlCommand(procedureName, conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    adapter = new SqlDataAdapter(comm);
                    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                    //Insert command
                    adapter.InsertCommand = cmdBuilder.GetInsertCommand();
                    //Update command
                    adapter.UpdateCommand = cmdBuilder.GetUpdateCommand();
                    //Delete command
                    adapter.DeleteCommand = cmdBuilder.GetDeleteCommand();
                    adapter.Fill(this);
                }
                else
                {
                    SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
                    SqlCommand comm = new SqlCommand(procedureName, conn);
                    comm.CommandType = CommandType.Text;
                    adapter = new SqlDataAdapter(comm);
                    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                    //Insert command
                    adapter.InsertCommand = cmdBuilder.GetInsertCommand();
                    //Update command
                    adapter.UpdateCommand = cmdBuilder.GetUpdateCommand();
                    //Delete command
                    adapter.DeleteCommand = cmdBuilder.GetDeleteCommand();
                    adapter.Fill(this);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DA_DataTable RowToDA_DataTable(DataRow[] dtrow)
        {

            DA_DataTable dtTable = new DA_DataTable();
            if (dtrow.Length > 0)
            {
                foreach (DataColumn col in dtrow[0].Table.Columns)
                {
                    dtTable.Columns.Add(col.Caption);
                }

                for (int i = 0; i < dtrow.Length; i++)
                {

                    DataRow dtrNewRow = dtTable.NewRow();
                    for (int j = 0; j < dtTable.Columns.Count; j++)
                    {
                        dtrNewRow[j] = dtrow[i][j].ToString();

                    }
                    dtTable.Rows.Add(dtrNewRow);
                }
            }
            return dtTable;
        }
        public DA_DataTable RowToDA_DataTable(DataRow dtrow)
        {

            DA_DataTable dtTable = new DA_DataTable();

            if (dtrow != null)
            {
                foreach (DataColumn col in dtrow.Table.Columns)
                {
                    dtTable.Columns.Add(col.Caption);
                }

                DataRow dtrNewRow = dtTable.NewRow();
                for (int j = 0; j < dtTable.Columns.Count; j++)
                {
                    dtrNewRow[j] = dtrow[j].ToString();

                }
                dtTable.Rows.Add(dtrNewRow);
            }
            return dtTable;
        }
        public DA_DataTable RowFilter(string strFilter)
        {
            if (strFilter.Trim() != "")
            {

                DataRow[] row = this.Select(strFilter);
                return RowToDA_DataTable(row);
            }
            else
            {
                return this;
            }

        }
        //Update

        public void Update() { adapter.Update(this); }
        #endregion
        #region Property
        public SqlDataAdapter Adapter { get { return adapter; } }
        #endregion
        #region Event

        #endregion



        
        
       

        
        
    }
}
