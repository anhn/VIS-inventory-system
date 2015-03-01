using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Inventory.DataModels.Warehouse;
using System.Data;
using Inventory.DataModels;
using Inventory.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Inventory.Properties;
using DevExpress.XtraEditors.Repository;

namespace Inventory.Forms.Warehouse
{
    /// <summary>
    /// Summary description for InventoryAdjustment.
    /// </summary>
    public class InventoryAdjustment : BaseWarehouse
    {
        private TextEdit txtName;
        private DevExpress.XtraGrid.GridControl grdInvAdjustment;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private MemoEdit memReason;
        private Label lblName;
        private Label lblReason;
        private CheckEdit chkShow;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public InventoryAdjustment()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        private string m_Name;


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
            this.grdInvAdjustment = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.memReason = new DevExpress.XtraEditors.MemoEdit();
            this.lblName = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.chkShow = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.repoWarehouseLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoLocationLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoProductLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoPackageLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoToWarehouseLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoToLocationLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvAdjustment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShow.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(435, 68);
            this.btnFind.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(257, 68);
            this.btnAdd.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(346, 68);
            this.btnDelete.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(173, 391);
            this.btnSave.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(276, 391);
            this.btnClose.TabIndex = 10;
            // 
            // dtmDateCreated
            // 
            this.dtmDateCreated.Location = new System.Drawing.Point(335, 26);
            this.dtmDateCreated.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(257, 30);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(52, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 21);
            this.txtName.TabIndex = 1;
            // 
            // grdInvAdjustment
            // 
            this.grdInvAdjustment.EmbeddedNavigator.Name = "";
            this.grdInvAdjustment.Location = new System.Drawing.Point(12, 100);
            this.grdInvAdjustment.MainView = this.gridView1;
            this.grdInvAdjustment.Name = "grdInvAdjustment";
            this.grdInvAdjustment.Size = new System.Drawing.Size(498, 200);
            this.grdInvAdjustment.TabIndex = 6;
            this.grdInvAdjustment.TabStop = false;
            this.grdInvAdjustment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdInvAdjustment;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdInvAdjustment;
            this.gridView2.Name = "gridView2";
            // 
            // memReason
            // 
            this.memReason.Location = new System.Drawing.Point(77, 320);
            this.memReason.Name = "memReason";
            this.memReason.Size = new System.Drawing.Size(308, 62);
            this.memReason.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 14);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Name";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(12, 322);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(46, 14);
            this.lblReason.TabIndex = 22;
            this.lblReason.Text = "Reason";
            // 
            // chkShow
            // 
            this.chkShow.Location = new System.Drawing.Point(396, 320);
            this.chkShow.Name = "chkShow";
            this.chkShow.Properties.Caption = "Show Adjustment";
            this.chkShow.Size = new System.Drawing.Size(126, 19);
            this.chkShow.TabIndex = 8;
            // 
            // InventoryAdjustment
            // 
            this.ClientSize = new System.Drawing.Size(524, 426);
            this.Controls.Add(this.chkShow);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.memReason);
            this.Controls.Add(this.grdInvAdjustment);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "InventoryAdjustment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventory Adjustment";
            this.Load += new System.EventHandler(this.InventoryAdjustment_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.grdInvAdjustment, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.memReason, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.dtmDateCreated, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.lblReason, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.chkShow, 0);
            ((System.ComponentModel.ISupportInitialize)(this.repoWarehouseLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoLocationLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoProductLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoPackageLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoToWarehouseLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoToLocationLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvAdjustment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShow.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        //Stock Transfer Model
        private InventoryAdjustmentModel model = new InventoryAdjustmentModel();

        /// <summary>
        /// Get/set data model StockTransfer 
        /// </summary>
        public InventoryAdjustmentModel DataModel
        {
            get { return model; }
            set { model = value; }
        }

        /// <summary>
        /// Binding data to dialog
        /// </summary>
        /// <param name="objModel">InventoryAdjustmentModel</param>
        public void BindData(InventoryAdjustmentModel objModel)
        {
            
            //In case of adding new packing list, initialize the grid with nodata
            if (objModel == null)
            {
                model = new InventoryAdjustmentModel();
                model.AdjustDetails = Mediator.GetInstance().GetEmptyInventoryAdjustmentDetails();
            }
            else
            {
                model = objModel;
                m_Name = model.AdjustName;
            }

            this.txtName.Text = model.AdjustName;
            this.dtmDateCreated.Text = model.DateCreated.ToShortDateString();
            this.dtDetails = model.AdjustDetails;
            this.memReason.Text = model.Notes;
            this.chkShow.Checked = model.ViewStatus;

            grdInvAdjustment.DataSource = dtDetails;

            //Get grid view
            gridView = (GridView)this.grdInvAdjustment.Views[0];

            foreach (GridColumn cl in gridView.Columns)
            {
                //cl.Visible = false;
                cl.MinWidth = 10;
                cl.AppearanceHeader.Font = Settings.Default.cfgDefaultFont;
                cl.AppearanceCell.Font = Settings.Default.cfgDefaultFont;
            }

            this.InitializeDropDowGrid();

            //Setting up columns
            gridView.Columns["ID"].Visible = false;
            gridView.Columns["InventoryAdjustmentID"].Visible = false;
            gridView.Columns["Warehouse"].ColumnEdit = repoWarehouseLookUp;
            gridView.Columns["Location"].ColumnEdit = repoLocationLookUp;
            gridView.Columns["Product"].ColumnEdit = repoProductLookUp;
            //gridView.Columns["Package code"].ColumnEdit = repoPackageLookUp;

            gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridView_CellValueChanged);
            dtDetails.AcceptChanges();
        }

        /// <summary>
        /// Accept change on interface into datatable, keeping same focus
        /// </summary>
        private void AcceptChanges()
        {
            int iFocusRow = GetSelectedRowIndex();
            grdInvAdjustment.Refresh();
            gridView.FocusedRowHandle = iFocusRow;
            dtDetails.AcceptChanges();
        }

        /// <summary>
        /// Implement Validate data
        /// </summary>
        /// <returns></returns>
        protected override bool Validate()
        {
            Validator objValidator = new Validator();
            if (!(objValidator.IsNonEmpty("Name", txtName.Text, true))) 
            {
                txtName.Focus();
                return false;
            }
            if (Toolkit.DbToolKit.IsDataOfSqlExists("SELECT ID,Name FROM InventoryAdjustmentMaster WHERE Name = '" + txtName.Text + "' AND ID <> '" + this.DataModel.AdjustId + "'"))
            {
                MessageBox.Show("This name is already available, please select another one");
                txtName.Focus();
                return false;
            }
            if (!objValidator.IsDateTime("Created Date", this.dtmDateCreated.Text))
            {
                dtmDateCreated.Focus();
                return false;
            }
            if (dtDetails.Rows.Count <=0) {
                MessageBox.Show("Please add the product item in the grid");
                btnAdd.Focus();
                return false;
            }

            foreach (DataRow dr in dtDetails.Rows)
            {
                int i = dtDetails.Rows.IndexOf(dr) + 1;
                String strTemp = dr["Location"].ToString();
                if (!objValidator.IsNonEmpty("Line " + i + " :location", strTemp))
                {
                    return false;
                }
                strTemp = dr["Product"].ToString();
                if (!objValidator.IsNonEmpty("Line " + i + " :product", strTemp))
                {
                    return false;
                }
                strTemp = dr["Quantity"].ToString();
                if (!objValidator.IsDecimal("Line " + i + " :quantity", strTemp))
                {
                    return false;
                }
            }
            Inventory.DataObjects.DAO.InventoryAdjustmentDao oDao = new Inventory.DataObjects.DAO.InventoryAdjustmentDao();
            if (oDao.IsExistAdjustmentNameMaster(txtName.Text.Trim()))
            {
                if ((m_Name == null) || ((m_Name != null) && (m_Name != txtName.Text.Trim())))
                {
                    MessageBox.Show("Name is exited", "Error");
                    txtName.Focus();
                    return false;
                }
                
            }
            if (gridView.RowCount == 0)
            {
                MessageBox.Show("Can not add a empty Adjustment. Please add some items to grid", "Error");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Implement ReadToDataModel
        /// </summary>
        protected override void ReadToDataModel()
        {
            model.AdjustName = this.txtName.Text;
            model.DateCreated = DateUtils.ParseDate(this.dtmDateCreated.Text);
            model.AdjustDetails = (DataTable)this.grdInvAdjustment.DataSource;
            model.Notes = this.memReason.Text;
            model.ViewStatus = this.chkShow.Checked;
            
        }

        override protected bool CheckQuantityOnHand()
        {
            DataRow dr = GetSelectedRow();
            String strQuantity = dr["Quantity"].ToString();
            String strWarehouse = dr["Warehouse"].ToString();
            String strProduct = dr["Product"].ToString();
            String strLocation = dr["Location"].ToString();
            //If any of the field is null, no need tovalidate
            if (String.IsNullOrEmpty(strQuantity) || String.IsNullOrEmpty(strWarehouse)
                || String.IsNullOrEmpty(strLocation) || String.IsNullOrEmpty(strProduct)) return true;
            try
            {
                Decimal dQty = Convert.ToDecimal(strQuantity);
                Decimal dAvailQty = Mediator.GetInstance().GetOnHandQty(strWarehouse, strLocation, strProduct);
                if (dQty < 0 && System.Math.Abs(dQty) > dAvailQty)
                {
                    MessageBox.Show("Reduction quantity is greater than available quantity", "Warning");
                    dr["Quantity"] = -dAvailQty;
                    return false;
                }
                return true;
            }
            catch
            {
                return true;
            }
        }

        private void InventoryAdjustment_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }
    }
}

