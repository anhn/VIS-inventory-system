using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Inventory.DataModels.Listings;

namespace Inventory.Forms.Listings
{
    /// <summary>
    /// Summary description for PaymentMethod.
    /// </summary>
    public class PaymentMethod : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton btnClose;
        private SimpleButton btnSave;
        private Label lblDescription;
        private MemoEdit txtDescription;
        private TextEdit txtName;
        private Label lblName;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private PaymentMethodModel model;

        private bool isEdited = false;

        public PaymentMethodModel DataModel
        {
            get { return model; }
            set { model = value; }
        }

        public PaymentMethod()
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
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(206, 208);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(107, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 79);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(91, 79);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(290, 96);
            this.txtDescription.TabIndex = 9;
            this.txtDescription.EditValueChanged += new System.EventHandler(this.txtDescription_EditValueChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 20);
            this.txtName.TabIndex = 8;
            this.txtName.EditValueChanged += new System.EventHandler(this.txtName_EditValueChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // PaymentMethod
            // 
            this.AcceptButton = this.btnSave;
            this.ClientSize = new System.Drawing.Size(392, 270);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "PaymentMethod";
            this.Text = "PaymentMethod";
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        internal void BindData(PaymentMethodModel objModel)
        {
            if (objModel == null)
            {
                model = new PaymentMethodModel();
            }
            else
            {
                model = objModel;
            }

            this.txtName.Text = model.Name;
            this.txtDescription.Text = model.Description;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validate()) return;
            ReadToDataModel();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ReadToDataModel()
        {
            model.Name = txtName.Text;            
            model.Description = txtDescription.Text;           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isEdited)
            {
                // confirm to save data
                DialogResult dlgResult = MessageBox.Show(Constants.Message.Save_Prompt, Constants.Message.MessageTitle, MessageBoxButtons.YesNo);
                if (dlgResult == DialogResult.Yes)
                {
                    btnSave_Click(btnSave, EventArgs.Empty);
                }
                else
                {
                    this.Close();
                }
            }
        }

        private bool Validate()
        {
            Validator objValidator = new Validator();

            if (!objValidator.IsNonEmpty("Payment Method Name", txtName.Text))
            {
                txtName.Focus();
                return false;
            }

            return true;
        }

        private void txtName_EditValueChanged(object sender, EventArgs e)
        {
            isEdited = true;
        }

        private void txtDescription_EditValueChanged(object sender, EventArgs e)
        {
            isEdited = true;
        }
    }
}

