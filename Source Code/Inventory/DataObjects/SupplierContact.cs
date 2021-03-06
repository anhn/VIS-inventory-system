///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'SupplierContact'
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
	/// Purpose: Data Access class for the table 'SupplierContact'.
	/// </summary>
	public class SupplierContact : DBInteractionBase
	{
		#region Class Member Declarations
			private SqlDecimal		m_dcBalance, m_dcCredit_limit;
			private SqlInt32		m_iDiscount;
			private SqlString		m_sTax_agent, m_sCurrency, m_sParent_id, m_sPayment_term_id, m_sPayment_term_idOld, m_sSupplierID, m_sContactID, m_sAccount_number, m_sAccountName, m_sTax_code_id, m_sTax_code_idOld;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SupplierContact()
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
		///		 <LI>ContactID</LI>
		///		 <LI>SupplierID. May be SqlString.Null</LI>
		///		 <LI>Payment_term_id. May be SqlString.Null</LI>
		///		 <LI>Tax_code_id. May be SqlString.Null</LI>
		///		 <LI>AccountName. May be SqlString.Null</LI>
		///		 <LI>Account_number. May be SqlString.Null</LI>
		///		 <LI>Credit_limit. May be SqlDecimal.Null</LI>
		///		 <LI>Currency. May be SqlString.Null</LI>
		///		 <LI>Balance. May be SqlDecimal.Null</LI>
		///		 <LI>Discount. May be SqlInt32.Null</LI>
		///		 <LI>Parent_id. May be SqlString.Null</LI>
		///		 <LI>Tax_agent. May be SqlString.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert(SqlCommand scmCmdToExecute)
		{
			scmCmdToExecute.Parameters.Clear();
			scmCmdToExecute.CommandText = "dbo.[pr_SupplierContact_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sContactID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sContactID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sSupplierID", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSupplierID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPayment_term_id", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPayment_term_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTax_code_id", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTax_code_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sAccountName", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sAccountName));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sAccount_number", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sAccount_number));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcCredit_limit", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 2, "", DataRowVersion.Proposed, m_dcCredit_limit));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCurrency", SqlDbType.NVarChar, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCurrency));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcBalance", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 2, "", DataRowVersion.Proposed, m_dcBalance));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iDiscount", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iDiscount));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sParent_id", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sParent_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTax_agent", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTax_agent));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_SupplierContact_Insert' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("SupplierContact::Insert::Error occured.", ex);
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
		///		 <LI>ContactID</LI>
		///		 <LI>SupplierID. May be SqlString.Null</LI>
		///		 <LI>Payment_term_id. May be SqlString.Null</LI>
		///		 <LI>Tax_code_id. May be SqlString.Null</LI>
		///		 <LI>AccountName. May be SqlString.Null</LI>
		///		 <LI>Account_number. May be SqlString.Null</LI>
		///		 <LI>Credit_limit. May be SqlDecimal.Null</LI>
		///		 <LI>Currency. May be SqlString.Null</LI>
		///		 <LI>Balance. May be SqlDecimal.Null</LI>
		///		 <LI>Discount. May be SqlInt32.Null</LI>
		///		 <LI>Parent_id. May be SqlString.Null</LI>
		///		 <LI>Tax_agent. May be SqlString.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Update(SqlCommand scmCmdToExecute)
		{
			scmCmdToExecute.Parameters.Clear();
			scmCmdToExecute.CommandText = "dbo.[pr_SupplierContact_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sContactID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sContactID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sSupplierID", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSupplierID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPayment_term_id", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPayment_term_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTax_code_id", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTax_code_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sAccountName", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sAccountName));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sAccount_number", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sAccount_number));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcCredit_limit", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 2, "", DataRowVersion.Proposed, m_dcCredit_limit));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCurrency", SqlDbType.NVarChar, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCurrency));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcBalance", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 2, "", DataRowVersion.Proposed, m_dcBalance));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iDiscount", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iDiscount));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sParent_id", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sParent_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTax_agent", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTax_agent));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_SupplierContact_Update' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("SupplierContact::Update::Error occured.", ex);
			}
			finally
			{
			}
		}


		/// <summary>
		/// Purpose: Update method for updating one or more rows using the Foreign Key 'Payment_term_id.
		/// This method will Update one or more existing rows in the database. It will reset the field 'Payment_term_id' in
		/// all rows which have as value for this field the value as set in property 'payment_term_idOld' to 
		/// the value as set in property 'payment_term_id'.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>Payment_term_id. May be SqlString.Null</LI>
		///		 <LI>Payment_term_idOld. May be SqlString.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public bool UpdateAllWPayment_term_idLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_SupplierContact_UpdateAllWPayment_term_idLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPayment_term_id", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPayment_term_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPayment_term_idOld", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPayment_term_idOld));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 36, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_SupplierContact_UpdateAllWPayment_term_idLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("SupplierContact::UpdateAllWPayment_term_idLogic::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_SupplierContact_UpdateAllWTax_code_idLogic]";
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
					throw new Exception("Stored Procedure 'pr_SupplierContact_UpdateAllWTax_code_idLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("SupplierContact::UpdateAllWTax_code_idLogic::Error occured.", ex);
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
		///		 <LI>ContactID</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Delete(SqlCommand scmCmdToExecute)
		{
			scmCmdToExecute.Parameters.Clear();
			scmCmdToExecute.CommandText = "dbo.[pr_SupplierContact_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sContactID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sContactID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_SupplierContact_Delete' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("SupplierContact::Delete::Error occured.", ex);
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
		///		 <LI>ContactID</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		///		 <LI>ContactID</LI>
		///		 <LI>SupplierID</LI>
		///		 <LI>Payment_term_id</LI>
		///		 <LI>Tax_code_id</LI>
		///		 <LI>AccountName</LI>
		///		 <LI>Account_number</LI>
		///		 <LI>Credit_limit</LI>
		///		 <LI>Currency</LI>
		///		 <LI>Balance</LI>
		///		 <LI>Discount</LI>
		///		 <LI>Parent_id</LI>
		///		 <LI>Tax_agent</LI>
		/// </UL>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_SupplierContact_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("SupplierContact");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sContactID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sContactID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_SupplierContact_SelectOne' reported the ErrorCode: " + m_iErrorCode);
				}

				if(dtToReturn.Rows.Count > 0)
				{
					m_sContactID = (string)dtToReturn.Rows[0]["ContactID"];
					m_sSupplierID = dtToReturn.Rows[0]["SupplierID"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["SupplierID"];
					m_sPayment_term_id = dtToReturn.Rows[0]["Payment_term_id"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Payment_term_id"];
					m_sTax_code_id = dtToReturn.Rows[0]["Tax_code_id"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Tax_code_id"];
					m_sAccountName = dtToReturn.Rows[0]["AccountName"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["AccountName"];
					m_sAccount_number = dtToReturn.Rows[0]["Account_number"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Account_number"];
					m_dcCredit_limit = dtToReturn.Rows[0]["Credit_limit"] == System.DBNull.Value ? SqlDecimal.Null : (Decimal)dtToReturn.Rows[0]["Credit_limit"];
					m_sCurrency = dtToReturn.Rows[0]["Currency"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Currency"];
					m_dcBalance = dtToReturn.Rows[0]["Balance"] == System.DBNull.Value ? SqlDecimal.Null : (Decimal)dtToReturn.Rows[0]["Balance"];
					m_iDiscount = dtToReturn.Rows[0]["Discount"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Discount"];
					m_sParent_id = dtToReturn.Rows[0]["Parent_id"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Parent_id"];
					m_sTax_agent = dtToReturn.Rows[0]["Tax_agent"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Tax_agent"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("SupplierContact::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_SupplierContact_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("SupplierContact");
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
					throw new Exception("Stored Procedure 'pr_SupplierContact_SelectAll' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("SupplierContact::SelectAll::Error occured.", ex);
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
		/// Purpose: Select method for a foreign key. This method will Select one or more rows from the database, based on the Foreign Key 'Payment_term_id'
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>Payment_term_id. May be SqlString.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public DataTable SelectAllWPayment_term_idLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_SupplierContact_SelectAllWPayment_term_idLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("SupplierContact");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPayment_term_id", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPayment_term_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_SupplierContact_SelectAllWPayment_term_idLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("SupplierContact::SelectAllWPayment_term_idLogic::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_SupplierContact_SelectAllWTax_code_idLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("SupplierContact");
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
					throw new Exception("Stored Procedure 'pr_SupplierContact_SelectAllWTax_code_idLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("SupplierContact::SelectAllWTax_code_idLogic::Error occured.", ex);
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
		public SqlString ContactID
		{
			get
			{
				return m_sContactID;
			}
			set
			{
				SqlString sContactIDTmp = (SqlString)value;
				if(sContactIDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("contactID", "contactID can't be NULL");
				}
				m_sContactID = value;
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


		public SqlString Payment_term_id
		{
			get
			{
				return m_sPayment_term_id;
			}
			set
			{
				m_sPayment_term_id = value;
			}
		}
		public SqlString payment_term_idOld
		{
			get
			{
				return m_sPayment_term_idOld;
			}
			set
			{
				m_sPayment_term_idOld = value;
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


		public SqlString AccountName
		{
			get
			{
				return m_sAccountName;
			}
			set
			{
				m_sAccountName = value;
			}
		}


		public SqlString Account_number
		{
			get
			{
				return m_sAccount_number;
			}
			set
			{
				m_sAccount_number = value;
			}
		}


		public SqlDecimal Credit_limit
		{
			get
			{
				return m_dcCredit_limit;
			}
			set
			{
				m_dcCredit_limit = value;
			}
		}


		public SqlString Currency
		{
			get
			{
				return m_sCurrency;
			}
			set
			{
				m_sCurrency = value;
			}
		}


		public SqlDecimal Balance
		{
			get
			{
				return m_dcBalance;
			}
			set
			{
				m_dcBalance = value;
			}
		}


		public SqlInt32 Discount
		{
			get
			{
				return m_iDiscount;
			}
			set
			{
				m_iDiscount = value;
			}
		}


		public SqlString Parent_id
		{
			get
			{
				return m_sParent_id;
			}
			set
			{
				m_sParent_id = value;
			}
		}


		public SqlString Tax_agent
		{
			get
			{
				return m_sTax_agent;
			}
			set
			{
				m_sTax_agent = value;
			}
		}
		#endregion
	}
}
