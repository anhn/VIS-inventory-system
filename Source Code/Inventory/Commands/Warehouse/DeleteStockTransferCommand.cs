using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Inventory.Process.Warehouse;
using System.Data.SqlClient;
using Inventory.DataModels.Warehouse;

namespace Inventory.Commands.Warehouse
{
    /// <summary>
    /// Command for deleting StockTransfer List
    /// </summary>
    public class DeleteStockTransferCommand : Command
    {
        /// <summary>
        /// Storing Stock Transfer List Id
        /// </summary>
        private String strStockTransferListId;

        /// <summary>
        /// Property for geting and setting StockTransferList Id
        /// </summary>
        public String StockTransferListId
        {
            get { return strStockTransferListId; }
            set { strStockTransferListId = value; }
        }

        /// <summary>
        /// Excuting StockTransfer Deletion
        /// </summary>
        public override void Execute()
        {
            if (DialogResult.Cancel == MessageBox.Show("Are you sure you want to delete the selected record? ","Warning", MessageBoxButtons.OKCancel))
            {
                return;
            }

            SqlCommand objCmd = null;
            try
            {
                StockTransferModel model = new StockTransferModel();
                model.StockTransferId = this.StockTransferListId;                
                objCmd = NewSqlCommand();                
                StockTransferProcess pr = new StockTransferProcess();
                pr.DBCommand = objCmd;
                pr.DataIn = model;
                pr.DeleteStockTransfer();

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
