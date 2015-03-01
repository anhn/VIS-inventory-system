using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Forms.Warehouse;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using Inventory.DataModels.Warehouse;
using Inventory.Process.Warehouse;
using System.Data.SqlClient;

namespace Inventory.Commands
{
    public class NewDeliveryNoteCommand:Command
    {        
        #region Command Members

        public override void  Execute()
        {
            SqlCommand objCmd = null;            
            
            try
            {
                DeliveryNotes dlgNewNote = new DeliveryNotes();
                dlgNewNote.BindData(null);

                if (DialogResult.Cancel == dlgNewNote.ShowDialog())
                {
                    return;
                }

                objCmd = NewSqlCommand();
                DeliveryNoteModel dm = dlgNewNote.DataModel;

                DeliveryNoteProcess pr = new DeliveryNoteProcess();

                pr.DBCommand = objCmd;
                pr.DataIn = dm;

                pr.NewDeliveryNote();

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

        #endregion
    }
}
