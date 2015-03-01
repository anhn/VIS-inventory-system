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
    public class StockTransferProcess
    {
        private StockTransferModel model;
        private SqlCommand objCmd;

        public StockTransferModel DataIn
        {
            get { return model; }
            set { model = value; }
        }
        public SqlCommand DBCommand
        {
            get { return objCmd; }
            set { objCmd = value; }
        }

        //public void ProcessStockTransfers()
        //{
        //    NewStockTransfer();

        //    ProcessStockTransfers(model.StockTransferDetails);
        //}

        internal void EditStockTransfer()
        {
            //throw new Exception("The method or operation is not implemented.");
            StockTransferMaster objMaster = Mediator.GetInstance().GetStockTransferMaster(model.StockTransferId);
            objMaster.Name = model.StockTransferName;
            objMaster.DateCreated = model.DateCreated;

            objMaster.Update(DBCommand);

            DataTable dtOldDetails = Mediator.GetInstance().GetStockTransferDetails(model.StockTransferId);

            StockTransferDetails objDetail;
            //Go through the table of StockTransfer details, update or insert object
            if (model.StockTransferDetails != null)
            {
                foreach (DataRow dr in model.StockTransferDetails.Rows)
                {
                    objDetail = new StockTransferDetails();
                    
                    objDetail.ToLocation = dr["To Location"].ToString();
                    objDetail.StockTransferID = objMaster.ID;
                    objDetail.ProductID = dr["Product"].ToString();
                    objDetail.FromLocation = dr["Location"].ToString();
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
            //Go through table old detail, if any ID is not in model.StockTransferDetails.Rows
            //That means the row is deleted -> Delete from database
            String strId = null;
            bool isDeleted = false;
            foreach (DataRow dr in dtOldDetails.Rows)
            {
                strId = dr["ID"].ToString();
                isDeleted = true;
                foreach (DataRow drNew in model.StockTransferDetails.Rows)
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
                    objDetail = new StockTransferDetails();
                    objDetail.ID = strId;
                    objDetail.Delete(DBCommand);
                }
            }

            RollBackStockTransfers(dtOldDetails);
            ProcessStockTransfers(model.StockTransferDetails);
        }

        internal void DeleteStockTransfer()
        {            
            DataTable dtOldDetails = Mediator.GetInstance().GetStockTransferDetails(model.StockTransferId);

            StockTransferDetails objDetail;
            
            //Go through table old detail, Delete from database
            String strId = null;            
            foreach (DataRow dr in dtOldDetails.Rows)
            {
                strId = dr["ID"].ToString();                
                objDetail = new StockTransferDetails();
                objDetail.ID = strId;
                objDetail.Delete(DBCommand);               
            }

            //Delete master after detail so the FK would not be violated
            StockTransferMaster objMaster = new StockTransferMaster();
            objMaster.ID = model.StockTransferId;
            objMaster.Delete(DBCommand);
            RollBackStockTransfers(dtOldDetails);    
        }

        /// <summary>
        /// Update quantity on-hand and quantity-allocated of each location
        /// </summary>
        /// <param name="dataTable"></param>
        private void ProcessStockTransfers(DataTable dtDetails)
        {
            String strLocation = null;
            String strWarehouse = null;
            String strProduct = null;
            String strToLocation = null;
            String strToWarehouse = null;
            Int32 iQty = 0;
            Decimal dQty = 0;
            
            foreach (DataRow dr in dtDetails.Rows)
            {
                strLocation = dr["Location"].ToString();
                strWarehouse = dr["Warehouse"].ToString();
                strProduct = dr["Product"].ToString();
                strToLocation = dr["To Location"].ToString();
                strToWarehouse = dr["To Warehouse"].ToString();

                dQty = Convert.ToDecimal(dr["Quantity"].ToString());
                iQty = Convert.ToInt32(dQty);
                LocationProcess pr = new LocationProcess();
                //Deduct iQty from Quantity on hand of From Location
                pr.Warehouse = strWarehouse;
                pr.Location = strLocation;
                pr.DBCommand = this.DBCommand;
                pr.DeductOnHand(strProduct, iQty);

                //Add iQty to Quantity on hand of From Location
                pr.Warehouse = strToWarehouse;
                pr.Location = strToLocation;
                pr.DBCommand = this.DBCommand;
                pr.DeductOnHand(strProduct, -iQty);
            }
        }

        /// <summary>
        /// Roll-back the change to quantity on-hand and quantity-allocated of each location
        /// </summary>
        /// <param name="dataTable"></param>
        private void RollBackStockTransfers(DataTable dtDetails)
        {
            String strLocation = null;
            String strWarehouse = null;
            String strProduct = null;
            String strToLocation = null;
            String strToWarehouse = null;
            Int32 iQty = 0;
            Decimal dQty = 0;
            
            foreach (DataRow dr in dtDetails.Rows)
            {
                strLocation = dr["Location"].ToString();
                strWarehouse = dr["Warehouse"].ToString();
                strProduct = dr["Product"].ToString();
                strToLocation = dr["To Location"].ToString();
                strToWarehouse = dr["To Warehouse"].ToString();

                dQty = Convert.ToDecimal(dr["Quantity"].ToString());
                iQty = Convert.ToInt32(dQty);
                LocationProcess pr = new LocationProcess();
                
                //Deduct iQty from Quantity on hand of From Location
                try
                {
                    pr.Warehouse = strWarehouse;
                    pr.Location = strLocation;
                    pr.DBCommand = this.DBCommand;
                    
                    //Need to add iQty to Qty of Location
                    //So have to pass -iQty -> in function DeductOnHand it would mean
                    //Add iQty
                    pr.DeductOnHand(strProduct, 0 - iQty);                    
                    
                    pr.Warehouse = strToWarehouse;
                    pr.Location = strToLocation;
                    pr.DBCommand = this.DBCommand;
                    
                    //Deduct iQty from ToLocation
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
        /// Create a new StockTransfer and it's details
        /// </summary>
        internal void NewStockTransfer()
        {
            //Create StockTransferMaster
            StockTransferMaster objMaster = new StockTransferMaster();
            objMaster.Name = model.StockTransferName;
            objMaster.DateCreated = model.DateCreated;

            objMaster.Insert(DBCommand);

            //Create StockTransfer List Details
            if (model.StockTransferDetails == null) return;

            foreach (DataRow dr in model.StockTransferDetails.Rows)
            {
                StockTransferDetails objDetail = new StockTransferDetails();
                objDetail.FromLocation = dr["Location"].ToString();
                objDetail.ToLocation = dr["To Location"].ToString();
                objDetail.Qty = Convert.ToDecimal(dr["Quantity"]);
                objDetail.StockTransferID = objMaster.ID;
                objDetail.ProductID = dr["Product"].ToString();

                objDetail.Insert(DBCommand);
            }
            ProcessStockTransfers(model.StockTransferDetails);
        }
    }
}
