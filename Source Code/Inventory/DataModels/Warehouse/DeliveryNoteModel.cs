using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Inventory.DataObjects;

namespace Inventory.DataModels.Warehouse
{
    public class DeliveryNoteModel
    {
        private String strId;
        private String strDNID;
        private String strRefNo;
        private String strDeliverMethod;
        private String strDeliverType;
        private String strCustId;
        private String strAddress;
        private Decimal dCost1;
        private Decimal dCost2;
        private DateTime dtmCreated = DateTime.Now;
        private DataTable dtDetails;
        private bool bShowStatus = true;
        private string strNotes = string.Empty;

        public String ID
        {
            get { return strId; }
            set { strId = value; }
        }

        public String DNID
        {
            get { return strDNID; }
            set { strDNID = value; }
        }

        public String ReferenceNumber
        {
            get { return strRefNo; }
            set { strRefNo = value; }
        }

        public String DeliverMethod
        {
            get { return strDeliverMethod; }
            set { strDeliverMethod = value; }
        }

        public String DeliverType
        {
            get { return strDeliverType; }
            set { strDeliverType = value; }
        }

        public String CustomerID
        {
            get { return strCustId; }
            set { strCustId = value; }
        }

        public String Address
        {
            get { return strAddress; }
            set { strAddress = value; }
        }

        public decimal Cost1
        {
            get { return dCost1; }
            set { dCost1 = value; }
        }

        public decimal Cost2
        {
            get { return dCost2; }
            set { dCost2 = value; }
        }

        public DateTime CreatedDate
        {
            get { return dtmCreated; }
            set { dtmCreated = value; }
        }

        public DataTable Details
        {
            get { return dtDetails; }
            set { dtDetails = value; }
        }

        public bool ViewStatus
        {
            set { bShowStatus = value; }
            get { return bShowStatus; }
        }

        /// <summary>
        /// Set or Get value for Notes
        /// </summary>
        public string Notes
        {
            set { strNotes = value; }
            get { return strNotes; }
        }

        public DeliveryNoteModel()
        {
            

        }

        public void LoadDataFromDatabase()
        {
            DeliveryNotesMaster objMaster = Mediator.GetInstance().GetDeliveryNoteMaster(this.ID);
            this.Details = Mediator.GetInstance().GetDeliveryNoteDetails(this.ID);

            this.DNID = (objMaster.DNID.IsNull) ? string.Empty : Convert.ToString(objMaster.DNID);
            this.ID = (objMaster.ID.IsNull) ? string.Empty : Convert.ToString(objMaster.ID);
            this.CreatedDate = (objMaster.DateCreated.IsNull) ? DateTime.MinValue : (DateTime)objMaster.DateCreated;
            this.ReferenceNumber = (objMaster.ReferenceNo.IsNull) ? string.Empty : Convert.ToString(objMaster.ReferenceNo);
            this.DeliverMethod = (objMaster.DeliveryMethodID.IsNull) ? string.Empty : Convert.ToString(objMaster.DeliveryMethodID);
            this.Cost1 = (objMaster.Cost1.IsNull) ? 0 : (decimal)objMaster.Cost1;
            this.Cost2 = (objMaster.Cost2.IsNull) ? 0 : (decimal)objMaster.Cost2;
            this.ViewStatus = (objMaster.ViewStatus.IsNull) ? false : (bool)(objMaster.ViewStatus);
            this.Notes = (objMaster.Notes.IsNull) ? string.Empty : Convert.ToString(objMaster.Notes);
            this.DeliverType = (objMaster.TypeOfDelivery.IsNull) ? string.Empty : Convert.ToString(objMaster.TypeOfDelivery);
        }

        public DeliveryNotesMaster GetMasterRecord()
        {
            DeliveryNotesMaster masterDelv = new DeliveryNotesMaster();
            masterDelv.Cost1 = (System.Data.SqlTypes.SqlMoney)this.Cost1;
            masterDelv.Cost2 = (System.Data.SqlTypes.SqlMoney)this.Cost2;
            masterDelv.DateCreated = this.CreatedDate;
            masterDelv.DeliveryMethodID = this.DeliverMethod;
            masterDelv.LastUpdatedDate = DateTime.Now;
            masterDelv.ReferenceNo = this.ReferenceNumber;
            masterDelv.DNID = this.DNID;
            masterDelv.ViewStatus = this.ViewStatus;
            masterDelv.Notes = this.Notes;
            if (!String.IsNullOrEmpty(this.ID))
            {
                masterDelv.ID = this.ID;
            }
            masterDelv.CustomerID = this.CustomerID;
            masterDelv.Address = this.Address;
            masterDelv.TypeOfDelivery = this.DeliverType;
            return masterDelv;
        }
    }
}
