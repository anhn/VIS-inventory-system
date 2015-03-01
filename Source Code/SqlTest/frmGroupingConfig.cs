using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;

namespace SqlTest
{
    /// <summary>
    /// Summary description for frmGroupingConfig.
    /// </summary>
    public class frmGroupingConfig : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton btnBack;
        private SimpleButton btnOk;
        private SimpleButton btnCancel;
        private Label label1;
        private GroupControl grLayout;
        public RadioButton rdBlock;
        public RadioButton rdStepped;
        private PictureEdit ptLogo;
        public RadioButton rdSeparate;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmGroupingConfig()
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
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grLayout = new DevExpress.XtraEditors.GroupControl();
            this.rdSeparate = new System.Windows.Forms.RadioButton();
            this.rdBlock = new System.Windows.Forms.RadioButton();
            this.rdStepped = new System.Windows.Forms.RadioButton();
            this.ptLogo = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grLayout)).BeginInit();
            this.grLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnBack.Location = new System.Drawing.Point(63, 220);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 28);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "&Back";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(143, 220);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(74, 28);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "&Next";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnCancel.Location = new System.Drawing.Point(223, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "&Cancel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Which layout do you want to create in grouping?";
            // 
            // grLayout
            // 
            this.grLayout.Controls.Add(this.rdSeparate);
            this.grLayout.Controls.Add(this.rdBlock);
            this.grLayout.Controls.Add(this.rdStepped);
            this.grLayout.Location = new System.Drawing.Point(20, 43);
            this.grLayout.Name = "grLayout";
            this.grLayout.Size = new System.Drawing.Size(115, 158);
            this.grLayout.TabIndex = 19;
            this.grLayout.Text = "Layout";
            // 
            // rdSeparate
            // 
            this.rdSeparate.AutoSize = true;
            this.rdSeparate.Location = new System.Drawing.Point(24, 116);
            this.rdSeparate.Name = "rdSeparate";
            this.rdSeparate.Size = new System.Drawing.Size(69, 17);
            this.rdSeparate.TabIndex = 22;
            this.rdSeparate.Text = "Separate";
            this.rdSeparate.UseVisualStyleBackColor = true;
            // 
            // rdBlock
            // 
            this.rdBlock.AutoSize = true;
            this.rdBlock.Location = new System.Drawing.Point(24, 82);
            this.rdBlock.Name = "rdBlock";
            this.rdBlock.Size = new System.Drawing.Size(49, 17);
            this.rdBlock.TabIndex = 21;
            this.rdBlock.Text = "Block";
            this.rdBlock.UseVisualStyleBackColor = true;
            this.rdBlock.CheckedChanged += new System.EventHandler(this.rdBlock_CheckedChanged);
            // 
            // rdStepped
            // 
            this.rdStepped.AutoSize = true;
            this.rdStepped.Checked = true;
            this.rdStepped.Location = new System.Drawing.Point(24, 47);
            this.rdStepped.Name = "rdStepped";
            this.rdStepped.Size = new System.Drawing.Size(65, 17);
            this.rdStepped.TabIndex = 20;
            this.rdStepped.TabStop = true;
            this.rdStepped.Text = "Stepped";
            this.rdStepped.UseVisualStyleBackColor = true;
            this.rdStepped.CheckedChanged += new System.EventHandler(this.rdBlock_CheckedChanged);
            // 
            // ptLogo
            // 
            this.ptLogo.Location = new System.Drawing.Point(151, 43);
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ptLogo.Size = new System.Drawing.Size(147, 158);
            this.ptLogo.TabIndex = 20;
            // 
            // frmGroupingConfig
            // 
            this.ClientSize = new System.Drawing.Size(318, 260);
            this.Controls.Add(this.ptLogo);
            this.Controls.Add(this.grLayout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGroupingConfig";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grouping Configuration";
            this.Load += new System.EventHandler(this.frmGroupingConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grLayout)).EndInit();
            this.grLayout.ResumeLayout(false);
            this.grLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void frmGroupingConfig_Load(object sender, EventArgs e)
        {
            rdBlock_CheckedChanged(sender, e);
        }

        private void rdBlock_CheckedChanged(object sender, EventArgs e)
        {
            string filename = Application.StartupPath + "\\Layout\\";
            if (rdBlock.Checked)
            {
                filename += "Block.jpg";
            }
            else if (rdStepped.Checked)
            {
                filename += "Stepped.jpg";
            }
            else
            {
                filename += "Separate.jpg";
            }
            if (System.IO.File.Exists(filename))
            {
                ptLogo.Image = Image.FromFile(filename);
            }
            else
            {
                ptLogo.Image = null;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            frmTemplateSelection frm = (Tag as frmMain).fTemplateSelection;
            try
            {
                frm.TabularTemplate((Tag as frmMain).fFilterPreview.grMain.DataSource as DataTable, (Tag as frmMain).fPredictionPreview.dt);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating report");
            }
        }
    }
}