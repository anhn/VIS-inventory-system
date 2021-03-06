///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'StockOutDetails'
// Generated by LLBLGen v1.2.2710.28204 Final on: Sunday, June 03, 2007, 4:48:09 PM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Inventory.DataObjects
{
	/// <summary>
	/// Purpose: Data Access class for the table 'StockOutDetails'.
	/// </summary>
	public class StockOutDetails : DBInteractionBase
	{
		#region Class Member Declarations
			private SqlDateTime		m_daDate;
			private SqlString		m_sUserID;
			private SqlDecimal		m_dcQty;
			private SqlString		m_sID, m_sStockOutID, m_sStockOutIDOld, m_sProduct;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public StockOutDetails()
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
		///		 <LI>StockOutID</LI>
		///		 <LI>Product</LI>
		///		 <LI>Qty</LI>
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
            this.ID = Guid.NewGuid().ToString();
			scmCmdToExecute.Parameters.Clear();
			scmCmdToExecute.CommandText = "dbo.[pr_StockOutDetails_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sStockOutID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sStockOutID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sProduct", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sProduct));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcQty", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 2, "", DataRowVersion.Proposed, m_dcQty));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sUserID", SqlDbType.NChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sUserID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daDate));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_StockOutDetails_Insert' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("StockOutDetails::Insert::Error occured.", ex);
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
		///		 <LI>StockOutID</LI>
		///		 <LI>Product</LI>
		///		 <LI>Qty</LI>
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
			scmCmdToExecute.CommandText = "dbo.[pr_StockOutDetails_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sStockOutID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sStockOutID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sProduct", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sProduct));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcQty", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 2, "", DataRowVersion.Proposed, m_dcQty));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sUserID", SqlDbType.NChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sUserID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daDate));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_StockOutDetails_Update' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("StockOutDetails::Update::Error occured.", ex);
			}
			finally
			{
			}
		}


		/// <summary>
		/// Purpose: Update method for updating one or more rows using the Foreign Key 'StockOutID.
		/// This method will Update one or more existing rows in the database. It will reset the field 'StockOutID' in
		/// all rows which have as value for this field the value as set in property 'stockOutIDOld' to 
		/// the value as set in property 'stockOutID'.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>StockOutID</LI>
		///		 <LI>StockOutIDOld</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public bool UpdateAllWStockOutIDLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_StockOutDetails_UpdateAllWStockOutIDLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sStockOutID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sStockOutID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sStockOutIDOld", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sStockOutIDOld));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 36, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_StockOutDetails_UpdateAllWStockOutIDLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("StockOutDetails::UpdateAllWStockOutIDLogic::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_StockOutDetails_Delete]";
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
					throw new Exception("Stored Procedure 'pr_StockOutDetails_Delete' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("StockOutDetails::Delete::Error occured.", ex);
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
		///		 <LI>StockOutID</LI>
		///		 <LI>Product</LI>
		///		 <LI>Qty</LI>
		///		 <LI>UserID</LI>
		///		 <LI>Date</LI>
		/// </UL>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_StockOutDetails_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("StockOutDetails");
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
					throw new Exception("Stored Procedure 'pr_StockOutDetails_SelectOne' reported the ErrorCode: " + m_iErrorCode);
				}

				if(dtToReturn.Rows.Count > 0)
				{
					m_sID = (string)dtToReturn.Rows[0]["ID"];
					m_sStockOutID = (string)dtToReturn.Rows[0]["StockOutID"];
					m_sProduct = (string)dtToReturn.Rows[0]["Product"];
					m_dcQty = (Decimal)dtToReturn.Rows[0]["Qty"];
					m_sUserID = dtToReturn.Rows[0]["UserID"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["UserID"];
					m_daDate = dtToReturn.Rows[0]["Date"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Date"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("StockOutDetails::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_StockOutDetails_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("StockOutDetails");
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
					throw new Exception("Stored Procedure 'pr_StockOutDetails_SelectAll' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("StockOutDetails::SelectAll::Error occured.", ex);
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
		/// Purpose: Select method for a foreign key. This method will Select one or more rows from the database, based on the Foreign Key 'StockOutID'
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>StockOutID</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public DataTable SelectAllWStockOutIDLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_StockOutDetails_SelectAllWStockOutIDLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("StockOutDetails");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sStockOutID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sStockOutID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_StockOutDetails_SelectAllWStockOutIDLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("StockOutDetails::SelectAllWStockOutIDLogic::Error occured.", ex);
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


		public SqlString StockOutID
		{
			get
			{
				return m_sStockOutID;
			}
			set
			{
				SqlString sStockOutIDTmp = (SqlString)value;
				if(sStockOutIDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("stockOutID", "stockOutID can't be NULL");
				}
				m_sStockOutID = value;
			}
		}
		public SqlString stockOutIDOld
		{
			get
			{
				return m_sStockOutIDOld;
			}
			set
			{
				SqlString sStockOutIDOldTmp = (SqlString)value;
				if(sStockOutIDOldTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("stockOutIDOld", "stockOutIDOld can't be NULL");
				}
				m_sStockOutIDOld = value;
			}
		}


		public SqlString Product
		{
			get
			{
				return m_sProduct;
			}
			set
			{
				SqlString sProductTmp = (SqlString)value;
				if(sProductTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("product", "product can't be NULL");
				}
				m_sProduct = value;
			}
		}


		public SqlDecimal Qty
		{
			get
			{
				return m_dcQty;
			}
			set
			{
				SqlDecimal dcQtyTmp = (SqlDecimal)value;
				if(dcQtyTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("qty", "qty can't be NULL");
				}
				m_dcQty = value;
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
