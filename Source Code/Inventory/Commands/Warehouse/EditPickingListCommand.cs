using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using Inventory.Process.Warehouse;
using Inventory.DataModels.Warehouse;

namespace Inventory.Commands.Warehouse
{
    public class EditPickingListCommand:Command
    {
        private string strPickingListID = string.Empty;
        private Inventory.DataModels.Warehouse.PickingListModel objPickingList = new Inventory.DataModels.Warehouse.PickingListModel();

        public string PickingListID
        {
            set { strPickingListID = value; }
            get { return strPickingListID; }
        }

        public Inventory.DataModels.Warehouse.PickingListModel PickingList
        {
            set { objPickingList = value; }
        }

        public override void Execute()
        {
            SqlCommand objCommand = null;
            try
            {
                //Show dialog
                Inventory.Forms.Warehouse.PickingList dlgPickingList = new Inventory.Forms.Warehouse.PickingList();

                //Binding data for editing
                PickingListModel model = new PickingListModel();
                model.PickingListID = this.PickingListID;
                model.LoadDataFromDataBase();

                dlgPickingList.BindData(model);
                
                if (DialogResult.Cancel == dlgPickingList.ShowDialog()) return;

                objCommand = this.NewSqlCommand();

                //Process creating new Picking List

                //Get input data from GUI
                PickingListModel dm = dlgPickingList.DataModel;

                PickingListProcess objPickingListProcess = new PickingListProcess(objCommand);
                objPickingListProcess.DataModel = dm;
                objPickingListProcess.EditPickingList();
                
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
    }
}
