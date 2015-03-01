using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Forms.Warehouse;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using Inventory.DataModels.Warehouse;
using Inventory.Process.Warehouse;
using System.Data.SqlClient;
using System.Data;
using Inventory.DataModels;

namespace Inventory.Commands
{
    public class NewStockTransferCommand:Command
    {
        #region Command Member
        public override void Execute()
        {
            SqlCommand objCommand = null;
            try
            {
                //Show dialog
                Inventory.Forms.Warehouse.StockTransfer dlgStockTransfer = new Inventory.Forms.Warehouse.StockTransfer();

                dlgStockTransfer.BindData(null);

                if (DialogResult.Cancel == dlgStockTransfer.ShowDialog()) return;

                objCommand = this.NewSqlCommand();

                //Process creating new Picking List

                //Get input data from GUI
                StockTransferModel dm = dlgStockTransfer.DataModel;

                StockTransferProcess objStockTransferProcess = new StockTransferProcess();
                objStockTransferProcess.DBCommand = objCommand;
                objStockTransferProcess.DataIn = dm;
                objStockTransferProcess.NewStockTransfer();

                //Process update Location on hand

                //Commit if success
                objCommand.Transaction.Commit();
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
        #endregion
    }
}
