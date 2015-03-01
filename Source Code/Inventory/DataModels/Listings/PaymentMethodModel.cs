using System;
using System.Collections.Generic;
using System.Text;
using Inventory.DataObjects;

namespace Inventory.DataModels.Listings
{
    public class PaymentMethodModel
    {
        private String strID;
        private String strDescription;
        private DateTime datDateCreated;
        private String strName = string.Empty;

        public String ID
        {
            get { return strID; }
            set { strID = value; }
        }

        public String Description
        {
            get { return strDescription; }
            set { strDescription = value; }
        }
        
        public string Name
        {
            get { return strName; }
            set { strName = value; }
        }

        internal Inventory.DataObjects.PaymentMethod GetMasterRecord()
        {
            PaymentMethod objMaster = new PaymentMethod();
            objMaster.Name = this.Name;
            objMaster.Description = this.Description;
            if (this.ID != null && !String.IsNullOrEmpty(this.ID))
            {
                objMaster.ID = this.ID;
            }
            return objMaster;
        }

        internal void LoadDataFromDataBase()
        {
            PaymentMethod objMaster = new PaymentMethod();
            objMaster.ID = this.ID;
            objMaster.SelectOne();            
            this.Name = objMaster.Name.ToString();            
            this.Description = objMaster.Description.ToString();            
        }
    }
}
