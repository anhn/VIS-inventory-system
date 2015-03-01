///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the view 'VListContact'
// Generated by LLBLGen v1.2.2690.36218 Final on: Monday, May 14, 2007, 8:07:36 PM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Inventory.DataObjects
{
	/// <summary>
	/// Purpose: Data Access class for the view 'VListContact'.
	/// </summary>
	public class VListContact : DBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bViewStatus, m_bSubscribeNews;
			private SqlInt32		m_iContact_Group_ID;
			private SqlBinary		m_biPhoto, m_biFax_2, m_biTimestamp;
			private SqlString		m_sCell_1, m_sCell_2, m_sFax_1, m_sPhone_2, m_sNotes, m_sUserID, m_sEmail_3, m_sEmail_1, m_sEmail_2, m_sPhone_1, m_sLast_Name, m_sEmail_Name, m_sPosition, m_sMiddle_Name, m_sContact_ID, m_sMr, m_sFirst_Name, m_sDepartment, m_sProvince, m_sZip, m_sCountry, m_sCity, m_sDivision, m_sAddress_1, m_sAddress_2;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VListContact()
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
		///		 <LI>Contact_ID</LI>
		///		 <LI>Mr. May be SqlString.Null</LI>
		///		 <LI>First_Name. May be SqlString.Null</LI>
		///		 <LI>Middle_Name. May be SqlString.Null</LI>
		///		 <LI>Last_Name. May be SqlString.Null</LI>
		///		 <LI>Email_Name. May be SqlString.Null</LI>
		///		 <LI>Position. May be SqlString.Null</LI>
		///		 <LI>Department. May be SqlString.Null</LI>
		///		 <LI>Division. May be SqlString.Null</LI>
		///		 <LI>Address_1. May be SqlString.Null</LI>
		///		 <LI>Address_2. May be SqlString.Null</LI>
		///		 <LI>City. May be SqlString.Null</LI>
		///		 <LI>Province. May be SqlString.Null</LI>
		///		 <LI>Zip. May be SqlString.Null</LI>
		///		 <LI>Country. May be SqlString.Null</LI>
		///		 <LI>Phone_1. May be SqlString.Null</LI>
		///		 <LI>Phone_2. May be SqlString.Null</LI>
		///		 <LI>Fax_1. May be SqlString.Null</LI>
		///		 <LI>Fax_2. May be SqlBinary.Null</LI>
		///		 <LI>Cell_1. May be SqlString.Null</LI>
		///		 <LI>Cell_2. May be SqlString.Null</LI>
		///		 <LI>Email_1. May be SqlString.Null</LI>
		///		 <LI>Email_2. May be SqlString.Null</LI>
		///		 <LI>Email_3. May be SqlString.Null</LI>
		///		 <LI>Photo. May be SqlBinary.Null</LI>
		///		 <LI>Notes. May be SqlString.Null</LI>
		///		 <LI>Contact_Group_ID. May be SqlInt32.Null</LI>
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
			scmCmdToExecute.CommandText = "dbo.[pr_VListContact_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sContact_ID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sContact_ID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sMr", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMr));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFirst_Name", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFirst_Name));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sMiddle_Name", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMiddle_Name));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sLast_Name", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sLast_Name));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sEmail_Name", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sEmail_Name));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPosition", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPosition));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDepartment", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDepartment));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDivision", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDivision));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sAddress_1", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sAddress_1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sAddress_2", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sAddress_2));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCity", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCity));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sProvince", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sProvince));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sZip", SqlDbType.Char, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sZip));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCountry", SqlDbType.NVarChar, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCountry));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPhone_1", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPhone_1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPhone_2", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPhone_2));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sFax_1", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sFax_1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@biFax_2", SqlDbType.VarBinary, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_biFax_2));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCell_1", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCell_1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCell_2", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCell_2));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sEmail_1", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sEmail_1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sEmail_2", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sEmail_2));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sEmail_3", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sEmail_3));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@biPhoto", SqlDbType.VarBinary, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_biPhoto));
				int	iLength = 0;
				if(!m_sNotes.IsNull)
				{
					iLength = m_sNotes.Value.Length;
				}
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sNotes", SqlDbType.NText, iLength, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNotes));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iContact_Group_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iContact_Group_ID));
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
					throw new Exception("Stored Procedure 'pr_VListContact_Insert' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("VListContact::Insert::Error occured.", ex);
			}
			finally
			{
			}
		}


		/// <summary>
		/// Purpose: SelectAll method. This method will Select all rows from the view.
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
			scmCmdToExecute.CommandText = "dbo.[pr_VListContact_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("VListContact");
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
					throw new Exception("Stored Procedure 'pr_VListContact_SelectAll' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("VListContact::SelectAll::Error occured.", ex);
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
		public SqlString Contact_ID
		{
			get
			{
				return m_sContact_ID;
			}
			set
			{
				SqlString sContact_IDTmp = (SqlString)value;
				if(sContact_IDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("contact_ID", "contact_ID can't be NULL");
				}
				m_sContact_ID = value;
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


		public SqlString First_Name
		{
			get
			{
				return m_sFirst_Name;
			}
			set
			{
				m_sFirst_Name = value;
			}
		}


		public SqlString Middle_Name
		{
			get
			{
				return m_sMiddle_Name;
			}
			set
			{
				m_sMiddle_Name = value;
			}
		}


		public SqlString Last_Name
		{
			get
			{
				return m_sLast_Name;
			}
			set
			{
				m_sLast_Name = value;
			}
		}


		public SqlString Email_Name
		{
			get
			{
				return m_sEmail_Name;
			}
			set
			{
				m_sEmail_Name = value;
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


		public SqlString Address_1
		{
			get
			{
				return m_sAddress_1;
			}
			set
			{
				m_sAddress_1 = value;
			}
		}


		public SqlString Address_2
		{
			get
			{
				return m_sAddress_2;
			}
			set
			{
				m_sAddress_2 = value;
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


		public SqlString Phone_1
		{
			get
			{
				return m_sPhone_1;
			}
			set
			{
				m_sPhone_1 = value;
			}
		}


		public SqlString Phone_2
		{
			get
			{
				return m_sPhone_2;
			}
			set
			{
				m_sPhone_2 = value;
			}
		}


		public SqlString Fax_1
		{
			get
			{
				return m_sFax_1;
			}
			set
			{
				m_sFax_1 = value;
			}
		}


		public SqlBinary Fax_2
		{
			get
			{
				return m_biFax_2;
			}
			set
			{
				m_biFax_2 = value;
			}
		}


		public SqlString Cell_1
		{
			get
			{
				return m_sCell_1;
			}
			set
			{
				m_sCell_1 = value;
			}
		}


		public SqlString Cell_2
		{
			get
			{
				return m_sCell_2;
			}
			set
			{
				m_sCell_2 = value;
			}
		}


		public SqlString Email_1
		{
			get
			{
				return m_sEmail_1;
			}
			set
			{
				m_sEmail_1 = value;
			}
		}


		public SqlString Email_2
		{
			get
			{
				return m_sEmail_2;
			}
			set
			{
				m_sEmail_2 = value;
			}
		}


		public SqlString Email_3
		{
			get
			{
				return m_sEmail_3;
			}
			set
			{
				m_sEmail_3 = value;
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


		public SqlInt32 Contact_Group_ID
		{
			get
			{
				return m_iContact_Group_ID;
			}
			set
			{
				m_iContact_Group_ID = value;
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
