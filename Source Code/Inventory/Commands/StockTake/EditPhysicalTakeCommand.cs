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
    public class EditPhysicalTakeCommand : Command
    {
        private string strID = string.Empty;

        public string PhysicalTakeId
        {
            set { strID = value; }
        }

        public override void Execute()
        {
            SqlCommand objCmd = null;
            try
            {
                PhysicalTakeModel dm = new PhysicalTakeModel();
                dm.ID = strID;
                dm.LoadDataFromDataBase();

                PhysicalTake frmPhysicalTake = new PhysicalTake();
                frmPhysicalTake.BindData(dm);
                if (DialogResult.Cancel == frmPhysicalTake.ShowDialog())
                {
                    return;
                }

                objCmd = NewSqlCommand();
                PhysicalTakeProcess pr = new PhysicalTakeProcess();
                pr.DBCommand = objCmd;
                pr.DataIn = frmPhysicalTake.DataModel;

                pr.EditPhysicalTake();

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
