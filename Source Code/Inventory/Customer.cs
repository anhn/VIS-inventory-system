using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Inventory
{
    public class Customer: Supplier
    {
        public Customer()
        {
            this.ContactGroupID = 2;
        }
        public override bool AssignDataRow(DataRow row)
        {
            if (!base.AssignDataRow(row)) return false;
            try
            {
                Billing_address = row["Billing address"].ToString();
                Billing_city = row["Billing City"].ToString();
                Billing_country = row["Billing Country"].ToString();
                Billing_state = row["Billing State"].ToString();
                Billing_zip = row["Billing Zip"].ToString();
                Billing_phone = row["Billing Phone"].ToString();
                Billing_email = row["Billing Email"].ToString();
                

                Shipping_address1 = row["Billing address"].ToString();
                Shipping_city = row["Billing City"].ToString();
                Shipping_country = row["Billing Country"].ToString();
                Shipping_state = row["Billing State"].ToString();
                Shipping_zip = row["Billing Zip"].ToString();
                Shipping_phone = row["Billing Phone"].ToString();
                Shipping_email = row["Billing Email"].ToString();

                return true;
            }
            catch (Exception) { }
            return false;
        }

        public override bool ToDataRow(DataRow row)
        {
            if (!base.ToDataRow(row)) return false;
            try
            {
                row["Billing address"] = Billing_address;
                row["Billing City"] = Billing_city;
                row["Billing Country"] = Billing_country;
                row["Billing State"] = Billing_state;
                row["Billing Zip"] = Billing_zip;
                row["Billing Phone"] = Billing_phone;
                row["Billing Email"] = Billing_email;
                

                row["Billing address"] = Shipping_address1;
                row["Billing City"] = Shipping_city;
                row["Billing Country"] = Shipping_country;
                row["Billing State"] = Shipping_state;
                row["Billing Zip"] = Shipping_zip;
                row["Billing Phone"] = Shipping_phone;
                row["Billing Email"] = Shipping_email;

                return true;
            }
            catch (Exception) { }
            return false;
        }
        public string Billing_address;
        public string Billing_city;
        public string Billing_state;
        public string Billing_country;
        public string Billing_zip;
        public string Billing_phone;
        public string Billing_email;
        public string Shipping_address1;
        public string Shipping_city;
        public string Shipping_state;
        public string Shipping_country;
        public string Shipping_zip;
        public string Shipping_phone;
        public string Shipping_email;        
    }
    
}
