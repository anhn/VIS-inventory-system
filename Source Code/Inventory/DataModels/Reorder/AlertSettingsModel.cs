using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.DataModels.Reorder
{
    public class AlertSettingsModel
    {
        private int dblChkFreq;
        private int dblExpTime;
        private int dblArtLive;

        public AlertSettingsModel()
        {
        }

        public int CheckFrequency
        {
            get { return dblChkFreq; }
            set { dblChkFreq = value; }
        }

        public int DaysBeforeExpire
        {
            get { return dblExpTime; }
            set { dblExpTime = value; }
        }

        public int DaysKeepAlert
        {
            get { return dblArtLive; }
            set { dblArtLive = value; }
        }

        internal void LoadDataFromDatabase()
        {
            object objChkFreq = Mediator.GetInstance().GetConfigValue(Constants.Reorder.CheckFrequencyConfigName);
            object objlExpTime = Mediator.GetInstance().GetConfigValue(Constants.Reorder.DaysBeforeExpireConfigName);
            object objArtLive = Mediator.GetInstance().GetConfigValue(Constants.Reorder.DaysKeepAlertConfigName);

            if (objChkFreq != null && objChkFreq != DBNull.Value)
            {
                try
                {
                    this.dblChkFreq = Convert.ToInt32(objChkFreq);
                }
                catch{}
            }
            if (objlExpTime != null && objlExpTime != DBNull.Value)
            {
                try
                {
                    this.dblExpTime = Convert.ToInt32(objlExpTime);
                }
                catch { }
            }
            if (objArtLive != null && objArtLive != DBNull.Value)
            {
                try
                {
                    this.dblArtLive = Convert.ToInt32(objArtLive);
                }
                catch { }
            }
        }
    }
}
