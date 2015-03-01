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
    /// Summary description for frmAddEditDeliveryMethod.
    /// </summary>
    public class frmAddEditDeliveryMethod : DevExpress.XtraEditors.XtraForm
    {
        private Label label2;
        private Label label3;
        private Label label4;
        private TextEdit txtName;
        private CheckEdit chkViewStatus;
        private MemoEdit txtNote;
        private SimpleButton bnOK;
        private SimpleButton btnClose;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmAddEditDeliveryMethod()
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.chkViewStatus = new DevExpress.XtraEditors.CheckEdit();
            this.txtNote = new DevExpress.XtraEditors.MemoEdit();
            this.bnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "View Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Note";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 21);
            this.txtName.TabIndex = 1;
            // 
            // chkViewStatus
            // 
            this.chkViewStatus.Location = new System.Drawing.Point(96, 153);
            this.chkViewStatus.Name = "chkViewStatus";
            this.chkViewStatus.Properties.Caption = "";
            this.chkViewStatus.Size = new System.Drawing.Size(75, 19);
            this.chkViewStatus.TabIndex = 5;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(99, 52);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(270, 91);
            this.txtNote.TabIndex = 3;
            // 
            // bnOK
            // 
            this.bnOK.Location = new System.Drawing.Point(96, 194);
            this.bnOK.Name = "bnOK";
            this.bnOK.Size = new System.Drawing.Size(75, 23);
            this.bnOK.TabIndex = 6;
            this.bnOK.Text = "&Save";
            this.bnOK.Click += new System.EventHandler(this.bnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(203, 194);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddEditDeliveryMethod
            // 
            this.ClientSize = new System.Drawing.Size(392, 238);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bnOK);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.chkViewStatus);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditDeliveryMethod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delivery Method";
            this.Load += new System.EventHandler(this.frmAddEditDeliveryMethod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

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

        private void frmAddEditDeliveryMethod_Load(object sender, EventArgs e)
        {
            txtName.Select();
        }

        private void bnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValidated())
                    return;
                ProRow["Name"] = txtName.EditValue;
                ProRow["Notes"] = txtNote.EditValue;
                ProRow["ViewStatus"] = chkViewStatus.EditValue;
                if (ProTypeAdd)
                {
                    ProRow["DeliveryMethodID"] = System.Guid.NewGuid();
                    Globals.dtDeliveryMethod.Rows.Add(ProRow);
                    Globals.dtDeliveryMethod.Update();
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
                txtName.EditValue = ProRow["Name"];
                txtNote.EditValue = ProRow["Notes"];
                chkViewStatus.EditValue = ProRow["ViewStatus"];
            }
            else
            {
                chkViewStatus.EditValue = true;
            }
        }

        private bool CheckExistName()
        {
            for (int i = 0; i < Globals.dtDeliveryMethod.Rows.Count; i++)
            {
                if (Globals.dtDeliveryMethod.Rows[i]["Name"].ToString() == txtName.Text && Globals.dtDeliveryMethod.Rows[i]["DeliveryMethodID"].ToString() != ProRow["DeliveryMethodID"].ToString())
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
                MessageBox.Show("There is a same name of Delivery method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Text = ProRow["Name"].ToString();
                txtName.Focus();
                return false;
            }

            return true;
        }

        #endregion

    }
}

