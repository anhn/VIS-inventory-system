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
    /// Command for deleting StockOut List
    /// </summary>
    public class DeleteStockOutCommand : Command
    {
        /// <summary>
        /// Storing Stock Transfer List Id
        /// </summary>
        private String strId;

        /// <summary>
        /// Property for geting and setting StockOutList Id
        /// </summary>
        public String Id
        {
            get { return strId; }
            set { strId = value; }
        }

        /// <summary>
        /// Excuting StockOut Deletion
        /// </summary>
        public override void Execute()
        {
            if (DialogResult.Cancel == MessageBox.Show("Are you sure you want to delete the selected record? ", "Warning", MessageBoxButtons.OKCancel))
            {
                return;
            }

            SqlCommand objCmd = null;
            try
            {
                StockOutModel model = new StockOutModel();
                model.Id = this.Id;
                objCmd = NewSqlCommand();
                StockOutProcess pr = new StockOutProcess();
                pr.DBCommand = objCmd;
                pr.DataIn = model;
                pr.DeleteStockOut();

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
