using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.DataModels.StockTake
{
    public class PeriodClosingModel
    {
        #region Attributes

        private string strId = string.Empty;

        private string strType = string.Empty;

        private string strTypeName = string.Empty;

        private string strDesc = string.Empty;

        private DateTime datStart = DateTime.MinValue;

        private DateTime datEnd = DateTime.MinValue;

        private bool blnStatus;

        private bool blnState;

        #endregion

        #region Properties

        public string ID
        {
            get { return strId; }
            set { strId = value; }
        }

        public string Type
        {
            get { return strType; }
            set { strType = value; }
        }

        public string TypeName
        {
            get { return strTypeName; }
            set { strTypeName = value; }
        }

        public string Description
        {
            get { return strDesc; }
            set { strDesc = value; }
        }

        public DateTime StartDate
        {
            get { return datStart; }
            set { datStart = value; }
        }

        public DateTime EndDate
        {
            get { return datEnd; }
            set { datEnd = value; }
        }

        public bool Status
        {
            get { return blnStatus; }
            set { blnStatus = value; }
        }

        public bool State
        {
            get { return blnState; }
            set { blnState = value; }
        }

        #endregion
    }
}
