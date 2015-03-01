using System;
using System.Collections.Generic;
using System.Text;
using Inventory.DataObjects;

namespace Inventory.DataModels.Barcode
{
    public class BarcodeModel
    {
        #region Private data memeber for storing information of barcode
        /// <summary>
        /// Barcode Id
        /// </summary>
        private String strId;

        /// <summary>
        /// Size
        /// </summary>
        private int intSize = int.MinValue;

        /// <summary>
        /// Barcode Name
        /// </summary>
        private String strLabel;

        /// <summary>
        /// Barcode Description
        /// </summary>
        private String strDesc;

        /// <summary>
        /// Barcode information
        /// </summary>
        private byte[] arrBarcodeInfo;

        /// <summary>
        /// Date Created
        /// </summary>
        private DateTime datDateCreated = DateTime.Now;

        /// <summary>
        /// view status
        /// </summary>
        private bool blnViewStatus = true;

        /// <summary>
        /// view id
        /// </summary>
        private bool blnViewID = true;

        /// <summary>
        /// view label
        /// </summary>
        private bool blnViewLabel = true;

        /// <summary>
        /// is ShowBarcodeID
        /// </summary>
        private bool blnShowBarcodeID = true;
        #endregion

        #region Barcode Property
        /// <summary>
        /// Set or Get value for Label
        /// </summary>
        public string Label
        {
            set { this.strLabel = value; }
            get { return strLabel; }
        }

        /// <summary>
        /// Set or Get value for Description
        /// </summary>
        public string Description
        {
            set { this.strDesc = value; }
            get { return strDesc; }
        }

        /// <summary>
        /// Set or Get value for BarcodeId
        /// </summary>
        public string BarcodeId
        {
            set { strId = value; }
            get { return strId; }
        }

        /// <summary>
        /// Set or Get value for Size
        /// </summary>
        public int Size
        {
            set { intSize = value; }
            get { return intSize; }
        }

        /// <summary>
        /// Set or Get value for Date Created
        /// </summary>
        public DateTime CreationDate
        {
            set { datDateCreated = value; }
            get { return datDateCreated; }
        }

        ///<summary>
        /// Set ,Get value for Barcode info
        ///</summary>
        public byte[] BarcodeInfo
        {
            set { this.arrBarcodeInfo = value; }
            get { return arrBarcodeInfo; }
        }

        /// <summary>
        /// Set or Get value for View status
        /// </summary>
        public bool ViewStatus
        {
            set { this.blnViewStatus = value; }
            get { return blnViewStatus; }
        }

        /// <summary>
        /// Set or Get value for View status
        /// </summary>
        public bool ViewBarcodeID
        {
            set { this.blnViewID = value; }
            get { return blnViewID; }
        }

        /// <summary>
        /// Set or Get value for View status
        /// </summary>
        public bool ViewBarcodeLabel
        {
            set { this.blnViewLabel = value; }
            get { return blnViewLabel; }
        }

        internal BarcodeMaster GetMasterRecord()
        {
            BarcodeMaster objBarcodeDao = new BarcodeMaster();
            objBarcodeDao.ID = this.BarcodeId;
            objBarcodeDao.Label = this.Label;
            objBarcodeDao.Description = this.Description;
            objBarcodeDao.Size = this.Size;
            objBarcodeDao.CreationDate = this.CreationDate;
            objBarcodeDao.ViewLabel = this.ViewBarcodeLabel;
            objBarcodeDao.ViewID = this.ViewBarcodeID;
            objBarcodeDao.ViewState = this.ViewStatus;

            return objBarcodeDao;
        }
        #endregion

        /// <summary>
        /// Load Data From DataBase to bind data to GUI
        /// </summary>
        internal void LoadDataFromDataBase()
        {
            BarcodeMaster objMaster = Mediator.GetInstance().GetBarcodeMaster(this.BarcodeId);
            
            this.BarcodeId = (string)objMaster.ID;
            this.Label = (string)objMaster.Label;
            this.CreationDate = (DateTime)objMaster.CreationDate;
            this.Size = (int)objMaster.Size;
            this.Description = (string)objMaster.Description;
            this.ViewBarcodeID = (bool)objMaster.ViewID;
            this.ViewBarcodeLabel = (bool)objMaster.ViewLabel;
            this.ViewStatus = (bool)objMaster.ViewState;
        }
    }
}
