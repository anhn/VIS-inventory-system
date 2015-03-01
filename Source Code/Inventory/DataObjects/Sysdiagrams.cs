///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'sysdiagrams'
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
	/// Purpose: Data Access class for the table 'sysdiagrams'.
	/// </summary>
	public class Sysdiagrams : DBInteractionBase
	{
		#region Class Member Declarations
			private SqlInt32		m_iDiagram_id, m_iVersion, m_iPrincipal_id;
			private SqlString		m_sName;
			private SqlBinary		m_biDefinition;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public Sysdiagrams()
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
		///		 <LI>Name</LI>
		///		 <LI>Principal_id</LI>
		///		 <LI>Version. May be SqlInt32.Null</LI>
		///		 <LI>Definition. May be SqlBinary.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>Diagram_id</LI>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert(SqlCommand scmCmdToExecute)
		{
			scmCmdToExecute.Parameters.Clear();
			scmCmdToExecute.CommandText = "dbo.[pr_sysdiagrams_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sname", SqlDbType.NVarChar, 128, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sName));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iprincipal_id", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iPrincipal_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iversion", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iVersion));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bidefinition", SqlDbType.VarBinary, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_biDefinition));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@idiagram_id", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iDiagram_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iDiagram_id = (Int32)scmCmdToExecute.Parameters["@idiagram_id"].Value;
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_sysdiagrams_Insert' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("Sysdiagrams::Insert::Error occured.", ex);
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
		///		 <LI>Name</LI>
		///		 <LI>Principal_id</LI>
		///		 <LI>Diagram_id</LI>
		///		 <LI>Version. May be SqlInt32.Null</LI>
		///		 <LI>Definition. May be SqlBinary.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Update(SqlCommand scmCmdToExecute)
		{
			scmCmdToExecute.Parameters.Clear();
			scmCmdToExecute.CommandText = "dbo.[pr_sysdiagrams_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sname", SqlDbType.NVarChar, 128, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sName));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iprincipal_id", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iPrincipal_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@idiagram_id", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iDiagram_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iversion", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iVersion));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bidefinition", SqlDbType.VarBinary, -1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_biDefinition));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_sysdiagrams_Update' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("Sysdiagrams::Update::Error occured.", ex);
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
		///		 <LI>Diagram_id</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Delete(SqlCommand scmCmdToExecute)
		{
			scmCmdToExecute.Parameters.Clear();
			scmCmdToExecute.CommandText = "dbo.[pr_sysdiagrams_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@idiagram_id", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iDiagram_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_sysdiagrams_Delete' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("Sysdiagrams::Delete::Error occured.", ex);
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
		///		 <LI>Diagram_id</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		///		 <LI>Name</LI>
		///		 <LI>Principal_id</LI>
		///		 <LI>Diagram_id</LI>
		///		 <LI>Version</LI>
		///		 <LI>Definition</LI>
		/// </UL>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_sysdiagrams_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("sysdiagrams");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@idiagram_id", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iDiagram_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_sysdiagrams_SelectOne' reported the ErrorCode: " + m_iErrorCode);
				}

				if(dtToReturn.Rows.Count > 0)
				{
					m_sName = (string)dtToReturn.Rows[0]["name"];
					m_iPrincipal_id = (Int32)dtToReturn.Rows[0]["principal_id"];
					m_iDiagram_id = (Int32)dtToReturn.Rows[0]["diagram_id"];
					m_iVersion = dtToReturn.Rows[0]["version"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["version"];
					m_biDefinition = dtToReturn.Rows[0]["definition"] == System.DBNull.Value ? SqlBinary.Null : (byte[])dtToReturn.Rows[0]["definition"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("Sysdiagrams::SelectOne::Error occured.", ex);
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
		/// Purpose: Select method for a unique field. This method will Select one row from the database, based on the unique field 'name'
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>Name</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		///		 <LI>Name</LI>
		///		 <LI>Principal_id</LI>
		///		 <LI>Diagram_id</LI>
		///		 <LI>Version</LI>
		///		 <LI>Definition</LI>
		/// </UL>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public DataTable SelectOneWnameLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_sysdiagrams_SelectOneWnameLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("sysdiagrams");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sname", SqlDbType.NVarChar, 128, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sName));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_sysdiagrams_SelectOneWnameLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				if(dtToReturn.Rows.Count > 0)
				{
					m_sName = (string)dtToReturn.Rows[0]["name"];
					m_iPrincipal_id = (Int32)dtToReturn.Rows[0]["principal_id"];
					m_iDiagram_id = (Int32)dtToReturn.Rows[0]["diagram_id"];
					m_iVersion = dtToReturn.Rows[0]["version"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["version"];
					m_biDefinition = dtToReturn.Rows[0]["definition"] == System.DBNull.Value ? SqlBinary.Null : (byte[])dtToReturn.Rows[0]["definition"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("Sysdiagrams::SelectOneWnameLogic::Error occured.", ex);
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
		/// Purpose: Select method for a unique field. This method will Select one row from the database, based on the unique field 'principal_id'
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>Principal_id</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		///		 <LI>Name</LI>
		///		 <LI>Principal_id</LI>
		///		 <LI>Diagram_id</LI>
		///		 <LI>Version</LI>
		///		 <LI>Definition</LI>
		/// </UL>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public DataTable SelectOneWprincipal_idLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_sysdiagrams_SelectOneWprincipal_idLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("sysdiagrams");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iprincipal_id", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iPrincipal_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_sysdiagrams_SelectOneWprincipal_idLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				if(dtToReturn.Rows.Count > 0)
				{
					m_sName = (string)dtToReturn.Rows[0]["name"];
					m_iPrincipal_id = (Int32)dtToReturn.Rows[0]["principal_id"];
					m_iDiagram_id = (Int32)dtToReturn.Rows[0]["diagram_id"];
					m_iVersion = dtToReturn.Rows[0]["version"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["version"];
					m_biDefinition = dtToReturn.Rows[0]["definition"] == System.DBNull.Value ? SqlBinary.Null : (byte[])dtToReturn.Rows[0]["definition"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("Sysdiagrams::SelectOneWprincipal_idLogic::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_sysdiagrams_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("sysdiagrams");
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
					throw new Exception("Stored Procedure 'pr_sysdiagrams_SelectAll' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("Sysdiagrams::SelectAll::Error occured.", ex);
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
		public SqlString Name
		{
			get
			{
				return m_sName;
			}
			set
			{
				SqlString sNameTmp = (SqlString)value;
				if(sNameTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("name", "name can't be NULL");
				}
				m_sName = value;
			}
		}


		public SqlInt32 Principal_id
		{
			get
			{
				return m_iPrincipal_id;
			}
			set
			{
				SqlInt32 iPrincipal_idTmp = (SqlInt32)value;
				if(iPrincipal_idTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("principal_id", "principal_id can't be NULL");
				}
				m_iPrincipal_id = value;
			}
		}


		public SqlInt32 Diagram_id
		{
			get
			{
				return m_iDiagram_id;
			}
			set
			{
				SqlInt32 iDiagram_idTmp = (SqlInt32)value;
				if(iDiagram_idTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("diagram_id", "diagram_id can't be NULL");
				}
				m_iDiagram_id = value;
			}
		}


		public SqlInt32 Version
		{
			get
			{
				return m_iVersion;
			}
			set
			{
				m_iVersion = value;
			}
		}


		public SqlBinary Definition
		{
			get
			{
				return m_biDefinition;
			}
			set
			{
				m_biDefinition = value;
			}
		}
		#endregion
	}
}