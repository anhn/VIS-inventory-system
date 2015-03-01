////////////////////////////////////////////////////////////////////////////////
// Description: Base class for Database Interaction.                       
// Generated by LLBLGen v1.2.2688.20139 Final on: Saturday, May 12, 2007, 6:23:56 PM
// Because this class implements IDisposable, derived classes shouldn't do so.
///////////////////////////////////////////////////////////////////////////////
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Inventory.DataObjects
{
	/// <summary>
	/// Purpose: Error Enums used by this LLBL library.
	/// </summary>
	public enum LLBLError
	{
		AllOk
		// Add more here (check the comma's!)
	}


	/// <summary>
	/// Purpose: General interface of the API generated. Contains only common methods of all classes.
	/// </summary>
	public interface ICommonDBAccess
	{
        
        bool Insert(SqlCommand scmCmdToExecute);
        bool Update(SqlCommand scmCmdToExecute);
        bool Delete(SqlCommand scmCmdToExecute);
		DataTable	SelectOne();
		DataTable	SelectAll();
        DataTable SelectViewable();
	}


	/// <summary>
	/// Purpose: Abstract base class for Database Interaction classes.
	/// </summary>
	public abstract class DBInteractionBase : IDisposable, ICommonDBAccess
	{
		#region Class Member Declarations
			protected	SqlConnection			m_scoMainConnection;
			protected	SqlInt32				m_iErrorCode;
			protected	bool					m_bMainConnectionIsCreatedLocal;
			protected	ConnectionProvider	m_cpMainConnectionProvider;
			private		bool					m_bIsDisposed;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DBInteractionBase()
		{
			// Initialize the class' members.
			InitClass();
		}


		/// <summary>
		/// Purpose: Initializes class members.
		/// </summary>
		private void InitClass()
		{
			// create all the objects and initialize other members.
			m_scoMainConnection = new SqlConnection();
			m_bMainConnectionIsCreatedLocal = true;
			m_cpMainConnectionProvider = null;
			AppSettingsReader m_asrConfigReader = new AppSettingsReader();

			// Set connection string of the sqlconnection object
			m_scoMainConnection.ConnectionString = Properties.Settings.Default.ConnectionString;
			m_iErrorCode = (int)LLBLError.AllOk;
			m_bIsDisposed = false;
		}


		/// <summary>
		/// Purpose: Implements the IDispose' method Dispose.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}


		/// <summary>
		/// Purpose: Implements the Dispose functionality.
		/// </summary>
		protected virtual void Dispose(bool bIsDisposing)
		{
			// Check to see if Dispose has already been called.
			if(!m_bIsDisposed)
			{
				if(bIsDisposing)
				{
					// Dispose managed resources.
					if(m_bMainConnectionIsCreatedLocal)
					{
						// Object is created in this class, so destroy it here.
						m_scoMainConnection.Close();
						m_scoMainConnection.Dispose();
						m_bMainConnectionIsCreatedLocal = false;
					}
					m_cpMainConnectionProvider = null;
					m_scoMainConnection = null;
				}
			}
			m_bIsDisposed = true;
		}

        

		/// <summary>
		/// Purpose: Implements the ICommonDBAccess.Insert() method.
		/// </summary>
        public virtual bool Insert(SqlCommand scmCmdToExecute)
		{
			// No implementation, throw exception
			throw new NotImplementedException();
		}


		/// <summary>
		/// Purpose: Implements the ICommonDBAccess.Delete() method.
		/// </summary>
        public virtual bool Delete(SqlCommand scmCmdToExecute)
		{
			// No implementation, throw exception
			throw new NotImplementedException();
		}


		/// <summary>
		/// Purpose: Implements the ICommonDBAccess.Update() method.
		/// </summary>
        public virtual bool Update(SqlCommand scmCmdToExecute)
		{
			// No implementation, throw exception
			throw new NotImplementedException();
		}


		/// <summary>
		/// Purpose: Implements the ICommonDBAccess.SelectOne() method.
		/// </summary>
		public virtual DataTable SelectOne()
		{
			// No implementation, throw exception
			throw new NotImplementedException();
		}


		/// <summary>
		/// Purpose: Implements the ICommonDBAccess.SelectAll() method.
		/// </summary>
		public virtual DataTable SelectAll()
		{
			// No implementation, throw exception
			throw new NotImplementedException();
		}

        public virtual DataTable SelectAllTrueViewStatus()
        {
            // No implementation, throw exception
            throw new NotImplementedException();
        }

        /// <summary>
        /// Purpose: Implements the ICommonDBAccess.SelectViewable() method.
        /// </summary>
        public virtual DataTable SelectViewable()
        {
            // No implementation, throw exception
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// Generate new UUID
        /// </summary>
        /// <returns></returns>
        public String NewId()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "select newid() id  ";
            scmCmdToExecute.CommandType = CommandType.Text;
            DataTable dtToReturn = new DataTable("ID");
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
                    throw new Exception("Stored Procedure 'pr_DeliveryMethod_SelectAll' reported the ErrorCode: " + m_iErrorCode);
                }

                //Return the ID generated by database
                return dtToReturn.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("DeliveryMethod::SelectAll::Error occured.", ex);
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
		public ConnectionProvider cpMainConnectionProvider
		{
			set
			{
				if(value==null)
				{
					// Invalid value
					throw new ArgumentNullException("cpMainConnectionProvider", "Null passed as value to this property which is not allowed.");
				}

				// A connection provider object is passed to this class.
				// Retrieve the SqlConnection object, if present and create a
				// reference to it. If there is already a MainConnection object
				// referenced by the membervar, destroy that one or simply 
				// remove the reference, based on the flag.
				if(m_scoMainConnection!=null)
				{
					// First get rid of current connection object. Caller is responsible
					if(m_bMainConnectionIsCreatedLocal)
					{
						// Is local created object, close it and dispose it.
						m_scoMainConnection.Close();
						m_scoMainConnection.Dispose();
					}
					// Remove reference.
					m_scoMainConnection = null;
				}
				m_cpMainConnectionProvider = (ConnectionProvider)value;
				m_scoMainConnection = m_cpMainConnectionProvider.scoDBConnection;
				m_bMainConnectionIsCreatedLocal = false;
			}
		}


		public SqlInt32 iErrorCode
		{
			get
			{
				return m_iErrorCode;
			}
		}
		#endregion
	}
}
