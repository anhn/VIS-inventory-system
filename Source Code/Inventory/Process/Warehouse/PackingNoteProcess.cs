using System;
using System.Collections.Generic;
using System.Text;
using Inventory.DataModels.Warehouse;
using Inventory.DataObjects;
using System.Data.SqlClient;
using System.Data;
using Inventory.DataModels;

namespace Inventory.Process.Warehouse
{
    public class PackingNoteProcess
    {
        private PackingListModel model;
        private SqlCommand objCmd;

        public PackingListModel DataIn
        {
            get { return model; }
            set { model = value; }
        }
        public SqlCommand DBCommand
        {
            get { return objCmd; }
            set { objCmd = value; }
        }
        public void NewPackingList()
        {
            NewPackingListNoAdjust();

            ProcessPackingList(model.PackingDetails);
        }

        internal void EditPackingList()
        {
            //throw new Exception("The method or operation is not implemented.");
            PackingListMaster objMaster = Mediator.GetInstance().GetPackingListMaster(model.PackingListId);
            objMaster.PackingListName = model.PackingName;
            objMaster.LastUpdatedDate = DateTime.Now;
            objMaster.Notes = model.Notes;
            objMaster.ViewStatus = model.ViewStatus;
            objMaster.Update(DBCommand);

            DataTable dtOldDetails = Mediator.GetInstance().GetPackingListDetails(model.PackingListId);

            PackingListDetails objDetail;
            //Go through the table of Packing details, update or insert object
            if (model.PackingDetails != null)
            {
                foreach (DataRow dr in model.PackingDetails.Rows)
                {
                    objDetail = new PackingListDetails();
                    objDetail.FromLocation = dr["Location"].ToString();
                    objDetail.Package_code = dr["Package code"].ToString();
                    objDetail.PackingListID = objMaster.PackingListID;
                    objDetail.ProductID = dr["Product"].ToString();
                    objDetail.Qty = Convert.ToDecimal(dr["Quantity"]);
                    objDetail.ID = dr["ID"].ToString();
                    //if ID null or empty, that mean this is a new record
                    //Add to database
                    if (String.IsNullOrEmpty(dr["ID"].ToString()))
                    {
                        objDetail.Insert(DBCommand);
                    }
                    else
                    {                        
                        objDetail.Update(DBCommand);
                    }
                }
            }
            //Go through table old detail, if any ID is not in model.PackingDetails.Rows
            //That means the row is deleted -> Delete from database
            String strId = null;
            bool isDeleted = false;
            foreach (DataRow dr in dtOldDetails.Rows)
            {
                strId = dr["ID"].ToString();
                isDeleted = true;
                foreach (DataRow drNew in model.PackingDetails.Rows)
                {
                    if (strId.Equals(drNew["ID"].ToString()))
                    {
                        isDeleted = false;
                        break;
                    }
                }
                //After checking all new row, the current row needed to be deleted from DB
                if (isDeleted)
                {
                    objDetail = new PackingListDetails();
                    objDetail.ID = strId;
                    objDetail.Delete(DBCommand);
                }
            }

            RollBackPackingList(dtOldDetails);
            ProcessPackingList(model.PackingDetails);
        }

        internal void DeletePackingList()
        {            
            DataTable dtOldDetails = Mediator.GetInstance().GetPackingListDetails(model.PackingListId);

            PackingListDetails objDetail;
            
            //Go through table old detail, Delete from database
            String strId = null;            
            foreach (DataRow dr in dtOldDetails.Rows)
            {
                strId = dr["ID"].ToString();                
                objDetail = new PackingListDetails();
                objDetail.ID = strId;
                objDetail.Delete(DBCommand);               
            }

            //Delete master after detail so the FK would not be violated
            PackingListMaster objMaster = new PackingListMaster();
            objMaster.PackingListID = model.PackingListId;
            objMaster.Delete(DBCommand);
            RollBackPackingList(dtOldDetails);    
        }

        /// <summary>
        /// Update quantity on-hand and quantity-allocated of each location
        /// </summary>
        /// <param name="dataTable"></param>
        private void ProcessPackingList(DataTable dtDetails)
        {
            String strLocation = null;
            String strWarehouse = null;
            String strProduct = null;
            Int32 iQty = 0;
            Decimal dQty = 0;
            Location_Master objLocation = null;
            foreach (DataRow dr in dtDetails.Rows)
            {
                strLocation = dr["Location"].ToString();
                strWarehouse = dr["Warehouse"].ToString();
                strProduct = dr["Product"].ToString();
                
                dQty = Convert.ToDecimal(dr["Quantity"].ToString());
                iQty = Convert.ToInt32(dQty);
                LocationProcess pr = new LocationProcess();
                pr.Warehouse = strWarehouse;
                pr.Location = strLocation;
                pr.DBCommand = this.DBCommand;
                pr.DeductOnHandAddAllocated(strProduct, iQty);
            }
        }

        /// <summary>
        /// Roll-back the change to quantity on-hand and quantity-allocated of each location
        /// </summary>
        /// <param name="dataTable"></param>
        private void RollBackPackingList(DataTable dtDetails)
        {
            String strLocation = null;
            String strWarehouse = null;
            String strProduct = null;
            Int32 iQty = 0;
            Decimal dQty = 0;
            Location_Master objLocation = null;
            foreach (DataRow dr in dtDetails.Rows)
            {
                strLocation = dr["Location"].ToString();
                strWarehouse = dr["Warehouse"].ToString();
                strProduct = dr["Product"].ToString();
                //Quantity should be negative so the action is a rollback action
                dQty = 0 - Convert.ToDecimal(dr["Quantity"].ToString());
                iQty = Convert.ToInt32(dQty);
                LocationProcess pr = new LocationProcess();
                pr.Warehouse = strWarehouse;
                pr.Location = strLocation;
                pr.DBCommand = this.DBCommand;

                try
                {
                    pr.DeductOnHandAddAllocated(strProduct, iQty);
                }
                catch (NotFoundException ex)
                {
                    //Do nothing here, allow deleted the rows that
                    //are invalid
                }
            }
        }


        /// <summary>
        /// Create a packing list without modifying data in Location_Master
        /// </summary>
        internal void NewPackingListNoAdjust()
        {
            //Create PackingListMaster
            PackingListMaster objMaster = new PackingListMaster();
            objMaster.PackingListID = objMaster.NewId();
            objMaster.DateCreated = model.DateCreated;
            objMaster.PackingListName = model.PackingName;
            objMaster.Notes = model.Notes;
            //There is no setting for view status at the moment,set as true
            objMaster.ViewStatus = model.ViewStatus;
            objMaster.UserID = Globals.UserID;
            objMaster.userIDOld = null;
            objMaster.Insert(DBCommand);

            //Create Packing List Details
            if (model.PackingDetails == null) return;
            foreach (DataRow dr in model.PackingDetails.Rows)
            {
                PackingListDetails objDetail = new PackingListDetails();
                objDetail.FromLocation = dr["Location"].ToString();
                objDetail.Package_code = dr["Package code"].ToString();
                objDetail.PackingListID = objMaster.PackingListID;
                objDetail.ProductID = dr["Product"].ToString();
                objDetail.Qty = Convert.ToDecimal(dr["Quantity"]);
                objDetail.Insert(DBCommand);
            }
        }
    }
}
