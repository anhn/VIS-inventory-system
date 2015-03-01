using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Inventory.DataModels;
using Inventory.DataModels.SysInfos;
using Inventory.DataObjects;

namespace Inventory.Process.SysInfos
{
    public class SysInfosProcess
    {
        private SysInfosModel model;
        private SqlCommand objCmd;

        public SysInfosModel DataIn
        {
            get { return model; }
            set { model = value; }
        }
        public SqlCommand DBCommand
        {
            get { return objCmd; }
            set { objCmd = value; }
        }

        public void EditSysInfos()
        {
            Mediator.GetInstance().UpdateConfigValue(objCmd, Constants.SysInfos.MailSender, model.MailSender);
            Mediator.GetInstance().UpdateConfigValue(objCmd, Constants.SysInfos.MailFrom, model.MailFrom);
            Mediator.GetInstance().UpdateConfigValue(objCmd, Constants.SysInfos.MailTo, model.MailTo);
            Mediator.GetInstance().UpdateConfigValue(objCmd, Constants.SysInfos.MailHost, model.MailServer);
        }
    }
}
