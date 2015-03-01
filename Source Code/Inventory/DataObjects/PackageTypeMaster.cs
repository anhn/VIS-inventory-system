///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'Package Type Master'
// Generated by LLBLGen v1.2.2690.36218 Final on: Monday, May 14, 2007, 8:07:34 PM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Inventory.DataObjects
{
	/// <summary>
	/// Purpose: Data Access class for the table 'Package Type Master'.
	/// </summary>
	public class PackageTypeMaster : DBInteractionBase
	{
		#region Class Member Declarations
			private SqlInt32		m_iMax_width, m_iMax_height, m_iType_weight, m_iStorage_volume, m_iMax_weight, m_iMax_length;
			private SqlBinary		m_biTimestamp;
			private SqlString		m_sUserID, m_sStorage_pack_text, m_sPackage_type;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PackageTypeMaster()
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
		///		 <LI>Package_type</LI>
		///		 <LI>Storage_pack_text. May be SqlString.Null</LI>
		///		 <LI>Max_weight. May be SqlInt32.Null</LI>
		///		 <LI>Max_length. May be SqlInt32.Null</LI>
		///		 <LI>Max_height. May be SqlInt32.Null</LI>
		///		 <LI>Max_width. May be SqlInt32.Null</LI>
		///		 <LI>Storage_volume. May be SqlInt32.Null</LI>
		///		 <LI>Type_weight. May be SqlInt32.Null</LI>
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
			scmCmdToExecute.CommandText = "dbo.[pr_Package Type Master_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPackage_type", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPackage_type));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sStorage_pack_text", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sStorage_pack_text));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iMax_weight", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iMax_weight));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iMax_length", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iMax_length));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iMax_height", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iMax_height));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iMax_width", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iMax_width));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iStorage_volume", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iStorage_volume));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iType_weight", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iType_weight));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sUserID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sUserID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_Package Type Master_Insert' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("PackageTypeMaster::Insert::Error occured.", ex);
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
		///		 <LI>Package_type</LI>
		///		 <LI>Storage_pack_text. May be SqlString.Null</LI>
		///		 <LI>Max_weight. May be SqlInt32.Null</LI>
		///		 <LI>Max_length. May be SqlInt32.Null</LI>
		///		 <LI>Max_height. May be SqlInt32.Null</LI>
		///		 <LI>Max_width. May be SqlInt32.Null</LI>
		///		 <LI>Storage_volume. May be SqlInt32.Null</LI>
		///		 <LI>Type_weight. May be SqlInt32.Null</LI>
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
			scmCmdToExecute.CommandText = "dbo.[pr_Package Type Master_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPackage_type", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPackage_type));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sStorage_pack_text", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sStorage_pack_text));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iMax_weight", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iMax_weight));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iMax_length", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iMax_length));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iMax_height", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iMax_height));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iMax_width", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iMax_width));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iStorage_volume", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iStorage_volume));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iType_weight", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iType_weight));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sUserID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sUserID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_Package Type Master_Update' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("PackageTypeMaster::Update::Error occured.", ex);
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
		///		 <LI>Package_type</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Delete(SqlCommand scmCmdToExecute)
		{
			scmCmdToExecute.Parameters.Clear();
			scmCmdToExecute.CommandText = "dbo.[pr_Package Type Master_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPackage_type", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPackage_type));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_Package Type Master_Delete' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("PackageTypeMaster::Delete::Error occured.", ex);
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
		///		 <LI>Package_type</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		///		 <LI>Package_type</LI>
		///		 <LI>Storage_pack_text</LI>
		///		 <LI>Max_weight</LI>
		///		 <LI>Max_length</LI>
		///		 <LI>Max_height</LI>
		///		 <LI>Max_width</LI>
		///		 <LI>Storage_volume</LI>
		///		 <LI>Type_weight</LI>
		///		 <LI>UserID</LI>
		///		 <LI>Timestamp</LI>
		/// </UL>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_Package Type Master_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("Package Type Master");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPackage_type", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPackage_type));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_Package Type Master_SelectOne' reported the ErrorCode: " + m_iErrorCode);
				}

				if(dtToReturn.Rows.Count > 0)
				{
					m_sPackage_type = (string)dtToReturn.Rows[0]["Package_type"];
					m_sStorage_pack_text = dtToReturn.Rows[0]["Storage pack text"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Storage pack text"];
					m_iMax_weight = dtToReturn.Rows[0]["Max_weight"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Max_weight"];
					m_iMax_length = dtToReturn.Rows[0]["Max_length"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Max_length"];
					m_iMax_height = dtToReturn.Rows[0]["Max_height"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Max_height"];
					m_iMax_width = dtToReturn.Rows[0]["Max_width"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Max_width"];
					m_iStorage_volume = dtToReturn.Rows[0]["Storage_volume"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Storage_volume"];
					m_iType_weight = dtToReturn.Rows[0]["Type_weight"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Type_weight"];
					m_sUserID = dtToReturn.Rows[0]["UserID"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["UserID"];
					m_biTimestamp = dtToReturn.Rows[0]["Timestamp"] == System.DBNull.Value ? SqlBinary.Null : (byte[])dtToReturn.Rows[0]["Timestamp"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("PackageTypeMaster::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_Package Type Master_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("Package Type Master");
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
					throw new Exception("Stored Procedure 'pr_Package Type Master_SelectAll' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("PackageTypeMaster::SelectAll::Error occured.", ex);
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
		public SqlString Package_type
		{
			get
			{
				return m_sPackage_type;
			}
			set
			{
				m_sPackage_type = value;
			}
		}


		public SqlString Storage_pack_text
		{
			get
			{
				return m_sStorage_pack_text;
			}
			set
			{
				m_sStorage_pack_text = value;
			}
		}


		public SqlInt32 Max_weight
		{
			get
			{
				return m_iMax_weight;
			}
			set
			{
				m_iMax_weight = value;
			}
		}


		public SqlInt32 Max_length
		{
			get
			{
				return m_iMax_length;
			}
			set
			{
				m_iMax_length = value;
			}
		}


		public SqlInt32 Max_height
		{
			get
			{
				return m_iMax_height;
			}
			set
			{
				m_iMax_height = value;
			}
		}


		public SqlInt32 Max_width
		{
			get
			{
				return m_iMax_width;
			}
			set
			{
				m_iMax_width = value;
			}
		}


		public SqlInt32 Storage_volume
		{
			get
			{
				return m_iStorage_volume;
			}
			set
			{
				m_iStorage_volume = value;
			}
		}


		public SqlInt32 Type_weight
		{
			get
			{
				return m_iType_weight;
			}
			set
			{
				m_iType_weight = value;
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
