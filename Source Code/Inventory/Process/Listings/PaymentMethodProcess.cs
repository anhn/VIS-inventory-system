using System;
using System.Collections.Generic;
using System.Text;
using Inventory.DataModels.Listings;
using System.Data.SqlClient;
using Inventory.DataObjects;

namespace Inventory.Process.Listings
{
    class PaymentMethodProcess
    {
        private PaymentMethodModel model;
        private string strDeleteID = string.Empty;
        private SqlCommand objCmd;

        public PaymentMethodModel DataIn
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

        

        internal void NewPaymentMethod()
        {
            PaymentMethod masterDelv = model.GetMasterRecord();            
            masterDelv.Insert(objCmd);
        }

        internal void EditPaymentMethod()
        {
            PaymentMethod masterDelv = model.GetMasterRecord();
            masterDelv.Update(objCmd);
        }

        internal void DeletePaymentMethod()
        {
            PaymentMethod masterDelv = new PaymentMethod();
            masterDelv.ID = strDeleteID;
            masterDelv.Delete(objCmd);
        }
    }
}
