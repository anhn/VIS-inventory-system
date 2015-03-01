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
using Inventory.Forms.Binder;
using Toolkit;

namespace Inventory.Forms.Warehouse
{
    /// <summary>
    /// Summary description for StockOut.
    /// </summary>
    public class StockOut : BaseWarehouse
    {

        private DevExpress.XtraGrid.GridControl grdDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private TextEdit txtStockOut;
        private Label lblStockOut;
        private ComboBoxEdit cboWarehouse;
        private ComboBoxEdit cboLocation;
        private Label label2;
        private Label label3;
        private MemoEdit txtDesc;
        private Label label4;

        //Stock Transfer Model
        private StockOutModel model = new StockOutModel();

        private bool isBinding = false;
        /// <summary>
        /// Get/set data model StockOut 
        /// </summary>
        public StockOutModel DataModel
        {
            get { return model; }
            set { model = value; }
        }

        private void InitializeComponent()
        {
            this.txtStockOut = new DevExpress.XtraEditors.TextEdit();
            this.lblStockOut = new System.Windows.Forms.Label();
            this.grdDetails = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboWarehouse = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboLocation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new DevExpress.XtraEditors.MemoEdit();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repoWarehouseLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoLocationLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoProductLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoPackageLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoToWarehouseLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoToLocationLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockOut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboWarehouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(479, 156);
            this.btnFind.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(301, 156);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(390, 156);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(192, 389);
            this.btnSave.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(295, 389);
            this.btnClose.TabIndex = 11;
            // 
            // dtmDateCreated
            // 
            this.dtmDateCreated.Location = new System.Drawing.Point(416, 13);
            this.dtmDateCreated.Size = new System.Drawing.Size(150, 21);
            this.dtmDateCreated.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(312, 16);
            // 
            // txtStockOut
            // 
            this.txtStockOut.Location = new System.Drawing.Point(83, 13);
            this.txtStockOut.Name = "txtStockOut";
            this.txtStockOut.Size = new System.Drawing.Size(184, 21);
            this.txtStockOut.TabIndex = 1;
            // 
            // lblStockOut
            // 
            this.lblStockOut.AutoSize = true;
            this.lblStockOut.Location = new System.Drawing.Point(9, 16);
            this.lblStockOut.Name = "lblStockOut";
            this.lblStockOut.Size = new System.Drawing.Size(38, 14);
            this.lblStockOut.TabIndex = 17;
            this.lblStockOut.Text = "Name";
            // 
            // grdDetails
            // 
            this.grdDetails.EmbeddedNavigator.Name = "";
            this.grdDetails.Location = new System.Drawing.Point(12, 194);
            this.grdDetails.MainView = this.gridView1;
            this.grdDetails.Name = "grdDetails";
            this.grdDetails.Size = new System.Drawing.Size(544, 189);
            this.grdDetails.TabIndex = 9;
            this.grdDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdDetails;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // cboWarehouse
            // 
            this.cboWarehouse.Location = new System.Drawing.Point(83, 57);
            this.cboWarehouse.Name = "cboWarehouse";
            this.cboWarehouse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboWarehouse.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboWarehouse.Size = new System.Drawing.Size(184, 21);
            this.cboWarehouse.TabIndex = 3;
            this.cboWarehouse.SelectedValueChanged += new System.EventHandler(this.cboWarehouse_SelectedValueChanged);
            // 
            // cboLocation
            // 
            this.cboLocation.Location = new System.Drawing.Point(416, 57);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLocation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboLocation.Size = new System.Drawing.Size(150, 21);
            this.cboLocation.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 14);
            this.label2.TabIndex = 21;
            this.label2.Text = "Warehouse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 14);
            this.label3.TabIndex = 22;
            this.label3.Text = "Location";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(83, 92);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(184, 87);
            this.txtDesc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 24;
            this.label4.Text = "Description";
            // 
            // StockOut
            // 
            this.ClientSize = new System.Drawing.Size(578, 424);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboLocation);
            this.Controls.Add(this.cboWarehouse);
            this.Controls.Add(this.txtStockOut);
            this.Controls.Add(this.lblStockOut);
            this.Controls.Add(this.grdDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "StockOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Out";
            this.Load += new System.EventHandler(this.StockOut_Load);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.grdDetails, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.dtmDateCreated, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblStockOut, 0);
            this.Controls.SetChildIndex(this.txtStockOut, 0);
            this.Controls.SetChildIndex(this.cboWarehouse, 0);
            this.Controls.SetChildIndex(this.cboLocation, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtDesc, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.repoWarehouseLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoLocationLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoProductLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoPackageLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoToWarehouseLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoToLocationLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockOut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboWarehouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public StockOut()
        {
            this.InitializeComponent();
            dtDetails = new System.Data.DataTable();
            grdDetails.DataSource = dtDetails;
        }

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
        /// <param name="objModel">StockOutModel</param>
        public void BindData(StockOutModel objModel)
        {
            isBinding = true;
            //In case of adding new packing list, initialize the grid with nodata
            if (objModel == null)
            {
                model = new StockOutModel();
                model.Details = Mediator.GetInstance().GetEmptyStockOutDetails();
            }
            else
            {
                model = objModel;
            }

            this.txtStockOut.Text = model.Name;

            DataTable dt = Mediator.GetInstance().GetAllWarehouse();

            XComboBinder binder = new XComboBinder();
            binder.BindComboBox(cboWarehouse, dt, "Description", "Warehouse_id");
            dt = Mediator.GetInstance().GetAllLocations();
            binder.BindComboBox(cboLocation, dt, "Bin_location_id", "Bin_location_id");

            XTagItem itemLoc = XTagItem.GetItemByValue(cboLocation.Properties.Items, model.Location);
            XTagItem itemWare = XTagItem.GetItemByValue(cboWarehouse.Properties.Items, model.Warehouse);

            //Bind warehouse first, location second
            cboWarehouse.SelectedItem = itemWare;
            cboLocation.SelectedItem = itemLoc;

            this.dtmDateCreated.Text = model.DateCreated.ToShortDateString();
            this.dtDetails = model.Details;
            this.txtDesc.Text = model.Desc;

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
            gridView.Columns["StockOutID"].Visible = false;            
            gridView.Columns["Product"].ColumnEdit = repoProductLookUp;
            
            gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridView_CellValueChanged);

            isBinding = false;
        }

        /// <summary>
        /// Override this function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            /*
            if ("colWarehouse".Equals(e.Column.Name) ||
                "colProduct".Equals(e.Column.Name) ||
                "colLocation".Equals(e.Column.Name) ||
                "colQuantity".Equals(e.Column.Name))
            {
                CheckQuantityOnHand();
            }
             * */
        }

        

        /// <summary>
        /// Implement Validate data
        /// </summary>
        /// <returns></returns>
        protected override bool Validate()
        {
            Validator objValidator = new Validator();
            if (Toolkit.DbToolKit.IsDataOfSqlExists("SELECT ID,Name FROM StockOutMaster WHERE Name = '" + txtStockOut.Text.Trim() + "' AND ID <> '" + this.DataModel.Id + "'"))
            {
                MessageBox.Show("This stock in name is already available, please select another one");
                txtStockOut.Focus();
                return false;
            }
            if (!objValidator.IsNonEmpty("Name", this.txtStockOut.Text))
            {
                txtStockOut.Focus();
                return false;
            }

            if (!objValidator.IsNotNull("Warehouse", this.cboWarehouse.SelectedItem))
            {
                cboWarehouse.Focus();
                return false;
            }

            if (!objValidator.IsNotNull("Location", this.cboLocation.SelectedItem))
            {
                cboLocation.Focus();
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
                String strTemp = dr["Product"].ToString();
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
            return true;
        }

        /// <summary>
        /// Implement ReadToDataModel
        /// </summary>
        protected override void ReadToDataModel()
        {
            model.Name = this.txtStockOut.Text;
            model.Location = ((XTagItem)this.cboLocation.SelectedItem).Value;
            model.Warehouse = ((XTagItem)this.cboWarehouse.SelectedItem).Value;
            model.Desc = this.txtDesc.Text;
            model.DateCreated = DateUtils.ParseDate(this.dtmDateCreated.Text);
            model.Details = (DataTable)this.grdDetails.DataSource;
        }

        #endregion


        private void cboWarehouse_SelectedValueChanged(object sender, EventArgs e)
        {
            //If the form is bing binded with data or if no location or warehouse seleted
            //Skip this action
            if (isBinding) return;

            if (isBinding) return;
            if (cboWarehouse.EditValue == null)
            {
                return;
            }

            String strWarehouse = ((XTagItem)cboWarehouse.EditValue).Value;
            DataTable dt = Mediator.GetInstance().GetLocationsOfWareHouse(strWarehouse);
            XComboBinder binder = new XComboBinder();
            binder.BindComboBox(cboLocation, dt, "Bin_location_id", "Bin_location_id");
            //If no location currently selected then nothing need to be done
            //When warehouse changed, if location does not belong to warehouse then location box 
            //need to be cleared
            //Otherwise, location should stay the same as before
            if (cboLocation.EditValue == null) return;
            String strCurrentLocation = ((XTagItem)cboLocation.EditValue).Value;
            XTagItem objNewLocation = XTagItem.GetItemByValue(cboLocation.Properties.Items, strCurrentLocation);
            cboLocation.SelectedItem = objNewLocation;

        }

        private void StockOut_Load(object sender, EventArgs e)
        {
            txtStockOut.Focus();
        }

    }
}
