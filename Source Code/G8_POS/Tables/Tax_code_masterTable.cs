/*******************************************************************
*Tax_code_master interaction
* Created by DuongNT (g8 company)
* Date: Sunday, June 17, 2007
*******************************************************************/
using System.Data;
using System.Data.SqlClient;
namespace G8_POS
{
    public class Tax_code_masterTable : DataTable
    {
        private Tax_code_masterRec trecRows = new Tax_code_masterRec();
        private SqlConnection sqlConnection;
        private SqlDataAdapter adapter;
        public SqlDataAdapter Adapter { get {return adapter;} }
        public void ReSelect(string strSQL) {this.Clear(); adapter.SelectCommand.CommandText = "SELECT * FROM [Tax_code_master] WHERE " + strSQL; adapter.Fill(this); }
        public Tax_code_masterTable(SqlConnection conn) : base()
        {
            sqlConnection = conn;
            adapter = new SqlDataAdapter("SELECT * FROM [Tax_code_master]", sqlConnection);
            
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
            //Insert command
            adapter.InsertCommand = cmdBuilder.GetInsertCommand();
            
            //Update command
            adapter.UpdateCommand = cmdBuilder.GetUpdateCommand();
            
            //Delete command
            adapter.DeleteCommand = cmdBuilder.GetDeleteCommand();
            adapter.Fill(this);
        }
        public Tax_code_masterRec this[int index]
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
        public void Update() {
            try
            {
                adapter.Update(this);
            }
            catch { }
        }
    }
}
