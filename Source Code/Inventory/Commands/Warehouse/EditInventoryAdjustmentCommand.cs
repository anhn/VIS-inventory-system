using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using Inventory.DataModels.Warehouse;
using Inventory.Forms.Warehouse;
using Inventory.Process.Warehouse;

namespace Inventory.Commands.Warehouse
{
    public class EditInventoryAdjustmentCommand : Command
    {
        private String strAdjustId;
        public String AdjustId
        {
            get { return strAdjustId; }
            set { strAdjustId = value; }
        }

        public override void Execute()
        {
            SqlCommand objCmd = null;
            try
            {
                InventoryAdjustment dlgInventoryAdjustment = new InventoryAdjustment();
                InventoryAdjustmentModel model = new InventoryAdjustmentModel();
                model.AdjustId = this.AdjustId;
                model.LoadDataFromDataBase();
                dlgInventoryAdjustment.BindData(model);
                if (DialogResult.Cancel == dlgInventoryAdjustment.ShowDialog())
                {
                    return;
                }
                objCmd = NewSqlCommand();
                InventoryAdjustmentModel dm = dlgInventoryAdjustment.DataModel;
                InventoryAdjustmentProcess pr = new InventoryAdjustmentProcess();
                pr.DBCommand = objCmd;
                pr.DataIn = dm;
                pr.EditInventoryAdjustment();

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
