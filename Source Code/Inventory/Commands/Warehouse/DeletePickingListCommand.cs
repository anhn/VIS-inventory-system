using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Inventory.DataModels.Warehouse;
using Inventory.Process.Warehouse;

namespace Inventory.Commands.Warehouse
{
    public class DeletePickingListCommand : Command
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
            if (DialogResult.Cancel == MessageBox.Show("Are you sure you want to delete this list? ", "Warning", MessageBoxButtons.OKCancel))
            {
                return;
            }
            SqlCommand objCmd = null;
            try
            {
                PickingListModel model = new PickingListModel();
                model.PickingListID = this.PickingListID;
                objCmd = NewSqlCommand();
                PickingListProcess pr = new PickingListProcess(objCmd);
                pr.DBCommand = objCmd;
                pr.DataModel = model;
                pr.DeletePickingList();

                objCmd.Transaction.Commit();
            }
            catch (Exception e)
            {
                if (objCmd != null)
                {
                    objCmd.Transaction.Rollback();                    
                }
                string strMessage = e.Message;
                while (e.InnerException != null)
                {
                    strMessage += Environment.NewLine + e.InnerException.Message;
                    e = e.InnerException;
                }
                MessageBox.Show(strMessage, Constants.Message.MessageTitle);
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
