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
    class ProductCategoryProcess
    {
        private ProductCategoryModel model;
        private string strDeleteID = string.Empty;
        private SqlCommand objCmd;

        public ProductCategoryModel DataIn
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

        public void NewProductCategory()
        {
            ProductCategory masterDelv = model.GetMasterRecord();
            masterDelv.CategoryID = Guid.NewGuid().ToString();
            masterDelv.Insert(objCmd);
        }

        internal void EditProductCategory()
        {
            ProductCategory masterDelv = model.GetMasterRecord();

            masterDelv.Update(objCmd);
        }

        internal void DeleteProductCategory()
        {
            ProductCategory masterDelv = new ProductCategory();
            masterDelv.CategoryID = strDeleteID;
            masterDelv.Delete(objCmd);
        }
    }
}
