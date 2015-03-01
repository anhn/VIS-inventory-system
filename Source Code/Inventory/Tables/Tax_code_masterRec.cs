/*******************************************************************
*Tax_code_master record structure
* Created by Turbo Database copy right by DuongNT (g8 company)
* Date: Wednesday, April 04, 2007
*******************************************************************/
using System;
using System.Data;
namespace Inventory
{
    public class Tax_code_masterRec
    {
        public String Tax_code_id;
        public String Tax_code_desc;
        public Boolean ViewStatus;
        public String UserID;
        public Byte[] Timestamp;
        public Tax_code_masterRec(DataRow row) : base()
        {
            AssignFromDataRow(row);
        }
        public Tax_code_masterRec() : base() {}
        public bool AssignFromDataRow(DataRow row)
        {
            try
            {
                Tax_code_id = (String)row["Tax_code_id"];
            } catch {}
            try
            {
                Tax_code_desc = (String)row["Tax_code_desc"];
            } catch {}
            try
            {
                ViewStatus = (Boolean)row["ViewStatus"];
            } catch {}
            try
            {
                UserID = (String)row["UserID"];
            } catch {}
            try
            {
                Timestamp = (Byte[])row["Timestamp"];
            } catch {}
            return true;
        }
        public bool AssignToDataRow(DataRow row)
        {
            try
            {
                row["Tax_code_id"] = Tax_code_id;
            } catch {}
            try
            {
                row["Tax_code_desc"] = Tax_code_desc;
            } catch {}
            try
            {
                row["ViewStatus"] = ViewStatus;
            } catch {}
            try
            {
                row["UserID"] = UserID;
            } catch {}
            try
            {
                row["Timestamp"] = Timestamp;
            } catch {}
            return true;
        }
        public Tax_code_masterRec Copy()
        {
            Tax_code_masterRec ret = new Tax_code_masterRec();
            ret.Tax_code_id = Tax_code_id;
            ret.Tax_code_desc = Tax_code_desc;
            ret.ViewStatus = ViewStatus;
            ret.UserID = UserID;
            ret.Timestamp = Timestamp;
            return ret;
        }
    }
}
