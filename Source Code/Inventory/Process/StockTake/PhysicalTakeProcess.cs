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
    public class PhysicalTakeProcess
    {
        private PhysicalTakeModel model;
        private string strDeleteID = string.Empty;
        private SqlCommand objCmd;

        public PhysicalTakeModel DataIn
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

        public void NewPhysicalTake()
        {
            PhysicalTakeMaster masterDelv = model.GetMasterRecord();
            masterDelv.ID = Guid.NewGuid().ToString();
            masterDelv.Insert(objCmd);

            //Create InventoryAdjustment List Details
            if (model.Details == null) return;

            foreach (DataRow dr in model.Details.Rows)
            {
                PhysicalTakeDetails objDetail = new PhysicalTakeDetails();
                objDetail.ID = Guid.NewGuid().ToString();
                objDetail.PhysicalTakeID = masterDelv.ID;
                objDetail.LocationID = dr["Location"].ToString();
                objDetail.ProductID = dr["Product"].ToString();
                objDetail.CurrentQty = Convert.ToDecimal(dr["Current Qty"]);
                objDetail.CountQty = Convert.ToDecimal(dr["Count Qty"]);
                objDetail.Date = DateTime.Now;

                objDetail.Insert(DBCommand);
            }
        }

        internal void EditPhysicalTake()
        {
            PhysicalTakeMaster masterDelv = model.GetMasterRecord();

            masterDelv.Update(objCmd);

            DataTable dtOldDetails = Mediator.GetInstance().GetPhysicalTakeDetails(model.ID);

            PhysicalTakeDetails objDetail;
            //Go through the table of Inventoryment details, update or insert object
            if (model.Details != null)
            {
                foreach (DataRow dr in model.Details.Rows)
                {
                    objDetail = new PhysicalTakeDetails();
                    objDetail.PhysicalTakeID = masterDelv.ID;
                    objDetail.ID = dr["ID"].ToString();
                    objDetail.LocationID = dr["Location"].ToString();
                    objDetail.ProductID = dr["Product"].ToString();
                    objDetail.CurrentQty = Convert.ToDecimal(dr["Current Qty"]);
                    objDetail.CountQty = Convert.ToDecimal(dr["Count Qty"]);
                    objDetail.Date = (dr["Date"] == DBNull.Value)? DateTime.Now: Convert.ToDateTime(dr["Date"]);

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
                    objDetail = new PhysicalTakeDetails();
                    objDetail.ID = strId;
                    objDetail.Delete(DBCommand);
                }
            }
        }

        internal void DeletePhysicalTake()
        {
            DataTable dtOldDetails = Mediator.GetInstance().GetPhysicalTakeDetails(strDeleteID);
            PhysicalTakeDetails objDetail;

            //Go through table old detail, Delete from database
            String strId = null;
            foreach (DataRow dr in dtOldDetails.Rows)
            {
                strId = dr["ID"].ToString();
                objDetail = new PhysicalTakeDetails();
                objDetail.ID = strId;
                objDetail.Delete(DBCommand);
            }

            PhysicalTakeMaster masterDelv = new PhysicalTakeMaster();
            masterDelv.ID = strDeleteID;
            masterDelv.Delete(objCmd);
        }
    }
}
