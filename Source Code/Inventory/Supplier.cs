using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Inventory
{
    public class Supplier:ContactBase
    {
        public Supplier()
        {
            this.ContactGroupID = 3;
        }
        public override bool AssignDataRow(DataRow row)
        {
            if (!base.AssignDataRow(row)) return false;
            try
            {
                ContactName = row["Contact Name"].ToString();
                CompanyName = row["Company Name"].ToString();
                Alt_contact = row["Alt Contact"].ToString();
                Payment_term_id = row["Payment Term ID"].ToString();
                Payment_term_Name = row["Payment Term Name"].ToString();
                Website = row["Website"].ToString();
                Tax_code_id = row["Tax code ID"].ToString();
                Tax_Code_Name = row["Tax Code Name"].ToString();
                AccountName = row["Account Name"].ToString();
                Account_number = Convert.ToInt32(row["Account Number"].ToString());
                Credit_limit = Convert.ToInt32(row["Credit Limit"].ToString());
                Balance = Convert.ToInt32(row["Balance"].ToString());
                Discount = Convert.ToInt32(row["Discount"].ToString());
                Currency = row["Currency"].ToString();
                Tax_agent = row["Tax Agent"].ToString();
                Parent_id = row["Parent ID"].ToString();
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
                row["Contact Name"] = ContactName;
                row["Company Name"] = CompanyName;
                row["Alt Contact"] = Alt_contact;
                row["Payment Term ID"] = Payment_term_id;
                row["Payment Term Name"] = Payment_term_Name;
                row["Website"] = Website;
                row["Tax code ID"] = Tax_code_id;
                row["Tax Code Name"] = Tax_Code_Name;
                row["Account Name"] = AccountName;
                row["Account Number"] = Account_number;
                row["Credit Limit"] = Credit_limit;
                row["Balance"] = Balance;
                row["Discount"] = Discount;
                row["Currency"] = Currency;
                row["Tax Agent"] = Tax_agent;
                row["Parent ID"] = Parent_id;
                return true;
            }
            catch (Exception) { }
            return false;
        }
        public string Website;
        public string ContactName;
        public string CompanyName;
        public string Alt_contact;       
        public string Payment_term_id;
        public string Payment_term_Name;
        public string Tax_code_id;
        public string Tax_Code_Name;
        public string AccountName;
        public int Account_number;
        public int Credit_limit;
        public string Currency;
        public int Balance;
        public int Discount;
        public string Tax_agent;
        public string Parent_id;        
    }
}
