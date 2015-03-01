using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Inventory.DataModels;
using Inventory.DataModels.Reorder;
using Inventory.DataObjects;

namespace Inventory.Process.Reorder
{
    public class AlertSettingsProcess
    {
        private AlertSettingsModel model;
        private SqlCommand objCmd;

        public AlertSettingsModel DataIn
        {
            get { return model; }
            set { model = value; }
        }
        public SqlCommand DBCommand
        {
            get { return objCmd; }
            set { objCmd = value; }
        }

        public void EditAlertSettings()
        {
            Mediator.GetInstance().UpdateConfigValue(objCmd, Constants.Reorder.CheckFrequencyConfigName, model.CheckFrequency.ToString());
            Mediator.GetInstance().UpdateConfigValue(objCmd, Constants.Reorder.DaysBeforeExpireConfigName, model.DaysBeforeExpire.ToString());
            Mediator.GetInstance().UpdateConfigValue(objCmd, Constants.Reorder.DaysKeepAlertConfigName, model.DaysKeepAlert.ToString());
        }
    }
}
