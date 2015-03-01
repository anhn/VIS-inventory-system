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
    class EditPackingListCommand : Command
    {
        private String strPackingListId;
        public String PackingListId
        {
            get { return strPackingListId; }
            set { strPackingListId = value; }
        }
        public override void Execute()
        {
            SqlCommand objCmd = null;
            try
            {
                PackingList dlgPackingList = new PackingList();
                PackingListModel model = new PackingListModel();
                model.PackingListId = this.PackingListId;
                model.LoadDataFromDataBase();
                dlgPackingList.BindData(model);
                if (DialogResult.Cancel == dlgPackingList.ShowDialog())
                {
                    return;
                }
                objCmd = NewSqlCommand();
                PackingListModel dm = dlgPackingList.DataModel;
                PackingNoteProcess pr = new PackingNoteProcess();
                pr.DBCommand = objCmd;
                pr.DataIn = dm;
                pr.EditPackingList();

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
