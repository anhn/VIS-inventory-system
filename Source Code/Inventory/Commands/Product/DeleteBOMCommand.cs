using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Inventory.DataModels.Product;
using Inventory.Process.Product;

namespace Inventory.Commands.Warehouse
{
    public class DeleteBOMCommand : Command
    {
        private string strID = string.Empty;        

        public string Id
        {
            set { strID = value; }
            get { return strID; }
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
                BOMModel model = new BOMModel();
                model.ID = this.Id;
                objCmd = NewSqlCommand();
                BOMProcess pr = new BOMProcess();
                pr.DBCommand = objCmd;
                pr.DataIn = model;
                pr.DeleteBOM();

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
