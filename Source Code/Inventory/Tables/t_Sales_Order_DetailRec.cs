/*******************************************************************
*t_Sales_Order_Detail record structure
* Created by Turbo Database copy right by DuongNT (g8 company)
* Date: Wednesday, April 04, 2007
*******************************************************************/
using System;
using System.Data;
namespace Inventory
{
    public class t_Sales_Order_DetailRec
    {
        public String SONo;
        public String SOLineNo;
        public String ProductID;
        public String Qty;
        public Decimal UnitPrice;
        public Decimal DiscountPrice;
        public Decimal DiscountPer;
        public Decimal TotalAmount;
        public Decimal SettleAmount;
        public Decimal OSAmount;
        public String InvoiceNo;
        public Boolean ViewStatus;
        public t_Sales_Order_DetailRec(DataRow row) : base()
        {
            AssignFromDataRow(row);
        }
        public t_Sales_Order_DetailRec() : base() {}
        public bool AssignFromDataRow(DataRow row)
        {
            try
            {
                SONo = (String)row["SONo"];
            } catch {}
            try
            {
                SOLineNo = (String)row["SOLineNo"];
            } catch {}
            try
            {
                ProductID = (String)row["ProductID"];
            } catch {}
            try
            {
                Qty = (String)row["Qty"];
            } catch {}
            try
            {
                UnitPrice = (Decimal)row["UnitPrice"];
            } catch {}
            try
            {
                DiscountPrice = (Decimal)row["DiscountPrice"];
            } catch {}
            try
            {
                DiscountPer = (Decimal)row["DiscountPer"];
            } catch {}
            try
            {
                TotalAmount = (Decimal)row["TotalAmount"];
            } catch {}
            try
            {
                SettleAmount = (Decimal)row["SettleAmount"];
            } catch {}
            try
            {
                OSAmount = (Decimal)row["OSAmount"];
            } catch {}
            try
            {
                InvoiceNo = (String)row["InvoiceNo"];
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
                row["SONo"] = SONo;
            } catch {}
            try
            {
                row["SOLineNo"] = SOLineNo;
            } catch {}
            try
            {
                row["ProductID"] = ProductID;
            } catch {}
            try
            {
                row["Qty"] = Qty;
            } catch {}
            try
            {
                row["UnitPrice"] = UnitPrice;
            } catch {}
            try
            {
                row["DiscountPrice"] = DiscountPrice;
            } catch {}
            try
            {
                row["DiscountPer"] = DiscountPer;
            } catch {}
            try
            {
                row["TotalAmount"] = TotalAmount;
            } catch {}
            try
            {
                row["SettleAmount"] = SettleAmount;
            } catch {}
            try
            {
                row["OSAmount"] = OSAmount;
            } catch {}
            try
            {
                row["InvoiceNo"] = InvoiceNo;
            } catch {}
            try
            {
                row["ViewStatus"] = ViewStatus;
            } catch {}
            return true;
        }
        public t_Sales_Order_DetailRec Copy()
        {
            t_Sales_Order_DetailRec ret = new t_Sales_Order_DetailRec();
            ret.SONo = SONo;
            ret.SOLineNo = SOLineNo;
            ret.ProductID = ProductID;
            ret.Qty = Qty;
            ret.UnitPrice = UnitPrice;
            ret.DiscountPrice = DiscountPrice;
            ret.DiscountPer = DiscountPer;
            ret.TotalAmount = TotalAmount;
            ret.SettleAmount = SettleAmount;
            ret.OSAmount = OSAmount;
            ret.InvoiceNo = InvoiceNo;
            ret.ViewStatus = ViewStatus;
            return ret;
        }
    }
}
