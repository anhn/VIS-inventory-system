using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Inventory.DataObjects;
using Inventory.DataObjects.DAO;

namespace Inventory.DataModels.Product
{
    public class ProductFamilyModel
    {
        #region private data member for Product Family

        ///<summmary>
        /// ID
        ///</summary>
        private string strID = string.Empty;
        
        ///<summmary>
        /// name
        ///</summary>
        private string strName = string.Empty;
        
        ///<summary>
        /// Status
        ///</summary>
        private string strStatus = string.Empty;

        ///<summmary>
        /// Status
        ///</summary>
        private Boolean blnViewStatus = true;

        ///<summmary>
        /// Description
        ///</summary>
        ///

        private string strDescription = string.Empty;

        #endregion

        #region  Product Family Property 

        ///<summary>
        /// ID
        ///</summary>
        public string ID
        {
            get { return strID; }
            set { strID = value; }
        }

        ///<summary>
        ///Name 
        ///</summary>
        public string Name
        {
            get { return strName; }
            set { strName = value; }
        }

        ///<summary>
        /// Get set value for Status
        ///</summary>
        ///
        public string Status
        {
            get { return strStatus; }
            set { strStatus = value; }
        }

        ///<summary>
        /// Status 
        ///</summary>
        ///
        public Boolean ViewStatus
        {
            get { return blnViewStatus; }
            set { blnViewStatus = value; }
        }

        ///<summary>
        /// Description
        ///</summary>
        ///
        public string Description
        {
            get { return strDescription; }
            set { strDescription = value; }
        }
        
        #endregion 

        internal void LoadDataFromDataBase()
        {
            ProductFamily objMaster = Mediator.GetInstance().GetProductFamily(this.ID);
            this.ID = objMaster.FamilyID.ToString();
            this.Name = objMaster.Name.ToString();
            this.Status = objMaster.Status.ToString();
            this.Description = objMaster.Description.ToString();
            this.ViewStatus = (objMaster.ViewStatus.IsNull) ? false : (bool)(objMaster.ViewStatus);
        }
        
        internal ProductFamily GetMasterRecord()
        {
            ProductFamily objMaster = new ProductFamily();
            objMaster.FamilyID = this.ID;
            objMaster.Name = this.Name;
            objMaster.Status = this.Status;
            objMaster.Description = this.Description;
            objMaster.ViewStatus = this.ViewStatus;

            return objMaster;
        }
    }
}
