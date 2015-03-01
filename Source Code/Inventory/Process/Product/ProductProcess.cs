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
    class ProductProcess
    {
        private ProductModel model;
        private string strDeleteID = string.Empty;
        private SqlCommand objCmd;

        public ProductModel DataIn
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

        public void NewProduct()
        {
            ProductMaster masterDelv = model.GetMasterRecord();
            masterDelv.ProductID = masterDelv.NewId();
            masterDelv.Insert(objCmd);
        }

        internal void EditProduct()
        {
            ProductMaster masterDelv = model.GetMasterRecord();
            
            masterDelv.Update(objCmd);
        }

        internal void DeleteProduct()
        {
            ProductMaster masterDelv = new ProductMaster();
            masterDelv.ProductID = strDeleteID;
            masterDelv.Delete(objCmd);
        }
    }
}
