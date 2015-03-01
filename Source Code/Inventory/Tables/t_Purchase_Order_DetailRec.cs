/*******************************************************************
*t_Purchase_Order_Detail record structure
* Created by Turbo Database copy right by DuongNT (g8 company)
* Date: Wednesday, April 04, 2007
*******************************************************************/
using System;
using System.Data;
namespace Inventory
{
    public class t_Purchase_Order_DetailRec
    {
        public String PONo;
        public String POLineNo;
        public String POProductID;
        public String POSupplierProduct;
        public String ProductUnit;
        public Decimal PackQty;
        public Decimal OrderQty;
        public Decimal ReceiveQty;
        public Boolean ViewStatus;
        public t_Purchase_Order_DetailRec(DataRow row) : base()
        {
            AssignFromDataRow(row);
        }
        public t_Purchase_Order_DetailRec() : base() {}
        public bool AssignFromDataRow(DataRow row)
        {
            try
            {
                PONo = (String)row["PONo"];
            } catch {}
            try
            {
                POLineNo = (String)row["POLineNo"];
            } catch {}
            try
            {
                POProductID = (String)row["POProductID"];
            } catch {}
            try
            {
                POSupplierProduct = (String)row["POSupplierProduct"];
            } catch {}
            try
            {
                ProductUnit = (String)row["ProductUnit"];
            } catch {}
            try
            {
                PackQty = (Decimal)row["PackQty"];
            } catch {}
            try
            {
                OrderQty = (Decimal)row["OrderQty"];
            } catch {}
            try
            {
                ReceiveQty = (Decimal)row["ReceiveQty"];
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
                row["PONo"] = PONo;
            } catch {}
            try
            {
                row["POLineNo"] = POLineNo;
            } catch {}
            try
            {
                row["POProductID"] = POProductID;
            } catch {}
            try
            {
                row["POSupplierProduct"] = POSupplierProduct;
            } catch {}
            try
            {
                row["ProductUnit"] = ProductUnit;
            } catch {}
            try
            {
                row["PackQty"] = PackQty;
            } catch {}
            try
            {
                row["OrderQty"] = OrderQty;
            } catch {}
            try
            {
                row["ReceiveQty"] = ReceiveQty;
            } catch {}
            try
            {
                row["ViewStatus"] = ViewStatus;
            } catch {}
            return true;
        }
        public t_Purchase_Order_DetailRec Copy()
        {
            t_Purchase_Order_DetailRec ret = new t_Purchase_Order_DetailRec();
            ret.PONo = PONo;
            ret.POLineNo = POLineNo;
            ret.POProductID = POProductID;
            ret.POSupplierProduct = POSupplierProduct;
            ret.ProductUnit = ProductUnit;
            ret.PackQty = PackQty;
            ret.OrderQty = OrderQty;
            ret.ReceiveQty = ReceiveQty;
            ret.ViewStatus = ViewStatus;
            return ret;
        }
    }
}
