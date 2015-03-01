///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'BoMMaster'
// Generated by LLBLGen v1.2.2710.28204 Final on: Thursday, June 07, 2007, 2:41:09 PM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Inventory.DataObjects
{
    /// <summary>
    /// Purpose: Data Access class for the table 'BoMMaster'.
    /// </summary>
    public class BoMMaster : DBInteractionBase
    {
        #region Class Member Declarations
        private SqlDateTime m_daDateCreated;
        private SqlString m_sDescription, m_sUserID, m_sID, m_sProductID, m_sProductIDOld, m_sName;
        #endregion


        /// <summary>
        /// Purpose: Class constructor.
        /// </summary>
        public BoMMaster()
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
        ///		 <LI>ProductID. May be SqlString.Null</LI>
        ///		 <LI>Name</LI>
        ///		 <LI>Description. May be SqlString.Null</LI>
        ///		 <LI>DateCreated</LI>
        ///		 <LI>UserID. May be SqlString.Null</LI>
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
            scmCmdToExecute.CommandText = "dbo.[pr_BoMMaster_Insert]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sID));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sProductID", SqlDbType.NChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sProductID));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sName", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sName));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sDescription", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDescription));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@daDateCreated", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daDateCreated));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sUserID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sUserID));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

                if (m_iErrorCode != (int)LLBLError.AllOk)
                {
                    // Throw error.
                    throw new Exception("Stored Procedure 'pr_BoMMaster_Insert' reported the ErrorCode: " + m_iErrorCode);
                }

                return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("BoMMaster::Insert::Error occured.", ex);
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
        ///		 <LI>ProductID. May be SqlString.Null</LI>
        ///		 <LI>Name</LI>
        ///		 <LI>Description. May be SqlString.Null</LI>
        ///		 <LI>DateCreated</LI>
        ///		 <LI>UserID. May be SqlString.Null</LI>
        /// </UL>
        /// Properties set after a succesful call of this method: 
        /// <UL>
        ///		 <LI>ErrorCode</LI>
        /// </UL>
        /// </remarks>
        public override bool Update(SqlCommand scmCmdToExecute)
        {
            scmCmdToExecute.Parameters.Clear();
            scmCmdToExecute.CommandText = "dbo.[pr_BoMMaster_Update]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sID));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sProductID", SqlDbType.NChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sProductID));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sName", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sName));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sDescription", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDescription));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@daDateCreated", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daDateCreated));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sUserID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sUserID));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

                if (m_iErrorCode != (int)LLBLError.AllOk)
                {
                    // Throw error.
                    throw new Exception("Stored Procedure 'pr_BoMMaster_Update' reported the ErrorCode: " + m_iErrorCode);
                }

                return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("BoMMaster::Update::Error occured.", ex);
            }
            finally
            {
            }
        }


        /// <summary>
        /// Purpose: Update method for updating one or more rows using the Foreign Key 'ProductID.
        /// This method will Update one or more existing rows in the database. It will reset the field 'ProductID' in
        /// all rows which have as value for this field the value as set in property 'productIDOld' to 
        /// the value as set in property 'productID'.
        /// </summary>
        /// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
        /// <remarks>
        /// Properties needed for this method: 
        /// <UL>
        ///		 <LI>ProductID. May be SqlString.Null</LI>
        ///		 <LI>ProductIDOld. May be SqlString.Null</LI>
        /// </UL>
        /// Properties set after a succesful call of this method: 
        /// <UL>
        ///		 <LI>ErrorCode</LI>
        /// </UL>
        /// </remarks>
        public bool UpdateAllWProductIDLogic()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_BoMMaster_UpdateAllWProductIDLogic]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sProductID", SqlDbType.NChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sProductID));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sProductIDOld", SqlDbType.NChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sProductIDOld));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 10, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

                if (m_iErrorCode != (int)LLBLError.AllOk)
                {
                    // Throw error.
                    throw new Exception("Stored Procedure 'pr_BoMMaster_UpdateAllWProductIDLogic' reported the ErrorCode: " + m_iErrorCode);
                }

                return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("BoMMaster::UpdateAllWProductIDLogic::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
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
            scmCmdToExecute.CommandText = "dbo.[pr_BoMMaster_Delete]";
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
                    throw new Exception("Stored Procedure 'pr_BoMMaster_Delete' reported the ErrorCode: " + m_iErrorCode);
                }

                return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("BoMMaster::Delete::Error occured.", ex);
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
        ///		 <LI>ProductID</LI>
        ///		 <LI>Name</LI>
        ///		 <LI>Description</LI>
        ///		 <LI>DateCreated</LI>
        ///		 <LI>UserID</LI>
        /// </UL>
        /// Will fill all properties corresponding with a field in the table with the value of the row selected.
        /// </remarks>
        public override DataTable SelectOne()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_BoMMaster_SelectOne]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("BoMMaster");
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
                    throw new Exception("Stored Procedure 'pr_BoMMaster_SelectOne' reported the ErrorCode: " + m_iErrorCode);
                }

                if (dtToReturn.Rows.Count > 0)
                {
                    m_sID = (string)dtToReturn.Rows[0]["ID"];
                    m_sProductID = dtToReturn.Rows[0]["ProductID"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["ProductID"];
                    m_sName = (string)dtToReturn.Rows[0]["Name"];
                    m_sDescription = dtToReturn.Rows[0]["Description"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Description"];
                    m_daDateCreated = (DateTime)dtToReturn.Rows[0]["DateCreated"];
                    m_sUserID = dtToReturn.Rows[0]["UserID"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["UserID"];
                }
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("BoMMaster::SelectOne::Error occured.", ex);
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
            scmCmdToExecute.CommandText = "dbo.[pr_BoMMaster_SelectAll]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("BoMMaster");
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
                    throw new Exception("Stored Procedure 'pr_BoMMaster_SelectAll' reported the ErrorCode: " + m_iErrorCode);
                }

                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("BoMMaster::SelectAll::Error occured.", ex);
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
        /// Purpose: Select method for a foreign key. This method will Select one or more rows from the database, based on the Foreign Key 'ProductID'
        /// </summary>
        /// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
        /// <remarks>
        /// Properties needed for this method: 
        /// <UL>
        ///		 <LI>ProductID. May be SqlString.Null</LI>
        /// </UL>
        /// Properties set after a succesful call of this method: 
        /// <UL>
        ///		 <LI>ErrorCode</LI>
        /// </UL>
        /// </remarks>
        public DataTable SelectAllWProductIDLogic()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_BoMMaster_SelectAllWProductIDLogic]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("BoMMaster");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sProductID", SqlDbType.NChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sProductID));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                sdaAdapter.Fill(dtToReturn);
                m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

                if (m_iErrorCode != (int)LLBLError.AllOk)
                {
                    // Throw error.
                    throw new Exception("Stored Procedure 'pr_BoMMaster_SelectAllWProductIDLogic' reported the ErrorCode: " + m_iErrorCode);
                }

                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("BoMMaster::SelectAllWProductIDLogic::Error occured.", ex);
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


        public SqlString ProductID
        {
            get
            {
                return m_sProductID;
            }
            set
            {
                m_sProductID = value;
            }
        }
        public SqlString productIDOld
        {
            get
            {
                return m_sProductIDOld;
            }
            set
            {
                m_sProductIDOld = value;
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
                SqlString sNameTmp = (SqlString)value;
                if (sNameTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("name", "name can't be NULL");
                }
                m_sName = value;
            }
        }


        public SqlString Description
        {
            get
            {
                return m_sDescription;
            }
            set
            {
                m_sDescription = value;
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
                SqlDateTime daDateCreatedTmp = (SqlDateTime)value;
                if (daDateCreatedTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("dateCreated", "dateCreated can't be NULL");
                }
                m_daDateCreated = value;
            }
        }


        public SqlString UserID
        {
            get
            {
                return m_sUserID;
            }
            set
            {
                m_sUserID = value;
            }
        }
        #endregion
    }
}