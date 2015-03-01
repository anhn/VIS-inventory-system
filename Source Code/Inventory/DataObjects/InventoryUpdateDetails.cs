///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'InventoryUpdateDetails'
// Generated by LLBLGen v1.2.2710.28204 Final on: Thursday, June 07, 2007, 6:02:27 PM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Inventory.DataObjects
{
	/// <summary>
	/// Purpose: Data Access class for the table 'InventoryUpdateDetails'.
	/// </summary>
	public class InventoryUpdateDetails : DBInteractionBase
	{
		#region Class Member Declarations
			private SqlDateTime		m_daDate;
			private SqlDecimal		m_dcNewQty, m_dcOldQty;
			private SqlString		m_sUserID, m_sUserIDOld, m_sProductID, m_sProductIDOld, m_sInventoryUpdateID, m_sInventoryUpdateIDOld, m_sID, m_sLocationID, m_sWarehouseID;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public InventoryUpdateDetails()
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
		///		 <LI>InventoryUpdateID. May be SqlString.Null</LI>
		///		 <LI>WarehouseID. May be SqlString.Null</LI>
		///		 <LI>LocationID. May be SqlString.Null</LI>
		///		 <LI>ProductID. May be SqlString.Null</LI>
		///		 <LI>OldQty. May be SqlDecimal.Null</LI>
		///		 <LI>NewQty. May be SqlDecimal.Null</LI>
		///		 <LI>UserID. May be SqlString.Null</LI>
		///		 <LI>Date. May be SqlDateTime.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert(SqlCommand scmCmdToExecute)
		{
			scmCmdToExecute.Parameters.Clear();
			scmCmdToExecute.CommandText = "dbo.[pr_InventoryUpdateDetails_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sInventoryUpdateID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sInventoryUpdateID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sWarehouseID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sWarehouseID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sLocationID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sLocationID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sProductID", SqlDbType.NChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sProductID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcOldQty", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 2, "", DataRowVersion.Proposed, m_dcOldQty));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcNewQty", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 2, "", DataRowVersion.Proposed, m_dcNewQty));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sUserID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sUserID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daDate));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_InventoryUpdateDetails_Insert' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("InventoryUpdateDetails::Insert::Error occured.", ex);
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
		///		 <LI>InventoryUpdateID. May be SqlString.Null</LI>
		///		 <LI>WarehouseID. May be SqlString.Null</LI>
		///		 <LI>LocationID. May be SqlString.Null</LI>
		///		 <LI>ProductID. May be SqlString.Null</LI>
		///		 <LI>OldQty. May be SqlDecimal.Null</LI>
		///		 <LI>NewQty. May be SqlDecimal.Null</LI>
		///		 <LI>UserID. May be SqlString.Null</LI>
		///		 <LI>Date. May be SqlDateTime.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Update(SqlCommand scmCmdToExecute)
		{
			scmCmdToExecute.Parameters.Clear();
			scmCmdToExecute.CommandText = "dbo.[pr_InventoryUpdateDetails_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sInventoryUpdateID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sInventoryUpdateID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sWarehouseID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sWarehouseID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sLocationID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sLocationID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sProductID", SqlDbType.NChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sProductID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcOldQty", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 2, "", DataRowVersion.Proposed, m_dcOldQty));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcNewQty", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 2, "", DataRowVersion.Proposed, m_dcNewQty));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sUserID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sUserID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daDate));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_InventoryUpdateDetails_Update' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("InventoryUpdateDetails::Update::Error occured.", ex);
			}
			finally
			{
			}
		}


		/// <summary>
		/// Purpose: Update method for updating one or more rows using the Foreign Key 'InventoryUpdateID.
		/// This method will Update one or more existing rows in the database. It will reset the field 'InventoryUpdateID' in
		/// all rows which have as value for this field the value as set in property 'inventoryUpdateIDOld' to 
		/// the value as set in property 'inventoryUpdateID'.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>InventoryUpdateID. May be SqlString.Null</LI>
		///		 <LI>InventoryUpdateIDOld. May be SqlString.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public bool UpdateAllWInventoryUpdateIDLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_InventoryUpdateDetails_UpdateAllWInventoryUpdateIDLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sInventoryUpdateID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sInventoryUpdateID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sInventoryUpdateIDOld", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sInventoryUpdateIDOld));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 36, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_InventoryUpdateDetails_UpdateAllWInventoryUpdateIDLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("InventoryUpdateDetails::UpdateAllWInventoryUpdateIDLogic::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
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
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_InventoryUpdateDetails_UpdateAllWProductIDLogic]";
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

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_InventoryUpdateDetails_UpdateAllWProductIDLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("InventoryUpdateDetails::UpdateAllWProductIDLogic::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Update method for updating one or more rows using the Foreign Key 'UserID.
		/// This method will Update one or more existing rows in the database. It will reset the field 'UserID' in
		/// all rows which have as value for this field the value as set in property 'userIDOld' to 
		/// the value as set in property 'userID'.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>UserID. May be SqlString.Null</LI>
		///		 <LI>UserIDOld. May be SqlString.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public bool UpdateAllWUserIDLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_InventoryUpdateDetails_UpdateAllWUserIDLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sUserID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sUserID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sUserIDOld", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sUserIDOld));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 36, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_InventoryUpdateDetails_UpdateAllWUserIDLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("InventoryUpdateDetails::UpdateAllWUserIDLogic::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_InventoryUpdateDetails_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_InventoryUpdateDetails_Delete' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("InventoryUpdateDetails::Delete::Error occured.", ex);
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
		///		 <LI>InventoryUpdateID</LI>
		///		 <LI>WarehouseID</LI>
		///		 <LI>LocationID</LI>
		///		 <LI>ProductID</LI>
		///		 <LI>OldQty</LI>
		///		 <LI>NewQty</LI>
		///		 <LI>UserID</LI>
		///		 <LI>Date</LI>
		/// </UL>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_InventoryUpdateDetails_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("InventoryUpdateDetails");
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

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_InventoryUpdateDetails_SelectOne' reported the ErrorCode: " + m_iErrorCode);
				}

				if(dtToReturn.Rows.Count > 0)
				{
					m_sID = (string)dtToReturn.Rows[0]["ID"];
					m_sInventoryUpdateID = dtToReturn.Rows[0]["InventoryUpdateID"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["InventoryUpdateID"];
					m_sWarehouseID = dtToReturn.Rows[0]["WarehouseID"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["WarehouseID"];
					m_sLocationID = dtToReturn.Rows[0]["LocationID"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["LocationID"];
					m_sProductID = dtToReturn.Rows[0]["ProductID"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["ProductID"];
					m_dcOldQty = dtToReturn.Rows[0]["OldQty"] == System.DBNull.Value ? SqlDecimal.Null : (Decimal)dtToReturn.Rows[0]["OldQty"];
					m_dcNewQty = dtToReturn.Rows[0]["NewQty"] == System.DBNull.Value ? SqlDecimal.Null : (Decimal)dtToReturn.Rows[0]["NewQty"];
					m_sUserID = dtToReturn.Rows[0]["UserID"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["UserID"];
					m_daDate = dtToReturn.Rows[0]["Date"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Date"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("InventoryUpdateDetails::SelectOne::Error occured.", ex);
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
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_InventoryUpdateDetails_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("InventoryUpdateDetails");
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

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_InventoryUpdateDetails_SelectAll' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("InventoryUpdateDetails::SelectAll::Error occured.", ex);
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
		/// Purpose: Select method for a foreign key. This method will Select one or more rows from the database, based on the Foreign Key 'InventoryUpdateID'
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>InventoryUpdateID. May be SqlString.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public DataTable SelectAllWInventoryUpdateIDLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_InventoryUpdateDetails_SelectAllWInventoryUpdateIDLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("InventoryUpdateDetails");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sInventoryUpdateID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sInventoryUpdateID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_InventoryUpdateDetails_SelectAllWInventoryUpdateIDLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("InventoryUpdateDetails::SelectAllWInventoryUpdateIDLogic::Error occured.", ex);
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
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_InventoryUpdateDetails_SelectAllWProductIDLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("InventoryUpdateDetails");
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

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_InventoryUpdateDetails_SelectAllWProductIDLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("InventoryUpdateDetails::SelectAllWProductIDLogic::Error occured.", ex);
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
		/// Purpose: Select method for a foreign key. This method will Select one or more rows from the database, based on the Foreign Key 'UserID'
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>UserID. May be SqlString.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public DataTable SelectAllWUserIDLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_InventoryUpdateDetails_SelectAllWUserIDLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("InventoryUpdateDetails");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sUserID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sUserID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_InventoryUpdateDetails_SelectAllWUserIDLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("InventoryUpdateDetails::SelectAllWUserIDLogic::Error occured.", ex);
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
				if(sIDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD", "iD can't be NULL");
				}
				m_sID = value;
			}
		}


		public SqlString InventoryUpdateID
		{
			get
			{
				return m_sInventoryUpdateID;
			}
			set
			{
				m_sInventoryUpdateID = value;
			}
		}
		public SqlString inventoryUpdateIDOld
		{
			get
			{
				return m_sInventoryUpdateIDOld;
			}
			set
			{
				m_sInventoryUpdateIDOld = value;
			}
		}


		public SqlString WarehouseID
		{
			get
			{
				return m_sWarehouseID;
			}
			set
			{
				m_sWarehouseID = value;
			}
		}


		public SqlString LocationID
		{
			get
			{
				return m_sLocationID;
			}
			set
			{
				m_sLocationID = value;
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


		public SqlDecimal OldQty
		{
			get
			{
				return m_dcOldQty;
			}
			set
			{
				m_dcOldQty = value;
			}
		}


		public SqlDecimal NewQty
		{
			get
			{
				return m_dcNewQty;
			}
			set
			{
				m_dcNewQty = value;
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
		public SqlString userIDOld
		{
			get
			{
				return m_sUserIDOld;
			}
			set
			{
				m_sUserIDOld = value;
			}
		}


		public SqlDateTime Date
		{
			get
			{
				return m_daDate;
			}
			set
			{
				m_daDate = value;
			}
		}
		#endregion
	}
}