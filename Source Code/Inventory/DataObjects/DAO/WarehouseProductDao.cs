using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Inventory.DataObjects.DAO
{
    public class WarehouseProductDao : DBInteractionBase
    {
        public DataTable SelectOneByWarehouseProduct(SqlCommand scmCmdToExecute, WarehouseProductMaster objWhProd, string strWarehouse, string strProduct)
        {
            scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "select * from WarehouseProductMaster where Warehouse_id = '" + strWarehouse + "' and Product_id = '" + strProduct + "'";
            scmCmdToExecute.CommandType = CommandType.Text;
            DataTable dtToReturn = new DataTable("WarehouseProduct");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Open connection.
                    m_scoMainConnection.Open();
                }
                else
                {
                    if (m_cpMainConnectionProvider.bIsTransactionPending)
                    {
                        scmCmdToExecute.Transaction = m_cpMainConnectionProvider.stCurrentTransaction;
                    }
                }

                // Execute query.
                sdaAdapter.Fill(dtToReturn);

                if (dtToReturn.Rows.Count > 0)
                {
                    objWhProd.ID = (string)dtToReturn.Rows[0]["ID"];
                    objWhProd.Warehouse_id = (string)dtToReturn.Rows[0]["Warehouse_id"];
                    objWhProd.Product_id = (string)dtToReturn.Rows[0]["Product_id"];
                    objWhProd.Package_Code = dtToReturn.Rows[0]["Package Code"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Package Code"];
                    objWhProd.Product_weight = dtToReturn.Rows[0]["Product_weight"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Product_weight"];
                    objWhProd.Wide = dtToReturn.Rows[0]["Wide"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Wide"];
                    objWhProd.Length = dtToReturn.Rows[0]["Length"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Length"];
                    objWhProd.High = dtToReturn.Rows[0]["High"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["High"];
                    objWhProd.Pack_weight = dtToReturn.Rows[0]["Pack weight"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Pack weight"];
                    objWhProd.Storage_Unit = dtToReturn.Rows[0]["Storage_Unit"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Storage_Unit"];
                    objWhProd.Qty_prod_pack = dtToReturn.Rows[0]["Qty_prod_pack"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Qty_prod_pack"];
                    objWhProd.On_hand_qty = dtToReturn.Rows[0]["On_hand_qty"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["On_hand_qty"];
                    objWhProd.Date_created = dtToReturn.Rows[0]["Date_created"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Date_created"];
                    objWhProd.Date_last_Receipt = dtToReturn.Rows[0]["Date_last_Receipt"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Date_last_Receipt"];
                    objWhProd.Date_last_picked = dtToReturn.Rows[0]["Date_last_picked"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Date_last_picked"];
                    objWhProd.Date_qty_zero = dtToReturn.Rows[0]["Date_qty_zero"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Date_qty_zero"];
                    objWhProd.Date_last_count = dtToReturn.Rows[0]["Date_last_count"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Date_last_count"];
                    objWhProd.UserID = dtToReturn.Rows[0]["UserID"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["UserID"];
                    objWhProd.Timestamp = dtToReturn.Rows[0]["Timestamp"] == System.DBNull.Value ? SqlBinary.Null : (byte[])dtToReturn.Rows[0]["Timestamp"];
                }

                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("WarehouseProductMaster::SelectAll::Error occured.", ex);
            }
            finally
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    m_scoMainConnection.Close();
                }
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
    }
}
