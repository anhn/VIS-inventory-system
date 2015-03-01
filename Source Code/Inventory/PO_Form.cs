using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Inventory.Properties;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Data.Common;
namespace Inventory
{
    /// <summary>
    /// Summary description for PO_Form2.
    /// </summary>
    public class PO_Form : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton btnCancel;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private CheckEdit chkPOStatus;
        private MemoEdit memoNotes;
        private SimpleButton btnOK;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel2;
        private OpenFileDialog openFileDialog1;
        private TextEdit txtShipTo;
        private Label lblPOShipTo;
        private TextEdit txtDeliveryDate;
        private TextEdit txtPODate;
        private TextEdit txtPONo;
        private Label lblPODate;
        private Label lblPONo;
        private Label lblPONote;
        private TextEdit txtTotalAmt;
        private GroupControl grpPO;
        private Label lblPODeliveryDate;
        private ButtonEdit bteSupplierName;
        private DevExpress.XtraGrid.GridControl grdPurchaseDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private _Vis_InventoryDataSet _Vis_InventoryDataSet;
        private BindingSource productMasterBindingSource;
        private Inventory._Vis_InventoryDataSetTableAdapters.ProductMasterTableAdapter productMasterTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private BindingSource warehouseMasterBindingSource;
        private Inventory._Vis_InventoryDataSetTableAdapters.Warehouse_MasterTableAdapter warehouse_MasterTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private BindingSource locationMasterBindingSource;
        private Inventory._Vis_InventoryDataSetTableAdapters.Location_MasterTableAdapter location_MasterTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn Amount;
        private ComboBoxEdit cboTaxID;
        private Label label1;
        private SimpleButton btnPrint;
        private GroupControl groupControl1;
        private Label label2;
        private TextEdit txtSubtotal;
        private GroupControl groupControl2;
        private TextEdit txtTaxPercentage;
        private Label label3;
        private GroupControl groupControl3;
        private Label label4;
        private TextEdit txtDiscountPercentage;
        private TextEdit txtDiscountAmount;
        private Label label9;
        private GroupControl groupControl4;
        private ComboBoxEdit cboPatmentTerm;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label10;
        private TextEdit txtTaxAmount;
        private TextEdit txtShippingFee;
        private Label label11;
        private TextEdit txtBalanceDue;
        private Label label6;
        private TextEdit txtShipVia;
        private Label label13;
        private TextEdit txtTotal;
        private Label label12;
        private TextEdit txtFOB;
        private Label label14;
        private ComboBoxEdit cbPOType;
        private Label lblPOType;
        private Label label16;
        private Label label15;
        private IContainer components;

        public PO_Form()
        {
            InitializeComponent();
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
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.chkPOStatus = new DevExpress.XtraEditors.CheckEdit();
            this.memoNotes = new DevExpress.XtraEditors.MemoEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel2 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtShipTo = new DevExpress.XtraEditors.TextEdit();
            this.lblPOShipTo = new System.Windows.Forms.Label();
            this.txtDeliveryDate = new DevExpress.XtraEditors.TextEdit();
            this.txtPODate = new DevExpress.XtraEditors.TextEdit();
            this.txtPONo = new DevExpress.XtraEditors.TextEdit();
            this.lblPODate = new System.Windows.Forms.Label();
            this.lblPONo = new System.Windows.Forms.Label();
            this.lblPONote = new System.Windows.Forms.Label();
            this.txtTotalAmt = new DevExpress.XtraEditors.TextEdit();
            this.grpPO = new DevExpress.XtraEditors.GroupControl();
            this.txtFOB = new DevExpress.XtraEditors.TextEdit();
            this.label14 = new System.Windows.Forms.Label();
            this.txtShipVia = new DevExpress.XtraEditors.TextEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.cbPOType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblPOType = new System.Windows.Forms.Label();
            this.lblPODeliveryDate = new System.Windows.Forms.Label();
            this.txtSubtotal = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTaxID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bteSupplierName = new DevExpress.XtraEditors.ButtonEdit();
            this.grdPurchaseDetails = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtNumber = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Vis_InventoryDataSet = new Inventory._Vis_InventoryDataSet();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.warehouseMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.locationMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productMasterTableAdapter = new Inventory._Vis_InventoryDataSetTableAdapters.ProductMasterTableAdapter();
            this.warehouse_MasterTableAdapter = new Inventory._Vis_InventoryDataSetTableAdapters.Warehouse_MasterTableAdapter();
            this.location_MasterTableAdapter = new Inventory._Vis_InventoryDataSetTableAdapters.Location_MasterTableAdapter();
            this.Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtTaxPercentage = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscountAmount = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiscountPercentage = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTaxAmount = new DevExpress.XtraEditors.TextEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBalanceDue = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtShippingFee = new DevExpress.XtraEditors.TextEdit();
            this.cboPatmentTerm = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chkPOStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPODate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPONo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpPO)).BeginInit();
            this.grpPO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFOB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipVia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPOType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTaxID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteSupplierName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchaseDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Vis_InventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxPercentage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountPercentage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalanceDue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShippingFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPatmentTerm.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCancel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(675, 535);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = global::Inventory.Properties.Settings.Default.strCancel;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.defaultLookAndFeel1.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // chkPOStatus
            // 
            this.chkPOStatus.Location = new System.Drawing.Point(86, 198);
            this.chkPOStatus.Name = "chkPOStatus";
            this.chkPOStatus.Properties.Caption = "Mark As Viewable";
            this.chkPOStatus.Size = new System.Drawing.Size(108, 19);
            this.chkPOStatus.TabIndex = 9;
            // 
            // memoNotes
            // 
            this.memoNotes.Location = new System.Drawing.Point(86, 160);
            this.memoNotes.Name = "memoNotes";
            this.memoNotes.Size = new System.Drawing.Size(451, 32);
            this.memoNotes.TabIndex = 10;
            // 
            // btnOK
            // 
            this.btnOK.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strOK", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnOK.Location = new System.Drawing.Point(560, 535);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(109, 23);
            this.btnOK.TabIndex = 25;
            this.btnOK.Text = global::Inventory.Properties.Settings.Default.strOK;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // defaultLookAndFeel2
            // 
            this.defaultLookAndFeel2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.defaultLookAndFeel2.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtShipTo
            // 
            this.txtShipTo.Location = new System.Drawing.Point(86, 83);
            this.txtShipTo.Name = "txtShipTo";
            this.txtShipTo.Size = new System.Drawing.Size(166, 20);
            this.txtShipTo.TabIndex = 4;
            // 
            // lblPOShipTo
            // 
            this.lblPOShipTo.AutoSize = true;
            this.lblPOShipTo.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPurchaseOrderShipTo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPOShipTo.Location = new System.Drawing.Point(10, 86);
            this.lblPOShipTo.Name = "lblPOShipTo";
            this.lblPOShipTo.Size = new System.Drawing.Size(46, 13);
            this.lblPOShipTo.TabIndex = 30;
            this.lblPOShipTo.Text = global::Inventory.Properties.Settings.Default.strPurchaseOrderShipTo;
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Location = new System.Drawing.Point(337, 83);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.Properties.DisplayFormat.FormatString = "d";
            this.txtDeliveryDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDeliveryDate.Properties.Mask.EditMask = "d";
            this.txtDeliveryDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtDeliveryDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDeliveryDate.Size = new System.Drawing.Size(200, 20);
            this.txtDeliveryDate.TabIndex = 5;
            this.txtDeliveryDate.ToolTip = "Date must >= 1/1/1753 and  <= 12/31/9999";
            this.txtDeliveryDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtDeliveryDate_Validating);
            // 
            // txtPODate
            // 
            this.txtPODate.Location = new System.Drawing.Point(337, 31);
            this.txtPODate.Name = "txtPODate";
            this.txtPODate.Properties.DisplayFormat.FormatString = "d";
            this.txtPODate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtPODate.Properties.Mask.EditMask = "d";
            this.txtPODate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtPODate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPODate.Size = new System.Drawing.Size(200, 20);
            this.txtPODate.TabIndex = 2;
            this.txtPODate.ToolTip = "Date must >= 1/1/1753 and  <= 12/31/9999";
            this.txtPODate.Validating += new System.ComponentModel.CancelEventHandler(this.txtPODate_Validating);
            // 
            // txtPONo
            // 
            this.txtPONo.Location = new System.Drawing.Point(86, 31);
            this.txtPONo.Name = "txtPONo";
            this.txtPONo.Properties.Mask.EditMask = "[0-9]{0,}";
            this.txtPONo.Size = new System.Drawing.Size(166, 20);
            this.txtPONo.TabIndex = 1;
            this.txtPONo.Validating += new System.ComponentModel.CancelEventHandler(this.txtPONo_Validating);
            this.txtPONo.EditValueChanged += new System.EventHandler(this.txtPONo_EditValueChanged);
            // 
            // lblPODate
            // 
            this.lblPODate.AutoSize = true;
            this.lblPODate.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPurchaseOrderDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPODate.Location = new System.Drawing.Point(282, 34);
            this.lblPODate.Name = "lblPODate";
            this.lblPODate.Size = new System.Drawing.Size(51, 13);
            this.lblPODate.TabIndex = 11;
            this.lblPODate.Text = global::Inventory.Properties.Settings.Default.strPurchaseOrderDate;
            // 
            // lblPONo
            // 
            this.lblPONo.AutoSize = true;
            this.lblPONo.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPurchaseOrderNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPONo.Location = new System.Drawing.Point(10, 34);
            this.lblPONo.Name = "lblPONo";
            this.lblPONo.Size = new System.Drawing.Size(41, 13);
            this.lblPONo.TabIndex = 9;
            this.lblPONo.Text = global::Inventory.Properties.Settings.Default.strPurchaseOrderNo;
            // 
            // lblPONote
            // 
            this.lblPONote.AutoSize = true;
            this.lblPONote.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPurchaseOrderNote", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPONote.Location = new System.Drawing.Point(11, 162);
            this.lblPONote.Name = "lblPONote";
            this.lblPONote.Size = new System.Drawing.Size(39, 13);
            this.lblPONote.TabIndex = 48;
            this.lblPONote.Text = global::Inventory.Properties.Settings.Default.strPurchaseOrderNote;
            // 
            // txtTotalAmt
            // 
            this.txtTotalAmt.EditValue = "0";
            this.txtTotalAmt.Location = new System.Drawing.Point(602, 104);
            this.txtTotalAmt.Name = "txtTotalAmt";
            this.txtTotalAmt.Properties.Mask.EditMask = "n2";
            this.txtTotalAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalAmt.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotalAmt.Size = new System.Drawing.Size(175, 20);
            this.txtTotalAmt.TabIndex = 22;
            this.txtTotalAmt.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtTotalAmt_EditValueChanging);
            // 
            // grpPO
            // 
            this.grpPO.Controls.Add(this.txtFOB);
            this.grpPO.Controls.Add(this.label14);
            this.grpPO.Controls.Add(this.txtShipVia);
            this.grpPO.Controls.Add(this.label13);
            this.grpPO.Controls.Add(this.chkPOStatus);
            this.grpPO.Controls.Add(this.memoNotes);
            this.grpPO.Controls.Add(this.txtShipTo);
            this.grpPO.Controls.Add(this.lblPONote);
            this.grpPO.Controls.Add(this.lblPOShipTo);
            this.grpPO.Controls.Add(this.cbPOType);
            this.grpPO.Controls.Add(this.txtDeliveryDate);
            this.grpPO.Controls.Add(this.txtPODate);
            this.grpPO.Controls.Add(this.txtPONo);
            this.grpPO.Controls.Add(this.lblPOType);
            this.grpPO.Controls.Add(this.lblPODeliveryDate);
            this.grpPO.Controls.Add(this.lblPODate);
            this.grpPO.Controls.Add(this.lblPONo);
            this.grpPO.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPurchaseOrderGroup", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.grpPO.Location = new System.Drawing.Point(4, 3);
            this.grpPO.Name = "grpPO";
            this.grpPO.Size = new System.Drawing.Size(550, 226);
            this.grpPO.TabIndex = 114;
            this.grpPO.Text = global::Inventory.Properties.Settings.Default.strPurchaseOrderGroup;
            // 
            // txtFOB
            // 
            this.txtFOB.Location = new System.Drawing.Point(86, 134);
            this.txtFOB.Name = "txtFOB";
            this.txtFOB.Size = new System.Drawing.Size(451, 20);
            this.txtFOB.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 128;
            this.label14.Text = "FOB:";
            // 
            // txtShipVia
            // 
            this.txtShipVia.Location = new System.Drawing.Point(86, 109);
            this.txtShipVia.Name = "txtShipVia";
            this.txtShipVia.Size = new System.Drawing.Size(451, 20);
            this.txtShipVia.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 126;
            this.label13.Text = "Shipping Via:";
            // 
            // cbPOType
            // 
            this.cbPOType.Location = new System.Drawing.Point(86, 57);
            this.cbPOType.Name = "cbPOType";
            this.cbPOType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPOType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbPOType.Size = new System.Drawing.Size(166, 20);
            this.cbPOType.TabIndex = 3;
            // 
            // lblPOType
            // 
            this.lblPOType.AutoSize = true;
            this.lblPOType.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPurchaseOrderType", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPOType.Location = new System.Drawing.Point(10, 60);
            this.lblPOType.Name = "lblPOType";
            this.lblPOType.Size = new System.Drawing.Size(52, 13);
            this.lblPOType.TabIndex = 78;
            this.lblPOType.Text = global::Inventory.Properties.Settings.Default.strPurchaseOrderType;
            // 
            // lblPODeliveryDate
            // 
            this.lblPODeliveryDate.AutoSize = true;
            this.lblPODeliveryDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPurchaseOrderDevDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPODeliveryDate.Location = new System.Drawing.Point(257, 86);
            this.lblPODeliveryDate.Name = "lblPODeliveryDate";
            this.lblPODeliveryDate.Size = new System.Drawing.Size(76, 13);
            this.lblPODeliveryDate.TabIndex = 13;
            this.lblPODeliveryDate.Text = global::Inventory.Properties.Settings.Default.strPurchaseOrderDevDate;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.EditValue = "0";
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(337, 79);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Properties.Mask.EditMask = "n2";
            this.txtSubtotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSubtotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSubtotal.Size = new System.Drawing.Size(163, 20);
            this.txtSubtotal.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "ID:";
            // 
            // cboTaxID
            // 
            this.cboTaxID.Location = new System.Drawing.Point(45, 23);
            this.cboTaxID.Name = "cboTaxID";
            this.cboTaxID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTaxID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboTaxID.Size = new System.Drawing.Size(176, 20);
            this.cboTaxID.TabIndex = 12;
            // 
            // bteSupplierName
            // 
            this.bteSupplierName.Location = new System.Drawing.Point(20, 34);
            this.bteSupplierName.Name = "bteSupplierName";
            this.bteSupplierName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteSupplierName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.bteSupplierName.Size = new System.Drawing.Size(201, 20);
            this.bteSupplierName.TabIndex = 9;
            this.bteSupplierName.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteSupplierName_ButtonClick);
            // 
            // grdPurchaseDetails
            // 
            this.grdPurchaseDetails.EmbeddedNavigator.Name = "";
            this.grdPurchaseDetails.Location = new System.Drawing.Point(4, 369);
            this.grdPurchaseDetails.MainView = this.gridView1;
            this.grdPurchaseDetails.Name = "grdPurchaseDetails";
            this.grdPurchaseDetails.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtNumber,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3});
            this.grdPurchaseDetails.Size = new System.Drawing.Size(789, 160);
            this.grdPurchaseDetails.TabIndex = 23;
            this.grdPurchaseDetails.UseEmbeddedNavigator = true;
            this.grdPurchaseDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdPurchaseDetails;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // txtNumber
            // 
            this.txtNumber.AutoHeight = false;
            this.txtNumber.Mask.EditMask = "n2";
            this.txtNumber.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtNumber_EditValueChanging);
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName")});
            this.repositoryItemLookUpEdit1.DataSource = this.productMasterBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "ProductID";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "[Null]";
            this.repositoryItemLookUpEdit1.ValueMember = "ProductID";
            // 
            // productMasterBindingSource
            // 
            this.productMasterBindingSource.DataMember = "ProductMaster";
            this.productMasterBindingSource.DataSource = this._Vis_InventoryDataSet;
            // 
            // _Vis_InventoryDataSet
            // 
            this._Vis_InventoryDataSet.DataSetName = "_Vis_InventoryDataSet";
            this._Vis_InventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description")});
            this.repositoryItemLookUpEdit2.DataSource = this.warehouseMasterBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "Description";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "[Null]";
            this.repositoryItemLookUpEdit2.ValueMember = "Description";
            // 
            // warehouseMasterBindingSource
            // 
            this.warehouseMasterBindingSource.DataMember = "Warehouse_Master";
            this.warehouseMasterBindingSource.DataSource = this._Vis_InventoryDataSet;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Bin_location_id")});
            this.repositoryItemLookUpEdit3.DisplayMember = "Bin_location_id";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.NullText = "[Null]";
            this.repositoryItemLookUpEdit3.ValueMember = "Bin_location_id";
            // 
            // ProductName
            // 
            this.ProductName.Caption = "ProductName";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.OptionsColumn.AllowEdit = false;
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 0;
            // 
            // locationMasterBindingSource
            // 
            this.locationMasterBindingSource.DataMember = "Location_Master";
            this.locationMasterBindingSource.DataSource = this._Vis_InventoryDataSet;
            // 
            // productMasterTableAdapter
            // 
            this.productMasterTableAdapter.ClearBeforeFill = true;
            // 
            // warehouse_MasterTableAdapter
            // 
            this.warehouse_MasterTableAdapter.ClearBeforeFill = true;
            // 
            // location_MasterTableAdapter
            // 
            this.location_MasterTableAdapter.ClearBeforeFill = true;
            // 
            // Amount
            // 
            this.Amount.Caption = "Amount";
            this.Amount.DisplayFormat.FormatString = "f2";
            this.Amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Amount.FieldName = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.OptionsColumn.AllowEdit = false;
            this.Amount.Visible = true;
            this.Amount.VisibleIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(445, 535);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(109, 23);
            this.btnPrint.TabIndex = 24;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.bteSupplierName);
            this.groupControl1.Location = new System.Drawing.Point(560, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(233, 65);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Supplier:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label16);
            this.groupControl2.Controls.Add(this.txtTaxPercentage);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.cboTaxID);
            this.groupControl2.Location = new System.Drawing.Point(560, 71);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(233, 82);
            this.groupControl2.TabIndex = 117;
            this.groupControl2.Text = "Tax";
            // 
            // txtTaxPercentage
            // 
            this.txtTaxPercentage.EditValue = "0";
            this.txtTaxPercentage.Location = new System.Drawing.Point(89, 52);
            this.txtTaxPercentage.Name = "txtTaxPercentage";
            this.txtTaxPercentage.Properties.Mask.EditMask = "n2";
            this.txtTaxPercentage.Properties.Mask.IgnoreMaskBlank = false;
            this.txtTaxPercentage.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTaxPercentage.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTaxPercentage.Size = new System.Drawing.Size(108, 20);
            this.txtTaxPercentage.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Percentage:";
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.EditValue = "0";
            this.txtDiscountAmount.Enabled = false;
            this.txtDiscountAmount.Location = new System.Drawing.Point(602, 53);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.Properties.Mask.EditMask = "n2";
            this.txtDiscountAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscountAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(175, 20);
            this.txtDiscountAmount.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(508, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 83;
            this.label9.Text = "Discount Amount:";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.label15);
            this.groupControl3.Controls.Add(this.label4);
            this.groupControl3.Controls.Add(this.txtDiscountPercentage);
            this.groupControl3.Location = new System.Drawing.Point(560, 155);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(233, 74);
            this.groupControl3.TabIndex = 118;
            this.groupControl3.Text = "Discount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 120;
            this.label4.Text = "Percentage:";
            // 
            // txtDiscountPercentage
            // 
            this.txtDiscountPercentage.EditValue = "0";
            this.txtDiscountPercentage.Location = new System.Drawing.Point(89, 32);
            this.txtDiscountPercentage.Name = "txtDiscountPercentage";
            this.txtDiscountPercentage.Properties.Mask.EditMask = "n2";
            this.txtDiscountPercentage.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscountPercentage.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDiscountPercentage.Size = new System.Drawing.Size(108, 20);
            this.txtDiscountPercentage.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 122;
            this.label10.Text = "Tax Amount:";
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.EditValue = "0";
            this.txtTaxAmount.Enabled = false;
            this.txtTaxAmount.Location = new System.Drawing.Point(337, 53);
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.Properties.Mask.EditMask = "n2";
            this.txtTaxAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTaxAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTaxAmount.Size = new System.Drawing.Size(163, 20);
            this.txtTaxAmount.TabIndex = 17;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.label10);
            this.groupControl4.Controls.Add(this.txtDiscountAmount);
            this.groupControl4.Controls.Add(this.txtTaxAmount);
            this.groupControl4.Controls.Add(this.label9);
            this.groupControl4.Controls.Add(this.txtTotal);
            this.groupControl4.Controls.Add(this.label12);
            this.groupControl4.Controls.Add(this.txtBalanceDue);
            this.groupControl4.Controls.Add(this.label6);
            this.groupControl4.Controls.Add(this.txtSubtotal);
            this.groupControl4.Controls.Add(this.label11);
            this.groupControl4.Controls.Add(this.txtShippingFee);
            this.groupControl4.Controls.Add(this.cboPatmentTerm);
            this.groupControl4.Controls.Add(this.label8);
            this.groupControl4.Controls.Add(this.label7);
            this.groupControl4.Controls.Add(this.label5);
            this.groupControl4.Controls.Add(this.txtTotalAmt);
            this.groupControl4.Location = new System.Drawing.Point(4, 235);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(789, 132);
            this.groupControl4.TabIndex = 119;
            this.groupControl4.Text = "Payment";
            // 
            // txtTotal
            // 
            this.txtTotal.EditValue = "0";
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(602, 78);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Mask.EditMask = "n2";
            this.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotal.Size = new System.Drawing.Size(175, 20);
            this.txtTotal.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(565, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 129;
            this.label12.Text = "Total:";
            // 
            // txtBalanceDue
            // 
            this.txtBalanceDue.EditValue = "0";
            this.txtBalanceDue.Enabled = false;
            this.txtBalanceDue.Location = new System.Drawing.Point(86, 79);
            this.txtBalanceDue.Name = "txtBalanceDue";
            this.txtBalanceDue.Properties.Mask.EditMask = "n2";
            this.txtBalanceDue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBalanceDue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtBalanceDue.Size = new System.Drawing.Size(166, 20);
            this.txtBalanceDue.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 127;
            this.label6.Text = "Balance Due:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(506, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 126;
            this.label11.Text = "Received Amount:";
            // 
            // txtShippingFee
            // 
            this.txtShippingFee.EditValue = "0";
            this.txtShippingFee.Location = new System.Drawing.Point(86, 53);
            this.txtShippingFee.Name = "txtShippingFee";
            this.txtShippingFee.Properties.Mask.EditMask = "n2";
            this.txtShippingFee.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtShippingFee.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtShippingFee.Size = new System.Drawing.Size(166, 20);
            this.txtShippingFee.TabIndex = 16;
            // 
            // cboPatmentTerm
            // 
            this.cboPatmentTerm.Location = new System.Drawing.Point(86, 27);
            this.cboPatmentTerm.Name = "cboPatmentTerm";
            this.cboPatmentTerm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPatmentTerm.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboPatmentTerm.Size = new System.Drawing.Size(166, 20);
            this.cboPatmentTerm.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 123;
            this.label8.Text = "Subtotal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 122;
            this.label7.Text = "Shipping Fee:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 121;
            this.label5.Text = "Payment Term:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(203, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 121;
            this.label15.Text = "%";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(203, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 13);
            this.label16.TabIndex = 122;
            this.label16.Text = "%";
            // 
            // PO_Form
            // 
            this.AcceptButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(796, 567);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.grdPurchaseDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpPO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PO_Form";
            this.ShowInTaskbar = false;
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.PO_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkPOStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPODate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPONo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpPO)).EndInit();
            this.grpPO.ResumeLayout(false);
            this.grpPO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFOB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipVia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPOType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTaxID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteSupplierName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchaseDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Vis_InventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxPercentage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountPercentage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalanceDue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShippingFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPatmentTerm.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region
        public t_Purchase_Order_HeaderRec PurchaseOrder
        {
            get { return rec; }
            set
            {
                rec = value;
                currentSupplierID = rec.SupplierID;
            }
        }
        #endregion

        private string currentSupplierID = "";
        private void bteSupplierName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SelectSupplier frmSelectSupplier = new SelectSupplier();
            frmSelectSupplier.SupplierID = currentSupplierID;
            frmSelectSupplier.ShowDialog(this);
            currentSupplierID = frmSelectSupplier.SupplierID;
            try
            {
                DataRow row = Globals.daSupplier.View().Tables[0].Select("[Contact ID] = '" + currentSupplierID + "'")[0];
                Supplier sup = new Supplier();
                sup.AssignDataRow(row);
                bteSupplierName.Text = frmSelectSupplier.SupplierName;
            }
            catch (Exception oExc)
            {
                MessageBox.Show(oExc.Message);
            }
        }
 
        private void PO_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Vis_InventoryDataSet.Location_Master' table. You can move, or remove it, as needed.
            this.location_MasterTableAdapter.Fill(this._Vis_InventoryDataSet.Location_Master);
            // TODO: This line of code loads data into the '_Vis_InventoryDataSet.Warehouse_Master' table. You can move, or remove it, as needed.
            this.warehouse_MasterTableAdapter.Fill(this._Vis_InventoryDataSet.Warehouse_Master);
            // TODO: This line of code loads data into the '_Vis_InventoryDataSet.ProductMaster' table. You can move, or remove it, as needed.
            this.productMasterTableAdapter.Fill(this._Vis_InventoryDataSet.ProductMaster);
            
            txtTotalAmt.Properties.Mask.Culture = Globals.getCulture();
            txtDeliveryDate.Properties.Mask.EditMask = Settings.Default.cfgDateFormat;
            txtNumber.Mask.Culture = Globals.getCulture();
            string str = "SELECT DISTINCT Bin_location_id FROM Location_Master";
            if (!Data_Access.DoSqlCommand(str)) return;
            this.repositoryItemLookUpEdit3.DataSource = Data_Access.GetDataSet().Tables[0].Copy();
            LoadInfo();
        }

        private GridView gvPurchaseDetails;

        public t_Purchase_Order_HeaderRec rec = new t_Purchase_Order_HeaderRec();

        private void LoadInfo()
        {
            try
            {
                // Disable Print button if Create new
                // Save the PO fisrt if in create new
                if (rec == null || rec.PONo == null)
                {
                    btnPrint.Visible = false;
                    txtPONo.Enabled = true;
                }
                else
                {
                    btnPrint.Visible = true;
                    txtPONo.Enabled = false;
                }

                // Fill OrderType combo-box
                for (int i = 0; i < Globals.tblOrderType.RowCount; i++)
                    if (Globals.tblOrderType[i].ViewStatus)
                        cbPOType.Properties.Items.Add(new TabItem(Globals.tblOrderType[i].OrderTypeID, Globals.tblOrderType[i].OrderTypeName));

                // Fill tax combo-box
                for (int nCount = 0; nCount < Globals.taxCodeMasterTable.RowCount; nCount++)
                    if (Globals.taxCodeMasterTable[nCount].ViewStatus)
                        if (Globals.paymentTermMasterTable[nCount].ViewStatus)
                        cboTaxID.Properties.Items.Add(new TabItem(Globals.taxCodeMasterTable[nCount].Tax_code_id, Globals.taxCodeMasterTable[nCount].Tax_code_desc));

                // Fill Payment Term combo-box
                for (int nCount = 0; nCount < Globals.paymentTermMasterTable.RowCount; nCount++)
                        cboPatmentTerm.Properties.Items.Add(new TabItem(Globals.paymentTermMasterTable[nCount].ID, Globals.paymentTermMasterTable[nCount].PaymentTermsName));

                //InitValue(); // init value
                //currentSupplierID = rec.SupplierID;
                FillDataHeader(rec);
                // show gridview

                //******** PDKien edited

                grdPurchaseDetails.DataSource = Globals.purchaseOrderDetailTable; 
                gvPurchaseDetails = (GridView)grdPurchaseDetails.Views[0];

                gvPurchaseDetails.Columns["PONo"].FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
                gvPurchaseDetails.Columns["PONo"].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo(rec.PONo);
                gvPurchaseDetails.Columns["PONo"].Visible = false;
                gvPurchaseDetails.Columns["POLineNo"].Visible = false;
                gvPurchaseDetails.Columns["ViewStatus"].Visible = false;
                gvPurchaseDetails.Columns["POSupplierProduct"].Visible = false;
                gvPurchaseDetails.Columns["PackQty"].Visible = false;
                gvPurchaseDetails.Columns["ReceiveQty"].Visible = false;
                gvPurchaseDetails.Columns["ProductUnit"].OptionsColumn.AllowEdit = false;
                gvPurchaseDetails.Columns["Amount"].OptionsColumn.AllowEdit = false;
                gvPurchaseDetails.Columns["OrderQty"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gvPurchaseDetails.Columns["OrderQty"].DisplayFormat.FormatString = "f2";
                gvPurchaseDetails.Columns["UnitPrice"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gvPurchaseDetails.Columns["UnitPrice"].DisplayFormat.FormatString = "f2";
                gvPurchaseDetails.Columns["POProductID"].ColumnEdit = this.repositoryItemLookUpEdit1;                
                gvPurchaseDetails.Columns["Warehouse_id"].ColumnEdit = this.repositoryItemLookUpEdit2;
                gvPurchaseDetails.Columns["Location_id"].ColumnEdit = this.repositoryItemLookUpEdit3;

                // Re-display the view with naming convention
                gvPurchaseDetails.Columns["POProductID"].Caption = "ProductID";                
                gvPurchaseDetails.Columns["OrderQty"].Caption = "Quantity";
                gvPurchaseDetails.Columns["ProductUnit"].Caption = "Unit";
                gvPurchaseDetails.Columns["UnitPrice"].Caption = "Unit Price";
                gvPurchaseDetails.Columns["Warehouse_id"].Caption = "Warehouse";
                gvPurchaseDetails.Columns["Location_id"].Caption = "Location";               

                // row update
                gvPurchaseDetails.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(gvPurchaseDetails_RowUpdated);

                // find supplier                
                DataRow[] lstRows = Globals.daSupplier.View().Tables[0].Select("[Contact ID] = '" + currentSupplierID + "'");

                if (lstRows.Length > 0)
                {
                    DataRow row = lstRows[0];
                    Supplier sup = new Supplier();
                    sup.AssignDataRow(row);
                    bteSupplierName.Text = ContactBase.GetContactName(rec.SupplierID);
                }

                // Can not update PO if Status is Approved
                string strOrderType = Toolkit.DbToolKit.OpenSqlGetFirstFieldData("Select OrderTypeID From OrderType Where OrderTypeName = 'Approved'", "OrderTypeID");
                if (strOrderType.Equals(rec.POTypeID))
                {
                    btnOK.Visible = false;
                    btnPrint.Location = btnOK.Location;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void gvPurchaseDetails_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            DataRowView rv = (DataRowView)e.Row;
            try
            {
                if (rv["PONo"].ToString() == "")
                    rv["PONo"] = rec.PONo;
                if (rv["POLineNo"].ToString() == "")
                    rv["POLineNo"] = ContactBase.GetID();
            }
            catch { }
            try
            {
                string strSQL = "SELECT * FROM ProductMaster";
                if (!Data_Access.DoSqlCommand(strSQL)) return;
                DataRow row = Data_Access.GetDataSet().Tables[0].Copy().Select("ProductID = '" + rv["POProductID"] + "'")[0];
                rv["ProductUnit"] = row["UOMID"];
                if (rv["OrderQty"].ToString() == "" || Double.Parse(rv["OrderQty"].ToString()) < 0) rv["OrderQty"] = 0;
                if (rv["UnitPrice"].ToString() == "" || Double.Parse(rv["UnitPrice"].ToString()) < 0) rv["UnitPrice"] = 0;

                rv["Amount"] = Double.Parse(rv["OrderQty"].ToString()) * Double.Parse(rv["UnitPrice"].ToString());
                //rv["ProductName"] = row["ProductName"];
            }
            catch {}
            try
            {
                if (rv["Warehouse_id"].ToString() != "")
                {
                    string strSQL1 = "SELECT Location_Master.Warehouse_id, Warehouse_Master.Description, Location_Master.Bin_location_id, Location_Master.Product_id FROM Location_Master, Warehouse_Master WHERE Location_Master.Warehouse_id = Warehouse_Master.Warehouse_id AND Warehouse_Master.Description = '" + rv["Warehouse_id"] + "' AND Location_Master.Bin_location_id = '" + rv["Location_id"] + "' AND Location_Master.Product_id = '" + rv["ProductID"] + "'";
                    if (!Data_Access.DoSqlCommand(strSQL1)) return;
                    if (Data_Access.GetDataSet().Tables[0].Copy().Rows.Count == 0)
                    {
                        MessageBox.Show("Cannot find this item in the Location");
                        rv["Location_id"] = "";
                    }
                }
            }
            catch { }
        }

        private void FillDataHeader(t_Purchase_Order_HeaderRec rec)
        {
            try
            {
                txtPONo.Text = rec.PONo;
                txtDeliveryDate.Text = rec.DeliveryDate.ToShortDateString();
                txtPODate.Text = rec.PODate.ToShortDateString();
                txtTotalAmt.Text = rec.TotalAmt.ToString();
                txtShipTo.Text = rec.ShipTo;
                chkPOStatus.Checked = rec.ViewStatus;
                memoNotes.Text = rec.Notes;

                DataRow row;
                DataRow[] oRows = Globals.tblOrderType.Select("OrderTypeID = '" + rec.POTypeID + "'");
                if (oRows.Length > 0)
                {
                    row = oRows[0];
                    cbPOType.Text = row["OrderTypeName"].ToString();
                }
                
                // Display tax code id
                oRows = Globals.taxCodeMasterTable.Select("Tax_code_id = '" + rec.Tax_code_id + "'");
                if (oRows.Length > 0)
                {
                    row = oRows[0];
                    cboTaxID.Text = row["Tax_code_desc"].ToString();
                }

                // Display payment term
                oRows = Globals.paymentTermMasterTable.Select("ID = '" + rec.PaymentTermsID + "'");
                if (oRows.Length > 0)
                {
                    row = oRows[0];
                    cboPatmentTerm.Text = row["PaymentTermsName"].ToString();
                }

                txtFOB.Text = rec.FOB;
                txtShippingFee.Text = rec.ShippingFee.ToString();
                txtTaxPercentage.Text = ((Decimal)(rec.TaxPercentage*100)).ToString();
                txtDiscountAmount.Text = rec.Discount.ToString();
                txtTotalAmt.Text = rec.ReceivedAmt.ToString();
                txtShipVia.Text = rec.ShipViaID;
                memoNotes.Text = rec.Notes;

                // Get pure total amount and calculate for others accounting
                decimal dPureTotal = GetCoreTotalAmmount();
                if (dPureTotal != 0)
                {
                    txtSubtotal.Text = ((Decimal)(dPureTotal - rec.Discount)).ToString();
                    txtTaxAmount.Text = ((Decimal)(dPureTotal * rec.TaxPercentage)).ToString();
                    txtDiscountPercentage.Text = ((Decimal)(100 * rec.Discount / dPureTotal)).ToString();
                    txtTotal.Text = ((Decimal)(dPureTotal + rec.ShippingFee + dPureTotal * rec.TaxPercentage - rec.Discount)).ToString();
                    txtBalanceDue.Text = ((Decimal)(Decimal.Parse(txtTotal.Text) - rec.ReceivedAmt)).ToString();
                    txtDiscountPercentage.Text = ((Decimal)((rec.Discount / dPureTotal) * 100)).ToString();
                    txtTaxAmount.Text = ((Decimal)(rec.TaxPercentage * dPureTotal)).ToString();
                }
                else
                {
                    txtSubtotal.Text = "0";
                    txtTaxAmount.Text = "0";
                    txtDiscountPercentage.Text = "0";
                    txtTotal.Text = "0";
                    txtBalanceDue.Text = "0";
                    txtDiscountPercentage.Text = "0";
                    txtTaxAmount.Text = "0";
                }
            }
            catch (Exception oExc)
            {
                MessageBox.Show(String.Format("Error encountered while loading Purchage Order. {0}", oExc.Message), "Alert", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }

        private void txtDeliveryDate_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = ValidateDate(txtDeliveryDate.Text);
        }

        private void txtPODate_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = ValidateDate(txtPODate.Text);
        }

        private bool ValidateDate(string strDate)
        {
            try
            {
                DateTime t1 = (DateTime.Parse(strDate));
                if (t1 >= new DateTime(1753, 1, 1) && t1 <= new DateTime(9999, 12, 31))
                    return false;
            }
            catch { }
            return true;
        }

        private void txtPONo_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = (txtPONo.Text == null || txtPONo.Text == "");
        }

        private void txtNumber_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                if (Double.Parse(e.NewValue.ToString()) < 0) e.Cancel = true;
            }
            catch (Exception) { e.Cancel = true; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Validate
            if (!IsDataValid()) return;

            // Calculate payment before saving PO
            CalculatePayment();

            // Update the PO object
            if (cbPOType.SelectedIndex >= 0)
            {
                rec.POTypeID = ((TabItem)(cbPOType.Properties.Items[cbPOType.SelectedIndex])).ItemID;
            }
            if (cboTaxID.SelectedIndex >= 0)
            {
                rec.Tax_code_id = ((TabItem)(cboTaxID.Properties.Items[cboTaxID.SelectedIndex])).ItemID;
            }
            if (cboPatmentTerm.SelectedIndex >= 0)
            {
                rec.PaymentTermsID = ((TabItem)(cboPatmentTerm.Properties.Items[cboPatmentTerm.SelectedIndex])).ItemID;
            }            

            rec.PONo = txtPONo.Text;
            rec.DeliveryDate = DateTime.Parse(txtDeliveryDate.Text);
            rec.PODate = DateTime.Parse(txtPODate.Text);
            rec.ShipTo = txtShipTo.Text;
            rec.SupplierID = currentSupplierID;
            rec.TotalAmt = Decimal.Parse(txtTotalAmt.Text);
            rec.ViewStatus = chkPOStatus.Checked;
            rec.Notes = memoNotes.Text;
            rec.ShippingFee = Decimal.Parse(txtShippingFee.Text);
            rec.ShipViaID = txtShipVia.Text;
            rec.TaxPercentage = Decimal.Parse(txtTaxPercentage.Text)/100;
            rec.FOB = txtFOB.Text;
            rec.ShipViaID = txtShipVia.Text;
            rec.ReceivedAmt = Decimal.Parse(txtTotalAmt.Text);
            rec.Discount = Decimal.Parse(txtDiscountAmount.Text);
            
            // Notify the REC object is accepted to write then return back to parent form
            MessageBox.Show("The Purchage Order has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// This method is to calculate payment before saving PO
        /// </summary>
        private void CalculatePayment()
        {
            decimal dPureTotal = GetCoreTotalAmmount();
            txtDiscountAmount.Text = ((Decimal)(dPureTotal*Decimal.Parse(txtDiscountPercentage.Text)/100)).ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTotalAmt_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                if (e.NewValue.ToString().IndexOf("-") >= 0) e.Cancel = true;
                if (Double.Parse(e.NewValue.ToString()) < 0) e.Cancel = true;
            }
            catch (Exception) {}
        }
        /***********************************************
         * Modified by: DuongNT
         * Lastupdate: 5/4/2007
         ***********************************************/
        private void txtPONo_EditValueChanged(object sender, EventArgs e)
        {
            // Temporary disable ability to show detail

            //rec.PONo = txtPONo.Text;
            ////change PONo in purchase detail
            //ChangePNOInPurchaseDetail(rec.PONo);
            //try { gvPurchaseDetails.Columns["PONo"].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo(rec.PONo); }
            //catch { }
        }
        
        private void ChangePNOInPurchaseDetail(string No)
        {
            DataRow[] rows = Globals.purchaseOrderDetailTable.Select("[PONo] = '" + No + "'");
            for (int i = 0; i < rows.Length; i++)
            {
                rows[i]["PONo"] = No;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Print report
            frmPOReport oReporter = new frmPOReport(rec.PONo);
            oReporter.ShowDialog();
        }

        /// <summary>
        /// This method is to validate input data. It returns true if all input data are valid.
        /// Otherwise, false and focus on the invalid UI element
        /// </summary>
        private bool IsDataValid()
        {
            // Check duplicate number if in creating mode
            if (txtPONo.Enabled)
            {
                DataTable oTable = Toolkit.DbToolKit.OpenSqlReturnTable(String.Format("Select * From t_Purchase_Order_Header Where PONo = '{0}'", txtPONo.Text.Trim()));
                if (oTable.Rows.Count > 0)
                {
                    MessageBox.Show("The Purchase Order Number is already exist, please choose another one.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPONo.Focus();
                    return false;
                }
            }

            try
            {
                rec.PODate = (DateTime.Parse(txtPODate.Text));
            }
            catch 
            {
                MessageBox.Show("The system can't accept Purchage Date because of its invalid format.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPODate.Focus();
                return false;
            }
            try
            {
                rec.DeliveryDate = (DateTime.Parse(txtDeliveryDate.Text));
            }
            catch 
            {
                MessageBox.Show("The system can't accept Deliver Date because of its invalid format.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDeliveryDate.Focus();
                return false;
            }
            
            if (!IsDecimalText("Tax Percentage", txtTaxPercentage, true)) return false;
            if (!IsDecimalText("Discount Percentage", txtDiscountPercentage, true)) return false;
            if (!IsDecimalText("Shipping Fee", txtShippingFee, false)) return false;
            if (!IsDecimalText("Total Amount", txtTotalAmt, false)) return false;

            decimal dPureTotal = GetCoreTotalAmmount();
            decimal dTotal = ((Decimal)(dPureTotal + Decimal.Parse(txtShippingFee.Text) + dPureTotal * Decimal.Parse(txtTaxPercentage.Text)/100));
            if (dPureTotal * Decimal.Parse(txtDiscountPercentage.Text) / 100 > dTotal)
            {
                MessageBox.Show("The system can't accept Discount Amount will be greater than Total Amount.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDiscountPercentage.Focus();
                return false;
            }
            if (Decimal.Parse(txtTotalAmt.Text) > dTotal - dPureTotal * Decimal.Parse(txtDiscountPercentage.Text) / 100)
            {
                MessageBox.Show("The system can't accept Received Amount will be greater than Total Amount.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTotalAmt.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// This method is to check a string is decimal or not
        /// </summary>
        private bool IsDecimalText(string strFieldName, TextEdit oBox, bool isPercentage)
        {
            try
            {
                decimal dValue;
                try
                {
                    dValue = Decimal.Parse(oBox.Text);
                }
                catch
                {
                    throw new Exception(String.Format("The system can't accept {0} because it is not a decimal.", strFieldName));
                }
                if (isPercentage)
                {
                    if (dValue < 0 || dValue > 100)
                    {
                        throw new Exception(String.Format("{0} can't be greater than 100% or less than 0%.", strFieldName));
                    }
                }
            }
            catch (Exception oExc)
            {
                MessageBox.Show(oExc.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                oBox.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// This method return total amount without any accounting fee of a Purchase Order
        /// </summary>
        /// <returns></returns>
        private decimal GetCoreTotalAmmount()
        {
            decimal dValue = 0;
            DataRow[] oRows = Globals.purchaseOrderDetailTable.Select("[PONo] = '" + rec.PONo + "'");
            for (int nCount = 0; nCount < oRows.Length; nCount++)
            {
                dValue += Decimal.Parse(oRows[nCount]["Amount"].ToString());
            }
            return dValue;
        }
    }
}