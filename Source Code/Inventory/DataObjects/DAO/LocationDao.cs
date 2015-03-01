using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Inventory.DataObjects.DAO
{
    class LocationDao : Location_Master
    {
        internal DataTable GetAllLocations()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "Select distinct bin_location_id, Warehouse_id from Location_Master";
            scmCmdToExecute.CommandType = CommandType.Text;
            DataTable dtToReturn = new DataTable("Location_Master");
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

                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("Location_Master::SelectAll::Error occured.", ex);
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


        internal DataTable GetAllLocationProduct()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "Select * from VLocationProductSelection";
            scmCmdToExecute.CommandType = CommandType.Text;
            DataTable dtToReturn = new DataTable("Location_Master");
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

                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("Location_Master::SelectAll::Error occured.", ex);
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

        

        public DataTable SelectLocationsOfWareHouse(String strWareHouseId)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "Select distinct Bin_Location_Id from Location_Master where Warehouse_id = '" + strWareHouseId + "'";
            scmCmdToExecute.CommandType = CommandType.Text;
            DataTable dtToReturn = new DataTable("Location_Master");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                //scmCmdToExecute.Parameters.AddWithValue(":WarehouseId", strWareHouseId);

                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                sdaAdapter.Fill(dtToReturn);

                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("Location_Master::Select By Warehouse::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="objLocationMaster"></param>
        /// <param name="strLocation"></param>
        /// <param name="strWarehouse"></param>
        /// <param name="strProduct"></param>
        /// <returns></returns>
        internal DataTable SelectOneByWarehouseLocationProduct(Location_Master objLocationMaster, string strLocation, string strWarehouse, string strProduct)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "select * from Location_Master where bin_location_id = '" + strLocation +
                "' and Warehouse_id = '" + strWarehouse + "'" + " and product_id = '" + strProduct + "'";
            scmCmdToExecute.CommandType = CommandType.Text;
            DataTable dtToReturn = new DataTable("Location_Master");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;
            

            try
            {
                // Open connection.
                m_scoMainConnection.Open();
                // Execute query.
                sdaAdapter.Fill(dtToReturn);

                if (dtToReturn.Rows.Count > 0)
                {
                    objLocationMaster.Warehouse_id = (string)dtToReturn.Rows[0]["Warehouse_id"];
                    objLocationMaster.Bin_location_id = (string)dtToReturn.Rows[0]["Bin_location_id"];
                    objLocationMaster.Sequence = (Int32)dtToReturn.Rows[0]["Sequence"];
                    objLocationMaster.Product_id = dtToReturn.Rows[0]["Product_id"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Product_id"];
                    objLocationMaster.Package_Code = dtToReturn.Rows[0]["Package Code"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Package Code"];
                    objLocationMaster.Qty_on_hand = dtToReturn.Rows[0]["Qty_on_hand"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Qty_on_hand"];
                    objLocationMaster.Qty_allocated = dtToReturn.Rows[0]["Qty_allocated"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Qty_allocated"];
                    objLocationMaster.Date_last_unpack = dtToReturn.Rows[0]["Date_last_unpack"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Date_last_unpack"];
                    objLocationMaster.Date_Last_Picked = dtToReturn.Rows[0]["Date_Last_Picked"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Date_Last_Picked"];
                    objLocationMaster.Reserved_code = dtToReturn.Rows[0]["Reserved_code"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Reserved_code"];
                    objLocationMaster.Reserved_Date = dtToReturn.Rows[0]["Reserved_Date"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Reserved_Date"];
                    objLocationMaster.Qty_unpack = dtToReturn.Rows[0]["Qty_unpack"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Qty_unpack"];
                    objLocationMaster.UserID = dtToReturn.Rows[0]["UserID"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["UserID"];
                    objLocationMaster.TimeStamp = dtToReturn.Rows[0]["TimeStamp"] == System.DBNull.Value ? SqlBinary.Null : (byte[])dtToReturn.Rows[0]["TimeStamp"];
                }
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("Location_Master::SelectOneByWarehouseLocationProduct::Error occured.", ex);
            }
            finally
            {
                //// Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

        /// <summary>
        /// Used in process that contains a lot of actions with DB in one transaction
        /// </summary>
        /// <param name="scmCmdToExecute"></param>
        /// <param name="objLocationMaster"></param>
        /// <param name="strLocation"></param>
        /// <param name="strWarehouse"></param>
        /// <param name="strProduct"></param>
        /// <returns></returns>
        internal DataTable SelectOneByWarehouseLocationProduct(SqlCommand scmCmdToExecute, Location_Master objLocationMaster, string strLocation, string strWarehouse, string strProduct)
        {

            scmCmdToExecute.CommandText = "select * from Location_Master where bin_location_id = '" + strLocation +
                "' and Warehouse_id = '" + strWarehouse + "'" + " and product_id = '" + strProduct + "'";
            scmCmdToExecute.CommandType = CommandType.Text;
            DataTable dtToReturn = new DataTable("Location_Master");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);


            try
            {
                // Execute query.
                sdaAdapter.Fill(dtToReturn);

                if (dtToReturn.Rows.Count > 0)
                {
                    objLocationMaster.Warehouse_id = (string)dtToReturn.Rows[0]["Warehouse_id"];
                    objLocationMaster.Bin_location_id = (string)dtToReturn.Rows[0]["Bin_location_id"];
                    objLocationMaster.Sequence = (Int32)dtToReturn.Rows[0]["Sequence"];
                    objLocationMaster.Product_id = dtToReturn.Rows[0]["Product_id"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Product_id"];
                    objLocationMaster.Package_Code = dtToReturn.Rows[0]["Package Code"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Package Code"];
                    objLocationMaster.Qty_on_hand = dtToReturn.Rows[0]["Qty_on_hand"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Qty_on_hand"];
                    objLocationMaster.Qty_allocated = dtToReturn.Rows[0]["Qty_allocated"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Qty_allocated"];
                    objLocationMaster.Date_last_unpack = dtToReturn.Rows[0]["Date_last_unpack"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Date_last_unpack"];
                    objLocationMaster.Date_Last_Picked = dtToReturn.Rows[0]["Date_Last_Picked"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Date_Last_Picked"];
                    objLocationMaster.Reserved_code = dtToReturn.Rows[0]["Reserved_code"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Reserved_code"];
                    objLocationMaster.Reserved_Date = dtToReturn.Rows[0]["Reserved_Date"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Reserved_Date"];
                    objLocationMaster.Qty_unpack = dtToReturn.Rows[0]["Qty_unpack"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Qty_unpack"];
                    objLocationMaster.UserID = dtToReturn.Rows[0]["UserID"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["UserID"];
                    objLocationMaster.TimeStamp = dtToReturn.Rows[0]["TimeStamp"] == System.DBNull.Value ? SqlBinary.Null : (byte[])dtToReturn.Rows[0]["TimeStamp"];
                }
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("Location_Master::SelectOneByWarehouseLocationProduct::Error occured.", ex);
            }
            finally
            {
                sdaAdapter.Dispose();
            }
        }

        internal decimal GetOnHandQty(string strWarehouse, string strLocation, string strProduct)
        {
            Location_Master objMaster = new Location_Master();
            SelectOneByWarehouseLocationProduct(objMaster, strLocation, strWarehouse, strProduct);
            //No record found
            if (objMaster.Warehouse_id.IsNull ||objMaster.Qty_on_hand.IsNull)
            {
                return 0;
            }

            return Convert.ToDecimal(objMaster.Qty_on_hand.ToString());

        }


        internal void ReadFromDataRow(DataRow dr)
        {
            m_sWarehouse_id = (string)dr["Warehouse_id"];
            m_sBin_location_id = (string)dr["Bin_location_id"];
            m_iSequence = (Int32)dr["Sequence"];
            m_sProduct_id = dr["Product_id"] == System.DBNull.Value ? SqlString.Null : (string)dr["Product_id"];
            m_sPackage_Code = dr["Package Code"] == System.DBNull.Value ? SqlString.Null : (string)dr["Package Code"];
            m_iQty_on_hand = dr["Qty_on_hand"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dr["Qty_on_hand"];
            m_iQty_allocated = dr["Qty_allocated"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dr["Qty_allocated"];
            m_daDate_last_unpack = dr["Date_last_unpack"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dr["Date_last_unpack"];
            m_daDate_Last_Picked = dr["Date_Last_Picked"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dr["Date_Last_Picked"];
            m_sReserved_code = dr["Reserved_code"] == System.DBNull.Value ? SqlString.Null : (string)dr["Reserved_code"];
            m_daReserved_Date = dr["Reserved_Date"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dr["Reserved_Date"];
            m_iQty_unpack = dr["Qty_unpack"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dr["Qty_unpack"];
            m_sUserID = dr["UserID"] == System.DBNull.Value ? SqlString.Null : (string)dr["UserID"];
            m_biTimeStamp = dr["TimeStamp"] == System.DBNull.Value ? SqlBinary.Null : (byte[])dr["TimeStamp"];
        }

        /// <summary>
        /// Use this when need to add a product to a location
        /// </summary>
        /// <param name="scmCmdToExecute"></param>
        /// <returns></returns>
        public bool InsertWithNewSequence(SqlCommand scmCmdToExecute)
        {
            scmCmdToExecute.Parameters.Clear();
            scmCmdToExecute.CommandText = "dbo.[pr_Location_Master_Insert_New_Sequence]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sWarehouse_id", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sWarehouse_id));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sBin_location_id", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sBin_location_id));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iSequence", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iSequence));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sProduct_id", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sProduct_id));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sPackage_Code", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPackage_Code));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iQty_on_hand", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iQty_on_hand));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iQty_allocated", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iQty_allocated));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@daDate_last_unpack", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daDate_last_unpack));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@daDate_Last_Picked", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daDate_Last_Picked));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sReserved_code", SqlDbType.NVarChar, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sReserved_code));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@daReserved_Date", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daReserved_Date));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iQty_unpack", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iQty_unpack));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sUserID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sUserID));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

                if (m_iErrorCode != (int)LLBLError.AllOk)
                {
                    // Throw error.
                    throw new Exception("Stored Procedure 'pr_Location_Master_Insert_New_Sequence' reported the ErrorCode: " + m_iErrorCode);
                }

                return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("Location_Master::InsertWithNewSequence::Error occured.", ex);
            }
            finally
            {
            }
        }

        internal string SelectWarehouseByLocation(string strLocation)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "select * from Location_Master where bin_location_id = '" + strLocation + "'";
            scmCmdToExecute.CommandType = CommandType.Text;
            DataTable dtToReturn = new DataTable("Location_Master");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;


            try
            {
                // Open connection.
                m_scoMainConnection.Open();
                // Execute query.
                sdaAdapter.Fill(dtToReturn);

                if (dtToReturn.Rows.Count > 0)
                {
                    return (string)dtToReturn.Rows[0]["Warehouse_id"];
                    
                }
                return String.Empty;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("Location_Master::SelectOneByLocation::Error occured.", ex);
            }
            finally
            {
                //// Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
    }
        
}
