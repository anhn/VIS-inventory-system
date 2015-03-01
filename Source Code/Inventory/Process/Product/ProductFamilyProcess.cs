using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using Inventory.DataModels.Product;
using Inventory.DataObjects;
using Inventory.DataModels;

namespace Inventory.Process.Product
{
    class ProductFamilyProcess
    {
        private ProductFamilyModel model;
        private string strDeleteID = string.Empty;
        private SqlCommand objCmd;

        public ProductFamilyModel DataIn
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

        public void NewProductFamily()
        {
            ProductFamily masterDelv = model.GetMasterRecord();
            masterDelv.FamilyID = Guid.NewGuid().ToString();
            masterDelv.Insert(objCmd);
        }

        internal void EditProductFamily()
        {
            ProductFamily masterDelv = model.GetMasterRecord();

            masterDelv.Update(objCmd);
        }

        internal void DeleteProductFamily()
        {
            ProductFamily masterDelv = new ProductFamily();
            masterDelv.FamilyID = strDeleteID;
            masterDelv.Delete(objCmd);
        }
    }
}
