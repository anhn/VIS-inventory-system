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
using System.Data;

namespace Inventory.Commands.StockTake
{
    public class ClosePeriodCommand : Command
    {
        public override void Execute()
        {
            SqlCommand objCmd = null;
            try
            {
                PeriodClosing frmPeriodClosing = new PeriodClosing();
                frmPeriodClosing.BindData(null);
                if (DialogResult.Cancel == frmPeriodClosing.ShowDialog())
                {
                    return;
                }

                objCmd = NewSqlCommand();
                PeriodClosingProcess pr = new PeriodClosingProcess();
                pr.DBCommand = objCmd;
                pr.DataIn = frmPeriodClosing.DataModel;
                pr.ClosePeriod();

                objCmd.Transaction.Commit();
                MessageBox.Show(Constants.Message.PeriodClosing_Success, Constants.Message.MessageTitle);
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
            }
        }
    }
}
