using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Inventory.DataObjects.DAO
{
    public class DeliveryNoteDao: DBInteractionBase
    {
        /// <summary>
        /// Get all delivery notes
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAllDeliveryNoteMaster()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_DeliveryNotesMaster_SelectAll]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("DeliveryNotesMaster");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

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
                m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

                if (m_iErrorCode != (int)LLBLError.AllOk)
                {
                    // Throw error.
                    throw new Exception("Stored Procedure 'pr_DeliveryNotesMaster_SelectAll' reported the ErrorCode: " + m_iErrorCode);
                }

                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("DeliveryNotesMaster::SelectAll::Error occured.", ex);
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
        /// This method is to check the given DNID is exist or not
        /// </summary>
        /// <param name="strDNID"></param>
        /// <returns></returns>
        public bool IsExistDeliveryNotesMaster(string strDNID)
        {
            try
            {
                string strSQL = String.Format("Select * From DeliveryNotesMaster Where DeliveryNotesMaster.DNID = '{0}'", strDNID);

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
                throw new Exception(String.Format("Error occured while checking Deliver Notes. {0}", oExc.Message));
            }

            return false;
        }

        /// <summary>
        /// Get delivery notes with view status TRUE        
        /// </summary>
        /// <returns></returns>
        public DataTable GetViewableDeliveryNotes()
        {
            DeliveryNotesMaster objNoteMaster = new DeliveryNotesMaster();
            return objNoteMaster.SelectAll();
        }

        public DataTable SelectAllDeliveryMethod()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "Select * from DeliveryMethod";
            scmCmdToExecute.CommandType = CommandType.Text;
            DataTable dtToReturn = new DataTable("DeliveryMethod");
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
                throw new Exception("DeliveryMethod::SelectAll::Error occured.", ex);
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

        public DataTable SelectAllDeliveryType()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "Select * from DeliveryMethod";
            scmCmdToExecute.CommandType = CommandType.Text;
            DataTable dtToReturn = new DataTable("DeliveryMethod");
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
                throw new Exception("DeliveryMethod::SelectAll::Error occured.", ex);
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

        internal DataTable GetEmptyDeliveryNoteDetail()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "Select * from VListDeliveryNoteDetails where 1= 0";
            scmCmdToExecute.CommandType = CommandType.Text;
            DataTable dtToReturn = new DataTable("DeliveryNotesDetails");
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
                throw new Exception("DeliveryNotesDetails::SelectAll::Error occured.", ex);
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

        internal DataTable GetDeliveryNoteDetails(String strId)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "Select * from VListDeliveryNoteDetails where DeliveryNoteID = '" + strId + "'";
            scmCmdToExecute.CommandType = CommandType.Text;
            DataTable dtToReturn = new DataTable("DeliveryNotesDetails");
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
                throw new Exception("DeliveryNotesDetails::SelectAll::Error occured.", ex);
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
