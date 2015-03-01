using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Inventory.DataModels.Product;
using Inventory.DataModels;

namespace Inventory.Forms.Product
{
    /// <summary>
    /// Summary description for ProductFamily.
    /// </summary>
    public class ProductFamily : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton btnClose;
        private SimpleButton btnSave;
        private Label label4;
        private Label label3;
        private ComboBoxEdit cboStatus;
        private MemoEdit txtDescription;
        private Label label1;
        private TextEdit txtName;
        private CheckEdit chkViewStatus;
        private Label label5;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public ProductFamily()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.chkViewStatus = new DevExpress.XtraEditors.CheckEdit();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(249, 233);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(136, 233);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "Status:";
            this.label3.Visible = false;
            // 
            // cboStatus
            // 
            this.cboStatus.EditValue = "Active";
            this.cboStatus.Location = new System.Drawing.Point(100, 55);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStatus.Properties.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.cboStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboStatus.Size = new System.Drawing.Size(181, 23);
            this.cboStatus.TabIndex = 2;
            this.cboStatus.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(100, 92);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(336, 96);
            this.txtDescription.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 23);
            this.txtName.TabIndex = 1;
            // 
            // chkViewStatus
            // 
            this.chkViewStatus.Location = new System.Drawing.Point(100, 202);
            this.chkViewStatus.Name = "chkViewStatus";
            this.chkViewStatus.Properties.Caption = "";
            this.chkViewStatus.Size = new System.Drawing.Size(23, 19);
            this.chkViewStatus.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 53;
            this.label5.Text = "View Status:";
            // 
            // ProductFamily
            // 
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(461, 266);
            this.Controls.Add(this.chkViewStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductFamily";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product Family";
            this.Load += new System.EventHandler(this.ProductFamily_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewStatus.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        //Stock Transfer Model
        private ProductFamilyModel model = new ProductFamilyModel();

        /// <summary>
        /// Get/set data model StockTransfer 
        /// </summary>
        public ProductFamilyModel DataModel
        {
            get { return model; }
            set { model = value; }
        }

        /// <summary>
        /// Binding data to dialog
        /// </summary>
        /// <param name="objModel">ProductFamilyModel</param>

        public bool bAddorEdit = false; // KienPD Editing
        public string tmpStr = "";  // KienPD Editing
        public void BindData(ProductFamilyModel objModel)
        {

            if (objModel == null)
            {
                model = new ProductFamilyModel();
                bAddorEdit = true;  // KienPD Editing
            }
            else
            {
                model = objModel;
                tmpStr = model.Name;// KienPD Editing
            }

            this.txtName.Text = model.Name;
            this.txtDescription.Text = model.Description;
            this.cboStatus.Text = model.Status;
            this.chkViewStatus.Checked = model.ViewStatus;
        }

        /// <summary>
        /// Implement Validate data
        /// </summary>
        /// <returns></returns>
        protected bool Validate()
        {
            Validator objValidator = new Validator();

            if (!objValidator.IsNonEmpty("Family Name", txtName.Text))
            {
                txtName.Focus();
                return false;
            }
            if (Toolkit.DbToolKit.IsDataOfSqlExists("SELECT FamilyID,Name FROM ProductFamily WHERE Name = '" + txtName.Text + "' AND FamilyID <> '" + this.DataModel.ID + "'"))
            {
                MessageBox.Show("This name is already available, please select another one");
                txtName.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Implement ReadToDataModel
        /// </summary>
        protected void ReadToDataModel()
        {
            model.Name = txtName.Text;
            model.Status = cboStatus.Text;
            model.Description = txtDescription.Text;
            model.ViewStatus = chkViewStatus.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Begin of KienPD Editing
            string strSQL = "SELECT * FROM ProductFamily WHERE Name = '" + txtName.Text + "'";
            if (!Data_Access.DoSqlCommand(strSQL)) return;
            DataTable tb = Data_Access.GetDataSet().Tables[0].Copy();
            if (tb.Rows.Count > 0 && (bAddorEdit == true || txtName.Text != tmpStr))
            {
                MessageBox.Show("There is a same name of Family Name");
                return;
            }
            // End of KienPD Editing
            if (!Validate()) return;
            ReadToDataModel();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
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

        private void ProductFamily_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }
    }
}

