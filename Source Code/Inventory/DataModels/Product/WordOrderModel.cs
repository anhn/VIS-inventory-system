using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Inventory.DataObjects;
using Inventory.DataObjects.DAO;

namespace Inventory.DataModels.Product
{
    public class WorkOrderModel
    {
        #region Attributes

        private double dcmNumber = 0;

        private string strStatusID = string.Empty;

        private string strReference = string.Empty;

        private string strOrderedByID = string.Empty;

        private DateTime dtmIssuedDate = DateTime.Now;

        private DateTime dtmDueOn = DateTime.Now;

        private string strInstructions = string.Empty;

        private string strSupplierID = string.Empty;

        private string strPhone = string.Empty;

        private string strName = string.Empty;

        private string strAddress = string.Empty;

        private string strSuburb = string.Empty;

        private string strState = string.Empty;

        private string strPostcode = string.Empty;

        private string strContact = string.Empty;

        #endregion

        #region Packing Property

        public double Number
        {
            get { return dcmNumber; }
            set { dcmNumber = value; }
        }

        public string StatusID
        {
            get { return strStatusID; }
            set { strStatusID = value; }
        }

        public string Reference
        {
            get { return strReference; }
            set { strReference = value; }
        }

        public string OrderedByID
        {
            get { return strOrderedByID; }
            set { strOrderedByID = value; }
        }

        public DateTime IssuedDate
        {
            get { return dtmIssuedDate; }
            set { dtmIssuedDate = value; }
        }

        public DateTime DueOn
        {
            get { return dtmDueOn; }
            set { dtmDueOn = value; }
        }

        public string Instructions
        {
            get { return strInstructions; }
            set { strInstructions = value; }
        }

        public string SupplierID
        {
            get { return strSupplierID; }
            set { strSupplierID = value; }
        }

        public string Phone
        {
            get { return strPhone; }
            set { strPhone = value; }
        }

        public string Name
        {
            get { return strName; }
            set { strName = value; }
        }

        public string Address
        {
            get { return strAddress; }
            set { strAddress = value; }
        }

        public string Suburb
        {
            get { return strSuburb; }
            set { strSuburb = value; }
        }

        public string State
        {
            get { return strState; }
            set { strState = value; }
        }

        public string Postcode
        {
            get { return strPostcode; }
            set { strPostcode = value; }
        }

        public string Contact
        {
            get { return strContact; }
            set { strContact = value; }
        }

        #endregion

        internal void LoadDataFromDataBase()
        {
            WorkOrder objMaster = Mediator.GetInstance().GetWorkOrder(this.Number);
            this.Number = objMaster.Number.ToDouble();
            this.StatusID = objMaster.Status.ToString();
            this.Reference = objMaster.Reference.ToString();
            this.OrderedByID = objMaster.OrderedBy.ToString();
            this.IssuedDate = objMaster.IssuedDate.Value;
            this.DueOn = objMaster.DueOn.Value;
            this.Instructions = objMaster.Instructions.ToString();
            this.SupplierID = objMaster.SupplierID.ToString();
            this.Phone = objMaster.Phone.ToString();
            this.Name = objMaster.Name.ToString();
            this.Address = objMaster.Address.ToString();
            this.Suburb = objMaster.Suburb.ToString();
            this.State = objMaster.State.ToString();
            this.Postcode = objMaster.Postcode.ToString();
            this.Contact = objMaster.Contact.ToString();
        }


        internal WorkOrder GetMasterRecord()
        {
            WorkOrder objMaster = new WorkOrder();
            objMaster.Number = (decimal)this.Number;
            objMaster.Status = this.StatusID;
            objMaster.Reference = this.Reference;
            objMaster.OrderedBy = this.OrderedByID;
            objMaster.IssuedDate = this.IssuedDate;
            objMaster.DueOn = this.DueOn;
            objMaster.Instructions = this.Instructions;
            objMaster.SupplierID = this.SupplierID;
            objMaster.Phone = this.Phone;
            objMaster.Name = this.Name;
            objMaster.Address = this.Address;
            objMaster.Suburb = this.Suburb;
            objMaster.State = this.State;
            objMaster.Postcode = this.Postcode;
            objMaster.Contact = this.Contact;

            return objMaster;
        }

        internal string NewNumber()
        {
            WorkOrderDao objDao = new WorkOrderDao();
            double dblNewNumber = objDao.GetMaxNumber() + 1;
            
            return dblNewNumber.ToString();
        }
    }
}
