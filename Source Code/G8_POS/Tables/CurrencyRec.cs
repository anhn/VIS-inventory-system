/*******************************************************************
*Currency record structure
* Created by DuongNT (g8 company)
* Date: Friday, April 27, 2007
*******************************************************************/
using System;
using System.Data;
namespace G8_POS

{
    public class CurrencyRec
    {
        public String CurrencyID;
        public String CurrencyName;
        public Decimal ExRate;
        public Boolean IsMainCurrency;
        public Boolean ViewStatus;
        public String UserID;
        public DateTime LastUpdateDate;
        public CurrencyRec(DataRow row) : base()
        {
            AssignFromDataRow(row);
        }
        public CurrencyRec() : base() {}
        public bool AssignFromDataRow(DataRow row)
        {
            try
            {
                CurrencyID = (String)row["CurrencyID"];
            } catch {}
            try
            {
                CurrencyName = (String)row["CurrencyName"];
            } catch {}
            try
            {
                ExRate = (Decimal)row["ExRate"];
            } catch {}
            try
            {
                IsMainCurrency = (Boolean)row["IsMainCurrency"];
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
                LastUpdateDate = (DateTime)row["LastUpdateDate"];
            } catch {}
            return true;
        }
        public bool AssignToDataRow(DataRow row)
        {
            try
            {
                row["CurrencyID"] = CurrencyID;
            } catch {}
            try
            {
                row["CurrencyName"] = CurrencyName;
            } catch {}
            try
            {
                row["ExRate"] = ExRate;
            } catch {}
            try
            {
                row["IsMainCurrency"] = IsMainCurrency;
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
                row["LastUpdateDate"] = LastUpdateDate;
            } catch {}
            return true;
        }
        public CurrencyRec Copy()
        {
            CurrencyRec ret = new CurrencyRec();
            ret.CurrencyID = CurrencyID;
            ret.CurrencyName = CurrencyName;
            ret.ExRate = ExRate;
            ret.IsMainCurrency = IsMainCurrency;
            ret.ViewStatus = ViewStatus;
            ret.UserID = UserID;
            ret.LastUpdateDate = LastUpdateDate;
            return ret;
        }
    }
}
