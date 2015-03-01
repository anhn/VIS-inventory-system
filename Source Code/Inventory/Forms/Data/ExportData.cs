using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

using DevExpress.XtraEditors;
using Inventory.DataModels;

namespace Inventory.Forms.Data
{
    /// <summary>
    /// Summary description for ExportData.
    /// </summary>
    public class ExportData : DevExpress.XtraEditors.XtraForm
    {
        private GroupControl groupControl1;
        private CheckEdit chkWarehouse;
        private CheckEdit chkSalesOrder;
        private CheckEdit chkStockIn;
        private CheckEdit chkStockOut;
        private CheckEdit chkPickingList;
        private CheckEdit chkPackingList;
        private CheckEdit chkDeliverNotes;
        private CheckEdit chkLocation;
        private CheckEdit chkProduct;
        private CheckEdit chkCustomer;
        private CheckEdit chkBarcode;
        private CheckEdit chkBOM;
        private CheckEdit chkPaymentTerm;
        private CheckEdit chkPaymentMethods;
        private CheckEdit chkPurchaseOrder;
        private CheckEdit chkStockTransfer;
        private CheckEdit chkInvAdjust;
        private CheckEdit chkInvUpdate;
        private CheckEdit chkPhysicalTake;
        private CheckEdit chkPeriodDetails;
        private SimpleButton btnExport;
        private SimpleButton btnClose;
        private ButtonEdit btnSaveTo;
        private Label label1;
        private RadioButton radCore;
        private SimpleButton btnPeriodDetails;
        private SimpleButton btnPhysicalTake;
        private SimpleButton btnInvUpdate;
        private SimpleButton btnInvAdjust;
        private SimpleButton btnStockTransfer;
        private SimpleButton btnDeliveryNotes;
        private SimpleButton btnPackingList;
        private SimpleButton btnPickingList;
        private SimpleButton btnStockOut;
        private SimpleButton btnStockIn;
        private SimpleButton btnSalesOrder;
        private SimpleButton btnPurchaseOrder;
        private SimpleButton btnPaymentMethods;
        private SimpleButton btnPaymentTerm;
        private SimpleButton btnBOM;
        private SimpleButton btnBarcode;
        private SimpleButton btnCustomer;
        private SimpleButton btnProduct;
        private SimpleButton btnLocation;
        private SimpleButton btnWarehouseFilter;
        private RadioButton radTrans;
        private RadioButton radSelected;
        private SimpleButton btnCheckAll;
        private SimpleButton btnClearAll;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public ExportData()
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnPeriodDetails = new DevExpress.XtraEditors.SimpleButton();
            this.btnPhysicalTake = new DevExpress.XtraEditors.SimpleButton();
            this.btnInvUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnInvAdjust = new DevExpress.XtraEditors.SimpleButton();
            this.btnStockTransfer = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeliveryNotes = new DevExpress.XtraEditors.SimpleButton();
            this.btnPackingList = new DevExpress.XtraEditors.SimpleButton();
            this.btnPickingList = new DevExpress.XtraEditors.SimpleButton();
            this.btnStockOut = new DevExpress.XtraEditors.SimpleButton();
            this.btnStockIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalesOrder = new DevExpress.XtraEditors.SimpleButton();
            this.btnPurchaseOrder = new DevExpress.XtraEditors.SimpleButton();
            this.btnPaymentMethods = new DevExpress.XtraEditors.SimpleButton();
            this.btnPaymentTerm = new DevExpress.XtraEditors.SimpleButton();
            this.btnBOM = new DevExpress.XtraEditors.SimpleButton();
            this.btnBarcode = new DevExpress.XtraEditors.SimpleButton();
            this.btnCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.btnProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnLocation = new DevExpress.XtraEditors.SimpleButton();
            this.btnWarehouseFilter = new DevExpress.XtraEditors.SimpleButton();
            this.chkStockTransfer = new DevExpress.XtraEditors.CheckEdit();
            this.chkInvAdjust = new DevExpress.XtraEditors.CheckEdit();
            this.chkInvUpdate = new DevExpress.XtraEditors.CheckEdit();
            this.chkPhysicalTake = new DevExpress.XtraEditors.CheckEdit();
            this.chkPeriodDetails = new DevExpress.XtraEditors.CheckEdit();
            this.chkSalesOrder = new DevExpress.XtraEditors.CheckEdit();
            this.chkStockIn = new DevExpress.XtraEditors.CheckEdit();
            this.chkStockOut = new DevExpress.XtraEditors.CheckEdit();
            this.chkPickingList = new DevExpress.XtraEditors.CheckEdit();
            this.chkPackingList = new DevExpress.XtraEditors.CheckEdit();
            this.chkDeliverNotes = new DevExpress.XtraEditors.CheckEdit();
            this.chkLocation = new DevExpress.XtraEditors.CheckEdit();
            this.chkProduct = new DevExpress.XtraEditors.CheckEdit();
            this.chkCustomer = new DevExpress.XtraEditors.CheckEdit();
            this.chkBarcode = new DevExpress.XtraEditors.CheckEdit();
            this.chkBOM = new DevExpress.XtraEditors.CheckEdit();
            this.chkPaymentTerm = new DevExpress.XtraEditors.CheckEdit();
            this.chkPaymentMethods = new DevExpress.XtraEditors.CheckEdit();
            this.chkPurchaseOrder = new DevExpress.XtraEditors.CheckEdit();
            this.chkWarehouse = new DevExpress.XtraEditors.CheckEdit();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveTo = new DevExpress.XtraEditors.ButtonEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.radCore = new System.Windows.Forms.RadioButton();
            this.radTrans = new System.Windows.Forms.RadioButton();
            this.radSelected = new System.Windows.Forms.RadioButton();
            this.btnCheckAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnClearAll = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkStockTransfer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkInvAdjust.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkInvUpdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPhysicalTake.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPeriodDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSalesOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStockIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStockOut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPickingList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPackingList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDeliverNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBOM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPaymentTerm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPaymentMethods.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPurchaseOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkWarehouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveTo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnPeriodDetails);
            this.groupControl1.Controls.Add(this.btnPhysicalTake);
            this.groupControl1.Controls.Add(this.btnInvUpdate);
            this.groupControl1.Controls.Add(this.btnInvAdjust);
            this.groupControl1.Controls.Add(this.btnStockTransfer);
            this.groupControl1.Controls.Add(this.btnDeliveryNotes);
            this.groupControl1.Controls.Add(this.btnPackingList);
            this.groupControl1.Controls.Add(this.btnPickingList);
            this.groupControl1.Controls.Add(this.btnStockOut);
            this.groupControl1.Controls.Add(this.btnStockIn);
            this.groupControl1.Controls.Add(this.btnSalesOrder);
            this.groupControl1.Controls.Add(this.btnPurchaseOrder);
            this.groupControl1.Controls.Add(this.btnPaymentMethods);
            this.groupControl1.Controls.Add(this.btnPaymentTerm);
            this.groupControl1.Controls.Add(this.btnBOM);
            this.groupControl1.Controls.Add(this.btnBarcode);
            this.groupControl1.Controls.Add(this.btnCustomer);
            this.groupControl1.Controls.Add(this.btnProduct);
            this.groupControl1.Controls.Add(this.btnLocation);
            this.groupControl1.Controls.Add(this.btnWarehouseFilter);
            this.groupControl1.Controls.Add(this.chkStockTransfer);
            this.groupControl1.Controls.Add(this.chkInvAdjust);
            this.groupControl1.Controls.Add(this.chkInvUpdate);
            this.groupControl1.Controls.Add(this.chkPhysicalTake);
            this.groupControl1.Controls.Add(this.chkPeriodDetails);
            this.groupControl1.Controls.Add(this.chkSalesOrder);
            this.groupControl1.Controls.Add(this.chkStockIn);
            this.groupControl1.Controls.Add(this.chkStockOut);
            this.groupControl1.Controls.Add(this.chkPickingList);
            this.groupControl1.Controls.Add(this.chkPackingList);
            this.groupControl1.Controls.Add(this.chkDeliverNotes);
            this.groupControl1.Controls.Add(this.chkLocation);
            this.groupControl1.Controls.Add(this.chkProduct);
            this.groupControl1.Controls.Add(this.chkCustomer);
            this.groupControl1.Controls.Add(this.chkBarcode);
            this.groupControl1.Controls.Add(this.chkBOM);
            this.groupControl1.Controls.Add(this.chkPaymentTerm);
            this.groupControl1.Controls.Add(this.chkPaymentMethods);
            this.groupControl1.Controls.Add(this.chkPurchaseOrder);
            this.groupControl1.Controls.Add(this.chkWarehouse);
            this.groupControl1.Location = new System.Drawing.Point(12, 93);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(539, 292);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Select Data To Export";
            // 
            // btnPeriodDetails
            // 
            this.btnPeriodDetails.Enabled = false;
            this.btnPeriodDetails.Location = new System.Drawing.Point(432, 252);
            this.btnPeriodDetails.Name = "btnPeriodDetails";
            this.btnPeriodDetails.Size = new System.Drawing.Size(75, 18);
            this.btnPeriodDetails.TabIndex = 45;
            this.btnPeriodDetails.Text = "Filter";
            this.btnPeriodDetails.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnPhysicalTake
            // 
            this.btnPhysicalTake.Location = new System.Drawing.Point(432, 228);
            this.btnPhysicalTake.Name = "btnPhysicalTake";
            this.btnPhysicalTake.Size = new System.Drawing.Size(75, 18);
            this.btnPhysicalTake.TabIndex = 43;
            this.btnPhysicalTake.Tag = "";
            this.btnPhysicalTake.Text = "Filter";
            this.btnPhysicalTake.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnInvUpdate
            // 
            this.btnInvUpdate.Location = new System.Drawing.Point(432, 204);
            this.btnInvUpdate.Name = "btnInvUpdate";
            this.btnInvUpdate.Size = new System.Drawing.Size(75, 18);
            this.btnInvUpdate.TabIndex = 41;
            this.btnInvUpdate.Tag = "";
            this.btnInvUpdate.Text = "Filter";
            this.btnInvUpdate.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnInvAdjust
            // 
            this.btnInvAdjust.Location = new System.Drawing.Point(432, 180);
            this.btnInvAdjust.Name = "btnInvAdjust";
            this.btnInvAdjust.Size = new System.Drawing.Size(75, 18);
            this.btnInvAdjust.TabIndex = 39;
            this.btnInvAdjust.Tag = "";
            this.btnInvAdjust.Text = "Filter";
            this.btnInvAdjust.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnStockTransfer
            // 
            this.btnStockTransfer.Location = new System.Drawing.Point(432, 156);
            this.btnStockTransfer.Name = "btnStockTransfer";
            this.btnStockTransfer.Size = new System.Drawing.Size(75, 18);
            this.btnStockTransfer.TabIndex = 37;
            this.btnStockTransfer.Tag = "";
            this.btnStockTransfer.Text = "Filter";
            this.btnStockTransfer.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnDeliveryNotes
            // 
            this.btnDeliveryNotes.Location = new System.Drawing.Point(432, 132);
            this.btnDeliveryNotes.Name = "btnDeliveryNotes";
            this.btnDeliveryNotes.Size = new System.Drawing.Size(75, 18);
            this.btnDeliveryNotes.TabIndex = 35;
            this.btnDeliveryNotes.Tag = "";
            this.btnDeliveryNotes.Text = "Filter";
            this.btnDeliveryNotes.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnPackingList
            // 
            this.btnPackingList.Location = new System.Drawing.Point(432, 108);
            this.btnPackingList.Name = "btnPackingList";
            this.btnPackingList.Size = new System.Drawing.Size(75, 18);
            this.btnPackingList.TabIndex = 33;
            this.btnPackingList.Tag = "";
            this.btnPackingList.Text = "Filter";
            this.btnPackingList.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnPickingList
            // 
            this.btnPickingList.Location = new System.Drawing.Point(432, 84);
            this.btnPickingList.Name = "btnPickingList";
            this.btnPickingList.Size = new System.Drawing.Size(75, 18);
            this.btnPickingList.TabIndex = 31;
            this.btnPickingList.Tag = "";
            this.btnPickingList.Text = "Filter";
            this.btnPickingList.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnStockOut
            // 
            this.btnStockOut.Location = new System.Drawing.Point(432, 60);
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.Size = new System.Drawing.Size(75, 18);
            this.btnStockOut.TabIndex = 29;
            this.btnStockOut.Tag = "";
            this.btnStockOut.Text = "Filter";
            this.btnStockOut.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnStockIn
            // 
            this.btnStockIn.Location = new System.Drawing.Point(432, 36);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(75, 18);
            this.btnStockIn.TabIndex = 27;
            this.btnStockIn.Tag = "";
            this.btnStockIn.Text = "Filter";
            this.btnStockIn.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnSalesOrder
            // 
            this.btnSalesOrder.Location = new System.Drawing.Point(157, 252);
            this.btnSalesOrder.Name = "btnSalesOrder";
            this.btnSalesOrder.Size = new System.Drawing.Size(75, 18);
            this.btnSalesOrder.TabIndex = 25;
            this.btnSalesOrder.Tag = "";
            this.btnSalesOrder.Text = "Filter";
            this.btnSalesOrder.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnPurchaseOrder
            // 
            this.btnPurchaseOrder.Location = new System.Drawing.Point(157, 228);
            this.btnPurchaseOrder.Name = "btnPurchaseOrder";
            this.btnPurchaseOrder.Size = new System.Drawing.Size(75, 18);
            this.btnPurchaseOrder.TabIndex = 23;
            this.btnPurchaseOrder.Tag = "";
            this.btnPurchaseOrder.Text = "Filter";
            this.btnPurchaseOrder.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnPaymentMethods
            // 
            this.btnPaymentMethods.Location = new System.Drawing.Point(157, 204);
            this.btnPaymentMethods.Name = "btnPaymentMethods";
            this.btnPaymentMethods.Size = new System.Drawing.Size(75, 18);
            this.btnPaymentMethods.TabIndex = 21;
            this.btnPaymentMethods.Text = "Filter";
            this.btnPaymentMethods.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnPaymentTerm
            // 
            this.btnPaymentTerm.Location = new System.Drawing.Point(157, 180);
            this.btnPaymentTerm.Name = "btnPaymentTerm";
            this.btnPaymentTerm.Size = new System.Drawing.Size(75, 18);
            this.btnPaymentTerm.TabIndex = 19;
            this.btnPaymentTerm.Tag = "";
            this.btnPaymentTerm.Text = "Filter";
            this.btnPaymentTerm.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnBOM
            // 
            this.btnBOM.Location = new System.Drawing.Point(157, 156);
            this.btnBOM.Name = "btnBOM";
            this.btnBOM.Size = new System.Drawing.Size(75, 18);
            this.btnBOM.TabIndex = 17;
            this.btnBOM.Tag = "";
            this.btnBOM.Text = "Filter";
            this.btnBOM.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnBarcode
            // 
            this.btnBarcode.Location = new System.Drawing.Point(157, 132);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(75, 18);
            this.btnBarcode.TabIndex = 15;
            this.btnBarcode.Tag = "";
            this.btnBarcode.Text = "Filter";
            this.btnBarcode.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(157, 108);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(75, 18);
            this.btnCustomer.TabIndex = 13;
            this.btnCustomer.Tag = "";
            this.btnCustomer.Text = "Filter";
            this.btnCustomer.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(157, 84);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(75, 18);
            this.btnProduct.TabIndex = 11;
            this.btnProduct.Tag = "";
            this.btnProduct.Text = "Filter";
            this.btnProduct.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnLocation
            // 
            this.btnLocation.Location = new System.Drawing.Point(157, 60);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(75, 18);
            this.btnLocation.TabIndex = 9;
            this.btnLocation.Tag = "";
            this.btnLocation.Text = "Filter";
            this.btnLocation.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnWarehouseFilter
            // 
            this.btnWarehouseFilter.Location = new System.Drawing.Point(157, 36);
            this.btnWarehouseFilter.Name = "btnWarehouseFilter";
            this.btnWarehouseFilter.Size = new System.Drawing.Size(75, 18);
            this.btnWarehouseFilter.TabIndex = 7;
            this.btnWarehouseFilter.Tag = "";
            this.btnWarehouseFilter.Text = "Filter";
            this.btnWarehouseFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // chkStockTransfer
            // 
            this.chkStockTransfer.Location = new System.Drawing.Point(277, 156);
            this.chkStockTransfer.Name = "chkStockTransfer";
            this.chkStockTransfer.Properties.Caption = "Stock Transfer";
            this.chkStockTransfer.Size = new System.Drawing.Size(104, 19);
            this.chkStockTransfer.TabIndex = 36;
            // 
            // chkInvAdjust
            // 
            this.chkInvAdjust.Location = new System.Drawing.Point(277, 180);
            this.chkInvAdjust.Name = "chkInvAdjust";
            this.chkInvAdjust.Properties.Caption = "Inventory Adjustment";
            this.chkInvAdjust.Size = new System.Drawing.Size(144, 19);
            this.chkInvAdjust.TabIndex = 38;
            // 
            // chkInvUpdate
            // 
            this.chkInvUpdate.Location = new System.Drawing.Point(277, 204);
            this.chkInvUpdate.Name = "chkInvUpdate";
            this.chkInvUpdate.Properties.Caption = "Inventory Update";
            this.chkInvUpdate.Size = new System.Drawing.Size(119, 19);
            this.chkInvUpdate.TabIndex = 40;
            // 
            // chkPhysicalTake
            // 
            this.chkPhysicalTake.Location = new System.Drawing.Point(277, 228);
            this.chkPhysicalTake.Name = "chkPhysicalTake";
            this.chkPhysicalTake.Properties.Caption = "Physical Take";
            this.chkPhysicalTake.Size = new System.Drawing.Size(104, 19);
            this.chkPhysicalTake.TabIndex = 42;
            // 
            // chkPeriodDetails
            // 
            this.chkPeriodDetails.Enabled = false;
            this.chkPeriodDetails.Location = new System.Drawing.Point(277, 252);
            this.chkPeriodDetails.Name = "chkPeriodDetails";
            this.chkPeriodDetails.Properties.Caption = "Period Details";
            this.chkPeriodDetails.Size = new System.Drawing.Size(104, 19);
            this.chkPeriodDetails.TabIndex = 44;
            // 
            // chkSalesOrder
            // 
            this.chkSalesOrder.Location = new System.Drawing.Point(7, 252);
            this.chkSalesOrder.Name = "chkSalesOrder";
            this.chkSalesOrder.Properties.Caption = "Sales Order";
            this.chkSalesOrder.Size = new System.Drawing.Size(104, 19);
            this.chkSalesOrder.TabIndex = 24;
            // 
            // chkStockIn
            // 
            this.chkStockIn.Location = new System.Drawing.Point(277, 36);
            this.chkStockIn.Name = "chkStockIn";
            this.chkStockIn.Properties.Caption = "Stock In";
            this.chkStockIn.Size = new System.Drawing.Size(104, 19);
            this.chkStockIn.TabIndex = 26;
            // 
            // chkStockOut
            // 
            this.chkStockOut.Location = new System.Drawing.Point(277, 60);
            this.chkStockOut.Name = "chkStockOut";
            this.chkStockOut.Properties.Caption = "Stock Out";
            this.chkStockOut.Size = new System.Drawing.Size(104, 19);
            this.chkStockOut.TabIndex = 28;
            // 
            // chkPickingList
            // 
            this.chkPickingList.Location = new System.Drawing.Point(277, 84);
            this.chkPickingList.Name = "chkPickingList";
            this.chkPickingList.Properties.Caption = "Picking List";
            this.chkPickingList.Size = new System.Drawing.Size(83, 19);
            this.chkPickingList.TabIndex = 30;
            // 
            // chkPackingList
            // 
            this.chkPackingList.Location = new System.Drawing.Point(277, 108);
            this.chkPackingList.Name = "chkPackingList";
            this.chkPackingList.Properties.Caption = "Packing List";
            this.chkPackingList.Size = new System.Drawing.Size(95, 19);
            this.chkPackingList.TabIndex = 32;
            // 
            // chkDeliverNotes
            // 
            this.chkDeliverNotes.Location = new System.Drawing.Point(277, 132);
            this.chkDeliverNotes.Name = "chkDeliverNotes";
            this.chkDeliverNotes.Properties.Caption = "Delivery Notes";
            this.chkDeliverNotes.Size = new System.Drawing.Size(104, 19);
            this.chkDeliverNotes.TabIndex = 34;
            // 
            // chkLocation
            // 
            this.chkLocation.Location = new System.Drawing.Point(7, 60);
            this.chkLocation.Name = "chkLocation";
            this.chkLocation.Properties.Caption = "Location";
            this.chkLocation.Size = new System.Drawing.Size(75, 19);
            this.chkLocation.TabIndex = 8;
            // 
            // chkProduct
            // 
            this.chkProduct.Location = new System.Drawing.Point(7, 84);
            this.chkProduct.Name = "chkProduct";
            this.chkProduct.Properties.Caption = "Product";
            this.chkProduct.Size = new System.Drawing.Size(104, 19);
            this.chkProduct.TabIndex = 10;
            // 
            // chkCustomer
            // 
            this.chkCustomer.Location = new System.Drawing.Point(7, 108);
            this.chkCustomer.Name = "chkCustomer";
            this.chkCustomer.Properties.Caption = "Customer";
            this.chkCustomer.Size = new System.Drawing.Size(75, 19);
            this.chkCustomer.TabIndex = 12;
            // 
            // chkBarcode
            // 
            this.chkBarcode.Location = new System.Drawing.Point(7, 132);
            this.chkBarcode.Name = "chkBarcode";
            this.chkBarcode.Properties.Caption = "Barcode";
            this.chkBarcode.Size = new System.Drawing.Size(75, 19);
            this.chkBarcode.TabIndex = 14;
            // 
            // chkBOM
            // 
            this.chkBOM.Location = new System.Drawing.Point(7, 156);
            this.chkBOM.Name = "chkBOM";
            this.chkBOM.Properties.Caption = "Bill Of Materials";
            this.chkBOM.Size = new System.Drawing.Size(104, 19);
            this.chkBOM.TabIndex = 16;
            // 
            // chkPaymentTerm
            // 
            this.chkPaymentTerm.Location = new System.Drawing.Point(7, 180);
            this.chkPaymentTerm.Name = "chkPaymentTerm";
            this.chkPaymentTerm.Properties.Caption = "Payment Term";
            this.chkPaymentTerm.Size = new System.Drawing.Size(104, 19);
            this.chkPaymentTerm.TabIndex = 18;
            // 
            // chkPaymentMethods
            // 
            this.chkPaymentMethods.Location = new System.Drawing.Point(7, 204);
            this.chkPaymentMethods.Name = "chkPaymentMethods";
            this.chkPaymentMethods.Properties.Caption = "Payment Methods";
            this.chkPaymentMethods.Size = new System.Drawing.Size(135, 19);
            this.chkPaymentMethods.TabIndex = 20;
            // 
            // chkPurchaseOrder
            // 
            this.chkPurchaseOrder.Location = new System.Drawing.Point(7, 228);
            this.chkPurchaseOrder.Name = "chkPurchaseOrder";
            this.chkPurchaseOrder.Properties.Caption = "Purchase Order";
            this.chkPurchaseOrder.Size = new System.Drawing.Size(122, 19);
            this.chkPurchaseOrder.TabIndex = 22;
            // 
            // chkWarehouse
            // 
            this.chkWarehouse.Location = new System.Drawing.Point(7, 36);
            this.chkWarehouse.Name = "chkWarehouse";
            this.chkWarehouse.Properties.Caption = "Warehouse";
            this.chkWarehouse.Size = new System.Drawing.Size(104, 19);
            this.chkWarehouse.TabIndex = 6;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(190, 447);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 47;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(297, 447);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 48;
            this.btnClose.Text = "Close";
            // 
            // btnSaveTo
            // 
            this.btnSaveTo.Location = new System.Drawing.Point(83, 406);
            this.btnSaveTo.Name = "btnSaveTo";
            this.btnSaveTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnSaveTo.Size = new System.Drawing.Size(247, 21);
            this.btnSaveTo.TabIndex = 46;
            this.btnSaveTo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSaveTo_ButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Save To";
            // 
            // radCore
            // 
            this.radCore.AutoSize = true;
            this.radCore.Location = new System.Drawing.Point(12, 21);
            this.radCore.Name = "radCore";
            this.radCore.Size = new System.Drawing.Size(119, 18);
            this.radCore.TabIndex = 2;
            this.radCore.Text = "Export Core Data";
            this.radCore.UseVisualStyleBackColor = true;
            // 
            // radTrans
            // 
            this.radTrans.AutoSize = true;
            this.radTrans.Location = new System.Drawing.Point(12, 44);
            this.radTrans.Name = "radTrans";
            this.radTrans.Size = new System.Drawing.Size(157, 18);
            this.radTrans.TabIndex = 1;
            this.radTrans.TabStop = true;
            this.radTrans.Text = "Export Transaction Data";
            this.radTrans.UseVisualStyleBackColor = true;
            // 
            // radSelected
            // 
            this.radSelected.AutoSize = true;
            this.radSelected.Checked = true;
            this.radSelected.Location = new System.Drawing.Point(12, 67);
            this.radSelected.Name = "radSelected";
            this.radSelected.Size = new System.Drawing.Size(142, 18);
            this.radSelected.TabIndex = 0;
            this.radSelected.TabStop = true;
            this.radSelected.Text = "Export Selected Data";
            this.radSelected.UseVisualStyleBackColor = true;
            this.radSelected.CheckedChanged += new System.EventHandler(this.radSelected_CheckedChanged);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Location = new System.Drawing.Point(380, 69);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(75, 18);
            this.btnCheckAll.TabIndex = 3;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(476, 69);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 18);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // ExportData
            // 
            this.AcceptButton = this.btnExport;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(563, 478);
            this.Controls.Add(this.radSelected);
            this.Controls.Add(this.radTrans);
            this.Controls.Add(this.radCore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveTo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnCheckAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ExportData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export Data";
            this.Load += new System.EventHandler(this.ExportData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkStockTransfer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkInvAdjust.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkInvUpdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPhysicalTake.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPeriodDetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSalesOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStockIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStockOut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPickingList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPackingList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDeliverNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBOM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPaymentTerm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPaymentMethods.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPurchaseOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkWarehouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveTo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Attributes

        private Hashtable hshFilter = new Hashtable(); // store filter condition
        private Hashtable hshDialog = new Hashtable(); // store dialog and its temp data
        private Hashtable hshDataSet = new Hashtable(); // store data sets of tables

        private Properties.Settings settings = Properties.Settings.Default;

        #endregion

        #region Event Handler

        private void ExportData_Load(object sender, EventArgs e)
        {
            btnWarehouseFilter.Tag = settings.TB_WAREHOUSE;
            btnLocation.Tag = settings.TB_LOCATION;
            btnProduct.Tag = settings.TB_PRODUCT;
            btnCustomer.Tag = settings.TB_CUSTOMER;
            btnBarcode.Tag = settings.TB_BARCODE;
            btnBOM.Tag = settings.TB_BOM;
            btnPaymentTerm.Tag = settings.TB_PAYMENT_TERM;
            btnPaymentMethods.Tag = settings.TB_PAYMENT_METHOD;
            btnPurchaseOrder.Tag = settings.TB_PURCHASE_ORDER;
            btnSalesOrder.Tag = settings.TB_SALES_ORDER;
            btnStockIn.Tag = settings.TB_STOCK_IN;
            btnStockOut.Tag = settings.TB_STOCK_OUT;
            btnPickingList.Tag = settings.TB_PICKING_LIST;
            btnPackingList.Tag = settings.TB_PACKING_LIST;
            btnDeliveryNotes.Tag = settings.TB_DELIVERY_NOTES;
            btnStockTransfer.Tag = settings.TB_STOCK_TRANSFER;
            btnInvAdjust.Tag = settings.TB_INVENTORY_ADJUSTMENT;
            btnInvUpdate.Tag = settings.TB_INVENTORY_UPDATE;
            btnPhysicalTake.Tag = settings.TB_PHYSICAL_TAKE;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Note: all Click event of Filter buttons should handled by this function.
            // the Tag property of the button should be the Name of Table to be filtered.
            try
            {
                SimpleButton btnFilter = (SimpleButton)sender;
                string strTable = Convert.ToString(btnFilter.Tag); // used Tag to store name of table

                FilterDialog dlgFilter;
                if (hshDialog.Contains(strTable))
                {
                    dlgFilter = (FilterDialog)hshDialog[strTable];
                }
                else
                {
                    dlgFilter = new FilterDialog(strTable);
                    hshDialog.Add(strTable, dlgFilter);
                }

                DialogResult dlgResult = dlgFilter.ShowDialog();
                if (dlgResult == DialogResult.Cancel)
                {
                    return;
                }

                if (!hshFilter.ContainsKey(dlgFilter.TableName))
                {
                    hshFilter.Add(dlgFilter.TableName, "");
                }

                hshFilter[dlgFilter.TableName] = dlgFilter.GetFilterCondition();
            }
            catch (Exception ex)
            {
                string strMessage = ex.Message;
                while (ex.InnerException != null)
                {
                    strMessage += Environment.NewLine + ex.InnerException.Message;
                    ex = ex.InnerException;
                }

                MessageBox.Show(strMessage, Constants.Message.MessageTitle);
            }
        }

        private void btnSaveTo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.Filter = "Exported Xml (*.xml)|*.xml|All files (*.*)|*.*";
            DialogResult dlgResult = dlgSave.ShowDialog();
            if (dlgResult == DialogResult.Cancel)
            {
                return;
            }

            btnSaveTo.Text = dlgSave.FileName;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            foreach (Control ctlChild in this.groupControl1.Controls)
            {
                if (ctlChild is CheckEdit)
                {
                    ((CheckEdit)ctlChild).Checked = false;
                }
            }
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            foreach (Control ctlChild in this.groupControl1.Controls)
            {
                if (ctlChild is CheckEdit)
                {
                    ((CheckEdit)ctlChild).Checked = true;
                }
            }
        }

        private void radSelected_CheckedChanged(object sender, EventArgs e)
        {
            if (radSelected.Checked)
            {
                groupControl1.Enabled = true;
                btnCheckAll.Enabled = true;
                btnClearAll.Enabled = true;
            }
            else
            {
                groupControl1.Enabled = false;
                btnCheckAll.Enabled = false;
                btnClearAll.Enabled = false;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (!this.ValidateData())
            {
                return;
            }

            // re-initialize data storage each time click Export
            hshDataSet = new Hashtable();

            XmlDocument xmlDoc = new XmlDocument(); // store the exported data
            xmlDoc.LoadXml(settings.EXPORT_INVENTORY);
            xmlDoc.DocumentElement.InnerXml += "<EXPORT_INFO><Date>" + DateTime.Now + "</Date></EXPORT_INFO>";

            if (radCore.Checked)
            {
                this.ExportCoreData();
            }
            else if (radTrans.Checked)
            {
                this.ExportTransactionData();
            }
            else if (radSelected.Checked)
            {
                this.ExportSelectedData();
            }

            // get all data in data sets
            foreach (string strTableName in hshDataSet.Keys)
            {
                DataSet ds = (DataSet)hshDataSet[strTableName];
                xmlDoc.DocumentElement.InnerXml += ds.GetXml();
            }

            xmlDoc.Save(btnSaveTo.Text);
            MessageBox.Show(Constants.Message.Export_Success, Constants.Message.MessageTitle);
        }

        #endregion

        #region Methods

        private string GetExportSql(string tableName)
        {
            string strExportSql = "SELECT * FROM {0} {1}";
            string strCondition = "";
            if (hshFilter.ContainsKey(tableName))
            {
                string strFilter = (string)hshFilter[tableName];
                if (!string.IsNullOrEmpty(strFilter))
                {
                    strCondition = "WHERE " + (string)hshFilter[tableName];
                }
            }

            return string.Format(strExportSql, tableName, strCondition);
        }

        private string GetExportDependentSql(string primaryTable, string primaryColumn, string foreignTable, string foreignColumn)
        {
            string strExportDependentSql = "SELECT {0}.* FROM {0} INNER JOIN {1} ON {0}.{2} = {1}.{3}";
            return string.Format(strExportDependentSql, primaryTable, foreignTable, primaryColumn, foreignColumn);
        }

        private DataSet GetExportDataSet(string tableName)
        {
            string strSql = this.GetExportSql(tableName);
            DataTable dtData = Mediator.GetInstance().GetTableForFilter(strSql);

            DataSet ds = new DataSet(tableName);
            ds.Tables.Add(dtData);
            return ds;
        }

        private DataSet GetExportDependentDataSet(string primaryTable, string primaryColumn, string foreignTable, string foreignColumn)
        {
            string strSql = this.GetExportDependentSql(primaryTable, primaryColumn, foreignTable, foreignColumn);
            DataTable dtData = Mediator.GetInstance().GetTableForFilter(strSql);

            DataSet ds = new DataSet(primaryTable);
            ds.Tables.Add(dtData);
            return ds;
        }

        /// <summary>
        /// Each table may be got serveral times (ex. when loaded as dependencies). 
        /// Using this function to merge all the data of a table to one data set.
        /// </summary>
        /// <param name="ds"></param>
        private void MergeDataSet(DataSet ds)
        {
            string strTableName = ds.DataSetName;
            if (!hshDataSet.ContainsKey(strTableName))
            {
                hshDataSet.Add(strTableName, ds); // add data set to hashtable
                return;
            }

            // merge to existed data
            DataSet dsExisted = (DataSet)hshDataSet[strTableName];
            DataSet dsCopied = dsExisted.Copy(); // copy for loop and modify rows

            // iterator on new data rows
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                bool blnExisted = false;
                foreach (DataRow drExisted in dsCopied.Tables[0].Rows)
                {
                    // check values of data row
                    bool blnEqual = true;
                    for (int i = 0; i < dr.ItemArray.Length; i++)
                    {
                        if (!dr[i].Equals(drExisted[i]))
                        {
                            blnEqual = false; // value is different, data row not existed
                            break;
                        }
                    }

                    // data is equal
                    if (blnEqual)
                    {
                        blnExisted = true; // row existed
                    }
                }

                if (!blnExisted) // data not existed, add to data set
                {
                    dsExisted.Tables[0].LoadDataRow(dr.ItemArray, true);
                }
            }
        }

        private bool ValidateData()
        {
            if (radSelected.Checked)
            {
                // validate that at least one checkbox is selected
                bool hasSelected = false;
                foreach (Control ctlChild in this.groupControl1.Controls)
                {
                    if (ctlChild is CheckEdit)
                    {
                        if (((CheckEdit)ctlChild).Checked)
                        {
                            hasSelected = true;
                        }
                    }
                }

                if (!hasSelected)
                {
                    MessageBox.Show("Please select at least one Data to export.", Constants.Message.MessageTitle);
                    return false;
                }
            }

            if (btnSaveTo.Text == "")
            {
                MessageBox.Show("Please input the path to save the export file.", Constants.Message.MessageTitle);
                btnSaveTo.Focus();
                return false;
            }

            return true;
        }

        #endregion

        #region Export

        private void ExportCoreData()
        {
            this.GetExportWarehouse();
            this.GetExportLocation();
            this.GetExportProduct();
            this.GetExportCustomer();
            this.GetExportBarcode();
            this.GetExportBOM();
            this.GetExportPaymentTerm();
            this.GetExportPaymentMethod();
            this.GetExportPurchaseOrder();
            this.GetExportSaleOrder();
        }

        private void ExportTransactionData()
        {
            this.GetExportStockIn();
            this.GetExportStockOut();
            this.GetExportPickingList();
            this.GetExportPackingList();
            this.GetExportDeliveryNotes();
            this.GetExportStockTransfer();
            this.GetExportInvAdjust();
            this.GetExportInvUpdate();
            this.GetExportPhysicalTake();
            this.GetExportPeriodDetails();
        }

        private void ExportSelectedData()
        {
            if (chkWarehouse.Checked)
            {
                this.GetExportWarehouse();
            }

            if (chkLocation.Checked)
            {
                this.GetExportLocation();
            }

            if (chkProduct.Checked)
            {
                this.GetExportProduct();
            }

            if (chkCustomer.Checked)
            {
                this.GetExportCustomer();
            }

            if (chkBarcode.Checked)
            {
                this.GetExportBarcode();
            }

            if (chkBOM.Checked)
            {
                this.GetExportBOM();
            }

            if (chkPaymentTerm.Checked)
            {
                this.GetExportPaymentTerm();
            }

            if (chkPaymentMethods.Checked)
            {
                this.GetExportPaymentMethod();
            }

            if (chkPurchaseOrder.Checked)
            {
                this.GetExportPurchaseOrder();
            }

            if (chkSalesOrder.Checked)
            {
                this.GetExportSaleOrder();
            }

            if (chkStockIn.Checked)
            {
                this.GetExportStockIn();
            }

            if (chkStockOut.Checked)
            {
                this.GetExportStockOut();
            }

            if (chkPickingList.Checked)
            {
                this.GetExportPickingList();
            }

            if (chkPackingList.Checked)
            {
                this.GetExportPackingList();
            }

            if (chkDeliverNotes.Checked)
            {
                this.GetExportDeliveryNotes();
            }

            if (chkStockTransfer.Checked)
            {
                this.GetExportStockTransfer();
            }

            if (chkInvAdjust.Checked)
            {
                this.GetExportInvAdjust();
            }

            if (chkInvUpdate.Checked)
            {
                this.GetExportInvUpdate();
            }

            if (chkPhysicalTake.Checked)
            {
                this.GetExportPhysicalTake();
            }

            if (chkPeriodDetails.Checked)
            {
                this.GetExportPeriodDetails();
            }
        }

        #endregion

        #region Get Export

        private void GetExportWarehouse()
        {
            DataSet ds = this.GetExportDataSet(settings.TB_WAREHOUSE);
            this.MergeDataSet(ds); // store data of this table to one data set instance of the table
        }

        private void GetExportLocation()
        {
            DataSet ds = this.GetExportDataSet(settings.TB_LOCATION);
            this.MergeDataSet(ds); // store data of this table to one data set instance of the table
        }

        private void GetExportProduct()
        {
            DataSet ds = this.GetExportDataSet(settings.TB_PRODUCT);
            this.MergeDataSet(ds); // store data of this table to one data set instance of the table

            DataSet dsBarcode = this.GetExportDependentDataSet(settings.TB_BARCODE, "ID", settings.TB_PRODUCT, "BarcodeID");
            this.MergeDataSet(dsBarcode);

            DataSet dsCat = this.GetExportDependentDataSet(settings.TB_PRODUCT_CATEGORY, "CategoryID", settings.TB_PRODUCT, "CategoryID");
            this.MergeDataSet(dsCat);

            DataSet dsFa = this.GetExportDependentDataSet(settings.TB_PRODUCT_FAMILY, "FamilyID", settings.TB_PRODUCT, "FamilyID");
            this.MergeDataSet(dsFa);

            DataSet dsSubCat = this.GetExportDependentDataSet(settings.TB_PRODUCT_SUB_CATEGORY, "SubCategoryID", settings.TB_PRODUCT, "SubCategoryID");
            this.MergeDataSet(dsSubCat);

            DataSet dsUoM = this.GetExportDependentDataSet(settings.TB_UOM, "UOMID", settings.TB_PRODUCT, "UOMID");
            this.MergeDataSet(dsUoM);
        }

        private void GetExportCustomer()
        {
            DataSet ds = this.GetExportDataSet(settings.TB_CUSTOMER);
            this.MergeDataSet(ds);

            DataSet dsContact = this.GetExportDependentDataSet(settings.TB_CONTACT, "ContactID", settings.TB_CUSTOMER, "ContactID");
            this.MergeDataSet(dsContact);

            DataSet dsPaymentTerm = this.GetExportDependentDataSet(settings.TB_PAYMENT_TERM, "Payment_term_id", settings.TB_CUSTOMER, "Payment_term_id");
            this.MergeDataSet(dsPaymentTerm);

            DataSet dsTaxCode = this.GetExportDependentDataSet(settings.TB_TAX_CODE_MASTER, "Tax_code_id", settings.TB_CUSTOMER, "Tax_code_id");
            this.MergeDataSet(dsTaxCode);
        }

        private void GetExportBarcode()
        {
            DataSet ds = this.GetExportDataSet(settings.TB_BARCODE);
            this.MergeDataSet(ds);
        }

        private void GetExportBOM()
        {
            DataSet ds = this.GetExportDataSet(settings.TB_BOM);
            this.MergeDataSet(ds);

            DataSet dsProduct = this.GetExportDependentDataSet(settings.TB_PRODUCT, "ProductID", settings.TB_BOM, "ProductID");
            this.MergeDataSet(dsProduct);
        }

        private void GetExportPaymentTerm()
        {
            DataSet ds = this.GetExportDataSet(settings.TB_PAYMENT_TERM);
            this.MergeDataSet(ds);
        }

        private void GetExportPaymentMethod()
        {
            DataSet ds = this.GetExportDataSet(settings.TB_PAYMENT_METHOD);
            this.MergeDataSet(ds);
        }

        private void GetExportPurchaseOrder()
        {
            DataSet ds = this.GetExportDataSet(settings.TB_PURCHASE_ORDER);
            this.MergeDataSet(ds); // store data of this table to one data set instance of the table

            DataSet dsDetail = this.GetExportDataSet(settings.TB_PURCHASE_ORDER_DETAIL);
            this.MergeDataSet(dsDetail);

            DataSet dsContact = this.GetExportDependentDataSet(settings.TB_CONTACT, "ContactID", settings.TB_PURCHASE_ORDER, "SupplierID");
            this.MergeDataSet(dsContact);

            DataSet dsOrderType = this.GetExportDependentDataSet(settings.TB_ORDER_TYPE, "OrderTypeID", settings.TB_PURCHASE_ORDER, "POTypeID");
            this.MergeDataSet(dsOrderType);

            DataSet dsTaxCode = this.GetExportDependentDataSet(settings.TB_TAX_CODE_MASTER, "Tax_code_id", settings.TB_PURCHASE_ORDER, "Tax_code_id");
            this.MergeDataSet(dsTaxCode);
        }

        private void GetExportSaleOrder()
        {
            DataSet ds = this.GetExportDataSet(settings.TB_SALES_ORDER);
            this.MergeDataSet(ds); // store data of this table to one data set instance of the table

            DataSet dsDetail = this.GetExportDataSet(settings.TB_SALES_ORDER_DETAIL);
            this.MergeDataSet(dsDetail);

            DataSet dsContact = this.GetExportDependentDataSet(settings.TB_CONTACT, "ContactID", settings.TB_SALES_ORDER, "CustID");
            this.MergeDataSet(dsContact);

            DataSet dsOrderType = this.GetExportDependentDataSet(settings.TB_ORDER_TYPE, "OrderTypeID", settings.TB_SALES_ORDER, "SOTypeID");
            this.MergeDataSet(dsOrderType);

            DataSet dsPaymentTerm = this.GetExportDependentDataSet(settings.TB_PAYMENT_TERM, "Payment_term_id", settings.TB_SALES_ORDER, "PayType");
            this.MergeDataSet(dsPaymentTerm);

            DataSet dsShop = this.GetExportDependentDataSet(settings.TB_SHOP, "ShopID", settings.TB_SALES_ORDER, "ShopID");
            this.MergeDataSet(dsShop);

            DataSet dsTaxCode = this.GetExportDependentDataSet(settings.TB_TAX_CODE_MASTER, "Tax_code_id", settings.TB_SALES_ORDER, "Tax_code_id");
            this.MergeDataSet(dsTaxCode);
        }

        private void GetExportStockIn()
        {
            DataSet ds = this.GetExportDataSet(settings.TB_STOCK_IN);
            this.MergeDataSet(ds); // store data of this table to one data set instance of the table

            DataSet dsDetail = this.GetExportDataSet(settings.TB_STOCK_IN_DETAILS);
            this.MergeDataSet(dsDetail);

            DataSet dsLocation = this.GetExportDependentDataSet(settings.TB_LOCATION, "Bin_location_id", settings.TB_STOCK_IN, "Location");
            this.MergeDataSet(dsLocation);

            DataSet dsProduct = this.GetExportDependentDataSet(settings.TB_PRODUCT, "ProductID", settings.TB_STOCK_IN_DETAILS, "Product");
            this.MergeDataSet(dsProduct);
        }

        private void GetExportStockOut()
        {
            DataSet ds = this.GetExportDataSet(settings.TB_STOCK_OUT);
            this.MergeDataSet(ds);

            DataSet dsDetail = this.GetExportDataSet(settings.TB_STOCK_OUT_DETAILS);
            this.MergeDataSet(dsDetail);

            DataSet dsLocation = this.GetExportDependentDataSet(settings.TB_LOCATION, "Bin_location_id", settings.TB_STOCK_OUT, "Location");
            this.MergeDataSet(dsLocation);

            DataSet dsProduct = this.GetExportDependentDataSet(settings.TB_PRODUCT, "ProductID", settings.TB_STOCK_OUT_DETAILS, "Product");
            this.MergeDataSet(dsProduct);
        }

        private void GetExportPickingList()
        {
            DataSet ds = this.GetExportDataSet(settings.TB_PICKING_LIST);
            this.MergeDataSet(ds); // store data of this table to one data set instance of the table

            DataSet dsDetail = this.GetExportDataSet(settings.TB_PICKING_LIST_DETAILS);
            this.MergeDataSet(dsDetail);

            DataSet dsLocation = this.GetExportDependentDataSet(settings.TB_LOCATION, "Bin_location_id", settings.TB_PICKING_LIST, "DestLocation");
            this.MergeDataSet(dsLocation);

            DataSet dsOtherLocation = this.GetExportDependentDataSet(settings.TB_LOCATION, "Bin_location_id", settings.TB_PICKING_LIST, "OtherDestLocation");
            this.MergeDataSet(dsOtherLocation);

            DataSet dsProduct = this.GetExportDependentDataSet(settings.TB_PRODUCT, "ProductID", settings.TB_PICKING_LIST_DETAILS, "ProductID");
            this.MergeDataSet(dsProduct);

            DataSet dsFromLocation = this.GetExportDependentDataSet(settings.TB_LOCATION, "Bin_location_id", settings.TB_PICKING_LIST_DETAILS, "FromLocation");
            this.MergeDataSet(dsFromLocation);
        }

        private void GetExportPackingList()
        {
            DataSet ds = this.GetExportDataSet(settings.TB_PACKING_LIST);
            this.MergeDataSet(ds);

            DataSet dsDetail = this.GetExportDataSet(settings.TB_PACKING_LIST_DETAILS);
            this.MergeDataSet(dsDetail);

            DataSet dsProduct = this.GetExportDependentDataSet(settings.TB_PRODUCT, "ProductID", settings.TB_PACKING_LIST_DETAILS, "ProductID");
            this.MergeDataSet(dsProduct);

            DataSet dsFromLocation = this.GetExportDependentDataSet(settings.TB_LOCATION, "Bin_location_id", settings.TB_PACKING_LIST_DETAILS, "FromLocation");
            this.MergeDataSet(dsFromLocation);
        }

        private void GetExportDeliveryNotes()
        {
            DataSet ds = this.GetExportDataSet(settings.TB_DELIVERY_NOTES);
            this.MergeDataSet(ds);

            DataSet dsDetail = this.GetExportDataSet(settings.TB_DELIVERY_NOTES_DETAILS);
            this.MergeDataSet(dsDetail);

            DataSet dsMethod = this.GetExportDependentDataSet(settings.TB_DELIVERY_METHOD, "DeliveryMethodID", settings.TB_DELIVERY_NOTES, "DeliveryMethodID");
            this.MergeDataSet(dsMethod);

            DataSet dsCustomer = this.GetExportDependentDataSet(settings.TB_CUSTOMER, "CustomerID", settings.TB_DELIVERY_NOTES, "CustomerID");
            this.MergeDataSet(dsCustomer);

            DataSet dsProduct = this.GetExportDependentDataSet(settings.TB_PRODUCT, "ProductID", settings.TB_DELIVERY_NOTES_DETAILS, "ProductID");
            this.MergeDataSet(dsProduct);

            DataSet dsFromLocation = this.GetExportDependentDataSet(settings.TB_LOCATION, "Bin_location_id", settings.TB_DELIVERY_NOTES_DETAILS, "FromLocation");
            this.MergeDataSet(dsFromLocation);

            DataSet dsToLocation = this.GetExportDependentDataSet(settings.TB_LOCATION, "Bin_location_id", settings.TB_DELIVERY_NOTES_DETAILS, "ToLocation");
            this.MergeDataSet(dsToLocation);
        }

        private void GetExportStockTransfer()
        {
            DataSet ds = this.GetExportDataSet(settings.TB_STOCK_TRANSFER);
            this.MergeDataSet(ds);

            DataSet dsDetail = this.GetExportDataSet(settings.TB_STOCK_TRANSFER_DETAILS);
            this.MergeDataSet(dsDetail);

            DataSet dsFromLocation = this.GetExportDependentDataSet(settings.TB_LOCATION, "Bin_location_id", settings.TB_STOCK_TRANSFER_DETAILS, "FromLocation");
            this.MergeDataSet(dsFromLocation);

            DataSet dsToLocation = this.GetExportDependentDataSet(settings.TB_LOCATION, "Bin_location_id", settings.TB_STOCK_TRANSFER_DETAILS, "ToLocation");
            this.MergeDataSet(dsToLocation);

            DataSet dsProduct = this.GetExportDependentDataSet(settings.TB_PRODUCT, "ProductID", settings.TB_STOCK_TRANSFER_DETAILS, "ProductID");
            this.MergeDataSet(dsProduct);
        }

        private void GetExportInvAdjust()
        {
            DataSet ds = this.GetExportDataSet(settings.TB_INVENTORY_ADJUSTMENT);
            this.MergeDataSet(ds); // store data of this table to one data set instance of the table

            DataSet dsDetail = this.GetExportDataSet(settings.TB_INVENTORY_ADJUSTMENT_DETAILS);
            this.MergeDataSet(dsDetail);

            DataSet dsProduct = this.GetExportDependentDataSet(settings.TB_PRODUCT, "ProductID", settings.TB_INVENTORY_ADJUSTMENT_DETAILS, "ProductID");
            this.MergeDataSet(dsProduct);

            DataSet dsLocation = this.GetExportDependentDataSet(settings.TB_LOCATION, "Bin_location_id", settings.TB_INVENTORY_ADJUSTMENT_DETAILS, "Location");
            this.MergeDataSet(dsLocation);
        }

        private void GetExportInvUpdate()
        {
            DataSet ds = this.GetExportDataSet(settings.TB_INVENTORY_UPDATE);
            this.MergeDataSet(ds);

            DataSet dsDetail = this.GetExportDataSet(settings.TB_INVENTORY_UPDATE_DETAILS);
            this.MergeDataSet(dsDetail);

            DataSet dsProduct = this.GetExportDependentDataSet(settings.TB_PRODUCT, "ProductID", settings.TB_INVENTORY_UPDATE_DETAILS, "ProductID");
            this.MergeDataSet(dsProduct);

            DataSet dsLocation = this.GetExportDependentDataSet(settings.TB_LOCATION, "Bin_location_id", settings.TB_INVENTORY_UPDATE_DETAILS, "LocationID");
            this.MergeDataSet(dsLocation);

            DataSet dsWarehouse = this.GetExportDependentDataSet(settings.TB_WAREHOUSE, "Warehouse_id", settings.TB_INVENTORY_UPDATE_DETAILS, "WarehouseID");
            this.MergeDataSet(dsWarehouse);
        }

        private void GetExportPhysicalTake()
        {
            DataSet ds = this.GetExportDataSet(settings.TB_PHYSICAL_TAKE);
            this.MergeDataSet(ds); // store data of this table to one data set instance of the table

            DataSet dsDetail = this.GetExportDataSet(settings.TB_PHYSICAL_TAKE_DETAILS);
            this.MergeDataSet(dsDetail);

            DataSet dsProduct = this.GetExportDependentDataSet(settings.TB_PRODUCT, "ProductID", settings.TB_PHYSICAL_TAKE_DETAILS, "ProductID");
            this.MergeDataSet(dsProduct);

            DataSet dsLocation = this.GetExportDependentDataSet(settings.TB_LOCATION, "Bin_location_id", settings.TB_PHYSICAL_TAKE_DETAILS, "LocationID");
            this.MergeDataSet(dsLocation);
        }

        private void GetExportPeriodDetails()
        {
            //TODO: add this when Period Details is completed.
            //DataSet ds = this.GetExportDataSet(settings.TB_PERIOD_DETAILS);
            //this.MergeDataSet(ds);
        }

        #endregion
    }
}

