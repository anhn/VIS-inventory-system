using System;
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
using System.IO;
using Toolkit;


namespace Inventory.Forms.Warehouse
{
    /// <summary>
    /// Summary description for PackingList.
    /// </summary>
    public class PackingList : DevExpress.XtraEditors.XtraForm
    {
        private Label label1;
        private Label label2;
        private SimpleButton btnFind;
        private SimpleButton btnDelete;
        private SimpleButton btnAdd;
        private TextEdit txtPackingName;
        private DateEdit dtmDateCreated;
        private DevExpress.XtraGrid.GridControl grdPackingDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private SimpleButton btnClose;
        private SimpleButton btnSave;
        private RepositoryItemLookUpEdit repoWarehouseLookUp = new RepositoryItemLookUpEdit();
        private RepositoryItemLookUpEdit repoLocationLookUp = new RepositoryItemLookUpEdit();
        private RepositoryItemLookUpEdit repoProductLookUp = new RepositoryItemLookUpEdit();
        private RepositoryItemLookUpEdit repoPackageLookUp = new RepositoryItemLookUpEdit();
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private DataTable dtDetails;
        private GridView gridView = null;
        private DataTable dtProducts = null;
        private DataTable dtLocations = null;
        private CheckEdit chkShowPacking;
        private MemoEdit txtNotes;
        private Label label7;
        private PackingListModel model = new PackingListModel();

        public PackingListModel DataModel
        {
            get { return model; }
            set { model = value; }
        }

        public PackingList()
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
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtPackingName = new DevExpress.XtraEditors.TextEdit();
            this.dtmDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.grdPackingDetail = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.chkShowPacking = new DevExpress.XtraEditors.CheckEdit();
            this.txtNotes = new DevExpress.XtraEditors.MemoEdit();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPackingName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPackingDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowPacking.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Packing Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date Created:";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(466, 52);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(83, 23);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "&Find Products";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(369, 52);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Delete Item";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(272, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add Item";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPackingName
            // 
            this.txtPackingName.Location = new System.Drawing.Point(107, 12);
            this.txtPackingName.Name = "txtPackingName";
            this.txtPackingName.Size = new System.Drawing.Size(176, 21);
            this.txtPackingName.TabIndex = 1;
            // 
            // dtmDateCreated
            // 
            this.dtmDateCreated.EditValue = new System.DateTime(2007, 5, 11, 0, 0, 0, 0);
            this.dtmDateCreated.Location = new System.Drawing.Point(404, 12);
            this.dtmDateCreated.Name = "dtmDateCreated";
            this.dtmDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmDateCreated.Size = new System.Drawing.Size(144, 21);
            this.dtmDateCreated.TabIndex = 2;
            // 
            // grdPackingDetail
            // 
            this.grdPackingDetail.EmbeddedNavigator.Name = "";
            this.grdPackingDetail.Location = new System.Drawing.Point(12, 83);
            this.grdPackingDetail.MainView = this.gridView1;
            this.grdPackingDetail.Name = "grdPackingDetail";
            this.grdPackingDetail.Size = new System.Drawing.Size(541, 158);
            this.grdPackingDetail.TabIndex = 6;
            this.grdPackingDetail.TabStop = false;
            this.grdPackingDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdPackingDetail;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowColumnResizing = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(289, 319);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(179, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkShowPacking
            // 
            this.chkShowPacking.Location = new System.Drawing.Point(433, 254);
            this.chkShowPacking.Name = "chkShowPacking";
            this.chkShowPacking.Properties.Caption = "Show Packing List";
            this.chkShowPacking.Size = new System.Drawing.Size(120, 19);
            this.chkShowPacking.TabIndex = 8;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(53, 254);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(298, 53);
            this.txtNotes.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "Notes:";
            // 
            // PackingList
            // 
            this.ClientSize = new System.Drawing.Size(565, 348);
            this.Controls.Add(this.chkShowPacking);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdPackingDetail);
            this.Controls.Add(this.dtmDateCreated);
            this.Controls.Add(this.txtPackingName);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PackingList";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Packing List";
            this.Load += new System.EventHandler(this.PackingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPackingName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPackingDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowPacking.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
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
                btnSave_Click(btnSave, EventArgs.Empty);
            }
            else
            {
                this.Close();
            }
        }


        public void BindData(PackingListModel objModel)
        {
            dtmDateCreated.Text = DateTime.Now.ToShortDateString();
            //In case of adding new packing list, initialize the grid with nodata
            if (objModel == null)
            {
                model = new PackingListModel();
                model.PackingDetails = Mediator.GetInstance().GetEmptyListPackingDetail();
            }
            else
            {
                model = objModel;                
            }

            txtPackingName.Text = model.PackingName;
            dtmDateCreated.Text = model.DateCreated.ToShortDateString();
            txtNotes.Text = model.Notes;
            chkShowPacking.Checked = model.ViewStatus;
                        
            dtDetails = model.PackingDetails;
            dtDetails.Columns.Add("QtyAvail");

            grdPackingDetail.DataSource = dtDetails;            

            gridView = (GridView)grdPackingDetail.Views[0];
            foreach (GridColumn cl in gridView.Columns)
            {
                //cl.Visible = false;
                cl.MinWidth = 10;
                cl.AppearanceHeader.Font = Settings.Default.cfgDefaultFont;
                cl.AppearanceCell.Font = Settings.Default.cfgDefaultFont;
            }

            gridView.Columns["PackingListID"].Visible = false;           
            gridView.Columns["QtyAvail"].Visible = false;
            gridView.Columns["ID"].Visible = false;

            gridView.Columns["Warehouse"].Width = 100;
            gridView.Columns["Location"].Width = 90;
            gridView.Columns["Product"].Width = 100;
           // gridView.Columns["Old Qty"].Width = 90;
           // gridView.Columns["New Qty"].Width = 90;


            //dtLocationProducts = Mediator.GetInstance().GetAllLocationProducts();

            //repoWarehouseLookUp.QueryPopUp += new CancelEventHandler(repoWarehouseLookUp_QueryPopUp);
            repoWarehouseLookUp.EditValueChanged += new EventHandler(repoWarehouseLookUp_EditValueChanged);
            repoWarehouseLookUp.DisplayMember = "Description";
            repoWarehouseLookUp.ValueMember = "Warehouse_id";
            repoWarehouseLookUp.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Warehouse", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            repoWarehouseLookUp.DataSource = Mediator.GetInstance().GetAllWarehouse();
            

            repoLocationLookUp.QueryPopUp += new CancelEventHandler(repoLocationLookUp_QueryPopUp);
            repoLocationLookUp.DisplayMember = "bin_location_id";
            repoLocationLookUp.ValueMember = "bin_location_id";
            repoLocationLookUp.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("bin_location_id", "Location", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            dtLocations = Mediator.GetInstance().GetAllLocations();
            repoLocationLookUp.DataSource = dtLocations;


            repoProductLookUp.EditValueChanged += new EventHandler(repoProductLookUp_EditValueChanged);
            repoProductLookUp.DisplayMember = "ProductName";
            repoProductLookUp.ValueMember = "ProductId";
            repoProductLookUp.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Product", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            dtProducts = Mediator.GetInstance().GetAllProductNames();
            repoProductLookUp.DataSource = dtProducts;

            repoPackageLookUp.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Package", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            repoPackageLookUp.DisplayMember = "Name";
            repoPackageLookUp.ValueMember = "Code";
            repoPackageLookUp.DataSource = Mediator.GetInstance().GetAllPackage();

            gridView.Columns["Warehouse"].ColumnEdit = repoWarehouseLookUp;
            gridView.Columns["Location"].ColumnEdit = repoLocationLookUp;
            gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridView_CellValueChanged);
            gridView.Columns["Product"].ColumnEdit = repoProductLookUp;
            gridView.Columns["Package code"].ColumnEdit = repoPackageLookUp;
            dtDetails.AcceptChanges();
        }

        void repoWarehouseLookUp_QueryPopUp(object sender, CancelEventArgs e)
        {
            RemoveFilterOnLocation();
        }

        void repoProductLookUp_QueryPopUp(object sender, CancelEventArgs e)
        {
            RemoveFilterOnLocation();
        }

        void repoLocationLookUp_QueryPopUp(object sender, CancelEventArgs e)
        {
            FilterSelectionByWarehouse();
            /*
            DataRow dr = GetSelectedRow();
            String strWarehouse = dr["Warehouse"];
            if (String.IsNullOrEmpty(strWarehouse))
            {

            }
             * */
        }

        void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if("colWarehouse".Equals(e.Column.Name) ||
                "colProduct".Equals(e.Column.Name) ||
                "colLocation".Equals(e.Column.Name) ||
                "colQuantity".Equals(e.Column.Name) )
            {
                CheckQuantityOnHand();
            }
        }

        void repoWarehouseLookUp_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit le = (DevExpress.XtraEditors.LookUpEdit)sender;
            String strNewWarehouse = le.EditValue.ToString();
            //dtDetails.AcceptChanges();
            UpdateLocation(strNewWarehouse);
            UpdateQuantityAvailable();
        }

        

        void repoProductLookUp_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit le = (DevExpress.XtraEditors.LookUpEdit)sender;
            String strNewProduct = le.EditValue.ToString();
            UpdateUOM(strNewProduct);
            
             
        }


        private void ReadToDataModel()
        {
            model.PackingName = txtPackingName.Text;
            model.DateCreated = DateUtils.ParseDate(this.dtmDateCreated.Text);
            model.PackingDetails = (DataTable)this.grdPackingDetail.DataSource;
            model.Notes = txtNotes.Text;
            model.ViewStatus = chkShowPacking.Checked;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow dr = dtDetails.NewRow();
            for (int i = 0; i < dr.ItemArray.Length; i++)
            {
                if (dtDetails.Columns[i].DataType == typeof(String))
                {
                    dr[i] = String.Empty;
                }
                else if (dtDetails.Columns[i].DataType == typeof(Decimal))
                {
                    dr[i] = 0;
                }
                else
                {
                    dr[i] = null;
                }
            }
            dtDetails.Rows.Add(dr);
        }

        private DataRow GetSelectedRow()
        {
            int[] selectedRows = gridView.GetSelectedRows();
            if (selectedRows.Length == 0) return null;
            int i = selectedRows[0];
            DataRow row = dtDetails.Rows[i];
            return row;
        }

        private void UpdateQuantityAvailable()
        {
            //throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// Check if the current location match with the new warehouse, if not
        /// then clear the current value of location
        /// </summary>
        /// <param name="strWarehouse"></param>
        private void UpdateLocation(String strWarehouse)
        {
            
            DataRow dr = GetSelectedRow();
            if (dr == null) return;

            String strLocation = dr["Location"].ToString();

            //Don't have to care if location already empty
            if (String.IsNullOrEmpty(strLocation)) return;

            StringWriter wr = new StringWriter();
            if (!String.IsNullOrEmpty(strWarehouse))
            {
                wr.Write("Warehouse_id = '" + strWarehouse + "' ");
            }

            wr.Write(" and Bin_location_id = '" + strLocation + "' ");
            
            //If the warehouse and location not match then clear location
            dtLocations.DefaultView.RowFilter = wr.ToString();
            if (dtLocations.DefaultView.Count == 0)
            {
                dr["Location"] = "";
            }

        }

        private void UpdateUOM(String strProduct)
        {
            DataRow dr = GetSelectedRow();
            if ( dr == null ) return;

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

        private int GetSelectedRowIndex()
        {
            gridView.TopRowIndex = 0;
            return gridView.FocusedRowHandle;
            /*
            int[] selectedRows = gridView.FocusedRowHandle;
            if (selectedRows.Length > 0)
            {
                return selectedRows[0];
            }
            else
            {
                return -1;
            }
             * */
        }

        /// <summary>
        /// Accept change on interface into datatable, keeping same focus
        /// </summary>
        private void AcceptChanges()
        {
            int iFocusRow = GetSelectedRowIndex();
            grdPackingDetail.Refresh();
            gridView.FocusedRowHandle = iFocusRow;
            dtDetails.AcceptChanges();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete the selected Row
            int i = GetSelectedRowIndex();
            if (i < 0) return;
            dtDetails.Rows.RemoveAt(i);
        }

        private bool Validate()
        {
            Validator val = new Validator();            
            if (!val.IsNonEmpty("Packing name",txtPackingName.Text))
            {
                txtPackingName.Focus();
                return false;
            }
            if (Toolkit.DbToolKit.IsDataOfSqlExists("SELECT PackingListName FROM PackingListMaster WHERE PackingListName = '" + txtPackingName.Text.Trim() + "' AND PackingListID <> '" + this.DataModel.PackingListId + "'"))
            {
                MessageBox.Show("This packing name is already available, please select another one");
                txtPackingName.Focus();
                return false;
            }

            if (!val.IsDateTime("Created Date",dtmDateCreated.Text))
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
                if (!val.IsNonEmpty("Line " + i + " :location", strTemp ))
                {
                    return false;
                }
                strTemp = dr["Product"].ToString();
                if (!val.IsNonEmpty("Line " + i + " :product", strTemp))
                {
                    return false;
                }
                strTemp = dr["Quantity"].ToString();
                if (!val.IsPositiveDecimal("Line " + i + " :quantity", strTemp))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validate()) return;
            ReadToDataModel();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FilterSelectionByWarehouse()
        {
            DataRow dr = GetSelectedRow();
            if (dr == null) return;
            String strWarehouse = dr["Warehouse"].ToString();            
            String strLocation = dr["Location"].ToString();
            StringWriter wr = new StringWriter();
            if (!String.IsNullOrEmpty(strWarehouse))
            {
                wr.Write("Warehouse_id = '" + strWarehouse + "' ");
            }
            
            dtLocations.DefaultView.RowFilter = wr.ToString();
        }

        private void RemoveFilterOnLocation()
        {
            dtLocations.DefaultView.RowFilter = "";
        }

        private bool CheckQuantityOnHand()
        {
            DataRow dr = GetSelectedRow();
            String strQuantity = dr["Quantity"].ToString();
            String strWarehouse = dr["Warehouse"].ToString();
            String strProduct = dr["Product"].ToString();
            String strLocation = dr["Location"].ToString();
            //If any of the field is null, no need tovalidate
            if (String.IsNullOrEmpty(strQuantity) ||String.IsNullOrEmpty(strWarehouse)
                || String.IsNullOrEmpty(strLocation)|| String.IsNullOrEmpty(strProduct)) return true;
            try
            {
                Decimal dQty = Convert.ToDecimal(strQuantity);
                Decimal dAvailQty = Mediator.GetInstance().GetOnHandQty(strWarehouse,strLocation,strProduct);
                if (dQty > dAvailQty)
                {
                    MessageBox.Show("Quantity is greater than available quantity", "Warning");
                    dr["Quantity"] = dAvailQty;
                    return false;
                }
                return true;
            }
            catch
            {
                return true;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
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

            dr["Warehouse"] = frmFind.WarehouseID;
            dr["Location"] = frmFind.LocationID;
            dr["Product"] = frmFind.ProductID;
        }

        private void PackingList_Load(object sender, EventArgs e)
        {
            txtPackingName.Focus();
        }
    }
}

