using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Inventory.DataObjects;
using Inventory.DataObjects.DAO;

namespace Inventory.DataModels.Product
{
    public class ProductCategoryModel
    {
        #region Private data members storing for Product Category 

        ///<summmary>
        /// ID
        ///</summary>
        private string strID = string.Empty;
        
        ///<summary>
        /// Name
        ///</summary>
        private string strName = string.Empty;

        ///<summary>
        /// Parent
        ///</summary>
        private string strParentId = string.Empty;

        ///<summary>
        /// Status
        ///</summary>
        private string strStatus = string.Empty;

        ///<summary>
        /// View Status
        ///</summary>
        Boolean boolViewStatus = true;

        ///<summary>
        /// Description
        ///</summary>
        string strDescription = string.Empty;

       
   
        #endregion

        #region ProductCategory Property
        
        ///<summary>
        /// ID
        ///</summary>
        public string ID
        {
            get { return strID; }
            set { strID = value; }
        }

        ///<summary>
        /// Get set value for Name
        ///</summary>
        ///
        public string Name
        {
            get { return strName; }
            set { strName = value; }
        }

        ///<summary>
        /// Get set value for Parent
        ///</summary>
        ///
        public string ParentID
        {
            get { return strParentId; }
            set { strParentId = value; }
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
        /// Get set value for Status
        ///</summary>
        ///
        public Boolean ViewStatus
        {
            get { return boolViewStatus; }
            set { boolViewStatus = value; }
        }
        ///<summary>
        /// Get set value for Description
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
            ProductCategory objMaster = Mediator.GetInstance().GetProductCategory(this.ID);
            this.ID = objMaster.CategoryID.ToString();
            this.Name = objMaster.CategoryName.ToString();
            this.ParentID = objMaster.ParentCategoryID.ToString();
            this.Status = objMaster.Status.ToString();
            this.Description = objMaster.Description.ToString();
            this.ViewStatus = (objMaster.ViewStatus.IsNull) ? false : (bool)(objMaster.ViewStatus);
        }


        internal ProductCategory GetMasterRecord()
        {
            ProductCategory objMaster = new ProductCategory();
            objMaster.CategoryID = this.ID;
            objMaster.CategoryName = this.Name;
            objMaster.ParentCategoryID = this.ParentID;
            objMaster.Status = this.Status;
            objMaster.Description = this.Description;
            objMaster.ViewStatus = this.ViewStatus;

            return objMaster;
        }
    }
}
