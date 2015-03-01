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
    /// Command for deleting StockIn List
    /// </summary>
    public class DeleteStockInCommand : Command
    {
        /// <summary>
        /// Storing Stock Transfer List Id
        /// </summary>
        private String strId;

        /// <summary>
        /// Property for geting and setting StockInList Id
        /// </summary>
        public String Id
        {
            get { return strId; }
            set { strId = value; }
        }

        /// <summary>
        /// Excuting StockIn Deletion
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
                StockInModel model = new StockInModel();
                model.Id = this.Id;
                objCmd = NewSqlCommand();
                StockInProcess pr = new StockInProcess();
                pr.DBCommand = objCmd;
                pr.DataIn = model;
                pr.DeleteStockIn();

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
