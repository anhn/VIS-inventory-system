using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;
using Inventory.DataModels.Barcode;
using Inventory.Process.Barcode;

namespace Inventory.Commands.Barcode
{
    public class NewBarcodeCommand : Command
    {
        /// <summary>
        /// Excuting StockTransfer Deletion
        /// </summary>
        public override void Execute()
        {
            SqlCommand objCmd = null;

            try
            {
                BarCodeManager dlgBarcode = new BarCodeManager();
                dlgBarcode.BindData(null, "ADD");

                if (DialogResult.Cancel == dlgBarcode.ShowDialog()) return;
                
                objCmd = NewSqlCommand();
                BarcodeModel dm = dlgBarcode.DataModel;

                BarcodeProcess pr = new BarcodeProcess();

                pr.DBCommand = objCmd;
                pr.DataIn = dm;

                pr.NewBarcode();

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
