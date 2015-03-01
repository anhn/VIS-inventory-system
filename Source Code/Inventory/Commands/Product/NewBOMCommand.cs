using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Forms.Product;
using System.Windows.Forms;
using System.Data.SqlClient;
using Inventory.DataModels.Product;
using Inventory.Process.Product;

namespace Inventory.Commands.Product
{
    class NewBOMCommand : Command
    {

        public override void Execute()
        {
            SqlCommand objCmd = null;

            try
            {
                BillOfMaterial dlgBOM = new BillOfMaterial();
                dlgBOM.BindData(null);

                if (DialogResult.Cancel == dlgBOM.ShowDialog())
                {
                    return;
                }

                objCmd = NewSqlCommand();
                BOMModel dm = dlgBOM.DataModel;

                BOMProcess pr = new BOMProcess();

                pr.DBCommand = objCmd;
                pr.DataIn = dm;

                pr.NewBOM();

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
