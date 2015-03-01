using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Inventory.DataModels.SysInfos;
using Inventory.Process.SysInfos;

namespace Inventory.Commands.SysInfos
{
    public class EditSysInfosCommand : Command
    {
        public override void Execute()
        {
            SqlCommand objCmd = null;
            try
            {
                SysInfosModel sim = new SysInfosModel();
                sim.LoadDataFromDatabase();

                Inventory.Forms.SysInfo.SystemInformation frmInfo = new Inventory.Forms.SysInfo.SystemInformation();
                frmInfo.BindData(sim);
                if (DialogResult.Cancel == frmInfo.ShowDialog())
                {
                    return;
                }

                objCmd = NewSqlCommand();
                SysInfosProcess pr = new SysInfosProcess();
                pr.DBCommand = objCmd;
                pr.DataIn = frmInfo.DataModel;

                pr.EditSysInfos();

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
