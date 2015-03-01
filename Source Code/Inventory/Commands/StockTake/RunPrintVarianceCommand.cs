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
    public class RunPrintVarianceCommand : Command
    {
        private string strID = string.Empty;

        public string PhysicalTakeId
        {
            set { strID = value; }
        }

        public override void Execute()
        {
            
            try
            {
                StockVariance frmStockVar = new StockVariance();
                frmStockVar.BindData();
                if (DialogResult.Cancel == frmStockVar.ShowDialog())
                {
                    return;
                }
                
                StockVarianceProcess pr = new StockVarianceProcess();                
                pr.DataIn = frmStockVar.DataModel;
                DataTable dtVariance = pr.Run();
                ReportVariance rptVariance = new ReportVariance();
                rptVariance.DataSource = dtVariance;
                rptVariance.SetPhysicalTakeName(frmStockVar.DataModel.Name);
                rptVariance.ShowPreview();                
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
