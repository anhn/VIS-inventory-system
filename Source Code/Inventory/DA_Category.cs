using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Inventory.Properties
{
    class DA_Category
    {
        public bool Delete(string CatID, string ContactID)
        {
            string strSQL = "DELETE ContactCategory WHERE ContactCatID = '" + CatID + "' AND ContactID = '" + ContactID + "'";
            if (!Data_Access.DoSqlCommand(strSQL)) return false;
            return true;
        }
        public bool Add(string CatID, string ContactID)
        {
            string strSQL = "INSERT INTO ContactCategory(ContactCatID, ContactID) values('" + CatID + "', '" + ContactID + "')";
            if (!Data_Access.DoSqlCommand(strSQL)) return false;
            return true;
        }
        public bool Delete(string ContactID)
        {
            string strSQL = "DELETE ContactCategory WHERE ContactID = '" + ContactID + "'";
            if (!Data_Access.DoSqlCommand(strSQL)) return false;
            return true;
        }
        public static string getCategoriesName(string ContactID)
        {
            string strSQL = "SELECT CategoryInContact.ContactCatID, ContactCatName, Notes, ViewStatus, UserID FROM ContactCategory, CategoryInContact WHERE ContactCategory.ContactCatID = CategoryInContact.ContactCatID AND ContactCategory.ContactID = '" + ContactID + "' AND CategoryInContact.ViewStatus = 'true'";
            if (!Data_Access.DoSqlCommand(strSQL)) return "";
            DataTable tab = Data_Access.GetDataSet().Tables[0];
            string ret = "";
            foreach (DataRow row in  tab.Rows)
                ret += " " + row["ContactCatName"].ToString() + ",";

            if (ret.Length > 0)
                return ret.Remove(ret.Length - 1);
            else return "";
        }
        public static string getCategoriesName(CategoryRec[] cats)
        {
            string ret = "";
            foreach (CategoryRec rec in cats)
                if (rec.status != - 1)
                ret += " " + rec.ContactCatName.ToString() + ",";

            if (ret.Length > 0)
                return ret.Remove(ret.Length - 1);
            else return "";
        }
    }
}
