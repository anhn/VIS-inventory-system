using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Inventory.Forms.StockTake
{
    public partial class ReportVariance : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportVariance()
        {
            InitializeComponent();
        }

        public void SetPhysicalTakeName(String strPhysicalTakeName)
        {
            this.xrLblStockTakeName.Text = strPhysicalTakeName;
        }
    }
}
