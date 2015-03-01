using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Inventory.DataModels.Reorder;
using Inventory.Process.Reorder;

namespace Inventory.Commands.Reorder
{
    public class EditAlertSettingsCommand : Command
    {
        public override void Execute()
        {
            SqlCommand objCmd = null;
            try
            {
                AlertSettingsModel am = new AlertSettingsModel();
                am.LoadDataFromDatabase();

                Forms.Reorder.AlertSettings frmAlert = new Inventory.Forms.Reorder.AlertSettings();
                frmAlert.BindData(am);
                if (DialogResult.Cancel == frmAlert.ShowDialog())
                {
                    return;
                }

                objCmd = NewSqlCommand();
                AlertSettingsProcess pr = new AlertSettingsProcess();
                pr.DBCommand = objCmd;
                pr.DataIn = frmAlert.DataModel;

                pr.EditAlertSettings();

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
