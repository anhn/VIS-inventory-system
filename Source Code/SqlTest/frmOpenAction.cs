using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SqlTest
{
    /// <summary>
    /// Summary description for frmOpenAction.
    /// </summary>
    public class frmOpenAction : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton btnOk;
        private SimpleButton btnCancel;
        private GroupControl groupControl1;
        private MemoEdit memoEdit2;
        private MemoEdit memoEdit1;
        private RadioButton rbReconfig;
        public RadioButton rbCreateReport;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmOpenAction()
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
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.memoEdit2 = new DevExpress.XtraEditors.MemoEdit();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.rbReconfig = new System.Windows.Forms.RadioButton();
            this.rbCreateReport = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(122, 217);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(74, 28);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "&Next";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnCancel.Location = new System.Drawing.Point(202, 217);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "&Cancel";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.memoEdit2);
            this.groupControl1.Controls.Add(this.memoEdit1);
            this.groupControl1.Controls.Add(this.rbReconfig);
            this.groupControl1.Controls.Add(this.rbCreateReport);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(266, 192);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "What do you want to do?";
            // 
            // memoEdit2
            // 
            this.memoEdit2.EditValue = "Edit existed report. You can also create report after config report.";
            this.memoEdit2.Location = new System.Drawing.Point(19, 129);
            this.memoEdit2.Name = "memoEdit2";
            this.memoEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.memoEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.memoEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.memoEdit2.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memoEdit2.Size = new System.Drawing.Size(240, 56);
            this.memoEdit2.TabIndex = 3;
            // 
            // memoEdit1
            // 
            this.memoEdit1.EditValue = "Create report using exists template. It uses all exists config to create new repo" +
                "rt.";
            this.memoEdit1.Location = new System.Drawing.Point(19, 44);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.memoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.memoEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.memoEdit1.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memoEdit1.Size = new System.Drawing.Size(240, 56);
            this.memoEdit1.TabIndex = 2;
            // 
            // rbReconfig
            // 
            this.rbReconfig.AutoSize = true;
            this.rbReconfig.Location = new System.Drawing.Point(7, 106);
            this.rbReconfig.Name = "rbReconfig";
            this.rbReconfig.Size = new System.Drawing.Size(100, 17);
            this.rbReconfig.TabIndex = 1;
            this.rbReconfig.Text = "Reconfig report";
            this.rbReconfig.UseVisualStyleBackColor = true;
            // 
            // rbCreateReport
            // 
            this.rbCreateReport.AutoSize = true;
            this.rbCreateReport.Checked = true;
            this.rbCreateReport.Location = new System.Drawing.Point(7, 21);
            this.rbCreateReport.Name = "rbCreateReport";
            this.rbCreateReport.Size = new System.Drawing.Size(94, 17);
            this.rbCreateReport.TabIndex = 0;
            this.rbCreateReport.TabStop = true;
            this.rbCreateReport.Text = "Create Report";
            this.rbCreateReport.UseVisualStyleBackColor = true;
            // 
            // frmOpenAction
            // 
            this.ClientSize = new System.Drawing.Size(289, 257);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOpenAction";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open";
            this.Load += new System.EventHandler(this.frmOpenAction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private void frmOpenAction_Load(object sender, EventArgs e)
        {
            rbCreateReport.Checked = true;
        }

    }
}

