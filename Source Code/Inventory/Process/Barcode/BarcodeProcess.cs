using System;
using System.Collections.Generic;
using System.Text;
using Inventory.DataModels.Barcode;
using System.Data.SqlClient;
using Inventory.DataObjects;

namespace Inventory.Process.Barcode
{
    public class BarcodeProcess
    {
        private BarcodeModel model;
        private string strDeleteID = string.Empty;
        private SqlCommand objCmd;

        public BarcodeModel DataIn
        {
            get { return model; }
            set { model = value; }
        }

        public SqlCommand DBCommand
        {
            get { return objCmd; }
            set { objCmd = value; }
        }

        public string DeleteID
        {
            get { return strDeleteID; }
            set { strDeleteID = value; }
        }

        public void NewBarcode()
        {
            BarcodeMaster masterDelv = model.GetMasterRecord();
            masterDelv.Insert(objCmd);
        }

        internal void EditBarcode()
        {
            BarcodeMaster masterDelv = model.GetMasterRecord();
            masterDelv.Update(objCmd);
        }

        internal void DeleteBarcode(string strDeletedId)
        {
            BarcodeMaster masterDelv = new BarcodeMaster();
            masterDelv.ID = this.model.BarcodeId;
            masterDelv.Delete(objCmd);
        }
    }
}
