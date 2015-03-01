using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Inventory.Forms;
using Inventory.DataModels.Barcode;
using System.Windows.Forms;
using Inventory.Process.Barcode;


namespace Inventory.Commands.Barcode
{
    public class EditBarcodeCommand:Command
    {
        private String strBarcodeId;

        public String BarcodeId
        {
            get { return strBarcodeId; }
            set { strBarcodeId = value; }
        }

        public override void Execute()
        {
            SqlCommand objCmd = null;
            try
            {
                //Create instance of the dialog
                BarCodeManager dlgBarcode = new BarCodeManager();

                //Create instance of data model to get from GUI
                BarcodeModel model = new BarcodeModel();
                model.BarcodeId = this.strBarcodeId;

                //Get data to Data Model
                model.LoadDataFromDataBase();

                //Binding data for dialog with Data Model
                dlgBarcode.BindData(model,"EDIT");

                //If Cancel, return
                if (DialogResult.Cancel == dlgBarcode.ShowDialog()) return;

                objCmd = NewSqlCommand();

                //Create instance of data model to get from dialog
                BarcodeModel dm = dlgBarcode.DataModel;
                BarcodeProcess pr = new BarcodeProcess();
                pr.DBCommand = objCmd;
                pr.DataIn = dm;
                pr.EditBarcode();

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
