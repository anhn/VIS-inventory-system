using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Inventory.DataObjects;
using Inventory.DataObjects.DAO;

namespace Inventory.DataModels.StockTake
{
    public class PhysicalTakeModel
    {
        #region Attributes

        private string strId = string.Empty;

        private string strName = string.Empty;

        private DateTime datDateCreated = DateTime.Now;

        private string strWarehouseId = string.Empty;

        private string strLocationId = string.Empty;

        private string strProductName = string.Empty;

        private DataTable dtDetails;

        private string strNote = string.Empty;

        private bool blnViewStatus;

        #endregion

        #region Properties

        public string ID
        {
            get { return strId; }
            set { strId = value; }
        }

        public string Name
        {
            get { return strName; }
            set { strName = value; }
        }

        public DateTime DateCreated
        {
            set { datDateCreated = value; }
            get { return datDateCreated; }
        }

        public DataTable Details
        {
            get { return dtDetails; }
            set { dtDetails = value; }
        }

        public string Note
        {
            get { return strNote; }
            set { strNote = value; }
        }

        public bool ViewStatus
        {
            get { return blnViewStatus; }
            set { blnViewStatus = value; }
        }

        #endregion

        internal void LoadDataFromDataBase()
        {
            PhysicalTakeMaster objMaster = Mediator.GetInstance().GetPhysicalTake(this.ID);
            this.ID = objMaster.ID.ToString();
            this.Name = objMaster.Name.ToString();
            this.Note = objMaster.Description.ToString();
            this.DateCreated = (objMaster.DateCreated.IsNull) ? DateTime.MinValue : objMaster.DateCreated.Value;
            this.Details = Mediator.GetInstance().GetPhysicalTakeDetails(this.ID);
            this.ViewStatus = (objMaster.ViewStatus.IsNull) ? false : (bool)(objMaster.ViewStatus);
        }


        internal PhysicalTakeMaster GetMasterRecord()
        {
            PhysicalTakeMaster objMaster = new PhysicalTakeMaster();
            objMaster.ID = this.ID;
            objMaster.Name = this.Name;
            objMaster.Description = this.Note;
            objMaster.DateCreated = this.DateCreated;
            objMaster.ViewStatus = this.ViewStatus;

            return objMaster;
        }
    }
}
