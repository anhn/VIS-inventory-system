/*******************************************************************
*t_Sales_Order_Header interaction
* Created by Turbo Database copy right by DuongNT (g8 company)
* Date: Wednesday, April 04, 2007
*******************************************************************/
using System.Data;
using System.Data.SqlClient;

namespace Inventory
{
    public class t_Sales_Order_HeaderTable : DataTable
    {
        private t_Sales_Order_HeaderRec trecRows = new t_Sales_Order_HeaderRec();
        private SqlConnection sqlConnection;
        private SqlDataAdapter adapter;
        public SqlDataAdapter Adapter { get {return adapter;} }
        public void ReSelect(string strSQL) {adapter.SelectCommand.CommandText = strSQL; }
        public t_Sales_Order_HeaderTable(SqlConnection conn) : base()
        {
            sqlConnection = conn;
            adapter = new SqlDataAdapter("SELECT * FROM [t_Sales_Order_Header]", sqlConnection);
            
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
            //Insert command
            adapter.InsertCommand = cmdBuilder.GetInsertCommand();
            
            //Update command
            adapter.UpdateCommand = cmdBuilder.GetUpdateCommand();
            
            //Delete command
            adapter.DeleteCommand = cmdBuilder.GetDeleteCommand();
            adapter.Fill(this);
        }
        public t_Sales_Order_HeaderRec this[int index]
        {
            get
            {
                trecRows.AssignFromDataRow(this.Rows[index]);
                return trecRows;
            }
            set
            {
                value.AssignToDataRow(this.Rows[index]);
            }
        }
        //Row count
        public int RowCount {get {return this.Rows.Count;}}
        
        //Update
        public void Update() {adapter.Update(this);}
    }
}
