//this file was written by CenDoy
//purpose: create a toolkit to make easy to work with database
using System;
using DevExpress.XtraGrid.Views.Base;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.Collections;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Toolkit
{
    public enum ADD_ROW_ENUM
    {
        VALUES_ONLY, FIELDS_AND_VALUE
    }

    public class Tk_Elem
    {
        public String field;
        public Control control;
        public String value;

        public Tk_Elem(String value)
        {
            this.value = value;
        }

        public Tk_Elem(String field, String value)
        {
            this.field = field;
            this.value = value;
        }

        public Tk_Elem(String field, Control control)
        {
            this.field = field;
            this.control = control;
        }
    }

    class Tk_ControlFilterInfo
    {
        public ColumnView view;        
        public String displayField;
        public String memberField;
        public bool hasAddItem;

        public Tk_ControlFilterInfo(ColumnView gr, String displayField, String memberField, bool hasAddItem)
        {
            this.view = gr;
            this.displayField = displayField;
            this.memberField = memberField;
            this.hasAddItem = hasAddItem;
        }        
    }

    public static class DbToolKit
    {
        private static String _server, _db, _username, _password;
        private static SqlConnection conn;
        private static SqlDataAdapter da;
        private static SqlDataReader reader;
        private static DataTable dt;
        private static String connStr;
        private static SqlCommand com;
        private static DataRow _old;
        private static bool msgBoxTurnOn = true;
        #region private function
        //this is used to extract username, password, databasename, server from connection string
        private static void ShowError(string err)
        {
            MessageBox.Show(err);
        }

        private static void SplitConnStr(string s)
        {
            String[] arr = s.Split(';');
            foreach (string m in arr)
            {
                if (m.IndexOf("Source") > 0 && m.IndexOf("Data") >= 0)
                {
                    _server = m.Substring(m.IndexOf("=") + 1).Trim();
                }
                else if (m.IndexOf("Initial") >= 0 && m.IndexOf("Catalog") > 0)
                {
                    _db = m.Substring(m.IndexOf("=") + 1).Trim();
                }
                else if (m.IndexOf("User") >= 0 && m.IndexOf("ID") > 0)
                {
                    _username = m.Substring(m.IndexOf("=") + 1).Trim();
                }
                else if (m.IndexOf("Password") >= 0)
                {
                    _password = m.Substring(m.IndexOf("=") + 1).Trim();
                }
            }
        }
        //update connection string
        private static void UpdateConnStr()
        {
            connStr = "Data Source=" + _server + ";Initial Catalog=" + _db + ";User Id=" + _username + ";Password=" + _password + ";";
        }
        //open current connection
        private static void OpenConnection()
        {
            if (conn == null) ReConnect();
            if (conn.State == ConnectionState.Closed) conn.Open();
        }
        //close the connection avoid flush database
        private static void CloseConnection()
        {
            if (conn == null) return;
            conn.Close();
        }
        #endregion private function
        //properties
        public static bool MsgBoxTurnOn
        {
            set { msgBoxTurnOn = value; }
            get { return msgBoxTurnOn; }
        }
        //set string to connect to server
        public static String ConnectionString
        {
            get{ return connStr; }
            set { SplitConnStr(value); connStr = value; }
        }
        //set server name
        public static String ServerName
        {
            set { _server = value; UpdateConnStr(); }
            get { return _server; }
        }
        //set or get database name
        public static String DatabaseName
        {
            set { _db = value; UpdateConnStr(); }
            get { return _db; }
        }
        //set or get username
        public static string Username
        {
            set { _username = value; UpdateConnStr(); }
            get { return _username; }
        }
        //set or get password
        public static string Password
        {
            set { _password = value; UpdateConnStr(); }
            get { return _password; }
        }
        //connect
        public static bool ReConnect()
        {
            try
            {
                conn = new SqlConnection(ConnectionString);
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                if (msgBoxTurnOn) MessageBox.Show(ex.Message);
                return false;
            }
        }
        //check data
        public static bool IsDataOfSqlExists(string sql)
        {
            DataRow r = OpenSqlGetFirstRow(sql);
            return (r != null);
        }
        //insert, update, delete data
        public static bool ExecSql(string sql)
        {
            try
            {
                OpenConnection();
                com = new SqlCommand(sql, conn);
                com.ExecuteNonQuery();
                CloseConnection();
                return true;
            }
            catch(Exception ex)
            {
                if (msgBoxTurnOn) MessageBox.Show(ex.Message);
                return false;
            }            
        }
        //get data from database
        public static bool OpenSql(string sql)
        {
            try
            {
                OpenConnection();
                com = new SqlCommand(sql, conn);
                reader = com.ExecuteReader();
                reader.Read();
                CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                if (msgBoxTurnOn) MessageBox.Show(ex.Message);
                return false; 
            }
        }
        //get data return datatable
        public static DataTable OpenSqlReturnTable(string sql)
        {
            try
            {
                OpenConnection();
                da = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                da.Fill(dt);
                CloseConnection();
                return dt;                
            }
            catch (Exception ex)
            {                
                if (msgBoxTurnOn) MessageBox.Show(ex.Message);
                return null;
            }            
        }
        //get first row
        public static DataRow OpenSqlGetFirstRow(string sql)
        {
            try
            {                
                OpenSqlReturnTable(sql);
                if (dt == null || dt.Rows.Count == 0) return null;
                return dt.Rows[0];
            }
            catch { return null; }
        }
        public static bool CheckEmpty(Control c, String message)
        {
            if (c is LookUpEdit)
            {
                if (((LookUpEdit)c).EditValue == null)
                {
                    MessageBox.Show(message);
                    return false;
                }
            }
            if (c.Text.Length == 0)
            {
                MessageBox.Show(message);
                return false;
            }
            return true;
        }
        //function to add new row
        public static void AddRow(DataTable tbl, ADD_ROW_ENUM mode , params String[] value)
        {
            try
            {
                DataRow r = tbl.NewRow();
                if (mode == ADD_ROW_ENUM.VALUES_ONLY)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        r[i] = value[i];
                    }
                }
                else
                {
                    for (int i = 0; i < value.Length; i += 2)
                    {
                        r[value[i]] = value[i + 1];
                    }
                }
                tbl.Rows.Add(r);
            }
            catch (Exception ex)
            {
                if (msgBoxTurnOn) MessageBox.Show(ex.Message);
            }
        }        

        //function to show col of table
        public static void MakeColumnVisible(ColumnView view, String ColumnsName)
        {
            try
            {
                String[] arr = ColumnsName.Split(',');
                Hashtable hst = new Hashtable();
                foreach (String s in arr) hst.Add(s.Trim().ToUpper(), null);
                foreach (GridColumn col in view.Columns)
                    col.Visible = hst.ContainsKey(col.Caption.ToUpper());
            }
            catch (Exception ex)
            {
                if (msgBoxTurnOn) MessageBox.Show(ex.Message);
            }
        }
        //new table with field
        public static DataTable NewTable(String TableName, String ColumnName)
        {
            DataTable ret = null;
            try
            {
                ret = new DataTable(TableName);
                String[] arr = ColumnName.Split(',');
                foreach (String s in arr)
                {
                    DataColumn col = new DataColumn(s.Trim());
                    ret.Columns.Add(col);
                }
            }
            catch (Exception ex)
            {
                if (msgBoxTurnOn) MessageBox.Show(ex.Message);
            }
            return ret;
        }
        //get field of first row
        public static String OpenSqlGetFirstFieldData(string sql, string field)
        {
            try
            {
                DataRow r = OpenSqlGetFirstRow(sql);
                return r[field].ToString();
            }
            catch { return null; }
        }
        //Load data to LookupEdit, you have to put LookupEdit, string sql to get database, field name that will be displayed on form, the field is visibled, and value field
        public static bool LoadDataToLookupEdit(LookUpEdit lue, string sql, string displayField, string visisibleField, string valueField)
        {
            ArrayList arr = new ArrayList();
            arr.Add(visisibleField);
            return LoadDataToLookupEdit(lue, sql, displayField, arr, valueField);
        }

        public static bool LoadDataToLookupEdit(LookUpEdit lue, string sql, string displayField, ArrayList visisibleField, string valueField, string addNewItem)
        {
            ArrayList arr = new ArrayList();
            arr.Add(addNewItem);
            return LoadDataToLookupEdit(lue, sql, displayField, visisibleField, valueField, arr);
        }

        public static bool LoadDataToLookupEdit(LookUpEdit lue, string sql, string displayField, string visisibleField, string valueField, string addNewItem)
        {
            ArrayList arr = new ArrayList();
            arr.Add(visisibleField);
            return LoadDataToLookupEdit(lue, sql, displayField, arr, valueField, addNewItem);
        }

        public static bool LoadDataToLookupEdit(LookUpEdit lue, DataTable dt, string displayField, string visisibleField, string valueField)
        {
            ArrayList arr = new ArrayList();
            arr.Add(visisibleField);
            return LoadDataToLookupEdit(lue, dt, displayField, arr, valueField, null);
        }

        public static bool LoadDataToLookupEdit(LookUpEdit lue, string sql, string displayField, ArrayList visisibleField, string valueField)
        {
            ArrayList arr = null;
            return LoadDataToLookupEdit(lue, sql, displayField, visisibleField, valueField, arr);
        }
        //
        public static bool LoadDataToLookupEdit(LookUpEdit lue, DataTable table, string displayField, ArrayList visisibleField, string valueField, ArrayList addNewItem)
        {
            try
            {
                if (addNewItem != null)
                {
                    foreach (string s in addNewItem)
                    {
                        DataRow r = dt.NewRow();
                        r[displayField] = s;
                        r[valueField] = "";
                        dt.Rows.InsertAt(r, 0);
                    }
                }
                lue.Properties.DataSource = table;
                lue.Properties.PopulateColumns();
                foreach (LookUpColumnInfo col in lue.Properties.Columns) col.Visible = false;
                lue.Properties.Columns[displayField].Visible = true;
                foreach (string s in visisibleField) if (s.Length > 0) lue.Properties.Columns[s].Visible = true;
                lue.Properties.DisplayMember = displayField;
                lue.Properties.ValueMember = valueField;
                lue.Refresh();
                return true;
            }
            catch (Exception ex)
            {
                if (msgBoxTurnOn) MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static void SetFilterControl(LookUpEdit lue, ColumnView view, string diplayField, String memberField, bool hasAllRecordItem)
        {            
            lue.Tag = new Tk_ControlFilterInfo(view, diplayField, memberField, hasAllRecordItem);
            lue.EditValueChanged += new EventHandler(lue_EditValueChanged);
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn(diplayField));
            if (diplayField != memberField)
                dt.Columns.Add(new DataColumn(memberField));
            lue.Properties.DataSource = view.DataSource;
            for (int i = 0; i < view.RowCount; i++)
            {
                
            }
        }

        public static void lue_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lue = sender as LookUpEdit;
            Tk_ControlFilterInfo info = lue.Tag as Tk_ControlFilterInfo;
            ColumnFilterInfo filter = new ColumnFilterInfo(ColumnFilterType.Value, null, info.memberField + "='" + lue.EditValue + "'", info.memberField + "='" + lue.EditValue + "'");                        

            if (info.hasAddItem && lue.EditValue == "")
                info.view.Columns[info.memberField].ClearFilter();
            else
                info.view.Columns[info.memberField].FilterInfo = filter;
        }

        public static bool LoadDataToLookupEdit(LookUpEdit lue, ColumnView bv, string displayField, string memberField)
        {
            try
            {
                DataTable newTbl = new DataTable();
                newTbl.Columns.Add(new DataColumn(displayField));
                bool bNotSame = (displayField != memberField);
                if (bNotSame)
                    newTbl.Columns.Add(new DataColumn(memberField));
                for (int i = 0; i < bv.RowCount; i++)
                {
                    DataRow r = bv.GetDataRow(i);
                    DataRow newRow = newTbl.NewRow();
                    newRow[displayField] = r[displayField];
                    if (bNotSame) newRow[memberField] = r[memberField];
                    newTbl.Rows.Add(newRow);
                }
                lue.Properties.DataSource = newTbl;
                lue.Properties.DisplayMember = displayField;
                lue.Properties.ValueMember = memberField;
                lue.Properties.PopulateColumns();
                return true;
            }
            catch (Exception ex)
            {
                if (msgBoxTurnOn) MessageBox.Show(ex.Message);
                return false;
            }
        }
        //get all record of field and load to LookupEdit
        public static bool LoadDataToLookupEdit(LookUpEdit lue, string sql, string displayField, ArrayList visisibleField, string valueField, ArrayList addNewItem)
        {            
                if (!sql.Substring(0, 6).ToUpper().Equals("SELECT")) sql = "SELECT * FROM " + sql;
                return LoadDataToLookupEdit(lue, OpenSqlReturnTable(sql), displayField, visisibleField, valueField, addNewItem);
        }

        public static bool LoadSqlToControls(string sql, params Tk_Elem[] elems)
        {
            try
            {
                _old = OpenSqlGetFirstRow(sql);
                foreach (Tk_Elem e in elems)
                {
                    string value;
                    Control c = e.control;                   
                    try
                    {
                        value = _old[e.field].ToString();
                        if (c is LookUpEdit)
                            ((LookUpEdit)c).EditValue = value;
                        else
                            c.Text = value;
                    }
                    catch
                    {
                        MessageBox.Show("Field :" + e.field + " is not available");
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                if (msgBoxTurnOn) MessageBox.Show(ex.Message);
                return false; 
            }
        }

        public static string GetMaxOfField(String table, String field)
        {
            String max = OpenSqlGetFirstFieldData("SELECT MAX(" + field + ") as No FROM " + table, "No");
            if (max.Length == 0) return "";
            else return max;
        }

        //this will be used to update selected index of a lookupedit
        public static bool UpdateSelectedIndex(LookUpEdit lue, DataRow r, String field)
        {
            try
            {
                lue.EditValue = r[field].ToString();
                return true;
            }
            catch(Exception ex)
            {
                if (msgBoxTurnOn) MessageBox.Show(ex.Message);
                return false;
            }
        }
        //update selected index used result of above action
        public static bool UpdateSelectedIndex(LookUpEdit lue, string field)
        {
            return UpdateSelectedIndex(lue, _old, field);
        }

        public static bool InsertToTable(String table, params Tk_Elem[] elem)
        {            
            String sql = "INSERT INTO " + table + " VALUES(";
            foreach (Tk_Elem e in elem)
            {
                String sub;
                if (e.control == null)
                {
                    sub = "'" + e.value + "'";
                }
                else
                {
                    Control c = e.control;
                    if (c is LookUpEdit)
                    {
                        if (c.Enabled)
                        {
                            
                            if (((LookUpEdit)c).EditValue == null)
                                sub = "null";
                            else
                                sub = "'" + ((LookUpEdit)c).EditValue.ToString() + "'";
                        }
                        else
                        {
                            sub = "null";
                        }
                    }
                    else
                        sub = "'" + c.Text + "'";
                }
                sql = sql + sub + ",";
            }
            sql = sql.Remove(sql.Length - 1) + ")";
            return ExecSql(sql);
        }

        public static bool UpdateTable(String table, String where, params Tk_Elem[] elem)
        {
            String sql = "UPDATE " + table + " SET ";
            foreach (Tk_Elem e in elem)
            {
                String sub = "";
                if (e.control == null)
                {
                    if (e.field.Length == 0)
                        sub = e.value;
                    else
                        sub = e.field + "='" + e.value + "'";
                }
                else
                {
                    Control c = e.control;
                    if (c is LookUpEdit)
                    {
                        if (c.Enabled)
                        {
                            if (((LookUpEdit)c).EditValue == null)
                            {
                                sub = "[" + e.field + "]=null";
                            }
                            else
                                sub = "[" + e.field + "]='" + ((LookUpEdit)c).EditValue.ToString() + "'";
                        }
                        else
                            sub = "[" + e.field + "]=null";
                    }
                    else
                        sub = "[" + e.field + "]='" + c.Text + "'";
                }
                sql = sql + sub + ",";
            }
            sql += where;
            return ExecSql(sql);
        }
    }
}
