using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Forms.Warehouse;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using Inventory.DataModels.StockTake;
using Inventory.Process.StockTake;
using Inventory.Forms.StockTake;
using System.Data.SqlClient;

namespace Inventory.Commands.StockTake
{
    public class NewPhysicalTakeCommand : Command
    {
        #region Command Members

        public override void Execute()
        {
            SqlCommand objCmd = null;

            try
            {
                PhysicalTake dlgPhysicalTake = new PhysicalTake();
                dlgPhysicalTake.BindData(null);

                if (DialogResult.Cancel == dlgPhysicalTake.ShowDialog())
                {
                    return;
                }

                objCmd = NewSqlCommand();
                PhysicalTakeModel dm = dlgPhysicalTake.DataModel;

                PhysicalTakeProcess pr = new PhysicalTakeProcess();

                pr.DBCommand = objCmd;
                pr.DataIn = dm;

                pr.NewPhysicalTake();

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
