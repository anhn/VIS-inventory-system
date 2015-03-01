/*******************************************************************
*t_Shop record structure
* Created by Turbo Database copy right by DuongNT (g8 company)
* Date: Wednesday, April 04, 2007
*******************************************************************/
using System;
using System.Data;
namespace Inventory
{
    public class t_ShopRec
    {
        public String ShopID;
        public String ShopName;
        public t_ShopRec(DataRow row) : base()
        {
            AssignFromDataRow(row);
        }
        public t_ShopRec() : base() {}
        public bool AssignFromDataRow(DataRow row)
        {
            try
            {
                ShopID = (String)row["ShopID"];
            } catch {}
            try
            {
                ShopName = (String)row["ShopName"];
            } catch {}
            return true;
        }
        public bool AssignToDataRow(DataRow row)
        {
            try
            {
                row["ShopID"] = ShopID;
            } catch {}
            try
            {
                row["ShopName"] = ShopName;
            } catch {}
            return true;
        }
        public t_ShopRec Copy()
        {
            t_ShopRec ret = new t_ShopRec();
            ret.ShopID = ShopID;
            ret.ShopName = ShopName;
            return ret;
        }
    }
}
