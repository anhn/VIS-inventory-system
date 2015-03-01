using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace Inventory
{
    class Contact:ContactBase
    {
        public string Position;
        public string Department;
        public string Division;
        public byte[] Photo;
        public override bool AssignDataRow(DataRow row)
        {
            if (base.AssignDataRow(row) == false) return false;
            try
            {
                Position = row["Position"].ToString();
                Department = row["Department"].ToString();
                Division = row["Division"].ToString();
                Photo = (byte[])row["Photo"];
                return true;
            }
            catch (Exception) { }
            return false;
        }
        public override bool ToDataRow(DataRow row)
        {
            if (base.ToDataRow(row) == false) return false;
            try
            {                            
                row["Position"] = Position;
                row["Department"] = Department;
                Photo = (byte[])row["Photo"];
                row["Division"] = Division;
                return true;
            }
            catch (Exception) { }
            return false;
        }        
    }
}
