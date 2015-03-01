using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Inventory.DataObjects.DAO
{
    public class ProductLocationDao : DBInteractionBase
    {
        internal DataTable SelectOneByLocationProduct(SqlCommand scmCmdToExecute, ProductLocation objProLoc, string strLocation, string strProduct)
        {
            scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "select * from ProductLocation where LocationID = '" + strLocation + "' and ProductID = '" + strProduct + "'";
            scmCmdToExecute.CommandType = CommandType.Text;
            DataTable dtToReturn = new DataTable("ProductLocation");
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
                    objProLoc.ID = (string)dtToReturn.Rows[0]["ID"];
                    objProLoc.ProductID = (string)dtToReturn.Rows[0]["ProductID"];
                    objProLoc.LocationID = dtToReturn.Rows[0]["LocationID"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["LocationID"];
                    objProLoc.Qty_on_hand = dtToReturn.Rows[0]["Qty_on_hand"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Qty_on_hand"];
                    objProLoc.Qty_allocated = dtToReturn.Rows[0]["Qty_allocated"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Qty_allocated"];
                    objProLoc.Date_last_unpack = dtToReturn.Rows[0]["Date_last_unpack"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Date_last_unpack"];
                    objProLoc.Date_last_picked = dtToReturn.Rows[0]["Date_last_picked"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Date_last_picked"];
                    objProLoc.Qty_unpack = dtToReturn.Rows[0]["Qty_unpack"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Qty_unpack"];
                }

                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("ProductLocation::SelectAll::Error occured.", ex);
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
