using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;
using Inventory.DataModels;

namespace Inventory.Forms
{
    /// <summary>
    /// Summary description for FindProduct.
    /// </summary>
    public class FindProduct : DevExpress.XtraEditors.XtraForm
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private DevExpress.XtraGrid.GridControl grdResult;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private SimpleButton btnSearch;
        private SimpleButton btnSelect;
        private System.Windows.Forms.ComboBox cboLocation;
        private TextBox txtProductId;
        private System.Windows.Forms.ComboBox cboWareHouse;
        private IContainer components;
        private SimpleButton btnCancel;

        protected DataTable dtResult = new DataTable();
        string strWarehouseID = "";
        string strLocationID = "";
        string strProductID = "";
        private Label label4;
        private TextBox txtProductName;

        private bool bIsBinding = false;

        public string WarehouseID
        {
            get { return strWarehouseID; }
        }

        public string LocationID
        {
            get { return strLocationID; }
        }

        public string ProductID
        {
            get { return strProductID; }
        }

        public FindProduct()
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grdResult = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.cboLocation = new System.Windows.Forms.ComboBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.cboWareHouse = new System.Windows.Forms.ComboBox();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Warehouse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product ID";
            // 
            // grdResult
            // 
            this.grdResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdResult.EmbeddedNavigator.Name = "";
            this.grdResult.Location = new System.Drawing.Point(12, 140);
            this.grdResult.MainView = this.gridView1;
            this.grdResult.Name = "grdResult";
            this.grdResult.Size = new System.Drawing.Size(455, 192);
            this.grdResult.TabIndex = 6;
            this.grdResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdResult.DoubleClick += new System.EventHandler(this.grdResult_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdResult;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(373, 105);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(153, 350);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Select";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cboLocation
            // 
            this.cboLocation.FormattingEnabled = true;
            this.cboLocation.Location = new System.Drawing.Point(327, 32);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(121, 20);
            this.cboLocation.TabIndex = 2;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(94, 69);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(121, 22);
            this.txtProductId.TabIndex = 3;
            // 
            // cboWareHouse
            // 
            this.cboWareHouse.FormattingEnabled = true;
            this.cboWareHouse.Location = new System.Drawing.Point(94, 32);
            this.cboWareHouse.Name = "cboWareHouse";
            this.cboWareHouse.Size = new System.Drawing.Size(121, 20);
            this.cboWareHouse.TabIndex = 1;
            this.cboWareHouse.SelectedIndexChanged += new System.EventHandler(this.cboWareHouse_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(248, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(327, 69);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(121, 22);
            this.txtProductName.TabIndex = 4;
            // 
            // FindProduct
            // 
            this.AcceptButton = this.btnSearch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(477, 381);
            this.Controls.Add(this.cboWareHouse);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.cboLocation);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grdResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find Product";
            this.Load += new System.EventHandler(this.FindProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void FindProduct_Load(object sender, EventArgs e)
        {
            bIsBinding = true;
            DataTable dt = Mediator.GetInstance().GetAllWarehouse();
            cboWareHouse.DataSource = dt;
            cboWareHouse.DisplayMember = "Description";
            cboWareHouse.ValueMember = "Warehouse_Id";
            bIsBinding = false;

            cboWareHouse.SelectedIndex = -1;
            if (cboWareHouse.Items.Count > 0)
            {
                cboWareHouse.SelectedIndex = 0;
            }
        }

        private void cboWareHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bIsBinding) return;
            if (cboWareHouse.SelectedIndex == -1) return;
            String strSelectedWareHouse = cboWareHouse.SelectedValue.ToString();
            DataTable dt = Mediator.GetInstance().GetLocationsOfWareHouse(strSelectedWareHouse);
            cboLocation.DataSource = dt;
            cboLocation.DisplayMember = "Bin_Location_id";
            cboLocation.ValueMember = "Bin_Location_id";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtResult = Mediator.GetInstance().FindProducts(cboLocation.Text, txtProductId.Text, txtProductName.Text);
            grdResult.DataSource = dtResult;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void grdResult_DoubleClick(object sender, EventArgs e)
        {
            btnSelect_Click(sender, e);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataRow dr = this.GetSelectedRow();
            strWarehouseID = dr["Warehouse_id"].ToString();
            strLocationID = dr["bin_location_id"].ToString();
            strProductID = dr["ProductID"].ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private DataRow GetSelectedRow()
        {
            if (gridView1 == null) return null;
            int[] selectedRows = gridView1.GetSelectedRows();
            if (selectedRows.Length == 0) return null;
            int i = selectedRows[0];
            DataRow row = dtResult.Rows[i];
            return row;
        }

        private int GetSelectedRowIndex()
        {
            if (gridView1 != null)
            {
                gridView1.TopRowIndex = 0;
                return gridView1.FocusedRowHandle;
            }
            else
            {
                return -1;
            }
        }
    }
}

