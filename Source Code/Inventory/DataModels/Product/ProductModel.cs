using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Inventory.DataObjects;
using Inventory.DataObjects.DAO;

namespace Inventory.DataModels.Product
{
    public class ProductModel
    {
        #region Attributes

        private string strId = string.Empty;

        private string strName = string.Empty;

        private string strAlternativeId = string.Empty;

        private string strCategoryId = string.Empty;

        private string strFamilyId = string.Empty;

        private string strDescription = string.Empty;

        private string strCurrencyId = string.Empty;

        private string strBarcodeId = string.Empty;

        private string strUOM = string.Empty;

        private double dblBasePrice = 0;

        private double dblHoldingCost = 0;

        private bool blnViewStatus=true;

        #endregion

        #region Packing Property

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

        public string AlternativeID
        {
            get { return strAlternativeId; }
            set { strAlternativeId = value; }
        }

        public string CategoryID
        {
            get { return strCategoryId; }
            set { strCategoryId = value; }
        }

        public string FamilyID
        {
            get { return strFamilyId; }
            set { strFamilyId = value; }
        }

        public string Description
        {
            get { return strDescription; }
            set { strDescription = value; }
        }

        public string CurrencyID
        {
            get { return strCurrencyId; }
            set { strCurrencyId = value; }
        }

        public string BarcodeID
        {
            get { return strBarcodeId; }
            set { strBarcodeId = value; }
        }

        public string UOMID
        {
            get { return strUOM; }
            set { strUOM = value; }
        }

        public double BasePrice
        {
            get { return dblBasePrice; }
            set { dblBasePrice = value; }
        }

        public double HoldingCost
        {
            get { return dblHoldingCost; }
            set { dblHoldingCost = value; }
        }

        public bool ViewStatus
        {
            get { return blnViewStatus; }
            set { blnViewStatus = value; }
        }

        #endregion

        internal void LoadDataFromDataBase()
        {
            ProductMaster objMaster = Mediator.GetInstance().GetProductMaster(this.ID);
            this.ID = objMaster.ProductID.ToString();
            this.Name = objMaster.ProductName.ToString();
            this.AlternativeID = objMaster.AlternativeID.ToString();
            this.FamilyID = objMaster.FamilyID.ToString();
            this.CategoryID = objMaster.CategoryID.ToString();
            this.Description = objMaster.Description.ToString();
            this.CurrencyID = objMaster.CurrencyID.ToString();
            this.BarcodeID = objMaster.BarcodeID.ToString();
            this.UOMID = objMaster.UOMID.ToString();
            this.BasePrice = (objMaster.BasePrice.IsNull)? 0: objMaster.BasePrice.ToDouble();
            this.HoldingCost = (objMaster.HoldingCost.IsNull) ? 0 : objMaster.HoldingCost.ToDouble();
            this.ViewStatus = (objMaster.ViewStatus.IsNull) ? false : (bool)(objMaster.ViewStatus);
        }


        internal ProductMaster GetMasterRecord()
        {
            ProductMaster objMaster = new ProductMaster();
            objMaster.AlternativeID = this.AlternativeID;
            objMaster.BarcodeID = this.BarcodeID;
            objMaster.CategoryID = this.CategoryID;
            objMaster.UOMID = this.UOMID;
            objMaster.CurrencyID = this.CurrencyID;
            objMaster.Description = this.Description;
            objMaster.FamilyID = this.FamilyID;
            objMaster.ProductID = this.ID;
            objMaster.ProductName = this.Name;
            objMaster.BasePrice = (decimal)this.BasePrice;
            objMaster.HoldingCost = (decimal)this.HoldingCost;
            objMaster.ViewStatus = this.ViewStatus;

            return objMaster;
        }
    }
}
