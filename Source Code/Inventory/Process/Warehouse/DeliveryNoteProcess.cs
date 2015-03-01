using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

using Inventory.DataModels.Warehouse;
using Inventory.DataObjects;
using System.Data;
using Inventory.DataModels;

namespace Inventory.Process.Warehouse
{
    class DeliveryNoteProcess
    {
        private DeliveryNoteModel model;
        private string strDeleteID = string.Empty;
        private SqlCommand objCmd;

        public DeliveryNoteModel DataIn
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

        public void NewDeliveryNote()
        {
            DeliveryNotesMaster masterDelv = model.GetMasterRecord();

            masterDelv.Insert(objCmd);

            
            if (model.Details == null) return;
            DeliveryNotesDetails objDetail = null;
            foreach (DataRow dr in model.Details.Rows)
            {
                objDetail = new DeliveryNotesDetails();
                objDetail.ToLocation = dr["To Location"].ToString();                
                objDetail.FromLocation = dr["Location"].ToString();
                objDetail.Package_code = dr["Package code"].ToString();
                objDetail.DeliveryNoteID = masterDelv.ID;
                objDetail.ProductID = dr["Product"].ToString();
                objDetail.Qty = Convert.ToDecimal(dr["Quantity"]);
                objDetail.Insert(DBCommand);
            }

            

            ProcessDeliveryNote(model.Details);
        }

        

        internal void EditDeliveryNote()
        {
            DeliveryNotesMaster masterDelv = model.GetMasterRecord();

            masterDelv.Update(objCmd);

            DataTable dtOldDetails = Mediator.GetInstance().GetDeliveryNoteDetails(model.ID);

            DeliveryNotesDetails objDetail;
            //Go through the table of Packing details, update or insert object
            if (model.Details != null)
            {
                foreach (DataRow dr in model.Details.Rows)
                {
                    objDetail = new DeliveryNotesDetails();
                    objDetail.ToLocation = dr["To Location"].ToString();
                    objDetail.FromLocation = dr["Location"].ToString();
                    objDetail.Package_code = dr["Package code"].ToString();
                    objDetail.DeliveryNoteID = masterDelv.ID;
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
                    objDetail = new DeliveryNotesDetails();
                    objDetail.ID = strId;
                    objDetail.Delete(DBCommand);
                }
            }

            RollBackDeliveryNote(dtOldDetails);
            ProcessDeliveryNote(model.Details);

        }

        

        internal void DeleteDeliveryNote()
        {
            DataTable dtOldDetails = Mediator.GetInstance().GetDeliveryNoteDetails(strDeleteID);

            DeliveryNotesDetails objDetail;

            //Go through table old detail, Delete from database
            String strId = null;
            foreach (DataRow dr in dtOldDetails.Rows)
            {
                strId = dr["ID"].ToString();
                objDetail = new DeliveryNotesDetails();
                objDetail.ID = strId;
                objDetail.Delete(DBCommand);
            }

            DeliveryNotesMaster masterDelv = new DeliveryNotesMaster();
            masterDelv.ID = strDeleteID;
            masterDelv.Delete(objCmd);

            RollBackDeliveryNote(dtOldDetails);
        }

        private void ProcessDeliveryNote(DataTable dtDetails)
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

        private void RollBackDeliveryNote(DataTable dtDetails)
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
    }
}
