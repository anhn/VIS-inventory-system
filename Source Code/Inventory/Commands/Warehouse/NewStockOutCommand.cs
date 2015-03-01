using System;
using System.Collections.Generic;
using System.Text;
using Inventory.DataModels.Warehouse;
using Inventory.Process.Warehouse;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory.Commands.Warehouse
{
    class NewStockOutCommand : Command
    {
        #region Command Member
        public override void Execute()
        {
            SqlCommand objCommand = null;
            try
            {
                //Show dialog
                Inventory.Forms.Warehouse.StockOut dlgStockOut = new Inventory.Forms.Warehouse.StockOut();

                dlgStockOut.BindData(null);

                if (DialogResult.Cancel == dlgStockOut.ShowDialog()) return;

                objCommand = this.NewSqlCommand();

                //Process creating new Picking List

                //Get input data from GUI
                StockOutModel dm = dlgStockOut.DataModel;

                StockOutProcess objStockProcess = new StockOutProcess();
                objStockProcess.DBCommand = objCommand;
                objStockProcess.DataIn = dm;
                objStockProcess.NewStockOut();

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
