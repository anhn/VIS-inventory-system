using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Inventory.Process.Warehouse;
using System.Data.SqlClient;
using Inventory.DataModels.Warehouse;

namespace Inventory.Commands.Warehouse
{
    class DeletePackingListCommand : Command
    {
        private String strPackingListId;
        public String PackingListId
        {
            get { return strPackingListId; }
            set { strPackingListId = value; }
        }
        public override void Execute()
        {
            if (DialogResult.Cancel == MessageBox.Show("Are you sure you want to delete this list? ","Warning", MessageBoxButtons.OKCancel))
            {
                return;
            }
            SqlCommand objCmd = null;
            try
            {
                PackingListModel model = new PackingListModel();
                model.PackingListId = this.PackingListId;                
                objCmd = NewSqlCommand();                
                PackingNoteProcess pr = new PackingNoteProcess();
                pr.DBCommand = objCmd;
                pr.DataIn = model;
                pr.DeletePackingList();

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
