///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'Contact'
// Generated by LLBLGen v1.2.2690.36218 Final on: Monday, May 14, 2007, 8:07:33 PM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Inventory.DataObjects
{
	/// <summary>
	/// Purpose: Data Access class for the table 'Contact'.
	/// </summary>
	public class Contact : DBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bSubscribeNews, m_bViewStatus;
			private SqlInt32		m_iContactGroupID;
			private SqlString		m_sFax1, m_sFax2, m_sCell1, m_sCountry, m_sPhone1, m_sPhone2, m_sCell2, m_sWebsite, m_sNotes, m_sUserID, m_sEmail1, m_sEmail2, m_sEmail3, m_sZip, m_sEmailName, m_sLastName, m_sCompanyName, m_sContactName, m_sMr, m_sContactID, m_sMiddleName, m_sFirstName, m_sAddress2, m_sAddress1, m_sProvince, m_sCity, m_sDivision, m_sPosition, m_sAlt_contact, m_sDepartment;
			private SqlBinary		m_biTimestamp, m_biPhoto;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public Contact()
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
		///		 <LI>Mr. May be SqlString.Null</LI>
		///		 <LI>FirstName. May be SqlString.Null</LI>
		///		 <LI>MiddleName. May be SqlString.Null</LI>
		///		 <LI>LastName. May be SqlString.Null</LI>
		///		 <LI>EmailName. May be SqlString.Null</LI>
		///		 <LI>ContactName. May be SqlString.Null</LI>
		///		 <LI>CompanyName. May be SqlString.Null</LI>
		///		 <LI>Alt_contact. May be SqlString.Null</LI>
		///		 <LI>Position. May be SqlString.Null</LI>
		///		 <LI>Department. May be SqlString.Null</LI>
		///		 <LI>Division. May be SqlString.Null</LI>
		///		 <LI>Address1. May be SqlString.Null</LI>
		///		 <LI>Address2. May be SqlString.Null</LI>
		///		 <LI>City. May be SqlString.Null</LI>
		///		 <LI>Province. May be SqlString.Null</LI>
		///		 <LI>Zip. May be SqlString.Null</LI>
		///		 <LI>Country. May be SqlString.Null</LI>
		///		 <LI>Phone1. May be SqlString.Null</LI>
		///		 <LI>Phone2. May be SqlString.Null</LI>
		///		 <LI>Fax1. May be SqlString.Null</LI>
		///		 <LI>Fax2. May be SqlString.Null</LI>
		///		 <LI>Cell1. May be SqlString.Null</LI>
		///		 <LI>Cell2. May be SqlString.Null</LI>
		///		 <LI>Email1. May be SqlString.Null</LI>
		///		 <LI>Email2. May be SqlString.Null</LI>
		///		 <LI>Email3. May be SqlString.Null</LI>
		///		 <LI>Website. May be SqlString.Null</LI>
		///		 <LI>Photo. May be SqlBinary.Null</LI>
		///		 <LI>Notes. May be SqlString.Null</LI>
		///		 <LI>ContactGroupID. May be SqlInt32.Null</LI>
		///		 <LI>SubscribeNews. May be SqlBoolean.Null</LI>
		///		 <LI>ViewStatus. May be SqlBoolean.Null</LI>
		///		 <LI>UserID. May be SqlString.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert(SqlCommand scmCmdToExecute)
		{
			scmCmdToExecute.Parameters.Clear();
			scmCmdToExecute.CommandText = "dbo.[pr_Contact_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sContactID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sContactID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sMr", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMr));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFirstName", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFirstName));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sMiddleName", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMiddleName));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sLastName", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sLastName));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sEmailName", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sEmailName));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sContactName", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sContactName));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCompanyName", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCompanyName));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sAlt_contact", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sAlt_contact));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPosition", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPosition));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDepartment", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDepartment));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDivision", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDivision));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sAddress1", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sAddress1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sAddress2", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sAddress2));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCity", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCity));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sProvince", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sProvince));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sZip", SqlDbType.Char, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sZip));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCountry", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCountry));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPhone1", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPhone1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPhone2", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPhone2));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFax1", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFax1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFax2", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFax2));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCell1", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCell1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCell2", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCell2));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sEmail1", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sEmail1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sEmail2", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sEmail2));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sEmail3", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sEmail3));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sWebsite", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sWebsite));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@biPhoto", SqlDbType.VarBinary, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_biPhoto));
				int	iLength = 0;
				if(!m_sNotes.IsNull)
				{
					iLength = m_sNotes.Value.Length;
				}
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sNotes", SqlDbType.NText, iLength, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNotes));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iContactGroupID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iContactGroupID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bSubscribeNews", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bSubscribeNews));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bViewStatus", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bViewStatus));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sUserID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sUserID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_Contact_Insert' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("Contact::Insert::Error occured.", ex);
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
		///		 <LI>Mr. May be SqlString.Null</LI>
		///		 <LI>FirstName. May be SqlString.Null</LI>
		///		 <LI>MiddleName. May be SqlString.Null</LI>
		///		 <LI>LastName. May be SqlString.Null</LI>
		///		 <LI>EmailName. May be SqlString.Null</LI>
		///		 <LI>ContactName. May be SqlString.Null</LI>
		///		 <LI>CompanyName. May be SqlString.Null</LI>
		///		 <LI>Alt_contact. May be SqlString.Null</LI>
		///		 <LI>Position. May be SqlString.Null</LI>
		///		 <LI>Department. May be SqlString.Null</LI>
		///		 <LI>Division. May be SqlString.Null</LI>
		///		 <LI>Address1. May be SqlString.Null</LI>
		///		 <LI>Address2. May be SqlString.Null</LI>
		///		 <LI>City. May be SqlString.Null</LI>
		///		 <LI>Province. May be SqlString.Null</LI>
		///		 <LI>Zip. May be SqlString.Null</LI>
		///		 <LI>Country. May be SqlString.Null</LI>
		///		 <LI>Phone1. May be SqlString.Null</LI>
		///		 <LI>Phone2. May be SqlString.Null</LI>
		///		 <LI>Fax1. May be SqlString.Null</LI>
		///		 <LI>Fax2. May be SqlString.Null</LI>
		///		 <LI>Cell1. May be SqlString.Null</LI>
		///		 <LI>Cell2. May be SqlString.Null</LI>
		///		 <LI>Email1. May be SqlString.Null</LI>
		///		 <LI>Email2. May be SqlString.Null</LI>
		///		 <LI>Email3. May be SqlString.Null</LI>
		///		 <LI>Website. May be SqlString.Null</LI>
		///		 <LI>Photo. May be SqlBinary.Null</LI>
		///		 <LI>Notes. May be SqlString.Null</LI>
		///		 <LI>ContactGroupID. May be SqlInt32.Null</LI>
		///		 <LI>SubscribeNews. May be SqlBoolean.Null</LI>
		///		 <LI>ViewStatus. May be SqlBoolean.Null</LI>
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
			scmCmdToExecute.CommandText = "dbo.[pr_Contact_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sContactID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sContactID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sMr", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMr));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFirstName", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFirstName));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sMiddleName", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMiddleName));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sLastName", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sLastName));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sEmailName", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sEmailName));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sContactName", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sContactName));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCompanyName", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCompanyName));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sAlt_contact", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sAlt_contact));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPosition", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPosition));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDepartment", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDepartment));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDivision", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDivision));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sAddress1", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sAddress1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sAddress2", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sAddress2));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCity", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCity));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sProvince", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sProvince));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sZip", SqlDbType.Char, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sZip));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCountry", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCountry));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPhone1", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPhone1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPhone2", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPhone2));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFax1", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFax1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFax2", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFax2));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCell1", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCell1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCell2", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCell2));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sEmail1", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sEmail1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sEmail2", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sEmail2));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sEmail3", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sEmail3));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sWebsite", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sWebsite));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@biPhoto", SqlDbType.VarBinary, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_biPhoto));
				int	iLength = 0;
				if(!m_sNotes.IsNull)
				{
					iLength = m_sNotes.Value.Length;
				}
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sNotes", SqlDbType.NText, iLength, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNotes));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iContactGroupID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iContactGroupID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bSubscribeNews", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bSubscribeNews));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bViewStatus", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bViewStatus));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sUserID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sUserID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_Contact_Update' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("Contact::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_Contact_Delete]";
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
					throw new Exception("Stored Procedure 'pr_Contact_Delete' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("Contact::Delete::Error occured.", ex);
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
		///		 <LI>Mr</LI>
		///		 <LI>FirstName</LI>
		///		 <LI>MiddleName</LI>
		///		 <LI>LastName</LI>
		///		 <LI>EmailName</LI>
		///		 <LI>ContactName</LI>
		///		 <LI>CompanyName</LI>
		///		 <LI>Alt_contact</LI>
		///		 <LI>Position</LI>
		///		 <LI>Department</LI>
		///		 <LI>Division</LI>
		///		 <LI>Address1</LI>
		///		 <LI>Address2</LI>
		///		 <LI>City</LI>
		///		 <LI>Province</LI>
		///		 <LI>Zip</LI>
		///		 <LI>Country</LI>
		///		 <LI>Phone1</LI>
		///		 <LI>Phone2</LI>
		///		 <LI>Fax1</LI>
		///		 <LI>Fax2</LI>
		///		 <LI>Cell1</LI>
		///		 <LI>Cell2</LI>
		///		 <LI>Email1</LI>
		///		 <LI>Email2</LI>
		///		 <LI>Email3</LI>
		///		 <LI>Website</LI>
		///		 <LI>Photo</LI>
		///		 <LI>Notes</LI>
		///		 <LI>ContactGroupID</LI>
		///		 <LI>SubscribeNews</LI>
		///		 <LI>ViewStatus</LI>
		///		 <LI>UserID</LI>
		///		 <LI>Timestamp</LI>
		/// </UL>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_Contact_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("Contact");
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
					throw new Exception("Stored Procedure 'pr_Contact_SelectOne' reported the ErrorCode: " + m_iErrorCode);
				}

				if(dtToReturn.Rows.Count > 0)
				{
					m_sContactID = (string)dtToReturn.Rows[0]["ContactID"];
					m_sMr = dtToReturn.Rows[0]["Mr"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Mr"];
					m_sFirstName = dtToReturn.Rows[0]["FirstName"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["FirstName"];
					m_sMiddleName = dtToReturn.Rows[0]["MiddleName"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["MiddleName"];
					m_sLastName = dtToReturn.Rows[0]["LastName"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["LastName"];
					m_sEmailName = dtToReturn.Rows[0]["EmailName"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["EmailName"];
					m_sContactName = dtToReturn.Rows[0]["ContactName"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["ContactName"];
					m_sCompanyName = dtToReturn.Rows[0]["CompanyName"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["CompanyName"];
					m_sAlt_contact = dtToReturn.Rows[0]["Alt_contact"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Alt_contact"];
					m_sPosition = dtToReturn.Rows[0]["Position"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Position"];
					m_sDepartment = dtToReturn.Rows[0]["Department"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Department"];
					m_sDivision = dtToReturn.Rows[0]["Division"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Division"];
					m_sAddress1 = dtToReturn.Rows[0]["Address1"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Address1"];
					m_sAddress2 = dtToReturn.Rows[0]["Address2"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Address2"];
					m_sCity = dtToReturn.Rows[0]["City"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["City"];
					m_sProvince = dtToReturn.Rows[0]["Province"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Province"];
					m_sZip = dtToReturn.Rows[0]["Zip"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Zip"];
					m_sCountry = dtToReturn.Rows[0]["Country"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Country"];
					m_sPhone1 = dtToReturn.Rows[0]["Phone1"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Phone1"];
					m_sPhone2 = dtToReturn.Rows[0]["Phone2"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Phone2"];
					m_sFax1 = dtToReturn.Rows[0]["Fax1"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Fax1"];
					m_sFax2 = dtToReturn.Rows[0]["Fax2"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Fax2"];
					m_sCell1 = dtToReturn.Rows[0]["Cell1"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Cell1"];
					m_sCell2 = dtToReturn.Rows[0]["Cell2"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Cell2"];
					m_sEmail1 = dtToReturn.Rows[0]["Email1"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Email1"];
					m_sEmail2 = dtToReturn.Rows[0]["Email2"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Email2"];
					m_sEmail3 = dtToReturn.Rows[0]["Email3"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Email3"];
					m_sWebsite = dtToReturn.Rows[0]["Website"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Website"];
					m_biPhoto = dtToReturn.Rows[0]["Photo"] == System.DBNull.Value ? SqlBinary.Null : (byte[])dtToReturn.Rows[0]["Photo"];
					m_sNotes = dtToReturn.Rows[0]["Notes"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Notes"];
					m_iContactGroupID = dtToReturn.Rows[0]["ContactGroupID"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ContactGroupID"];
					m_bSubscribeNews = dtToReturn.Rows[0]["SubscribeNews"] == System.DBNull.Value ? SqlBoolean.Null : (bool)dtToReturn.Rows[0]["SubscribeNews"];
					m_bViewStatus = dtToReturn.Rows[0]["ViewStatus"] == System.DBNull.Value ? SqlBoolean.Null : (bool)dtToReturn.Rows[0]["ViewStatus"];
					m_sUserID = dtToReturn.Rows[0]["UserID"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["UserID"];
					m_biTimestamp = dtToReturn.Rows[0]["Timestamp"] == System.DBNull.Value ? SqlBinary.Null : (byte[])dtToReturn.Rows[0]["Timestamp"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("Contact::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_Contact_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("Contact");
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
					throw new Exception("Stored Procedure 'pr_Contact_SelectAll' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("Contact::SelectAll::Error occured.", ex);
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


		public SqlString Mr
		{
			get
			{
				return m_sMr;
			}
			set
			{
				m_sMr = value;
			}
		}


		public SqlString FirstName
		{
			get
			{
				return m_sFirstName;
			}
			set
			{
				m_sFirstName = value;
			}
		}


		public SqlString MiddleName
		{
			get
			{
				return m_sMiddleName;
			}
			set
			{
				m_sMiddleName = value;
			}
		}


		public SqlString LastName
		{
			get
			{
				return m_sLastName;
			}
			set
			{
				m_sLastName = value;
			}
		}


		public SqlString EmailName
		{
			get
			{
				return m_sEmailName;
			}
			set
			{
				m_sEmailName = value;
			}
		}


		public SqlString ContactName
		{
			get
			{
				return m_sContactName;
			}
			set
			{
				m_sContactName = value;
			}
		}


		public SqlString CompanyName
		{
			get
			{
				return m_sCompanyName;
			}
			set
			{
				m_sCompanyName = value;
			}
		}


		public SqlString Alt_contact
		{
			get
			{
				return m_sAlt_contact;
			}
			set
			{
				m_sAlt_contact = value;
			}
		}


		public SqlString Position
		{
			get
			{
				return m_sPosition;
			}
			set
			{
				m_sPosition = value;
			}
		}


		public SqlString Department
		{
			get
			{
				return m_sDepartment;
			}
			set
			{
				m_sDepartment = value;
			}
		}


		public SqlString Division
		{
			get
			{
				return m_sDivision;
			}
			set
			{
				m_sDivision = value;
			}
		}


		public SqlString Address1
		{
			get
			{
				return m_sAddress1;
			}
			set
			{
				m_sAddress1 = value;
			}
		}


		public SqlString Address2
		{
			get
			{
				return m_sAddress2;
			}
			set
			{
				m_sAddress2 = value;
			}
		}


		public SqlString City
		{
			get
			{
				return m_sCity;
			}
			set
			{
				m_sCity = value;
			}
		}


		public SqlString Province
		{
			get
			{
				return m_sProvince;
			}
			set
			{
				m_sProvince = value;
			}
		}


		public SqlString Zip
		{
			get
			{
				return m_sZip;
			}
			set
			{
				m_sZip = value;
			}
		}


		public SqlString Country
		{
			get
			{
				return m_sCountry;
			}
			set
			{
				m_sCountry = value;
			}
		}


		public SqlString Phone1
		{
			get
			{
				return m_sPhone1;
			}
			set
			{
				m_sPhone1 = value;
			}
		}


		public SqlString Phone2
		{
			get
			{
				return m_sPhone2;
			}
			set
			{
				m_sPhone2 = value;
			}
		}


		public SqlString Fax1
		{
			get
			{
				return m_sFax1;
			}
			set
			{
				m_sFax1 = value;
			}
		}


		public SqlString Fax2
		{
			get
			{
				return m_sFax2;
			}
			set
			{
				m_sFax2 = value;
			}
		}


		public SqlString Cell1
		{
			get
			{
				return m_sCell1;
			}
			set
			{
				m_sCell1 = value;
			}
		}


		public SqlString Cell2
		{
			get
			{
				return m_sCell2;
			}
			set
			{
				m_sCell2 = value;
			}
		}


		public SqlString Email1
		{
			get
			{
				return m_sEmail1;
			}
			set
			{
				m_sEmail1 = value;
			}
		}


		public SqlString Email2
		{
			get
			{
				return m_sEmail2;
			}
			set
			{
				m_sEmail2 = value;
			}
		}


		public SqlString Email3
		{
			get
			{
				return m_sEmail3;
			}
			set
			{
				m_sEmail3 = value;
			}
		}


		public SqlString Website
		{
			get
			{
				return m_sWebsite;
			}
			set
			{
				m_sWebsite = value;
			}
		}


		public SqlBinary Photo
		{
			get
			{
				return m_biPhoto;
			}
			set
			{
				m_biPhoto = value;
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


		public SqlInt32 ContactGroupID
		{
			get
			{
				return m_iContactGroupID;
			}
			set
			{
				m_iContactGroupID = value;
			}
		}


		public SqlBoolean SubscribeNews
		{
			get
			{
				return m_bSubscribeNews;
			}
			set
			{
				m_bSubscribeNews = value;
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


		public SqlBinary Timestamp
		{
			get
			{
				return m_biTimestamp;
			}
			set
			{
				m_biTimestamp = value;
			}
		}
		#endregion
	}
}