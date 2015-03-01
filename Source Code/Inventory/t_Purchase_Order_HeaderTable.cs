/*******************************************************************
*t_Purchase_Order_Header interaction
* Created by Turbo Database copy right by DuongNT (g8 company)
* Date: Wednesday, April 04, 2007
*******************************************************************/
using System.Data;
using System.Data.SqlClient;

namespace Inventory
{
    public class t_Purchase_Order_HeaderTable : DataTable
    {
        private t_Purchase_Order_HeaderRec trecRows = new t_Purchase_Order_HeaderRec();
        private SqlConnection sqlConnection;
        private SqlDataAdapter adapter;
        public t_Purchase_Order_HeaderTable(SqlConnection conn) : base()
        {
            
            sqlConnection = conn;
            adapter = new SqlDataAdapter("SELECT * FROM [t_Purchase_Order_Header]", sqlConnection);
            
            //Insert command
            adapter.InsertCommand = new SqlCommand();
            adapter.InsertCommand.CommandText = "INSERT INTO [t_Purchase_Order_Header] ([PONo],[PODate],[POTypeID],[DeliveryDate],[ShipTo],[SupplierID],[TotalAmt],[AccountNo],[Tax_code_id],[Discount],[Shipping],[SupplierTermsID],[Notes],[CreatedBy],[CreatedDate],[LastUpdatedBy],[LastUpdatedDate],[ViewStatus]) VALUES ( @PONo, @PODate, @POTypeID, @DeliveryDate, @ShipTo, @SupplierID, @TotalAmt, @AccountNo, @Tax_code_id, @Discount, @Shipping, @SupplierTermsID, @Notes, @CreatedBy, @CreatedDate, @LastUpdatedBy, @LastUpdatedDate, @ViewStatus);";
            adapter.InsertCommand.Connection = sqlConnection;
            adapter.InsertCommand.Parameters.Add("@PONo", SqlDbType.NVarChar);
            adapter.InsertCommand.Parameters.Add("@PODate", SqlDbType.DateTime);
            adapter.InsertCommand.Parameters.Add("@POTypeID", SqlDbType.NVarChar);
            adapter.InsertCommand.Parameters.Add("@DeliveryDate", SqlDbType.DateTime);
            adapter.InsertCommand.Parameters.Add("@ShipTo", SqlDbType.NVarChar);
            adapter.InsertCommand.Parameters.Add("@SupplierID", SqlDbType.NVarChar);
            adapter.InsertCommand.Parameters.Add("@TotalAmt", SqlDbType.Decimal);
            adapter.InsertCommand.Parameters.Add("@AccountNo", SqlDbType.NVarChar);
            adapter.InsertCommand.Parameters.Add("@Tax_code_id", SqlDbType.NVarChar);
            adapter.InsertCommand.Parameters.Add("@Discount", SqlDbType.Decimal);
            adapter.InsertCommand.Parameters.Add("@Shipping", SqlDbType.Decimal);
            adapter.InsertCommand.Parameters.Add("@SupplierTermsID", SqlDbType.NVarChar);
            adapter.InsertCommand.Parameters.Add("@Notes", SqlDbType.NVarChar);
            adapter.InsertCommand.Parameters.Add("@CreatedBy", SqlDbType.NVarChar);
            adapter.InsertCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime);
            adapter.InsertCommand.Parameters.Add("@LastUpdatedBy", SqlDbType.NVarChar);
            adapter.InsertCommand.Parameters.Add("@LastUpdatedDate", SqlDbType.DateTime);
            adapter.InsertCommand.Parameters.Add("@ViewStatus", SqlDbType.Bit);
            foreach (SqlParameter pr in adapter.InsertCommand.Parameters) pr.Value = null;
            
            //Update command
            adapter.UpdateCommand = new SqlCommand();
            adapter.UpdateCommand.CommandText = "UPDATE [t_Purchase_Order_Header] SET [PONo] = @PONo,[PODate] = @PODate,[POTypeID] = @POTypeID,[DeliveryDate] = @DeliveryDate,[ShipTo] = @ShipTo,[SupplierID] = @SupplierID,[TotalAmt] = @TotalAmt,[AccountNo] = @AccountNo,[Tax_code_id] = @Tax_code_id,[Discount] = @Discount,[Shipping] = @Shipping,[SupplierTermsID] = @SupplierTermsID,[Notes] = @Notes,[CreatedBy] = @CreatedBy,[CreatedDate] = @CreatedDate,[LastUpdatedBy] = @LastUpdatedBy,[LastUpdatedDate] = @LastUpdatedDate,[ViewStatus] = @ViewStatus WHERE 1 < 0;";
            adapter.UpdateCommand.Connection = sqlConnection;
            adapter.UpdateCommand.Parameters.Add("@PONo", SqlDbType.NVarChar);
            adapter.UpdateCommand.Parameters.Add("@PODate", SqlDbType.DateTime);
            adapter.UpdateCommand.Parameters.Add("@POTypeID", SqlDbType.NVarChar);
            adapter.UpdateCommand.Parameters.Add("@DeliveryDate", SqlDbType.DateTime);
            adapter.UpdateCommand.Parameters.Add("@ShipTo", SqlDbType.NVarChar);
            adapter.UpdateCommand.Parameters.Add("@SupplierID", SqlDbType.NVarChar);
            adapter.UpdateCommand.Parameters.Add("@TotalAmt", SqlDbType.Decimal);
            adapter.UpdateCommand.Parameters.Add("@AccountNo", SqlDbType.NVarChar);
            adapter.UpdateCommand.Parameters.Add("@Tax_code_id", SqlDbType.NVarChar);
            adapter.UpdateCommand.Parameters.Add("@Discount", SqlDbType.Decimal);
            adapter.UpdateCommand.Parameters.Add("@Shipping", SqlDbType.Decimal);
            adapter.UpdateCommand.Parameters.Add("@SupplierTermsID", SqlDbType.NVarChar);
            adapter.UpdateCommand.Parameters.Add("@Notes", SqlDbType.NVarChar);
            adapter.UpdateCommand.Parameters.Add("@CreatedBy", SqlDbType.NVarChar);
            adapter.UpdateCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime);
            adapter.UpdateCommand.Parameters.Add("@LastUpdatedBy", SqlDbType.NVarChar);
            adapter.UpdateCommand.Parameters.Add("@LastUpdatedDate", SqlDbType.DateTime);
            adapter.UpdateCommand.Parameters.Add("@ViewStatus", SqlDbType.Bit);
            foreach (SqlParameter pr in adapter.UpdateCommand.Parameters) pr.Value = null;
            
            //Delete command
            adapter.DeleteCommand = new SqlCommand();
            adapter.DeleteCommand.CommandText = "DELETE [t_Purchase_Order_Header] WHERE 1 < 0";
            adapter.DeleteCommand.Connection = sqlConnection;
            adapter.DeleteCommand.Parameters.Add("@PONo", SqlDbType.NVarChar);
            adapter.DeleteCommand.Parameters.Add("@PODate", SqlDbType.DateTime);
            adapter.DeleteCommand.Parameters.Add("@POTypeID", SqlDbType.NVarChar);
            adapter.DeleteCommand.Parameters.Add("@DeliveryDate", SqlDbType.DateTime);
            adapter.DeleteCommand.Parameters.Add("@ShipTo", SqlDbType.NVarChar);
            adapter.DeleteCommand.Parameters.Add("@SupplierID", SqlDbType.NVarChar);
            adapter.DeleteCommand.Parameters.Add("@TotalAmt", SqlDbType.Decimal);
            adapter.DeleteCommand.Parameters.Add("@AccountNo", SqlDbType.NVarChar);
            adapter.DeleteCommand.Parameters.Add("@Tax_code_id", SqlDbType.NVarChar);
            adapter.DeleteCommand.Parameters.Add("@Discount", SqlDbType.Decimal);
            adapter.DeleteCommand.Parameters.Add("@Shipping", SqlDbType.Decimal);
            adapter.DeleteCommand.Parameters.Add("@SupplierTermsID", SqlDbType.NVarChar);
            adapter.DeleteCommand.Parameters.Add("@Notes", SqlDbType.NVarChar);
            adapter.DeleteCommand.Parameters.Add("@CreatedBy", SqlDbType.NVarChar);
            adapter.DeleteCommand.Parameters.Add("@CreatedDate", SqlDbType.DateTime);
            adapter.DeleteCommand.Parameters.Add("@LastUpdatedBy", SqlDbType.NVarChar);
            adapter.DeleteCommand.Parameters.Add("@LastUpdatedDate", SqlDbType.DateTime);
            adapter.DeleteCommand.Parameters.Add("@ViewStatus", SqlDbType.Bit);
            foreach (SqlParameter pr in adapter.DeleteCommand.Parameters) pr.Value = null;
            adapter.Fill(this);
        }
        public t_Purchase_Order_HeaderRec this[int index]
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
