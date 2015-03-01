using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Inventory.DataModels.Warehouse;

namespace Inventory.DataObjects.DAO
{
    public class PickingListDAO : DBInteractionBase
    {
        private SqlCommand cmdCommand = new SqlCommand();
        private PickingListModel objPickingListModel = new PickingListModel(); 
        private DataTable dtPickingListDetails = new DataTable("dtPickingListDetails");

        public DataTable PickingListDetails
        {
            get { return dtPickingListDetails; }
            set { dtPickingListDetails = value; }
        }

        public SqlCommand Command
        {
            get { return cmdCommand; }
            set { cmdCommand = value; }
        }

        public PickingListModel PickingListModel
        {
            get { return objPickingListModel; }
        }

        //public DataTable PickingListDetails
        //{
        //    get { return dtPickingListDetails; }
        //}

        public PickingListDAO()
        {
            this.InitializeDataTable();
        }

        private void InitializeDataTable()
        {
            //Initlialize for dtOutlets.
            dtPickingListDetails.Columns.Add("ID");
            //Set primary key
            DataColumn[] objPrimaryKey = { dtPickingListDetails.Columns["ID"] };
            dtPickingListDetails.PrimaryKey = objPrimaryKey;

            dtPickingListDetails.Columns.Add("PickingListID");
            dtPickingListDetails.Columns.Add("ProductID");
            dtPickingListDetails.Columns.Add("Qty");
            dtPickingListDetails.Columns.Add("FromLocation");
        }
        /*
        public DataTable GetPickingListDetailsBy(string strPickingListID)
        {
            //SqlDataAdapter da = null;
            SqlConnection cn = new SqlConnection(Inventory.Properties.Settings.Default.ConnectionString);
            //StringBuilder sb = new StringBuilder();
            //sb.Append("SELECT PickingListMaster.PickingListID, PickingListMaster.PickingName, PickingListMaster.ReferenceNo, PickingListMaster.DateCreated, ");
            //sb.Append("PickingListMaster.DestLocation, PickingListMaster.DestDepartment, PickingListMaster.OtherDestLocation, PickingListMaster.Notes, ");
            //sb.Append("PickingListMaster.ViewStatus, PickingListMaster.UserID, PickingListMaster.LastUpdatedDate, PickingListDetails.ID, " );
            //sb.Append("PickingListDetails.PickingListID AS Expr1, PickingListDetails.ProductID, PickingListDetails.Qty, PickingListDetails.FromLocation, ");
            //sb.Append("ProductMaster.ProductName, ProductMaster.ProductID AS Expr2 ");
            //sb.Append("FROM PickingListDetails INNER JOIN ");
            //sb.Append("PickingListMaster ON PickingListDetails.PickingListID = '{0}' INNER JOIN ");
            //sb.Append("ProductMaster ON PickingListDetails.ProductID = ProductMaster.ProductID");
            //string strSQL = sb.ToString();
            string strSQL = string.Format("SELECT * FROM VListPickingListDetails WHERE PickingListId = '{0}'", strPickingListID);
            this.cmdCommand.Connection = cn;
            strSQL = string.Format(strSQL, strPickingListID);
            this.cmdCommand.CommandText = strSQL;
            this.cmdCommand.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(this.cmdCommand);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblPickingListDetails");

            DataView dv = ds.Tables[0].DefaultView;

            //dv.RowFilter = "ID = 22222 OR ID = 2224";
            dv.Sort = "ID DESC";

            DataTable dtTemp = dv.ToTable();
            dtTemp.TableName = "tblPickingListDetails";

            return dtTemp;
        }
         * */
        /// <summary>
        /// Adding record
        /// </summary>
        public void Add()
        {
            DataRow dr = dtPickingListDetails.NewRow();
            
            //dr["PickingListID"] = "Four";
            //dr["ProductID"] = 4;
            //dr["FromLocation"] = "Four";
            dtPickingListDetails.Rows.Add(dr);
        }

        public void Delete(string strID)
        {
            DataRow dr = dtPickingListDetails.Rows.Find(strID);
            if (dr == null) return;
            //Deleting record
            dr.Delete();
        }

        public void Edit(string strID)
        {
            //DataRow dr = dtPickingListDetails.Rows.Find(strID);
            //if (dr == null) return;
            ////Editing record
            //dr["Details"] = "Edited Details";
            //dr["RowState"] = dr.RowState.ToString();
            
        }

        public DataTable GetDataView()
        {
            DataView dv = dtPickingListDetails.DefaultView;

            dv.RowFilter = "ID = 2 OR ID = 4";
            dv.Sort = "ID DESC";
            DataTable dtTemp = dv.ToTable();
            dtTemp.TableName = "TableName";

            return dtTemp;
        }

        public DataTable GetPickingListDetails(string strPickingListId)
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            string strSQL = string.Format("SELECT * FROM VListPickingDetails WHERE PickingListId = '{0}'", strPickingListId);
            scmCmdToExecute.CommandText = strSQL;
            scmCmdToExecute.CommandType = CommandType.Text;
            DataTable dtToReturn = new DataTable("ListPickingDetails");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Open connection.
                    m_scoMainConnection.Open();
                }
                else
                {
                    if (m_cpMainConnectionProvider.bIsTransactionPending)
                    {
                        scmCmdToExecute.Transaction = m_cpMainConnectionProvider.stCurrentTransaction;
                    }
                }

                // Execute query.
                sdaAdapter.Fill(dtToReturn);

                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("VListPickingDetails::SelectAll::Error occured.", ex);
            }
            finally
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    m_scoMainConnection.Close();
                }
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

        /// <summary>
        /// Only get the data schema with no data
        /// </summary>
        /// <returns></returns>
        internal DataTable GetEmptyListPickingDetail()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "Select * from VListPickingDetails where 1= 0";
            scmCmdToExecute.CommandType = CommandType.Text;
            DataTable dtToReturn = new DataTable("ListPickingDetails");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Open connection.
                    m_scoMainConnection.Open();
                }
                else
                {
                    if (m_cpMainConnectionProvider.bIsTransactionPending)
                    {
                        scmCmdToExecute.Transaction = m_cpMainConnectionProvider.stCurrentTransaction;
                    }
                }

                // Execute query.
                sdaAdapter.Fill(dtToReturn);

                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("ListPickingDetails::SelectAll::Error occured.", ex);
            }
            finally
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    m_scoMainConnection.Close();
                }
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
    }
}
