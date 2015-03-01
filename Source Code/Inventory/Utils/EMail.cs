using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using Inventory.DataModels.SysInfos;

namespace Inventory.Utils
{
    public class EMail
    {
        MailMessage mail = new MailMessage();
        SysInfosModel model = new SysInfosModel();

        public EMail(string strMailTitle, string strMailBody)
        {
            model.LoadDataFromDatabase();
            mail.From = new MailAddress(model.MailFrom);

            string[] strSeparate = new string[] { ",", ";" };
            string[] arrTo = model.MailTo.Split(strSeparate, StringSplitOptions.RemoveEmptyEntries);
            foreach (string strTo in arrTo)
            {
                if (!string.IsNullOrEmpty(strTo.Trim()))
                {
                    mail.To.Add(strTo.Trim());
                }
            }

            mail.Subject = strMailTitle;
            mail.Body = strMailBody;
        }

        public void SendEmail()
        {
            SmtpClient smtp = new SmtpClient(model.MailServer);
            smtp.Send(mail);
        }
    }
}
