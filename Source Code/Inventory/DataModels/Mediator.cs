using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Inventory.DataObjects.DAO;
using Inventory.DataObjects;


namespace Inventory.DataModels
{
    public class Mediator
    {
        private static Mediator instance;

        public static Mediator GetInstance()
        {
            if (instance == null)
            {
                instance = new Mediator();
            }
            return instance;
        }

        public String ConvertToString(System.Data.SqlTypes.SqlString obj)
        {
            if (obj == null || obj.IsNull)
            {
                return String.Empty;
            }
            else
            {
                return obj.ToString();
            }
        }

        public DataTable GetAllDeliveryNoteMaster()
        {
            DeliveryNoteDao dao = new DeliveryNoteDao();
            return dao.SelectAllDeliveryNoteMaster();
        }

        public DataTable GetAllPickingListMaster()
        {
            PickingListMaster objPickMaster = new PickingListMaster();
            return objPickMaster.SelectAll();
        }

        public DataTable GetAllPackingListMaster()
        {
            PackingListDao objDao = new PackingListDao();
            return objDao.GetAllPackingList();
        }

        //public DataTable SelectPickingListDetailsBy(string strPickingListID)
        //{
        //    PickingListDAO dao = new PickingListDAO();
        //    return dao.GetPickingListDetailsBy(strPickingListID);
        //}


        internal DataTable GetAllCustomerName()
        {
            CustomerDao dao = new CustomerDao();
            return dao.SelectAllCustomerName();
        }




        internal DataTable GetAllWarehouse()
        {
            WarehouseDao dao = new WarehouseDao();
            return dao.SelectAllWareHouse();
        }


        internal DataTable GetLocationsOfWareHouse(string strWareHouseId)
        {
            LocationDao dao = new LocationDao();
            return dao.SelectLocationsOfWareHouse(strWareHouseId);
        }

        internal DataTable GetEmptyListPackingDetail()
        {
            PackingListDao objDao = new PackingListDao();
            return objDao.GetEmptyListPackingDetail();
        }

        internal DataTable GetEmptyDeliveryNoteDetail()
        {
            DeliveryNoteDao objDao = new DeliveryNoteDao();
            return objDao.GetEmptyDeliveryNoteDetail();
        }

        internal DataTable GetAllLocations()
        {
            LocationDao dao = new LocationDao();
            return dao.GetAllLocations();
        }

        /// <summary>
        /// Get records from Location_master for selection in drow down list
        /// </summary>
        /// <returns></returns>
        internal DataTable GetAllLocationProducts()
        {
            LocationDao dao = new LocationDao();
            return dao.GetAllLocationProduct();
        }

        internal DataTable GetAllProductNames()
        {
            ProductDao dao = new ProductDao();
            return dao.GetAllProductNames();
        }

        internal DataTable GetAllPackage()
        {
            PackingListDao dao = new PackingListDao();
            return dao.GetAllPackageTypes();
        }


        internal DataTable GetPackingListDetails(string strPackingListId)
        {
            PackingListDao dao = new PackingListDao();
            return dao.GetPackingListDetail(strPackingListId);

        }

        internal PackingListMaster GetPackingListMaster(string strPackingListId)
        {
            PackingListMaster objMaster = new PackingListMaster();
            objMaster.PackingListID = strPackingListId;
            objMaster.SelectOne();
            return objMaster;
        }


        public DataTable GetAllProducts()
        {
            ProductDao dao = new ProductDao();
            return dao.GetAllProductNames();
        }

        public PickingListMaster GetPickingListMaster(string strPickingListId)
        {
            PickingListMaster objMaster = new PickingListMaster();
            objMaster.PickingListID = strPickingListId;
            objMaster.SelectOne();
            return objMaster;
        }

        public DataTable GetPickingListDetails(string strPickingListId)
        {
            PickingListDAO dao = new PickingListDAO();
            return dao.GetPickingListDetails(strPickingListId);

        }


        internal DeliveryNotesMaster GetDeliveryNoteMaster(string strDeliveryNoteId)
        {
            DeliveryNotesMaster objMaster = new DeliveryNotesMaster();
            objMaster.ID = strDeliveryNoteId;
            objMaster.SelectOne();
            return objMaster;
        }

        internal DataTable GetDeliveryNoteDetails(string strDeliveryNoteID)
        {
            DeliveryNoteDao objDao = new DeliveryNoteDao();

            return objDao.GetDeliveryNoteDetails(strDeliveryNoteID);
        }

        internal DataTable GetAllDeliveryMethod()
        {
            DeliveryMethod objMethod = new DeliveryMethod();
            return objMethod.SelectAll();
        }
        
        internal decimal GetOnHandQty(string strWarehouse, string strLocation, string strProduct)
        {
            LocationDao dao = new LocationDao();
            return dao.GetOnHandQty(strWarehouse, strLocation, strProduct);
        }

        internal DataTable GetEmptyListPickingDetail()
        {
            PickingListDAO dao = new PickingListDAO();
            return dao.GetEmptyListPickingDetail();
        }

        #region Stock Transfer
        /// <summary>
        /// Get a StockTransfer Master based on id
        /// </summary>
        /// <param name="strId"></param>
        /// <returns></returns>
        public StockTransferMaster GetStockTransferMaster(string strId)
        {
            StockTransferMaster objMaster = new StockTransferMaster();
            objMaster.ID = strId;
            objMaster.SelectOne();
            return objMaster;
        }

        /// <summary>
        /// Get Empty StockTransfer Details
        /// </summary>
        /// <returns></returns>
        public DataTable GetEmptyStockTransferDetails()
        {
            StockTransferDao dao = new StockTransferDao();
            return dao.GetEmptyListStockTransferDetail();
        }

        /// <summary>
        /// Get StockTransfer Details
        /// </summary>
        /// <param name="strId"></param>
        /// <returns></returns>
        public DataTable GetStockTransferDetails(string strId)
        {
            StockTransferDao dao = new StockTransferDao();
            return dao.GetStockTransferListDetail(strId);
        }

        /// <summary>
        /// Get StockTransfer Master list
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllStockTransferMasters()
        {
            StockTransferMaster objMaster = new StockTransferMaster();
            return objMaster.SelectAll(); 
        }
        #endregion

        internal DataTable GetAllInventoryAdjustment()
        {
            InventoryAdjustmentMaster objAdjust = new InventoryAdjustmentMaster();
            return objAdjust.SelectAll();
        }

        internal InventoryAdjustmentMaster GetInventoryAdjustmentMaster(string id)
        {
            InventoryAdjustmentMaster objAdjust = new InventoryAdjustmentMaster();
            objAdjust.ID = id;
            objAdjust.SelectOne();
            return objAdjust;
        }

        internal DataTable GetInventoryAdjustmentDetails(string ajustId)
        {
            InventoryAdjustmentDao objDao = new InventoryAdjustmentDao();
            return objDao.GetInventoryAdjustmentListDetail(ajustId);
        }

        internal DataTable GetEmptyInventoryAdjustmentDetails()
        {
            InventoryAdjustmentDao objDao = new InventoryAdjustmentDao();
            return objDao.GetEmptyListInventoryAdjustmentDetail();
        }

        internal string GetConfigValue(string strConfigName)
        {
            Configs objConfigs = new Configs();
            objConfigs.Name = strConfigName;
            objConfigs.SelectOne();

            if (objConfigs.Value.IsNull)
            {
                return "";
            }

            return (string)objConfigs.Value;
        }

        internal void UpdateConfigValue(System.Data.SqlClient.SqlCommand objCmd, string strConfigName, string strConfigValue)
        {
            Configs objConfigs = new Configs();
            objConfigs.Name = strConfigName;
            DataTable dtConfig = objConfigs.SelectOne();

            objConfigs.Value = strConfigValue;
            if (dtConfig.Rows.Count > 0) // config record has existed
            {
                objConfigs.Update(objCmd);
            }
            else // config record not exist, create new
            {
                objConfigs.Insert(objCmd);
            }
        }

        internal Inventory.DataObjects.ProductMaster GetProductMaster(string id)
        {
            Inventory.DataObjects.ProductMaster objProductMaster = new Inventory.DataObjects.ProductMaster();
            objProductMaster.ProductID = id;
            objProductMaster.SelectOne();
            return objProductMaster;
        }

        internal DataTable GetAllProductMaster()
        {
            ProductDao objDao = new ProductDao();
            return objDao.GetAllProductMaster();
        }

        internal DataTable GetAllProductFamily()
        {
            ProductFamily objFamily = new ProductFamily();
            return objFamily.SelectAll();
        }

        internal DataTable GetAllTrueViewStatusProductFamily()
        {
            ProductFamily objFamily = new ProductFamily();
            return objFamily.SelectAllTrueViewStatus();
        }

        internal DataTable GetAllProductCategory()
        {
            ProductCategoryDao objDao = new ProductCategoryDao();
            return objDao.GetAllProductCategory();
        }

        internal DataTable GetAllTrueViewStatusProductCategory()
        {
            ProductCategoryDao objDao = new ProductCategoryDao();
            return objDao.GetAllProductCategoryTrueViewStatus();
        }

        internal DataTable GetAllProductBarcode()
        {
            BarcodeMaster objBarcode = new BarcodeMaster();
            return objBarcode.SelectAll();
        }

        internal DataTable GetAllTrueViewStatusProductBarcode()
        {
            BarcodeMaster objBarcode = new BarcodeMaster();
            return objBarcode.SelectAllTrueViewStatus();
        }

        internal DataTable GetAllProductUnitMeasure()
        {
            UOM objUOM = new UOM();
            return objUOM.SelectAll();
        }

        internal DataTable GetAllTrueViewStatusProductUnitMeasure()
        {
            UOM objUOM = new UOM();
            return objUOM.SelectAllTrueViewStatus();
        }

        internal Inventory.DataObjects.BarcodeMaster GetBarcodeMaster(string id)
        {
            Inventory.DataObjects.BarcodeMaster objBarcodeMaster = new Inventory.DataObjects.BarcodeMaster();
            objBarcodeMaster.ID = id;
            objBarcodeMaster.SelectOne();
            return objBarcodeMaster;
        }

        internal DataTable GetAllBarcodeMaster()
        {
            BarcodeMaster objMaster = new BarcodeMaster();
            return objMaster.SelectAll(); 
        }

        internal DataTable GetStockInDetails(string strId)
        {
            StockInDetailsDao dao = new StockInDetailsDao();
            return dao.GetStockInDetails(strId);
        }

        internal StockInMaster GetStockInMaster(string strId)
        {
            StockInMaster objMaster = new StockInMaster();
            objMaster.ID = strId;
            objMaster.SelectOne();
            return objMaster;
        }

        internal StockOutMaster GetStockOutMaster(string strId)
        {
            StockOutMaster objMaster = new StockOutMaster();
            objMaster.ID = strId;
            objMaster.SelectOne();
            return objMaster;
        }

        internal DataTable GetStockOutDetails(string strId)
        {
            StockOutDetailsDao dao = new StockOutDetailsDao();
            return dao.GetStockOutDetails(strId);
        }

        internal ProductFamily GetProductFamily(string strID)
        {
            ProductFamily objFamily = new ProductFamily();
            objFamily.FamilyID = strID;
            objFamily.SelectOne();
            return objFamily;
        }

        internal ProductCategory GetProductCategory(string strID)
        {
            ProductCategory objCat = new ProductCategory();
            objCat.CategoryID = strID;
            objCat.SelectOne();
            return objCat;
        }

        internal DataTable GetEmptyStockInDetails()
        {
            StockInDetailsDao dao = new StockInDetailsDao();
            return dao.GetEmptyListStockInDetail();
        }

        internal DataTable GetEmptyStockOutDetails()
        {
            StockOutDetailsDao dao = new StockOutDetailsDao();
            return dao.GetEmptyListStockOutDetail();
        }

        internal object GetAllStockOutMasters()
        {
            StockOutMaster objMaster = new StockOutMaster();
            return objMaster.SelectAll(); 
        }

        internal string GetWarehouseForLocation(string strLocationId)
        {
            LocationDao dao = new LocationDao();
            return dao.SelectWarehouseByLocation(strLocationId);
        }

        internal object GetAllStockInMasters()
        {
            StockInMaster objMaster = new StockInMaster();
            return objMaster.SelectAll(); 
        }

        internal BoMMaster GetBillOfMaterialMaster(string strID)
        {
            BoMMaster objMaster = new BoMMaster();
            objMaster.ID = strID;
            objMaster.SelectOne();
            return objMaster;
        }

        public DataTable GetAllBOMMaster()
        {
            BoMMasterDao objDao = new BoMMasterDao();
            return objDao.GetAllBoMMaster();
        }

        internal DataTable GetBillOfMaterialDetails(string strBoMID)
        {
            BoMDetailsDao objDao = new BoMDetailsDao();
            return objDao.SelectBoMDetails(strBoMID);
        }

        internal DataTable GetEmptyListBOMDetail()
        {
            return GetBillOfMaterialDetails(String.Empty);
        }

        internal InventoryUpdateMaster GetInventoryUpdate(string strID)
        {
            InventoryUpdateMaster objInvent = new InventoryUpdateMaster();
            objInvent.ID = strID;
            objInvent.SelectOne();
            return objInvent;
        }

        internal DateTime ConvertToDateTime(System.Data.SqlTypes.SqlDateTime sqlDateTime)
        {
            return (DateTime)sqlDateTime;
        }

        internal DataTable GetAllInventoryUpdate()
        {
            InventoryUpdateMaster objMaster = new InventoryUpdateMaster();
            return objMaster.SelectAll();
        }

        internal DataTable GetInventoryUpdateDetails(string strMasterID)
        {
            InventoryUpdateDao objDao = new InventoryUpdateDao();
            return objDao.GetInventoryUpdateListDetail(strMasterID);
        }

        internal DataTable GetEmptyInventoryUpdateDetails()
        {
            InventoryUpdateDao objDao = new InventoryUpdateDao();
            return objDao.GetEmptyListInventoryUpdateDetail();
        }

        internal DataTable GetAllPhysicalTake()
        {
            PhysicalTakeMaster objMaster = new PhysicalTakeMaster();
            return objMaster.SelectAll();
        }

        internal PhysicalTakeMaster GetPhysicalTake(string strID)
        {
            PhysicalTakeMaster objMaster = new PhysicalTakeMaster();
            objMaster.ID = strID;
            objMaster.SelectOne();
            return objMaster;
        }

        internal DataTable GetPhysicalTakeDetails(string strMasterID)
        {
            PhysicalTakeDao objDao = new PhysicalTakeDao();
            return objDao.GetPhysicalTakeListDetail(strMasterID);
        }

        internal DataTable GetEmptyPhysicalTakeDetails()
        {
            PhysicalTakeDao objDao = new PhysicalTakeDao();
            return objDao.GetEmptyListPhysicalTakeDetail();
        }

        internal WorkOrder GetWorkOrder(double dblNumber)
        {
            WorkOrder objWorkOrder = new WorkOrder();
            objWorkOrder.Number = (decimal)dblNumber;
            objWorkOrder.SelectOne();
            return objWorkOrder;
        }

        public DataTable GetAllWorkOrder()
        {
            WorkOrder objWorkOrder = new WorkOrder();
            return objWorkOrder.SelectAll();
        }

        internal DataTable GetAllWorkOrderStatus()
        {
            WorkOrderStatus objStatus = new WorkOrderStatus();
            return objStatus.SelectAll();
        }

        internal DataTable GetAllUser()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        internal DataTable GetAllSupplier()
        {
            SupplierContact objSupplier = new SupplierContact();
            return objSupplier.SelectAll();
        }

        internal DataTable GetEmptyTableForFilter(string tableName)
        {
            ExportDao filterDao = new ExportDao();
            return filterDao.GetEmptyTableForFilter(tableName);
        }

        internal DataTable GetTableForFilter(string selectSql)
        {
            ExportDao filterDao = new ExportDao();
            return filterDao.GetTableForFilter(selectSql);
        }

        internal object GetAllPaymentMethod()
        {
            PaymentMethod objDao = new PaymentMethod();
            return objDao.SelectAll();
        }

        internal DataTable GetAllPeriodType()
        {
            PeriodType objType = new PeriodType();
            return objType.SelectAll();
        }

        internal DataTable FindProducts(string locationId, string productID, string productName)
        {
            ProductDao objDao = new ProductDao();
            return objDao.FindProducts(locationId, productID, productName);
        }
    }
}
