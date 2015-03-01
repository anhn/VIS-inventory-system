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
    public class EditProductCategoryCommand : Command
    {
        private string strID = string.Empty;

        public string ProductCategoryId
        {
            set { strID = value; }
        }

        public override void Execute()
        {
            SqlCommand objCmd = null;
            try
            {
                ProductCategoryModel dm = new ProductCategoryModel();
                dm.ID = strID;
                dm.LoadDataFromDataBase();

                ProductCategory frmProductCategory = new ProductCategory();
                frmProductCategory.BindData(dm);
                if (DialogResult.Cancel == frmProductCategory.ShowDialog())
                {
                    return;
                }

                objCmd = NewSqlCommand();
                ProductCategoryProcess pr = new ProductCategoryProcess();
                pr.DBCommand = objCmd;
                pr.DataIn = frmProductCategory.DataModel;

                pr.EditProductCategory();

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
