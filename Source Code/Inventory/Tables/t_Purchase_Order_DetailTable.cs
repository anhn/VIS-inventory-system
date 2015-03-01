/*******************************************************************
*t_Purchase_Order_Detail interaction
* Created by Turbo Database copy right by DuongNT (g8 company)
* Date: Wednesday, April 04, 2007
*******************************************************************/
using System.Data;
using System.Data.SqlClient;

namespace Inventory
{
    public class t_Purchase_Order_DetailTable : DataTable
    {
        private string m_strSQL = "SELECT t_Purchase_Order_Detail.PONo, t_Purchase_Order_Detail.POLineNo,t_Purchase_Order_Detail.POProductID,ProductMaster.ProductName," +
                                  "t_Purchase_Order_Detail.POSupplierProduct, t_Purchase_Order_Detail.ProductUnit, t_Purchase_Order_Detail.PackQty," +
                                  "t_Purchase_Order_Detail.OrderQty,t_Purchase_Order_Detail.ReceiveQty,t_Purchase_Order_Detail.ViewStatus," +
                                  "t_Purchase_Order_Detail.UnitPrice,t_Purchase_Order_Detail.Warehouse_id,t_Purchase_Order_Detail.Location_id," +
                                  "t_Purchase_Order_Detail.Amount " + 
                                  "FROM t_Purchase_Order_Detail, ProductMaster " + 
                                  "Where ProductMaster.ProductID = t_Purchase_Order_Detail.POProductID";

        private t_Purchase_Order_DetailRec trecRows = new t_Purchase_Order_DetailRec();
        private SqlConnection sqlConnection;
        private SqlDataAdapter adapter;
        public SqlDataAdapter Adapter { get {return adapter;} }
        public void ReSelect(string strSQL) { this.Clear(); adapter.SelectCommand.CommandText = "Select * From t_Purchase_Order_Detail Where " + strSQL; adapter.Fill(this); }
        public t_Purchase_Order_DetailTable(SqlConnection conn) : base()
        {
            sqlConnection = conn;
            adapter = new SqlDataAdapter("Select * From t_Purchase_Order_Detail", sqlConnection);
            
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
            //Insert command
            adapter.InsertCommand = cmdBuilder.GetInsertCommand();
            
            //Update command
            adapter.UpdateCommand = cmdBuilder.GetUpdateCommand();            
            
            //Delete command
            adapter.DeleteCommand = cmdBuilder.GetDeleteCommand();            

            adapter.Fill(this);
        }
        public t_Purchase_Order_DetailRec this[int index]
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
