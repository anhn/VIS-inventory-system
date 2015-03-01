/*******************************************************************
*t_Purchase_Order_Header record structure
* Created by Turbo Database copy right by DuongNT (g8 company)
* Date: Wednesday, April 04, 2007
*******************************************************************/
using System;
using System.Data;
namespace Inventory
{
    public class t_Purchase_Order_HeaderRec
    {
        public String PONo;
        public DateTime PODate;
        public String POTypeID;
        public DateTime DeliveryDate;
        public String ShipTo;
        public String SupplierID;
        public Decimal TotalAmt = 0;
        public String AccountNo;
        public String Tax_code_id;
        public Decimal Discount = 0;
        public Decimal ShippingFee = 0;
        public String PaymentTermsID;
        public String Notes;
        public String CreatedBy;
        public DateTime CreatedDate;
        public String LastUpdatedBy;
        public DateTime LastUpdatedDate;
        public Boolean ViewStatus;
        public String ShipViaID;
        public Decimal TaxPercentage = 0;
        public String FOB;
        public Decimal ReceivedAmt = 0;

        public t_Purchase_Order_HeaderRec(DataRow row) : base()
        {
            AssignFromDataRow(row);
        }
        public t_Purchase_Order_HeaderRec() : base() {}
        public bool AssignFromDataRow(DataRow row)
        {
            PONo = (String)row["PONo"];
            if (row["PODate"] != System.DBNull.Value) PODate = (DateTime)row["PODate"];
            if (row["POTypeID"] != System.DBNull.Value) POTypeID = (String)row["POTypeID"];
            if (row["DeliveryDate"] != System.DBNull.Value) DeliveryDate = (DateTime)row["DeliveryDate"];
            if (row["ShipTo"] != System.DBNull.Value) ShipTo = (String)row["ShipTo"];
            if (row["SupplierID"] != System.DBNull.Value) SupplierID = (String)row["SupplierID"];
            if (row["TotalAmt"] != System.DBNull.Value) TotalAmt = (Decimal)row["TotalAmt"];
            if (row["AccountNo"] != System.DBNull.Value) AccountNo = (String)row["AccountNo"];
            if (row["Tax_code_id"] != System.DBNull.Value) Tax_code_id = (String)row["Tax_code_id"];
            if (row["Discount"] != System.DBNull.Value) Discount = (Decimal)row["Discount"];
            if (row["ShippingFee"] != System.DBNull.Value) ShippingFee = (Decimal)row["ShippingFee"];
            if (row["PaymentTermsID"] != System.DBNull.Value) PaymentTermsID = (String)row["PaymentTermsID"];
            if (row["Notes"] != System.DBNull.Value) Notes = (String)row["Notes"];
            if (row["CreatedBy"] != System.DBNull.Value) CreatedBy = (String)row["CreatedBy"];
            if (row["CreatedDate"] != System.DBNull.Value) CreatedDate = (DateTime)row["CreatedDate"];
            if (row["LastUpdatedBy"] != System.DBNull.Value) LastUpdatedBy = (String)row["LastUpdatedBy"];
            if (row["LastUpdatedDate"] != System.DBNull.Value) LastUpdatedDate = (DateTime)row["LastUpdatedDate"];
            if (row["ViewStatus"] != System.DBNull.Value) ViewStatus = (Boolean)row["ViewStatus"];
            if (row["ShipViaID"] != System.DBNull.Value) ShipViaID = (String)row["ShipViaID"];
            if (row["TaxPercentage"] != System.DBNull.Value) TaxPercentage = (Decimal)row["TaxPercentage"];
            if (row["FOB"] != System.DBNull.Value) FOB = (String)row["FOB"];
            if (row["ReceivedAmt"] != System.DBNull.Value) ReceivedAmt = (Decimal)row["ReceivedAmt"];

            return true;
        }
        public bool AssignToDataRow(DataRow row)
        {
            row["PONo"] = PONo;
            row["PODate"] = PODate;
            row["POTypeID"] = POTypeID;
            row["DeliveryDate"] = DeliveryDate;
            row["ShipTo"] = ShipTo;
            row["SupplierID"] = SupplierID;
            row["TotalAmt"] = TotalAmt;
            row["AccountNo"] = AccountNo;
            row["Tax_code_id"] = Tax_code_id;
            row["Discount"] = Discount;
            row["ShippingFee"] = ShippingFee;
            row["PaymentTermsID"] = PaymentTermsID;
            row["Notes"] = Notes;
            row["CreatedBy"] = CreatedBy;
            row["CreatedDate"] = CreatedDate;
            row["LastUpdatedBy"] = LastUpdatedBy;
            row["LastUpdatedDate"] = LastUpdatedDate;
            row["ViewStatus"] = ViewStatus;
            row["ShipViaID"] = ShipViaID;
            row["TaxPercentage"] = TaxPercentage;
            row["FOB"] = FOB;
            row["ReceivedAmt"] = ReceivedAmt;

            return true;
        }
        public t_Purchase_Order_HeaderRec Copy()
        {
            t_Purchase_Order_HeaderRec ret = new t_Purchase_Order_HeaderRec();
            ret.PONo = PONo;
            ret.PODate = PODate;
            ret.POTypeID = POTypeID;
            ret.DeliveryDate = DeliveryDate;
            ret.ShipTo = ShipTo;
            ret.SupplierID = SupplierID;
            ret.TotalAmt = TotalAmt;
            ret.AccountNo = AccountNo;
            ret.Tax_code_id = Tax_code_id;
            ret.Discount = Discount;
            ret.ShippingFee = ShippingFee;
            ret.PaymentTermsID = PaymentTermsID;
            ret.Notes = Notes;
            ret.CreatedBy = CreatedBy;
            ret.CreatedDate = CreatedDate;
            ret.LastUpdatedBy = LastUpdatedBy;
            ret.LastUpdatedDate = LastUpdatedDate;
            ret.ViewStatus = ViewStatus;
            ret.ShipViaID = ShipViaID;
            ret.TaxPercentage = TaxPercentage;
            ret.FOB = FOB;
            ret.ReceivedAmt = ReceivedAmt;

            return ret;
        }
    }
}
