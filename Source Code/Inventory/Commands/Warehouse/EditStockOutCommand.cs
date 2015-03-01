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
    public class EditStockOutCommand : Command
    {
        private String strId;
        public String Id
        {
            get { return strId; }
            set { strId = value; }
        }
        public override void Execute()
        {
            SqlCommand objCmd = null;
            try
            {
                //Create instance of the dialog
                StockOut dlgStockOut = new StockOut();

                //Create instance of data model to get from GUI
                StockOutModel model = new StockOutModel();
                model.Id = this.Id;

                //Get data to Data Model
                model.LoadDataFromDataBase();

                //Binding data for dialog with Data Model
                dlgStockOut.BindData(model);

                //If Cancel, return
                if (DialogResult.Cancel == dlgStockOut.ShowDialog()) return;

                objCmd = NewSqlCommand();

                //Create instance of data model to get from dialog
                StockOutModel dm = dlgStockOut.DataModel;
                StockOutProcess pr = new StockOutProcess();
                pr.DBCommand = objCmd;
                pr.DataIn = dm;
                pr.EditStockOut();

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
