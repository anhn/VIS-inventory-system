using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Forms.Warehouse;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using Inventory.DataModels.Warehouse;
using Inventory.Process.Warehouse;
using System.Data.SqlClient;

namespace Inventory.Commands.Warehouse
{
    public class DeleteDeliveryNoteCommand : Command
    {
        private string strDeliveryNoteID = string.Empty;

        public string DeliveryNoteID
        {
            get { return strDeliveryNoteID; }
            set { strDeliveryNoteID = value; }
        }

        public override void Execute()
        {
            DialogResult dlgResult = MessageBox.Show(Properties.Settings.Default.strWarningDelete, Properties.Settings.Default.strWarningTitle, MessageBoxButtons.OKCancel);
            if (dlgResult == DialogResult.Cancel)
            {
                return;
            }

            SqlCommand objCmd = null;
            try
            {
                objCmd = NewSqlCommand();
                DeliveryNoteProcess pr = new DeliveryNoteProcess();

                pr.DBCommand = objCmd;
                pr.DeleteID = strDeliveryNoteID;

                pr.DeleteDeliveryNote();

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
