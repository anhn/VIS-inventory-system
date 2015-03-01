using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Inventory.DataObjects;
using Inventory.DataObjects.DAO;

namespace Inventory.Process
{
    public class ProductLocationProcess
    {
        private String strProduct;
        private String strLocation;
        private SqlCommand objCmd = null;

        public String Product
        {
            get { return strProduct; }
            set { strProduct = value; }
        }
        public String Location
        {
            get { return strLocation; }
            set { strLocation = value; }
        }


        public SqlCommand DBCommand
        {
            get { return objCmd; }
            set { objCmd = value; }
        }

        public void UpdateOnHand(Int32 oldQty, Int32 newQty)
        {
            if (oldQty == newQty)
            {
                return;
            }

            ProductLocation objProLoc = new ProductLocation();
            ProductLocationDao objDao = new ProductLocationDao();
            objDao.SelectOneByLocationProduct(objCmd, objProLoc, strLocation, strProduct);

            if (objProLoc.LocationID.IsNull || objProLoc.ProductID.IsNull) // no row exists
            {
                return;
            }

            objProLoc.Qty_on_hand = newQty;
            objProLoc.Update(objCmd);
        }
    }
}
