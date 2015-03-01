/*******************************************************************
*TaxType record structure
* Created by DuongNT (g8 company)
* Date: Sunday, June 17, 2007
*******************************************************************/
using System;
using System.Data;
namespace G8_POS
{
    public class TaxTypeRec
    {
        public String TaxTypeID;
        public String TaxTypeName;
        public String Note;
        public TaxTypeRec(DataRow row) : base()
        {
            AssignFromDataRow(row);
        }
        public TaxTypeRec() : base() {}
        public bool AssignFromDataRow(DataRow row)
        {
            try
            {
                TaxTypeID = (String)row["TaxTypeID"];
            } catch {}
            try
            {
                TaxTypeName = (String)row["TaxTypeName"];
            } catch {}
            try
            {
                Note = (String)row["Note"];
            } catch {}
            return true;
        }
        public bool AssignToDataRow(DataRow row)
        {
            try
            {
                row["TaxTypeID"] = TaxTypeID;
            } catch {}
            try
            {
                row["TaxTypeName"] = TaxTypeName;
            } catch {}
            try
            {
                row["Note"] = Note;
            } catch {}
            return true;
        }
        public TaxTypeRec Copy()
        {
            TaxTypeRec ret = new TaxTypeRec();
            ret.TaxTypeID = TaxTypeID;
            ret.TaxTypeName = TaxTypeName;
            ret.Note = Note;
            return ret;
        }
    }
}
