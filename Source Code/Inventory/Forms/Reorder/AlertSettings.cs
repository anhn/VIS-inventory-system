using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Inventory.DataModels.Reorder;

namespace Inventory.Forms.Reorder
{
    /// <summary>
    /// Summary description for AlertSettings.
    /// </summary>
    public class AlertSettings : DevExpress.XtraEditors.XtraForm
    {
        private TextEdit txtCheckFreq;
        private Label label2;
        private Label label1;
        private TextEdit txtDaysExpire;
        private Label label3;
        private TextEdit txtKeepAlert;
        private Label label4;
        private SimpleButton btnClose;
        private SimpleButton btnSave;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private AlertSettingsModel model = new AlertSettingsModel();

        public AlertSettingsModel DataModel
        {
            get { return model; }
            set { model = value; }
        }

        public AlertSettings()
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
            this.txtCheckFreq = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDaysExpire = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKeepAlert = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtCheckFreq.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaysExpire.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeepAlert.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCheckFreq
            // 
            this.txtCheckFreq.Location = new System.Drawing.Point(122, 44);
            this.txtCheckFreq.Name = "txtCheckFreq";
            this.txtCheckFreq.Size = new System.Drawing.Size(171, 20);
            this.txtCheckFreq.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Check Frequency:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Days before expire:";
            // 
            // txtDaysExpire
            // 
            this.txtDaysExpire.Location = new System.Drawing.Point(122, 84);
            this.txtDaysExpire.Name = "txtDaysExpire";
            this.txtDaysExpire.Size = new System.Drawing.Size(171, 20);
            this.txtDaysExpire.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Days to keep Alert:";
            // 
            // txtKeepAlert
            // 
            this.txtKeepAlert.Location = new System.Drawing.Point(122, 123);
            this.txtKeepAlert.Name = "txtKeepAlert";
            this.txtKeepAlert.Size = new System.Drawing.Size(171, 20);
            this.txtKeepAlert.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Settings for Reorder and Expire date alerts:";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(171, 165);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(61, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AlertSettings
            // 
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(305, 200);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtKeepAlert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDaysExpire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCheckFreq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AlertSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alert Settings";
            ((System.ComponentModel.ISupportInitialize)(this.txtCheckFreq.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaysExpire.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeepAlert.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        internal void BindData(AlertSettingsModel objModel)
        {
            if (objModel == null)
            {
                model = new AlertSettingsModel();
            }
            else
            {
                model = objModel;
            }

            txtCheckFreq.Text = objModel.CheckFrequency.ToString();
            txtDaysExpire.Text = objModel.DaysBeforeExpire.ToString();
            txtKeepAlert.Text = objModel.DaysKeepAlert.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.Validate())
            {
                return;
            }

            this.ReadToDataModel();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool Validate()
        {
            int result;
            if (!int.TryParse(txtCheckFreq.Text, out result) || result < 0)
            {
                MessageBox.Show("The value of Check Frequencey must be a postivie integer.", "Error");
                txtCheckFreq.Focus();
                return false;
            }

            if (!int.TryParse(txtDaysExpire.Text, out result) || result < 0)
            {
                MessageBox.Show("The value of Days Before Expire must be a postivie integer.", "Error");
                txtDaysExpire.Focus();
                return false;
            }
            if (!int.TryParse(txtKeepAlert.Text, out result) || result < 0)
            {
                MessageBox.Show("The value of Days to Keep Alert must be a postivie integer.", "Error");
                txtKeepAlert.Focus();
                return false;
            }
            return true;
        }

        private void ReadToDataModel()
        {
            model.CheckFrequency = Convert.ToInt32(txtCheckFreq.Text);
            model.DaysBeforeExpire = Convert.ToInt32(txtDaysExpire.Text);
            model.DaysKeepAlert = Convert.ToInt32(txtKeepAlert.Text);
        }
    }
}

