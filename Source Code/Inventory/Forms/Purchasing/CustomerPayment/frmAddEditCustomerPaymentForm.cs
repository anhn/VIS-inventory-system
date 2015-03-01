using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using System.Data.SqlClient;

namespace Inventory
{
    /// <summary>
    /// Summary description for frmAddEditVendorPaymentForm.
    /// </summary>
    public class frmAddEditCustomerPaymentForm : DevExpress.XtraEditors.XtraForm
    {
        private GroupControl grbVendorInfomation;
        private GroupControl grbOrderDetails;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextEdit txtDateCreated;
        private TextEdit txtTotalAmount;
        private TextEdit txtTransactionDate;
        private TextEdit txtCustomerPaymentNo;
        private TextEdit txtUserCreated;
        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private ComboBoxEdit cboOrderNumber;
        private Timer timer1;
        private Label label7;
        private TextEdit txtDescription;
        private IContainer components;
        private ComboBoxEdit cboPaymentMethod;
        private Label label8;
        private ComboBoxEdit cboStatusMaster;
        private Label label10;
        private Label label9;
        private Label label11;
        private TextEdit txtCustomerName;
        private TextEdit txtPaidAmount;
        private Label label12;
        private TextEdit txtBalanceDue;
        private DevExpress.XtraGrid.GridControl grdT_Sales_Order_Detail;
        private GridView grvT_Sales_Order_Detail;
        private Label label13;
        private TextEdit txtSumPaidAmount;
        RepositoryItemLookUpEdit resProduct=new RepositoryItemLookUpEdit();
        public frmAddEditCustomerPaymentForm()
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
            this.components = new System.ComponentModel.Container();
            this.grbVendorInfomation = new DevExpress.XtraEditors.GroupControl();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBalanceDue = new DevExpress.XtraEditors.TextEdit();
            this.cboStatusMaster = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboPaymentMethod = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboOrderNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.txtTransactionDate = new DevExpress.XtraEditors.TextEdit();
            this.txtCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.txtPaidAmount = new DevExpress.XtraEditors.TextEdit();
            this.txtCustomerPaymentNo = new DevExpress.XtraEditors.TextEdit();
            this.txtUserCreated = new DevExpress.XtraEditors.TextEdit();
            this.txtDateCreated = new DevExpress.XtraEditors.TextEdit();
            this.grbOrderDetails = new DevExpress.XtraEditors.GroupControl();
            this.grdT_Sales_Order_Detail = new DevExpress.XtraGrid.GridControl();
            this.grvT_Sales_Order_Detail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.txtSumPaidAmount = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grbVendorInfomation)).BeginInit();
            this.grbVendorInfomation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalanceDue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatusMaster.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPaymentMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOrderNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaidAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerPaymentNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbOrderDetails)).BeginInit();
            this.grbOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdT_Sales_Order_Detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvT_Sales_Order_Detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSumPaidAmount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grbVendorInfomation
            // 
            this.grbVendorInfomation.Controls.Add(this.label13);
            this.grbVendorInfomation.Controls.Add(this.txtSumPaidAmount);
            this.grbVendorInfomation.Controls.Add(this.label12);
            this.grbVendorInfomation.Controls.Add(this.txtBalanceDue);
            this.grbVendorInfomation.Controls.Add(this.cboStatusMaster);
            this.grbVendorInfomation.Controls.Add(this.cboPaymentMethod);
            this.grbVendorInfomation.Controls.Add(this.cboOrderNumber);
            this.grbVendorInfomation.Controls.Add(this.btnCancel);
            this.grbVendorInfomation.Controls.Add(this.btnOK);
            this.grbVendorInfomation.Controls.Add(this.label6);
            this.grbVendorInfomation.Controls.Add(this.label5);
            this.grbVendorInfomation.Controls.Add(this.label4);
            this.grbVendorInfomation.Controls.Add(this.label3);
            this.grbVendorInfomation.Controls.Add(this.label7);
            this.grbVendorInfomation.Controls.Add(this.label10);
            this.grbVendorInfomation.Controls.Add(this.label9);
            this.grbVendorInfomation.Controls.Add(this.label11);
            this.grbVendorInfomation.Controls.Add(this.label2);
            this.grbVendorInfomation.Controls.Add(this.label8);
            this.grbVendorInfomation.Controls.Add(this.label1);
            this.grbVendorInfomation.Controls.Add(this.txtTotalAmount);
            this.grbVendorInfomation.Controls.Add(this.txtDescription);
            this.grbVendorInfomation.Controls.Add(this.txtTransactionDate);
            this.grbVendorInfomation.Controls.Add(this.txtCustomerName);
            this.grbVendorInfomation.Controls.Add(this.txtPaidAmount);
            this.grbVendorInfomation.Controls.Add(this.txtCustomerPaymentNo);
            this.grbVendorInfomation.Controls.Add(this.txtUserCreated);
            this.grbVendorInfomation.Controls.Add(this.txtDateCreated);
            this.grbVendorInfomation.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbVendorInfomation.Location = new System.Drawing.Point(0, 0);
            this.grbVendorInfomation.Name = "grbVendorInfomation";
            this.grbVendorInfomation.Size = new System.Drawing.Size(794, 327);
            this.grbVendorInfomation.TabIndex = 0;
            this.grbVendorInfomation.Text = "Customer Payment Infomation";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(428, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Balance Due:";
            // 
            // txtBalanceDue
            // 
            this.txtBalanceDue.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtBalanceDue.Location = new System.Drawing.Point(547, 237);
            this.txtBalanceDue.Name = "txtBalanceDue";
            this.txtBalanceDue.Properties.DisplayFormat.FormatString = "f2";
            this.txtBalanceDue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtBalanceDue.Properties.Mask.EditMask = "f2";
            this.txtBalanceDue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBalanceDue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtBalanceDue.Properties.ReadOnly = true;
            this.txtBalanceDue.Size = new System.Drawing.Size(213, 20);
            this.txtBalanceDue.TabIndex = 11;
            // 
            // cboStatusMaster
            // 
            this.cboStatusMaster.Location = new System.Drawing.Point(547, 52);
            this.cboStatusMaster.Name = "cboStatusMaster";
            this.cboStatusMaster.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStatusMaster.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboStatusMaster.Size = new System.Drawing.Size(213, 20);
            this.cboStatusMaster.TabIndex = 9;
            // 
            // cboPaymentMethod
            // 
            this.cboPaymentMethod.Location = new System.Drawing.Point(547, 89);
            this.cboPaymentMethod.Name = "cboPaymentMethod";
            this.cboPaymentMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPaymentMethod.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboPaymentMethod.Size = new System.Drawing.Size(213, 20);
            this.cboPaymentMethod.TabIndex = 9;
            // 
            // cboOrderNumber
            // 
            this.cboOrderNumber.Location = new System.Drawing.Point(168, 92);
            this.cboOrderNumber.Name = "cboOrderNumber";
            this.cboOrderNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboOrderNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboOrderNumber.Size = new System.Drawing.Size(205, 20);
            this.cboOrderNumber.TabIndex = 1;
            this.cboOrderNumber.SelectedIndexChanged += new System.EventHandler(this.cboOrderNumber_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(685, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Close";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(592, 281);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "&Save";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "User Created:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Order Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Transaction Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Description:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Customer  Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Paid Amount:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(428, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Payment No.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Payment Method:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date Created:";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTotalAmount.Location = new System.Drawing.Point(547, 126);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Properties.DisplayFormat.FormatString = "f2";
            this.txtTotalAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalAmount.Properties.Mask.EditMask = "f2";
            this.txtTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotalAmount.Properties.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(213, 20);
            this.txtTotalAmount.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(168, 272);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(205, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // txtTransactionDate
            // 
            this.txtTransactionDate.Location = new System.Drawing.Point(168, 237);
            this.txtTransactionDate.Name = "txtTransactionDate";
            this.txtTransactionDate.Properties.DisplayFormat.FormatString = "d";
            this.txtTransactionDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTransactionDate.Properties.Mask.EditMask = "d";
            this.txtTransactionDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtTransactionDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTransactionDate.Properties.ReadOnly = true;
            this.txtTransactionDate.Size = new System.Drawing.Size(205, 20);
            this.txtTransactionDate.TabIndex = 6;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(168, 129);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Properties.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(205, 20);
            this.txtCustomerName.TabIndex = 0;
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPaidAmount.Location = new System.Drawing.Point(547, 163);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Properties.DisplayFormat.FormatString = "f2";
            this.txtPaidAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPaidAmount.Properties.Mask.EditMask = "f2";
            this.txtPaidAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPaidAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPaidAmount.Size = new System.Drawing.Size(213, 20);
            this.txtPaidAmount.TabIndex = 0;
            this.txtPaidAmount.EditValueChanged += new System.EventHandler(this.txtPaidAmount_EditValueChanged);
            this.txtPaidAmount.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtPaidAmount_EditValueChanging);
            // 
            // txtCustomerPaymentNo
            // 
            this.txtCustomerPaymentNo.Location = new System.Drawing.Point(168, 52);
            this.txtCustomerPaymentNo.Name = "txtCustomerPaymentNo";
            this.txtCustomerPaymentNo.Properties.ReadOnly = true;
            this.txtCustomerPaymentNo.Size = new System.Drawing.Size(205, 20);
            this.txtCustomerPaymentNo.TabIndex = 0;
            // 
            // txtUserCreated
            // 
            this.txtUserCreated.Location = new System.Drawing.Point(168, 163);
            this.txtUserCreated.Name = "txtUserCreated";
            this.txtUserCreated.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtUserCreated.Properties.ReadOnly = true;
            this.txtUserCreated.Size = new System.Drawing.Size(205, 20);
            this.txtUserCreated.TabIndex = 5;
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.Location = new System.Drawing.Point(168, 200);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.Properties.EditFormat.FormatString = "d";
            this.txtDateCreated.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDateCreated.Properties.Mask.EditMask = "d";
            this.txtDateCreated.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtDateCreated.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDateCreated.Properties.ReadOnly = true;
            this.txtDateCreated.Size = new System.Drawing.Size(205, 20);
            this.txtDateCreated.TabIndex = 4;
            // 
            // grbOrderDetails
            // 
            this.grbOrderDetails.Controls.Add(this.grdT_Sales_Order_Detail);
            this.grbOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbOrderDetails.Location = new System.Drawing.Point(0, 327);
            this.grbOrderDetails.Name = "grbOrderDetails";
            this.grbOrderDetails.Size = new System.Drawing.Size(794, 241);
            this.grbOrderDetails.TabIndex = 0;
            this.grbOrderDetails.Text = "Sales Order Details Information";
            // 
            // grdT_Sales_Order_Detail
            // 
            this.grdT_Sales_Order_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdT_Sales_Order_Detail.EmbeddedNavigator.Name = "";
            this.grdT_Sales_Order_Detail.Location = new System.Drawing.Point(4, 18);
            this.grdT_Sales_Order_Detail.MainView = this.grvT_Sales_Order_Detail;
            this.grdT_Sales_Order_Detail.Name = "grdT_Sales_Order_Detail";
            this.grdT_Sales_Order_Detail.Size = new System.Drawing.Size(786, 219);
            this.grdT_Sales_Order_Detail.TabIndex = 0;
            this.grdT_Sales_Order_Detail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvT_Sales_Order_Detail});
            // 
            // grvT_Sales_Order_Detail
            // 
            this.grvT_Sales_Order_Detail.GridControl = this.grdT_Sales_Order_Detail;
            this.grvT_Sales_Order_Detail.Name = "grvT_Sales_Order_Detail";
            this.grvT_Sales_Order_Detail.OptionsBehavior.Editable = false;
            this.grvT_Sales_Order_Detail.OptionsView.ShowGroupPanel = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(426, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Sum Paid Amount";
            // 
            // txtSumPaidAmount
            // 
            this.txtSumPaidAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSumPaidAmount.Location = new System.Drawing.Point(547, 202);
            this.txtSumPaidAmount.Name = "txtSumPaidAmount";
            this.txtSumPaidAmount.Properties.DisplayFormat.FormatString = "f2";
            this.txtSumPaidAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSumPaidAmount.Properties.Mask.EditMask = "f2";
            this.txtSumPaidAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSumPaidAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSumPaidAmount.Properties.ReadOnly = true;
            this.txtSumPaidAmount.Size = new System.Drawing.Size(213, 20);
            this.txtSumPaidAmount.TabIndex = 15;
            // 
            // frmAddEditCustomerPaymentForm
            // 
            this.ClientSize = new System.Drawing.Size(794, 568);
            this.Controls.Add(this.grbOrderDetails);
            this.Controls.Add(this.grbVendorInfomation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditCustomerPaymentForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Customer Payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditVendorPaymentForm_FormClosing);
            this.Load += new System.EventHandler(this.frmAddEditCustomerPaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grbVendorInfomation)).EndInit();
            this.grbVendorInfomation.ResumeLayout(false);
            this.grbVendorInfomation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalanceDue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatusMaster.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPaymentMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOrderNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaidAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerPaymentNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbOrderDetails)).EndInit();
            this.grbOrderDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdT_Sales_Order_Detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvT_Sales_Order_Detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSumPaidAmount.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion




        #region Variable
        DA_DataTable dtSales_Order_Header;
        DA_DataTable dtProductMaster;
        DA_DataTable dtWarehouse_Master;
        DA_DataTable dtSales_Order_Details;
        DA_DataTable dtStatusMaster;
        DA_DataTable dtPaymentMethod;
        decimal paidAmount = 0;
        bool isSave;
        #endregion
        #region Method
        #region Get
        private decimal GetSumPaidAmount()
        {
            decimal sumPaidAmount = 0;
            for (int i = 0; i < Globals.dtCustomerPayment.Rows.Count; i++)
            {
                if (Globals.dtCustomerPayment.Rows[i]["CustomerPaymentNo"].ToString().CompareTo(txtCustomerPaymentNo.Text) < 0)
                {
                    if (Globals.dtCustomerPayment.Rows[i]["OrderID"].ToString() == cboOrderNumber.SelectedItem.ToString())
                    {
                        if (Globals.dtCustomerPayment.Rows[i]["PaidAmount"].ToString() != "")
                        {
                            sumPaidAmount = sumPaidAmount + (Decimal)Globals.dtCustomerPayment.Rows[i]["PaidAmount"];
                        }
                    }

                }
            }
            return sumPaidAmount;


        }
        private string GetCustomerName(string contactID)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from VListCustomers where [Contact ID]='" + contactID + "'", conn);
            DataTable dtVListCustomers = new DataTable();
            adapter.Fill(dtVListCustomers);
                         
            if (dtVListCustomers.Rows.Count <= 0)
                return "";
            return dtVListCustomers.Rows[0]["Company Name"].ToString();
        }

        public string GetNumber()
        {
            DA_DataTable dtCustomerPayment = new DA_DataTable("Select * from CustomerPayment  Order By CustomerPaymentNo Desc", false);
            string orderNumber = "200701010001";
            DataView dtv = new DataView(dtCustomerPayment);

            dtv.Sort = "CustomerPaymentNo Desc";
            orderNumber = DateTime.Today.ToString("yyyyMMdd") + "0001";
            if (dtv.Table.Rows.Count > 0)
            {
                if (dtv.Table.Rows[0]["CustomerPaymentNo"].ToString() != "")
                {
                    if (Int64.Parse(dtv.Table.Rows[0]["CustomerPaymentNo"].ToString()) >= Int64.Parse(orderNumber))
                    {
                        orderNumber = Int64.Parse(dtv.Table.Rows[0]["CustomerPaymentNo"].ToString()) + 1 + "";
                    }
                }
            }
            return orderNumber;
        }
        private string GetUserName(string userID)
        {
            DA_DataTable dtUser = new DA_DataTable("Select * from t_User where UserID='" + userID + "'", false);
            if (dtUser.Rows.Count > 0)
            {
                return dtUser.Rows[0]["UserName"].ToString();
            }
            return "";
        }

        private string GetProductName(string productID)
        {
            dtProductMaster = new DA_DataTable("select * from ProductMaster", false);
            foreach (DataRow row in dtProductMaster.Rows)
            {
                if (row["ProductID"].ToString() == productID)
                {
                    return row["ProductName"].ToString();
                }
            }
            return "";
        }
        private string GetWarehouseName(string WarehouseID)
        {
            dtWarehouse_Master = new DA_DataTable("select * from Warehouse_Master", false);
            foreach (DataRow row in dtWarehouse_Master.Rows)
            {
                if (row["Warehouse_id"].ToString() == WarehouseID)
                {
                    return row["Description"].ToString();
                }
            }
            return "";
        }

    
        #endregion

        private void LoadData()
        {
            if (!ProTypeAction)
            {
                txtDateCreated.EditValue = ProRow["DateCreated"];
                txtTransactionDate.EditValue = ProRow["TransactionDate"];
                txtBalanceDue.EditValue = ProRow["BalanceDue"];
                txtUserCreated.EditValue = GetUserName(ProRow["UserCreated"].ToString());
                txtPaidAmount.EditValue = ProRow["PaidAmount"];
                txtCustomerName.EditValue = GetCustomerName(ProRow["CustomerID"].ToString());
            }
            else
            {
                txtUserCreated.EditValue = Globals.UserName;
                txtTransactionDate.EditValue = DateTime.Today;
                txtDateCreated.EditValue = DateTime.Today;
                txtPaidAmount.EditValue = 0;
            }
        }
        private void LoadCboOrderNumber()
        {
            dtSales_Order_Header = new DA_DataTable("select * from t_Sales_Order_Header", false);
            for (int i = 0; i < dtSales_Order_Header.Rows.Count; i++)
            {
                cboOrderNumber.Properties.Items.Add(dtSales_Order_Header.Rows[i]["SONo"].ToString());
            }
            if (!ProTypeAction)
            {
                cboOrderNumber.SelectedItem = ProRow["OrderID"].ToString();
                CalTotalAmount();
                cboOrderNumber.Enabled = false;
            }
            else
            {

                if (dtSales_Order_Header.Rows.Count > 0)
                    cboOrderNumber.SelectedItem = dtSales_Order_Header.Rows[0]["SONo"].ToString();
                CalTotalAmount();
                cboOrderNumber.Enabled = true;

            }
            
        }
        private void LoadCboStatusMaster()
        {
            dtStatusMaster = new DA_DataTable("Select * from StatusMaster", false);
            if (dtStatusMaster.Rows.Count <= 0)
                return;
            for (int i = 0; i < dtStatusMaster.Rows.Count; i++)
            {
                cboStatusMaster.Properties.Items.Add(new TabItem(
                    dtStatusMaster.Rows[i]["StatusID"].ToString(),
                    dtStatusMaster.Rows[i]["StatusName"].ToString()));
            }
            cboStatusMaster.SelectedIndex = 0;
            if (!ProTypeAction)
            {
                for (int i = 0; i < cboStatusMaster.Properties.Items.Count; i++)
                {
                    if (((TabItem)cboStatusMaster.Properties.Items[i]).ItemID == ProRow["StatusID"].ToString())
                    {
                        cboStatusMaster.SelectedIndex = i;
                        return;
                    }
                }
            }
 
        }
        private void LoadCboPaymentMethod()
        {
            dtPaymentMethod = new DA_DataTable("Select * from PaymentMethod", false);
            if (dtPaymentMethod.Rows.Count <= 0)
                return;
            for (int i = 0; i < dtPaymentMethod.Rows.Count; i++)
            {
                cboPaymentMethod.Properties.Items.Add(new TabItem(
                    dtPaymentMethod.Rows[i]["PMID"].ToString(),
                    dtPaymentMethod.Rows[i]["Name"].ToString()));
                    
            }
            cboPaymentMethod.SelectedIndex = 0;
            if (!ProTypeAction)
            {
                for (int i = 0; i < cboPaymentMethod.Properties.Items.Count; i++)
                {
                    if (((TabItem)cboPaymentMethod.Properties.Items[i]).ItemID == ProRow["PaymentMethodID"].ToString())
                    {
                        cboPaymentMethod.SelectedIndex = i;
                        return;
                    }
                }
            }
        }
        



        private void LoadSalesOrderDetail()
        {
            dtSales_Order_Details = new DA_DataTable("select * from t_Sales_Order_Detail where SONo='" + cboOrderNumber.Text + "'", false);
            dtSales_Order_Details.Columns.Add("ProductName", typeof(string));
            dtSales_Order_Details.Columns.Add("WarehouseName", typeof(string));
            grdT_Sales_Order_Detail.DataSource = dtSales_Order_Details;

            
           
            foreach (DataRow row in dtSales_Order_Details.Rows)
            {
                if (row["ProductID"].ToString().Length > 0)
                {
                    row["ProductName"] = GetProductName(row["ProductID"].ToString());
                }
                if (row["Warehouse_id"].ToString().Length > 0)
                {
                    row["WarehouseName"] = GetWarehouseName(row["Warehouse_id"].ToString());
                }
            }
            foreach (GridColumn col in grvT_Sales_Order_Detail.Columns)
            {
                col.VisibleIndex = -1;
            }
            grvT_Sales_Order_Detail.Columns["ProductName"].VisibleIndex = 0;
            grvT_Sales_Order_Detail.Columns["WarehouseName"].VisibleIndex = 1;
            grvT_Sales_Order_Detail.Columns["Location_id"].VisibleIndex = 2;
            grvT_Sales_Order_Detail.Columns["Qty"].VisibleIndex = 3;
            grvT_Sales_Order_Detail.Columns["UnitPrice"].VisibleIndex = 4;
            grvT_Sales_Order_Detail.Columns["SettleAmount"].VisibleIndex = 5;
            grvT_Sales_Order_Detail.Columns["TotalAmount"].VisibleIndex = 6;

            grvT_Sales_Order_Detail.Columns["ProductName"].Caption = "Product";
            grvT_Sales_Order_Detail.Columns["WarehouseName"].Caption = "Warehouse";
            grvT_Sales_Order_Detail.Columns["Location_id"].Caption = "Location";
            grvT_Sales_Order_Detail.Columns["Qty"].Caption = "Quantity";
            grvT_Sales_Order_Detail.Columns["UnitPrice"].Caption = "Unit Price";
            grvT_Sales_Order_Detail.Columns["SettleAmount"].Caption = "Settle Amount";
            grvT_Sales_Order_Detail.Columns["TotalAmount"].Caption = "Total Amount";
            
        }
        private void SaveAllData() 
        {
            ProRow["CustomerPaymentNo"] = txtCustomerPaymentNo.EditValue;
            ProRow["OrderID"] = cboOrderNumber.EditValue;
            ProRow["UserCreated"] = Globals.UserID;
            ProRow["Description"] = txtDescription.EditValue;
            ProRow["PaymentMethodID"] = ((TabItem)cboPaymentMethod.SelectedItem).ItemID;
            ProRow["StatusID"] = ((TabItem)cboStatusMaster.SelectedItem).ItemID;
            ProRow["CustomerID"] = txtCustomerName.Tag.ToString();
            ProRow["PaidAmount"] = txtPaidAmount.EditValue;
            ProRow["BalanceDue"] = txtBalanceDue.EditValue;
            ProRow["DateCreated"] = txtDateCreated.EditValue;
            ProRow["TransactionDate"] = txtTransactionDate.EditValue;
            dtSales_Order_Header.Update();
            if (ProTypeAction)
            {
                Globals.dtCustomerPayment.Rows.Add(ProRow);
                Globals.dtCustomerPayment.Update();
                
            }
            else
            {
                for (int i = 0; i < Globals.dtCustomerPayment.Rows.Count; i++)
                {
                   if (Globals.dtCustomerPayment.Rows[i]["CustomerPaymentID"] == ProRow["CustomerPaymentID"])
                    {
                        DataRow row = Globals.dtCustomerPayment.Rows[i];
                        row = ProRow;

                        Globals.dtCustomerPayment.Update();
                        
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
            isSave = true;
            this.Close();
            
        }

        private void CalTotalAmount()
        {
            for (int i = 0; i < dtSales_Order_Header.Rows.Count; i++)
            {
                if (dtSales_Order_Header.Rows[i]["SONo"].ToString() == cboOrderNumber.SelectedItem.ToString())
                {
                    txtCustomerName.EditValue = GetCustomerName(dtSales_Order_Header.Rows[i]["CustID"].ToString());
                    txtCustomerName.Tag = dtSales_Order_Header.Rows[i]["CustID"].ToString();
                    if (dtSales_Order_Header.Rows[i]["PayAmount"].ToString() != "")
                    {
                        txtTotalAmount.EditValue = dtSales_Order_Header.Rows[i]["PayAmount"];
                    }
                    else
                    {
                        txtTotalAmount.EditValue = 0;
                    }
                    txtPaidAmount.EditValue = 0;
                    txtSumPaidAmount.EditValue = GetSumPaidAmount();
                    txtBalanceDue.EditValue = decimal.Parse(txtTotalAmount.EditValue.ToString()) - decimal.Parse(txtSumPaidAmount.EditValue.ToString());
                    
                }
            }
        }
        #region CheckValidate
        private bool CheckAddOrderDetails()
        {
            return true;
        }

        private bool CheckRemoveOrderDetails()
        {
            
            //if ((Decimal)txtQuantity.EditValue <= 0)
            //{
            //    MessageBox.Show("Quantity cannot less than or equal zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtQuantity.Focus();
            //    return false;
            //}
            //decimal orderDetailQty = (Decimal)grvOrderDatails.GetRowCellValue(grvOrderDatails.FocusedRowHandle, "Qty");
            //decimal productQty = GetProductQty(grvOrderDatails.GetRowCellValue(grvOrderDatails.FocusedRowHandle, "ProductMasterID").ToString());
            //if ((Decimal)txtQuantity.EditValue > orderDetailQty)
            //{
            //    MessageBox.Show("Quantity cannot greater than quantity of OrderDetails", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtQuantity.Focus();
            //    return false;
            //}
            return true;
        }
            
        #endregion
        #endregion
        #region Property
        private DataRow row;
        public DataRow ProRow
        {
            get
            {
                return this.row;
            }
            set
            {
                row = value;
                
            }
        }
        private bool typeAction;
        public bool ProTypeAction
        {
            get
            {
                return this.typeAction;
            }
            set
            {
                typeAction = value;
            }
        }
      
        #endregion
        #region Event
        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveAllData();
        }



        private void frmAddEditCustomerPaymentForm_Load(object sender, EventArgs e)
        {
            if (!ProTypeAction)
            {
                txtCustomerPaymentNo.EditValue = ProRow["CustomerPaymentNo"].ToString();
            }
            else
            {
                txtCustomerPaymentNo.EditValue = GetNumber();
            }
            LoadCboOrderNumber();
            LoadCboPaymentMethod();
            LoadCboStatusMaster();
            LoadData();
 
        }

   
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ProTypeAction)
            {
                txtDateCreated.EditValue = DateTime.Now;
                txtTransactionDate.EditValue = DateTime.Now;
            }
        }

        private void cboOrderNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

            LoadSalesOrderDetail();
            CalTotalAmount();
          
                
        }

        private void txtPaidAmount_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue.ToString() != "")
                if (decimal.Parse(e.NewValue.ToString()) < 0)
                    e.Cancel = true;
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditVendorPaymentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSave)
            {
                string str = MessageBox.Show("Do you want save your changes", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (str == "Yes")
                {
                    btnOK.PerformClick();
                }
                else
                {
                }
            }
        }

        private void txtPaidAmount_EditValueChanged(object sender, EventArgs e)
        {
            if ((decimal.Parse(txtPaidAmount.EditValue.ToString()) - paidAmount) + (Decimal)txtSumPaidAmount.EditValue > (Decimal)txtTotalAmount.EditValue)
            {
                MessageBox.Show("Sum Of Paid Amount cannot greater than Total Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPaidAmount.EditValue = paidAmount;
                txtTotalAmount.Focus();
                txtPaidAmount.Focus();
                return;
            }
            else
            {
                if (txtPaidAmount.EditValue.ToString() != "")
                {

                    txtSumPaidAmount.EditValue = (decimal.Parse(txtPaidAmount.EditValue.ToString()) - paidAmount) + (Decimal)txtSumPaidAmount.EditValue;
                    txtBalanceDue.EditValue = decimal.Parse(txtTotalAmount.EditValue.ToString()) - decimal.Parse(txtSumPaidAmount.EditValue.ToString());
                    paidAmount = decimal.Parse(txtPaidAmount.EditValue.ToString());
                }
            }
        }
    }
}


