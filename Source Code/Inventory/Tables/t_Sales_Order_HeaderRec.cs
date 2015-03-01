/*******************************************************************
*t_Sales_Order_Header record structure
* Created by Turbo Database copy right by DuongNT (g8 company)
* Date: Wednesday, April 04, 2007
*******************************************************************/
using System;
using System.Data;
namespace Inventory
{
    public class t_Sales_Order_HeaderRec
    {
        public String SONo;
        public DateTime SODate;
        public String SOTypeID;
        public String ShopID;
        public String CustID;
        public String PayType;
        public Decimal PayAmount;
        public Decimal OSAmount;
        public String Tax_code_id;
        public Decimal Discount;
        public String Notes;
        public String CreatedBy;
        public DateTime CreatedDate;
        public String LastUpdatedBy;
        public DateTime LastUpdatedDate;
        public Boolean ViewStatus;
        public String PaymentTermsID;
        public String ShipViaID;
        public Decimal TaxRate;
        public Decimal ShippingFee;
        public String FOB;
        public Decimal ReceivedAmt;

        public t_Sales_Order_HeaderRec(DataRow row) : base()
        {
            AssignFromDataRow(row);
        }
        public t_Sales_Order_HeaderRec() : base() {}
        public bool AssignFromDataRow(DataRow row)
        {
            SONo = (String)row["SONo"];
            if (row["SODate"] != System.DBNull.Value) SODate = (DateTime)row["SODate"];
            if (row["SOTypeID"] != System.DBNull.Value) SOTypeID = (String)row["SOTypeID"];
            if (row["ShopID"] != System.DBNull.Value) ShopID = (String)row["ShopID"];
            if (row["CustID"] != System.DBNull.Value) CustID = (String)row["CustID"];
            if (row["PayType"] != System.DBNull.Value) PayType = (String)row["PayType"];
            if (row["PayAmount"] != System.DBNull.Value) PayAmount = (Decimal)row["PayAmount"];
            if (row["OSAmount"] != System.DBNull.Value) OSAmount = (Decimal)row["OSAmount"];
            if (row["Tax_code_id"] != System.DBNull.Value) Tax_code_id = (String)row["Tax_code_id"];
            if (row["Discount"] != System.DBNull.Value) Discount = (Decimal)row["Discount"];
            if (row["Notes"] != System.DBNull.Value) Notes = (String)row["Notes"];
            if (row["CreatedBy"] != System.DBNull.Value) CreatedBy = (String)row["CreatedBy"];
            if (row["CreatedDate"] != System.DBNull.Value) CreatedDate = (DateTime)row["CreatedDate"];
            if (row["LastUpdatedBy"] != System.DBNull.Value) LastUpdatedBy = (String)row["LastUpdatedBy"];
            if (row["LastUpdatedDate"] != System.DBNull.Value) LastUpdatedDate = (DateTime)row["LastUpdatedDate"];
            if (row["ViewStatus"] != System.DBNull.Value) ViewStatus = (Boolean)row["ViewStatus"];

            if (row["PaymentTermsID"] != System.DBNull.Value) PaymentTermsID = (String)row["PaymentTermsID"];
            if (row["ShipViaID"] != System.DBNull.Value) ShipViaID = (String)row["ShipViaID"];
            if (row["TaxRate"] != System.DBNull.Value) TaxRate = (Decimal)row["TaxRate"];
            if (row["ShippingFee"] != System.DBNull.Value) ShippingFee = (Decimal)row["ShippingFee"];
            if (row["FOB"] != System.DBNull.Value) FOB = (String)row["FOB"];
            if (row["ReceivedAmt"] != System.DBNull.Value) ReceivedAmt = (Decimal)row["ReceivedAmt"];

            return true;
        }
        public bool AssignToDataRow(DataRow row)
        {
            row["SONo"] = SONo;
            row["SODate"] = SODate;
            row["SOTypeID"] = SOTypeID;
            row["ShopID"] = ShopID;
            row["CustID"] = CustID;
            row["PayType"] = PayType;
            row["PayAmount"] = PayAmount;
            row["OSAmount"] = OSAmount;
            row["Tax_code_id"] = Tax_code_id;
            row["Discount"] = Discount;
            row["Notes"] = Notes;
            row["CreatedBy"] = CreatedBy;
            row["CreatedDate"] = CreatedDate;
            row["LastUpdatedBy"] = LastUpdatedBy;
            row["LastUpdatedDate"] = LastUpdatedDate;
            row["ViewStatus"] = ViewStatus;

            row["PaymentTermsID"] = PaymentTermsID;
            row["ShipViaID"] = ShipViaID;
            row["TaxRate"] = TaxRate;
            row["ShippingFee"] = ShippingFee;
            row["FOB"] = FOB;
            row["ReceivedAmt"] = ReceivedAmt;

            return true;
        }
        public t_Sales_Order_HeaderRec Copy()
        {
            t_Sales_Order_HeaderRec ret = new t_Sales_Order_HeaderRec();
            ret.SONo = SONo;
            ret.SODate = SODate;
            ret.SOTypeID = SOTypeID;
            ret.ShopID = ShopID;
            ret.CustID = CustID;
            ret.PayType = PayType;
            ret.PayAmount = PayAmount;
            ret.OSAmount = OSAmount;
            ret.Tax_code_id = Tax_code_id;
            ret.Discount = Discount;
            ret.Notes = Notes;
            ret.CreatedBy = CreatedBy;
            ret.CreatedDate = CreatedDate;
            ret.LastUpdatedBy = LastUpdatedBy;
            ret.LastUpdatedDate = LastUpdatedDate;
            ret.ViewStatus = ViewStatus;

            ret.PaymentTermsID = PaymentTermsID;
            ret.ShipViaID = ShipViaID;
            ret.TaxRate = TaxRate;
            ret.ShippingFee = ShippingFee;
            ret.FOB = FOB;
            ret.ReceivedAmt = ReceivedAmt;
            return ret;
        }
    }
}
