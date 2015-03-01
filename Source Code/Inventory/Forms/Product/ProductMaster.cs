using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Inventory.DataModels.Product;
using Inventory.DataModels;
using Toolkit;

namespace Inventory.Forms.Product
{
    /// <summary>
    /// Summary description for ProductMaster.
    /// </summary>
    public class ProductMaster : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton btnClose;
        private SimpleButton btnSave;
        private GroupControl groupControl5;
        private Label label16;
        private CheckEdit chkViewStatus;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private MemoEdit txtDescription;
        private TextEdit txtHoldingCost;
        private TextEdit txtBasePrice;
        private Label label39;
        private TextEdit txtAlternativeName;
        private Label label46;
        private Label label48;
        private Label label50;
        private Label label51;
        private TextEdit txtProductName;
        private ComboBoxEdit cboUnitMeasure;
        private ComboBoxEdit cboBarcode;
        private ComboBoxEdit cboCategory;
        private ComboBoxEdit cboFamily;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public ProductMaster()
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
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.cboUnitMeasure = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboBarcode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboFamily = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label16 = new System.Windows.Forms.Label();
            this.chkViewStatus = new DevExpress.XtraEditors.CheckEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.txtHoldingCost = new DevExpress.XtraEditors.TextEdit();
            this.txtBasePrice = new DevExpress.XtraEditors.TextEdit();
            this.label39 = new System.Windows.Forms.Label();
            this.txtAlternativeName = new DevExpress.XtraEditors.TextEdit();
            this.label46 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboUnitMeasure.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFamily.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoldingCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBasePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlternativeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(454, 311);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(342, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.cboUnitMeasure);
            this.groupControl5.Controls.Add(this.cboBarcode);
            this.groupControl5.Controls.Add(this.cboCategory);
            this.groupControl5.Controls.Add(this.cboFamily);
            this.groupControl5.Controls.Add(this.label16);
            this.groupControl5.Controls.Add(this.chkViewStatus);
            this.groupControl5.Controls.Add(this.label15);
            this.groupControl5.Controls.Add(this.label14);
            this.groupControl5.Controls.Add(this.label13);
            this.groupControl5.Controls.Add(this.label12);
            this.groupControl5.Controls.Add(this.txtDescription);
            this.groupControl5.Controls.Add(this.txtHoldingCost);
            this.groupControl5.Controls.Add(this.txtBasePrice);
            this.groupControl5.Controls.Add(this.label39);
            this.groupControl5.Controls.Add(this.txtAlternativeName);
            this.groupControl5.Controls.Add(this.label46);
            this.groupControl5.Controls.Add(this.label48);
            this.groupControl5.Controls.Add(this.label50);
            this.groupControl5.Controls.Add(this.label51);
            this.groupControl5.Controls.Add(this.txtProductName);
            this.groupControl5.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strNameAndAddr", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupControl5.Location = new System.Drawing.Point(13, 11);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(516, 288);
            this.groupControl5.TabIndex = 88;
            this.groupControl5.Text = global::Inventory.Properties.Settings.Default.strNameAndAddr;
            // 
            // cboUnitMeasure
            // 
            this.cboUnitMeasure.Location = new System.Drawing.Point(257, 138);
            this.cboUnitMeasure.Name = "cboUnitMeasure";
            this.cboUnitMeasure.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboUnitMeasure.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboUnitMeasure.Size = new System.Drawing.Size(154, 23);
            this.cboUnitMeasure.TabIndex = 7;
            // 
            // cboBarcode
            // 
            this.cboBarcode.Location = new System.Drawing.Point(10, 229);
            this.cboBarcode.Name = "cboBarcode";
            this.cboBarcode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboBarcode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboBarcode.Size = new System.Drawing.Size(162, 23);
            this.cboBarcode.TabIndex = 5;
            // 
            // cboCategory
            // 
            this.cboCategory.Location = new System.Drawing.Point(10, 184);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboCategory.Size = new System.Drawing.Size(162, 23);
            this.cboCategory.TabIndex = 4;
            // 
            // cboFamily
            // 
            this.cboFamily.Location = new System.Drawing.Point(10, 138);
            this.cboFamily.Name = "cboFamily";
            this.cboFamily.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFamily.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboFamily.Size = new System.Drawing.Size(162, 23);
            this.cboFamily.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(418, 233);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 14);
            this.label16.TabIndex = 52;
            this.label16.Text = "/Year";
            // 
            // chkViewStatus
            // 
            this.chkViewStatus.Location = new System.Drawing.Point(10, 261);
            this.chkViewStatus.Name = "chkViewStatus";
            this.chkViewStatus.Properties.Caption = "View Status";
            this.chkViewStatus.Size = new System.Drawing.Size(108, 19);
            this.chkViewStatus.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(256, 213);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 14);
            this.label15.TabIndex = 38;
            this.label15.Text = "Holding Cost";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(256, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 14);
            this.label14.TabIndex = 37;
            this.label14.Text = "Base Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 14);
            this.label13.TabIndex = 36;
            this.label13.Text = "Bar Code";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 14);
            this.label12.TabIndex = 35;
            this.label12.Text = "Category";
            // 
            // txtDescription
            // 
            this.txtDescription.EditValue = "";
            this.txtDescription.Location = new System.Drawing.Point(257, 40);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDescription.Properties.Appearance.Options.UseForeColor = true;
            this.txtDescription.Size = new System.Drawing.Size(246, 71);
            this.txtDescription.TabIndex = 6;
            // 
            // txtHoldingCost
            // 
            this.txtHoldingCost.EditValue = "";
            this.txtHoldingCost.Location = new System.Drawing.Point(257, 227);
            this.txtHoldingCost.Name = "txtHoldingCost";
            this.txtHoldingCost.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHoldingCost.Properties.Appearance.Options.UseForeColor = true;
            this.txtHoldingCost.Size = new System.Drawing.Size(154, 23);
            this.txtHoldingCost.TabIndex = 9;
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.EditValue = "";
            this.txtBasePrice.Location = new System.Drawing.Point(257, 182);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBasePrice.Properties.Appearance.Options.UseForeColor = true;
            this.txtBasePrice.Size = new System.Drawing.Size(154, 23);
            this.txtBasePrice.TabIndex = 8;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(256, 125);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(122, 14);
            this.label39.TabIndex = 30;
            this.label39.Text = global::Inventory.Properties.Settings.Default.strAltContact;
            // 
            // txtAlternativeName
            // 
            this.txtAlternativeName.EditValue = "";
            this.txtAlternativeName.Location = new System.Drawing.Point(12, 40);
            this.txtAlternativeName.Name = "txtAlternativeName";
            this.txtAlternativeName.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAlternativeName.Properties.Appearance.Options.UseForeColor = true;
            this.txtAlternativeName.Size = new System.Drawing.Size(162, 23);
            this.txtAlternativeName.TabIndex = 1;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(9, 125);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(39, 14);
            this.label46.TabIndex = 13;
            this.label46.Text = global::Inventory.Properties.Settings.Default.strCompanyName;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(11, 27);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(66, 14);
            this.label48.TabIndex = 9;
            this.label48.Text = global::Inventory.Properties.Settings.Default.strEmailName;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(256, 28);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(67, 14);
            this.label50.TabIndex = 5;
            this.label50.Text = global::Inventory.Properties.Settings.Default.strMiddleName;
            this.label50.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(9, 78);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(85, 14);
            this.label51.TabIndex = 3;
            this.label51.Text = global::Inventory.Properties.Settings.Default.strFirstName;
            // 
            // txtProductName
            // 
            this.txtProductName.EditValue = "";
            this.txtProductName.Location = new System.Drawing.Point(10, 92);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProductName.Properties.Appearance.Options.UseForeColor = true;
            this.txtProductName.Size = new System.Drawing.Size(162, 23);
            this.txtProductName.TabIndex = 2;
            // 
            // ProductMaster
            // 
            this.ClientSize = new System.Drawing.Size(545, 340);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product Master";
            this.Load += new System.EventHandler(this.ProductMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboUnitMeasure.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFamily.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoldingCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBasePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlternativeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion


        //Stock Transfer Model
        private ProductModel model = new ProductModel();

        /// <summary>
        /// Get/set data model StockTransfer 
        /// </summary>
        public ProductModel DataModel
        {
            get { return model; }
            set { model = value; }
        }

        /// <summary>
        /// Binding data to dialog
        /// </summary>
        /// <param name="objModel">ProductModel</param>
        public void BindData(ProductModel objModel)
        {

            //In case of adding new packing list, initialize the grid with nodata
            if (objModel == null)
            {
                model = new ProductModel();
            }
            else
            {
                model = objModel;
            }

            this.txtProductName.Text = model.Name;
            this.txtDescription.Text = model.Description;
            this.txtAlternativeName.Text = model.AlternativeID;

            cboFamily.Properties.Items.Clear();
            DataTable dtFamily = Mediator.GetInstance().GetAllTrueViewStatusProductFamily();
            dtFamily.DefaultView.Sort = "Name";
            //cboFamily.Properties.Items.Add(new TabItem("", "")); // None family
            foreach (DataRow row in dtFamily.Rows)
            {
                cboFamily.Properties.Items.Add(new TabItem(row["FamilyID"].ToString(), row["Name"].ToString()));
            }

            cboFamily.SelectedItem = TabItem.GetItemById(cboFamily.Properties.Items, model.FamilyID);
            if (cboFamily.SelectedItem == null)
            {
                cboFamily.SelectedIndex = 0;
            }

            cboCategory.Properties.Items.Clear();
            DataTable dtCategory = Mediator.GetInstance().GetAllTrueViewStatusProductCategory();
            dtCategory.DefaultView.Sort = "CategoryName";
            //cboCategory.Properties.Items.Add(new TabItem("", "")); // None category
            foreach (DataRow row in dtCategory.Rows)
            {
                cboCategory.Properties.Items.Add(new TabItem(row["CategoryID"].ToString(), row["CategoryName"].ToString()));
            }

            cboCategory.SelectedItem = TabItem.GetItemById(cboCategory.Properties.Items, model.CategoryID);
            if (cboCategory.SelectedItem == null)
            {
                cboCategory.SelectedIndex = 0;
            }

            cboBarcode.Properties.Items.Clear();
            DataTable dtBarcode = Mediator.GetInstance().GetAllTrueViewStatusProductBarcode();
            dtBarcode.DefaultView.Sort = "Label";
            cboBarcode.Properties.Items.Add(new TabItem("", "")); // None barcode
            foreach (DataRow row in dtBarcode.Rows)
            {
                cboBarcode.Properties.Items.Add(new TabItem(row["ID"].ToString(), row["Label"].ToString()));
            }

            cboBarcode.SelectedItem = TabItem.GetItemById(cboBarcode.Properties.Items, model.BarcodeID);
            if (cboBarcode.SelectedItem == null)
            {
                cboBarcode.SelectedIndex = 0;
            }

            cboUnitMeasure.Properties.Items.Clear();
            DataTable dtUnitMeasure = Mediator.GetInstance().GetAllTrueViewStatusProductUnitMeasure();
            dtUnitMeasure.DefaultView.Sort = "Note";
            //cboUnitMeasure.Properties.Items.Add(new TabItem("", "")); // None UOM
            foreach (DataRow row in dtUnitMeasure.Rows)
            {
                cboUnitMeasure.Properties.Items.Add(new TabItem(row["UOMID"].ToString(), row["Note"].ToString()));
            }

            cboUnitMeasure.SelectedItem = TabItem.GetItemById(cboUnitMeasure.Properties.Items, model.UOMID);
            if (cboUnitMeasure.SelectedItem == null)
            {
                cboUnitMeasure.SelectedIndex = 0;
            }

            this.txtBasePrice.Text = model.BasePrice.ToString();
            this.txtHoldingCost.Text = model.HoldingCost.ToString();
            this.chkViewStatus.Checked = model.ViewStatus;
            //this.txtName.Text = model.AdjustName;
            //this.dtmDateCreated.Text = model.DateCreated.ToShortDateString();
            //this.dtDetails = model.AdjustDetails;
            //this.memReason.Text = model.Notes;
            //this.chkShow.Checked = model.ViewStatus;
        }

        /// <summary>
        /// Implement Validate data
        /// </summary>
        /// <returns></returns>
        protected bool Validate()
        {
            Validator objValidator = new Validator();

            if (!objValidator.IsNonEmpty("Product ID", txtAlternativeName.Text))
            {
                txtAlternativeName.Focus();
                return false;
            }
            if (Toolkit.DbToolKit.IsDataOfSqlExists("SELECT * FROM ProductMaster WHERE ProductID <> '" + model.ID + "' AND AlternativeID = '" + txtAlternativeName.Text + "'"))
            {
                MessageBox.Show("Duplicate Product ID is found");
                txtAlternativeName.Focus();
                return false;
            }

            if (!objValidator.IsNonEmpty("Product Name", txtProductName.Text))
            {
                txtProductName.Focus();
                return false;
            }

            if (Toolkit.DbToolKit.IsDataOfSqlExists("SELECT * FROM ProductMaster WHERE ProductID <> '" + model.ID + "' AND ProductName = '" + txtProductName.Text + "'"))
            {
                MessageBox.Show("Duplicate Product Name is found");
                txtProductName.Focus();
                return false;
            }

            //if (!objValidator.IsNonEmpty("Family", cboFamily.Text))
            //{
            //    cboFamily.Focus();
            //    return false;
            //}

            //if (!objValidator.IsNonEmpty("Category", cboCategory.Text))
            //{
            //    cboCategory.Focus();
            //    return false;
            //}

            //if (!objValidator.IsNonEmpty("Bar Code", cboBarcode.Text))
            //{
            //    cboBarcode.Focus();
            //    return false;
            //}

            //if (!objValidator.IsNonEmpty("Unit of Measure", cboUnitMeasure.Text))
            //{
            //    cboUnitMeasure.Focus();
            //    return false;
            //}

            if (!objValidator.IsPositiveDecimal("Base Price", txtBasePrice.Text))
            {
                txtBasePrice.Focus();
                return false;
            }

            if (!objValidator.IsPositiveDecimal("Holding Cost", txtHoldingCost.Text))
            {
                txtHoldingCost.Focus();
                return false;
            }





            return true;
        }

        /// <summary>
        /// Implement ReadToDataModel
        /// </summary>
        protected void ReadToDataModel()
        {
            model.Name = txtProductName.Text;
            model.Description = txtDescription.Text;
            model.AlternativeID = txtAlternativeName.Text;
            model.FamilyID = ((TabItem)cboFamily.SelectedItem).ItemID;
            if (model.FamilyID == "")
            {
                model.FamilyID = null;
            }

            model.CategoryID = ((TabItem)cboCategory.SelectedItem).ItemID;
            if (model.CategoryID == "")
            {
                model.CategoryID = null;
            }

            model.BarcodeID = ((TabItem)cboBarcode.SelectedItem).ItemID;
            if (model.BarcodeID == "")
            {
                model.BarcodeID = null;
            }

            model.UOMID = ((TabItem)cboUnitMeasure.SelectedItem).ItemID;
            if (model.UOMID == "")
            {
                model.UOMID = null;
            }

            model.BasePrice = Convert.ToDouble(txtBasePrice.Text);
            model.HoldingCost = Convert.ToDouble(txtHoldingCost.Text);
            model.ViewStatus = chkViewStatus.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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

        private void ProductMaster_Load(object sender, EventArgs e)
        {
            txtAlternativeName.Select();
        }
    }
}
