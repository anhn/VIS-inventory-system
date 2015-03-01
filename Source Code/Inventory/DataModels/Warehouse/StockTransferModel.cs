using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Inventory.DataObjects;
using Inventory.DataObjects.DAO;

namespace Inventory.DataModels.Warehouse
{
    public class StockTransferModel
    {

        #region Private data memeber for storing information of StockTransfer List
        /// <summary>
        /// StockTransfer Id;
        /// </summary>
        private String strStockTransferId;

        /// <summary>
        /// StockTransfer Name;
        /// </summary>
        private String strStockTransferName;

        /// <summary>
        /// Date Created
        /// </summary>
        private DateTime datDateCreated = DateTime.Now;

        /// <summary>
        /// Storing information of StockTransfer Details
        /// </summary>
        private DataTable dtStockTransferDetails = new DataTable();

        #endregion

        #region StockTransfer Property
        /// <summary>
        /// Set or Get value for StockTransfer Name
        /// </summary>
        public string StockTransferName
        {
            set { strStockTransferName = value; }
            get { return strStockTransferName; }
        }

        /// <summary>
        /// Set or Get value for StockTransfer Id
        /// </summary>
        public string StockTransferId
        {
            set { strStockTransferId = value; }
            get { return strStockTransferId; }
        }

        /// <summary>
        /// Set or Get value for Date Created
        /// </summary>
        public DateTime DateCreated
        {
            set { datDateCreated = value;}
            get { return datDateCreated; }
        }

        ///<summary>
        /// Set ,Get value for StockTransfer Detail
        ///</summary>
        public DataTable StockTransferDetails
        {
            set { dtStockTransferDetails = value; }
            get { return dtStockTransferDetails; }
        }
        
        #endregion

        #region Methods
        public void LoadDataFromDataBase()
        {

            StockTransferMaster objMaster = Mediator.GetInstance().GetStockTransferMaster(this.StockTransferId);
            this.StockTransferDetails = Mediator.GetInstance().GetStockTransferDetails(this.StockTransferId);
            this.StockTransferName = (string)objMaster.Name;
            this.DateCreated = (DateTime)objMaster.DateCreated;
            this.StockTransferId = objMaster.ID.ToString();
        } 
        #endregion
    }
}
