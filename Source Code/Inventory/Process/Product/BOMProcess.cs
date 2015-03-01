using System;
using System.Collections.Generic;
using System.Text;
using Inventory.DataModels.Product;
using System.Data.SqlClient;
using Inventory.DataObjects;
using System.Collections;

namespace Inventory.Process.Product
{
    class BOMProcess
    {
        private BOMModel model;
        private string strID = string.Empty;
        private SqlCommand objCmd;

        public BOMModel DataIn
        {
            get { return model; }
            set { model = value; }
        }

        public SqlCommand DBCommand
        {
            get { return objCmd; }
            set { objCmd = value; }
        }

        public String ID
        {
            get { return strID; }
            set { strID = value; }
        }


        internal void NewBOM()
        {
            ICommonDBAccess objMaster = model.GetMasterRecord();
            objMaster.Insert(DBCommand);
            model.CopyID(objMaster);
            
            //Create StockIn List Details
            if (model.Details == null) return;

            ArrayList arrDetails = model.GetDetailsRecord();
            foreach (ICommonDBAccess objDetail in arrDetails)
            {
                objDetail.Insert(DBCommand);
            }
        }

        internal void EditBOM()
        {
            ICommonDBAccess objMaster = model.GetMasterRecord();
            objMaster.Update(DBCommand);
            model.AnalyzeDetailsChanges();
            //Add new details
            foreach (ICommonDBAccess objDetail in model.NewDetails)
            {
                objDetail.Insert(DBCommand);
            }
            //Update changed details
            foreach (ICommonDBAccess objDetail in model.ChangedDetails)
            {
                objDetail.Update(DBCommand);
            }
            //DeleteBOM som details
            foreach (ICommonDBAccess objDetail in model.DeletedDetails)
            {
                objDetail.Delete(DBCommand);
            }
        }

        internal void DeleteBOM()
        {
            model.LoadFromDataBase();
            //Create StockIn List Details
            if (model.Details == null) return;

            ArrayList arrDetails = model.GetDetailsRecord();
            foreach (ICommonDBAccess objDetail in arrDetails)
            {
                objDetail.Delete(DBCommand);
            }

            ICommonDBAccess objMaster = model.GetMasterRecord();
            objMaster.Delete(DBCommand);
        }
    }
}
