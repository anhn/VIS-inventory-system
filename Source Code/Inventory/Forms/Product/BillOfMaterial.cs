using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Inventory.DataModels.Product;
using System.Data;
using Inventory.Utils;
using Inventory.DataModels;
using Inventory.Forms.Binder;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using Toolkit;

namespace Inventory.Forms.Product
{
    /// <summary>
    /// Summary description for BillOfMaterial.
    /// </summary>
    public class BillOfMaterial : BaseFormWithGrid
    {
        private SimpleButton btnPick;
        private Label label3;
        private Label lblProduct;
        private DevExpress.XtraGrid.GridControl grdDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MemoEdit txtDesc;
        private TextEdit txtName;
        private Label lblName;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private ComboBoxEdit cboProduct;
        private BOMModel model;
        private DataTable dtProducts;

        public BOMModel DataModel
        {
            get { return model; }
            set { model = value; }
        }

        public BillOfMaterial()
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
            this.btnPick = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.grdDetails = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtDesc = new DevExpress.XtraEditors.MemoEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblName = new System.Windows.Forms.Label();
            this.cboProduct = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProduct.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(206, 215);
            this.btnAdd.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(303, 215);
            this.btnDelete.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(160, 450);
            this.btnSave.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(270, 450);
            this.btnClose.TabIndex = 10;
            // 
            // dtmDateCreated
            // 
            this.dtmDateCreated.Location = new System.Drawing.Point(350, 15);
            this.dtmDateCreated.Size = new System.Drawing.Size(129, 23);
            this.dtmDateCreated.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(259, 18);
            // 
            // btnPick
            // 
            this.btnPick.Location = new System.Drawing.Point(392, 215);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(109, 23);
            this.btnPick.TabIndex = 7;
            this.btnPick.Text = "Pick Components";
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 19;
            this.label3.Text = "Description";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(8, 62);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(50, 14);
            this.lblProduct.TabIndex = 18;
            this.lblProduct.Text = "Product";
            // 
            // grdDetails
            // 
            this.grdDetails.EmbeddedNavigator.Name = "";
            this.grdDetails.Location = new System.Drawing.Point(9, 244);
            this.grdDetails.MainView = this.gridView1;
            this.grdDetails.Name = "grdDetails";
            this.grdDetails.Size = new System.Drawing.Size(493, 200);
            this.grdDetails.TabIndex = 8;
            this.grdDetails.TabStop = false;
            this.grdDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdDetails;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(82, 106);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(312, 90);
            this.txtDesc.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 14);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // cboProduct
            // 
            this.cboProduct.Location = new System.Drawing.Point(82, 59);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboProduct.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboProduct.Size = new System.Drawing.Size(100, 23);
            this.cboProduct.TabIndex = 3;
            // 
            // BillOfMaterial
            // 
            this.ClientSize = new System.Drawing.Size(513, 485);
            this.Controls.Add(this.cboProduct);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.grdDetails);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "BillOfMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bill Of Material";
            this.Load += new System.EventHandler(this.BillOfMaterial_Load);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtDesc, 0);
            this.Controls.SetChildIndex(this.grdDetails, 0);
            this.Controls.SetChildIndex(this.lblProduct, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnPick, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.dtmDateCreated, 0);
            this.Controls.SetChildIndex(this.cboProduct, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dtmDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProduct.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        

        internal void BindData(BOMModel objModel)
        {
            if (objModel == null)
            {
                model = new BOMModel();
                model.Details = Mediator.GetInstance().GetEmptyListBOMDetail();
            }
            else
            {
                model = objModel;
            }
            this.txtName.Text = model.Name;
            this.txtDesc.Text = model.Description;
            this.dtmDateCreated.Text = model.DateCreated.ToShortDateString();            
            DataTable dt = Mediator.GetInstance().GetAllProducts();
            XComboBinder binder = new XComboBinder();
            binder.BindComboBox(cboProduct, dt, "ProductName", "ProductID");
            XTagItem item = XTagItem.GetItemByValue( cboProduct.Properties.Items, model.ProductID);
            cboProduct.SelectedItem = item;
            dtDetails = model.Details;
            grdDetails.DataSource = model.Details;
            gridView = (GridView)grdDetails.Views[0];
            RepositoryItemLookUpEdit repoProductLookUp = new RepositoryItemLookUpEdit();
            repoProductLookUp.EditValueChanged += new EventHandler(repoProductLookUp_EditValueChanged);
            repoProductLookUp.DisplayMember = "ProductName";
            repoProductLookUp.ValueMember = "ProductId";
            repoProductLookUp.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Product", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            dtProducts = Mediator.GetInstance().GetAllProductNames();
            repoProductLookUp.DataSource = dtProducts;
            gridView.Columns["Component"].ColumnEdit = repoProductLookUp;
            gridView.Columns["ID"].Visible = false;
            gridView.Columns["BOMID"].Visible = false;
            //gridView.Columns["Units"].ColumnType = typeof(Int32);
            ((DevExpress.XtraGrid.Columns.GridColumn)gridView.Columns["UoM"]).OptionsColumn.AllowEdit = false;
            //gridView.Columns["UoM"].View.
        }

        void repoProductLookUp_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit le = (DevExpress.XtraEditors.LookUpEdit)sender;
            String strNewProduct = le.EditValue.ToString();
            UpdateUOM(strNewProduct);
        }

        private void UpdateUOM(string strProduct)
        {
            DataRow dr = GetSelectedRow();
            if (dr == null) return;

            if (String.IsNullOrEmpty(strProduct)) return;

            foreach (DataRow dtr in dtProducts.Rows)
            {
                if (dtr["ProductId"].ToString().Equals(strProduct))
                {
                    dr["UoM"] = dtr["Note"].ToString();
                    return;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validate()) return;
            ReadToDataModel();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        protected override void ReadToDataModel()
        {
            model.DateCreated = DateUtils.ParseDate(this.dtmDateCreated.Text);
            model.Description = this.txtDesc.Text;
            model.Details = (DataTable)this.grdDetails.DataSource;
            model.ProductID = ((XTagItem)this.cboProduct.SelectedItem).Value;
            model.Name = this.txtName.Text;
            model.Details = (DataTable)this.grdDetails.DataSource;

        }

        protected override bool Validate()
        {
            Validator objValidator = new Validator();
            if (Toolkit.DbToolKit.IsDataOfSqlExists("SELECT ID,Name FROM BoMMaster WHERE Name = '" + txtName.Text.Trim() + "' AND ID <> '" + this.DataModel.ID + "'"))
            {
                MessageBox.Show("This name is already available, please select another one");
                txtName.Focus();
                return false;
            }
            if (!objValidator.IsNonEmpty("Bill Of Materials Name", this.txtName.Text))
            {
                txtName.Focus();
                return false;
            }

            if (!objValidator.IsNotNull("Product", this.cboProduct.SelectedItem))
            {
                cboProduct.Focus();
                return false;
            }
            
            if (!objValidator.IsDateTime("Created Date", this.dtmDateCreated.Text))
            {
                dtmDateCreated.Focus();
                return false;
            }

            if (dtDetails.Rows.Count <= 0)
            {
                MessageBox.Show("Please add the product item in the grid");
                btnAdd.Focus();
                return false;
            }
            foreach (DataRow dr in dtDetails.Rows)
            {
                int i = dtDetails.Rows.IndexOf(dr) + 1;
                String strTemp = dr["Component"].ToString();
                if (!objValidator.IsNonEmpty("Line " + i + " :Component", strTemp))
                {
                    return false;
                }
                if (((XTagItem)cboProduct.SelectedItem).Value.ToString() == strTemp)
                {
                    cboProduct.Select();
                    MessageBox.Show("Component cannot be same as the Product Name");
                    return false;
                }
                strTemp = dr["Units"].ToString();
                if (!objValidator.IsPositiveDecimal("Line " + i + " :Units", strTemp))
                {
                    return false;
                }


            }
            return true;
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (cboProduct.EditValue != null)
            {
                //MessageBox.Show(gridView1.GetRowCellDisplayText(e.RowHandle, "Component"));
                
                if (cboProduct.EditValue.ToString() == gridView1.GetRowCellDisplayText(e.RowHandle, "Component"))
                {
                    e.Valid = false;
                    e.ErrorText = "Component cannot be same as the Product Name";
                }
            }

        }

        private void BillOfMaterial_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            DataRow dr = GetSelectedRow();
            if (dr == null)
            {
                MessageBox.Show(Constants.Message.FindProducts_SelectRow, Constants.Message.MessageTitle);
                return;
            }

            FindProduct frmFind = new FindProduct();
            if (DialogResult.OK != frmFind.ShowDialog())
            {
                return;
            }

            //dr["Warehouse"] = frmFind.WarehouseID;
            //dr["Location"] = frmFind.LocationID;
            dr["Product"] = frmFind.strSelectedDesc;
        }
    }
}

