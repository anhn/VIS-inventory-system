///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'InventoryAdjustmentMaster'
// Generated by LLBLGen v1.2.2690.36218 Final on: Saturday, May 19, 2007, 2:45:13 PM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Inventory.DataObjects
{
    /// <summary>
    /// Purpose: Data Access class for the table 'InventoryAdjustmentMaster'.
    /// </summary>
    public class InventoryAdjustmentMaster : DBInteractionBase
    {
        #region Class Member Declarations
        private SqlBoolean m_bViewStatus;
        private SqlDateTime m_daDateCreated;
        private SqlString m_sID, m_sNotes, m_sName;
        #endregion


        /// <summary>
        /// Purpose: Class constructor.
        /// </summary>
        public InventoryAdjustmentMaster()
        {
            // Nothing for now.
        }


        /// <summary>
        /// Purpose: Insert method. This method will insert one new row into the database.
        /// </summary>
        /// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
        /// <remarks>
        /// Properties needed for this method: 
        /// <UL>
        ///		 <LI>ID</LI>
        ///		 <LI>Name. May be SqlString.Null</LI>
        ///		 <LI>DateCreated. May be SqlDateTime.Null</LI>
        ///		 <LI>Notes. May be SqlString.Null</LI>
        ///		 <LI>ViewStatus. May be SqlBoolean.Null</LI>
        /// </UL>
        /// Properties set after a succesful call of this method: 
        /// <UL>
        ///		 <LI>ErrorCode</LI>
        /// </UL>
        /// </remarks>
        public override bool Insert(SqlCommand scmCmdToExecute)
        {
            this.ID = Guid.NewGuid().ToString();
            scmCmdToExecute.Parameters.Clear();
            scmCmdToExecute.CommandText = "dbo.[pr_InventoryAdjustmentMaster_Insert]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sID));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sName", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sName));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@daDateCreated", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daDateCreated));
                int iLength = 0;
                if (!m_sNotes.IsNull)
                {
                    iLength = m_sNotes.Value.Length;
                }
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sNotes", SqlDbType.NText, iLength, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNotes));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@bViewStatus", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bViewStatus));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

                if (m_iErrorCode != (int)LLBLError.AllOk)
                {
                    // Throw error.
                    throw new Exception("Stored Procedure 'pr_InventoryAdjustmentMaster_Insert' reported the ErrorCode: " + m_iErrorCode);
                }

                return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("InventoryAdjustmentMaster::Insert::Error occured.", ex);
            }
            finally
            {
            }
        }


        /// <summary>
        /// Purpose: Update method. This method will Update one existing row in the database.
        /// </summary>
        /// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
        /// <remarks>
        /// Properties needed for this method: 
        /// <UL>
        ///		 <LI>ID</LI>
        ///		 <LI>Name. May be SqlString.Null</LI>
        ///		 <LI>DateCreated. May be SqlDateTime.Null</LI>
        ///		 <LI>Notes. May be SqlString.Null</LI>
        ///		 <LI>ViewStatus. May be SqlBoolean.Null</LI>
        /// </UL>
        /// Properties set after a succesful call of this method: 
        /// <UL>
        ///		 <LI>ErrorCode</LI>
        /// </UL>
        /// </remarks>
        public override bool Update(SqlCommand scmCmdToExecute)
        {
            scmCmdToExecute.Parameters.Clear();
            scmCmdToExecute.CommandText = "dbo.[pr_InventoryAdjustmentMaster_Update]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sID));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sName", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sName));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@daDateCreated", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daDateCreated));
                int iLength = 0;
                if (!m_sNotes.IsNull)
                {
                    iLength = m_sNotes.Value.Length;
                }
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sNotes", SqlDbType.NText, iLength, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNotes));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@bViewStatus", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bViewStatus));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

                if (m_iErrorCode != (int)LLBLError.AllOk)
                {
                    // Throw error.
                    throw new Exception("Stored Procedure 'pr_InventoryAdjustmentMaster_Update' reported the ErrorCode: " + m_iErrorCode);
                }

                return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("InventoryAdjustmentMaster::Update::Error occured.", ex);
            }
            finally
            {
            }
        }


        /// <summary>
        /// Purpose: Delete method. This method will Delete one existing row in the database, based on the Primary Key.
        /// </summary>
        /// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
        /// <remarks>
        /// Properties needed for this method: 
        /// <UL>
        ///		 <LI>ID</LI>
        /// </UL>
        /// Properties set after a succesful call of this method: 
        /// <UL>
        ///		 <LI>ErrorCode</LI>
        /// </UL>
        /// </remarks>
        public override bool Delete(SqlCommand scmCmdToExecute)
        {
            scmCmdToExecute.Parameters.Clear();
            scmCmdToExecute.CommandText = "dbo.[pr_InventoryAdjustmentMaster_Delete]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sID));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

                if (m_iErrorCode != (int)LLBLError.AllOk)
                {
                    // Throw error.
                    throw new Exception("Stored Procedure 'pr_InventoryAdjustmentMaster_Delete' reported the ErrorCode: " + m_iErrorCode);
                }

                return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("InventoryAdjustmentMaster::Delete::Error occured.", ex);
            }
            finally
            {
            }
        }


        /// <summary>
        /// Purpose: Select method. This method will Select one existing row from the database, based on the Primary Key.
        /// </summary>
        /// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
        /// <remarks>
        /// Properties needed for this method: 
        /// <UL>
        ///		 <LI>ID</LI>
        /// </UL>
        /// Properties set after a succesful call of this method: 
        /// <UL>
        ///		 <LI>ErrorCode</LI>
        ///		 <LI>ID</LI>
        ///		 <LI>Name</LI>
        ///		 <LI>DateCreated</LI>
        ///		 <LI>Notes</LI>
        ///		 <LI>ViewStatus</LI>
        /// </UL>
        /// Will fill all properties corresponding with a field in the table with the value of the row selected.
        /// </remarks>
        public override DataTable SelectOne()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_InventoryAdjustmentMaster_SelectOne]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("InventoryAdjustmentMaster");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sID));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                sdaAdapter.Fill(dtToReturn);
                m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

                if (m_iErrorCode != (int)LLBLError.AllOk)
                {
                    // Throw error.
                    throw new Exception("Stored Procedure 'pr_InventoryAdjustmentMaster_SelectOne' reported the ErrorCode: " + m_iErrorCode);
                }

                if (dtToReturn.Rows.Count > 0)
                {
                    m_sID = (string)dtToReturn.Rows[0]["ID"];
                    m_sName = dtToReturn.Rows[0]["Name"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Name"];
                    m_daDateCreated = dtToReturn.Rows[0]["DateCreated"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["DateCreated"];
                    m_sNotes = dtToReturn.Rows[0]["Notes"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Notes"];
                    m_bViewStatus = dtToReturn.Rows[0]["ViewStatus"] == System.DBNull.Value ? SqlBoolean.Null : (bool)dtToReturn.Rows[0]["ViewStatus"];
                }
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("InventoryAdjustmentMaster::SelectOne::Error occured.", ex);
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
        /// Purpose: SelectAll method. This method will Select all rows from the table.
        /// </summary>
        /// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
        /// <remarks>
        /// Properties set after a succesful call of this method: 
        /// <UL>
        ///		 <LI>ErrorCode</LI>
        /// </UL>
        /// </remarks>
        public override DataTable SelectAll()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_InventoryAdjustmentMaster_SelectAll]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("InventoryAdjustmentMaster");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                sdaAdapter.Fill(dtToReturn);
                m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

                if (m_iErrorCode != (int)LLBLError.AllOk)
                {
                    // Throw error.
                    throw new Exception("Stored Procedure 'pr_InventoryAdjustmentMaster_SelectAll' reported the ErrorCode: " + m_iErrorCode);
                }

                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("InventoryAdjustmentMaster::SelectAll::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }


        #region Class Property Declarations
        public SqlString ID
        {
            get
            {
                return m_sID;
            }
            set
            {
                SqlString sIDTmp = (SqlString)value;
                if (sIDTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("iD", "iD can't be NULL");
                }
                m_sID = value;
            }
        }


        public SqlString Name
        {
            get
            {
                return m_sName;
            }
            set
            {
                m_sName = value;
            }
        }


        public SqlDateTime DateCreated
        {
            get
            {
                return m_daDateCreated;
            }
            set
            {
                m_daDateCreated = value;
            }
        }


        public SqlString Notes
        {
            get
            {
                return m_sNotes;
            }
            set
            {
                m_sNotes = value;
            }
        }


        public SqlBoolean ViewStatus
        {
            get
            {
                return m_bViewStatus;
            }
            set
            {
                m_bViewStatus = value;
            }
        }
        #endregion
    }
}
