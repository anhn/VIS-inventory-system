using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Inventory.DataObjects;
using Inventory.DataObjects.DAO;

namespace Inventory.Process
{
    public class WarehouseProductMasterPocess
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

        public void UpdateOnHand()
        {
            // get warehouse by location
            LocationDao objLocDao = new LocationDao();
            string strWarehouse = objLocDao.SelectWarehouseByLocation(strLocation);

            // get all locations by warehouse
            DataTable dtLocations = objLocDao.SelectLocationsOfWareHouse(strWarehouse);
            ArrayList arrLocations = new ArrayList();
            foreach (DataRow dr in dtLocations.Rows)
            {
                string strLoc = (dr["Bin_Location_Id"] == DBNull.Value)? "" : dr["Bin_Location_Id"].ToString();
                if (!string.IsNullOrEmpty(strLoc))
                {
                    arrLocations.Add(strLoc);
                }
            }

            int intQty = 0;

            // calculate Sum of all LocationProduct with the same warehouse
            ProductLocation objProLoc = new ProductLocation();
            DataTable dtProLocs = objProLoc.SelectAll();
            foreach (DataRow dr in dtProLocs.Rows)
            {
                string strP = (dr["ProductID"] == DBNull.Value) ? "" : dr["ProductID"].ToString();
                string strL = (dr["LocationID"] == DBNull.Value) ? "" : dr["LocationID"].ToString();

                if(strProduct == strP && arrLocations.Contains(strL))
                {
                    int qty = (dr["Qty_on_hand"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["Qty_on_hand"]);
                    intQty += qty;
                }
            }

            WarehouseProductMaster objWhProd = new WarehouseProductMaster();
            WarehouseProductDao objDao = new WarehouseProductDao();
            objDao.SelectOneByWarehouseProduct(objCmd, objWhProd, strWarehouse, strProduct);

            if (objWhProd.Warehouse_id.IsNull || objWhProd.Product_id.IsNull) // no row exists
            {
                return;
            }

            objWhProd.On_hand_qty = intQty;
            objWhProd.Update(objCmd);
        }
    }
}
