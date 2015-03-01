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
    /// Summary description for frmAddEditShipViaMethod.
    /// </summary>
    public class frmAddEditShipViaMethod : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton btnClose;
        private SimpleButton bnOK;
        private MemoEdit txtNote;
        private CheckEdit chkViewStatus;
        private TextEdit txtName;
        private Label label3;
        private Label label4;
        private Label label2;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmAddEditShipViaMethod()
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
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.bnOK = new DevExpress.XtraEditors.SimpleButton();
            this.txtNote = new DevExpress.XtraEditors.MemoEdit();
            this.chkViewStatus = new DevExpress.XtraEditors.CheckEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(209, 184);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bnOK
            // 
            this.bnOK.Location = new System.Drawing.Point(102, 184);
            this.bnOK.Name = "bnOK";
            this.bnOK.Size = new System.Drawing.Size(75, 23);
            this.bnOK.TabIndex = 6;
            this.bnOK.Text = "&Save";
            this.bnOK.Click += new System.EventHandler(this.bnOK_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(96, 42);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(270, 91);
            this.txtNote.TabIndex = 3;
            // 
            // chkViewStatus
            // 
            this.chkViewStatus.Location = new System.Drawing.Point(93, 143);
            this.chkViewStatus.Name = "chkViewStatus";
            this.chkViewStatus.Properties.Caption = "";
            this.chkViewStatus.Size = new System.Drawing.Size(75, 19);
            this.chkViewStatus.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 21);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "View Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // frmAddEditShipViaMethod
            // 
            this.ClientSize = new System.Drawing.Size(392, 220);
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
            this.Name = "frmAddEditShipViaMethod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ship Via Method";
            this.Load += new System.EventHandler(this.frmAddEditShipViaMethod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
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
                    ProRow["ID"] = System.Guid.NewGuid();
                    Globals.dtShipViaMethod.Rows.Add(ProRow);
                    Globals.dtShipViaMethod.Update();
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

        private void frmAddEditShipViaMethod_Load(object sender, EventArgs e)
        {
            txtName.Select();
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
            for (int i = 0; i < Globals.dtShipViaMethod.Rows.Count; i++)
            {
                if (Globals.dtShipViaMethod.Rows[i]["Name"].ToString() == txtName.Text && Globals.dtShipViaMethod.Rows[i]["ID"].ToString() != ProRow["ID"].ToString())
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
                MessageBox.Show("There is a same name of Ship Via method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Text = ProRow["Name"].ToString();
                txtName.Focus();
                return false;
            }

            return true;
        }

        #endregion
    }
}

