using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace SqlTest
{
    /// <summary>
    /// Summary description for frmReportDetails.
    /// </summary>
    public class frmReportDetails : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton btnCancel;
        private SimpleButton btnNext;
        private Label label1;
        public TextEdit txtCompanyLogo;
        private SimpleButton btnBrowser;
        private Label label2;
        public TextEdit txtTitle;
        private GroupControl groupControl1;
        private PictureEdit ptLogo;
        private Label label5;
        private GroupControl groupControl2;
        public TextEdit txtFooter;
        private Label label3;
        public TextEdit txtHeader;
        private Label label4;
        private OpenFileDialog openDlg;
        private Label label6;
        public TextEdit txtCaption;
        private Label label7;
        private SimpleButton btnDate;
        private Label label9;
        private Label label8;
        public ComboBoxEdit cbHeaderAlign;
        public ComboBoxEdit cbFooterAlign;
        private GroupControl groupControl3;
        public RadioButton rdPortrait;
        public RadioButton rdLandscape;
        public ComboBoxEdit cbPageNumberPos;
        private Label label10;
        public ComboBoxEdit cbPageNumberAlign;
        private Label label11;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmReportDetails()
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompanyLogo = new DevExpress.XtraEditors.TextEdit();
            this.btnBrowser = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtCaption = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.ptLogo = new DevExpress.XtraEditors.PictureEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbHeaderAlign = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbFooterAlign = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnDate = new DevExpress.XtraEditors.SimpleButton();
            this.txtFooter = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeader = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.openDlg = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.rdPortrait = new System.Windows.Forms.RadioButton();
            this.rdLandscape = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cbPageNumberPos = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.cbPageNumberAlign = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbHeaderAlign.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFooterAlign.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFooter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPageNumberPos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPageNumberAlign.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnCancel.Location = new System.Drawing.Point(551, 439);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNext.Location = new System.Drawing.Point(468, 439);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(77, 28);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "&Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Company Logo:";
            // 
            // txtCompanyLogo
            // 
            this.txtCompanyLogo.Location = new System.Drawing.Point(56, 50);
            this.txtCompanyLogo.Name = "txtCompanyLogo";
            this.txtCompanyLogo.Size = new System.Drawing.Size(332, 20);
            this.txtCompanyLogo.TabIndex = 5;
            this.txtCompanyLogo.EditValueChanged += new System.EventHandler(this.txtCompanyLogo_EditValueChanged);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(394, 50);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(68, 23);
            this.btnBrowser.TabIndex = 6;
            this.btnBrowser.Text = "&Browse...";
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(56, 102);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(406, 20);
            this.txtTitle.TabIndex = 8;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtCaption);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.ptLogo);
            this.groupControl1.Controls.Add(this.txtTitle);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.btnBrowser);
            this.groupControl1.Controls.Add(this.txtCompanyLogo);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(12, 41);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(621, 193);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Report Title and Company Logo";
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(56, 151);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(406, 20);
            this.txtCaption.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Caption:";
            // 
            // ptLogo
            // 
            this.ptLogo.Location = new System.Drawing.Point(477, 48);
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ptLogo.Size = new System.Drawing.Size(129, 123);
            this.ptLogo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "*Note: You can also edit this later.";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cbPageNumberAlign);
            this.groupControl2.Controls.Add(this.label11);
            this.groupControl2.Controls.Add(this.cbPageNumberPos);
            this.groupControl2.Controls.Add(this.label10);
            this.groupControl2.Controls.Add(this.label9);
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Controls.Add(this.cbHeaderAlign);
            this.groupControl2.Controls.Add(this.cbFooterAlign);
            this.groupControl2.Controls.Add(this.btnDate);
            this.groupControl2.Controls.Add(this.txtFooter);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.txtHeader);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Location = new System.Drawing.Point(12, 255);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(621, 162);
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "Report Header and Footer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(436, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Alignment:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Alignment:";
            // 
            // cbHeaderAlign
            // 
            this.cbHeaderAlign.EditValue = "Left";
            this.cbHeaderAlign.Location = new System.Drawing.Point(510, 42);
            this.cbHeaderAlign.Name = "cbHeaderAlign";
            this.cbHeaderAlign.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbHeaderAlign.Properties.Items.AddRange(new object[] {
            "Left",
            "Center",
            "Right"});
            this.cbHeaderAlign.Size = new System.Drawing.Size(100, 25);
            this.cbHeaderAlign.TabIndex = 12;
            // 
            // cbFooterAlign
            // 
            this.cbFooterAlign.EditValue = "Left";
            this.cbFooterAlign.Location = new System.Drawing.Point(510, 83);
            this.cbFooterAlign.Name = "cbFooterAlign";
            this.cbFooterAlign.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFooterAlign.Properties.Items.AddRange(new object[] {
            "Left",
            "Center",
            "Right"});
            this.cbFooterAlign.Size = new System.Drawing.Size(100, 25);
            this.cbFooterAlign.TabIndex = 14;
            // 
            // btnDate
            // 
            this.btnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDate.Location = new System.Drawing.Point(37, 122);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(77, 28);
            this.btnDate.TabIndex = 10;
            this.btnDate.Text = "#Date";
            this.btnDate.Click += new System.EventHandler(this.btnPage_Click);
            // 
            // txtFooter
            // 
            this.txtFooter.Location = new System.Drawing.Point(37, 88);
            this.txtFooter.Name = "txtFooter";
            this.txtFooter.Size = new System.Drawing.Size(382, 20);
            this.txtFooter.TabIndex = 8;
            this.txtFooter.Enter += new System.EventHandler(this.txtFooter_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Footer";
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(37, 44);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(382, 20);
            this.txtHeader.TabIndex = 5;
            this.txtHeader.Enter += new System.EventHandler(this.txtHeader_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Header:";
            // 
            // openDlg
            // 
            this.openDlg.Filter = "All Supported File (*.bmp; *.ico; *.jpg; *.jpeg)|*.bmp; *.ico; *.jpg; *.jpeg|All " +
                "Files (*.*)|*.*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(610, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Welcome to New Report Wizard. This wizard will help you  create the report step b" +
                "y step. First thing, please fill following item.";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.rdPortrait);
            this.groupControl3.Controls.Add(this.rdLandscape);
            this.groupControl3.Location = new System.Drawing.Point(12, 423);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(240, 53);
            this.groupControl3.TabIndex = 23;
            this.groupControl3.Text = "Page Setup";
            // 
            // rdPortrait
            // 
            this.rdPortrait.AutoSize = true;
            this.rdPortrait.Checked = true;
            this.rdPortrait.Location = new System.Drawing.Point(160, 21);
            this.rdPortrait.Name = "rdPortrait";
            this.rdPortrait.Size = new System.Drawing.Size(61, 17);
            this.rdPortrait.TabIndex = 1;
            this.rdPortrait.TabStop = true;
            this.rdPortrait.Text = "Portrait";
            this.rdPortrait.UseVisualStyleBackColor = true;
            // 
            // rdLandscape
            // 
            this.rdLandscape.AutoSize = true;
            this.rdLandscape.Location = new System.Drawing.Point(17, 21);
            this.rdLandscape.Name = "rdLandscape";
            this.rdLandscape.Size = new System.Drawing.Size(76, 17);
            this.rdLandscape.TabIndex = 0;
            this.rdLandscape.Text = "Landscape";
            this.rdLandscape.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "PageNumber Position:";
            // 
            // cbPageNumberPos
            // 
            this.cbPageNumberPos.EditValue = "Don\'t have";
            this.cbPageNumberPos.Location = new System.Drawing.Point(319, 124);
            this.cbPageNumberPos.Name = "cbPageNumberPos";
            this.cbPageNumberPos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPageNumberPos.Properties.Items.AddRange(new object[] {
            "Don\'t have",
            "Header",
            "Footer"});
            this.cbPageNumberPos.Size = new System.Drawing.Size(100, 25);
            this.cbPageNumberPos.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(436, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Alignment:";
            // 
            // cbPageNumberAlign
            // 
            this.cbPageNumberAlign.EditValue = "Left";
            this.cbPageNumberAlign.Location = new System.Drawing.Point(510, 122);
            this.cbPageNumberAlign.Name = "cbPageNumberAlign";
            this.cbPageNumberAlign.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPageNumberAlign.Properties.Items.AddRange(new object[] {
            "Left",
            "Center",
            "Right"});
            this.cbPageNumberAlign.Size = new System.Drawing.Size(100, 25);
            this.cbPageNumberAlign.TabIndex = 20;
            // 
            // frmReportDetails
            // 
            this.ClientSize = new System.Drawing.Size(645, 488);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Report Wizard";
            this.Load += new System.EventHandler(this.frmReportDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbHeaderAlign.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFooterAlign.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFooter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPageNumberPos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPageNumberAlign.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void txtCompanyLogo_EditValueChanged(object sender, EventArgs e)
        {
            if (File.Exists(txtCompanyLogo.Text.Trim()))
            {
                try
                {
                    ptLogo.Image = Image.FromFile(txtCompanyLogo.Text.Trim());
                }
                catch (Exception ex)
                {
                    ptLogo.Image = null;
                    if (txtCompanyLogo.Focused || !this.Visible) return;
                    MessageBox.Show("Can not load image from this file.");
                }
            }
            else
            {
                ptLogo.Image = null;
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                txtCompanyLogo.Text = openDlg.FileName;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void frmReportDetails_Load(object sender, EventArgs e)
        {

        }
        private int inputHeader = 0;
        public bool callFromTemplateSelection = false;

        private void btnPage_Click(object sender, EventArgs e)
        {
            if (inputHeader == 1)
            {
                txtHeader.Text += "[" + (sender as SimpleButton).Text + "]";
            }
            else if (inputHeader == 2)
            {
                txtFooter.Text += "[" + (sender as SimpleButton).Text + "]";
            }
            else
                MessageBox.Show("Only can add to header and footer!");
        }

        private void txtHeader_Enter(object sender, EventArgs e)
        {
            inputHeader = 1;
        }

        private void txtFooter_Enter(object sender, EventArgs e)
        {
            inputHeader = 2;
        }
    }
}

