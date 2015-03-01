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
    public class InventoryAdjustmentProcess
    {
        private InventoryAdjustmentModel model;
        private SqlCommand objCmd;

        public InventoryAdjustmentModel DataIn
        {
            get { return model; }
            set { model = value; }
        }
        public SqlCommand DBCommand
        {
            get { return objCmd; }
            set { objCmd = value; }
        }

        internal void EditInventoryAdjustment()
        {
            //throw new Exception("The method or operation is not implemented.");
            InventoryAdjustmentMaster objMaster = Mediator.GetInstance().GetInventoryAdjustmentMaster(model.AdjustId);
            objMaster.Name = model.AdjustName;
            objMaster.DateCreated = model.DateCreated;
            objMaster.Notes = model.Notes;
            objMaster.ViewStatus = model.ViewStatus;

            objMaster.Update(DBCommand);

            DataTable dtOldDetails = Mediator.GetInstance().GetInventoryAdjustmentDetails(model.AdjustId);

            InventoryAdjustmentDetails objDetail;
            //Go through the table of InventoryAdjustment details, update or insert object
            if (model.AdjustDetails != null)
            {
                foreach (DataRow dr in model.AdjustDetails.Rows)
                {
                    objDetail = new InventoryAdjustmentDetails();

                    objDetail.InventoryAdjustmentID = objMaster.ID;
                    objDetail.ProductID = dr["Product"].ToString();
                    objDetail.Location = dr["Location"].ToString();
                    objDetail.Qty = Convert.ToDecimal(dr["Quantity"]);
                    objDetail.ID = dr["ID"].ToString();

                    //if ID null or empty, that mean this is a new record
                    //Add to database
                    if (String.IsNullOrEmpty(dr["ID"].ToString()))
                    {
                        objDetail.ID = Guid.NewGuid().ToString();
                        objDetail.Insert(DBCommand);
                    }
                    else
                    {
                        objDetail.Update(DBCommand);
                    }
                }
            }
            //Go through table old detail, if any ID is not in model.InventoryAdjustmentDetails.Rows
            //That means the row is deleted -> Delete from database
            String strId = null;
            bool isDeleted = false;
            foreach (DataRow dr in dtOldDetails.Rows)
            {
                strId = dr["ID"].ToString();
                isDeleted = true;
                foreach (DataRow drNew in model.AdjustDetails.Rows)
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
                    objDetail = new InventoryAdjustmentDetails();
                    objDetail.ID = strId;
                    objDetail.Delete(DBCommand);
                }
            }

            RollBackInventoryAdjustments(dtOldDetails);
            ProcessInventoryAdjustments(model.AdjustDetails);
        }

        internal void DeleteInventoryAdjustment()
        {
            DataTable dtOldDetails = Mediator.GetInstance().GetInventoryAdjustmentDetails(model.AdjustId);

            InventoryAdjustmentDetails objDetail;

            //Go through table old detail, Delete from database
            String strId = null;
            foreach (DataRow dr in dtOldDetails.Rows)
            {
                strId = dr["ID"].ToString();
                objDetail = new InventoryAdjustmentDetails();
                objDetail.ID = strId;
                objDetail.Delete(DBCommand);
            }

            //Delete master after detail so the FK would not be violated
            InventoryAdjustmentMaster objMaster = new InventoryAdjustmentMaster();
            objMaster.ID = model.AdjustId;
            objMaster.Delete(DBCommand);
            RollBackInventoryAdjustments(dtOldDetails);
        }

        /// <summary>
        /// Update quantity on-hand and quantity-allocated of each location
        /// </summary>
        /// <param name="dataTable"></param>
        private void ProcessInventoryAdjustments(DataTable dtDetails)
        {
            String strLocation = null;
            String strWarehouse = null;
            String strProduct = null;
            Int32 iQty = 0;
            Decimal dQty = 0;

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
                //Add iQty from Quantity on hand of Location: input is -Qty
                pr.DeductOnHand(strProduct, -iQty);
            }
        }

        /// <summary>
        /// Roll-back the change to quantity on-hand and quantity-allocated of each location
        /// </summary>
        /// <param name="dataTable"></param>
        private void RollBackInventoryAdjustments(DataTable dtDetails)
        {
            String strLocation = null;
            String strWarehouse = null;
            String strProduct = null;
            Int32 iQty = 0;
            Decimal dQty = 0;

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
                //Add iQty from Quantity on hand of Location: input is Qty
                try
                {
                    pr.DeductOnHand(strProduct, iQty);
                }
                catch (NotFoundException ex)
                {
                    //Do nothing here, allow deleted the rows that
                    //are invalid
                }
            }
        }

        /// <summary>
        /// Create a new InventoryAdjustment and it's details
        /// </summary>
        internal void NewInventoryAdjustment()
        {
            //Create InventoryAdjustmentMaster
            InventoryAdjustmentMaster objMaster = new InventoryAdjustmentMaster();
            objMaster.Name = model.AdjustName;
            objMaster.DateCreated = model.DateCreated;
            objMaster.Notes = model.Notes;
            objMaster.ViewStatus = model.ViewStatus;

            objMaster.ID = (System.Data.SqlTypes.SqlString)Guid.NewGuid().ToString();
            objMaster.Insert(DBCommand);

            //Create InventoryAdjustment List Details
            if (model.AdjustDetails == null) return;

            foreach (DataRow dr in model.AdjustDetails.Rows)
            {
                InventoryAdjustmentDetails objDetail = new InventoryAdjustmentDetails();
                objDetail.Location = dr["Location"].ToString();
                objDetail.Qty = Convert.ToDecimal(dr["Quantity"]);
                objDetail.InventoryAdjustmentID = objMaster.ID;
                objDetail.ProductID = dr["Product"].ToString();

                objDetail.ID = Guid.NewGuid().ToString();
                objDetail.Insert(DBCommand);
            }
            ProcessInventoryAdjustments(model.AdjustDetails);
        }
    }
}
