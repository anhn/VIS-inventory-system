using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;

namespace Inventory
{
    /// <summary>
    /// Summary description for frmAddEditPackageTypeMaster.
    /// </summary>
    public class frmAddEditPackageTypeMaster : DevExpress.XtraEditors.XtraForm
    {
        private TextEdit txtName;
        private Label label2;
        private TextEdit txtMWeight;
        private Label label1;
        private TextEdit txtMLength;
        private Label label3;
        private TextEdit txtMHeight;
        private Label label4;
        private TextEdit txtMWidth;
        private Label label5;
        private TextEdit txtStorageVolume;
        private Label label6;
        private CheckEdit chkViewStatus;
        private Label label7;
        private SimpleButton btnClose;
        private SimpleButton bnOK;
        private GroupControl grpNameAddress;
        private ButtonEdit bteCategory;
        private Label lblCategory;
        private GroupControl groupControl1;
        private ButtonEdit buttonEdit1;
        private Label label8;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmAddEditPackageTypeMaster()
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
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMWeight = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMLength = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMHeight = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMWidth = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStorageVolume = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.chkViewStatus = new DevExpress.XtraEditors.CheckEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.bnOK = new DevExpress.XtraEditors.SimpleButton();
            this.grpNameAddress = new DevExpress.XtraEditors.GroupControl();
            this.bteCategory = new DevExpress.XtraEditors.ButtonEdit();
            this.lblCategory = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStorageVolume.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNameAddress)).BeginInit();
            this.grpNameAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(30, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // txtMWeight
            // 
            this.txtMWeight.Location = new System.Drawing.Point(114, 101);
            this.txtMWeight.Name = "txtMWeight";
            this.txtMWeight.Size = new System.Drawing.Size(100, 21);
            this.txtMWeight.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(30, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Max Weight";
            // 
            // txtMLength
            // 
            this.txtMLength.Location = new System.Drawing.Point(350, 101);
            this.txtMLength.Name = "txtMLength";
            this.txtMLength.Size = new System.Drawing.Size(100, 21);
            this.txtMLength.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(251, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Max Length";
            // 
            // txtMHeight
            // 
            this.txtMHeight.Location = new System.Drawing.Point(114, 133);
            this.txtMHeight.Name = "txtMHeight";
            this.txtMHeight.Size = new System.Drawing.Size(100, 21);
            this.txtMHeight.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(30, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Max Height";
            // 
            // txtMWidth
            // 
            this.txtMWidth.Location = new System.Drawing.Point(350, 133);
            this.txtMWidth.Name = "txtMWidth";
            this.txtMWidth.Size = new System.Drawing.Size(100, 21);
            this.txtMWidth.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(251, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "Max Width";
            // 
            // txtStorageVolume
            // 
            this.txtStorageVolume.Location = new System.Drawing.Point(350, 35);
            this.txtStorageVolume.Name = "txtStorageVolume";
            this.txtStorageVolume.Size = new System.Drawing.Size(100, 21);
            this.txtStorageVolume.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(249, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "Storage Volume";
            // 
            // chkViewStatus
            // 
            this.chkViewStatus.Location = new System.Drawing.Point(111, 176);
            this.chkViewStatus.Name = "chkViewStatus";
            this.chkViewStatus.Properties.Caption = "";
            this.chkViewStatus.Size = new System.Drawing.Size(75, 19);
            this.chkViewStatus.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(30, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "View Status";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(375, 174);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bnOK
            // 
            this.bnOK.Location = new System.Drawing.Point(294, 174);
            this.bnOK.Name = "bnOK";
            this.bnOK.Size = new System.Drawing.Size(75, 23);
            this.bnOK.TabIndex = 16;
            this.bnOK.Text = "&Save";
            this.bnOK.Click += new System.EventHandler(this.bnOK_Click);
            // 
            // grpNameAddress
            // 
            this.grpNameAddress.Controls.Add(this.bteCategory);
            this.grpNameAddress.Controls.Add(this.lblCategory);
            this.grpNameAddress.Location = new System.Drawing.Point(12, 74);
            this.grpNameAddress.Name = "grpNameAddress";
            this.grpNameAddress.Size = new System.Drawing.Size(452, 89);
            this.grpNameAddress.TabIndex = 5;
            this.grpNameAddress.Text = "Configuration";
            // 
            // bteCategory
            // 
            this.bteCategory.EditValue = "";
            this.bteCategory.Location = new System.Drawing.Point(87, 391);
            this.bteCategory.Name = "bteCategory";
            this.bteCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteCategory.Size = new System.Drawing.Size(273, 21);
            this.bteCategory.TabIndex = 20;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(4, 392);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(60, 14);
            this.lblCategory.TabIndex = 63;
            this.lblCategory.Text = "Category:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.buttonEdit1);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Location = new System.Drawing.Point(12, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(452, 57);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "General";
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.EditValue = "";
            this.buttonEdit1.Location = new System.Drawing.Point(87, 391);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit1.Size = new System.Drawing.Size(273, 21);
            this.buttonEdit1.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 14);
            this.label8.TabIndex = 63;
            this.label8.Text = "Category:";
            // 
            // frmAddEditPackageTypeMaster
            // 
            this.ClientSize = new System.Drawing.Size(478, 209);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bnOK);
            this.Controls.Add(this.chkViewStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStorageVolume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMWidth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMHeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpNameAddress);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditPackageTypeMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Package Type";
            this.Load += new System.EventHandler(this.frmAddEditPackageTypeMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStorageVolume.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNameAddress)).EndInit();
            this.grpNameAddress.ResumeLayout(false);
            this.grpNameAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void frmAddEditPackageTypeMaster_Load(object sender, EventArgs e)
        {
            txtName.Select();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // confirm to save data
            DialogResult dlgResult = MessageBox.Show(Constants.Message.Save_Prompt, Constants.Message.MessageTitle, MessageBoxButtons.YesNo);
            if (dlgResult == DialogResult.Yes)
            {
                bnOK_Click(bnOK, EventArgs.Empty);
            }
            else
            {
                this.Close();
            }
        }

        private void bnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValidated())
                    return;
                ProRow["Storage pack text"] = txtName.EditValue;
                ProRow["Max_weight"] = txtMWeight.EditValue;
                ProRow["Max_length"] = txtMLength.EditValue;
                ProRow["Max_height"] = txtMHeight.EditValue;
                ProRow["Max_width"] = txtMWidth.EditValue;
                ProRow["Storage_volume"] = txtStorageVolume.EditValue;
                ProRow["ViewStatus"] = chkViewStatus.EditValue;
                if (ProTypeAdd)
                {
                    ProRow["Package_type"] = System.Guid.NewGuid();
                    Globals.dtPackageType.Rows.Add(ProRow);
                    Globals.dtPackageType.Update();
                }
                else
                {

                }
                MessageBox.Show(Constants.Message.Save_Success, Constants.Message.MessageTitle);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured");
            }
        }
        #region Property
        bool strTypeAdd;
        public bool ProTypeAdd
        {
            get
            {
                return this.strTypeAdd;
            }
            set
            {
                strTypeAdd = value;
            }
        }
        DataRow row;
        public DataRow ProRow
        {
            get
            {
                return this.row;
            }
            set
            {
                row = value;
                LoadData();
            }
        }

        #endregion

        #region Method
        private void LoadData()
        {
            if (!ProTypeAdd)
            {
                txtName.EditValue = ProRow["Storage pack text"];
                txtMWeight.EditValue = ProRow["Max_weight"];
                txtMLength.EditValue = ProRow["Max_length"];
                txtMHeight.EditValue = ProRow["Max_height"];
                txtMWidth.EditValue = ProRow["Max_width"];
                txtStorageVolume.EditValue = ProRow["Storage_volume"];
                chkViewStatus.EditValue = ProRow["ViewStatus"];
            }
            else
            {
                chkViewStatus.EditValue = true;
            }
        }

        private bool CheckExistName()
        {
            for (int i = 0; i < Globals.dtPackageType.Rows.Count; i++)
            {
                if (Globals.dtPackageType.Rows[i]["Storage pack text"].ToString() == txtName.Text && Globals.dtPackageType.Rows[i]["Package_type"].ToString() != ProRow["Package_type"].ToString())
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckValidated()
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Field Name empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }

            if (CheckExistName())
            {
                MessageBox.Show("There is a same name of Package Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Text = ProRow["Storage pack text"].ToString();
                txtName.Focus();
                return false;
            }

            return true;
        }

        #endregion

    }
}

