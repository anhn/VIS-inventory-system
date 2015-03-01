using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using Inventory.DataModels.StockTake;
using Inventory.DataObjects;
using Inventory.DataModels;

namespace Inventory.Process.StockTake
{
    public class InventoryUpdateProcess
    {
        private InventoryUpdateModel model;
        private string strDeleteID = string.Empty;
        private SqlCommand objCmd;

        public InventoryUpdateModel DataIn
        {
            get { return model; }
            set { model = value; }
        }

        public SqlCommand DBCommand
        {
            get { return objCmd; }
            set { objCmd = value; }
        }

        public string DeleteID
        {
            get { return strDeleteID; }
            set { strDeleteID = value; }
        }

        public void NewInventoryUpdate()
        {
            InventoryUpdateMaster masterDelv = model.GetMasterRecord();
            masterDelv.ID = Guid.NewGuid().ToString();
            masterDelv.Insert(objCmd);

            //Create InventoryAdjustment List Details
            if (model.Details == null) return;

            foreach (DataRow dr in model.Details.Rows)
            {
                InventoryUpdateDetails objDetail = new InventoryUpdateDetails();
                objDetail.ID = Guid.NewGuid().ToString();
                objDetail.InventoryUpdateID = masterDelv.ID;
                objDetail.LocationID = dr["Location"].ToString();
                objDetail.ProductID = dr["Product"].ToString();
                objDetail.OldQty = Convert.ToDecimal(dr["Old Qty"]);
                objDetail.NewQty = Convert.ToDecimal(dr["New Qty"]);
                objDetail.Date = DateTime.Now;
                
                objDetail.Insert(DBCommand);
            }

            ProcessInventoryUpdates(model.Details);
        }

        internal void EditInventoryUpdate()
        {
            InventoryUpdateMaster masterDelv = model.GetMasterRecord();

            masterDelv.Update(objCmd);

            DataTable dtOldDetails = Mediator.GetInstance().GetInventoryUpdateDetails(model.ID);

            InventoryUpdateDetails objDetail;
            //Go through the table of Inventoryment details, update or insert object
            if (model.Details != null)
            {
                foreach (DataRow dr in model.Details.Rows)
                {
                    objDetail = new InventoryUpdateDetails();
                    objDetail.InventoryUpdateID = masterDelv.ID;
                    objDetail.LocationID = dr["Location"].ToString();
                    objDetail.ProductID = dr["Product"].ToString();
                    objDetail.OldQty = Convert.ToDecimal(dr["Old Qty"]);
                    objDetail.NewQty = Convert.ToDecimal(dr["New Qty"]);
                    objDetail.Date = DateTime.Now;
                    
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
            //Go through table old detail, if any ID is not in model.InventorymentDetails.Rows
            //That means the row is deleted -> Delete from database
            String strId = null;
            bool isDeleted = false;
            foreach (DataRow dr in dtOldDetails.Rows)
            {
                strId = dr["ID"].ToString();
                isDeleted = true;
                foreach (DataRow drNew in model.Details.Rows)
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
                    objDetail = new InventoryUpdateDetails();
                    objDetail.ID = strId;
                    objDetail.Delete(DBCommand);
                }
            }

            RollBackInventoryUpdates(dtOldDetails);
            ProcessInventoryUpdates(model.Details);
        }

        internal void DeleteInventoryUpdate()
        {
            DataTable dtOldDetails = Mediator.GetInstance().GetInventoryUpdateDetails(strDeleteID);
            InventoryUpdateDetails objDetail;

            //Go through table old detail, Delete from database
            String strId = null;
            foreach (DataRow dr in dtOldDetails.Rows)
            {
                strId = dr["ID"].ToString();
                objDetail = new InventoryUpdateDetails();
                objDetail.ID = strId;
                objDetail.Delete(DBCommand);
            }

            InventoryUpdateMaster masterDelv = new InventoryUpdateMaster();
            masterDelv.ID = strDeleteID;
            masterDelv.Delete(objCmd);

            RollBackInventoryUpdates(dtOldDetails);
        }


        /// <summary>
        /// Update quantity on-hand and quantity-allocated of each location
        /// </summary>
        /// <param name="dataTable"></param>
        private void ProcessInventoryUpdates(DataTable dtDetails)
        {
            String strLocation = null;
            String strProduct = null;
            Int32 iOldQty = 0;
            Decimal dOldQty = 0;
            
            Int32 iNewQty = 0;
            Decimal dNewQty = 0;

            foreach (DataRow dr in dtDetails.Rows)
            {
                strLocation = dr["Location"].ToString();
                strProduct = dr["Product"].ToString();

                dOldQty = Convert.ToDecimal(dr["Old Qty"].ToString());
                iOldQty = Convert.ToInt32(dOldQty);

                dNewQty = Convert.ToDecimal(dr["New Qty"].ToString());
                iNewQty = Convert.ToInt32(dNewQty);

                ProductLocationProcess pr = new ProductLocationProcess();
                pr.Location = strLocation;
                pr.Product = strProduct;
                pr.DBCommand = this.DBCommand;
                pr.UpdateOnHand(iOldQty, iNewQty);

                WarehouseProductMasterPocess wppr = new WarehouseProductMasterPocess();
                wppr.Location = strLocation;
                wppr.Product = strProduct;
                wppr.DBCommand = this.DBCommand;
                wppr.UpdateOnHand();
            }
        }

        /// <summary>
        /// Roll-back the change to quantity on-hand and quantity-allocated of each location
        /// </summary>
        /// <param name="dataTable"></param>
        private void RollBackInventoryUpdates(DataTable dtDetails)
        {
            String strLocation = null;
            String strProduct = null;
            Int32 iOldQty = 0;
            Decimal dOldQty = 0;
            
            Int32 iNewQty = 0;
            Decimal dNewQty = 0;

            foreach (DataRow dr in dtDetails.Rows)
            {
                strLocation = dr["Location"].ToString();
                strProduct = dr["Product"].ToString();

                dOldQty = Convert.ToDecimal(dr["Old Qty"].ToString());
                iOldQty = Convert.ToInt32(dOldQty);

                dNewQty = Convert.ToDecimal(dr["New Qty"].ToString());
                iNewQty = Convert.ToInt32(dNewQty);

                ProductLocationProcess pr = new ProductLocationProcess();

                pr.Product = strProduct;
                pr.Location = strLocation;
                pr.DBCommand = this.DBCommand;
                //Add iQty from Quantity on hand of Location: input is Qty
                try
                {
                    pr.UpdateOnHand(iNewQty, iOldQty);
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
