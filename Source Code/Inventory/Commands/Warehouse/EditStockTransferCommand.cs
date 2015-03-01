using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Forms.Warehouse;
using Inventory.DataModels.Warehouse;
using Inventory.Process.Warehouse;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory.Commands.Warehouse
{
    public class EditStockTransferCommand : Command
    {
        private String strStockTransferListId;
        private String strStockTransferName;

        public String StockTransferListId
        {
            get { return strStockTransferListId; }
            set { strStockTransferListId = value; }
        }
        public String StockTransferName
        {
            get { return strStockTransferName; }
            set { strStockTransferName = value; }
        }

        public override void Execute()
        {
            SqlCommand objCmd = null;
            try
            {
                //Create instance of the dialog
                StockTransfer dlgStockTransfer = new StockTransfer(strStockTransferName);
                //Create instance of data model to get from GUI
                StockTransferModel model = new StockTransferModel();
                model.StockTransferId = this.StockTransferListId;

                //Get data to Data Model
                model.LoadDataFromDataBase();

                //Binding data for dialog with Data Model
                dlgStockTransfer.BindData(model);

                //If Cancel, return
                if (DialogResult.Cancel == dlgStockTransfer.ShowDialog()) return;
                
                objCmd = NewSqlCommand();

                //Create instance of data model to get from dialog
                StockTransferModel dm = dlgStockTransfer.DataModel;
                StockTransferProcess pr = new StockTransferProcess();
                pr.DBCommand = objCmd;
                pr.DataIn = dm;
                pr.EditStockTransfer();

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
