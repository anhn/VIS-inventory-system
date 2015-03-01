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
    public class EditInventoryUpdateCommand : Command
    {
        private string strID = string.Empty;

        public string InventoryUpdateId
        {
            set { strID = value; }
        }

        public override void Execute()
        {
            SqlCommand objCmd = null;
            try
            {
                InventoryUpdateModel dm = new InventoryUpdateModel();
                dm.ID = strID;
                dm.LoadDataFromDataBase();

                InventoryUpdate frmInventoryUpdate = new InventoryUpdate();
                frmInventoryUpdate.BindData(dm);
                if (DialogResult.Cancel == frmInventoryUpdate.ShowDialog())
                {
                    return;
                }

                objCmd = NewSqlCommand();
                InventoryUpdateProcess pr = new InventoryUpdateProcess();
                pr.DBCommand = objCmd;
                pr.DataIn = frmInventoryUpdate.DataModel;

                // Since the InventoryUpdate does not permit to be updated so temporary disable below
                //pr.EditInventoryUpdate();
                //objCmd.Transaction.Commit();

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
