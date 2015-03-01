using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Inventory.DataObjects.DAO
{
    class InventoryAdjustmentDao : DBInteractionBase
    {
        internal bool IsExistAdjustmentNameMaster(string strName)
        {
            try
            {
                string strSQL = String.Format("Select * From InventoryAdjustmentMaster Where [Name] = '{0}'", strName);

                // Query database
                SqlCommand oCommand = new SqlCommand();
                oCommand.CommandText = strSQL;
                oCommand.Connection = m_scoMainConnection;
                DataTable oTable = new DataTable();
                SqlDataAdapter oAdapter = new SqlDataAdapter(oCommand);
                oAdapter.Fill(oTable);

                // Check exist or not
                if (oTable.Rows.Count > 0)
                {
                    return true;
                }
            }
            catch (Exception oExc)
            {
                throw new Exception(String.Format("Error occured while checking Adjustment Name. {0}", oExc.Message));
            }

            return false;
        }
        internal System.Data.DataTable GetAllInventoryAdjustmentList()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "Select * from VListInventoryAdjustments";
            scmCmdToExecute.CommandType = CommandType.Text;
            DataTable dtToReturn = new DataTable("ListInventoryAdjustments");
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
                throw new Exception("ListInventoryAdjustments::SelectAll::Error occured.", ex);
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

        /// <summary>
        /// Only get the data schema with no data
        /// </summary>
        /// <returns></returns>
        internal DataTable GetEmptyListInventoryAdjustmentDetail()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "Select * from VListInventoryAdjustmentDetails where 1 = 0";
            scmCmdToExecute.CommandType = CommandType.Text;
            DataTable dtToReturn = new DataTable("ListInventoryAdjustmentDetails");
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
                throw new Exception("ListInventoryAdjustmentDetails::SelectAll::Error occured.", ex);
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

        internal DataTable GetAllPackageTypes()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "SELECT  [Package Type Master].[Storage pack text] AS Name, Package_Master.Package_code AS Code " +
                "FROM Package_Master INNER JOIN [Package Type Master] ON Package_Master.Package_type = [Package Type Master].Package_type";
            scmCmdToExecute.CommandType = CommandType.Text;
            DataTable dtToReturn = new DataTable("Package_Master");
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
                throw new Exception("Package_Master::SelectAll::Error occured.", ex);
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

        internal DataTable GetInventoryAdjustmentListDetail(string strInventoryAdjustmentId)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "Select * from VListInventoryAdjustmentDetails where InventoryAdjustmentId = '" + strInventoryAdjustmentId + "'";
            scmCmdToExecute.CommandType = CommandType.Text;
            DataTable dtToReturn = new DataTable("ListInventoryAdjustmentDetails");
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
                throw new Exception("ListInventoryAdjustmentDetails::SelectAll::Error occured.", ex);
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
