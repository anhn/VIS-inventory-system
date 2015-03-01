using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.DataModels.SysInfos
{
    public class SysInfosModel
    {
        private string strMailSender = "";
        private string strMailFrom = "";
        private string strMailTo = "";
        private string strMailServer = "";

        public SysInfosModel()
        {
        }

        public string MailSender
        {
            get { return strMailSender; }
            set { strMailSender = value; }
        }

        public string MailFrom
        {
            get { return strMailFrom; }
            set { strMailFrom = value; }
        }
        
        public string MailTo
        {
            get { return strMailTo; }
            set { strMailTo = value; }
        }

        public string MailServer
        {
            get { return strMailServer; }
            set { strMailServer = value; }
        }

        internal void LoadDataFromDatabase()
        {
            this.strMailSender = Mediator.GetInstance().GetConfigValue(Constants.SysInfos.MailSender);
            this.strMailFrom = Mediator.GetInstance().GetConfigValue(Constants.SysInfos.MailFrom);
            this.strMailTo = Mediator.GetInstance().GetConfigValue(Constants.SysInfos.MailTo);
            this.strMailServer = Mediator.GetInstance().GetConfigValue(Constants.SysInfos.MailHost);
        }
    }
}
