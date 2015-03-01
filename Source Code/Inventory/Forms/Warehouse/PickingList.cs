using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;
using Inventory.DataModels.Warehouse;
using Inventory.DataModels;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using Inventory.Utils;
using DevExpress.XtraGrid.Columns;
using Inventory.Properties;
using System.IO;
using Toolkit;


namespace Inventory.Forms.Warehouse
{
    /// <summary>
    /// Summary description for PickingList.
    /// </summary>
    public class PickingList : DevExpress.XtraEditors.XtraForm
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private SimpleButton btnAdd;
        private SimpleButton btnDelete;
        private SimpleButton btnFind;
        private TextEdit txtPickingName;
        private TextEdit txtReferenceNo;
        private TextEdit txtOtherLocation;
        private ComboBoxEdit cboDestLocation;
        private ComboBoxEdit cboDestDepart;
        private DevExpress.XtraGrid.GridControl grdPickingDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Label label7;
        private MemoEdit txtNotes;
        private CheckEdit chkShowPicking;
        private SimpleButton btnSave;
        private SimpleButton btnClose;
        private DateEdit dtmDateCreated;
        
        private PickingListModel model = new PickingListModel();
        private DataTable dtDetails = new DataTable();
        private RepositoryItemLookUpEdit repoWarehouseLookUp = new RepositoryItemLookUpEdit();
        private RepositoryItemLookUpEdit repoLocationLookUp = new RepositoryItemLookUpEdit();
        private RepositoryItemLookUpEdit repoProductLookUp = new RepositoryItemLookUpEdit();
        private RepositoryItemLookUpEdit repoPackageLookUp = new RepositoryItemLookUpEdit();
        private DataTable dtLocations = null;

        private DataTable dtProducts = null;


        private GridView gridView = null;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        
        public PickingListModel DataModel
        {
            get { return model; }
            set { model = value; }
        }


        public PickingList()
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            this.txtPickingName = new DevExpress.XtraEditors.TextEdit();
            this.txtReferenceNo = new DevExpress.XtraEditors.TextEdit();
            this.txtOtherLocation = new DevExpress.XtraEditors.TextEdit();
            this.cboDestLocation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboDestDepart = new DevExpress.XtraEditors.ComboBoxEdit();
            this.grdPickingDetails = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNotes = new DevExpress.XtraEditors.MemoEdit();
            this.chkShowPicking = new DevExpress.XtraEditors.CheckEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.dtmDateCreated = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPickingName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferenceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtherLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDestLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDestDepart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPickingDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowPicking.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDateCreated.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Picking Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reference No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dest. Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Other Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date Created:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Dest. Depart:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(275, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Add Item";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(372, 149);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "&Delete Item";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(469, 149);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(83, 23);
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "&Find Products";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtPickingName
            // 
            this.txtPickingName.Location = new System.Drawing.Point(100, 17);
            this.txtPickingName.Name = "txtPickingName";
            this.txtPickingName.Size = new System.Drawing.Size(175, 21);
            this.txtPickingName.TabIndex = 1;
            // 
            // txtReferenceNo
            // 
            this.txtReferenceNo.Location = new System.Drawing.Point(100, 50);
            this.txtReferenceNo.Name = "txtReferenceNo";
            this.txtReferenceNo.Size = new System.Drawing.Size(175, 21);
            this.txtReferenceNo.TabIndex = 3;
            // 
            // txtOtherLocation
            // 
            this.txtOtherLocation.Location = new System.Drawing.Point(100, 116);
            this.txtOtherLocation.Name = "txtOtherLocation";
            this.txtOtherLocation.Size = new System.Drawing.Size(451, 21);
            this.txtOtherLocation.TabIndex = 6;
            // 
            // cboDestLocation
            // 
            this.cboDestLocation.Location = new System.Drawing.Point(100, 83);
            this.cboDestLocation.Name = "cboDestLocation";
            this.cboDestLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDestLocation.Size = new System.Drawing.Size(175, 21);
            this.cboDestLocation.TabIndex = 4;
            // 
            // cboDestDepart
            // 
            this.cboDestDepart.Location = new System.Drawing.Point(376, 83);
            this.cboDestDepart.Name = "cboDestDepart";
            this.cboDestDepart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDestDepart.Size = new System.Drawing.Size(175, 21);
            this.cboDestDepart.TabIndex = 5;
            // 
            // grdPickingDetails
            // 
            this.grdPickingDetails.EmbeddedNavigator.Name = "";
            this.grdPickingDetails.Location = new System.Drawing.Point(18, 181);
            this.grdPickingDetails.MainView = this.gridView1;
            this.grdPickingDetails.Name = "grdPickingDetails";
            this.grdPickingDetails.Size = new System.Drawing.Size(533, 154);
            this.grdPickingDetails.TabIndex = 10;
            this.grdPickingDetails.TabStop = false;
            this.grdPickingDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdPickingDetails;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(60, 348);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(298, 53);
            this.txtNotes.TabIndex = 12;
            // 
            // chkShowPicking
            // 
            this.chkShowPicking.Location = new System.Drawing.Point(387, 348);
            this.chkShowPicking.Name = "chkShowPicking";
            this.chkShowPicking.Properties.Caption = "Show Picking List";
            this.chkShowPicking.Size = new System.Drawing.Size(120, 19);
            this.chkShowPicking.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(194, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(304, 410);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtmDateCreated
            // 
            this.dtmDateCreated.EditValue = new System.DateTime(2007, 5, 11, 0, 0, 0, 0);
            this.dtmDateCreated.Location = new System.Drawing.Point(376, 17);
            this.dtmDateCreated.Name = "dtmDateCreated";
            this.dtmDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmDateCreated.Size = new System.Drawing.Size(175, 21);
            this.dtmDateCreated.TabIndex = 2;
            // 
            // PickingList
            // 
            this.ClientSize = new System.Drawing.Size(572, 443);
            this.Controls.Add(this.dtmDateCreated);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkShowPicking);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.grdPickingDetails);
            this.Controls.Add(this.cboDestDepart);
            this.Controls.Add(this.cboDestLocation);
            this.Controls.Add(this.txtOtherLocation);
            this.Controls.Add(this.txtReferenceNo);
            this.Controls.Add(this.txtPickingName);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PickingList";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Picking List";
            this.Load += new System.EventHandler(this.PickingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPickingName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferenceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtherLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDestLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDestDepart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPickingDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowPicking.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDateCreated.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        

        private void PickingList_Load(object sender, EventArgs e)
        {
            txtPickingName.Focus();

        }

        public void BindData(PickingListModel objModel)
        {
            dtmDateCreated.Text = DateTime.Now.ToShortDateString();
            //In case of adding new packing list, initialize the grid with nodata
            if (objModel == null)
            {
                model = new PickingListModel();
                model.PickingDetails = Mediator.GetInstance().GetEmptyListPickingDetail();
            }
            else
            {
                model = objModel;
            }
            DataTable dt = Mediator.GetInstance().GetAllLocations();

            foreach (DataRow dr in dt.Rows)
            {
                cboDestLocation.Properties.Items.Add(dr["bin_location_id"].ToString());
                cboDestDepart.Properties.Items.Add(dr["bin_location_id"].ToString());
            }

            cboDestDepart.Text = model.DestDepart;
            cboDestLocation.Text = model.DestLocation;

            this.txtNotes.Text = model.Notes;
            this.txtPickingName.Text = model.PickingName;
            this.txtReferenceNo.Text = model.ReferenceNo;
            this.txtOtherLocation.Text = model.OtherLocation;
            this.chkShowPicking.Checked = model.ViewStatus;
            dtDetails = model.PickingDetails;

            grdPickingDetails.DataSource = dtDetails;

            gridView = (GridView)grdPickingDetails.Views[0];
            foreach (GridColumn cl in gridView.Columns)
            {
                cl.MinWidth = 10;
                cl.AppearanceHeader.Font = Settings.Default.cfgDefaultFont;
                cl.AppearanceCell.Font = Settings.Default.cfgDefaultFont;
            }

            gridView.Columns["PickingListID"].Visible = false;            
            gridView.Columns["ID"].Visible = false;

            
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
            //gridView.Columns["Package code"].ColumnEdit = repoPackageLookUp;
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
            if ("colWarehouse".Equals(e.Column.Name) ||
                "colProduct".Equals(e.Column.Name) ||
                "colLocation".Equals(e.Column.Name) ||
                "colQuantity".Equals(e.Column.Name))
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
            model.PickingName = txtPickingName.Text;
            model.DateCreated = DateUtils.ParseDate(this.dtmDateCreated.Text);
            if (cboDestLocation.SelectedItem != null) model.DestDepart = cboDestDepart.SelectedItem.ToString();
            if (cboDestLocation.SelectedItem != null) model.DestLocation = cboDestLocation.SelectedItem.ToString();
            model.Notes = txtNotes.Text;
            model.OtherLocation = txtOtherLocation.Text;
            model.ReferenceNo = txtReferenceNo.Text;
            model.ViewStatus = (bool)chkShowPicking.EditValue;
            model.PickingDetails = (DataTable)this.grdPickingDetails.DataSource;
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
            grdPickingDetails.Refresh();
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
            if (!val.IsNonEmpty("Picking name", txtPickingName.Text))
            {
                txtPickingName.Focus();
                return false;
            }
            if (Toolkit.DbToolKit.IsDataOfSqlExists("SELECT PickingName FROM PickingListMaster WHERE PickingName = '" + txtPickingName.Text.Trim() + "' AND PickingListId <> '" + this.DataModel.PickingListID + "'"))
            {
                MessageBox.Show("This picking name is already available, please select another one");
                txtPickingName.Focus();
                return false;
            }
            if (!val.IsDateTime("Created Date", dtmDateCreated.Text))
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
                if (!val.IsNonEmpty("Line " + i + " :location", strTemp))
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
            if (String.IsNullOrEmpty(strQuantity) || String.IsNullOrEmpty(strWarehouse)
                || String.IsNullOrEmpty(strLocation) || String.IsNullOrEmpty(strProduct)) return true;
            try
            {
                Decimal dQty = Convert.ToDecimal(strQuantity);
                Decimal dAvailQty = Mediator.GetInstance().GetOnHandQty(strWarehouse, strLocation, strProduct);
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

    }
}

