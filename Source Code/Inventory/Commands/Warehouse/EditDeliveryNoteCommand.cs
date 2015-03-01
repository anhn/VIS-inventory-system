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
    public class EditDeliveryNoteCommand : Command
    {
        private string strID = string.Empty;
        private string strDNID = "";

        public string DeliveryNoteId
        {
            set { strID = value; }
        }

        public string DeliveryNoteDNID
        {
            set { strDNID = value; }
        }        

        public override void Execute()
        {
            SqlCommand objCmd = null;
            try
            {                
                DeliveryNoteModel dm = new DeliveryNoteModel();
                dm.ID = strID;
                dm.LoadDataFromDatabase();

                DeliveryNotes frmDeliveryNote = new DeliveryNotes(strDNID);
                frmDeliveryNote.BindData(dm);
                if (DialogResult.Cancel == frmDeliveryNote.ShowDialog())
                {
                    return;
                }

                objCmd = NewSqlCommand();
                DeliveryNoteProcess pr = new DeliveryNoteProcess();                
                pr.DBCommand = objCmd;
                pr.DataIn = frmDeliveryNote.DataModel;

                pr.EditDeliveryNote();

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
