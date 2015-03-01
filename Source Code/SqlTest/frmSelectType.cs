using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SqlTest
{
    /// <summary>
    /// Summary description for frmSelectType.
    /// </summary>
    public class frmSelectType : DevExpress.XtraEditors.XtraForm
    {
        public RadioButton rbTemplate;
        private RadioButton rbIDE;
        private GroupControl groupControl1;
        private MemoEdit memoEdit1;
        private MemoEdit memoEdit2;
        private SimpleButton btnBack;
        private SimpleButton btnOk;
        private SimpleButton btnCancel;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmSelectType()
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
            this.rbTemplate = new System.Windows.Forms.RadioButton();
            this.rbIDE = new System.Windows.Forms.RadioButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.memoEdit2 = new DevExpress.XtraEditors.MemoEdit();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // rbTemplate
            // 
            this.rbTemplate.AutoSize = true;
            this.rbTemplate.Checked = true;
            this.rbTemplate.Location = new System.Drawing.Point(7, 21);
            this.rbTemplate.Name = "rbTemplate";
            this.rbTemplate.Size = new System.Drawing.Size(130, 17);
            this.rbTemplate.TabIndex = 0;
            this.rbTemplate.TabStop = true;
            this.rbTemplate.Text = "Create from Template";
            this.rbTemplate.UseVisualStyleBackColor = true;
            // 
            // rbIDE
            // 
            this.rbIDE.AutoSize = true;
            this.rbIDE.Location = new System.Drawing.Point(7, 106);
            this.rbIDE.Name = "rbIDE";
            this.rbIDE.Size = new System.Drawing.Size(142, 17);
            this.rbIDE.TabIndex = 1;
            this.rbIDE.Text = "Create using Report IDE";
            this.rbIDE.UseVisualStyleBackColor = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.memoEdit2);
            this.groupControl1.Controls.Add(this.memoEdit1);
            this.groupControl1.Controls.Add(this.rbIDE);
            this.groupControl1.Controls.Add(this.rbTemplate);
            this.groupControl1.Location = new System.Drawing.Point(14, 21);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(266, 192);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Select one radiobox bellow";
            // 
            // memoEdit2
            // 
            this.memoEdit2.EditValue = "Create report using exists template. It\'s easy to use, it will help you create re" +
                "port step by step.\r\nYou only using your mouse and click, click...";
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
            this.memoEdit1.EditValue = "Create report using exists template. It\'s easy to use, it will help you create re" +
                "port step by step.\r\nYou only using your mouse and click, click...";
            this.memoEdit1.Location = new System.Drawing.Point(19, 44);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.memoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.memoEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.memoEdit1.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memoEdit1.Size = new System.Drawing.Size(240, 56);
            this.memoEdit1.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnBack.Location = new System.Drawing.Point(30, 224);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 28);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "&Back";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(110, 224);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(74, 28);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "&Next";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnCancel.Location = new System.Drawing.Point(190, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            // 
            // frmSelectType
            // 
            this.ClientSize = new System.Drawing.Size(292, 264);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select the way to create report";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (rbTemplate.Checked) DialogResult = DialogResult.Yes;
            else
            {
                MessageBox.Show("Not avaiable this time");
                return;
                //DialogResult = DialogResult.No;
            }
        }
    }
}

