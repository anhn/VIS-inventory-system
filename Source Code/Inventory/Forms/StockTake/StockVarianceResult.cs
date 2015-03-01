using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Inventory.Forms.StockTake
{
    /// <summary>
    /// Summary description for StockVarianceResult.
    /// </summary>
    public class StockVarianceResult : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = new Container();

        public StockVarianceResult()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // StockVarianceResult
            // 
            this.ClientSize = new System.Drawing.Size(487, 374);
            this.Name = "StockVarianceResult";
            this.Text = "Print Variance Result";
            this.ResumeLayout(false);

        }
        #endregion
    }
}

