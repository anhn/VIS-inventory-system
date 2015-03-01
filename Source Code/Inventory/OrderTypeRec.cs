/*******************************************************************
*OrderType record structure
* Created by Turbo Database copy right by DuongNT (g8 company)
* Date: Wednesday, April 04, 2007
*******************************************************************/
using System;
using System.Data;

namespace Inventory
{
    public class OrderTypeRec
    {
        public String OrderTypeID;
        public String OrderTypeName;
        public String Notes;
        public Boolean ViewStatus;
        
        public bool AssignFromDataRow(DataRow row)
        {
            
            try
            {
                OrderTypeID = (String)row["OrderTypeID"];
            } catch {}
            try
            {
                OrderTypeName = (String)row["OrderTypeName"];
            } catch {}
            try
            {
                Notes = (String)row["Notes"];
            } catch {}
            try
            {
                ViewStatus = (Boolean)row["ViewStatus"];
            } catch {}
            return true;
        }
        public bool AssignToDataRow(DataRow row)
        {
            try
            {
                row["OrderTypeID"] = OrderTypeID;
            } catch {}
            try
            {
                row["OrderTypeName"] = OrderTypeName;
            } catch {}
            try
            {
                row["Notes"] = Notes;
            } catch {}
            try
            {
                row["ViewStatus"] = ViewStatus;
            } catch {}
            return true;
        }
        public OrderTypeRec Copy()
        {
            OrderTypeRec ret = new OrderTypeRec();
            ret.OrderTypeID = OrderTypeID;
            ret.OrderTypeName = OrderTypeName;
            ret.Notes = Notes;
            ret.ViewStatus = ViewStatus;
            return ret;
        }
    }
}
