/*******************************************************************
*TaxType interaction
* Created by DuongNT (g8 company)
* Date: Sunday, June 17, 2007
*******************************************************************/
using System.Data;
using System.Data.SqlClient;

namespace G8_POS
{
    public class TaxTypeTable : DataTable
    {
        private TaxTypeRec trecRows = new TaxTypeRec();
        private SqlConnection sqlConnection;
        private SqlDataAdapter adapter;
        public SqlDataAdapter Adapter { get {return adapter;} }
        public void ReSelect(string strSQL) {this.Clear(); adapter.SelectCommand.CommandText = "SELECT * FROM [TaxType] WHERE " + strSQL; adapter.Fill(this); }
        public TaxTypeTable(SqlConnection conn) : base()
        {
            sqlConnection = conn;
            adapter = new SqlDataAdapter("SELECT * FROM [TaxType]", sqlConnection);
            
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
            //Insert command
            adapter.InsertCommand = cmdBuilder.GetInsertCommand();
            
            //Update command
            adapter.UpdateCommand = cmdBuilder.GetUpdateCommand();
            
            //Delete command
            adapter.DeleteCommand = cmdBuilder.GetDeleteCommand();
            adapter.Fill(this);
        }
        public TaxTypeRec this[int index]
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
