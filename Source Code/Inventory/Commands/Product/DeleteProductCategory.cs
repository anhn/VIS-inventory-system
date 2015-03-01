using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Forms.Warehouse;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using Inventory.DataModels.Product;
using Inventory.Process.Product;
using System.Data.SqlClient;

namespace Inventory.Commands.Product
{
    public class DeleteProductCategoryCommand : Command
    {
        private string strProductCategoryID = string.Empty;

        public string ProductCategoryID
        {
            get { return strProductCategoryID; }
            set { strProductCategoryID = value; }
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
                ProductCategoryProcess pr = new ProductCategoryProcess();

                pr.DBCommand = objCmd;
                pr.DeleteID = strProductCategoryID;

                pr.DeleteProductCategory();

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
