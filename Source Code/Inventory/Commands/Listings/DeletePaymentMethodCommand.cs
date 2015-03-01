using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Inventory.Process.Listings;

namespace Inventory.Commands.Listings
{
    class DeletePaymentMethodCommand : Command
    {
        private string strID = string.Empty;

        public string PaymentMethodId
        {
            get { return strID; }
            set { strID = value; }
        }

        public override void Execute()
        {
            DialogResult dlgResult = MessageBox.Show(Properties.Settings.Default.strWarningDelete, Properties.Settings.Default.strWarningTitle, MessageBoxButtons.OKCancel);
            if (dlgResult == DialogResult.Cancel)
            {
                return;
            }

            SqlCommand objCmd = null;
            try
            {
                objCmd = NewSqlCommand();
                PaymentMethodProcess pr = new PaymentMethodProcess();

                pr.DBCommand = objCmd;
                pr.DeleteID = strID;

                pr.DeletePaymentMethod();

                objCmd.Transaction.Commit();
            }
            catch (Exception ex)
            {
                string strMessage = ex.Message;
                while (ex.InnerException != null)
                {
                    strMessage += Environment.NewLine + ex.InnerException.Message;
                    ex = ex.InnerException;
                }

                MessageBox.Show(strMessage, Constants.Message.MessageTitle);

                if (objCmd != null)
                {
                    objCmd.Transaction.Rollback();
                }
            }
            finally
            {
                if (objCmd != null)
                {
                    objCmd.Connection.Close();
                }
            }
        }
    }
}
