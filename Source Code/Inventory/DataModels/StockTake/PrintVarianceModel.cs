using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.DataModels.StockTake
{
    public class PrintVarianceModel
    {
        #region Attributes

        private string strId = string.Empty;

        private string strSortBy = string.Empty;

        private decimal dcmVariance = 0;

        private bool blnOnlyMissingItems;

        private bool blnExcludeBothZero;

        private String strName;

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

        public string SortBy
        {
            get { return strSortBy; }
            set { strSortBy = value; }
        }

        public decimal Variance
        {
            get { return dcmVariance; }
            set { dcmVariance = value; }
        }

        public bool OnlyMissingItems
        {
            get { return blnOnlyMissingItems; }
            set { blnOnlyMissingItems = value; }
        }

        public bool ExcludeBothZero
        {
            get { return blnExcludeBothZero; }
            set { blnExcludeBothZero = value; }
        }

        #endregion
    }
}
