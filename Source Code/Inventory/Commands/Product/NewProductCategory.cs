using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Forms.Warehouse;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using Inventory.DataModels.Product;
using Inventory.Process.Product;
using Inventory.Forms.Product;
using System.Data.SqlClient;

namespace Inventory.Commands.Product
{
    public class NewProductCategoryCommand : Command
    {
        #region Command Members

        public override void Execute()
        {
            SqlCommand objCmd = null;

            try
            {
                ProductCategory dlgProductCategory = new ProductCategory();
                dlgProductCategory.BindData(null);

                if (DialogResult.Cancel == dlgProductCategory.ShowDialog())
                {
                    return;
                }

                objCmd = NewSqlCommand();
                ProductCategoryModel dm = dlgProductCategory.DataModel;

                ProductCategoryProcess pr = new ProductCategoryProcess();

                pr.DBCommand = objCmd;
                pr.DataIn = dm;

                pr.NewProductCategory();

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

        #endregion
    }
}
