///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'WarehouseProductMaster'
// Generated by LLBLGen v1.2.2069.24088 Final on: Friday, September 02, 2005, 2:27:41 PM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Inventory.DataObjects
{
	/// <summary>
	/// Purpose: Data Access class for the table 'WarehouseProductMaster'.
	/// </summary>
	public class WarehouseProductMaster : DBInteractionBase
	{
		#region Class Member Declarations
			private SqlDateTime		m_daDate_last_Receipt, m_daDate_created, m_daDate_last_picked, m_daDate_last_count, m_daDate_qty_zero;
			private SqlInt32		m_iStorage_Unit, m_iQty_prod_pack, m_iOn_hand_qty, m_iPack_weight, m_iWide, m_iProduct_weight, m_iHigh, m_iLength;
			private SqlBinary		m_biTimestamp;
			private SqlString		m_sID, m_sUserID, m_sPackage_Code, m_sProduct_id, m_sProduct_idOld, m_sWarehouse_id;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public WarehouseProductMaster()
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
		///		 <LI>Warehouse_id</LI>
		///		 <LI>Product_id</LI>
		///		 <LI>Package_Code. May be SqlString.Null</LI>
		///		 <LI>Product_weight. May be SqlInt32.Null</LI>
		///		 <LI>Wide. May be SqlInt32.Null</LI>
		///		 <LI>Length. May be SqlInt32.Null</LI>
		///		 <LI>High. May be SqlInt32.Null</LI>
		///		 <LI>Pack_weight. May be SqlInt32.Null</LI>
		///		 <LI>Storage_Unit. May be SqlInt32.Null</LI>
		///		 <LI>Qty_prod_pack. May be SqlInt32.Null</LI>
		///		 <LI>On_hand_qty. May be SqlInt32.Null</LI>
		///		 <LI>Date_created. May be SqlDateTime.Null</LI>
		///		 <LI>Date_last_Receipt. May be SqlDateTime.Null</LI>
		///		 <LI>Date_last_picked. May be SqlDateTime.Null</LI>
		///		 <LI>Date_qty_zero. May be SqlDateTime.Null</LI>
		///		 <LI>Date_last_count. May be SqlDateTime.Null</LI>
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
			scmCmdToExecute.CommandText = "dbo.[pr_WarehouseProductMaster_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sWarehouse_id", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sWarehouse_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sProduct_id", SqlDbType.NChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sProduct_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPackage_Code", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPackage_Code));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iProduct_weight", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iProduct_weight));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iWide", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iWide));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iLength", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iLength));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iHigh", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iHigh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iPack_weight", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iPack_weight));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iStorage_Unit", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iStorage_Unit));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iQty_prod_pack", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iQty_prod_pack));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iOn_hand_qty", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iOn_hand_qty));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daDate_created", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daDate_created));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daDate_last_Receipt", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daDate_last_Receipt));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daDate_last_picked", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daDate_last_picked));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daDate_qty_zero", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daDate_qty_zero));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daDate_last_count", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daDate_last_count));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sUserID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sUserID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_WarehouseProductMaster_Insert' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("WarehouseProductMaster::Insert::Error occured.", ex);
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
		///		 <LI>Warehouse_id</LI>
		///		 <LI>Product_id</LI>
		///		 <LI>Package_Code. May be SqlString.Null</LI>
		///		 <LI>Product_weight. May be SqlInt32.Null</LI>
		///		 <LI>Wide. May be SqlInt32.Null</LI>
		///		 <LI>Length. May be SqlInt32.Null</LI>
		///		 <LI>High. May be SqlInt32.Null</LI>
		///		 <LI>Pack_weight. May be SqlInt32.Null</LI>
		///		 <LI>Storage_Unit. May be SqlInt32.Null</LI>
		///		 <LI>Qty_prod_pack. May be SqlInt32.Null</LI>
		///		 <LI>On_hand_qty. May be SqlInt32.Null</LI>
		///		 <LI>Date_created. May be SqlDateTime.Null</LI>
		///		 <LI>Date_last_Receipt. May be SqlDateTime.Null</LI>
		///		 <LI>Date_last_picked. May be SqlDateTime.Null</LI>
		///		 <LI>Date_qty_zero. May be SqlDateTime.Null</LI>
		///		 <LI>Date_last_count. May be SqlDateTime.Null</LI>
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
			scmCmdToExecute.CommandText = "dbo.[pr_WarehouseProductMaster_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sWarehouse_id", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sWarehouse_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sProduct_id", SqlDbType.NChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sProduct_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPackage_Code", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPackage_Code));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iProduct_weight", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iProduct_weight));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iWide", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iWide));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iLength", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iLength));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iHigh", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iHigh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iPack_weight", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iPack_weight));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iStorage_Unit", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iStorage_Unit));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iQty_prod_pack", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iQty_prod_pack));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iOn_hand_qty", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iOn_hand_qty));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daDate_created", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daDate_created));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daDate_last_Receipt", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daDate_last_Receipt));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daDate_last_picked", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daDate_last_picked));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daDate_qty_zero", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daDate_qty_zero));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daDate_last_count", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daDate_last_count));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sUserID", SqlDbType.VarChar, 36, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sUserID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_WarehouseProductMaster_Update' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("WarehouseProductMaster::Update::Error occured.", ex);
			}
			finally
			{
			}
		}


		/// <summary>
		/// Purpose: Update method for updating one or more rows using the Foreign Key 'Product_id.
		/// This method will Update one or more existing rows in the database. It will reset the field 'Product_id' in
		/// all rows which have as value for this field the value as set in property 'product_idOld' to 
		/// the value as set in property 'product_id'.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>Product_id</LI>
		///		 <LI>Product_idOld</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public bool UpdateAllWProduct_idLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_WarehouseProductMaster_UpdateAllWProduct_idLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sProduct_id", SqlDbType.NChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sProduct_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sProduct_idOld", SqlDbType.NChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sProduct_idOld));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 10, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_WarehouseProductMaster_UpdateAllWProduct_idLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("WarehouseProductMaster::UpdateAllWProduct_idLogic::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_WarehouseProductMaster_Delete]";
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
					throw new Exception("Stored Procedure 'pr_WarehouseProductMaster_Delete' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("WarehouseProductMaster::Delete::Error occured.", ex);
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
		///		 <LI>Warehouse_id</LI>
		///		 <LI>Product_id</LI>
		///		 <LI>Package_Code</LI>
		///		 <LI>Product_weight</LI>
		///		 <LI>Wide</LI>
		///		 <LI>Length</LI>
		///		 <LI>High</LI>
		///		 <LI>Pack_weight</LI>
		///		 <LI>Storage_Unit</LI>
		///		 <LI>Qty_prod_pack</LI>
		///		 <LI>On_hand_qty</LI>
		///		 <LI>Date_created</LI>
		///		 <LI>Date_last_Receipt</LI>
		///		 <LI>Date_last_picked</LI>
		///		 <LI>Date_qty_zero</LI>
		///		 <LI>Date_last_count</LI>
		///		 <LI>UserID</LI>
		///		 <LI>Timestamp</LI>
		/// </UL>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_WarehouseProductMaster_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("WarehouseProductMaster");
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
					throw new Exception("Stored Procedure 'pr_WarehouseProductMaster_SelectOne' reported the ErrorCode: " + m_iErrorCode);
				}

				if(dtToReturn.Rows.Count > 0)
				{
					m_sID = (string)dtToReturn.Rows[0]["ID"];
					m_sWarehouse_id = (string)dtToReturn.Rows[0]["Warehouse_id"];
					m_sProduct_id = (string)dtToReturn.Rows[0]["Product_id"];
					m_sPackage_Code = dtToReturn.Rows[0]["Package Code"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Package Code"];
					m_iProduct_weight = dtToReturn.Rows[0]["Product_weight"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Product_weight"];
					m_iWide = dtToReturn.Rows[0]["Wide"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Wide"];
					m_iLength = dtToReturn.Rows[0]["Length"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Length"];
					m_iHigh = dtToReturn.Rows[0]["High"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["High"];
					m_iPack_weight = dtToReturn.Rows[0]["Pack weight"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Pack weight"];
					m_iStorage_Unit = dtToReturn.Rows[0]["Storage_Unit"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Storage_Unit"];
					m_iQty_prod_pack = dtToReturn.Rows[0]["Qty_prod_pack"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["Qty_prod_pack"];
					m_iOn_hand_qty = dtToReturn.Rows[0]["On_hand_qty"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["On_hand_qty"];
					m_daDate_created = dtToReturn.Rows[0]["Date_created"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Date_created"];
					m_daDate_last_Receipt = dtToReturn.Rows[0]["Date_last_Receipt"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Date_last_Receipt"];
					m_daDate_last_picked = dtToReturn.Rows[0]["Date_last_picked"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Date_last_picked"];
					m_daDate_qty_zero = dtToReturn.Rows[0]["Date_qty_zero"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Date_qty_zero"];
					m_daDate_last_count = dtToReturn.Rows[0]["Date_last_count"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["Date_last_count"];
					m_sUserID = dtToReturn.Rows[0]["UserID"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["UserID"];
					m_biTimestamp = dtToReturn.Rows[0]["Timestamp"] == System.DBNull.Value ? SqlBinary.Null : (byte[])dtToReturn.Rows[0]["Timestamp"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("WarehouseProductMaster::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_WarehouseProductMaster_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("WarehouseProductMaster");
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
					throw new Exception("Stored Procedure 'pr_WarehouseProductMaster_SelectAll' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("WarehouseProductMaster::SelectAll::Error occured.", ex);
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
		/// Purpose: Select method for a foreign key. This method will Select one or more rows from the database, based on the Foreign Key 'Product_id'
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>Product_id</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>ErrorCode</LI>
		/// </UL>
		/// </remarks>
		public DataTable SelectAllWProduct_idLogic()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_WarehouseProductMaster_SelectAllWProduct_idLogic]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("WarehouseProductMaster");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sProduct_id", SqlDbType.NChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sProduct_id));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_WarehouseProductMaster_SelectAllWProduct_idLogic' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("WarehouseProductMaster::SelectAllWProduct_idLogic::Error occured.", ex);
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


		public SqlString Warehouse_id
		{
			get
			{
				return m_sWarehouse_id;
			}
			set
			{
				m_sWarehouse_id = value;
			}
		}


		public SqlString Product_id
		{
			get
			{
				return m_sProduct_id;
			}
			set
			{
				SqlString sProduct_idTmp = (SqlString)value;
				if(sProduct_idTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("product_id", "product_id can't be NULL");
				}
				m_sProduct_id = value;
			}
		}
		public SqlString product_idOld
		{
			get
			{
				return m_sProduct_idOld;
			}
			set
			{
				SqlString sProduct_idOldTmp = (SqlString)value;
				if(sProduct_idOldTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("product_idOld", "product_idOld can't be NULL");
				}
				m_sProduct_idOld = value;
			}
		}


		public SqlString Package_Code
		{
			get
			{
				return m_sPackage_Code;
			}
			set
			{
				m_sPackage_Code = value;
			}
		}


		public SqlInt32 Product_weight
		{
			get
			{
				return m_iProduct_weight;
			}
			set
			{
				m_iProduct_weight = value;
			}
		}


		public SqlInt32 Wide
		{
			get
			{
				return m_iWide;
			}
			set
			{
				m_iWide = value;
			}
		}


		public SqlInt32 Length
		{
			get
			{
				return m_iLength;
			}
			set
			{
				m_iLength = value;
			}
		}


		public SqlInt32 High
		{
			get
			{
				return m_iHigh;
			}
			set
			{
				m_iHigh = value;
			}
		}


		public SqlInt32 Pack_weight
		{
			get
			{
				return m_iPack_weight;
			}
			set
			{
				m_iPack_weight = value;
			}
		}


		public SqlInt32 Storage_Unit
		{
			get
			{
				return m_iStorage_Unit;
			}
			set
			{
				m_iStorage_Unit = value;
			}
		}


		public SqlInt32 Qty_prod_pack
		{
			get
			{
				return m_iQty_prod_pack;
			}
			set
			{
				m_iQty_prod_pack = value;
			}
		}


		public SqlInt32 On_hand_qty
		{
			get
			{
				return m_iOn_hand_qty;
			}
			set
			{
				m_iOn_hand_qty = value;
			}
		}


		public SqlDateTime Date_created
		{
			get
			{
				return m_daDate_created;
			}
			set
			{
				m_daDate_created = value;
			}
		}


		public SqlDateTime Date_last_Receipt
		{
			get
			{
				return m_daDate_last_Receipt;
			}
			set
			{
				m_daDate_last_Receipt = value;
			}
		}


		public SqlDateTime Date_last_picked
		{
			get
			{
				return m_daDate_last_picked;
			}
			set
			{
				m_daDate_last_picked = value;
			}
		}


		public SqlDateTime Date_qty_zero
		{
			get
			{
				return m_daDate_qty_zero;
			}
			set
			{
				m_daDate_qty_zero = value;
			}
		}


		public SqlDateTime Date_last_count
		{
			get
			{
				return m_daDate_last_count;
			}
			set
			{
				m_daDate_last_count = value;
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
