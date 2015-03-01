using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Forms.Listings;
using Inventory.DataModels.Listings;
using Inventory.Process.Listings;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory.Commands.Listings
{
    public class NewPaymentMethodCommand : Command
    {
        public override void Execute()
        {
            SqlCommand objCmd = null;

            try
            {
                PaymentMethod dlgForm = new PaymentMethod();
                dlgForm.BindData(null);

                if (DialogResult.Cancel == dlgForm.ShowDialog())
                {
                    return;
                }

                objCmd = NewSqlCommand();
                PaymentMethodModel dm = dlgForm.DataModel;

                PaymentMethodProcess pr = new PaymentMethodProcess();

                pr.DBCommand = objCmd;
                pr.DataIn = dm;

                pr.NewPaymentMethod();

                objCmd.Transaction.Commit();
                MessageBox.Show(Constants.Message.Save_Success, Constants.Message.MessageTitle);
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
