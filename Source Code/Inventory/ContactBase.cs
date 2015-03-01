using System;
using System.Collections.Generic;
using System.Text;
using System.Data;



namespace Inventory
{
    public class ContactBase
    {
        public static string GetID()
        {
            return Guid.NewGuid().ToString();
        }
        public static string GetContactName(string CID)
        {
            if (CID == "") return "";
            string strSQL = "SELECT * FROM Contact WHERE ContactID = '" + CID + "'";
            if (!Data_Access.DoSqlCommand(strSQL)) return "";
            try{
                DataRow row = Data_Access.GetDataSet().Tables[0].Rows[0];
                
                return row["LastName"].ToString() + " " + row["MiddleName"].ToString() + " " + row["FirstName"].ToString();
            } catch(Exception e) {}
            return "";
        }
        // data row phai chua cac truong thoa man 
        public virtual bool AssignDataRow(DataRow row)
        {
            try
            {
                ContactID = row["Contact ID"].ToString();
                Mr = row["Mr"].ToString();
                FirstName = row["First Name"].ToString();
                MiddleName = row["Middle Name"].ToString();
                LastName = row["Last Name"].ToString();
                EmailName = row["Email Name"].ToString();                
                Address1 = row["Address 1"].ToString();
                Address2 = row["Address 2"].ToString();
                City = row["City"].ToString();
                Province = row["Province"].ToString();
                Zip = row["Zip"].ToString();
                Country = row["Country"].ToString();
                Phone1 = row["Phone 1"].ToString();
                Phone2 = row["Phone 2"].ToString();
                Fax1 = row["Fax 1"].ToString();
                Fax2 = row["Fax 2"].ToString();
                Cell1 = row["Cell 1"].ToString();
                Cell2 = row["Cell 2"].ToString();
                Email1 = row["Email 1"].ToString();
                try
                {
                    Email2 = row["Email 2"].ToString();
                }
                catch { }
                try
                {
                    Email3 = row["Email 3"].ToString();
                }
                catch { }
                Notes = row["Notes"].ToString();
                ContactGroupID = Convert.ToInt32(row["Contact Group ID"].ToString());
                SubscribeNews = Convert.ToBoolean(row["SubscribeNews"].ToString());
                ViewStatus = Convert.ToBoolean(row["ViewStatus"].ToString());
                UserID = row["UserID"].ToString();
                return true;
            }
            catch (Exception) { }
            return false;
        }
        public virtual bool ToDataRow(DataRow row)
        {
            try
            {
                row["Contact ID"] = ContactID;
                row["Mr"] = Mr;
                row["First Name"] = FirstName;
                row["Middle Name"] = MiddleName;
                row["Last Name"] = LastName;
                row["Email Name"] = EmailName;                
                
                row["Address 1"] = Address1;
                row["Address 2"] = Address2;
                row["City"] = City;
                row["Province"] = Province;
                row["Zip"] = Zip;
                row["Country"] = Country;
                row["Phone 1"] = Phone1;
                row["Phone 2"] = Phone2;
                row["Fax 1"] = Fax1;
                row["Fax 2"] = Fax2;
                row["Cell 1"] = Cell1;
                row["Cell 2"] = Cell2;
                row["Email 1"] = Email1;
                row["Email 2"] = Email2;
                row["Email 3"] = Email3;
                
                row["Notes"] = Notes;
                row["Contact Group ID"] = ContactGroupID;                 
                row["SubscribeNews"] = SubscribeNews;                 
                row["ViewStatus"] = ViewStatus;
                row["UserID"] = UserID;
               
                return true;
            }
            catch (Exception) { }
            return false;
        }        
        public string ContactID;        
        public string Mr;
        public string FirstName;
        public string MiddleName;
        public string LastName;
        public string EmailName;                
               
        public string Address1;
        public string Address2;
        public string City;
        public string Province;
        public string Zip;
        public string Country;
        public string Phone1;
        public string Phone2;
        public string Fax1;
        public string Fax2;
        public string Cell1;
        public string Cell2;
        public string Email1;
        public string Email2;
        public string Email3;              
        public string Notes;

        public int ContactGroupID;
        public bool SubscribeNews;
        public bool ViewStatus;
        public string UserID;
        
                 
    }
}
