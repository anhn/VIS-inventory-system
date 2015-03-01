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
    /// Summary description for StockTransfer.
    /// </summary>
    public class StockTransfer : BaseWarehouse
    {

        private DevExpress.XtraGrid.GridControl grdDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private TextEdit txtStockTransfer;
        private Label lblStockTransfer;

        //Stock Transfer Model
        private StockTransferModel model = new StockTransferModel();

        /// <summary>
        /// Get/set data model StockTransfer 
        /// </summary>
        public StockTransferModel DataModel
        {
            get { return model; }
            set { model = value; }
        }

        private void InitializeComponent()
        {
            this.txtStockTransfer = new DevExpress.XtraEditors.TextEdit();
            this.lblStockTransfer = new System.Windows.Forms.Label();
            this.grdDetails = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.repoWarehouseLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoLocationLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoProductLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoPackageLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoToWarehouseLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoToLocationLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockTransfer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.TabIndex = 8;
            // 
            // dtmDateCreated
            // 
            this.dtmDateCreated.TabIndex = 2;
            // 
            // txtStockTransfer
            // 
            this.txtStockTransfer.Location = new System.Drawing.Point(136, 15);
            this.txtStockTransfer.Name = "txtStockTransfer";
            this.txtStockTransfer.Size = new System.Drawing.Size(156, 21);
            this.txtStockTransfer.TabIndex = 1;
            // 
            // lblStockTransfer
            // 
            this.lblStockTransfer.AutoSize = true;
            this.lblStockTransfer.Location = new System.Drawing.Point(8, 21);
            this.lblStockTransfer.Name = "lblStockTransfer";
            this.lblStockTransfer.Size = new System.Drawing.Size(122, 14);
            this.lblStockTransfer.TabIndex = 17;
            this.lblStockTransfer.Text = "Stock Transfer Name";
            // 
            // grdDetails
            // 
            this.grdDetails.EmbeddedNavigator.Name = "";
            this.grdDetails.Location = new System.Drawing.Point(12, 106);
            this.grdDetails.MainView = this.gridView1;
            this.grdDetails.Name = "grdDetails";
            this.grdDetails.Size = new System.Drawing.Size(544, 189);
            this.grdDetails.TabIndex = 6;
            this.grdDetails.TabStop = false;
            this.grdDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdDetails;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // StockTransfer
            // 
            this.ClientSize = new System.Drawing.Size(578, 336);
            this.Controls.Add(this.txtStockTransfer);
            this.Controls.Add(this.lblStockTransfer);
            this.Controls.Add(this.grdDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "StockTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Transfers";
            this.Load += new System.EventHandler(this.StockTransfer_Load);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.grdDetails, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.dtmDateCreated, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblStockTransfer, 0);
            this.Controls.SetChildIndex(this.txtStockTransfer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.repoWarehouseLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoLocationLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoProductLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoPackageLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoToWarehouseLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoToLocationLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockTransfer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public StockTransfer()
        {
            this.InitializeComponent();
            dtDetails = new System.Data.DataTable();
            grdDetails.DataSource = dtDetails;
        }
        // Begin of KienPD Editing
        public string m_Name;
        public StockTransfer(string strStockTransfer)
        {
            m_Name = strStockTransfer;
            this.InitializeComponent();
            dtDetails = new System.Data.DataTable();
            grdDetails.DataSource = dtDetails;
        }
        // End of KienPD Editing

        #region Event Methods
        /// <summary>
        /// gridView_CellValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //    if ("colWarehouse".Equals(e.Column.Name) ||
        //        "colProduct".Equals(e.Column.Name) ||
        //        "colLocation".Equals(e.Column.Name) ||
        //        "colQuantity".Equals(e.Column.Name))
        //    {
        //        CheckQuantityOnHand();
        //    }
        //}
        #endregion

        #region Additional Methods
        /// <summary>
        /// Binding data to dialog
        /// </summary>
        /// <param name="objModel">StockTransferModel</param>
        public void BindData(StockTransferModel objModel)
        {
            //this.txtStockTransfer.Text = string.Empty;
            //this.dtmDateCreated.Text = DateTime.Now.ToShortDateString();

            //In case of adding new packing list, initialize the grid with nodata
            if (objModel == null)
            {
                model = new StockTransferModel();
                model.StockTransferDetails = Mediator.GetInstance().GetEmptyStockTransferDetails();
            }
            else
            {
                model = objModel;
            }

            this.txtStockTransfer.Text = model.StockTransferName;
            this.dtmDateCreated.Text = model.DateCreated.ToShortDateString();
            this.dtDetails = model.StockTransferDetails;

            grdDetails.DataSource = dtDetails;

            //Get grid view
            gridView = (GridView)this.grdDetails.Views[0];

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
            gridView.Columns["StockTransferID"].Visible = false;
            gridView.Columns["Warehouse"].ColumnEdit = repoWarehouseLookUp;
            gridView.Columns["To Warehouse"].ColumnEdit = repoToWarehouseLookUp;
            gridView.Columns["To Location"].ColumnEdit = this.repoToLocationLookUp;
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
            grdDetails.Refresh();
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
            if (!(objValidator.IsNonEmpty("Stock Transfer Name", txtStockTransfer.Text)))  
            {
                txtStockTransfer.Focus();
                return false;
            }
            if (Toolkit.DbToolKit.IsDataOfSqlExists("SELECT ID,Name FROM StockTransferMaster WHERE Name = '" + txtStockTransfer.Text + "' AND ID <> '" + this.DataModel.StockTransferId + "'"))
            {
                MessageBox.Show("This name is already available, please select another one");
                txtStockTransfer.Focus();
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
                if (!objValidator.IsPositiveDecimal("Line " + i + " :quantity", strTemp))
                {
                    return false;
                }
            }
            //check Exited
            Inventory.DataObjects.DAO.StockTransferDao oDao = new Inventory.DataObjects.DAO.StockTransferDao();
            if (oDao.IsExistStockTransferNameMaster(txtStockTransfer.Text.Trim()))
            {
                if ((m_Name == null) || ((m_Name != null) && (m_Name != txtStockTransfer.Text.Trim())))
                {
                    MessageBox.Show("Stock Tranfer Name is existed !", "Error");
                    txtStockTransfer.Focus();
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Implement ReadToDataModel
        /// </summary>
        protected override void ReadToDataModel()
        {
            model.StockTransferName = this.txtStockTransfer.Text;
            model.DateCreated = DateUtils.ParseDate(this.dtmDateCreated.Text);
            model.StockTransferDetails = (DataTable)this.grdDetails.DataSource;
        }

        #endregion


        private void StockTransfer_Load(object sender, EventArgs e)
        {
            txtStockTransfer.Focus();
        }

    }
}
