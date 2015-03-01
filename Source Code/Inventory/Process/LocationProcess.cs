using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Inventory.DataObjects;
using Inventory.DataObjects.DAO;

namespace Inventory.Process
{
    class LocationProcess
    {
        private String strWarehouse;
        private String strLocation;
        private SqlCommand objCmd = null;

        public String Warehouse
        {
            get { return strWarehouse; }
            set { strWarehouse = value; }
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

        public void DeductOnHandAddAllocated(String strProduct, Int32 qty)
        {
            if (qty == 0)
            {
                return;
            }
            Location_Master objLocation = new Location_Master();
            LocationDao objDao = new LocationDao();
            objDao.SelectOneByWarehouseLocationProduct(DBCommand, objLocation, strLocation, strWarehouse, strProduct);
            //If warehouse of objLocation is null or empty -> No row exists
            //That means there are errors with the input, Stop the process
            if ((objLocation.Warehouse_id.IsNull) || (String.IsNullOrEmpty((string)objLocation.Warehouse_id)))
            {
                throw new NotFoundException("Product is not existed in warehouse location");                
            }
            if (objLocation.Qty_on_hand.IsNull)
            {
                objLocation.Qty_on_hand = 0 - qty;
            }
            else
            {
                objLocation.Qty_on_hand = objLocation.Qty_on_hand - qty;
            }
            if (objLocation.Qty_allocated.IsNull)
            {
                objLocation.Qty_allocated = qty;
            }
            else
            {
                objLocation.Qty_allocated = objLocation.Qty_allocated + qty;
            }
            objLocation.Update(DBCommand);
        }

        /// <summary>
        /// Use when only the onhand quantity needed to be changed
        /// InventoryAdjustment, StockTransfers
        /// </summary>
        /// <param name="strProduct"></param>
        /// <param name="qty"></param>
        public void DeductOnHand(String strProduct, Int32 qty)
        {
            if (qty == 0)
            {
                return;
            }
            Location_Master objLocation = new Location_Master();
            LocationDao objDao = new LocationDao();
            objDao.SelectOneByWarehouseLocationProduct(DBCommand, objLocation, strLocation, strWarehouse, strProduct);
            //If warehouse of objLocation is null or empty -> No row exists
            //That means there are errors with the input, Stop the process
            if ((objLocation.Warehouse_id.IsNull) || (String.IsNullOrEmpty((string)objLocation.Warehouse_id)))
            {
                //If qty < 0, that means qty is being added to Location
                //In this case, create new record in Location_Master
                if (qty < 0)
                {
                    objDao.Warehouse_id = strWarehouse;
                    objDao.Product_id = strProduct;
                    objDao.Bin_location_id = strLocation;
                    objDao.Qty_on_hand = 0 - qty;
                    objDao.InsertWithNewSequence(DBCommand);
                    return;
                }
                //Id qty > 0, throw exception because a qty could not be updated to be negative
                else
                {
                    throw new NotFoundException("Product is not existed in warehouse location");
                }
            }
            if (objLocation.Qty_on_hand.IsNull)
            {
                objLocation.Qty_on_hand = 0 - qty;
            }
            else
            {
                objLocation.Qty_on_hand = objLocation.Qty_on_hand - qty;
            }            
            objLocation.Update(DBCommand);
        }
    }
}
