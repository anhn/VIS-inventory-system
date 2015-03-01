using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using DevExpress.XtraEditors;

namespace Inventory.Forms.Data
{
    /// <summary>
    /// Summary description for ImportData.
    /// </summary>
    public class ImportData : DevExpress.XtraEditors.XtraForm
    {
        private Label label1;
        private ButtonEdit btnImportFrom;
        private RadioButton radStop;
        private RadioButton radSkip;
        private RadioButton radOverride;
        private SimpleButton btnClose;
        private SimpleButton btnImport;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public ImportData()
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnImportFrom = new DevExpress.XtraEditors.ButtonEdit();
            this.radStop = new System.Windows.Forms.RadioButton();
            this.radSkip = new System.Windows.Forms.RadioButton();
            this.radOverride = new System.Windows.Forms.RadioButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnImportFrom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Import From";
            // 
            // btnImportFrom
            // 
            this.btnImportFrom.Location = new System.Drawing.Point(95, 39);
            this.btnImportFrom.Name = "btnImportFrom";
            this.btnImportFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnImportFrom.Size = new System.Drawing.Size(247, 21);
            this.btnImportFrom.TabIndex = 5;
            this.btnImportFrom.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnImportFrom_ButtonClick);
            // 
            // radStop
            // 
            this.radStop.AutoSize = true;
            this.radStop.Checked = true;
            this.radStop.Location = new System.Drawing.Point(26, 148);
            this.radStop.Name = "radStop";
            this.radStop.Size = new System.Drawing.Size(121, 18);
            this.radStop.TabIndex = 10;
            this.radStop.TabStop = true;
            this.radStop.Text = "Stop If Data Exist";
            this.radStop.UseVisualStyleBackColor = true;
            // 
            // radSkip
            // 
            this.radSkip.AutoSize = true;
            this.radSkip.Location = new System.Drawing.Point(26, 125);
            this.radSkip.Name = "radSkip";
            this.radSkip.Size = new System.Drawing.Size(121, 18);
            this.radSkip.TabIndex = 9;
            this.radSkip.Text = "Skip Existing Data";
            this.radSkip.UseVisualStyleBackColor = true;
            // 
            // radOverride
            // 
            this.radOverride.AutoSize = true;
            this.radOverride.Location = new System.Drawing.Point(26, 102);
            this.radOverride.Name = "radOverride";
            this.radOverride.Size = new System.Drawing.Size(145, 18);
            this.radOverride.TabIndex = 8;
            this.radOverride.Text = "Override Existing Data";
            this.radOverride.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(215, 189);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(109, 189);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 11;
            this.btnImport.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // ImportData
            // 
            this.AcceptButton = this.btnImport;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(394, 234);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.radStop);
            this.Controls.Add(this.radSkip);
            this.Controls.Add(this.radOverride);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImportFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ImportData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Data";
            ((System.ComponentModel.ISupportInitialize)(this.btnImportFrom.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private XmlDocument xmlDoc = new XmlDocument();

        public XmlDocument XmlDoc
        {
            get { return xmlDoc; }
        }

        /// <summary>
        /// 2: override exist data, 1: skip exist data, 0 (is default): stop.
        /// </summary>
        public int ImportType
        {
            get
            {
                if (radOverride.Checked)
                {
                    return 2;
                }
                else if (radSkip.Checked)
                {
                    return 1;
                }

                return 0;
            }
        }

        private void btnImportFrom_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Exported Xml (*.xml)|*.xml|All files (*.*)|*.*";
            DialogResult dlgResult = dlgOpen.ShowDialog();
            if (dlgResult == DialogResult.Cancel)
            {
                return;
            }

            btnImportFrom.Text = dlgOpen.FileName;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (!this.ValidateData())
            {
                return;
            }

            xmlDoc = new XmlDocument();
            xmlDoc.Load(btnImportFrom.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool ValidateData()
        {
            if (btnImportFrom.Text == "")
            {
                MessageBox.Show("Please select a data file to Import.");
                btnImportFrom.Focus();
                return false;
            }

            if (radOverride.Checked == false && radSkip.Checked == false && radStop.Checked == false)
            {
                MessageBox.Show("Please select a type of Import.");
                return false;
            }

            return true;
        }
    }
}

