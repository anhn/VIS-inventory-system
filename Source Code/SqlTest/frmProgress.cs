using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SqlTest
{
    /// <summary>
    /// Summary description for frmProgress.
    /// </summary>
    public class frmProgress : DevExpress.XtraEditors.XtraForm
    {
        public ProgressBarControl proMain;
        private Label label1;
        public Label lblAction;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmProgress()
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
            this.proMain = new DevExpress.XtraEditors.ProgressBarControl();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proMain.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // proMain
            // 
            this.proMain.Location = new System.Drawing.Point(21, 12);
            this.proMain.Name = "proMain";
            this.proMain.Size = new System.Drawing.Size(393, 20);
            this.proMain.TabIndex = 0;
            this.proMain.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current action:";
            // 
            // lblAction
            // 
            this.lblAction.Location = new System.Drawing.Point(110, 48);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(304, 36);
            this.lblAction.TabIndex = 2;
            this.lblAction.Text = "No action.";
            // 
            // frmProgress
            // 
            this.ClientSize = new System.Drawing.Size(436, 93);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProgress";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progress";
            ((System.ComponentModel.ISupportInitialize)(this.proMain.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}

