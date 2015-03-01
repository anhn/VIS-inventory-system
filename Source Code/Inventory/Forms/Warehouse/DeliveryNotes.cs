using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

using Inventory.DataModels;
using Inventory.Utils;
using Inventory.DataModels.Warehouse;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using Inventory.Properties;
using System.IO;

namespace Inventory.Forms.Warehouse
{
    /// <summary>
    /// Summary description for DeliveryNotes.
    /// </summary>
    public class DeliveryNotes : DevExpress.XtraEditors.XtraForm
    {
        #region Attributes
        private DateEdit dtmDateCreated;
        private SimpleButton btnClose;
        private SimpleButton btnSave;
        private CheckEdit chkShowDelivery;
        private MemoEdit txtNotes;
        private DevExpress.XtraGrid.GridControl grdDeliveryDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ComboBoxEdit cboDeliveryMethod;
        private TextEdit txtReferenceNo;
        private TextEdit txtID;
        private SimpleButton btnFind;
        private SimpleButton btnDelete;
        private SimpleButton btnAdd;
        private Label label7;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label1;
        private Label label4;
        private ComboBoxEdit cboTypeDelivery;
        private Label label6;
        private ComboBoxEdit cboCustomerID;
        private Label label8;
        private TextEdit txtAddress;
        private Label label9;
        private TextEdit txtShipCost1;
        private Label label10;
        private TextEdit txtShipCost2;
        private Label label11;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private DeliveryNoteModel model = new DeliveryNoteModel();
        private DataTable dtDetails;
        private GridView gridView = null;
        private DataTable dtProducts = null;
        private DataTable dtLocations = null;
        private DataTable dtToLocations = null;

        public DeliveryNoteModel DataModel
        {
            get { return model; }
            set { model = value; }
        }

        private RepositoryItemLookUpEdit repoWarehouseLookUp = new RepositoryItemLookUpEdit();
        private RepositoryItemLookUpEdit repoLocationLookUp = new RepositoryItemLookUpEdit();
        private RepositoryItemLookUpEdit repoProductLookUp = new RepositoryItemLookUpEdit();
        private RepositoryItemLookUpEdit repoPackageLookUp = new RepositoryItemLookUpEdit();

        private RepositoryItemLookUpEdit repoToWarehouseLookUp = new RepositoryItemLookUpEdit();
        private RepositoryItemLookUpEdit repoToLocationLookUp = new RepositoryItemLookUpEdit();

        public DeliveryNotes()
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
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtmDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.chkShowDelivery = new DevExpress.XtraEditors.CheckEdit();
            this.txtNotes = new DevExpress.XtraEditors.MemoEdit();
            this.grdDeliveryDetail = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboDeliveryMethod = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtReferenceNo = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTypeDelivery = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCustomerID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txtShipCost1 = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.txtShipCost2 = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowDelivery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeliveryDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDeliveryMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferenceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTypeDelivery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipCost1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipCost2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtmDateCreated
            // 
            this.dtmDateCreated.EditValue = new System.DateTime(2007, 5, 13, 0, 0, 0, 0);
            this.dtmDateCreated.Location = new System.Drawing.Point(454, 15);
            this.dtmDateCreated.Name = "dtmDateCreated";
            this.dtmDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmDateCreated.Size = new System.Drawing.Size(175, 21);
            this.dtmDateCreated.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(353, 504);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(243, 504);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkShowDelivery
            // 
            this.chkShowDelivery.Location = new System.Drawing.Point(387, 444);
            this.chkShowDelivery.Name = "chkShowDelivery";
            this.chkShowDelivery.Properties.Caption = "Show Delivery Notes";
            this.chkShowDelivery.Size = new System.Drawing.Size(145, 19);
            this.chkShowDelivery.TabIndex = 15;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(60, 444);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(298, 53);
            this.txtNotes.TabIndex = 14;
            // 
            // grdDeliveryDetail
            // 
            this.grdDeliveryDetail.EmbeddedNavigator.Name = "";
            this.grdDeliveryDetail.Location = new System.Drawing.Point(15, 268);
            this.grdDeliveryDetail.MainView = this.gridView1;
            this.grdDeliveryDetail.Name = "grdDeliveryDetail";
            this.grdDeliveryDetail.Size = new System.Drawing.Size(636, 163);
            this.grdDeliveryDetail.TabIndex = 13;
            this.grdDeliveryDetail.TabStop = false;
            this.grdDeliveryDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdDeliveryDetail;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // cboDeliveryMethod
            // 
            this.cboDeliveryMethod.Location = new System.Drawing.Point(124, 75);
            this.cboDeliveryMethod.Name = "cboDeliveryMethod";
            this.cboDeliveryMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDeliveryMethod.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboDeliveryMethod.Size = new System.Drawing.Size(175, 21);
            this.cboDeliveryMethod.TabIndex = 4;
            // 
            // txtReferenceNo
            // 
            this.txtReferenceNo.Location = new System.Drawing.Point(124, 45);
            this.txtReferenceNo.Name = "txtReferenceNo";
            this.txtReferenceNo.Size = new System.Drawing.Size(175, 21);
            this.txtReferenceNo.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(124, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(175, 21);
            this.txtID.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(546, 239);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(83, 23);
            this.btnFind.TabIndex = 12;
            this.btnFind.Text = "&Find Products";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(449, 239);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "&Delete Item";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(352, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "&Add Item";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 14);
            this.label7.TabIndex = 11;
            this.label7.Text = "Notes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Delivery Method:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Reference No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 14);
            this.label5.TabIndex = 14;
            this.label5.Text = "Date Created:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "*Delivery Notes ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Type of Delivery:";
            // 
            // cboTypeDelivery
            // 
            this.cboTypeDelivery.EditValue = "Internal Transfer";
            this.cboTypeDelivery.Location = new System.Drawing.Point(124, 105);
            this.cboTypeDelivery.Name = "cboTypeDelivery";
            this.cboTypeDelivery.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTypeDelivery.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboTypeDelivery.Size = new System.Drawing.Size(175, 21);
            this.cboTypeDelivery.TabIndex = 5;
            this.cboTypeDelivery.SelectedIndexChanged += new System.EventHandler(this.cboTypeDelivery_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "Customer ID:";
            // 
            // cboCustomerID
            // 
            this.cboCustomerID.Location = new System.Drawing.Point(124, 135);
            this.cboCustomerID.Name = "cboCustomerID";
            this.cboCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCustomerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboCustomerID.Size = new System.Drawing.Size(175, 21);
            this.cboCustomerID.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 14);
            this.label8.TabIndex = 12;
            this.label8.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(124, 165);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(175, 21);
            this.txtAddress.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 14);
            this.label9.TabIndex = 12;
            this.label9.Text = "Shipping Cost 1:";
            // 
            // txtShipCost1
            // 
            this.txtShipCost1.Location = new System.Drawing.Point(124, 195);
            this.txtShipCost1.Name = "txtShipCost1";
            this.txtShipCost1.Properties.Mask.EditMask = "n2";
            this.txtShipCost1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtShipCost1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtShipCost1.Size = new System.Drawing.Size(175, 21);
            this.txtShipCost1.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(350, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 14);
            this.label10.TabIndex = 12;
            this.label10.Text = "Shipping Cost 2:";
            // 
            // txtShipCost2
            // 
            this.txtShipCost2.Location = new System.Drawing.Point(454, 199);
            this.txtShipCost2.Name = "txtShipCost2";
            this.txtShipCost2.Properties.Mask.EditMask = "n2";
            this.txtShipCost2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtShipCost2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtShipCost2.Size = new System.Drawing.Size(175, 21);
            this.txtShipCost2.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 444);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 14);
            this.label11.TabIndex = 12;
            this.label11.Text = "Notes:";
            // 
            // DeliveryNotes
            // 
            this.AcceptButton = this.btnSave;
            this.ClientSize = new System.Drawing.Size(663, 539);
            this.Controls.Add(this.dtmDateCreated);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkShowDelivery);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.grdDeliveryDetail);
            this.Controls.Add(this.cboCustomerID);
            this.Controls.Add(this.cboTypeDelivery);
            this.Controls.Add(this.cboDeliveryMethod);
            this.Controls.Add(this.txtShipCost2);
            this.Controls.Add(this.txtShipCost1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtReferenceNo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeliveryNotes";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delivery Notes";
            this.Load += new System.EventHandler(this.DeliveryNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtmDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowDelivery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeliveryDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDeliveryMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferenceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTypeDelivery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipCost1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipCost2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private string m_strID;

        public DeliveryNotes(string strID)
        {
            m_strID = strID;
            InitializeComponent();
        }

        private void DeliveryNotes_Load(object sender, EventArgs e)
        {
            txtID.Focus();
        }

        /// <summary>
        /// Bind data into the form
        /// </summary>
        /// <param name="objModel"></param>
        public void BindData(DeliveryNoteModel objModel)
        {
            dtmDateCreated.Text = DateTime.Now.ToShortDateString();
            if (objModel == null)
            {
                model = new DeliveryNoteModel();
                model.Details = Mediator.GetInstance().GetEmptyDeliveryNoteDetail();
            }
            else
            {
                model = objModel;
            }


            //Bind data for the dropdown list
            Mediator mediator = new Mediator();


            cboTypeDelivery.Properties.Items.Clear();
            cboTypeDelivery.Properties.Items.Add("Internal transfer");
            cboTypeDelivery.Properties.Items.Add("Stock out");
            cboCustomerID.Properties.Items.Clear();
            DataTable dt = mediator.GetAllCustomerName();
            foreach (DataRow row in dt.Rows)
            {
                cboCustomerID.Properties.Items.Add(new TabItem(row["CustomerId"].ToString(), row["ContactName"].ToString()));
            }

            cboDeliveryMethod.Properties.Items.Clear();
            dt = mediator.GetAllDeliveryMethod();
            foreach (DataRow row in dt.Rows)
            {
                cboDeliveryMethod.Properties.Items.Add(new TabItem(row["DeliveryMethodID"].ToString(), row["Name"].ToString()));
            }

            dtmDateCreated.DateTime = model.CreatedDate;
            txtID.Text = model.DNID;
            txtReferenceNo.Text = model.ReferenceNumber;
            cboDeliveryMethod.Text = model.DeliverMethod;
            cboCustomerID.Text = model.CustomerID;
            txtAddress.Text = model.Address;
            txtShipCost1.Text = model.Cost1.ToString();
            txtShipCost2.Text = model.Cost2.ToString();
            chkShowDelivery.Checked = model.ViewStatus;
            txtNotes.Text = model.Notes;
            dtDetails = model.Details;
            grdDeliveryDetail.DataSource = dtDetails;

            gridView = (GridView)grdDeliveryDetail.Views[0];
            //Bind data to cboTypeDelivery after assign gridView to avoid Null Pointer Exception
            cboTypeDelivery.Text = model.DeliverType;

            foreach (GridColumn cl in gridView.Columns)
            {
                //cl.Visible = false;
                cl.MinWidth = 10;
                cl.AppearanceHeader.Font = Settings.Default.cfgDefaultFont;
                cl.AppearanceCell.Font = Settings.Default.cfgDefaultFont;
            }

            gridView.Columns["DeliveryNoteID"].Visible = false;
            gridView.Columns["ID"].Visible = false;

            //dtLocationProducts = Mediator.GetInstance().GetAllLocationProducts();

            //repoWarehouseLookUp.QueryPopUp += new CancelEventHandler(repoWarehouseLookUp_QueryPopUp);
            repoWarehouseLookUp.EditValueChanged += new EventHandler(repoWarehouseLookUp_EditValueChanged);
            repoWarehouseLookUp.DisplayMember = "Description";
            repoWarehouseLookUp.ValueMember = "Warehouse_id";
            repoWarehouseLookUp.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Warehouse", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            repoWarehouseLookUp.DataSource = Mediator.GetInstance().GetAllWarehouse();

            repoToWarehouseLookUp.EditValueChanged += new EventHandler(repoToWarehouseLookUp_EditValueChanged);
            repoToWarehouseLookUp.DisplayMember = "Description";
            repoToWarehouseLookUp.ValueMember = "Warehouse_id";
            repoToWarehouseLookUp.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Warehouse", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            repoToWarehouseLookUp.DataSource = Mediator.GetInstance().GetAllWarehouse();


            repoLocationLookUp.QueryPopUp += new CancelEventHandler(repoLocationLookUp_QueryPopUp);
            repoLocationLookUp.DisplayMember = "bin_location_id";
            repoLocationLookUp.ValueMember = "bin_location_id";
            repoLocationLookUp.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("bin_location_id", "Location", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            dtLocations = Mediator.GetInstance().GetAllLocations();
            repoLocationLookUp.DataSource = dtLocations;

            repoToLocationLookUp.QueryPopUp += new CancelEventHandler(repoToLocationLookUp_QueryPopUp);
            repoToLocationLookUp.DisplayMember = "bin_location_id";
            repoToLocationLookUp.ValueMember = "bin_location_id";
            repoToLocationLookUp.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("bin_location_id", "Location", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            dtToLocations = Mediator.GetInstance().GetAllLocations();
            repoToLocationLookUp.DataSource = dtToLocations;



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
            gridView.Columns["To Warehouse"].ColumnEdit = repoToWarehouseLookUp;
            gridView.Columns["To Location"].ColumnEdit = repoToLocationLookUp;

            gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridView_CellValueChanged);
            gridView.Columns["Product"].ColumnEdit = repoProductLookUp;
            gridView.Columns["Package code"].ColumnEdit = repoPackageLookUp;
            dtDetails.AcceptChanges();
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

        private int GetSelectedRowIndex()
        {
            gridView.TopRowIndex = 0;
            return gridView.FocusedRowHandle;
        }

        private void AcceptChanges()
        {
            int iFocusRow = GetSelectedRowIndex();
            grdDeliveryDetail.Refresh();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {
                //MessageBox.Show("Data for the focused field is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ReadToDataModel();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool Validate()
        {
            Validator val = new Validator();
            if (!(val.IsNonEmpty("Delivery Note ID", txtID.Text, true)))  
            {
                txtID.Focus();
                return false;
            }
            if (Toolkit.DbToolKit.IsDataOfSqlExists("SELECT ID,DNID FROM DeliveryNotesMaster WHERE DNID = '" + txtID.Text + "' AND ID <> '" + this.DataModel.ID + "'"))
            {
                MessageBox.Show("This name is already available, please select another one");
                txtID.Focus();
                return false;
            }
            if (!val.IsDateTime("Created Date", dtmDateCreated.Text))
            {
                dtmDateCreated.Focus();
                return false;
            }

            if (!val.IsDecimal("Ship Cost 1", txtShipCost1.Text))
            {
                txtShipCost1.Focus();
                return false;
            }

            if (!val.IsDecimal("Ship Cost 2", txtShipCost2.Text))
            {
                txtShipCost2.Focus();
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
                if (!val.IsNonEmpty("Line " + i + " :location", strTemp,false))
                {
                    return false;
                }
                strTemp = dr["Product"].ToString();
                if (!val.IsNonEmpty("Line " + i + " :product", strTemp,false))
                {
                    return false;
                }
                strTemp = dr["Quantity"].ToString();
                if (!val.IsPositiveDecimal("Line " + i + " :quantity", strTemp))
                {
                    return false;
                }
            }

            // Check the Notes exist or not
            Inventory.DataObjects.DAO.DeliveryNoteDao oDao = new Inventory.DataObjects.DAO.DeliveryNoteDao();
            if (oDao.IsExistDeliveryNotesMaster(txtID.Text.Trim()))
            {
                if ((m_strID == null) || ((m_strID != null) && (m_strID != txtID.Text.Trim())))
                {
                    txtID.Focus();
                    return false;
                }
            }

            return true;
        }

        private void ReadToDataModel()
        {
            model.DNID = txtID.Text;
            model.CreatedDate = dtmDateCreated.DateTime;
            model.ReferenceNumber = txtReferenceNo.Text;
            model.DeliverMethod = cboDeliveryMethod.Text;
            model.DeliverType = cboTypeDelivery.Text;
            model.CustomerID = cboCustomerID.Text;
            model.Address = txtAddress.Text;
            model.Cost1 = Convert.ToDecimal(txtShipCost1.Text);
            model.Cost2 = Convert.ToDecimal(txtShipCost2.Text);
            model.ViewStatus = chkShowDelivery.Checked;
            model.Notes = txtNotes.Text;
            model.Details = (DataTable)this.grdDeliveryDetail.DataSource;
        }

        private void cboTypeDelivery_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTypeDelivery.Text == "Stock out")
            {
                cboCustomerID.Enabled = true;
                txtAddress.Enabled = true;
                gridView.Columns["To Warehouse"].Visible = false;
                gridView.Columns["To Location"].Visible = false;
            }
            else
            {
                cboCustomerID.Enabled = false;
                txtAddress.Enabled = false;
                gridView.Columns["To Warehouse"].Visible = true;
                gridView.Columns["To Location"].Visible = true;
            }
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
        }

        void repoToLocationLookUp_QueryPopUp(object sender, CancelEventArgs e)
        {
            FilterSelectionByToWarehouse();
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
            UpdateLocation(strNewWarehouse);

        }

        void repoToWarehouseLookUp_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit le = (DevExpress.XtraEditors.LookUpEdit)sender;
            String strNewWarehouse = le.EditValue.ToString();
            UpdateToLocation(strNewWarehouse);
        }

        private void UpdateToLocation(string strNewWarehouse)
        {
            DataRow dr = GetSelectedRow();
            if (dr == null) return;

            String strLocation = dr["To Location"].ToString();

            //Don't have to care if location already empty
            if (String.IsNullOrEmpty(strLocation)) return;

            StringWriter wr = new StringWriter();
            if (!String.IsNullOrEmpty(strNewWarehouse))
            {
                wr.Write("Warehouse_id = '" + strNewWarehouse + "' ");
            }

            wr.Write(" and Bin_location_id = '" + strLocation + "' ");

            //If the warehouse and location not match then clear location
            dtToLocations.DefaultView.RowFilter = wr.ToString();
            if (dtToLocations.DefaultView.Count == 0)
            {
                dr["To Location"] = "";
            }
        }


        void repoProductLookUp_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit le = (DevExpress.XtraEditors.LookUpEdit)sender;
            String strNewProduct = le.EditValue.ToString();
            UpdateUOM(strNewProduct);
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


        /// <summary>
        /// Accept change on interface into datatable, keeping same focus
        /// </summary>

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

        private void FilterSelectionByToWarehouse()
        {
            DataRow dr = GetSelectedRow();
            if (dr == null) return;
            String strToWarehouse = dr["To Warehouse"].ToString();

            StringWriter wr = new StringWriter();
            if (!String.IsNullOrEmpty(strToWarehouse))
            {
                wr.Write("Warehouse_id = '" + strToWarehouse + "' ");
            }

            dtToLocations.DefaultView.RowFilter = wr.ToString();
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
    }
}


