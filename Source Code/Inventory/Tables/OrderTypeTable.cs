/*******************************************************************
*OrderType interaction
* Created by Turbo Database copy right by DuongNT (g8 company)
* Date: Wednesday, April 04, 2007
*******************************************************************/
using System.Data;
using System.Data.SqlClient;

namespace Inventory
{
    public class OrderTypeTable : DataTable
    {
        private OrderTypeRec trecRows = new OrderTypeRec();
        private SqlConnection sqlConnection;
        private SqlDataAdapter adapter;
        public SqlDataAdapter Adapter { get {return adapter;} }
        public void ReSelect(string strSQL) {adapter.SelectCommand.CommandText = strSQL; }
        public OrderTypeTable(SqlConnection conn) : base()
        {
            sqlConnection = conn;
            adapter = new SqlDataAdapter("SELECT * FROM [OrderType]", sqlConnection);
            
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
            //Insert command
            adapter.InsertCommand = cmdBuilder.GetInsertCommand();
            
            //Update command
            adapter.UpdateCommand = cmdBuilder.GetUpdateCommand();
            
            //Delete command
            adapter.DeleteCommand = cmdBuilder.GetDeleteCommand();
            adapter.Fill(this);
        }
        public OrderTypeRec this[int index]
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
