using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Inventory.DataModels.Warehouse;
using Inventory.Process.Warehouse;

namespace Inventory.Commands.Warehouse
{
    public class DeleteInventoryAdjustmentCommand : Command
    {
        private String strAdjustId;
        public String AdjustId
        {
            get { return strAdjustId; }
            set { strAdjustId = value; }
        }
        public override void Execute()
        {
            if (DialogResult.Cancel == MessageBox.Show("Are you sure you want to delete this list? ", "Warning", MessageBoxButtons.OKCancel))
            {
                return;
            }
            SqlCommand objCmd = null;
            try
            {
                InventoryAdjustmentModel model = new InventoryAdjustmentModel();
                model.AdjustId = this.AdjustId;
                objCmd = NewSqlCommand();
                InventoryAdjustmentProcess pr = new InventoryAdjustmentProcess();
                pr.DBCommand = objCmd;
                pr.DataIn = model;
                pr.DeleteInventoryAdjustment();

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
