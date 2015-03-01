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
    public class PickingListProcess
    {
        private SqlCommand objCommand = null;
        /// <summary>
        /// Storing value of Picking List
        /// </summary>
        Inventory.DataModels.Warehouse.PickingListModel model = new Inventory.DataModels.Warehouse.PickingListModel();
        
        /// <summary>
        /// Picking List
        /// </summary>
        public Inventory.DataModels.Warehouse.PickingListModel DataModel
        {
            set { model = value; }
            get { return model; }
        }

        public SqlCommand DBCommand
        {
            get { return objCommand; }
            set { objCommand = value; }
        }

        public PickingListProcess(SqlCommand objCommandArg)
        {
            this.objCommand = objCommandArg;
        }
        public void NewPickingList() 
        {
            //Process creating new Picking List
          
            //Create new and assign value to PickingListMaster data object
            PickingListMaster objPickingListMasterDO = new PickingListMaster();

            objPickingListMasterDO.PickingName = this.model.PickingName;
            objPickingListMasterDO.ReferenceNo = this.model.ReferenceNo;
            objPickingListMasterDO.Notes = this.model.Notes;
            objPickingListMasterDO.OtherDestLocation = this.model.OtherLocation;
            objPickingListMasterDO.DestLocation = this.model.DestLocation;
            objPickingListMasterDO.DestDepartment = this.model.DestDepart;
            objPickingListMasterDO.DateCreated = this.model.DateCreated;
            objPickingListMasterDO.ViewStatus = this.model.ViewStatus;
            objPickingListMasterDO.UserID = Globals.UserID;
            
            //Add new
            objPickingListMasterDO.Insert(objCommand);
            
            //Create new and assign value to PickingListDetails data object
            PickingListDetails objDetail = new PickingListDetails();

            DataTable dtPickingDetais = this.model.PickingDetails;
            if(dtPickingDetais.Rows==null || dtPickingDetais.Rows.Count==0)return;
            foreach (DataRow dr in model.PickingDetails.Rows)
            {
                objDetail.FromLocation = dr["Location"].ToString();
                objDetail.PickingListID = objPickingListMasterDO.PickingListID;
                objDetail.ProductID = dr["Product"].ToString();
                objDetail.Qty = Convert.ToDecimal(dr["Quantity"]);
                objDetail.Insert(objCommand);
            }

            ProcessPickingList(dtPickingDetais);
        }

        public void EditPickingList()
        {
            PickingListMaster objPickingListMasterDO = new PickingListMaster();

            objPickingListMasterDO.PickingListID = model.PickingListID;
            objPickingListMasterDO.PickingName = this.model.PickingName;
            objPickingListMasterDO.ReferenceNo = this.model.ReferenceNo;
            objPickingListMasterDO.Notes = this.model.Notes;
            objPickingListMasterDO.OtherDestLocation = this.model.OtherLocation;
            objPickingListMasterDO.DestLocation = this.model.DestLocation;
            objPickingListMasterDO.DestDepartment = this.model.DestDepart;
            objPickingListMasterDO.DateCreated = this.model.DateCreated;
            objPickingListMasterDO.ViewStatus = this.model.ViewStatus;
            objPickingListMasterDO.UserID = Globals.UserID;

            objPickingListMasterDO.Update(objCommand);

            DataTable dtOldDetails = Mediator.GetInstance().GetPickingListDetails(model.PickingListID);

            PickingListDetails objDetail;
            //Go through the table of Packing details, update or insert object
            if (model.PickingDetails != null)
            {
                foreach (DataRow dr in model.PickingDetails.Rows)
                {
                    objDetail = new PickingListDetails();
                    objDetail.FromLocation = dr["Location"].ToString();
                    objDetail.PickingListID = objPickingListMasterDO.PickingListID;
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
                foreach (DataRow drNew in model.PickingDetails.Rows)
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
                    objDetail = new PickingListDetails();
                    objDetail.ID = strId;
                    objDetail.Delete(DBCommand);
                }
            }

            RollBackPickingList(dtOldDetails);
            ProcessPickingList(model.PickingDetails);
        }

        

        public void DeletePickingList()
        {
            DataTable dtOldDetails = Mediator.GetInstance().GetPickingListDetails(model.PickingListID);

            PickingListDetails objDetail;

            //Go through table old detail, Delete from database
            String strId = null;
            foreach (DataRow dr in dtOldDetails.Rows)
            {
                strId = dr["ID"].ToString();
                objDetail = new PickingListDetails();
                objDetail.ID = strId;
                objDetail.Delete(DBCommand);
            }

            //Delete master after detail so the FK would not be violated
            PickingListMaster objMaster = new PickingListMaster();
            objMaster.PickingListID = model.PickingListID;
            objMaster.Delete(DBCommand);
            RollBackPickingList(dtOldDetails); 
        }

        /// <summary>
        /// Update quantity on-hand and quantity-allocated of each location
        /// </summary>
        /// <param name="dataTable"></param>
        private void ProcessPickingList(DataTable dtDetails)
        {
            String strLocation = null;
            String strWarehouse = null;
            String strProduct = null;
            Int32 iQty = 0;
            Decimal dQty = 0;
            Location_Master objLocation = null;
            LocationProcess pr = new LocationProcess();

            foreach (DataRow dr in dtDetails.Rows)
            {
                strLocation = dr["Location"].ToString();
                strWarehouse = dr["Warehouse"].ToString();
                strProduct = dr["Product"].ToString();

                dQty = Convert.ToDecimal(dr["Quantity"].ToString());
                iQty = Convert.ToInt32(dQty);                
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
        private void RollBackPickingList(DataTable dtDetails)
        {
            String strLocation = null;
            String strWarehouse = null;
            String strProduct = null;
            Int32 iQty = 0;
            Decimal dQty = 0;
            Location_Master objLocation = null;
            LocationProcess pr = new LocationProcess();

            foreach (DataRow dr in dtDetails.Rows)
            {
                strLocation = dr["Location"].ToString();
                strWarehouse = dr["Warehouse"].ToString();
                strProduct = dr["Product"].ToString();
                //Quantity should be negative so the action is a rollback action
                dQty = 0 - Convert.ToDecimal(dr["Quantity"].ToString());
                iQty = Convert.ToInt32(dQty);                
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

    }
}
