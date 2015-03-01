using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Inventory.DataObjects;
using System.Collections;

namespace Inventory.DataModels.Product
{
    public class BOMModel : IModel
    {
        private String strID;
        private String strProductID;
        private String strName;
        private String strDescription;
        private DataTable dtDetails;
        private DateTime datCreated = DateTime.Now;
        private ArrayList arrDeletedDetails = new ArrayList();
        private ArrayList arrNewDetails = new ArrayList();
        private ArrayList arrChangedDetails = new ArrayList();

        public String ID
        {
            get { return strID; }
            set { strID = value; }
        }

        public String ProductID
        {
            get { return strProductID; }
            set { strProductID = value; }
        }

        public String Name
        {
            get { return strName; }
            set { strName = value; }
        }

        public String Description
        {
            get { return strDescription; }
            set { strDescription = value; }
        }

        public DateTime DateCreated
        {
            get { return datCreated; }
            set { datCreated = value; }
        }

        public DataTable Details
        {
            get { return dtDetails; }
            set { dtDetails = value; }
        }

        #region IModel Members

        public void LoadFromDataBase()
        {
            Mediator med = Mediator.GetInstance();
            BoMMaster objMaster = med.GetBillOfMaterialMaster(this.ID);
            this.ProductID = med.ConvertToString(objMaster.ProductID);
            this.Name = med.ConvertToString(objMaster.Name);            
            this.Description = med.ConvertToString(objMaster.Description);
            this.DateCreated = med.ConvertToDateTime(objMaster.DateCreated);
            dtDetails = med.GetBillOfMaterialDetails(this.ID);
        }

        public Inventory.DataObjects.ICommonDBAccess GetMasterRecord()
        {
            BoMMaster objMaster = new BoMMaster();
            if (this.ID != null && !String.IsNullOrEmpty(this.ID))
            {
                objMaster.ID = this.ID;
            }
            objMaster.Name = this.Name;            
            objMaster.ProductID = this.ProductID;
            objMaster.DateCreated = this.datCreated;
            objMaster.Description = this.Description;
            return objMaster;
        }

        public void SaveToDatabase()
        {
            BoMMaster objMaster = new BoMMaster();
            objMaster.Name = this.Name;
            objMaster.ID = this.ProductID;
            objMaster.DateCreated = this.datCreated;
            objMaster.Description = this.Description;
            //objMaster.Insert();
        }


        public void CopyID(ICommonDBAccess objMaster)
        {
            if (objMaster != null && objMaster is BoMMaster)
            {
                this.ID =  Mediator.GetInstance().ConvertToString(((BoMMaster)objMaster).ID);
            }
        }

        public ArrayList DeletedDetails
        {
            get { return arrDeletedDetails; }
        }

        public ArrayList NewDetails
        {
            get { return arrNewDetails; }
        }

        public ArrayList ChangedDetails
        {
            get { return arrChangedDetails; }
        }

        public void AnalyzeDetailsChanges()
        {
            DataTable dtOldDetails = Mediator.GetInstance().GetBillOfMaterialDetails(this.ID);

            BoMDetails objDetail;
            //Go through the table of StockIn details, update or insert object
            if (this.Details != null)
            {
                foreach (DataRow dr in this.Details.Rows)
                {
                    objDetail = new BoMDetails();
                    //Use this.ID because the column in table could be null
                    objDetail.BOMID = this.ID;
                    objDetail.ComponentID = dr["Component"].ToString();
                    objDetail.Units = Convert.ToDecimal(dr["Units"]);
                    objDetail.ID = dr["ID"].ToString();

                    //if ID null or empty, that mean this is a new record
                    //Add to database
                    if (String.IsNullOrEmpty(dr["ID"].ToString()))
                    {
                        arrNewDetails.Add(objDetail);                        
                    }
                    else
                    {
                        arrChangedDetails.Add(objDetail);
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
                foreach (DataRow drNew in this.Details.Rows)
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
                    //For deletion, only require ID
                    objDetail = new BoMDetails();
                    objDetail.ID = strId;
                    arrDeletedDetails.Add(objDetail);
                }
            }
        }


        #endregion

        internal System.Collections.ArrayList GetDetailsRecord()
        {
            ArrayList arrDetails = new ArrayList();
            BoMDetails objDetail = null;
            String strTemp = null;

            if (this.Details != null)
            {
                foreach (DataRow dr in this.Details.Rows)
                {
                    objDetail = new BoMDetails();
                    objDetail.BOMID = this.ID;
                    objDetail.ComponentID = dr["Component"].ToString();
                    objDetail.Units = Convert.ToDecimal(dr["Units"]);
                    strTemp = dr["ID"].ToString();
                    if (!String.IsNullOrEmpty(strTemp))
                    {
                        objDetail.ID = strTemp;
                    }
                    arrDetails.Add(objDetail);
                }
            }
            return arrDetails;
        }

    }
}
