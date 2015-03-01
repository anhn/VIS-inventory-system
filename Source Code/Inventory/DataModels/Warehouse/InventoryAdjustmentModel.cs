using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Inventory.DataObjects;
using Inventory.DataObjects.DAO;

namespace Inventory.DataModels.Warehouse
{
    public class InventoryAdjustmentModel
    {
        #region Attributes

        /// <summary>
        /// Picking Name
        /// </summary>
        private string strAdjustName = string.Empty;

        /// <summary>
        /// Date Created
        /// </summary>
        private DateTime datDateCreated = DateTime.Now;

        /// <summary>
        /// Private data memeber for storing information of Packing Details
        /// </summary>
        private DataTable dtAdjustDetails = new DataTable();

        private String strAdjustId;

        private String strReason;

        private bool bViewStatus=true;

        #endregion

        #region Packing Property

        /// <summary>
        /// Set or Get value for Packing Name
        /// </summary>
        public string AdjustName
        {
            set { strAdjustName = value; }
            get { return strAdjustName; }
        }

        public string Notes
        {
            set { strReason = value; }
            get { return strReason; }
        }

        public bool ViewStatus
        {
            get { return bViewStatus; }
            set { bViewStatus = value; }
        }

        /// <summary>
        /// Set or Get value for Packing Name
        /// </summary>
        public string AdjustId
        {
            set { strAdjustId = value; }
            get { return strAdjustId; }
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
        /// Set ,Get value for Packing Detail
        ///</summary>
        public DataTable AdjustDetails
        {
            set { dtAdjustDetails = value; }
            get { return dtAdjustDetails; }
        }
        
        #endregion

        internal void LoadDataFromDataBase()
        {
            InventoryAdjustmentMaster objMaster = Mediator.GetInstance().GetInventoryAdjustmentMaster(this.AdjustId);
            this.AdjustDetails = Mediator.GetInstance().GetInventoryAdjustmentDetails(this.AdjustId);
            this.AdjustName = objMaster.Name.ToString();
            this.DateCreated = (DateTime)objMaster.DateCreated;
            this.AdjustId = objMaster.ID.ToString();
            this.ViewStatus = (objMaster.ViewStatus.IsNull) ? false : (bool)(objMaster.ViewStatus);
            this.Notes = (objMaster.Notes.IsNull) ? string.Empty : Convert.ToString(objMaster.Notes);          
        }

    }
}
