using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Inventory.DataObjects;
using Inventory.DataObjects.DAO;

namespace Inventory.DataModels.Warehouse
{
    public class PackingListModel
    {

        #region Private data memeber for storing information of Packing List
        /// <summary>
        /// Picking Name
        /// </summary>
        private string strPackingName = string.Empty;

        /// <summary>
        /// Date Created
        /// </summary>
        private DateTime datDateCreated = DateTime.Now;

        /// <summary>
        /// Private data memeber for storing information of Packing Details
        /// </summary>
        private DataTable dtPackingDetails = new DataTable();

        private String strPackingListId;

        /// <summary>
        /// Notes of Picking List
        /// </summary>
        private string strNotes = string.Empty;

        /// <summary>
        /// Determining if Picking List is showed
        /// </summary>
        private bool blnViewStatus = true;

        #endregion

        #region Packing Property

        /// <summary>
        /// Set or Get value for Packing Name
        /// </summary>
        public string PackingName
        {
            set { strPackingName = value; }
            get { return strPackingName; }
        }

        /// <summary>
        /// Set or Get value for Packing Name
        /// </summary>
        public string PackingListId
        {
            set { strPackingListId = value; }
            get { return strPackingListId; }
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
        public DataTable PackingDetails
        {
            set { dtPackingDetails = value; }
            get { return dtPackingDetails; }
        }

        /// <summary>
        /// Set or Get value for Notes
        /// </summary>
        public string Notes
        {
            set { strNotes = value; }
            get { return strNotes; }
        }

        /// <summary>
        /// Set or Get value for Notes
        /// </summary>
        public bool ViewStatus
        {
            set { blnViewStatus = value; }
            get { return blnViewStatus; }
        }

        #endregion

        internal void LoadDataFromDataBase()
        {

            PackingListMaster objMaster = Mediator.GetInstance().GetPackingListMaster(this.PackingListId);
            this.PackingDetails = Mediator.GetInstance().GetPackingListDetails(this.PackingListId);
            this.PackingName = objMaster.PackingListName.ToString();
            this.DateCreated = (DateTime)objMaster.DateCreated;
            this.PackingListId = objMaster.PackingListID.ToString();

            this.Notes = objMaster.Notes.ToString();
            this.ViewStatus = (bool)objMaster.ViewStatus;
        }
    }
}
