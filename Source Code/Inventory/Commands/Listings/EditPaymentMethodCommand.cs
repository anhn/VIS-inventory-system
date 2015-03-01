using System;
using System.Collections.Generic;
using System.Text;
using Inventory.DataModels.Listings;
using Inventory.Forms.Listings;
using Inventory.Process.Listings;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory.Commands.Listings
{
    class EditPaymentMethodCommand : Command
    {
        private string strID = string.Empty;

        public string PaymentMethodId
        {
            set { strID = value; }
        }

        public override void Execute()
        {
            SqlCommand objCmd = null;
            try
            {
                PaymentMethodModel dm = new PaymentMethodModel();
                dm.ID = strID;
                dm.LoadDataFromDataBase();

                PaymentMethod objForm = new PaymentMethod();
                objForm.BindData(dm);
                if (DialogResult.Cancel == objForm.ShowDialog())
                {
                    return;
                }

                objCmd = NewSqlCommand();
                PaymentMethodProcess pr = new PaymentMethodProcess();
                pr.DBCommand = objCmd;
                pr.DataIn = objForm.DataModel;

                pr.EditPaymentMethod();

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
