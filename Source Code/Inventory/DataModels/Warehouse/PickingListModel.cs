using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Inventory.DataObjects;

namespace Inventory.DataModels.Warehouse
{
    public class PickingListModel
    {
        #region Private data memeber for storing information of Picking List
        /// <summary>
        /// Private data memeber for storing information of Picking List ID
        /// </summary>
        private string strPickingListID = string.Empty;

        /// <summary>
        /// Picking Name
        /// </summary>
        private string strPickingName = string.Empty;


        /// <summary>
        /// Date Created
        /// </summary>
        private DateTime datDateCreated = DateTime.MinValue;

        /// <summary>
        /// Reference No
        /// </summary>
        private string strReferenceNo = string.Empty;

        /// <summary>
        /// Destination Location
        /// </summary>
        private string strDestLocation = string.Empty;

        /// <summary>
        /// Other Location
        /// </summary>
        private string strOtherLocation = string.Empty;

        /// <summary>
        /// Destination Department
        /// </summary>
        private string strDestDepart = string.Empty;

        /// <summary>
        /// Notes of Picking List
        /// </summary>
        private string strNotes = string.Empty;

        /// <summary>
        /// Determining if Picking List is showed
        /// </summary>
        private bool blnViewStatus = true;

        /// <summary>
        /// Private data memeber for storing information of Picking Details
        /// </summary>
        private DataTable dtPickingDetails = new DataTable();
        #endregion

        #region Properties
        /// <summary>
        /// Set or Get value for Picking List ID
        /// </summary>
        public string PickingListID
        {
            set { strPickingListID = value; }
            get { return strPickingListID; }
        }

        /// <summary>
        /// Set or Get value for Picking Name
        /// </summary>
        public string PickingName
        {
            set { strPickingName = value; }
            get { return strPickingName; }
        }

        /// <summary>
        /// Set or Get value for Date Created
        /// </summary>
        public DateTime DateCreated
        {
            set { datDateCreated = value; }
            get { return datDateCreated; }
        }

        /// <summary>
        /// Set or Get value for Reference No
        /// </summary>
        public string ReferenceNo
        {
            set { strReferenceNo = value; }
            get { return strReferenceNo; }
        }

        /// <summary>
        /// Set or Get value for Dest. Location
        /// </summary>
        public string DestLocation
        {
            set { strDestLocation = value; }
            get { return strDestLocation; }
        }

        /// <summary>
        /// Set or Get value for Othe rLocation
        /// </summary>
        public string OtherLocation
        {
            set { strOtherLocation = value; }
            get { return strOtherLocation; }
        }

        /// <summary>
        /// Set or Get value for Dest. Department
        /// </summary>
        public string DestDepart
        {
            set { strDestDepart = value; }
            get { return strDestDepart; }
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

        /// <summary>
        /// Set or Get value for PickingDetails
        /// </summary>
        public DataTable PickingDetails
        {
            set { dtPickingDetails = value; }
            get { return dtPickingDetails; }
        }
        #endregion


        internal void LoadDataFromDataBase()
        {
            PickingListMaster objMaster = Mediator.GetInstance().GetPickingListMaster(this.PickingListID);
            this.PickingDetails = Mediator.GetInstance().GetPickingListDetails(this.PickingListID);

            this.PickingName = objMaster.PickingName.ToString();
            this.DateCreated = (DateTime)objMaster.DateCreated;
            this.PickingListID = objMaster.PickingListID.ToString();

            this.ReferenceNo = objMaster.ReferenceNo.ToString();
            this.OtherLocation = objMaster.OtherDestLocation.ToString();
            this.Notes = objMaster.Notes.ToString();

            
            this.DestDepart = objMaster.DestDepartment.ToString();
            this.DestLocation = objMaster.DestLocation.ToString();
            this.ViewStatus = (bool)objMaster.ViewStatus;
            
        }
    }
}
