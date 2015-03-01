using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Windows.Forms;
using Inventory.Forms.Data;
using Inventory.Process.Data;

namespace Inventory.Commands.Data
{
    public class PurgeCommand : Command
    {
        public override void Execute()
        {
            SqlCommand objCmd = null;
            try
            {
                PurgeData frmPurge = new PurgeData();
                if (DialogResult.Cancel == frmPurge.ShowDialog()) return;
                
                objCmd = NewSqlCommand();

                PurgeDataProcess pr = new PurgeDataProcess();
                pr.DBCommand = objCmd;

                frmPurge.ExecutePurgeData(pr);

                objCmd.Transaction.Commit();
                MessageBox.Show(Constants.Message.PurgeData_Success, Constants.Message.MessageTitle);
            }
            catch (Exception ex)
            {
                string strMessage = ex.Message;
                while (ex.InnerException != null)
                {
                    strMessage += Environment.NewLine + ex.InnerException.Message;
                    ex = ex.InnerException;
                }
                MessageBox.Show(strMessage);

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
