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
    public class StockOutProcess
    {
        private StockOutModel model;
        private SqlCommand objCmd;

        public StockOutModel DataIn
        {
            get { return model; }
            set { model = value; }
        }
        public SqlCommand DBCommand
        {
            get { return objCmd; }
            set { objCmd = value; }
        }

        
        internal void EditStockOut()
        {
            //throw new Exception("The method or operation is not implemented.");
            StockOutMaster objMaster = Mediator.GetInstance().GetStockOutMaster(model.Id);
            objMaster.Name = model.Name;
            objMaster.DateCreated = model.DateCreated;
            objMaster.Location = model.Location;
            objMaster.Description = model.Desc;
            objMaster.Update(DBCommand);

            DataTable dtOldDetails = Mediator.GetInstance().GetStockOutDetails(model.Id);

            StockOutDetails objDetail;
            //Go through the table of StockOut details, update or insert object
            if (model.Details != null)
            {
                foreach (DataRow dr in model.Details.Rows)
                {
                    objDetail = new StockOutDetails();                    
                    objDetail.StockOutID = objMaster.ID;
                    objDetail.Product = dr["Product"].ToString();                    
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
            //Go through table old detail, if any ID is not in model.Details.Rows
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
                    objDetail = new StockOutDetails();
                    objDetail.ID = strId;
                    objDetail.Delete(DBCommand);
                }
            }

            RollBackStockOuts(dtOldDetails);
            ProcessStockOuts(model.Details);
        }

        internal void DeleteStockOut()
        {
            DataTable dtOldDetails = Mediator.GetInstance().GetStockOutDetails(model.Id);
            //Load data into the model so the information could be used for rolling back
            model.LoadDataFromDataBase();
            StockOutDetails objDetail;

            //Go through table old detail, Delete from database
            String strId = null;
            foreach (DataRow dr in dtOldDetails.Rows)
            {
                strId = dr["ID"].ToString();
                objDetail = new StockOutDetails();
                objDetail.ID = strId;
                objDetail.Delete(DBCommand);
            }

            //Delete master after detail so the FK would not be violated
            StockOutMaster objMaster = new StockOutMaster();
            objMaster.ID = model.Id;
            objMaster.Delete(DBCommand);
            RollBackStockOuts(dtOldDetails);
        }

        /// <summary>
        /// Update quantity on-hand and quantity-allocated of each location
        /// </summary>
        /// <param name="dataTable"></param>
        private void ProcessStockOuts(DataTable dtDetails)
        {
            String strLocation = null;
            String strWarehouse = null;
            String strProduct = null;
            
            Int32 iQty = 0;
            Decimal dQty = 0;

            foreach (DataRow dr in dtDetails.Rows)
            {
                strLocation = model.Location;
                strWarehouse = model.Warehouse;
                strProduct = dr["Product"].ToString();
                

                dQty = Convert.ToDecimal(dr["Quantity"].ToString());
                iQty = Convert.ToInt32(dQty);
                LocationProcess pr = new LocationProcess();
                //Deduct iQty from Quantity on hand of From Location
                pr.Warehouse = strWarehouse;
                pr.Location = strLocation;
                pr.DBCommand = this.DBCommand;
                pr.DeductOnHand(strProduct, iQty);

                
            }
        }

        /// <summary>
        /// Roll-back the change to quantity on-hand and quantity-allocated of each location
        /// </summary>
        /// <param name="dataTable"></param>
        private void RollBackStockOuts(DataTable dtDetails)
        {
            String strLocation = null;
            String strWarehouse = null;
            String strProduct = null;
            
            Int32 iQty = 0;
            Decimal dQty = 0;

            foreach (DataRow dr in dtDetails.Rows)
            {
                strLocation = model.Location;
                strWarehouse = model.Warehouse;
                strProduct = dr["Product"].ToString();                

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
                    //So have to pass iQty -> in function DeductOnHand it would mean
                    //add iQty
                    pr.DeductOnHand(strProduct, -iQty);
                    
                }
                catch (NotFoundException ex)
                {
                    //Do nothing here, allow deleted the rows that
                    //are invalid
                }
            }
        }

        /// <summary>
        /// Create a new StockOut and it's details
        /// </summary>
        internal void NewStockOut()
        {
            //Create StockOutMaster
            StockOutMaster objMaster = new StockOutMaster();
            objMaster.Name = model.Name;
            objMaster.Location = model.Location;
            objMaster.Description = model.Desc;
            objMaster.DateCreated = model.DateCreated;

            objMaster.Insert(DBCommand);

            //Create StockOut List Details
            if (model.Details == null) return;

            foreach (DataRow dr in model.Details.Rows)
            {
                StockOutDetails objDetail = new StockOutDetails();
                
                objDetail.Qty = Convert.ToDecimal(dr["Quantity"]);
                objDetail.StockOutID = objMaster.ID;
                objDetail.Product = dr["Product"].ToString();

                objDetail.Insert(DBCommand);
            }
            ProcessStockOuts(model.Details);
        }
    }
}
