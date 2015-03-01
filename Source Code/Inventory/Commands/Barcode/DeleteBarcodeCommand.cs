using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Inventory.DataModels.Barcode;
using Inventory.Process.Barcode;
using System.Windows.Forms;

namespace Inventory.Commands.Barcode
{
    public class DeleteBarcodeCommand:Command
    {
        /// <summary>
        /// Storing Stock Transfer List Id
        /// </summary>
        private String strBarcodeId;

        /// <summary>
        /// Property for geting and setting StockTransferList Id
        /// </summary>
        public String BarcodeId
        {
            get { return strBarcodeId; }
            set { strBarcodeId = value; }
        }

        /// <summary>
        /// Excuting StockTransfer Deletion
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
                BarcodeModel model = new BarcodeModel();
                model.BarcodeId = this.strBarcodeId;
                objCmd = NewSqlCommand();
                BarcodeProcess pr = new BarcodeProcess();
                pr.DBCommand = objCmd;
                pr.DataIn = model;
                pr.DeleteBarcode(this.strBarcodeId);

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
                MessageBox.Show(strMessage);

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
