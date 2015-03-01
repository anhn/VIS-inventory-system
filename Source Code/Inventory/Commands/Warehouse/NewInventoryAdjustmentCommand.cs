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
    public class NewInventoryAdjustmentCommand : Command
    {
        private String strAdjustId;
        public String AdjustId
        {
            get { return strAdjustId; }
            set { strAdjustId = value; }
        }

        private Inventory.DataModels.Warehouse.InventoryAdjustmentModel objAdjust = new Inventory.DataModels.Warehouse.InventoryAdjustmentModel();

        public Inventory.DataModels.Warehouse.InventoryAdjustmentModel AdjustModel
        {
            set { objAdjust = value; }
        }

        public override void Execute()
        {
            SqlCommand objCommand = null;
            try
            {
                //Show dialog
                Inventory.Forms.Warehouse.InventoryAdjustment dlgAdjust = new Inventory.Forms.Warehouse.InventoryAdjustment();

                dlgAdjust.BindData(null);

                if (DialogResult.Cancel == dlgAdjust.ShowDialog()) return;

                objCommand = this.NewSqlCommand();

                //Process creating new Picking List

                //Get input data from GUI
                InventoryAdjustmentModel dm = dlgAdjust.DataModel;

                InventoryAdjustmentProcess objAdjustProcess = new InventoryAdjustmentProcess();
                objAdjustProcess.DataIn = dm;
                objAdjustProcess.DBCommand = objCommand;
                objAdjustProcess.NewInventoryAdjustment();

                //Process update Location on hand

                //Commit if success
                objCommand.Transaction.Commit();
                MessageBox.Show(Constants.Message.Save_Success, Constants.Message.MessageTitle);
                //Console.WriteLine("New Picking List Transction was successfully processed.");
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

                if (objCommand != null)
                {
                    objCommand.Transaction.Rollback();
                }
            }
            finally
            {
                //Close the connection.
                if (objCommand != null)
                {
                    objCommand.Connection.Close();
                }
            }
        }
    }
}
