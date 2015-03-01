using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Inventory
{
    public class CategoryRec
    {
        public string ContactCatID;
        public string ContactCatName;
        public string Notes;
        public bool ViewStatus;
        public string UserID;
        public int status = 1; // 1 = add new, -1 = delete
        public bool AssignFromDataRow(DataRow dr)
        {
            try
            {
                ContactCatID = dr["ContactCatID"].ToString();
                ContactCatName = dr["ContactCatName"].ToString();
                Notes = dr["Notes"].ToString();
                ViewStatus = Convert.ToBoolean(dr["ViewStatus"].ToString());
                UserID = dr["UserID"].ToString();
                return true;
            }
            catch (Exception) { }
            return false;
        }
        public override string ToString()
        {
            return ContactCatName;
        }
       
    }
}
