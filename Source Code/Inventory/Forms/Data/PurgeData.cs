using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Inventory.Process.Data;

namespace Inventory.Forms.Data
{
    /// <summary>
    /// Summary description for PurgeData.
    /// </summary>
    public class PurgeData : DevExpress.XtraEditors.XtraForm
    {
        private CheckBox chkStockIn;
        private CheckBox chkStockOut;
        private CheckBox chkStockTransfer;
        private CheckBox chkPickingList;
        private CheckBox chkPackingList;
        private CheckBox chkWorkOrder;
        private CheckBox chkInvAdjust;
        private CheckBox chkSalesOrder;
        private CheckBox chkPurchaseOrder;
        private CheckBox chkDeliveryNote;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox chkInvUpdate;
        private CheckBox chkPhysicalTake;
        private CheckBox chkInvoice;
        private CheckBox chkPayment;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private DateEdit dtmInvAdjustFrom;
        private Label label12;
        private DateEdit dtmInvUpdateTo;
        private DateEdit dtmInvUpdateFrom;
        private Label label11;
        private DateEdit dtmInvoicesTo;
        private DateEdit dtmInvoicesFrom;
        private Label label10;
        private DateEdit dtmPaymentTo;
        private DateEdit dtmPaymentFrom;
        private Label label9;
        private DateEdit dtmSalesOrderTo;
        private DateEdit dtmSalesOrderFrom;
        private Label label8;
        private DateEdit dtmPurchaseOrderTo;
        private DateEdit dtmPurchaseOrderFrom;
        private Label label7;
        private DateEdit dtmStockInTo;
        private DateEdit dtmStockInFrom;
        private Label label6;
        private DateEdit dtmStockOutTo;
        private DateEdit dtmStockOutFrom;
        private Label label5;
        private DateEdit dtmStockTransferTo;
        private DateEdit dtmStockTransferFrom;
        private Label label4;
        private DateEdit dtmPickingListTo;
        private DateEdit dtmPickingListFrom;
        private Label label3;
        private DateEdit dtmPackingListTo;
        private DateEdit dtmPackingListFrom;
        private Label label2;
        private DateEdit dtmDeliveryNotesTo;
        private DateEdit dtmDeliveryNotesFrom;
        private Label label1;
        private DateEdit dtmInvAdjustTo;
        private Label label14;
        private DateEdit dtmWorkOrderTo;
        private DateEdit dtmWorkOrderFrom;
        private Label label13;
        private DateEdit dtmPhysicalTakeTo;
        private DateEdit dtmPhysicalTakeFrom;
        private RadioButton radAll;
        private RadioButton radSelected;
        private Label lblDateRange;
        private Label lblFrom;
        private Label lblTo;
        private DateEdit dtmTo;
        private DateEdit dtmFrom;
        private GroupBox groupBox5;
        private Label label20;
        private DateEdit dtmPeriodDetailsTo;
        private DateEdit dtmPeriodDetailsFrom;
        private Label label21;
        private DateEdit dtmProductDetailsTo;
        private DateEdit dtmProductDetailsFrom;
        private CheckBox chkProductDetails;
        private CheckBox chkPeriodDetails;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        Properties.Settings settings = Properties.Settings.Default;
        private SimpleButton btnExecute;
        private SimpleButton btnClose;

        bool blnUseSpecialDate = false;

        public PurgeData()
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
            this.chkStockIn = new System.Windows.Forms.CheckBox();
            this.chkStockOut = new System.Windows.Forms.CheckBox();
            this.chkStockTransfer = new System.Windows.Forms.CheckBox();
            this.chkPickingList = new System.Windows.Forms.CheckBox();
            this.chkPackingList = new System.Windows.Forms.CheckBox();
            this.chkWorkOrder = new System.Windows.Forms.CheckBox();
            this.chkInvAdjust = new System.Windows.Forms.CheckBox();
            this.chkSalesOrder = new System.Windows.Forms.CheckBox();
            this.chkPurchaseOrder = new System.Windows.Forms.CheckBox();
            this.chkDeliveryNote = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dtmPeriodDetailsTo = new DevExpress.XtraEditors.DateEdit();
            this.dtmPeriodDetailsFrom = new DevExpress.XtraEditors.DateEdit();
            this.label21 = new System.Windows.Forms.Label();
            this.dtmProductDetailsTo = new DevExpress.XtraEditors.DateEdit();
            this.dtmProductDetailsFrom = new DevExpress.XtraEditors.DateEdit();
            this.chkProductDetails = new System.Windows.Forms.CheckBox();
            this.chkPeriodDetails = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtmWorkOrderTo = new DevExpress.XtraEditors.DateEdit();
            this.dtmWorkOrderFrom = new DevExpress.XtraEditors.DateEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.dtmPhysicalTakeTo = new DevExpress.XtraEditors.DateEdit();
            this.dtmPhysicalTakeFrom = new DevExpress.XtraEditors.DateEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.dtmInvUpdateTo = new DevExpress.XtraEditors.DateEdit();
            this.dtmInvUpdateFrom = new DevExpress.XtraEditors.DateEdit();
            this.chkInvUpdate = new System.Windows.Forms.CheckBox();
            this.chkPhysicalTake = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtmInvoicesTo = new DevExpress.XtraEditors.DateEdit();
            this.dtmInvoicesFrom = new DevExpress.XtraEditors.DateEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.dtmPaymentTo = new DevExpress.XtraEditors.DateEdit();
            this.dtmPaymentFrom = new DevExpress.XtraEditors.DateEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.dtmSalesOrderTo = new DevExpress.XtraEditors.DateEdit();
            this.dtmSalesOrderFrom = new DevExpress.XtraEditors.DateEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.dtmPurchaseOrderTo = new DevExpress.XtraEditors.DateEdit();
            this.dtmPurchaseOrderFrom = new DevExpress.XtraEditors.DateEdit();
            this.chkPayment = new System.Windows.Forms.CheckBox();
            this.chkInvoice = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtmStockInTo = new DevExpress.XtraEditors.DateEdit();
            this.dtmStockInFrom = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.dtmStockOutTo = new DevExpress.XtraEditors.DateEdit();
            this.dtmStockOutFrom = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.dtmStockTransferTo = new DevExpress.XtraEditors.DateEdit();
            this.dtmStockTransferFrom = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.dtmPickingListTo = new DevExpress.XtraEditors.DateEdit();
            this.dtmPickingListFrom = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.dtmPackingListTo = new DevExpress.XtraEditors.DateEdit();
            this.dtmPackingListFrom = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.dtmDeliveryNotesTo = new DevExpress.XtraEditors.DateEdit();
            this.dtmDeliveryNotesFrom = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dtmInvAdjustTo = new DevExpress.XtraEditors.DateEdit();
            this.dtmInvAdjustFrom = new DevExpress.XtraEditors.DateEdit();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.radSelected = new System.Windows.Forms.RadioButton();
            this.lblDateRange = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtmTo = new DevExpress.XtraEditors.DateEdit();
            this.dtmFrom = new DevExpress.XtraEditors.DateEdit();
            this.btnExecute = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPeriodDetailsTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPeriodDetailsFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmProductDetailsTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmProductDetailsFrom.Properties)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmWorkOrderTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmWorkOrderFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPhysicalTakeTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPhysicalTakeFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmInvUpdateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmInvUpdateFrom.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmInvoicesTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmInvoicesFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPaymentTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPaymentFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmSalesOrderTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmSalesOrderFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPurchaseOrderTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPurchaseOrderFrom.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmStockInTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmStockInFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmStockOutTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmStockOutFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmStockTransferTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmStockTransferFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPickingListTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPickingListFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPackingListTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPackingListFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDeliveryNotesTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDeliveryNotesFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmInvAdjustTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmInvAdjustFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmFrom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chkStockIn
            // 
            this.chkStockIn.AutoSize = true;
            this.chkStockIn.Location = new System.Drawing.Point(7, 24);
            this.chkStockIn.Name = "chkStockIn";
            this.chkStockIn.Size = new System.Drawing.Size(72, 18);
            this.chkStockIn.TabIndex = 0;
            this.chkStockIn.Text = "Stock In";
            this.chkStockIn.UseVisualStyleBackColor = true;
            // 
            // chkStockOut
            // 
            this.chkStockOut.AutoSize = true;
            this.chkStockOut.Location = new System.Drawing.Point(7, 65);
            this.chkStockOut.Name = "chkStockOut";
            this.chkStockOut.Size = new System.Drawing.Size(82, 18);
            this.chkStockOut.TabIndex = 1;
            this.chkStockOut.Text = "Stock Out";
            this.chkStockOut.UseVisualStyleBackColor = true;
            // 
            // chkStockTransfer
            // 
            this.chkStockTransfer.AutoSize = true;
            this.chkStockTransfer.Location = new System.Drawing.Point(7, 105);
            this.chkStockTransfer.Name = "chkStockTransfer";
            this.chkStockTransfer.Size = new System.Drawing.Size(106, 18);
            this.chkStockTransfer.TabIndex = 2;
            this.chkStockTransfer.Text = "Stock Transfer";
            this.chkStockTransfer.UseVisualStyleBackColor = true;
            // 
            // chkPickingList
            // 
            this.chkPickingList.AutoSize = true;
            this.chkPickingList.Location = new System.Drawing.Point(7, 147);
            this.chkPickingList.Name = "chkPickingList";
            this.chkPickingList.Size = new System.Drawing.Size(85, 18);
            this.chkPickingList.TabIndex = 3;
            this.chkPickingList.Text = "Picking List";
            this.chkPickingList.UseVisualStyleBackColor = true;
            // 
            // chkPackingList
            // 
            this.chkPackingList.AutoSize = true;
            this.chkPackingList.Location = new System.Drawing.Point(7, 191);
            this.chkPackingList.Name = "chkPackingList";
            this.chkPackingList.Size = new System.Drawing.Size(89, 18);
            this.chkPackingList.TabIndex = 4;
            this.chkPackingList.Text = "Packing List";
            this.chkPackingList.UseVisualStyleBackColor = true;
            // 
            // chkWorkOrder
            // 
            this.chkWorkOrder.AutoSize = true;
            this.chkWorkOrder.Location = new System.Drawing.Point(5, 102);
            this.chkWorkOrder.Name = "chkWorkOrder";
            this.chkWorkOrder.Size = new System.Drawing.Size(90, 18);
            this.chkWorkOrder.TabIndex = 5;
            this.chkWorkOrder.Text = "Work Order";
            this.chkWorkOrder.UseVisualStyleBackColor = true;
            // 
            // chkInvAdjust
            // 
            this.chkInvAdjust.AutoSize = true;
            this.chkInvAdjust.Location = new System.Drawing.Point(7, 271);
            this.chkInvAdjust.Name = "chkInvAdjust";
            this.chkInvAdjust.Size = new System.Drawing.Size(147, 18);
            this.chkInvAdjust.TabIndex = 6;
            this.chkInvAdjust.Text = "Inventory Adjustment";
            this.chkInvAdjust.UseVisualStyleBackColor = true;
            // 
            // chkSalesOrder
            // 
            this.chkSalesOrder.AutoSize = true;
            this.chkSalesOrder.Location = new System.Drawing.Point(9, 65);
            this.chkSalesOrder.Name = "chkSalesOrder";
            this.chkSalesOrder.Size = new System.Drawing.Size(88, 18);
            this.chkSalesOrder.TabIndex = 7;
            this.chkSalesOrder.Text = "Sales Order";
            this.chkSalesOrder.UseVisualStyleBackColor = true;
            // 
            // chkPurchaseOrder
            // 
            this.chkPurchaseOrder.AutoSize = true;
            this.chkPurchaseOrder.Location = new System.Drawing.Point(9, 20);
            this.chkPurchaseOrder.Name = "chkPurchaseOrder";
            this.chkPurchaseOrder.Size = new System.Drawing.Size(110, 18);
            this.chkPurchaseOrder.TabIndex = 8;
            this.chkPurchaseOrder.Text = "Purchase Order";
            this.chkPurchaseOrder.UseVisualStyleBackColor = true;
            // 
            // chkDeliveryNote
            // 
            this.chkDeliveryNote.AutoSize = true;
            this.chkDeliveryNote.Location = new System.Drawing.Point(7, 231);
            this.chkDeliveryNote.Name = "chkDeliveryNote";
            this.chkDeliveryNote.Size = new System.Drawing.Size(104, 18);
            this.chkDeliveryNote.TabIndex = 9;
            this.chkDeliveryNote.Text = "Delivery Notes";
            this.chkDeliveryNote.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 473);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Data For Purging";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.dtmPeriodDetailsTo);
            this.groupBox5.Controls.Add(this.dtmPeriodDetailsFrom);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.dtmProductDetailsTo);
            this.groupBox5.Controls.Add(this.dtmProductDetailsFrom);
            this.groupBox5.Controls.Add(this.chkProductDetails);
            this.groupBox5.Controls.Add(this.chkPeriodDetails);
            this.groupBox5.Location = new System.Drawing.Point(367, 209);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(316, 242);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Product Details";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(204, 65);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 14);
            this.label20.TabIndex = 18;
            this.label20.Text = "To";
            // 
            // dtmPeriodDetailsTo
            // 
            this.dtmPeriodDetailsTo.EditValue = new System.DateTime(((long)(0)));
            this.dtmPeriodDetailsTo.Enabled = false;
            this.dtmPeriodDetailsTo.Location = new System.Drawing.Point(229, 63);
            this.dtmPeriodDetailsTo.Name = "dtmPeriodDetailsTo";
            this.dtmPeriodDetailsTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmPeriodDetailsTo.Size = new System.Drawing.Size(75, 21);
            this.dtmPeriodDetailsTo.TabIndex = 17;
            // 
            // dtmPeriodDetailsFrom
            // 
            this.dtmPeriodDetailsFrom.EditValue = new System.DateTime(((long)(0)));
            this.dtmPeriodDetailsFrom.Enabled = false;
            this.dtmPeriodDetailsFrom.Location = new System.Drawing.Point(122, 63);
            this.dtmPeriodDetailsFrom.Name = "dtmPeriodDetailsFrom";
            this.dtmPeriodDetailsFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmPeriodDetailsFrom.Size = new System.Drawing.Size(75, 21);
            this.dtmPeriodDetailsFrom.TabIndex = 16;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(204, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(22, 14);
            this.label21.TabIndex = 15;
            this.label21.Text = "To";
            // 
            // dtmProductDetailsTo
            // 
            this.dtmProductDetailsTo.EditValue = new System.DateTime(((long)(0)));
            this.dtmProductDetailsTo.Enabled = false;
            this.dtmProductDetailsTo.Location = new System.Drawing.Point(229, 17);
            this.dtmProductDetailsTo.Name = "dtmProductDetailsTo";
            this.dtmProductDetailsTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmProductDetailsTo.Size = new System.Drawing.Size(75, 21);
            this.dtmProductDetailsTo.TabIndex = 14;
            // 
            // dtmProductDetailsFrom
            // 
            this.dtmProductDetailsFrom.EditValue = new System.DateTime(((long)(0)));
            this.dtmProductDetailsFrom.Enabled = false;
            this.dtmProductDetailsFrom.Location = new System.Drawing.Point(122, 17);
            this.dtmProductDetailsFrom.Name = "dtmProductDetailsFrom";
            this.dtmProductDetailsFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmProductDetailsFrom.Size = new System.Drawing.Size(75, 21);
            this.dtmProductDetailsFrom.TabIndex = 13;
            // 
            // chkProductDetails
            // 
            this.chkProductDetails.AutoSize = true;
            this.chkProductDetails.Enabled = false;
            this.chkProductDetails.Location = new System.Drawing.Point(9, 20);
            this.chkProductDetails.Name = "chkProductDetails";
            this.chkProductDetails.Size = new System.Drawing.Size(108, 18);
            this.chkProductDetails.TabIndex = 8;
            this.chkProductDetails.Text = "Product Details";
            this.chkProductDetails.UseVisualStyleBackColor = true;
            // 
            // chkPeriodDetails
            // 
            this.chkPeriodDetails.AutoSize = true;
            this.chkPeriodDetails.Enabled = false;
            this.chkPeriodDetails.Location = new System.Drawing.Point(9, 65);
            this.chkPeriodDetails.Name = "chkPeriodDetails";
            this.chkPeriodDetails.Size = new System.Drawing.Size(99, 18);
            this.chkPeriodDetails.TabIndex = 7;
            this.chkPeriodDetails.Text = "Period Details";
            this.chkPeriodDetails.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.dtmWorkOrderTo);
            this.groupBox4.Controls.Add(this.dtmWorkOrderFrom);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.dtmPhysicalTakeTo);
            this.groupBox4.Controls.Add(this.dtmPhysicalTakeFrom);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.dtmInvUpdateTo);
            this.groupBox4.Controls.Add(this.dtmInvUpdateFrom);
            this.groupBox4.Controls.Add(this.chkInvUpdate);
            this.groupBox4.Controls.Add(this.chkWorkOrder);
            this.groupBox4.Controls.Add(this.chkPhysicalTake);
            this.groupBox4.Location = new System.Drawing.Point(15, 337);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(335, 130);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Others";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(227, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 14);
            this.label14.TabIndex = 24;
            this.label14.Text = "To";
            // 
            // dtmWorkOrderTo
            // 
            this.dtmWorkOrderTo.EditValue = new System.DateTime(((long)(0)));
            this.dtmWorkOrderTo.Location = new System.Drawing.Point(252, 99);
            this.dtmWorkOrderTo.Name = "dtmWorkOrderTo";
            this.dtmWorkOrderTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmWorkOrderTo.Size = new System.Drawing.Size(75, 21);
            this.dtmWorkOrderTo.TabIndex = 23;
            // 
            // dtmWorkOrderFrom
            // 
            this.dtmWorkOrderFrom.EditValue = new System.DateTime(((long)(0)));
            this.dtmWorkOrderFrom.Location = new System.Drawing.Point(150, 99);
            this.dtmWorkOrderFrom.Name = "dtmWorkOrderFrom";
            this.dtmWorkOrderFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmWorkOrderFrom.Size = new System.Drawing.Size(75, 21);
            this.dtmWorkOrderFrom.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(227, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 14);
            this.label13.TabIndex = 21;
            this.label13.Text = "To";
            // 
            // dtmPhysicalTakeTo
            // 
            this.dtmPhysicalTakeTo.EditValue = new System.DateTime(((long)(0)));
            this.dtmPhysicalTakeTo.Location = new System.Drawing.Point(252, 60);
            this.dtmPhysicalTakeTo.Name = "dtmPhysicalTakeTo";
            this.dtmPhysicalTakeTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmPhysicalTakeTo.Size = new System.Drawing.Size(75, 21);
            this.dtmPhysicalTakeTo.TabIndex = 20;
            // 
            // dtmPhysicalTakeFrom
            // 
            this.dtmPhysicalTakeFrom.EditValue = new System.DateTime(((long)(0)));
            this.dtmPhysicalTakeFrom.Location = new System.Drawing.Point(150, 60);
            this.dtmPhysicalTakeFrom.Name = "dtmPhysicalTakeFrom";
            this.dtmPhysicalTakeFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmPhysicalTakeFrom.Size = new System.Drawing.Size(75, 21);
            this.dtmPhysicalTakeFrom.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(227, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 14);
            this.label12.TabIndex = 18;
            this.label12.Text = "To";
            // 
            // dtmInvUpdateTo
            // 
            this.dtmInvUpdateTo.EditValue = new System.DateTime(((long)(0)));
            this.dtmInvUpdateTo.Location = new System.Drawing.Point(252, 19);
            this.dtmInvUpdateTo.Name = "dtmInvUpdateTo";
            this.dtmInvUpdateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmInvUpdateTo.Size = new System.Drawing.Size(75, 21);
            this.dtmInvUpdateTo.TabIndex = 17;
            // 
            // dtmInvUpdateFrom
            // 
            this.dtmInvUpdateFrom.EditValue = new System.DateTime(((long)(0)));
            this.dtmInvUpdateFrom.Location = new System.Drawing.Point(150, 19);
            this.dtmInvUpdateFrom.Name = "dtmInvUpdateFrom";
            this.dtmInvUpdateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmInvUpdateFrom.Size = new System.Drawing.Size(75, 21);
            this.dtmInvUpdateFrom.TabIndex = 16;
            // 
            // chkInvUpdate
            // 
            this.chkInvUpdate.AutoSize = true;
            this.chkInvUpdate.Location = new System.Drawing.Point(5, 22);
            this.chkInvUpdate.Name = "chkInvUpdate";
            this.chkInvUpdate.Size = new System.Drawing.Size(123, 18);
            this.chkInvUpdate.TabIndex = 15;
            this.chkInvUpdate.Text = "Inventory Update";
            this.chkInvUpdate.UseVisualStyleBackColor = true;
            // 
            // chkPhysicalTake
            // 
            this.chkPhysicalTake.AutoSize = true;
            this.chkPhysicalTake.Location = new System.Drawing.Point(5, 62);
            this.chkPhysicalTake.Name = "chkPhysicalTake";
            this.chkPhysicalTake.Size = new System.Drawing.Size(98, 18);
            this.chkPhysicalTake.TabIndex = 12;
            this.chkPhysicalTake.Text = "Physical Take";
            this.chkPhysicalTake.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dtmInvoicesTo);
            this.groupBox3.Controls.Add(this.dtmInvoicesFrom);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.dtmPaymentTo);
            this.groupBox3.Controls.Add(this.dtmPaymentFrom);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dtmSalesOrderTo);
            this.groupBox3.Controls.Add(this.dtmSalesOrderFrom);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dtmPurchaseOrderTo);
            this.groupBox3.Controls.Add(this.dtmPurchaseOrderFrom);
            this.groupBox3.Controls.Add(this.chkPurchaseOrder);
            this.groupBox3.Controls.Add(this.chkSalesOrder);
            this.groupBox3.Controls.Add(this.chkPayment);
            this.groupBox3.Controls.Add(this.chkInvoice);
            this.groupBox3.Location = new System.Drawing.Point(367, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 183);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Orders and Invoices";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 14);
            this.label11.TabIndex = 24;
            this.label11.Text = "To";
            // 
            // dtmInvoicesTo
            // 
            this.dtmInvoicesTo.EditValue = new System.DateTime(((long)(0)));
            this.dtmInvoicesTo.Enabled = false;
            this.dtmInvoicesTo.Location = new System.Drawing.Point(229, 145);
            this.dtmInvoicesTo.Name = "dtmInvoicesTo";
            this.dtmInvoicesTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmInvoicesTo.Size = new System.Drawing.Size(75, 21);
            this.dtmInvoicesTo.TabIndex = 23;
            // 
            // dtmInvoicesFrom
            // 
            this.dtmInvoicesFrom.EditValue = new System.DateTime(((long)(0)));
            this.dtmInvoicesFrom.Enabled = false;
            this.dtmInvoicesFrom.Location = new System.Drawing.Point(122, 145);
            this.dtmInvoicesFrom.Name = "dtmInvoicesFrom";
            this.dtmInvoicesFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmInvoicesFrom.Size = new System.Drawing.Size(75, 21);
            this.dtmInvoicesFrom.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 14);
            this.label10.TabIndex = 21;
            this.label10.Text = "To";
            // 
            // dtmPaymentTo
            // 
            this.dtmPaymentTo.EditValue = new System.DateTime(((long)(0)));
            this.dtmPaymentTo.Location = new System.Drawing.Point(229, 102);
            this.dtmPaymentTo.Name = "dtmPaymentTo";
            this.dtmPaymentTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmPaymentTo.Size = new System.Drawing.Size(75, 21);
            this.dtmPaymentTo.TabIndex = 20;
            // 
            // dtmPaymentFrom
            // 
            this.dtmPaymentFrom.EditValue = new System.DateTime(((long)(0)));
            this.dtmPaymentFrom.Location = new System.Drawing.Point(122, 102);
            this.dtmPaymentFrom.Name = "dtmPaymentFrom";
            this.dtmPaymentFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmPaymentFrom.Size = new System.Drawing.Size(75, 21);
            this.dtmPaymentFrom.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(204, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 14);
            this.label9.TabIndex = 18;
            this.label9.Text = "To";
            // 
            // dtmSalesOrderTo
            // 
            this.dtmSalesOrderTo.EditValue = new System.DateTime(((long)(0)));
            this.dtmSalesOrderTo.Location = new System.Drawing.Point(229, 63);
            this.dtmSalesOrderTo.Name = "dtmSalesOrderTo";
            this.dtmSalesOrderTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmSalesOrderTo.Size = new System.Drawing.Size(75, 21);
            this.dtmSalesOrderTo.TabIndex = 17;
            // 
            // dtmSalesOrderFrom
            // 
            this.dtmSalesOrderFrom.EditValue = new System.DateTime(((long)(0)));
            this.dtmSalesOrderFrom.Location = new System.Drawing.Point(122, 63);
            this.dtmSalesOrderFrom.Name = "dtmSalesOrderFrom";
            this.dtmSalesOrderFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmSalesOrderFrom.Size = new System.Drawing.Size(75, 21);
            this.dtmSalesOrderFrom.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 14);
            this.label8.TabIndex = 15;
            this.label8.Text = "To";
            // 
            // dtmPurchaseOrderTo
            // 
            this.dtmPurchaseOrderTo.EditValue = new System.DateTime(((long)(0)));
            this.dtmPurchaseOrderTo.Location = new System.Drawing.Point(229, 17);
            this.dtmPurchaseOrderTo.Name = "dtmPurchaseOrderTo";
            this.dtmPurchaseOrderTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmPurchaseOrderTo.Size = new System.Drawing.Size(75, 21);
            this.dtmPurchaseOrderTo.TabIndex = 14;
            // 
            // dtmPurchaseOrderFrom
            // 
            this.dtmPurchaseOrderFrom.EditValue = new System.DateTime(((long)(0)));
            this.dtmPurchaseOrderFrom.Location = new System.Drawing.Point(122, 17);
            this.dtmPurchaseOrderFrom.Name = "dtmPurchaseOrderFrom";
            this.dtmPurchaseOrderFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmPurchaseOrderFrom.Size = new System.Drawing.Size(75, 21);
            this.dtmPurchaseOrderFrom.TabIndex = 13;
            // 
            // chkPayment
            // 
            this.chkPayment.AutoSize = true;
            this.chkPayment.Location = new System.Drawing.Point(9, 105);
            this.chkPayment.Name = "chkPayment";
            this.chkPayment.Size = new System.Drawing.Size(79, 18);
            this.chkPayment.TabIndex = 10;
            this.chkPayment.Text = "Payments";
            this.chkPayment.UseVisualStyleBackColor = true;
            // 
            // chkInvoice
            // 
            this.chkInvoice.AutoSize = true;
            this.chkInvoice.Enabled = false;
            this.chkInvoice.Location = new System.Drawing.Point(9, 147);
            this.chkInvoice.Name = "chkInvoice";
            this.chkInvoice.Size = new System.Drawing.Size(70, 18);
            this.chkInvoice.TabIndex = 11;
            this.chkInvoice.Text = "Invoices";
            this.chkInvoice.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtmStockInTo);
            this.groupBox2.Controls.Add(this.dtmStockInFrom);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtmStockOutTo);
            this.groupBox2.Controls.Add(this.dtmStockOutFrom);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtmStockTransferTo);
            this.groupBox2.Controls.Add(this.dtmStockTransferFrom);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtmPickingListTo);
            this.groupBox2.Controls.Add(this.dtmPickingListFrom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtmPackingListTo);
            this.groupBox2.Controls.Add(this.dtmPackingListFrom);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtmDeliveryNotesTo);
            this.groupBox2.Controls.Add(this.dtmDeliveryNotesFrom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtmInvAdjustTo);
            this.groupBox2.Controls.Add(this.dtmInvAdjustFrom);
            this.groupBox2.Controls.Add(this.chkStockIn);
            this.groupBox2.Controls.Add(this.chkPackingList);
            this.groupBox2.Controls.Add(this.chkPickingList);
            this.groupBox2.Controls.Add(this.chkStockTransfer);
            this.groupBox2.Controls.Add(this.chkInvAdjust);
            this.groupBox2.Controls.Add(this.chkDeliveryNote);
            this.groupBox2.Controls.Add(this.chkStockOut);
            this.groupBox2.Location = new System.Drawing.Point(15, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 311);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Daily Operation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 14);
            this.label7.TabIndex = 30;
            this.label7.Text = "To";
            // 
            // dtmStockInTo
            // 
            this.dtmStockInTo.EditValue = new System.DateTime(((long)(0)));
            this.dtmStockInTo.Location = new System.Drawing.Point(252, 22);
            this.dtmStockInTo.Name = "dtmStockInTo";
            this.dtmStockInTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmStockInTo.Size = new System.Drawing.Size(75, 21);
            this.dtmStockInTo.TabIndex = 29;
            // 
            // dtmStockInFrom
            // 
            this.dtmStockInFrom.EditValue = new System.DateTime(((long)(0)));
            this.dtmStockInFrom.Location = new System.Drawing.Point(150, 22);
            this.dtmStockInFrom.Name = "dtmStockInFrom";
            this.dtmStockInFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmStockInFrom.Size = new System.Drawing.Size(75, 21);
            this.dtmStockInFrom.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 14);
            this.label6.TabIndex = 27;
            this.label6.Text = "To";
            // 
            // dtmStockOutTo
            // 
            this.dtmStockOutTo.EditValue = new System.DateTime(((long)(0)));
            this.dtmStockOutTo.Location = new System.Drawing.Point(252, 63);
            this.dtmStockOutTo.Name = "dtmStockOutTo";
            this.dtmStockOutTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmStockOutTo.Size = new System.Drawing.Size(75, 21);
            this.dtmStockOutTo.TabIndex = 26;
            // 
            // dtmStockOutFrom
            // 
            this.dtmStockOutFrom.EditValue = new System.DateTime(((long)(0)));
            this.dtmStockOutFrom.Location = new System.Drawing.Point(150, 63);
            this.dtmStockOutFrom.Name = "dtmStockOutFrom";
            this.dtmStockOutFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmStockOutFrom.Size = new System.Drawing.Size(75, 21);
            this.dtmStockOutFrom.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 14);
            this.label5.TabIndex = 24;
            this.label5.Text = "To";
            // 
            // dtmStockTransferTo
            // 
            this.dtmStockTransferTo.EditValue = new System.DateTime(((long)(0)));
            this.dtmStockTransferTo.Location = new System.Drawing.Point(252, 103);
            this.dtmStockTransferTo.Name = "dtmStockTransferTo";
            this.dtmStockTransferTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmStockTransferTo.Size = new System.Drawing.Size(75, 21);
            this.dtmStockTransferTo.TabIndex = 23;
            // 
            // dtmStockTransferFrom
            // 
            this.dtmStockTransferFrom.EditValue = new System.DateTime(((long)(0)));
            this.dtmStockTransferFrom.Location = new System.Drawing.Point(150, 103);
            this.dtmStockTransferFrom.Name = "dtmStockTransferFrom";
            this.dtmStockTransferFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmStockTransferFrom.Size = new System.Drawing.Size(75, 21);
            this.dtmStockTransferFrom.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 14);
            this.label4.TabIndex = 21;
            this.label4.Text = "To";
            // 
            // dtmPickingListTo
            // 
            this.dtmPickingListTo.EditValue = new System.DateTime(((long)(0)));
            this.dtmPickingListTo.Location = new System.Drawing.Point(252, 145);
            this.dtmPickingListTo.Name = "dtmPickingListTo";
            this.dtmPickingListTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmPickingListTo.Size = new System.Drawing.Size(75, 21);
            this.dtmPickingListTo.TabIndex = 20;
            // 
            // dtmPickingListFrom
            // 
            this.dtmPickingListFrom.EditValue = new System.DateTime(((long)(0)));
            this.dtmPickingListFrom.Location = new System.Drawing.Point(150, 145);
            this.dtmPickingListFrom.Name = "dtmPickingListFrom";
            this.dtmPickingListFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmPickingListFrom.Size = new System.Drawing.Size(75, 21);
            this.dtmPickingListFrom.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 14);
            this.label3.TabIndex = 18;
            this.label3.Text = "To";
            // 
            // dtmPackingListTo
            // 
            this.dtmPackingListTo.EditValue = new System.DateTime(((long)(0)));
            this.dtmPackingListTo.Location = new System.Drawing.Point(252, 189);
            this.dtmPackingListTo.Name = "dtmPackingListTo";
            this.dtmPackingListTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmPackingListTo.Size = new System.Drawing.Size(75, 21);
            this.dtmPackingListTo.TabIndex = 17;
            // 
            // dtmPackingListFrom
            // 
            this.dtmPackingListFrom.EditValue = new System.DateTime(((long)(0)));
            this.dtmPackingListFrom.Location = new System.Drawing.Point(150, 189);
            this.dtmPackingListFrom.Name = "dtmPackingListFrom";
            this.dtmPackingListFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmPackingListFrom.Size = new System.Drawing.Size(75, 21);
            this.dtmPackingListFrom.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 14);
            this.label2.TabIndex = 15;
            this.label2.Text = "To";
            // 
            // dtmDeliveryNotesTo
            // 
            this.dtmDeliveryNotesTo.EditValue = new System.DateTime(((long)(0)));
            this.dtmDeliveryNotesTo.Location = new System.Drawing.Point(252, 228);
            this.dtmDeliveryNotesTo.Name = "dtmDeliveryNotesTo";
            this.dtmDeliveryNotesTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmDeliveryNotesTo.Size = new System.Drawing.Size(75, 21);
            this.dtmDeliveryNotesTo.TabIndex = 14;
            // 
            // dtmDeliveryNotesFrom
            // 
            this.dtmDeliveryNotesFrom.EditValue = new System.DateTime(((long)(0)));
            this.dtmDeliveryNotesFrom.Location = new System.Drawing.Point(150, 228);
            this.dtmDeliveryNotesFrom.Name = "dtmDeliveryNotesFrom";
            this.dtmDeliveryNotesFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmDeliveryNotesFrom.Size = new System.Drawing.Size(75, 21);
            this.dtmDeliveryNotesFrom.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = "To";
            // 
            // dtmInvAdjustTo
            // 
            this.dtmInvAdjustTo.EditValue = new System.DateTime(((long)(0)));
            this.dtmInvAdjustTo.Location = new System.Drawing.Point(252, 269);
            this.dtmInvAdjustTo.Name = "dtmInvAdjustTo";
            this.dtmInvAdjustTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmInvAdjustTo.Size = new System.Drawing.Size(75, 21);
            this.dtmInvAdjustTo.TabIndex = 11;
            // 
            // dtmInvAdjustFrom
            // 
            this.dtmInvAdjustFrom.EditValue = new System.DateTime(((long)(0)));
            this.dtmInvAdjustFrom.Location = new System.Drawing.Point(150, 269);
            this.dtmInvAdjustFrom.Name = "dtmInvAdjustFrom";
            this.dtmInvAdjustFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmInvAdjustFrom.Size = new System.Drawing.Size(75, 21);
            this.dtmInvAdjustFrom.TabIndex = 10;
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Location = new System.Drawing.Point(12, 12);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(169, 18);
            this.radAll.TabIndex = 11;
            this.radAll.Text = "Purge All Transaction Data";
            this.radAll.UseVisualStyleBackColor = true;
            // 
            // radSelected
            // 
            this.radSelected.AutoSize = true;
            this.radSelected.Checked = true;
            this.radSelected.Location = new System.Drawing.Point(12, 35);
            this.radSelected.Name = "radSelected";
            this.radSelected.Size = new System.Drawing.Size(138, 18);
            this.radSelected.TabIndex = 12;
            this.radSelected.TabStop = true;
            this.radSelected.Text = "Purge Selected Data";
            this.radSelected.UseVisualStyleBackColor = true;
            this.radSelected.CheckedChanged += new System.EventHandler(this.radSelected_CheckedChanged);
            // 
            // lblDateRange
            // 
            this.lblDateRange.AutoSize = true;
            this.lblDateRange.Location = new System.Drawing.Point(396, 31);
            this.lblDateRange.Name = "lblDateRange";
            this.lblDateRange.Size = new System.Drawing.Size(71, 14);
            this.lblDateRange.TabIndex = 13;
            this.lblDateRange.Text = "Date Range";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(475, 31);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(34, 14);
            this.lblFrom.TabIndex = 14;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(600, 31);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(22, 14);
            this.lblTo.TabIndex = 33;
            this.lblTo.Text = "To";
            // 
            // dtmTo
            // 
            this.dtmTo.EditValue = new System.DateTime(2007, 6, 10, 0, 0, 0, 0);
            this.dtmTo.Location = new System.Drawing.Point(625, 29);
            this.dtmTo.Name = "dtmTo";
            this.dtmTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmTo.Size = new System.Drawing.Size(75, 21);
            this.dtmTo.TabIndex = 32;
            // 
            // dtmFrom
            // 
            this.dtmFrom.EditValue = new System.DateTime(2007, 6, 10, 0, 0, 0, 0);
            this.dtmFrom.Location = new System.Drawing.Point(518, 29);
            this.dtmFrom.Name = "dtmFrom";
            this.dtmFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmFrom.Size = new System.Drawing.Size(75, 21);
            this.dtmFrom.TabIndex = 31;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(279, 549);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 36;
            this.btnExecute.Text = "Execute";
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(369, 549);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PurgeData
            // 
            this.ClientSize = new System.Drawing.Size(713, 584);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtmTo);
            this.Controls.Add(this.dtmFrom);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblDateRange);
            this.Controls.Add(this.radSelected);
            this.Controls.Add(this.radAll);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PurgeData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purge Data";
            this.Load += new System.EventHandler(this.PurgeData_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPeriodDetailsTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPeriodDetailsFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmProductDetailsTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmProductDetailsFrom.Properties)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmWorkOrderTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmWorkOrderFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPhysicalTakeTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPhysicalTakeFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmInvUpdateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmInvUpdateFrom.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmInvoicesTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmInvoicesFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPaymentTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPaymentFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmSalesOrderTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmSalesOrderFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPurchaseOrderTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPurchaseOrderFrom.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmStockInTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmStockInFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmStockOutTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmStockOutFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmStockTransferTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmStockTransferFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPickingListTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPickingListFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPackingListTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmPackingListFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDeliveryNotesTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDeliveryNotesFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmInvAdjustTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmInvAdjustFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmFrom.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Event Handler

        private void btnExecute_Click(object sender, EventArgs e)
        {

        }

        private void radSelected_CheckedChanged(object sender, EventArgs e)
        {
            if (radSelected.Checked)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void PurgeData_Load(object sender, EventArgs e)
        {
            this.ClearAllDate();
            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            if (radSelected.Checked)
            {
                if (this.CheckAtLeastOneDateInputted())
                {
                    dtmFrom.Text = "";
                    dtmFrom.Enabled = false;
                    dtmTo.Text = "";
                    dtmTo.Enabled = false;
                }
                else
                {
                    dtmFrom.Enabled = true;
                    dtmTo.Enabled = true;
                }
            }
            if (radAll.Checked)
            {
                dtmFrom.Enabled = true;
                dtmTo.Enabled = true;
            }
        }

        #endregion

        #region Methods

        private bool ValidateData()
        {
            if (radSelected.Checked)
            {
                bool blnAtLeastOneSelected = this.CheckAtLeastOneSelected();
                if (!blnAtLeastOneSelected)
                {
                    MessageBox.Show(Constants.Message.PurgeData_NoOneSelected, Constants.Message.MessageTitle);
                    return false;
                }

                if (chkStockIn.Checked)
                {
                    if (dtmStockInTo.DateTime.CompareTo(dtmStockInFrom.DateTime) < 0)
                    {
                        MessageBox.Show(Constants.Message.PurgeData_ToDateMustGreaterThanFromDate, Constants.Message.MessageTitle);
                        dtmStockInTo.Focus();
                        return false;
                    }
                }

                if (chkStockOut.Checked)
                {
                    if (dtmStockOutTo.DateTime.CompareTo(dtmStockOutFrom.DateTime) < 0)
                    {
                        MessageBox.Show(Constants.Message.PurgeData_ToDateMustGreaterThanFromDate, Constants.Message.MessageTitle);
                        dtmStockOutTo.Focus();
                        return false;
                    }
                }

                if (chkStockTransfer.Checked)
                {
                    if (dtmStockTransferTo.DateTime.CompareTo(dtmStockTransferFrom.DateTime) < 0)
                    {
                        MessageBox.Show(Constants.Message.PurgeData_ToDateMustGreaterThanFromDate, Constants.Message.MessageTitle);
                        dtmStockTransferTo.Focus();
                        return false;
                    }
                }

                if (chkPickingList.Checked)
                {
                    if (dtmPickingListTo.DateTime.CompareTo(dtmPickingListFrom.DateTime) < 0)
                    {
                        MessageBox.Show(Constants.Message.PurgeData_ToDateMustGreaterThanFromDate, Constants.Message.MessageTitle);
                        dtmPickingListTo.Focus();
                        return false;
                    }
                }

                if (chkPackingList.Checked)
                {
                    if (dtmPackingListTo.DateTime.CompareTo(dtmPackingListFrom.DateTime) < 0)
                    {
                        MessageBox.Show(Constants.Message.PurgeData_ToDateMustGreaterThanFromDate, Constants.Message.MessageTitle);
                        dtmPackingListTo.Focus();
                        return false;
                    }
                }

                if (chkDeliveryNote.Checked)
                {
                    if (dtmDeliveryNotesTo.DateTime.CompareTo(dtmDeliveryNotesFrom.DateTime) < 0)
                    {
                        MessageBox.Show(Constants.Message.PurgeData_ToDateMustGreaterThanFromDate, Constants.Message.MessageTitle);
                        dtmDeliveryNotesTo.Focus();
                        return false;
                    }
                }

                if (chkInvAdjust.Checked)
                {
                    if (dtmInvAdjustTo.DateTime.CompareTo(dtmInvAdjustFrom.DateTime) < 0)
                    {
                        MessageBox.Show(Constants.Message.PurgeData_ToDateMustGreaterThanFromDate, Constants.Message.MessageTitle);
                        dtmInvAdjustTo.Focus();
                        return false;
                    }
                }

                if (chkInvUpdate.Checked)
                {
                    if (dtmInvUpdateTo.DateTime.CompareTo(dtmInvUpdateFrom.DateTime) < 0)
                    {
                        MessageBox.Show(Constants.Message.PurgeData_ToDateMustGreaterThanFromDate, Constants.Message.MessageTitle);
                        dtmInvUpdateTo.Focus();
                        return false;
                    }
                }

                if (chkPhysicalTake.Checked)
                {
                    if (dtmPhysicalTakeTo.DateTime.CompareTo(dtmPhysicalTakeFrom.DateTime) < 0)
                    {
                        MessageBox.Show(Constants.Message.PurgeData_ToDateMustGreaterThanFromDate, Constants.Message.MessageTitle);
                        dtmPhysicalTakeTo.Focus();
                        return false;
                    }
                }

                if (chkWorkOrder.Checked)
                {
                    if (dtmWorkOrderTo.DateTime.CompareTo(dtmWorkOrderFrom.DateTime) < 0)
                    {
                        MessageBox.Show(Constants.Message.PurgeData_ToDateMustGreaterThanFromDate, Constants.Message.MessageTitle);
                        dtmWorkOrderTo.Focus();
                        return false;
                    }
                }

                if (chkPurchaseOrder.Checked)
                {
                    if (dtmPurchaseOrderTo.DateTime.CompareTo(dtmPurchaseOrderFrom.DateTime) < 0)
                    {
                        MessageBox.Show(Constants.Message.PurgeData_ToDateMustGreaterThanFromDate, Constants.Message.MessageTitle);
                        dtmPurchaseOrderTo.Focus();
                        return false;
                    }
                }

                if (chkSalesOrder.Checked)
                {
                    if (dtmSalesOrderTo.DateTime.CompareTo(dtmSalesOrderFrom.DateTime) < 0)
                    {
                        MessageBox.Show(Constants.Message.PurgeData_ToDateMustGreaterThanFromDate, Constants.Message.MessageTitle);
                        dtmSalesOrderTo.Focus();
                        return false;
                    }
                }

                if (chkPayment.Checked)
                {
                    if (dtmPaymentTo.DateTime.CompareTo(dtmPaymentFrom.DateTime) < 0)
                    {
                        MessageBox.Show(Constants.Message.PurgeData_ToDateMustGreaterThanFromDate, Constants.Message.MessageTitle);
                        dtmPaymentTo.Focus();
                        return false;
                    }
                }

                if (chkInvoice.Checked)
                {
                    if (dtmInvoicesTo.DateTime.CompareTo(dtmInvoicesFrom.DateTime) < 0)
                    {
                        MessageBox.Show(Constants.Message.PurgeData_ToDateMustGreaterThanFromDate, Constants.Message.MessageTitle);
                        dtmInvoicesTo.Focus();
                        return false;
                    }
                }

                if (chkProductDetails.Checked)
                {
                    if (dtmProductDetailsTo.DateTime.CompareTo(dtmProductDetailsFrom.DateTime) < 0)
                    {
                        MessageBox.Show(Constants.Message.PurgeData_ToDateMustGreaterThanFromDate, Constants.Message.MessageTitle);
                        dtmProductDetailsTo.Focus();
                        return false;
                    }
                }

                if (chkPeriodDetails.Checked)
                {
                    if (dtmPeriodDetailsTo.DateTime.CompareTo(dtmPeriodDetailsFrom.DateTime) < 0)
                    {
                        MessageBox.Show(Constants.Message.PurgeData_ToDateMustGreaterThanFromDate, Constants.Message.MessageTitle);
                        dtmPeriodDetailsTo.Focus();
                        return false;
                    }
                }
            }

            if (dtmTo.DateTime.CompareTo(dtmFrom.DateTime) < 0)
            {
                MessageBox.Show(Constants.Message.PurgeData_ToDateMustGreaterThanFromDate, Constants.Message.MessageTitle);
                dtmTo.Focus();
                return false;
            }

            return true;
        }

        private void ClearAllDate()
        {
            dtmFrom.Text = "";
            dtmTo.Text = "";
            
            foreach (Control dtm in groupBox2.Controls)
            {
                if (dtm is DateEdit)
                {
                    ((DateEdit)dtm).Text = "";
                }
            }

            foreach (Control dtm in groupBox3.Controls)
            {
                if (dtm is DateEdit)
                {
                    ((DateEdit)dtm).Text = "";
                }
            }

            foreach (Control dtm in groupBox4.Controls)
            {
                if (dtm is DateEdit)
                {
                    ((DateEdit)dtm).Text = "";
                }
            }

            foreach (Control dtm in groupBox5.Controls)
            {
                if (dtm is DateEdit)
                {
                    ((DateEdit)dtm).Text = "";
                }
            }
        }

        private bool CheckAtLeastOneSelected()
        {
            foreach (Control chk in groupBox2.Controls)
            {
                if (chk is CheckBox)
                {
                    if (((CheckBox)chk).Checked)
                    {
                        return true;
                    }
                }
            }

            foreach (Control chk in groupBox3.Controls)
            {
                if (chk is CheckBox)
                {
                    if (((CheckBox)chk).Checked)
                    {
                        return true;
                    }
                }
            }

            foreach (Control chk in groupBox4.Controls)
            {
                if (chk is CheckBox)
                {
                    if (((CheckBox)chk).Checked)
                    {
                        return true;
                    }
                }
            }

            foreach (Control chk in groupBox5.Controls)
            {
                if (chk is CheckBox)
                {
                    if (((CheckBox)chk).Checked)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool CheckAtLeastOneDateInputted()
        {
            foreach (Control dtm in groupBox2.Controls)
            {
                if (dtm is DateEdit)
                {
                    if (((DateEdit)dtm).Text != "")
                    {
                        return true;
                    }
                }
            }

            foreach (Control dtm in groupBox3.Controls)
            {
                if (dtm is DateEdit)
                {
                    if (((DateEdit)dtm).Text != "")
                    {
                        return true;
                    }
                }
            }

            foreach (Control dtm in groupBox4.Controls)
            {
                if (dtm is DateEdit)
                {
                    if (((DateEdit)dtm).Text != "")
                    {
                        return true;
                    }
                }
            }

            foreach (Control dtm in groupBox5.Controls)
            {
                if (dtm is DateEdit)
                {
                    if (((DateEdit)dtm).Text != "")
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        #endregion

        #region Purge Methods

        public void ExecutePurgeData(PurgeDataProcess pr)
        {
            if (radAll.Checked) // purge all data
            {
                PurgeAll(pr);
                return;
            }

            PurgeSelected(pr); // purge selected data
        }

        private void PurgeAll(PurgeDataProcess pr)
        {
            this.PurgeStockIn(pr, dtmFrom.DateTime, dtmTo.DateTime);
            this.PurgeStockOut(pr, dtmFrom.DateTime, dtmTo.DateTime);
            this.PurgeStockTransfer(pr, dtmFrom.DateTime, dtmTo.DateTime);
            this.PurgePickingList(pr, dtmFrom.DateTime, dtmTo.DateTime);
            this.PurgePackingList(pr, dtmFrom.DateTime, dtmTo.DateTime);
            this.PurgeDeliveryNotes(pr, dtmFrom.DateTime, dtmTo.DateTime);
            this.PurgeInventoryAdjustment(pr, dtmFrom.DateTime, dtmTo.DateTime);
            this.PurgeInventoryUpdate(pr, dtmFrom.DateTime, dtmTo.DateTime);
            this.PurgePhysicalTake(pr, dtmFrom.DateTime, dtmTo.DateTime);
            this.PurgeWorkOrder(pr, dtmFrom.DateTime, dtmTo.DateTime);
            this.PurgePurchaseOrder(pr, dtmFrom.DateTime, dtmTo.DateTime);
            this.PurgeSalesOrder(pr, dtmFrom.DateTime, dtmTo.DateTime);
            this.PurgePayment(pr, dtmFrom.DateTime, dtmTo.DateTime);
            this.PurgeInvoices(pr, dtmFrom.DateTime, dtmTo.DateTime);
            this.PurgeProductDetails(pr, dtmFrom.DateTime, dtmTo.DateTime);
            this.PurgePeriodDetails(pr, dtmFrom.DateTime, dtmTo.DateTime);
        }

        private void PurgeSelected(PurgeDataProcess pr)
        {
            // check that use special Date for each Data, or use common Date
            blnUseSpecialDate = this.CheckAtLeastOneDateInputted();

            DateTime from = dtmFrom.DateTime;
            DateTime to = dtmTo.DateTime;

            // purge Stock In
            if (chkStockIn.Checked)
            {
                // check that use special date, or leave common date
                if (blnUseSpecialDate) 
                {
                    from = dtmStockInFrom.DateTime;
                    to = dtmStockInTo.DateTime;
                }

                this.PurgeStockIn(pr, from, to);
            }

            if (chkStockOut.Checked)
            {
                // check that use special date, or leave common date
                if (blnUseSpecialDate)
                {
                    from = dtmStockOutFrom.DateTime;
                    to = dtmStockOutTo.DateTime;
                }

                this.PurgeStockOut(pr, from, to);
            }

            if (chkStockOut.Checked)
            {
                // check that use special date, or leave common date
                if (blnUseSpecialDate)
                {
                    from = dtmStockOutFrom.DateTime;
                    to = dtmStockOutTo.DateTime;
                }

                this.PurgeStockOut(pr, from, to);
            }

            if (chkPickingList.Checked)
            {
                // check that use special date, or leave common date
                if (blnUseSpecialDate)
                {
                    from = dtmPickingListFrom.DateTime;
                    to = dtmPickingListTo.DateTime;
                }

                this.PurgePickingList(pr, from, to);
            }

            if (chkPackingList.Checked)
            {
                // check that use special date, or leave common date
                if (blnUseSpecialDate)
                {
                    from = dtmPackingListFrom.DateTime;
                    to = dtmPackingListTo.DateTime;
                }

                this.PurgePackingList(pr, from, to);
            }

            if (chkDeliveryNote.Checked)
            {
                // check that use special date, or leave common date
                if (blnUseSpecialDate)
                {
                    from = dtmDeliveryNotesFrom.DateTime;
                    to = dtmDeliveryNotesTo.DateTime;
                }

                this.PurgeDeliveryNotes(pr, from, to);
            }

            if (chkInvAdjust.Checked)
            {
                // check that use special date, or leave common date
                if (blnUseSpecialDate)
                {
                    from = dtmInvAdjustFrom.DateTime;
                    to = dtmInvAdjustTo.DateTime;
                }

                this.PurgeInventoryAdjustment(pr, from, to);
            }

            if (chkInvUpdate.Checked)
            {
                // check that use special date, or leave common date
                if (blnUseSpecialDate)
                {
                    from = dtmInvUpdateFrom.DateTime;
                    to = dtmInvUpdateTo.DateTime;
                }

                this.PurgeInventoryUpdate(pr, from, to);
            }

            if (chkPhysicalTake.Checked)
            {
                // check that use special date, or leave common date
                if (blnUseSpecialDate)
                {
                    from = dtmPhysicalTakeFrom.DateTime;
                    to = dtmPhysicalTakeTo.DateTime;
                }

                this.PurgePhysicalTake(pr, from, to);
            }

            if (chkWorkOrder.Checked)
            {
                // check that use special date, or leave common date
                if (blnUseSpecialDate)
                {
                    from = dtmWorkOrderFrom.DateTime;
                    to = dtmWorkOrderTo.DateTime;
                }

                this.PurgeWorkOrder(pr, from, to);
            }

            if (chkPurchaseOrder.Checked)
            {
                // check that use special date, or leave common date
                if (blnUseSpecialDate)
                {
                    from = dtmPurchaseOrderFrom.DateTime;
                    to = dtmPurchaseOrderTo.DateTime;
                }

                this.PurgePurchaseOrder(pr, from, to);
            }

            if (chkSalesOrder.Checked)
            {
                // check that use special date, or leave common date
                if (blnUseSpecialDate)
                {
                    from = dtmSalesOrderFrom.DateTime;
                    to = dtmSalesOrderTo.DateTime;
                }

                this.PurgeSalesOrder(pr, from, to);
            }

            if (chkPayment.Checked)
            {
                // check that use special date, or leave common date
                if (blnUseSpecialDate)
                {
                    from = dtmPaymentFrom.DateTime;
                    to = dtmPaymentTo.DateTime;
                }

                this.PurgePayment(pr, from, to);
            }

            if (chkInvoice.Checked)
            {
                // check that use special date, or leave common date
                if (blnUseSpecialDate)
                {
                    from = dtmInvoicesFrom.DateTime;
                    to = dtmInvoicesTo.DateTime;
                }

                this.PurgeInvoices(pr, from, to);
            }

            if (chkProductDetails.Checked)
            {
                // check that use special date, or leave common date
                if (blnUseSpecialDate)
                {
                    from = dtmProductDetailsFrom.DateTime;
                    to = dtmProductDetailsTo.DateTime;
                }

                this.PurgeProductDetails(pr, from, to);
            }

            if (chkPeriodDetails.Checked)
            {
                // check that use special date, or leave common date
                if (blnUseSpecialDate)
                {
                    from = dtmPeriodDetailsFrom.DateTime;
                    to = dtmPeriodDetailsTo.DateTime;
                }

                this.PurgePeriodDetails(pr, from, to);
            }
        }

        #endregion

        #region Purge Data

        private void PurgeStockIn(PurgeDataProcess pr, DateTime fromDate, DateTime toDate)
        {
            pr.PurgeDependentData(settings.TB_STOCK_IN, "ID", settings.TB_STOCK_IN_DETAILS, "StockInID", "DateCreated", fromDate, toDate);
            pr.PurgeData(settings.TB_STOCK_IN, "DateCreated", fromDate, toDate);
        }

        private void PurgeStockOut(PurgeDataProcess pr, DateTime fromDate, DateTime toDate)
        {
            pr.PurgeDependentData(settings.TB_STOCK_OUT, "ID", settings.TB_STOCK_OUT_DETAILS, "StockOutID", "DateCreated", fromDate, toDate);
            pr.PurgeData(settings.TB_STOCK_OUT, "DateCreated", fromDate, toDate);
        }

        private void PurgeStockTransfer(PurgeDataProcess pr, DateTime fromDate, DateTime toDate)
        {
            pr.PurgeDependentData(settings.TB_STOCK_TRANSFER, "ID", settings.TB_STOCK_TRANSFER_DETAILS, "StockTransferID", "DateCreated", fromDate, toDate);
            pr.PurgeData(settings.TB_STOCK_TRANSFER, "DateCreated", fromDate, toDate);
        }

        private void PurgePickingList(PurgeDataProcess pr, DateTime fromDate, DateTime toDate)
        {
            pr.PurgeDependentData(settings.TB_PICKING_LIST, "PickingListID", settings.TB_PICKING_LIST_DETAILS, "PickingListID", "DateCreated", fromDate, toDate);
            pr.PurgeData(settings.TB_PICKING_LIST, "DateCreated", fromDate, toDate);
        }

        private void PurgePackingList(PurgeDataProcess pr, DateTime fromDate, DateTime toDate)
        {
            pr.PurgeDependentData(settings.TB_PACKING_LIST, "PackingListID", settings.TB_PACKING_LIST_DETAILS, "PackingListID", "DateCreated", fromDate, toDate);
            pr.PurgeData(settings.TB_PACKING_LIST, "DateCreated", fromDate, toDate);
        }

        private void PurgeDeliveryNotes(PurgeDataProcess pr, DateTime fromDate, DateTime toDate)
        {
            pr.PurgeDependentData(settings.TB_DELIVERY_NOTES, "ID", settings.TB_DELIVERY_NOTES_DETAILS, "DeliveryNoteID", "DateCreated", fromDate, toDate);
            pr.PurgeData(settings.TB_DELIVERY_NOTES, "DateCreated", fromDate, toDate);
        }

        private void PurgeInventoryAdjustment(PurgeDataProcess pr, DateTime fromDate, DateTime toDate)
        {
            pr.PurgeDependentData(settings.TB_INVENTORY_ADJUSTMENT, "ID", settings.TB_INVENTORY_ADJUSTMENT_DETAILS, "InventoryAdjustmentID", "DateCreated", fromDate, toDate);
            pr.PurgeData(settings.TB_INVENTORY_ADJUSTMENT, "DateCreated", fromDate, toDate);
        }

        private void PurgeInventoryUpdate(PurgeDataProcess pr, DateTime fromDate, DateTime toDate)
        {
            pr.PurgeDependentData(settings.TB_INVENTORY_UPDATE, "ID", settings.TB_INVENTORY_UPDATE_DETAILS, "InventoryUpdateID", "DateCreated", fromDate, toDate);
            pr.PurgeData(settings.TB_INVENTORY_UPDATE, "DateCreated", fromDate, toDate);
        }

        private void PurgePhysicalTake(PurgeDataProcess pr, DateTime fromDate, DateTime toDate)
        {
            pr.PurgeDependentData(settings.TB_PHYSICAL_TAKE, "ID", settings.TB_PHYSICAL_TAKE_DETAILS, "PhysicalTakeID", "DateCreated", fromDate, toDate);
            pr.PurgeData(settings.TB_PHYSICAL_TAKE, "DateCreated", fromDate, toDate);
        }

        private void PurgeWorkOrder(PurgeDataProcess pr, DateTime fromDate, DateTime toDate)
        {
            pr.PurgeData(settings.TB_WORK_ORDER, "DateCreated", fromDate, toDate);
        }

        private void PurgePurchaseOrder(PurgeDataProcess pr, DateTime fromDate, DateTime toDate)
        {
            pr.PurgeDependentData(settings.TB_PURCHASE_ORDER, "PONo", settings.TB_PURCHASE_ORDER_DETAIL, "PONo", "CreatedDate", fromDate, toDate);
            pr.PurgeData(settings.TB_PURCHASE_ORDER, "CreatedDate", fromDate, toDate);
        }

        private void PurgeSalesOrder(PurgeDataProcess pr, DateTime fromDate, DateTime toDate)
        {
            pr.PurgeDependentData(settings.TB_SALES_ORDER, "SONo", settings.TB_SALES_ORDER_DETAIL, "SONo", "CreatedDate", fromDate, toDate);
            pr.PurgeData(settings.TB_SALES_ORDER, "CreatedDate", fromDate, toDate);
        }

        private void PurgePayment(PurgeDataProcess pr, DateTime fromDate, DateTime toDate)
        {
            pr.PurgeData(settings.TB_PAYMENT_TERM, "DateCreated", fromDate, toDate);
        }

        private void PurgeInvoices(PurgeDataProcess pr, DateTime fromDate, DateTime toDate)
        {
            //pr.PurgeData(settings.TB_INVOICES, "DateCreated", fromDate, toDate);
        }

        private void PurgeProductDetails(PurgeDataProcess pr, DateTime fromDate, DateTime toDate)
        {
            //TODO: product table not contains Date column
            //pr.PurgeData(settings.TB_PRODUCT, "DateCreated", fromDate, toDate);
        }

        private void PurgePeriodDetails(PurgeDataProcess pr, DateTime fromDate, DateTime toDate)
        {
            //pr.PurgeData(settings.TB_PERIOD, "DateCreated", fromDate, toDate);
        }

        #endregion

        private void btnExecute_Click_1(object sender, EventArgs e)
        {
            if (!this.ValidateData())
            {
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

