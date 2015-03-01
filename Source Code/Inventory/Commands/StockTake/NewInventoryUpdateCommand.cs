using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Forms.Warehouse;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using Inventory.DataModels.StockTake;
using Inventory.Process.StockTake;
using Inventory.Forms.StockTake;
using System.Data.SqlClient;

namespace Inventory.Commands.StockTake
{
    public class NewInventoryUpdateCommand : Command
    {
        #region Command Members

        public override void Execute()
        {
            SqlCommand objCmd = null;

            try
            {
                InventoryUpdate dlgInventoryUpdate = new InventoryUpdate();
                dlgInventoryUpdate.BindData(null);

                if (DialogResult.Cancel == dlgInventoryUpdate.ShowDialog())
                {
                    return;
                }

                objCmd = NewSqlCommand();
                InventoryUpdateModel dm = dlgInventoryUpdate.DataModel;

                InventoryUpdateProcess pr = new InventoryUpdateProcess();

                pr.DBCommand = objCmd;
                pr.DataIn = dm;

                pr.NewInventoryUpdate();

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
