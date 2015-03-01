using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Forms.Warehouse;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using Inventory.DataModels.StockTake;
using Inventory.Process.StockTake;
using System.Data.SqlClient;

namespace Inventory.Commands.StockTake
{
    public class DeleteInventoryUpdateCommand : Command
    {
        private string strInventoryUpdateID = string.Empty;

        public string InventoryUpdateID
        {
            get { return strInventoryUpdateID; }
            set { strInventoryUpdateID = value; }
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
                InventoryUpdateProcess pr = new InventoryUpdateProcess();

                pr.DBCommand = objCmd;
                pr.DeleteID = strInventoryUpdateID;

                pr.DeleteInventoryUpdate();

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
