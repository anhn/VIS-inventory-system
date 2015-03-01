///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 't_Purchase_Order_Detail'
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
	/// Purpose: Data Access class for the table 't_Purchase_Order_Detail'.
	/// </summary>
	public class T_Purchase_Order_Detail : DBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bViewStatus;
			private SqlDecimal		m_dcPackQty, m_dcOrderQty, m_dcReceiveQty;
			private SqlString		m_sProductUnit, m_sPOLineNo, m_sPONo, m_sPOSupplierProduct, m_sPOProductID;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public T_Purchase_Order_Detail()
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
		///		 <LI>POLineNo</LI>
		///		 <LI>POProductID. May be SqlString.Null</LI>
		///		 <LI>POSupplierProduct. May be SqlString.Null</LI>
		///		 <LI>ProductUnit. May be SqlString.Null</LI>
		///		 <LI>PackQty. May be SqlDecimal.Null</LI>
		///		 <LI>OrderQty. May be SqlDecimal.Null</LI>
		///		 <LI>ReceiveQty. May be SqlDecimal.Null</LI>
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
			scmCmdToExecute.CommandText = "dbo.[pr_t_Purchase_Order_Detail_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPONo", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPONo));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPOLineNo", SqlDbType.NVarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPOLineNo));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPOProductID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPOProductID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPOSupplierProduct", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPOSupplierProduct));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sProductUnit", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sProductUnit));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcPackQty", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 2, "", DataRowVersion.Proposed, m_dcPackQty));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcOrderQty", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 2, "", DataRowVersion.Proposed, m_dcOrderQty));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcReceiveQty", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 2, "", DataRowVersion.Proposed, m_dcReceiveQty));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bViewStatus", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bViewStatus));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_t_Purchase_Order_Detail_Insert' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("T_Purchase_Order_Detail::Insert::Error occured.", ex);
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
		///		 <LI>POLineNo</LI>
		///		 <LI>POProductID. May be SqlString.Null</LI>
		///		 <LI>POSupplierProduct. May be SqlString.Null</LI>
		///		 <LI>ProductUnit. May be SqlString.Null</LI>
		///		 <LI>PackQty. May be SqlDecimal.Null</LI>
		///		 <LI>OrderQty. May be SqlDecimal.Null</LI>
		///		 <LI>ReceiveQty. May be SqlDecimal.Null</LI>
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
			scmCmdToExecute.CommandText = "dbo.[pr_t_Purchase_Order_Detail_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPONo", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPONo));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPOLineNo", SqlDbType.NVarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPOLineNo));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPOProductID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPOProductID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPOSupplierProduct", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPOSupplierProduct));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sProductUnit", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sProductUnit));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcPackQty", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 2, "", DataRowVersion.Proposed, m_dcPackQty));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcOrderQty", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 2, "", DataRowVersion.Proposed, m_dcOrderQty));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcReceiveQty", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 2, "", DataRowVersion.Proposed, m_dcReceiveQty));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bViewStatus", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bViewStatus));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_t_Purchase_Order_Detail_Update' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("T_Purchase_Order_Detail::Update::Error occured.", ex);
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
		///		 <LI>PONo</LI>
		///		 <LI>POLineNo</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Delete(SqlCommand scmCmdToExecute)
		{
			scmCmdToExecute.Parameters.Clear();
			scmCmdToExecute.CommandText = "dbo.[pr_t_Purchase_Order_Detail_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPONo", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPONo));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPOLineNo", SqlDbType.NVarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPOLineNo));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_t_Purchase_Order_Detail_Delete' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("T_Purchase_Order_Detail::Delete::Error occured.", ex);
			}
			finally
			{
			}
		}


		/// <summary>
		/// Purpose: Delete method using PK field 'PONo'. This method will 
		/// delete one or more rows from the database, based on the Primary Key field 'PONo'.
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
		public bool DeleteWPONoLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_t_Purchase_Order_Detail_DeleteWPONoLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPONo", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPONo));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 36, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_t_Purchase_Order_Detail_DeleteWPONoLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("T_Purchase_Order_Detail::DeleteWPONoLogic::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Delete method using PK field 'POLineNo'. This method will 
		/// delete one or more rows from the database, based on the Primary Key field 'POLineNo'.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>POLineNo</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public bool DeleteWPOLineNoLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_t_Purchase_Order_Detail_DeleteWPOLineNoLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPOLineNo", SqlDbType.NVarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPOLineNo));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 36, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_t_Purchase_Order_Detail_DeleteWPOLineNoLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("T_Purchase_Order_Detail::DeleteWPOLineNoLogic::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
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
		///		 <LI>POLineNo</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		///		 <LI>PONo</LI>
		///		 <LI>POLineNo</LI>
		///		 <LI>POProductID</LI>
		///		 <LI>POSupplierProduct</LI>
		///		 <LI>ProductUnit</LI>
		///		 <LI>PackQty</LI>
		///		 <LI>OrderQty</LI>
		///		 <LI>ReceiveQty</LI>
		///		 <LI>ViewStatus</LI>
		/// </UL>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_t_Purchase_Order_Detail_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("t_Purchase_Order_Detail");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPONo", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPONo));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPOLineNo", SqlDbType.NVarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPOLineNo));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_t_Purchase_Order_Detail_SelectOne' reported the ErrorCode: " + m_iErrorCode);
				}

				if(dtToReturn.Rows.Count > 0)
				{
					m_sPONo = (string)dtToReturn.Rows[0]["PONo"];
					m_sPOLineNo = (string)dtToReturn.Rows[0]["POLineNo"];
					m_sPOProductID = dtToReturn.Rows[0]["POProductID"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["POProductID"];
					m_sPOSupplierProduct = dtToReturn.Rows[0]["POSupplierProduct"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["POSupplierProduct"];
					m_sProductUnit = dtToReturn.Rows[0]["ProductUnit"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["ProductUnit"];
					m_dcPackQty = dtToReturn.Rows[0]["PackQty"] == System.DBNull.Value ? SqlDecimal.Null : (Decimal)dtToReturn.Rows[0]["PackQty"];
					m_dcOrderQty = dtToReturn.Rows[0]["OrderQty"] == System.DBNull.Value ? SqlDecimal.Null : (Decimal)dtToReturn.Rows[0]["OrderQty"];
					m_dcReceiveQty = dtToReturn.Rows[0]["ReceiveQty"] == System.DBNull.Value ? SqlDecimal.Null : (Decimal)dtToReturn.Rows[0]["ReceiveQty"];
					m_bViewStatus = dtToReturn.Rows[0]["ViewStatus"] == System.DBNull.Value ? SqlBoolean.Null : (bool)dtToReturn.Rows[0]["ViewStatus"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("T_Purchase_Order_Detail::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_t_Purchase_Order_Detail_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("t_Purchase_Order_Detail");
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
					throw new Exception("Stored Procedure 'pr_t_Purchase_Order_Detail_SelectAll' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("T_Purchase_Order_Detail::SelectAll::Error occured.", ex);
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


		public SqlString POLineNo
		{
			get
			{
				return m_sPOLineNo;
			}
			set
			{
				SqlString sPOLineNoTmp = (SqlString)value;
				if(sPOLineNoTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("pOLineNo", "pOLineNo can't be NULL");
				}
				m_sPOLineNo = value;
			}
		}


		public SqlString POProductID
		{
			get
			{
				return m_sPOProductID;
			}
			set
			{
				m_sPOProductID = value;
			}
		}


		public SqlString POSupplierProduct
		{
			get
			{
				return m_sPOSupplierProduct;
			}
			set
			{
				m_sPOSupplierProduct = value;
			}
		}


		public SqlString ProductUnit
		{
			get
			{
				return m_sProductUnit;
			}
			set
			{
				m_sProductUnit = value;
			}
		}


		public SqlDecimal PackQty
		{
			get
			{
				return m_dcPackQty;
			}
			set
			{
				m_dcPackQty = value;
			}
		}


		public SqlDecimal OrderQty
		{
			get
			{
				return m_dcOrderQty;
			}
			set
			{
				m_dcOrderQty = value;
			}
		}


		public SqlDecimal ReceiveQty
		{
			get
			{
				return m_dcReceiveQty;
			}
			set
			{
				m_dcReceiveQty = value;
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
