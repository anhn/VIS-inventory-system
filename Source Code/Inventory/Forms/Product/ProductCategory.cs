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
    /// Summary description for ProductCategory.
    /// </summary>
    public class ProductCategory : DevExpress.XtraEditors.XtraForm
    {
        private TextEdit txtName;
        private Label label1;
        private MemoEdit txtDescription;
        private ComboBoxEdit cboStatus;
        private Label label2;
        private Label label3;
        private Label label4;
        private SimpleButton btnSave;
        private SimpleButton btnClose;
        private CheckEdit chkViewStatus;
        private Label label5;
        private ComboBoxEdit cboParent;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public ProductCategory()
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.cboStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.chkViewStatus = new DevExpress.XtraEditors.CheckEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.cboParent = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboParent.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 23);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category Name:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(106, 127);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(328, 96);
            this.txtDescription.TabIndex = 4;
            // 
            // cboStatus
            // 
            this.cboStatus.EditValue = "Active";
            this.cboStatus.Location = new System.Drawing.Point(106, 91);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStatus.Properties.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.cboStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboStatus.Size = new System.Drawing.Size(173, 23);
            this.cboStatus.TabIndex = 3;
            this.cboStatus.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parent Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(138, 271);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(244, 271);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkViewStatus
            // 
            this.chkViewStatus.Location = new System.Drawing.Point(103, 235);
            this.chkViewStatus.Name = "chkViewStatus";
            this.chkViewStatus.Properties.Caption = "";
            this.chkViewStatus.Size = new System.Drawing.Size(23, 19);
            this.chkViewStatus.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "View Status:";
            // 
            // cboParent
            // 
            this.cboParent.Location = new System.Drawing.Point(106, 55);
            this.cboParent.Name = "cboParent";
            this.cboParent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboParent.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboParent.Size = new System.Drawing.Size(173, 23);
            this.cboParent.TabIndex = 2;
            // 
            // ProductCategory
            // 
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(456, 306);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cboParent);
            this.Controls.Add(this.chkViewStatus);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product Category";
            this.Load += new System.EventHandler(this.ProductCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboParent.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        //Stock Transfer Model
        private ProductCategoryModel model = new ProductCategoryModel();

        /// <summary>
        /// Get/set data model StockTransfer 
        /// </summary>
        public ProductCategoryModel DataModel
        {
            get { return model; }
            set { model = value; }
        }

        /// <summary>
        /// Binding data to dialog
        /// </summary>
        /// <param name="objModel">ProductCategoryModel</param>

        public bool bAddorEdit = false; // KienPD Editing
        public string tmpStr = "";  // KienPD Editing

        public void BindData(ProductCategoryModel objModel)
        {

            //In case of adding new packing list, initialize the grid with nodata
            if (objModel == null)
            {
                model = new ProductCategoryModel();
                bAddorEdit = true;  // KienPD Editing
            }
            else
            {
                model = objModel;
                tmpStr = model.Name;// KienPD Editing
            }

            this.txtName.Text = model.Name;

            cboParent.Properties.Items.Clear();
            DataTable dtCat = Mediator.GetInstance().GetAllProductCategory();
            dtCat.DefaultView.Sort = "CategoryName";
            cboParent.Properties.Items.Add(new TabItem("", "")); // None parent
            foreach (DataRow row in dtCat.Rows)
            {
                cboParent.Properties.Items.Add(new TabItem(row["CategoryID"].ToString(), row["CategoryName"].ToString()));
            }

            cboParent.SelectedItem = TabItem.GetItemById(cboParent.Properties.Items, model.ParentID);

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

            if (!objValidator.IsNonEmpty("Category Name", txtName.Text))
            {
                txtName.Focus();
                return false;
            }
            if (Toolkit.DbToolKit.IsDataOfSqlExists("SELECT CategoryID, CategoryName FROM ProductCategory WHERE CategoryName = '" + txtName.Text + "' AND CategoryID <> '" + this.DataModel.ID + "'"))
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

            if (cboParent.SelectedItem == null)
            {
                model.ParentID = "";
            } 
            else
            {
                model.ParentID = ((TabItem)cboParent.SelectedItem).ItemID;
            }
            if (model.ParentID == "")
            {
                model.ParentID = null;
            }

            model.Status = cboStatus.Text;
            model.Description = txtDescription.Text;
            model.ViewStatus = chkViewStatus.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Begin of KienPD Editing
            string strSQL = "SELECT * FROM ProductCategory WHERE CategoryName = '" + txtName.Text + "'";
            if (!Data_Access.DoSqlCommand(strSQL)) return;
            DataTable tb = Data_Access.GetDataSet().Tables[0].Copy();
            if (tb.Rows.Count > 0 && (bAddorEdit == true || txtName.Text != tmpStr))
            {
                MessageBox.Show("There is a same name of category");
                txtName.Focus();
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

        private void ProductCategory_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

    }
}

