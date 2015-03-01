using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Inventory.DataObjects;
using Inventory.DataObjects.DAO;

namespace Inventory.DataModels.Listings
{
    public class ProductMasterModel
    {
        #region Private data member for storing information of Product Master
        ///<summary>
        /// productName
        ///</summary>
        private string strProductName = string.Empty;

        ///<summary>
        /// Product Description
        ///</summary>
        ///
        private string strProductDescription = string.Empty;


        ///<summary>
        /// AlternativeName
        ///</summary>
        ///
        private string strAlternativeName = string.Empty;

        ///<summary>
        /// Family
        ///</summary>
        ///
        private string strFamily = string.Empty;

        ///<summary>
        /// Category
        ///</summary>
        ///
        private string strCategory = string.Empty;

        ///<summary>
        /// BarCode
        ///</summary>
        ///
        private string strBarCode = string.Empty;

        ///<summary>
        /// Unit of Measure
        ///</summary>
        ///
        private string strUnitOfMeasure = string.Empty;

        ///<summary>
        /// Base price
        ///</summary>
        ///
        private string strBasePrice = string.Empty;

        ///<summary>
        /// Holding Code
        ///</summary>
        ///
        private string strHoldingCode = string.Empty;

        ///<summary>
        /// View Status
        ///</summary>
        ///
        private Boolean boolViewStatus = false;

        #endregion

        #region ProductMasterProperty

        ///<summary>
        ///Get Set value for ProductMaster Name
        ///</summary>
        ///
        public string ProductName
        {
            set { strProductName = value; }
            get { return strProductName; }
        }

        ///<summary>
        /// Get Set value for Product Description
        ///</summary>
        ///
        public string ProductDescription
        {
            set { strProductDescription = value; }
            get { return strProductDescription; }
        }

        ///<summary>
        /// Get Set values for Alternative Name
        ///</summary>
        ///
        public string AlternativeName
        {
            set { strAlternativeName = value; }
            get { return strAlternativeName; }
        }
        
        ///<summary>
        /// Get Set values for Family
        ///</summary>
        ///
        public string Family
        {
            set { strFamily = value; }
            get { return strFamily; }
        }
        ///<summary>
        /// Get Set Values for Category
        ///</summary>
        ///
        public string Category
        {
            set { strCategory = value; }
            get { return strCategory; }
        }
        ///<summary>
        /// Get Set Values for BarCode
        ///</summary>
        ///
        public string BarCode
        {
            set { strBarCode = value; }
            get { return strBarCode; }
        }
        ///<summary>
        /// Get Set Values for Unit of Measure
        ///</summary>
        ///
        public string UnitOfMeasure
        {
            set { strUnitOfMeasure = value; }
            get { return strUnitOfMeasure; }
        }
        ///<summary>
        ///Get Set values for  BasePrice
        ///</summary>
        ///
        public string BasePrice
        {
            get { return strBasePrice; }
            set { strBasePrice = value; }
        }
        ///<summary>
        /// Get Set values for Holding Cost
        ///</summary>
        ///
        public string HoldingCost
        {
            get { return strHoldingCode; }
            set { strHoldingCode = value; }
        }

        ///<summary>
        /// Get Set values for View Status
        ///</summary>
        ///
        public Boolean ViewStatus
        {
            get { return boolViewStatus; }
            set { boolViewStatus = value; }
        }
        #endregion
    }
}
