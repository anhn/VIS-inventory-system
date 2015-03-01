using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Inventory.DataObjects;

namespace Inventory.Process.Reorder
{
    public class ProductExpiredProcess
    {
        private string strProductExpired = "";
        private string strExpireWarning = "";

        public ProductExpiredProcess()
        {

        }

        public void Execute()
        {
            ProductMaster objProduct = new ProductMaster();
            DataTable dtProducts = objProduct.SelectAll();
            if (dtProducts.Rows.Count == 0)
            {
                return;
            }

            Configs objConfig = new Configs();
            objConfig.Name = Constants.Reorder.DaysBeforeExpireConfigName;
            objConfig.SelectOne();

            int intDaysBeforeExpire = 0;
            try
            {
                intDaysBeforeExpire = Convert.ToInt32((string)objConfig.Value);
            }
            catch { }
            
            // calculate Reorder for each product
            foreach (DataRow drProd in dtProducts.Rows)
            {
                DateTime dtExpire = DateTime.MinValue;
                try
                {
                    dtExpire = Convert.ToDateTime(drProd["ExpiredDate"]);
                }
                catch{}

                if(dtExpire <= DateTime.Now)
                {
                    this.CreateExpireAlert(drProd, false);
                } 
                else if (dtExpire >= DateTime.Now &&
                    dtExpire < DateTime.Now.AddDays(intDaysBeforeExpire))
                {
                    this.CreateExpireAlert(drProd, true);
                }
                          
            }

            this.SendEmail();
        }

        private void SendEmail()
        {
            string strContent = "";
            if (!string.IsNullOrEmpty(strProductExpired))
            {
                strContent += "Expired Product Alert: " + Environment.NewLine + strProductExpired;
            }
            if (!string.IsNullOrEmpty(strExpireWarning))
            {
                strContent += Environment.NewLine + Environment.NewLine;
                strContent += "Product Expire Warning: " + Environment.NewLine + strExpireWarning;
            }

            strContent += Environment.NewLine + Environment.NewLine;
            if (strContent == "")
            {
                return; // there is no expired product, do not send mail
            }

            Utils.EMail mail = new Inventory.Utils.EMail(Properties.Settings.Default.MailExpireSubject, strContent);
            mail.SendEmail();
        }

        private void CreateExpireAlert(DataRow drProd, bool isWarning)
        {
            if (isWarning)
            {
                strExpireWarning += "\tProduct Name: " + drProd["ProductName"] + ", Expired Date: " + drProd["ExpiredDate"] + Environment.NewLine;
            }
            else
            {
                strProductExpired += "\tProduct Name: " + drProd["ProductName"] + ", Expired Date: " + drProd["ExpiredDate"] + Environment.NewLine;
            }
        }
    }
}
