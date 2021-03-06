///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 't_Purchase_Order_Header'
// Generated by LLBLGen v1.2.2690.36218 Final on: Monday, May 14, 2007, 8:07:35 PM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Inventory.DataObjects
{
	/// <summary>
	/// Purpose: Data Access class for the table 't_Purchase_Order_Header'.
	/// </summary>
	public class T_Purchase_Order_Header : DBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bViewStatus;
			private SqlDateTime		m_daDeliveryDate, m_daCreatedDate, m_daPODate, m_daLastUpdatedDate;
			private SqlDecimal		m_dcDiscount, m_dcShipping, m_dcTotalAmt;
			private SqlString		m_sLastUpdatedBy, m_sCreatedBy, m_sNotes, m_sSupplierTermsID, m_sShipTo, m_sPOTypeID, m_sPOTypeIDOld, m_sPONo, m_sTax_code_id, m_sTax_code_idOld, m_sAccountNo, m_sSupplierID, m_sSupplierIDOld;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public T_Purchase_Order_Header()
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
		///		 <LI>PONo</LI>
		///		 <LI>PODate. May be SqlDateTime.Null</LI>
		///		 <LI>POTypeID. May be SqlString.Null</LI>
		///		 <LI>DeliveryDate. May be SqlDateTime.Null</LI>
		///		 <LI>ShipTo. May be SqlString.Null</LI>
		///		 <LI>SupplierID. May be SqlString.Null</LI>
		///		 <LI>TotalAmt. May be SqlDecimal.Null</LI>
		///		 <LI>AccountNo. May be SqlString.Null</LI>
		///		 <LI>Tax_code_id. May be SqlString.Null</LI>
		///		 <LI>Discount. May be SqlDecimal.Null</LI>
		///		 <LI>Shipping. May be SqlDecimal.Null</LI>
		///		 <LI>SupplierTermsID. May be SqlString.Null</LI>
		///		 <LI>Notes. May be SqlString.Null</LI>
		///		 <LI>CreatedBy. May be SqlString.Null</LI>
		///		 <LI>CreatedDate. May be SqlDateTime.Null</LI>
		///		 <LI>LastUpdatedBy. May be SqlString.Null</LI>
		///		 <LI>LastUpdatedDate. May be SqlDateTime.Null</LI>
		///		 <LI>ViewStatus. May be SqlBoolean.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert(SqlCommand scmCmdToExecute)
		{
			scmCmdToExecute.Parameters.Clear();
			scmCmdToExecute.CommandText = "dbo.[pr_t_Purchase_Order_Header_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPONo", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPONo));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daPODate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daPODate));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPOTypeID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPOTypeID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daDeliveryDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daDeliveryDate));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sShipTo", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sShipTo));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sSupplierID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSupplierID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcTotalAmt", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 2, "", DataRowVersion.Proposed, m_dcTotalAmt));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sAccountNo", SqlDbType.VarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sAccountNo));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTax_code_id", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTax_code_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcDiscount", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 2, "", DataRowVersion.Proposed, m_dcDiscount));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcShipping", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 2, "", DataRowVersion.Proposed, m_dcShipping));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sSupplierTermsID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSupplierTermsID));
				int	iLength = 0;
				if(!m_sNotes.IsNull)
				{
					iLength = m_sNotes.Value.Length;
				}
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sNotes", SqlDbType.NText, iLength, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNotes));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCreatedBy", SqlDbType.VarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCreatedBy));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daCreatedDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daCreatedDate));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sLastUpdatedBy", SqlDbType.VarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sLastUpdatedBy));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daLastUpdatedDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daLastUpdatedDate));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bViewStatus", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bViewStatus));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_t_Purchase_Order_Header_Insert' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("T_Purchase_Order_Header::Insert::Error occured.", ex);
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
		///		 <LI>PONo</LI>
		///		 <LI>PODate. May be SqlDateTime.Null</LI>
		///		 <LI>POTypeID. May be SqlString.Null</LI>
		///		 <LI>DeliveryDate. May be SqlDateTime.Null</LI>
		///		 <LI>ShipTo. May be SqlString.Null</LI>
		///		 <LI>SupplierID. May be SqlString.Null</LI>
		///		 <LI>TotalAmt. May be SqlDecimal.Null</LI>
		///		 <LI>AccountNo. May be SqlString.Null</LI>
		///		 <LI>Tax_code_id. May be SqlString.Null</LI>
		///		 <LI>Discount. May be SqlDecimal.Null</LI>
		///		 <LI>Shipping. May be SqlDecimal.Null</LI>
		///		 <LI>SupplierTermsID. May be SqlString.Null</LI>
		///		 <LI>Notes. May be SqlString.Null</LI>
		///		 <LI>CreatedBy. May be SqlString.Null</LI>
		///		 <LI>CreatedDate. May be SqlDateTime.Null</LI>
		///		 <LI>LastUpdatedBy. May be SqlString.Null</LI>
		///		 <LI>LastUpdatedDate. May be SqlDateTime.Null</LI>
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
			scmCmdToExecute.CommandText = "dbo.[pr_t_Purchase_Order_Header_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPONo", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPONo));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daPODate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daPODate));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPOTypeID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPOTypeID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daDeliveryDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daDeliveryDate));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sShipTo", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sShipTo));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sSupplierID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSupplierID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcTotalAmt", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 2, "", DataRowVersion.Proposed, m_dcTotalAmt));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sAccountNo", SqlDbType.VarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sAccountNo));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTax_code_id", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTax_code_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcDiscount", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 2, "", DataRowVersion.Proposed, m_dcDiscount));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcShipping", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 2, "", DataRowVersion.Proposed, m_dcShipping));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sSupplierTermsID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSupplierTermsID));
				int	iLength = 0;
				if(!m_sNotes.IsNull)
				{
					iLength = m_sNotes.Value.Length;
				}
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sNotes", SqlDbType.NText, iLength, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNotes));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCreatedBy", SqlDbType.VarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCreatedBy));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daCreatedDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daCreatedDate));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sLastUpdatedBy", SqlDbType.VarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sLastUpdatedBy));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daLastUpdatedDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daLastUpdatedDate));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bViewStatus", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bViewStatus));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_t_Purchase_Order_Header_Update' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("T_Purchase_Order_Header::Update::Error occured.", ex);
			}
			finally
			{
			}
		}


		/// <summary>
		/// Purpose: Update method for updating one or more rows using the Foreign Key 'POTypeID.
		/// This method will Update one or more existing rows in the database. It will reset the field 'POTypeID' in
		/// all rows which have as value for this field the value as set in property 'pOTypeIDOld' to 
		/// the value as set in property 'pOTypeID'.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>POTypeID. May be SqlString.Null</LI>
		///		 <LI>POTypeIDOld. May be SqlString.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public bool UpdateAllWPOTypeIDLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_t_Purchase_Order_Header_UpdateAllWPOTypeIDLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPOTypeID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPOTypeID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPOTypeIDOld", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPOTypeIDOld));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 36, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_t_Purchase_Order_Header_UpdateAllWPOTypeIDLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("T_Purchase_Order_Header::UpdateAllWPOTypeIDLogic::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Update method for updating one or more rows using the Foreign Key 'SupplierID.
		/// This method will Update one or more existing rows in the database. It will reset the field 'SupplierID' in
		/// all rows which have as value for this field the value as set in property 'supplierIDOld' to 
		/// the value as set in property 'supplierID'.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>SupplierID. May be SqlString.Null</LI>
		///		 <LI>SupplierIDOld. May be SqlString.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public bool UpdateAllWSupplierIDLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_t_Purchase_Order_Header_UpdateAllWSupplierIDLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sSupplierID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSupplierID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sSupplierIDOld", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSupplierIDOld));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 36, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_t_Purchase_Order_Header_UpdateAllWSupplierIDLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("T_Purchase_Order_Header::UpdateAllWSupplierIDLogic::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Update method for updating one or more rows using the Foreign Key 'Tax_code_id.
		/// This method will Update one or more existing rows in the database. It will reset the field 'Tax_code_id' in
		/// all rows which have as value for this field the value as set in property 'tax_code_idOld' to 
		/// the value as set in property 'tax_code_id'.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>Tax_code_id. May be SqlString.Null</LI>
		///		 <LI>Tax_code_idOld. May be SqlString.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public bool UpdateAllWTax_code_idLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_t_Purchase_Order_Header_UpdateAllWTax_code_idLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTax_code_id", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTax_code_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTax_code_idOld", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTax_code_idOld));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 36, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_t_Purchase_Order_Header_UpdateAllWTax_code_idLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("T_Purchase_Order_Header::UpdateAllWTax_code_idLogic::Error occured.", ex);
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
		///		 <LI>PONo</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Delete(SqlCommand scmCmdToExecute)
		{
			scmCmdToExecute.Parameters.Clear();
			scmCmdToExecute.CommandText = "dbo.[pr_t_Purchase_Order_Header_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPONo", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPONo));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_t_Purchase_Order_Header_Delete' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("T_Purchase_Order_Header::Delete::Error occured.", ex);
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
		///		 <LI>PONo</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		///		 <LI>PONo</LI>
		///		 <LI>PODate</LI>
		///		 <LI>POTypeID</LI>
		///		 <LI>DeliveryDate</LI>
		///		 <LI>ShipTo</LI>
		///		 <LI>SupplierID</LI>
		///		 <LI>TotalAmt</LI>
		///		 <LI>AccountNo</LI>
		///		 <LI>Tax_code_id</LI>
		///		 <LI>Discount</LI>
		///		 <LI>Shipping</LI>
		///		 <LI>SupplierTermsID</LI>
		///		 <LI>Notes</LI>
		///		 <LI>CreatedBy</LI>
		///		 <LI>CreatedDate</LI>
		///		 <LI>LastUpdatedBy</LI>
		///		 <LI>LastUpdatedDate</LI>
		///		 <LI>ViewStatus</LI>
		/// </UL>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_t_Purchase_Order_Header_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("t_Purchase_Order_Header");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPONo", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPONo));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_t_Purchase_Order_Header_SelectOne' reported the ErrorCode: " + m_iErrorCode);
				}

				if(dtToReturn.Rows.Count > 0)
				{
					m_sPONo = (string)dtToReturn.Rows[0]["PONo"];
					m_daPODate = dtToReturn.Rows[0]["PODate"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["PODate"];
					m_sPOTypeID = dtToReturn.Rows[0]["POTypeID"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["POTypeID"];
					m_daDeliveryDate = dtToReturn.Rows[0]["DeliveryDate"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["DeliveryDate"];
					m_sShipTo = dtToReturn.Rows[0]["ShipTo"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["ShipTo"];
					m_sSupplierID = dtToReturn.Rows[0]["SupplierID"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["SupplierID"];
					m_dcTotalAmt = dtToReturn.Rows[0]["TotalAmt"] == System.DBNull.Value ? SqlDecimal.Null : (Decimal)dtToReturn.Rows[0]["TotalAmt"];
					m_sAccountNo = dtToReturn.Rows[0]["AccountNo"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["AccountNo"];
					m_sTax_code_id = dtToReturn.Rows[0]["Tax_code_id"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Tax_code_id"];
					m_dcDiscount = dtToReturn.Rows[0]["Discount"] == System.DBNull.Value ? SqlDecimal.Null : (Decimal)dtToReturn.Rows[0]["Discount"];
					m_dcShipping = dtToReturn.Rows[0]["Shipping"] == System.DBNull.Value ? SqlDecimal.Null : (Decimal)dtToReturn.Rows[0]["Shipping"];
					m_sSupplierTermsID = dtToReturn.Rows[0]["SupplierTermsID"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["SupplierTermsID"];
					m_sNotes = dtToReturn.Rows[0]["Notes"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Notes"];
					m_sCreatedBy = dtToReturn.Rows[0]["CreatedBy"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["CreatedBy"];
					m_daCreatedDate = dtToReturn.Rows[0]["CreatedDate"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["CreatedDate"];
					m_sLastUpdatedBy = dtToReturn.Rows[0]["LastUpdatedBy"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["LastUpdatedBy"];
					m_daLastUpdatedDate = dtToReturn.Rows[0]["LastUpdatedDate"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["LastUpdatedDate"];
					m_bViewStatus = dtToReturn.Rows[0]["ViewStatus"] == System.DBNull.Value ? SqlBoolean.Null : (bool)dtToReturn.Rows[0]["ViewStatus"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("T_Purchase_Order_Header::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_t_Purchase_Order_Header_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("t_Purchase_Order_Header");
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
					throw new Exception("Stored Procedure 'pr_t_Purchase_Order_Header_SelectAll' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("T_Purchase_Order_Header::SelectAll::Error occured.", ex);
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
		/// Purpose: Select method for a foreign key. This method will Select one or more rows from the database, based on the Foreign Key 'POTypeID'
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>POTypeID. May be SqlString.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public DataTable SelectAllWPOTypeIDLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_t_Purchase_Order_Header_SelectAllWPOTypeIDLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("t_Purchase_Order_Header");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPOTypeID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPOTypeID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_t_Purchase_Order_Header_SelectAllWPOTypeIDLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("T_Purchase_Order_Header::SelectAllWPOTypeIDLogic::Error occured.", ex);
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
		/// Purpose: Select method for a foreign key. This method will Select one or more rows from the database, based on the Foreign Key 'SupplierID'
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>SupplierID. May be SqlString.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public DataTable SelectAllWSupplierIDLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_t_Purchase_Order_Header_SelectAllWSupplierIDLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("t_Purchase_Order_Header");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sSupplierID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSupplierID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_t_Purchase_Order_Header_SelectAllWSupplierIDLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("T_Purchase_Order_Header::SelectAllWSupplierIDLogic::Error occured.", ex);
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
		/// Purpose: Select method for a foreign key. This method will Select one or more rows from the database, based on the Foreign Key 'Tax_code_id'
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>Tax_code_id. May be SqlString.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public DataTable SelectAllWTax_code_idLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_t_Purchase_Order_Header_SelectAllWTax_code_idLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("t_Purchase_Order_Header");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTax_code_id", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTax_code_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_t_Purchase_Order_Header_SelectAllWTax_code_idLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("T_Purchase_Order_Header::SelectAllWTax_code_idLogic::Error occured.", ex);
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
		public SqlString PONo
		{
			get
			{
				return m_sPONo;
			}
			set
			{
				SqlString sPONoTmp = (SqlString)value;
				if(sPONoTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("pONo", "pONo can't be NULL");
				}
				m_sPONo = value;
			}
		}


		public SqlDateTime PODate
		{
			get
			{
				return m_daPODate;
			}
			set
			{
				m_daPODate = value;
			}
		}


		public SqlString POTypeID
		{
			get
			{
				return m_sPOTypeID;
			}
			set
			{
				m_sPOTypeID = value;
			}
		}
		public SqlString pOTypeIDOld
		{
			get
			{
				return m_sPOTypeIDOld;
			}
			set
			{
				m_sPOTypeIDOld = value;
			}
		}


		public SqlDateTime DeliveryDate
		{
			get
			{
				return m_daDeliveryDate;
			}
			set
			{
				m_daDeliveryDate = value;
			}
		}


		public SqlString ShipTo
		{
			get
			{
				return m_sShipTo;
			}
			set
			{
				m_sShipTo = value;
			}
		}


		public SqlString SupplierID
		{
			get
			{
				return m_sSupplierID;
			}
			set
			{
				m_sSupplierID = value;
			}
		}
		public SqlString supplierIDOld
		{
			get
			{
				return m_sSupplierIDOld;
			}
			set
			{
				m_sSupplierIDOld = value;
			}
		}


		public SqlDecimal TotalAmt
		{
			get
			{
				return m_dcTotalAmt;
			}
			set
			{
				m_dcTotalAmt = value;
			}
		}


		public SqlString AccountNo
		{
			get
			{
				return m_sAccountNo;
			}
			set
			{
				m_sAccountNo = value;
			}
		}


		public SqlString Tax_code_id
		{
			get
			{
				return m_sTax_code_id;
			}
			set
			{
				m_sTax_code_id = value;
			}
		}
		public SqlString tax_code_idOld
		{
			get
			{
				return m_sTax_code_idOld;
			}
			set
			{
				m_sTax_code_idOld = value;
			}
		}


		public SqlDecimal Discount
		{
			get
			{
				return m_dcDiscount;
			}
			set
			{
				m_dcDiscount = value;
			}
		}


		public SqlDecimal Shipping
		{
			get
			{
				return m_dcShipping;
			}
			set
			{
				m_dcShipping = value;
			}
		}


		public SqlString SupplierTermsID
		{
			get
			{
				return m_sSupplierTermsID;
			}
			set
			{
				m_sSupplierTermsID = value;
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


		public SqlString CreatedBy
		{
			get
			{
				return m_sCreatedBy;
			}
			set
			{
				m_sCreatedBy = value;
			}
		}


		public SqlDateTime CreatedDate
		{
			get
			{
				return m_daCreatedDate;
			}
			set
			{
				m_daCreatedDate = value;
			}
		}


		public SqlString LastUpdatedBy
		{
			get
			{
				return m_sLastUpdatedBy;
			}
			set
			{
				m_sLastUpdatedBy = value;
			}
		}


		public SqlDateTime LastUpdatedDate
		{
			get
			{
				return m_daLastUpdatedDate;
			}
			set
			{
				m_daLastUpdatedDate = value;
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
