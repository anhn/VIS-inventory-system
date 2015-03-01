using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;

namespace Inventory
{
    /// <summary>
    /// Summary description for SO_Form2.
    /// </summary>
    public class SO_Form : DevExpress.XtraEditors.XtraForm
    {
        private TextEdit txtSODate;
        private TextEdit txtSONo;
        private Label lblSOType;
        private Label lblSODate;
        private Label lblSONo;
        private ComboBoxEdit cbSOType;
        private SimpleButton btnCancel;
        private OpenFileDialog openFileDialog1;
        private ComboBoxEdit cbTaxCode;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private CheckEdit chkViewStatus;
        private MemoEdit memoNote;
        private Label lblSONote;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel2;
        private GroupControl grpSO;
        private SimpleButton btnOK;
        private DevExpress.XtraGrid.GridControl grdSalesDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSaleOrderDetail;
        private ButtonEdit bteCustName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtNumber;
        private SimpleButton btnPrint;
        private GroupControl groupControl1;
        private GroupControl groupControl2;
        private GroupControl groupControl3;
        private Label label1;
        private TextEdit txtTaxPercentage;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextEdit txtDiscountPercentage;
        private GroupControl groupControl4;
        private Label label10;
        private TextEdit txtDiscountAmount;
        private TextEdit txtTaxAmount;
        private Label label9;
        private TextEdit txtTotal;
        private Label label12;
        private TextEdit txtBalanceDue;
        private Label label6;
        private TextEdit txtSubtotal;
        private Label label11;
        private TextEdit txtShippingFee;
        private ComboBoxEdit cboPaymentTerm;
        private Label label8;
        private Label label7;
        private Label label5;
        private TextEdit txtTotalAmt;
        private Label label14;
        private Label label13;
        private Label label16;
        private TextEdit txtFOB;
        private Label label15;
        private TextEdit txtShipVia;
        private IContainer components;

        public SO_Form()
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
            this.txtSODate = new DevExpress.XtraEditors.TextEdit();
            this.txtSONo = new DevExpress.XtraEditors.TextEdit();
            this.lblSOType = new System.Windows.Forms.Label();
            this.lblSODate = new System.Windows.Forms.Label();
            this.lblSONo = new System.Windows.Forms.Label();
            this.cbSOType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbTaxCode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.chkViewStatus = new DevExpress.XtraEditors.CheckEdit();
            this.memoNote = new DevExpress.XtraEditors.MemoEdit();
            this.lblSONote = new System.Windows.Forms.Label();
            this.defaultLookAndFeel2 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.grpSO = new DevExpress.XtraEditors.GroupControl();
            this.bteCustName = new DevExpress.XtraEditors.ButtonEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.grdSalesDetail = new DevExpress.XtraGrid.GridControl();
            this.gvSaleOrderDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtNumber = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaxPercentage = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiscountPercentage = new DevExpress.XtraEditors.TextEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiscountAmount = new DevExpress.XtraEditors.TextEdit();
            this.txtTaxAmount = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBalanceDue = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubtotal = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.txtShippingFee = new DevExpress.XtraEditors.TextEdit();
            this.cboPaymentTerm = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalAmt = new DevExpress.XtraEditors.TextEdit();
            this.txtShipVia = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtFOB = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSODate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSONo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSOType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTaxCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSO)).BeginInit();
            this.grpSO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteCustName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSaleOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxPercentage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountPercentage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalanceDue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShippingFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPaymentTerm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipVia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFOB.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSODate
            // 
            this.txtSODate.Location = new System.Drawing.Point(412, 28);
            this.txtSODate.Name = "txtSODate";
            this.txtSODate.Properties.DisplayFormat.FormatString = "d";
            this.txtSODate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtSODate.Properties.Mask.EditMask = "d";
            this.txtSODate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtSODate.Properties.ValidateOnEnterKey = true;
            this.txtSODate.Size = new System.Drawing.Size(184, 20);
            this.txtSODate.TabIndex = 2;
            this.txtSODate.ToolTip = "Date must >= 1/1/1753 and  <= 12/31/9999";
            this.txtSODate.Validating += new System.ComponentModel.CancelEventHandler(this.txtSODate_Validating);
            // 
            // txtSONo
            // 
            this.txtSONo.Location = new System.Drawing.Point(119, 28);
            this.txtSONo.Name = "txtSONo";
            this.txtSONo.Size = new System.Drawing.Size(173, 20);
            this.txtSONo.TabIndex = 1;
            this.txtSONo.Validating += new System.ComponentModel.CancelEventHandler(this.txtSONo_Validating);
            this.txtSONo.EditValueChanged += new System.EventHandler(this.txtSONo_EditValueChanged);
            // 
            // lblSOType
            // 
            this.lblSOType.AutoSize = true;
            this.lblSOType.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strSaleOrderType", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSOType.Location = new System.Drawing.Point(11, 57);
            this.lblSOType.Name = "lblSOType";
            this.lblSOType.Size = new System.Drawing.Size(96, 13);
            this.lblSOType.TabIndex = 78;
            this.lblSOType.Text = global::Inventory.Properties.Settings.Default.strSaleOrderType;
            // 
            // lblSODate
            // 
            this.lblSODate.AutoSize = true;
            this.lblSODate.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strSaleOrderDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSODate.Location = new System.Drawing.Point(318, 31);
            this.lblSODate.Name = "lblSODate";
            this.lblSODate.Size = new System.Drawing.Size(88, 13);
            this.lblSODate.TabIndex = 11;
            this.lblSODate.Text = global::Inventory.Properties.Settings.Default.strSaleOrderDate;
            // 
            // lblSONo
            // 
            this.lblSONo.AutoSize = true;
            this.lblSONo.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strSaleOrderNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSONo.Location = new System.Drawing.Point(11, 31);
            this.lblSONo.Name = "lblSONo";
            this.lblSONo.Size = new System.Drawing.Size(102, 13);
            this.lblSONo.TabIndex = 9;
            this.lblSONo.Text = global::Inventory.Properties.Settings.Default.strSaleOrderNo;
            // 
            // cbSOType
            // 
            this.cbSOType.Location = new System.Drawing.Point(119, 54);
            this.cbSOType.Name = "cbSOType";
            this.cbSOType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSOType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSOType.Size = new System.Drawing.Size(173, 20);
            this.cbSOType.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCancel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(789, 576);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = global::Inventory.Properties.Settings.Default.strCancel;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbTaxCode
            // 
            this.cbTaxCode.Location = new System.Drawing.Point(94, 28);
            this.cbTaxCode.Name = "cbTaxCode";
            this.cbTaxCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTaxCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTaxCode.Size = new System.Drawing.Size(184, 20);
            this.cbTaxCode.TabIndex = 7;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.defaultLookAndFeel1.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // chkViewStatus
            // 
            this.chkViewStatus.Location = new System.Drawing.Point(9, 136);
            this.chkViewStatus.Name = "chkViewStatus";
            this.chkViewStatus.Properties.Caption = "Mark As Viewable";
            this.chkViewStatus.Size = new System.Drawing.Size(108, 19);
            this.chkViewStatus.TabIndex = 4;
            // 
            // memoNote
            // 
            this.memoNote.Location = new System.Drawing.Point(13, 174);
            this.memoNote.Name = "memoNote";
            this.memoNote.Size = new System.Drawing.Size(581, 52);
            this.memoNote.TabIndex = 5;
            // 
            // lblSONote
            // 
            this.lblSONote.AutoSize = true;
            this.lblSONote.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strSaleOrderNote", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSONote.Location = new System.Drawing.Point(10, 158);
            this.lblSONote.Name = "lblSONote";
            this.lblSONote.Size = new System.Drawing.Size(34, 13);
            this.lblSONote.TabIndex = 48;
            this.lblSONote.Text = global::Inventory.Properties.Settings.Default.strSaleOrderNote;
            // 
            // grpSO
            // 
            this.grpSO.Controls.Add(this.label16);
            this.grpSO.Controls.Add(this.txtFOB);
            this.grpSO.Controls.Add(this.label15);
            this.grpSO.Controls.Add(this.txtShipVia);
            this.grpSO.Controls.Add(this.chkViewStatus);
            this.grpSO.Controls.Add(this.memoNote);
            this.grpSO.Controls.Add(this.lblSONote);
            this.grpSO.Controls.Add(this.cbSOType);
            this.grpSO.Controls.Add(this.txtSODate);
            this.grpSO.Controls.Add(this.txtSONo);
            this.grpSO.Controls.Add(this.lblSOType);
            this.grpSO.Controls.Add(this.lblSODate);
            this.grpSO.Controls.Add(this.lblSONo);
            this.grpSO.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strGroupSaleOrder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.grpSO.Location = new System.Drawing.Point(3, 6);
            this.grpSO.Name = "grpSO";
            this.grpSO.Size = new System.Drawing.Size(611, 234);
            this.grpSO.TabIndex = 9;
            this.grpSO.Text = global::Inventory.Properties.Settings.Default.strGroupSaleOrder;
            // 
            // bteCustName
            // 
            this.bteCustName.Location = new System.Drawing.Point(94, 30);
            this.bteCustName.Name = "bteCustName";
            this.bteCustName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteCustName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.bteCustName.Size = new System.Drawing.Size(184, 20);
            this.bteCustName.TabIndex = 6;
            this.bteCustName.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteCustName_ButtonClick);
            // 
            // btnOK
            // 
            this.btnOK.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strOK", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(674, 576);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(109, 23);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = global::Inventory.Properties.Settings.Default.strOK;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grdSalesDetail
            // 
            this.grdSalesDetail.EmbeddedNavigator.Name = "";
            this.grdSalesDetail.Location = new System.Drawing.Point(3, 384);
            this.grdSalesDetail.MainView = this.gvSaleOrderDetail;
            this.grdSalesDetail.Name = "grdSalesDetail";
            this.grdSalesDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtNumber});
            this.grdSalesDetail.Size = new System.Drawing.Size(904, 182);
            this.grdSalesDetail.TabIndex = 19;
            this.grdSalesDetail.UseEmbeddedNavigator = true;
            this.grdSalesDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSaleOrderDetail});
            // 
            // gvSaleOrderDetail
            // 
            this.gvSaleOrderDetail.GridControl = this.grdSalesDetail;
            this.gvSaleOrderDetail.Name = "gvSaleOrderDetail";
            this.gvSaleOrderDetail.OptionsView.ShowGroupPanel = false;
            this.gvSaleOrderDetail.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // txtNumber
            // 
            this.txtNumber.AutoHeight = false;
            this.txtNumber.Mask.EditMask = "n2";
            this.txtNumber.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNumber.Mask.UseMaskAsDisplayFormat = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtNumber_EditValueChanging);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(554, 576);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(114, 23);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.bteCustName);
            this.groupControl1.Location = new System.Drawing.Point(620, 7);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(287, 61);
            this.groupControl1.TabIndex = 21;
            this.groupControl1.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = "Name:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label14);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.txtTaxPercentage);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.cbTaxCode);
            this.groupControl2.Location = new System.Drawing.Point(620, 74);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(287, 100);
            this.groupControl2.TabIndex = 22;
            this.groupControl2.Text = "Tax";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(200, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 93;
            this.label14.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Percentage:";
            // 
            // txtTaxPercentage
            // 
            this.txtTaxPercentage.EditValue = "0";
            this.txtTaxPercentage.Location = new System.Drawing.Point(94, 54);
            this.txtTaxPercentage.Name = "txtTaxPercentage";
            this.txtTaxPercentage.Properties.Mask.EditMask = "n2";
            this.txtTaxPercentage.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTaxPercentage.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTaxPercentage.Size = new System.Drawing.Size(100, 20);
            this.txtTaxPercentage.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Tax code:";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.label13);
            this.groupControl3.Controls.Add(this.label4);
            this.groupControl3.Controls.Add(this.txtDiscountPercentage);
            this.groupControl3.Location = new System.Drawing.Point(620, 180);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(287, 60);
            this.groupControl3.TabIndex = 23;
            this.groupControl3.Text = "Discount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(200, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 92;
            this.label13.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "Percentage:";
            // 
            // txtDiscountPercentage
            // 
            this.txtDiscountPercentage.EditValue = "0";
            this.txtDiscountPercentage.Location = new System.Drawing.Point(94, 28);
            this.txtDiscountPercentage.Name = "txtDiscountPercentage";
            this.txtDiscountPercentage.Properties.Mask.EditMask = "n2";
            this.txtDiscountPercentage.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscountPercentage.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDiscountPercentage.Size = new System.Drawing.Size(100, 20);
            this.txtDiscountPercentage.TabIndex = 9;
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
            this.groupControl4.Controls.Add(this.cboPaymentTerm);
            this.groupControl4.Controls.Add(this.label8);
            this.groupControl4.Controls.Add(this.label7);
            this.groupControl4.Controls.Add(this.label5);
            this.groupControl4.Controls.Add(this.txtTotalAmt);
            this.groupControl4.Location = new System.Drawing.Point(3, 246);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(904, 132);
            this.groupControl4.TabIndex = 120;
            this.groupControl4.Text = "Payment";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(339, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 122;
            this.label10.Text = "Tax Amount:";
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.EditValue = "0";
            this.txtDiscountAmount.Enabled = false;
            this.txtDiscountAmount.Location = new System.Drawing.Point(711, 52);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.Properties.Mask.EditMask = "n2";
            this.txtDiscountAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscountAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(184, 20);
            this.txtDiscountAmount.TabIndex = 16;
            this.txtDiscountAmount.EditValueChanged += new System.EventHandler(this.txtDiscountAmount_EditValueChanged);
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.EditValue = "0";
            this.txtTaxAmount.Enabled = false;
            this.txtTaxAmount.Location = new System.Drawing.Point(412, 53);
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.Properties.Mask.EditMask = "n2";
            this.txtTaxAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTaxAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTaxAmount.Size = new System.Drawing.Size(183, 20);
            this.txtTaxAmount.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(617, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 83;
            this.label9.Text = "Discount Amount:";
            // 
            // txtTotal
            // 
            this.txtTotal.EditValue = "0";
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(711, 77);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Mask.EditMask = "n2";
            this.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotal.Size = new System.Drawing.Size(184, 20);
            this.txtTotal.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(674, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 129;
            this.label12.Text = "Total:";
            // 
            // txtBalanceDue
            // 
            this.txtBalanceDue.EditValue = "0";
            this.txtBalanceDue.Enabled = false;
            this.txtBalanceDue.Location = new System.Drawing.Point(119, 79);
            this.txtBalanceDue.Name = "txtBalanceDue";
            this.txtBalanceDue.Properties.Mask.EditMask = "n2";
            this.txtBalanceDue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBalanceDue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtBalanceDue.Size = new System.Drawing.Size(173, 20);
            this.txtBalanceDue.TabIndex = 12;
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
            // txtSubtotal
            // 
            this.txtSubtotal.EditValue = "0";
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(412, 79);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Properties.Mask.EditMask = "n2";
            this.txtSubtotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSubtotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSubtotal.Size = new System.Drawing.Size(183, 20);
            this.txtSubtotal.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(615, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 126;
            this.label11.Text = "Received Amount:";
            // 
            // txtShippingFee
            // 
            this.txtShippingFee.EditValue = "0";
            this.txtShippingFee.Location = new System.Drawing.Point(119, 53);
            this.txtShippingFee.Name = "txtShippingFee";
            this.txtShippingFee.Properties.Mask.EditMask = "n2";
            this.txtShippingFee.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtShippingFee.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtShippingFee.Size = new System.Drawing.Size(173, 20);
            this.txtShippingFee.TabIndex = 11;
            // 
            // cboPaymentTerm
            // 
            this.cboPaymentTerm.Location = new System.Drawing.Point(119, 27);
            this.cboPaymentTerm.Name = "cboPaymentTerm";
            this.cboPaymentTerm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPaymentTerm.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboPaymentTerm.Size = new System.Drawing.Size(173, 20);
            this.cboPaymentTerm.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 83);
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
            this.label5.Location = new System.Drawing.Point(11, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 121;
            this.label5.Text = "Payment Term:";
            // 
            // txtTotalAmt
            // 
            this.txtTotalAmt.EditValue = "0";
            this.txtTotalAmt.Location = new System.Drawing.Point(711, 103);
            this.txtTotalAmt.Name = "txtTotalAmt";
            this.txtTotalAmt.Properties.Mask.EditMask = "n2";
            this.txtTotalAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalAmt.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotalAmt.Size = new System.Drawing.Size(184, 20);
            this.txtTotalAmt.TabIndex = 18;
            // 
            // txtShipVia
            // 
            this.txtShipVia.Location = new System.Drawing.Point(119, 80);
            this.txtShipVia.Name = "txtShipVia";
            this.txtShipVia.Size = new System.Drawing.Size(477, 20);
            this.txtShipVia.TabIndex = 79;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 90;
            this.label15.Text = "Ship Via:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 92;
            this.label16.Text = "FOB:";
            // 
            // txtFOB
            // 
            this.txtFOB.Location = new System.Drawing.Point(119, 107);
            this.txtFOB.Name = "txtFOB";
            this.txtFOB.Size = new System.Drawing.Size(477, 20);
            this.txtFOB.TabIndex = 91;
            // 
            // SO_Form
            // 
            this.AcceptButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(912, 607);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.grdSalesDetail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpSO);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SO_Form";
            this.ShowInTaskbar = false;
            this.Text = "Sales Order Detail";
            this.Load += new System.EventHandler(this.SO_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSODate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSONo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSOType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTaxCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSO)).EndInit();
            this.grpSO.ResumeLayout(false);
            this.grpSO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteCustName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSaleOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxPercentage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountPercentage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalanceDue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShippingFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPaymentTerm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipVia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFOB.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region
        public t_Sales_Order_HeaderRec SaleOrder
        {
            get { return salesOrderHeaderRec; }
            set
            {
                salesOrderHeaderRec = value;
                currentCustID = salesOrderHeaderRec.CustID;
            }
        }
        #endregion

        private void SO_Form_Load(object sender, EventArgs e)
        {
            txtDiscountAmount.Properties.Mask.Culture = Globals.getCulture();
            LoadInfo();
        }        

        // test
        private t_Sales_Order_HeaderRec salesOrderHeaderRec = new t_Sales_Order_HeaderRec();

        private string currentCustID = "";        

        private void LoadInfo()
        {
            try
            {
                // Hide Print button if create new one
                if (salesOrderHeaderRec == null || salesOrderHeaderRec.SONo == null)
                {
                    btnPrint.Visible = false;
                    txtSONo.Enabled = true;
                }
                else
                {
                    btnPrint.Visible = true;
                    txtSONo.Enabled = false;
                }

                // fill taxCode combo
                for (int i = 0; i < Globals.taxCodeMasterTable.RowCount; i++)
                    if (Globals.taxCodeMasterTable[i].ViewStatus)
                        cbTaxCode.Properties.Items.Add(new TabItem(Globals.taxCodeMasterTable[i].Tax_code_id, Globals.taxCodeMasterTable[i].Tax_code_desc));

                // fill SOType combo
                for (int i = 0; i < Globals.tblOrderType.RowCount; i++)
                    if (Globals.tblOrderType[i].ViewStatus)
                        cbSOType.Properties.Items.Add(new TabItem(Globals.tblOrderType[i].OrderTypeID, Globals.tblOrderType[i].OrderTypeName));

                // Fill Payment Term combo-box
                for (int nCount = 0; nCount < Globals.paymentTermMasterTable.RowCount; nCount++)
                    cboPaymentTerm.Properties.Items.Add(new TabItem(Globals.paymentTermMasterTable[nCount].ID, Globals.paymentTermMasterTable[nCount].PaymentTermsName));
                
                // Fill corresponding value of SO to form
                FillSaleOrderHeader();

                // SO details
                grdSalesDetail.DataSource = Globals.salesOrderDetailTable;               
                gvSaleOrderDetail = (GridView)grdSalesDetail.Views[0];
                gvSaleOrderDetail.Columns["SONo"].FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
                gvSaleOrderDetail.Columns["SONo"].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo(salesOrderHeaderRec.SONo);
                gvSaleOrderDetail.Columns["SettleAmount"].Visible = false;
                gvSaleOrderDetail.Columns["OSAmount"].Visible = false;
                gvSaleOrderDetail.Columns["InvoiceNo"].Visible = false;
                gvSaleOrderDetail.Columns["ViewStatus"].Visible = false;
                gvSaleOrderDetail.Columns["DiscountPrice"].Visible = false;
                gvSaleOrderDetail.Columns["DiscountPer"].Visible = false;
                gvSaleOrderDetail.Columns["SONo"].Visible = false;
                gvSaleOrderDetail.Columns["SOLineNo"].Visible = false;
                
                // format number
                gvSaleOrderDetail.Columns["UnitPrice"].ColumnEdit = txtNumber;
                gvSaleOrderDetail.Columns["DiscountPrice"].ColumnEdit = txtNumber;
                gvSaleOrderDetail.Columns["DiscountPer"].ColumnEdit = txtNumber;
                gvSaleOrderDetail.Columns["TotalAmount"].ColumnEdit = txtNumber;
                gvSaleOrderDetail.Columns["SettleAmount"].ColumnEdit = txtNumber;
                gvSaleOrderDetail.Columns["OSAmount"].ColumnEdit = txtNumber;

                // Re-display view with naming convention
                gvSaleOrderDetail.Columns["TotalAmount"].OptionsColumn.AllowEdit = false;
                gvSaleOrderDetail.Columns["ProductUnit"].OptionsColumn.AllowEdit = false;
                gvSaleOrderDetail.Columns["ProductUnit"].Caption = "Unit";
                gvSaleOrderDetail.Columns["Warehouse_id"].Caption = "Warehouse";
                gvSaleOrderDetail.Columns["Location_id"].Caption = "Location";
                gvSaleOrderDetail.Columns["ProductID"].Caption = "Product ID";
                gvSaleOrderDetail.Columns["Qty"].Caption = "Quantity";
                gvSaleOrderDetail.Columns["TotalAmount"].Caption = "Total Amount";
                gvSaleOrderDetail.Columns["UnitPrice"].Caption = "Unit Price";                

                // Set handle for row-update event
                gvSaleOrderDetail.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(gvSaleOrderDetail_RowUpdated);

                // show Supplier
                DataRow[] oRows = Globals.daCustomer.View().Tables[0].Select("[Contact ID] = '" + currentCustID + "'");
                if (oRows.Length > 0)
                {
                    DataRow row = oRows[0];
                    Customer cust = new Customer();
                    cust.AssignDataRow(row);
                    bteCustName.Text = ContactBase.GetContactName(salesOrderHeaderRec.CustID);                    
                }
                memoNote.Text = salesOrderHeaderRec.Notes;

                // Can not update PO if Status is Approved
                string strOrderType = Toolkit.DbToolKit.OpenSqlGetFirstFieldData("Select OrderTypeID From OrderType Where OrderTypeName = 'Approved'", "OrderTypeID");
                if (strOrderType.Equals(salesOrderHeaderRec.SOTypeID))
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

        private void gvSaleOrderDetail_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            DataRowView rv = (DataRowView)e.Row;
            
            try
            {
                if (rv["SONo"].ToString() == "")
                    rv["SONo"] = salesOrderHeaderRec.SONo;
                if (rv["SOLineNo"].ToString() == "")
                    rv["SOLineNo"] = ContactBase.GetID();

                string strQty = rv["Qty"].ToString();
                string strPrice = rv["UnitPrice"].ToString();
                double dQty;
                double dPrice;

                if (strQty == null || strQty.Equals(""))
                {
                    dQty = 0;
                }
                else
                {
                    try
                    {
                        dQty = double.Parse(strQty);
                    }
                    catch
                    {
                        throw new Exception("Quantity must be a number.");
                    }
                }

                if (dQty < 0)
                {
                    throw new Exception("Quantity must be greater or equal zero.");
                }

                if (strPrice == null || strPrice.Equals(""))
                {
                    dPrice = 0;
                }
                else
                {
                    try
                    {
                        dPrice = double.Parse(strPrice);
                    }
                    catch
                    {
                        throw new Exception("Price must be a number.");
                    }
                }

                if (dPrice < 0)
                {
                    throw new Exception("Price must be greater or equal zero.");
                }

                rv["TotalAmount"] = dQty * dPrice;
            }
            catch (Exception oExc)
            {
                MessageBox.Show(oExc.Message);
            }
        }        

        private void FillSaleOrderHeader()
        {
            txtSONo.Text = salesOrderHeaderRec.SONo;
            txtSODate.Text = salesOrderHeaderRec.SODate.ToShortDateString();
            txtTaxPercentage.Text = ((Decimal)(salesOrderHeaderRec.TaxRate * 100)).ToString();
            txtDiscountAmount.Text = salesOrderHeaderRec.Discount.ToString();
            chkViewStatus.Checked = salesOrderHeaderRec.ViewStatus;
            memoNote.Text = salesOrderHeaderRec.Notes;
            txtShippingFee.Text = salesOrderHeaderRec.ShippingFee.ToString();
            txtShipVia.Text = salesOrderHeaderRec.ShipViaID;
            txtFOB.Text = salesOrderHeaderRec.FOB;
            txtTotalAmt.Text = salesOrderHeaderRec.ReceivedAmt.ToString();

            DataRow[] oRows = Globals.tblOrderType.Select("OrderTypeID = '" + salesOrderHeaderRec.SOTypeID + "'");
            if (oRows.Length > 0)
            {
                OrderTypeRec orderTypeRec = new OrderTypeRec(oRows[0]);
                cbSOType.Text = orderTypeRec.OrderTypeName;
            }
         
            oRows = Globals.taxCodeMasterTable.Select("Tax_code_id = '" + salesOrderHeaderRec.Tax_code_id + "'");
            if (oRows.Length > 0)
            {
                Tax_code_masterRec taxRec = new Tax_code_masterRec(oRows[0]);
                cbTaxCode.Text = taxRec.Tax_code_desc;
            }

            oRows = Globals.paymentTermMasterTable.Select("ID = '" + salesOrderHeaderRec.PaymentTermsID + "'");
            if (oRows.Length > 0)
            {
                Payment_Term_MasterRec payRec = new Payment_Term_MasterRec(oRows[0]);
                cboPaymentTerm.Text = payRec.PaymentTermsName;
            }
            
            // Calculate payment information for displaying
            decimal dPureTotal = GetCoreTotalAmmount();
            if (dPureTotal != 0)
            {
                txtDiscountPercentage.Text = ((Decimal)(salesOrderHeaderRec.Discount * 100 / dPureTotal)).ToString();
                txtTaxAmount.Text = ((Decimal)(salesOrderHeaderRec.TaxRate * dPureTotal)).ToString();
                txtSubtotal.Text = ((Decimal)(dPureTotal - salesOrderHeaderRec.Discount)).ToString();
                txtTotal.Text = ((Decimal)(Decimal.Parse(txtSubtotal.Text) + salesOrderHeaderRec.ShippingFee + Decimal.Parse(txtTaxAmount.Text))).ToString();
                txtBalanceDue.Text = ((Decimal)(Decimal.Parse(txtTotal.Text) - salesOrderHeaderRec.ReceivedAmt)).ToString();
            }
            else
            {
                txtDiscountPercentage.Text = "0";
                txtTaxAmount.Text = "0";
                txtSubtotal.Text = "0";
                txtTotal.Text = "0";
                txtBalanceDue.Text = "0";
            }

        }

        private void bteCustName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SelectCustomer frmSelectCust = new SelectCustomer();
            frmSelectCust.CustomerID = currentCustID;
            frmSelectCust.ShowDialog(this);
            currentCustID = frmSelectCust.CustomerID;
            try
            {
                DataRow row = Globals.daCustomer.View().Tables[0].Select("[Contact ID] = '" + currentCustID + "'")[0];
                Customer cust = new Customer();
                cust.AssignDataRow(row);
                bteCustName.Text = frmSelectCust.CustomerName;                
                memoNote.Text = cust.Notes;
            }
            catch { }
        }

        private void txtSODate_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                DateTime t1 = (DateTime.Parse(txtSODate.Text));
                if (t1 >= new DateTime(1753, 1, 1) && t1 <= new DateTime(9999, 12, 31))
                    e.Cancel = false;
                else e.Cancel = true;
            }
            catch
            { e.Cancel = true; }

        }

        private void txtSONo_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = (txtSONo.Text == null || txtSONo.Text == "");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Validate before saving the SO
            if (!IsDataValid())
            {
                DialogResult = DialogResult.Abort;
                return;
            }

            // Calculate before saving
            CalculatePayment();

            // Build information for SO
            if (cbSOType.SelectedIndex >= 0)
            {
                salesOrderHeaderRec.SOTypeID = ((TabItem)cbSOType.Properties.Items[cbSOType.SelectedIndex]).ItemID;
            }

            if (cbTaxCode.SelectedIndex >= 0)
            {
                salesOrderHeaderRec.Tax_code_id = ((TabItem)cbTaxCode.Properties.Items[cbTaxCode.SelectedIndex]).ItemID;
            }

            if (cboPaymentTerm.SelectedIndex >= 0)
            {
                salesOrderHeaderRec.PaymentTermsID = ((TabItem)cboPaymentTerm.Properties.Items[cboPaymentTerm.SelectedIndex]).ItemID;
            }

            salesOrderHeaderRec.SONo = txtSONo.Text;            
            salesOrderHeaderRec.SODate = DateTime.Parse(txtSODate.Text);
            salesOrderHeaderRec.PayAmount = Decimal.Parse(txtTotalAmt.Text);
            salesOrderHeaderRec.Discount = Decimal.Parse(txtDiscountAmount.Text);
            salesOrderHeaderRec.ShippingFee = Decimal.Parse(txtShippingFee.Text);
            salesOrderHeaderRec.ShipViaID = txtShipVia.Text;
            salesOrderHeaderRec.FOB = txtFOB.Text;
            salesOrderHeaderRec.Notes = memoNote.Text;
            salesOrderHeaderRec.ViewStatus = chkViewStatus.Checked;
            salesOrderHeaderRec.ReceivedAmt = Decimal.Parse(txtTotalAmt.Text);
            salesOrderHeaderRec.TaxRate = Decimal.Parse(txtTaxPercentage.Text)/100;
            salesOrderHeaderRec.CustID = currentCustID;

            MessageBox.Show("The Sale Order has saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// This method is to calculate and fill into payment text-boxes
        /// </summary>
        private void CalculatePayment()
        {
            decimal dPureTotal = GetCoreTotalAmmount();
            decimal dTax = Decimal.Parse(txtTaxPercentage.Text) * dPureTotal / 100;
            decimal dDiscount = Decimal.Parse(txtDiscountPercentage.Text) * dPureTotal / 100;
            decimal dSubtotal = dPureTotal - dDiscount;
            decimal dTotal = dSubtotal + Decimal.Parse(txtShippingFee.Text) + dTax;
            decimal dBalance = dTotal - Decimal.Parse(txtTotalAmt.Text);

            txtTaxAmount.Text = dTax.ToString();
            txtDiscountAmount.Text = dDiscount.ToString();
            txtSubtotal.Text = dSubtotal.ToString();
            txtTotal.Text = dTotal.ToString();
            txtBalanceDue.Text = dBalance.ToString();
        }

        /// <summary>
        /// This method is to validate input data. It returns true if all input data are valid.
        /// Otherwise, false and focus on the invalid UI element
        /// </summary>
        private bool IsDataValid()
        {
            // Check duplicate number if in creating mode
            if (txtSONo.Enabled)
            {
                DataTable oTable = Toolkit.DbToolKit.OpenSqlReturnTable(String.Format("Select * From t_Sales_Order_Header Where SONo = '{0}'", txtSONo.Text.Trim()));
                if (oTable.Rows.Count > 0)
                {
                    MessageBox.Show("The Sale Order Number is already exist, please choose another one.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtSONo.Focus();
                    return false;
                }
            }

            try
            {
                DateTime.Parse(txtSODate.Text);
            }
            catch
            {
                MessageBox.Show("The system can't accept Sale Order Date because of its invalid format.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSODate.Focus();
                return false;
            }

            if (!IsDecimalText("Tax Percentage", txtTaxPercentage, true)) return false;
            if (!IsDecimalText("Discount Percentage", txtDiscountPercentage, true)) return false;
            if (!IsDecimalText("Shipping Fee", txtShippingFee, false)) return false;
            if (!IsDecimalText("Total Amount", txtTotalAmt, false)) return false;

            decimal dPureTotal = GetCoreTotalAmmount();
            decimal dTotal = ((Decimal)(dPureTotal + Decimal.Parse(txtShippingFee.Text) + dPureTotal * Decimal.Parse(txtTaxPercentage.Text) / 100));
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
            DataRow[] oRows = Globals.salesOrderDetailTable.Select("[SONo] = '" + salesOrderHeaderRec.SONo + "'");
            for (int nCount = 0; nCount < oRows.Length; nCount++)
            {
                dValue += Decimal.Parse(oRows[nCount]["TotalAmount"].ToString());
            }
            return dValue;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ValidateNumber(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                if (e.NewValue.ToString().IndexOf("-") >= 0) e.Cancel = true;
                if (Double.Parse(e.NewValue.ToString()) < 0) e.Cancel = true;
            }
            catch (Exception) { e.Cancel = true; }
        }

        private void txtNumber_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                if (e.NewValue.ToString().IndexOf("-") >= 0) e.Cancel = true;
                if (Double.Parse(e.NewValue.ToString()) < 0) e.Cancel = true;
            }
            catch (Exception) { e.Cancel = true; }
        }
        /***********************************************
         * Modified by: DuongNT
         * Lastupdate: 5/4/2007
         ***********************************************/
        private void txtSONo_EditValueChanged(object sender, EventArgs e)
        {
            // Temporary disable details table while tying Number

            //salesOrderHeaderRec.SONo = txtSONo.Text;
            ////change PONo in purchase detail
            //ChangeSNoInPurchaseDetail(salesOrderHeaderRec.SONo);
            //try { gvSaleOrderDetail.Columns["SONo"].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo(salesOrderHeaderRec.SONo); }
            //catch { }
        }
                

        private void ChangeSNoInPurchaseDetail(string No)
        {
            DataRow[] rows = Globals.salesOrderDetailTable.Select("[SONo] = '" + No + "'");
            for (int i = 0; i < rows.Length; i++)
            {
                rows[i]["SONo"] = No;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string strSaleOrderNumber = salesOrderHeaderRec.SONo;
            frmSOReport oReport = new frmSOReport(strSaleOrderNumber);
            oReport.ShowDialog();
        }

        private void txtDiscountAmount_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}

