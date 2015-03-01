/*******************************************************************
*Payment_Term_Master interaction
* Created by Turbo Database copy right by DuongNT (g8 company)
* Date: Wednesday, April 04, 2007
*******************************************************************/
using System.Data;
using System.Data.SqlClient;

namespace Inventory
{
    public class Payment_Term_MasterTable : DataTable
    {
        private Payment_Term_MasterRec trecRows = new Payment_Term_MasterRec();
        private SqlConnection sqlConnection;
        private SqlDataAdapter adapter;
        public SqlDataAdapter Adapter { get {return adapter;} }
        public void ReSelect(string strSQL) {adapter.SelectCommand.CommandText = strSQL; }
        public Payment_Term_MasterTable(SqlConnection conn) : base()
        {
            sqlConnection = conn;
            adapter = new SqlDataAdapter("SELECT * FROM [PaymentTermMaster]", sqlConnection);
            
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
            //Insert command
            adapter.InsertCommand = cmdBuilder.GetInsertCommand();
            
            //Update command
            adapter.UpdateCommand = cmdBuilder.GetUpdateCommand();
            
            //Delete command
            adapter.DeleteCommand = cmdBuilder.GetDeleteCommand();
            adapter.Fill(this);
        }
        public Payment_Term_MasterRec this[int index]
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
