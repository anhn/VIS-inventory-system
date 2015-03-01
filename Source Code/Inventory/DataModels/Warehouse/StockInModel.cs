using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Inventory.DataObjects;
using Inventory.DataObjects.DAO;

namespace Inventory.DataModels.Warehouse
{
    public class StockInModel
    {

        #region Private data memeber for storing information of StockIn List
        /// <summary>
        /// StockIn Id;
        /// </summary>
        private String strId;

        /// <summary>
        /// StockIn Name;
        /// </summary>
        private String strName;

        private String strLocation;
        private String strWarehouse;

        /// <summary>
        /// Description
        /// </summary>
        private String strDesc;

        /// <summary>
        /// Date Created
        /// </summary>
        private DateTime datDateCreated = DateTime.Now;

        /// <summary>
        /// Storing information of StockIn Details
        /// </summary>
        private DataTable dtDetails = new DataTable();

        #endregion

        #region StockIn Property
        /// <summary>
        /// Set or Get value for StockIn Name
        /// </summary>
        public string Name
        {
            set { strName = value; }
            get { return strName; }
        }

        public String Location
        {
            set { strLocation = value; }
            get { return strLocation; }
        }

        public string Desc
        {
            set { strDesc = value; }
            get { return strDesc; }
        }

        /// <summary>
        /// Set or Get value for StockTransfer Id
        /// </summary>
        public string Id
        {
            set { strId = value; }
            get { return strId; }
        }

        public String Warehouse
        {
            set { strWarehouse = value; }
            get { return strWarehouse; }
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
        /// Set ,Get value for StockTransfer Detail
        ///</summary>
        public DataTable Details
        {
            set { dtDetails = value; }
            get { return dtDetails; }
        }

        #endregion

        #region Methods
        public void LoadDataFromDataBase()
        {
            
            StockInMaster objMaster = Mediator.GetInstance().GetStockInMaster(this.Id);
            this.Details = Mediator.GetInstance().GetStockInDetails(this.Id);
            this.Name = (objMaster.Name.IsNull) ? string.Empty:(string)objMaster.Name;
            this.Desc = (objMaster.Description.IsNull) ? string.Empty : (string)objMaster.Description;
            this.Location = (objMaster.Location.IsNull) ? string.Empty : (string)objMaster.Location;
            this.Warehouse = Mediator.GetInstance().GetWarehouseForLocation(this.Location);
            this.DateCreated = (objMaster.DateCreated.IsNull) ? DateTime.Now :(DateTime)objMaster.DateCreated;
            this.Id = objMaster.ID.ToString();            
        }
        #endregion
    }
}
