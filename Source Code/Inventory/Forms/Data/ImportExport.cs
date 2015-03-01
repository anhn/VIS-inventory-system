using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Inventory.Forms.Data
{
    /// <summary>
    /// Summary description for ImportExport.
    /// </summary>
    public class ImportExport : DevExpress.XtraEditors.XtraForm
    {
        private TextEdit txtFile;
        private Label label1;
        private SimpleButton btnBrowse;
        private RadioGroup grpType;
        private Label label2;
        private SimpleButton btnOK;

        private bool isImport = true;
        private SimpleButton btnCancel;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public ImportExport(bool isImport)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            this.isImport = isImport;
            if (isImport)
            {
                this.Text = "Import";
                btnOK.Text = "Import";
            }
            else
            {
                this.Text = "Export";
                btnOK.Text = "Export";
            }

            grpType.SelectedIndex = 0;
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
            this.txtFile = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.grpType = new DevExpress.XtraEditors.RadioGroup();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(86, 101);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(254, 20);
            this.txtFile.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Select File:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(346, 101);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(35, 20);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "...";
            // 
            // grpType
            // 
            this.grpType.Location = new System.Drawing.Point(85, 18);
            this.grpType.Name = "grpType";
            this.grpType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.grpType.Properties.Appearance.Options.UseBackColor = true;
            this.grpType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "CVS"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Excel"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Microsoft Access"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Xml")});
            this.grpType.Size = new System.Drawing.Size(295, 65);
            this.grpType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Select Type:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(141, 138);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(71, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(233, 138);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ImportExport
            // 
            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(401, 168);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ImportExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Export";
            ((System.ComponentModel.ISupportInitialize)(this.txtFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}

