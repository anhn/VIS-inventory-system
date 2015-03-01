using System;
using System.Collections.Generic;
using System.Text;
using Inventory.DataModels.Warehouse;
using Inventory.Process.Warehouse;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory.Commands.Warehouse
{
    class NewStockInCommand : Command
    {
        #region Command Member
        public override void Execute()
        {
            SqlCommand objCommand = null;
            try
            {
                //Show dialog
                Inventory.Forms.Warehouse.StockIn dlgStockIn = new Inventory.Forms.Warehouse.StockIn();

                dlgStockIn.BindData(null);

                if (DialogResult.Cancel == dlgStockIn.ShowDialog()) return;

                objCommand = this.NewSqlCommand();

                //Process creating new Picking List

                //Get input data from GUI
                StockInModel dm = dlgStockIn.DataModel;

                StockInProcess objStockInProcess = new StockInProcess();
                objStockInProcess.DBCommand = objCommand;
                objStockInProcess.DataIn = dm;
                objStockInProcess.NewStockIn();

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
