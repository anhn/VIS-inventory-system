using System;
using System.Collections.Generic;
using System.Text;
using Inventory;
using Inventory.Forms;
using Inventory.Forms.Warehouse;
using Inventory.Process.Warehouse;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using Inventory.DataModels.Warehouse;

namespace Inventory.Commands
{
    public class NewPickingListCommand:Command
    {
        private string strPackingListID = string.Empty;
        private Inventory.DataModels.Warehouse.PickingListModel objPickingList = new Inventory.DataModels.Warehouse.PickingListModel();

        public string PackingListID
        {
            set { strPackingListID = value; }
            get { return strPackingListID; }
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
            
            dlgPickingList.BindData(null);
            
            if (DialogResult.Cancel == dlgPickingList.ShowDialog()) return;

            objCommand = this.NewSqlCommand();
        
            //Process creating new Picking List

            //Get input data from GUI
            PickingListModel dm = dlgPickingList.DataModel;

            PickingListProcess objPickingListProcess = new PickingListProcess(objCommand);
            objPickingListProcess.DataModel = dm;
            objPickingListProcess.NewPickingList();

            //Process update Location on hand

            //Commit if success
            objCommand.Transaction.Commit();
            MessageBox.Show(Constants.Message.Save_Success, Constants.Message.MessageTitle);
            //Console.WriteLine("New Picking List Transction was successfully processed.");
            } 
            catch(Exception ex) 
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
