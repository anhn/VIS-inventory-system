/*******************************************************************
*Payment_Term_Master record structure
* Created by Turbo Database copy right by DuongNT (g8 company)
* Date: Wednesday, April 04, 2007
*******************************************************************/
using System;
using System.Data;
namespace Inventory
{
    public class Payment_Term_MasterRec
    {
        public String ID;
        public String PaymentTermsName;
        public Int32 DiscountDay;
        public Int32 PaymentsDay;
        public Boolean ViewStatus;
        public String UserID;
        public String Notes;
        public Decimal DiscountPercent;
        public DateTime LastUpdatedDate;

        public Payment_Term_MasterRec(DataRow row) : base()
        {
            AssignFromDataRow(row);
        }
        public Payment_Term_MasterRec() : base() {}
        public bool AssignFromDataRow(DataRow row)
        {
            try
            {
                ID = (String)row["ID"];
            } catch {}
            try
            {
                PaymentTermsName = (String)row["PaymentTermsName"];
            } catch {}
            try
            {
                DiscountDay = (Int32)row["DiscountDay"];
            } catch {}
            try
            {
                DiscountPercent = (Int32)row["DiscountPercent"];
            } catch {}
            try
            {
                PaymentsDay = (Int32)row["PaymentsDay"];
            }
            catch { }
            try
            {
                ViewStatus = (Boolean)row["ViewStatus"];
            } catch {}
            try
            {
                LastUpdatedDate = (DateTime)row["LastUpdatedDate"];
            } catch {}            
            try
            {
                UserID = (String)row["UserID"];
            } catch {}
            try
            {
                Notes = (String)row["Notes"];
            } catch {}
            return true;
        }
        public bool AssignToDataRow(DataRow row)
        {
            try
            {
                row["ID"] = ID;
            }
            catch { }
            try
            {
                row["PaymentTermsName"] = PaymentTermsName;
            }
            catch { }
            try
            {
                row["DiscountDay"] = DiscountDay.ToString();
            }
            catch { }
            try
            {
                row["DiscountPercent"] = DiscountPercent.ToString();
            }
            catch { }
            try
            {
                row["PaymentsDay"] = PaymentsDay.ToString();
            }
            catch { }
            try
            {
                row["ViewStatus"] = ViewStatus.ToString();
            }
            catch { }
            try
            {
                row["LastUpdatedDate"] = LastUpdatedDate.ToString();
            }
            catch { }
            try
            {
                row["UserID"] = UserID;
            }
            catch { }
            try
            {
                row["Notes"] = Notes;
            }
            catch { }
            return true;
        }
        public Payment_Term_MasterRec Copy()
        {
            Payment_Term_MasterRec ret = new Payment_Term_MasterRec();
            ret.ID = ID;
            ret.LastUpdatedDate = LastUpdatedDate;
            ret.Notes = Notes;
            ret.PaymentsDay = PaymentsDay;
            ret.PaymentTermsName = PaymentTermsName;
            ret.UserID = UserID;
            ret.ViewStatus = ViewStatus;
            ret.DiscountDay = DiscountDay;
            ret.DiscountPercent = DiscountPercent;
            return ret;
        }
    }
}
