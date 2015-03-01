using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Inventory.DataObjects;
using Inventory.DataObjects.DAO;

namespace Inventory.DataModels.Warehouse
{
    public class StockOutModel
    {

        #region Private data memeber for storing information of StockOut List
        /// <summary>
        /// StockOut Id;
        /// </summary>
        private String strId;

        /// <summary>
        /// StockOut Name;
        /// </summary>
        private String strName;

        /// <summary>
        /// Description
        /// </summary>
        private String strDesc;

        private String strLocation;

        private String strWarehouse;

        /// <summary>
        /// Date Created
        /// </summary>
        private DateTime datDateCreated = DateTime.Now;

        /// <summary>
        /// Storing information of StockIn Details
        /// </summary>
        private DataTable dtDetails = new DataTable();

        #endregion

        #region StockOut Property
        /// <summary>
        /// Set or Get value for StockOut Name
        /// </summary>
        public string Name
        {
            set { strName = value; }
            get { return strName; }
        }

        public string Desc
        {
            set { strDesc = value; }
            get { return strDesc; }
        }

        /// <summary>
        /// Set or Get value for StockOut Id
        /// </summary>
        public string Id
        {
            set { strId = value; }
            get { return strId; }
        }

        /// <summary>
        /// Set or Get value for Date Created
        /// </summary>
        public DateTime DateCreated
        {
            set { datDateCreated = value; }
            get { return datDateCreated; }
        }

        ///<summary>
        /// Set ,Get value for StockOut Detail
        ///</summary>
        public DataTable Details
        {
            set { dtDetails = value; }
            get { return dtDetails; }
        }

        public String Location
        {
            set { strLocation = value; }
            get { return strLocation; }
        }

        public String Warehouse
        {
            set { strWarehouse = value; }
            get { return strWarehouse; }
        }

        #endregion

        #region Methods

        public void LoadDataFromDataBase()
        {

            StockOutMaster objMaster = Mediator.GetInstance().GetStockOutMaster(this.Id);
            this.Details = Mediator.GetInstance().GetStockOutDetails(this.Id);
            this.Name = (string)objMaster.Name;
            this.DateCreated = (DateTime)objMaster.DateCreated;
            this.Id = objMaster.ID.ToString();
            this.Location = (string)objMaster.Location;
            this.Warehouse = Mediator.GetInstance().GetWarehouseForLocation(this.Location);
            this.Desc = (string)objMaster.Description;
        }
        #endregion
    }
}
