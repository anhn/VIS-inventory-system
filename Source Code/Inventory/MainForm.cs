using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;
using Inventory.Properties;
using System.Xml;
using System.Data;
using System.Data.SqlClient;


using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using System.Collections.Generic;

using System.Drawing.Printing;
using DevExpress.Utils;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraPrinting;

using Inventory.DataObjects;
using Inventory.Forms.Warehouse;
using Inventory.Forms.Product;
using Inventory.Commands;
using Inventory.DataModels;
using Inventory.Commands.Warehouse;
using Inventory.Commands.Product;
using Inventory.Utils;
using Inventory.Forms;
using Inventory.Commands.Barcode;
using Inventory.Commands.StockTake;
using Inventory.Commands.Listings;
using G8_POS;
using BackUpAndRestore;
using SqlTest;
using Toolkit;


namespace Inventory
{
    /// <summary>
    /// Summary description for MainForm.
    /// </summary>
    public class MainForm : DevExpress.XtraEditors.XtraForm
    {
        #region Design Attributes
        private IContainer components;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarSubItem mnuFile;
        private DevExpress.XtraBars.BarButtonItem mnuSLogin;
        private DevExpress.XtraBars.BarButtonItem mnuSBackup;
        private DevExpress.XtraBars.BarButtonItem mnuSRestore;
        private DevExpress.XtraBars.BarButtonItem mnuSPurgeData;
        private DevExpress.XtraBars.BarButtonItem mnuSPageSetup;
        private DevExpress.XtraBars.BarButtonItem mnuSExport;
        private DevExpress.XtraBars.BarButtonItem mnuSImport;
        private DevExpress.XtraBars.BarButtonItem mnuSUserGroupSecurity;
        private DevExpress.XtraBars.BarSubItem mnuInventory;
        private DevExpress.XtraBars.BarButtonItem mnuSUpdateInventory;
        private DevExpress.XtraBars.BarButtonItem mnuSInventorySheet;
        private DevExpress.XtraBars.BarButtonItem mnuSPrintWorkSheet;
        private DevExpress.XtraBars.BarButtonItem mnuSPhysicalTake;
        private DevExpress.XtraBars.BarButtonItem mnuSPrintVariance;
        private DevExpress.XtraBars.BarButtonItem mnuSPostPeriod;
        private DevExpress.XtraBars.BarButtonItem mnuSClosePeriod;
        private DevExpress.XtraBars.BarSubItem mnuAction;
        private DevExpress.XtraBars.BarButtonItem mnuSPurchaseOrders;
        private DevExpress.XtraBars.BarButtonItem mnuSReceiving;
        private DevExpress.XtraBars.BarButtonItem mnuSVendorPayments;
        private DevExpress.XtraBars.BarButtonItem mnuSSalesOrders;
        private DevExpress.XtraBars.BarButtonItem mnuSPackListing;
        private DevExpress.XtraBars.BarButtonItem mnuSDeliveryNote;
        private DevExpress.XtraBars.BarButtonItem mnuSInvoices;
        private DevExpress.XtraBars.BarButtonItem mnuSCustomerPayments;
        private DevExpress.XtraBars.BarButtonItem mnuSWordOrders;
        private DevExpress.XtraBars.BarButtonItem mnuSTransfers;
        private DevExpress.XtraBars.BarButtonItem mnuSAdjustInventory;
        private DevExpress.XtraBars.BarButtonItem mnuSReports;
        private DevExpress.XtraBars.BarSubItem mnuList;
        private DevExpress.XtraBars.BarButtonItem mnuSItems;
        private DevExpress.XtraBars.BarButtonItem mnuSVendor;
        private DevExpress.XtraBars.BarButtonItem mnuSCustomer;
        private DevExpress.XtraBars.BarButtonItem mnuSCustomerType;
        private DevExpress.XtraBars.BarButtonItem mnuSPaymentTerms;
        private DevExpress.XtraBars.BarButtonItem mnuSPaymentMethods;
        private DevExpress.XtraBars.BarButtonItem mnuSCustomerMessage;
        private DevExpress.XtraBars.BarButtonItem mnuSTaxCodeList;
        private DevExpress.XtraBars.BarButtonItem mnuSShipViaList;
        private DevExpress.XtraBars.BarButtonItem mnuSBillOfMaterial;
        private DevExpress.XtraBars.BarButtonItem mnuSCurrency;
        private DevExpress.XtraBars.BarSubItem    mnuNew;
        private DevExpress.XtraBars.BarButtonItem mnuSOurCompany;
        private DevExpress.XtraBars.BarButtonItem mnuSWarehouse;
        private DevExpress.XtraBars.BarButtonItem mnuSLocation;
        private DevExpress.XtraBars.BarButtonItem mnuSNewVendor;
        private DevExpress.XtraBars.BarButtonItem BarButtonItem1;
        private DevExpress.XtraBars.BarButtonItem mnuSNewCustomer;
        private DevExpress.XtraBars.BarButtonItem mnuSItem;
        private DevExpress.XtraBars.BarButtonItem mnuSNewBillOfMaterial;
        private DevExpress.XtraBars.BarSubItem mnuInterface;
        private DevExpress.XtraBars.BarButtonItem mnuSPointOfSales;
        private DevExpress.XtraBars.BarButtonItem mnuSChangeManagement;
        private DevExpress.XtraBars.BarButtonItem mnuSAccounting;
        private DevExpress.XtraBars.BarSubItem mnuHelp;
        private DevExpress.XtraBars.BarButtonItem mnuSContents;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.BarSubItem barSubItem5;
        private DevExpress.XtraBars.BarButtonItem mnuSPickListing;
        private DevExpress.XtraBars.BarSubItem barSubItem6;
        private DevExpress.XtraBars.BarSubItem barSubItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarSubItem barSubItem9;
        private DevExpress.XtraBars.BarSubItem barSubItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarSubItem barSubItem10;
        private DevExpress.XtraBars.BarSubItem barSubItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarSubItem barSubItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private PageSetupDialog pageSetupDialog1;
        private PrintDialog printDialog1;
        private PanelControl panelControl1;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private SimpleButton btnSave;
        private ImageList imageList1;
        private SimpleButton btnEdit;
        private SimpleButton btnNew;
        private SimpleButton btnPreview;
        private SimpleButton btnPrint;
        private SimpleButton btnSearch;
        private SimpleButton btnDelete;
        private SimpleButton btnHelp;
        private DevExpress.XtraTreeList.Blending.XtraTreeListBlending xtraTreeListBlending1;
        private SplitterControl splitterControl1;
        private TreeView tvMenu;
        private DevExpress.XtraPrintingLinks.DataGridLink dgrPrint;
        private DevExpress.XtraBars.BarButtonItem mnuSAbout;
        private DevExpress.XtraGrid.GridControl grdCustomer;
        private GridView gridView1;
        private GridView gridView2;
        #endregion

        #region Private Attributes

        private bool isModified = false;

        private DisplayedTabs CurrentTab;
        private BarSubItem barSubItem13;
        private BarButtonItem mnuSAlert;
        private BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private BarButtonItem mnuBarcode;
        private BarSubItem barSubItem14;
        private BarButtonItem mnuSProductCategory;
        private BarButtonItem mnuSProductFamily;
        private BarButtonItem mnuDOpWhStockIn;
        private BarButtonItem mnuDOpWhStockOut;
        private BarButtonItem mnuSSystemInformation;
        private BarButtonItem barButtonItem4;
        private BarButtonItem mnuReport;
        private BarSubItem mnuRG;
        private BarButtonItem mnuSReport;
        private BarButtonItem mnuListOtherUOM;
        private BarButtonItem barButtonItem11;
        private BarButtonItem mnuSPR;
        private BarButtonItem mnuSSR;
        private BarButtonItem mnuDeliveryMethod;
        private BarSubItem barSubItem15;
        private BarButtonItem mnuSPayTerms;
        private BarButtonItem mnuSPayMethods;
        private BarButtonItem mnuSDelMethod;
        private BarButtonItem mnuSTax;
        private BarButtonItem barButtonItem12;
        private BarButtonItem mnuSCurr;
        private BarButtonItem mnuSUOM;
        private BarButtonItem mnuSPackage;
        private BarButtonItem mnuSShipVia;

        private Mediator mediator = new Mediator();

        #endregion

        #region Initialization

        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            
            InitializeComponent();
            G8_POS.Globals.SetConnectionString(Globals.strVISConnection);
            grdCustomer.Font = Settings.Default.cfgDefaultFont;
            btnSave.ToolTip = Settings.Default.strSave;
            btnNew.ToolTip = Settings.Default.strAdd;
            btnEdit.ToolTip = Settings.Default.strEdit;
            btnDelete.ToolTip = Settings.Default.strDelete;
            btnPrint.ToolTip = Settings.Default.strPrint;
            btnPreview.ToolTip = Settings.Default.strPreview;
            btnHelp.ToolTip = Settings.Default.strHelp;
            btnSearch.ToolTip = Settings.Default.strSearch;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.mnuFile = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.mnuSBackup = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSPurgeData = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.mnuSImport = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSExport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSSystemInformation = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSPageSetup = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSUserGroupSecurity = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem13 = new DevExpress.XtraBars.BarSubItem();
            this.mnuSAlert = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSLogin = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.mnuInventory = new DevExpress.XtraBars.BarSubItem();
            this.mnuSUpdateInventory = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSPrintWorkSheet = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSInventorySheet = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSPhysicalTake = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSPrintVariance = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSClosePeriod = new DevExpress.XtraBars.BarButtonItem();
            this.mnuAction = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.mnuSPurchaseOrders = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSVendorPayments = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSPR = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.mnuSSalesOrders = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSInvoices = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSCustomerPayments = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSSR = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem5 = new DevExpress.XtraBars.BarSubItem();
            this.mnuSReceiving = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSPickListing = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSPackListing = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSDeliveryNote = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSTransfers = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSAdjustInventory = new DevExpress.XtraBars.BarButtonItem();
            this.mnuDOpWhStockIn = new DevExpress.XtraBars.BarButtonItem();
            this.mnuDOpWhStockOut = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSWordOrders = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSReports = new DevExpress.XtraBars.BarButtonItem();
            this.mnuNew = new DevExpress.XtraBars.BarSubItem();
            this.mnuSOurCompany = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem11 = new DevExpress.XtraBars.BarSubItem();
            this.mnuSWarehouse = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSLocation = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSNewVendor = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSNewCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem12 = new DevExpress.XtraBars.BarSubItem();
            this.mnuSItem = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSNewBillOfMaterial = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSProductCategory = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSProductFamily = new DevExpress.XtraBars.BarButtonItem();
            this.mnuBarcode = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem15 = new DevExpress.XtraBars.BarSubItem();
            this.mnuSPayTerms = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSPayMethods = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSDelMethod = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSTax = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSCurr = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSUOM = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSPackage = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSShipVia = new DevExpress.XtraBars.BarButtonItem();
            this.mnuInterface = new DevExpress.XtraBars.BarSubItem();
            this.mnuSPointOfSales = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSChangeManagement = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSAccounting = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.mnuRG = new DevExpress.XtraBars.BarSubItem();
            this.mnuSReport = new DevExpress.XtraBars.BarButtonItem();
            this.mnuHelp = new DevExpress.XtraBars.BarSubItem();
            this.mnuSContents = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSAbout = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.mnuSRestore = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSPostPeriod = new DevExpress.XtraBars.BarButtonItem();
            this.mnuList = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem6 = new DevExpress.XtraBars.BarSubItem();
            this.mnuSItems = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSBillOfMaterial = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem7 = new DevExpress.XtraBars.BarSubItem();
            this.mnuSVendor = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem9 = new DevExpress.XtraBars.BarSubItem();
            this.mnuSCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem10 = new DevExpress.XtraBars.BarSubItem();
            this.mnuSPaymentTerms = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSPaymentMethods = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSCustomerMessage = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSTaxCodeList = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSShipViaList = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSCustomerType = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSCurrency = new DevExpress.XtraBars.BarButtonItem();
            this.BarButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem8 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barSubItem14 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.mnuReport = new DevExpress.XtraBars.BarButtonItem();
            this.mnuListOtherUOM = new DevExpress.XtraBars.BarButtonItem();
            this.mnuDeliveryMethod = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnHelp = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.dgrPrint = new DevExpress.XtraPrintingLinks.DataGridLink(this.components);
            this.xtraTreeListBlending1 = new DevExpress.XtraTreeList.Blending.XtraTreeListBlending();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.grdCustomer = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mnuFile,
            this.mnuSLogin,
            this.mnuSBackup,
            this.mnuSRestore,
            this.mnuSPurgeData,
            this.mnuSPageSetup,
            this.mnuSExport,
            this.mnuSImport,
            this.mnuSUserGroupSecurity,
            this.mnuInventory,
            this.mnuSUpdateInventory,
            this.mnuSInventorySheet,
            this.mnuSPrintWorkSheet,
            this.mnuSPhysicalTake,
            this.mnuSPrintVariance,
            this.mnuSPostPeriod,
            this.mnuSClosePeriod,
            this.mnuAction,
            this.mnuSPurchaseOrders,
            this.mnuSReceiving,
            this.mnuSVendorPayments,
            this.mnuSSalesOrders,
            this.mnuSPackListing,
            this.mnuSDeliveryNote,
            this.mnuSInvoices,
            this.mnuSCustomerPayments,
            this.mnuSWordOrders,
            this.mnuSTransfers,
            this.mnuSAdjustInventory,
            this.mnuSReports,
            this.mnuList,
            this.mnuSItems,
            this.mnuSVendor,
            this.mnuSCustomer,
            this.mnuSCustomerType,
            this.mnuSPaymentTerms,
            this.mnuSPaymentMethods,
            this.mnuSCustomerMessage,
            this.mnuSTaxCodeList,
            this.mnuSShipViaList,
            this.mnuSBillOfMaterial,
            this.mnuSCurrency,
            this.BarButtonItem1,
            this.mnuNew,
            this.mnuSOurCompany,
            this.mnuSWarehouse,
            this.mnuSLocation,
            this.mnuSNewVendor,
            this.mnuSNewCustomer,
            this.mnuSItem,
            this.mnuSNewBillOfMaterial,
            this.mnuInterface,
            this.mnuSPointOfSales,
            this.mnuSChangeManagement,
            this.mnuSAccounting,
            this.mnuHelp,
            this.mnuSContents,
            this.mnuSAbout,
            this.barSubItem1,
            this.barSubItem2,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barSubItem3,
            this.barSubItem4,
            this.barSubItem5,
            this.mnuSPickListing,
            this.barSubItem6,
            this.barSubItem7,
            this.barButtonItem5,
            this.barSubItem8,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barSubItem9,
            this.barSubItem10,
            this.barSubItem11,
            this.barButtonItem8,
            this.barSubItem12,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barEditItem1,
            this.barSubItem13,
            this.mnuSAlert,
            this.mnuBarcode,
            this.barSubItem14,
            this.mnuSProductCategory,
            this.mnuSProductFamily,
            this.mnuDOpWhStockIn,
            this.mnuDOpWhStockOut,
            this.mnuSSystemInformation,
            this.barButtonItem4,
            this.mnuReport,
            this.mnuRG,
            this.mnuSReport,
            this.mnuListOtherUOM,
            this.barButtonItem11,
            this.mnuSPR,
            this.mnuSSR,
            this.mnuDeliveryMethod,
            this.barButtonItem12,
            this.barSubItem15,
            this.mnuSPayTerms,
            this.mnuSPayMethods,
            this.mnuSDelMethod,
            this.mnuSTax,
            this.mnuSCurr,
            this.mnuSUOM,
            this.mnuSPackage,
            this.mnuSShipVia});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 120;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 1";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(102, 166);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuInventory),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuAction),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuInterface),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuRG),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuHelp)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 1";
            // 
            // mnuFile
            // 
            this.mnuFile.Caption = global::Inventory.Properties.Settings.Default.strmnuFile;
            this.mnuFile.Id = 0;
            this.mnuFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem10),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSSystemInformation),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSPageSetup),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSUserGroupSecurity),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem13),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSLogin),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, false, this.barButtonItem11, false)});
            this.mnuFile.Name = "mnuFile";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = global::Inventory.Properties.Settings.Default.strmnuDataOper;
            this.barSubItem1.Id = 69;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSBackup),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSPurgeData)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // mnuSBackup
            // 
            this.mnuSBackup.Caption = global::Inventory.Properties.Settings.Default.strmnuBackup;
            this.mnuSBackup.Id = 2;
            this.mnuSBackup.Name = "mnuSBackup";
            this.mnuSBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSBackup_ItemClick);
            // 
            // mnuSPurgeData
            // 
            this.mnuSPurgeData.Caption = global::Inventory.Properties.Settings.Default.strmnuPurgeDate;
            this.mnuSPurgeData.Id = 4;
            this.mnuSPurgeData.Name = "mnuSPurgeData";
            this.mnuSPurgeData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSPurgeData_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = global::Inventory.Properties.Settings.Default.strmnuDataIO;
            this.barSubItem2.Id = 70;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSImport),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSExport)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // mnuSImport
            // 
            this.mnuSImport.Caption = global::Inventory.Properties.Settings.Default.strmnuImport;
            this.mnuSImport.Id = 7;
            this.mnuSImport.Name = "mnuSImport";
            this.mnuSImport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSImport_ItemClick);
            // 
            // mnuSExport
            // 
            this.mnuSExport.Caption = global::Inventory.Properties.Settings.Default.strmnuExport;
            this.mnuSExport.Id = 6;
            this.mnuSExport.Name = "mnuSExport";
            this.mnuSExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSExport_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = global::Inventory.Properties.Settings.Default.strmnuLanguageSetting;
            this.barButtonItem10.Id = 89;
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = global::Inventory.Properties.Settings.Default.strmnuSystemParam;
            this.barButtonItem3.Id = 72;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick_1);
            // 
            // mnuSSystemInformation
            // 
            this.mnuSSystemInformation.Caption = "System Information";
            this.mnuSSystemInformation.Id = 100;
            this.mnuSSystemInformation.Name = "mnuSSystemInformation";
            this.mnuSSystemInformation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSSystemInformation_ItemClick);
            // 
            // mnuSPageSetup
            // 
            this.mnuSPageSetup.Caption = global::Inventory.Properties.Settings.Default.strmnuPageSetup;
            this.mnuSPageSetup.Id = 5;
            this.mnuSPageSetup.Name = "mnuSPageSetup";
            this.mnuSPageSetup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSPageSetup_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = global::Inventory.Properties.Settings.Default.strmnuPrinterSetup;
            this.barButtonItem2.Id = 71;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // mnuSUserGroupSecurity
            // 
            this.mnuSUserGroupSecurity.Caption = "User/Group Security";
            this.mnuSUserGroupSecurity.Id = 8;
            this.mnuSUserGroupSecurity.Name = "mnuSUserGroupSecurity";
            this.mnuSUserGroupSecurity.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSUserGroupSecurity_ItemClick);
            // 
            // barSubItem13
            // 
            this.barSubItem13.Caption = "Settings";
            this.barSubItem13.Id = 91;
            this.barSubItem13.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSAlert)});
            this.barSubItem13.Name = "barSubItem13";
            // 
            // mnuSAlert
            // 
            this.mnuSAlert.Caption = "Alert";
            this.mnuSAlert.Id = 92;
            this.mnuSAlert.Name = "mnuSAlert";
            this.mnuSAlert.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSAlert_ItemClick);
            // 
            // mnuSLogin
            // 
            this.mnuSLogin.Caption = global::Inventory.Properties.Settings.Default.strmnuLogout;
            this.mnuSLogin.Id = 1;
            this.mnuSLogin.Name = "mnuSLogin";
            this.mnuSLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSLogin_ItemClick);
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Exit";
            this.barButtonItem11.Id = 106;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // mnuInventory
            // 
            this.mnuInventory.Caption = global::Inventory.Properties.Settings.Default.strmnuStockTake;
            this.mnuInventory.Id = 9;
            this.mnuInventory.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSUpdateInventory),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSPrintWorkSheet),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSInventorySheet),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSPhysicalTake),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSPrintVariance),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSClosePeriod)});
            this.mnuInventory.Name = "mnuInventory";
            // 
            // mnuSUpdateInventory
            // 
            this.mnuSUpdateInventory.Caption = global::Inventory.Properties.Settings.Default.strmnuUpdateInventory;
            this.mnuSUpdateInventory.Id = 10;
            this.mnuSUpdateInventory.Name = "mnuSUpdateInventory";
            this.mnuSUpdateInventory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSUpdateInventory_ItemClick);
            // 
            // mnuSPrintWorkSheet
            // 
            this.mnuSPrintWorkSheet.Caption = "Print Work Sheet (Developing)";
            this.mnuSPrintWorkSheet.Id = 12;
            this.mnuSPrintWorkSheet.Name = "mnuSPrintWorkSheet";
            // 
            // mnuSInventorySheet
            // 
            this.mnuSInventorySheet.Caption = "Inventory Sheet (Developing)";
            this.mnuSInventorySheet.Id = 11;
            this.mnuSInventorySheet.Name = "mnuSInventorySheet";
            // 
            // mnuSPhysicalTake
            // 
            this.mnuSPhysicalTake.Caption = global::Inventory.Properties.Settings.Default.strmnuPhysicalTake;
            this.mnuSPhysicalTake.Id = 13;
            this.mnuSPhysicalTake.Name = "mnuSPhysicalTake";
            this.mnuSPhysicalTake.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSPhysicalTake_ItemClick);
            // 
            // mnuSPrintVariance
            // 
            this.mnuSPrintVariance.Caption = global::Inventory.Properties.Settings.Default.strmnuPrintVar;
            this.mnuSPrintVariance.Id = 14;
            this.mnuSPrintVariance.Name = "mnuSPrintVariance";
            this.mnuSPrintVariance.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSPrintVariance_ItemClick);
            // 
            // mnuSClosePeriod
            // 
            this.mnuSClosePeriod.Caption = "Close Period (Debugging)";
            this.mnuSClosePeriod.Id = 16;
            this.mnuSClosePeriod.Name = "mnuSClosePeriod";
            this.mnuSClosePeriod.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSClosePeriod_ItemClick);
            // 
            // mnuAction
            // 
            this.mnuAction.Caption = global::Inventory.Properties.Settings.Default.strmnuDailyOper;
            this.mnuAction.Id = 17;
            this.mnuAction.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSWordOrders),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSReports)});
            this.mnuAction.Name = "mnuAction";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Purchasing";
            this.barSubItem3.Id = 73;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSPurchaseOrders),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSVendorPayments),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSPR)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // mnuSPurchaseOrders
            // 
            this.mnuSPurchaseOrders.Caption = "Purchase Orders (Developing)";
            this.mnuSPurchaseOrders.Id = 18;
            this.mnuSPurchaseOrders.Name = "mnuSPurchaseOrders";
            this.mnuSPurchaseOrders.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSPurchaseOrders_ItemClick);
            // 
            // mnuSVendorPayments
            // 
            this.mnuSVendorPayments.Caption = "Supplier Payments (Developing)";
            this.mnuSVendorPayments.Id = 20;
            this.mnuSVendorPayments.Name = "mnuSVendorPayments";
            this.mnuSVendorPayments.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSVendorPayments_ItemClick);
            // 
            // mnuSPR
            // 
            this.mnuSPR.Caption = "Purchase Returns (Developing)";
            this.mnuSPR.Id = 107;
            this.mnuSPR.Name = "mnuSPR";
            this.mnuSPR.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSPR_ItemClick);
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = global::Inventory.Properties.Settings.Default.strmnuOrdering;
            this.barSubItem4.Id = 74;
            this.barSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSSalesOrders),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, false, this.mnuSInvoices, false),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSCustomerPayments),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSSR)});
            this.barSubItem4.Name = "barSubItem4";
            // 
            // mnuSSalesOrders
            // 
            this.mnuSSalesOrders.Caption = "Sales Orders (Developing)";
            this.mnuSSalesOrders.Id = 21;
            this.mnuSSalesOrders.Name = "mnuSSalesOrders";
            this.mnuSSalesOrders.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSSalesOrders_ItemClick);
            // 
            // mnuSInvoices
            // 
            this.mnuSInvoices.Caption = global::Inventory.Properties.Settings.Default.strmnuInvoices;
            this.mnuSInvoices.Id = 24;
            this.mnuSInvoices.Name = "mnuSInvoices";
            this.mnuSInvoices.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSInvoices_ItemClick);
            // 
            // mnuSCustomerPayments
            // 
            this.mnuSCustomerPayments.Caption = "Customer Payments (Developing)";
            this.mnuSCustomerPayments.Id = 25;
            this.mnuSCustomerPayments.Name = "mnuSCustomerPayments";
            this.mnuSCustomerPayments.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSCustomerPayments_ItemClick);
            // 
            // mnuSSR
            // 
            this.mnuSSR.Caption = "Sales Return (Developing)";
            this.mnuSSR.Id = 108;
            this.mnuSSR.Name = "mnuSSR";
            this.mnuSSR.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSSR_ItemClick);
            // 
            // barSubItem5
            // 
            this.barSubItem5.Caption = global::Inventory.Properties.Settings.Default.strmnuWarehouse;
            this.barSubItem5.Id = 75;
            this.barSubItem5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSReceiving),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSPickListing),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSPackListing),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSDeliveryNote),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSTransfers),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSAdjustInventory),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuDOpWhStockIn),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuDOpWhStockOut)});
            this.barSubItem5.Name = "barSubItem5";
            // 
            // mnuSReceiving
            // 
            this.mnuSReceiving.Caption = global::Inventory.Properties.Settings.Default.strmnuReceiving;
            this.mnuSReceiving.Id = 19;
            this.mnuSReceiving.Name = "mnuSReceiving";
            this.mnuSReceiving.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSReceiving_ItemClick);
            // 
            // mnuSPickListing
            // 
            this.mnuSPickListing.Caption = global::Inventory.Properties.Settings.Default.strmnuPickListing;
            this.mnuSPickListing.Id = 76;
            this.mnuSPickListing.Name = "mnuSPickListing";
            this.mnuSPickListing.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSPickListing_ItemClick);
            // 
            // mnuSPackListing
            // 
            this.mnuSPackListing.Caption = global::Inventory.Properties.Settings.Default.strmnuPackListing;
            this.mnuSPackListing.Id = 22;
            this.mnuSPackListing.Name = "mnuSPackListing";
            this.mnuSPackListing.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSPackListing_ItemClick);
            // 
            // mnuSDeliveryNote
            // 
            this.mnuSDeliveryNote.Caption = global::Inventory.Properties.Settings.Default.strmnuDeliveryNote;
            this.mnuSDeliveryNote.Id = 23;
            this.mnuSDeliveryNote.Name = "mnuSDeliveryNote";
            this.mnuSDeliveryNote.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSDeliveryNote_ItemClick);
            // 
            // mnuSTransfers
            // 
            this.mnuSTransfers.Caption = global::Inventory.Properties.Settings.Default.strmnuTransfers;
            this.mnuSTransfers.Id = 27;
            this.mnuSTransfers.Name = "mnuSTransfers";
            this.mnuSTransfers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSTransfers_ItemClick);
            // 
            // mnuSAdjustInventory
            // 
            this.mnuSAdjustInventory.Caption = global::Inventory.Properties.Settings.Default.strmnuAdjustInventory;
            this.mnuSAdjustInventory.Id = 28;
            this.mnuSAdjustInventory.Name = "mnuSAdjustInventory";
            this.mnuSAdjustInventory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSAdjustInventory_ItemClick);
            // 
            // mnuDOpWhStockIn
            // 
            this.mnuDOpWhStockIn.Caption = "Stock In";
            this.mnuDOpWhStockIn.Id = 98;
            this.mnuDOpWhStockIn.Name = "mnuDOpWhStockIn";
            this.mnuDOpWhStockIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuDOpWhStockIn_ItemClick);
            // 
            // mnuDOpWhStockOut
            // 
            this.mnuDOpWhStockOut.Caption = "Stock Out";
            this.mnuDOpWhStockOut.Id = 99;
            this.mnuDOpWhStockOut.Name = "mnuDOpWhStockOut";
            this.mnuDOpWhStockOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuDOpWhStockOut_ItemClick);
            // 
            // mnuSWordOrders
            // 
            this.mnuSWordOrders.Caption = global::Inventory.Properties.Settings.Default.strmnuWordOrders;
            this.mnuSWordOrders.Id = 26;
            this.mnuSWordOrders.Name = "mnuSWordOrders";
            this.mnuSWordOrders.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSWordOrders_ItemClick);
            // 
            // mnuSReports
            // 
            this.mnuSReports.Caption = global::Inventory.Properties.Settings.Default.strmnuDailyReport;
            this.mnuSReports.Id = 29;
            this.mnuSReports.Name = "mnuSReports";
            // 
            // mnuNew
            // 
            this.mnuNew.Caption = global::Inventory.Properties.Settings.Default.strmnuMaintenance;
            this.mnuNew.Id = 45;
            this.mnuNew.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSOurCompany),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem11),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, false, this.mnuSLocation, false),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSNewVendor),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSNewCustomer),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem12),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuBarcode),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem15)});
            this.mnuNew.Name = "mnuNew";
            // 
            // mnuSOurCompany
            // 
            this.mnuSOurCompany.Caption = "Our Company (Developing)";
            this.mnuSOurCompany.Id = 46;
            this.mnuSOurCompany.Name = "mnuSOurCompany";
            // 
            // barSubItem11
            // 
            this.barSubItem11.Caption = global::Inventory.Properties.Settings.Default.strmnuWarehouseMaster;
            this.barSubItem11.Id = 85;
            this.barSubItem11.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSWarehouse),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem8)});
            this.barSubItem11.Name = "barSubItem11";
            // 
            // mnuSWarehouse
            // 
            this.mnuSWarehouse.Caption = "Warehouse";
            this.mnuSWarehouse.Id = 47;
            this.mnuSWarehouse.Name = "mnuSWarehouse";
            this.mnuSWarehouse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSWarehouse_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Location";
            this.barButtonItem8.Id = 86;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // mnuSLocation
            // 
            this.mnuSLocation.Caption = global::Inventory.Properties.Settings.Default.strmnuLocation;
            this.mnuSLocation.Id = 48;
            this.mnuSLocation.Name = "mnuSLocation";
            // 
            // mnuSNewVendor
            // 
            this.mnuSNewVendor.Caption = "Supplier";
            this.mnuSNewVendor.Id = 49;
            this.mnuSNewVendor.Name = "mnuSNewVendor";
            this.mnuSNewVendor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSNewVendor_ItemClick);
            // 
            // mnuSNewCustomer
            // 
            this.mnuSNewCustomer.Caption = global::Inventory.Properties.Settings.Default.strmnuCustomer;
            this.mnuSNewCustomer.Id = 53;
            this.mnuSNewCustomer.Name = "mnuSNewCustomer";
            this.mnuSNewCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSNewCustomer_ItemClick);
            // 
            // barSubItem12
            // 
            this.barSubItem12.Caption = global::Inventory.Properties.Settings.Default.strmnuItemMaster;
            this.barSubItem12.Id = 87;
            this.barSubItem12.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSNewBillOfMaterial),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSProductCategory),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSProductFamily)});
            this.barSubItem12.Name = "barSubItem12";
            // 
            // mnuSItem
            // 
            this.mnuSItem.Caption = global::Inventory.Properties.Settings.Default.strmnuItem;
            this.mnuSItem.Id = 59;
            this.mnuSItem.Name = "mnuSItem";
            this.mnuSItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSItem_ItemClick);
            // 
            // mnuSNewBillOfMaterial
            // 
            this.mnuSNewBillOfMaterial.Caption = global::Inventory.Properties.Settings.Default.strmnuBillofMaterial;
            this.mnuSNewBillOfMaterial.Id = 60;
            this.mnuSNewBillOfMaterial.Name = "mnuSNewBillOfMaterial";
            this.mnuSNewBillOfMaterial.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSNewBillOfMaterial_ItemClick);
            // 
            // mnuSProductCategory
            // 
            this.mnuSProductCategory.Caption = "Product Category (Developing)";
            this.mnuSProductCategory.Id = 96;
            this.mnuSProductCategory.Name = "mnuSProductCategory";
            this.mnuSProductCategory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSProductCategory_ItemClick);
            // 
            // mnuSProductFamily
            // 
            this.mnuSProductFamily.Caption = "Product Family";
            this.mnuSProductFamily.Id = 97;
            this.mnuSProductFamily.Name = "mnuSProductFamily";
            this.mnuSProductFamily.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSProductFamily_ItemClick);
            // 
            // mnuBarcode
            // 
            this.mnuBarcode.Caption = "Barcode";
            this.mnuBarcode.Id = 94;
            this.mnuBarcode.Name = "mnuBarcode";
            this.mnuBarcode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuBarcode_ItemClick);
            // 
            // barSubItem15
            // 
            this.barSubItem15.Caption = "Others";
            this.barSubItem15.Id = 111;
            this.barSubItem15.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSPayTerms),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSPayMethods),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSDelMethod),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSTax),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSCurr),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSUOM),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSPackage),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSShipVia)});
            this.barSubItem15.Name = "barSubItem15";
            // 
            // mnuSPayTerms
            // 
            this.mnuSPayTerms.Caption = "Payment Terms";
            this.mnuSPayTerms.Id = 112;
            this.mnuSPayTerms.Name = "mnuSPayTerms";
            this.mnuSPayTerms.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSPayTerms_ItemClick);
            // 
            // mnuSPayMethods
            // 
            this.mnuSPayMethods.Caption = "Payment Methods";
            this.mnuSPayMethods.Id = 113;
            this.mnuSPayMethods.Name = "mnuSPayMethods";
            this.mnuSPayMethods.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSPayMethods_ItemClick);
            // 
            // mnuSDelMethod
            // 
            this.mnuSDelMethod.Caption = "Delivery Methods";
            this.mnuSDelMethod.Id = 114;
            this.mnuSDelMethod.Name = "mnuSDelMethod";
            this.mnuSDelMethod.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSDelMethod_ItemClick);
            // 
            // mnuSTax
            // 
            this.mnuSTax.Caption = "Tax Code List";
            this.mnuSTax.Id = 115;
            this.mnuSTax.Name = "mnuSTax";
            this.mnuSTax.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSTax_ItemClick);
            // 
            // mnuSCurr
            // 
            this.mnuSCurr.Caption = "Currency";
            this.mnuSCurr.Id = 116;
            this.mnuSCurr.Name = "mnuSCurr";
            this.mnuSCurr.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem17_ItemClick);
            // 
            // mnuSUOM
            // 
            this.mnuSUOM.Caption = "UOM";
            this.mnuSUOM.Id = 117;
            this.mnuSUOM.Name = "mnuSUOM";
            this.mnuSUOM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSUOM_ItemClick);
            // 
            // mnuSPackage
            // 
            this.mnuSPackage.Caption = "Package Type";
            this.mnuSPackage.Id = 118;
            this.mnuSPackage.Name = "mnuSPackage";
            this.mnuSPackage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSPackage_ItemClick);
            // 
            // mnuSShipVia
            // 
            this.mnuSShipVia.Caption = "Ship Via List";
            this.mnuSShipVia.Id = 119;
            this.mnuSShipVia.Name = "mnuSShipVia";
            this.mnuSShipVia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSShipVia_ItemClick);
            // 
            // mnuInterface
            // 
            this.mnuInterface.Caption = global::Inventory.Properties.Settings.Default.strmnuInterface;
            this.mnuInterface.Id = 62;
            this.mnuInterface.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSPointOfSales),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSChangeManagement),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSAccounting),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem9)});
            this.mnuInterface.Name = "mnuInterface";
            // 
            // mnuSPointOfSales
            // 
            this.mnuSPointOfSales.Caption = global::Inventory.Properties.Settings.Default.strmnuPointOfSales;
            this.mnuSPointOfSales.Id = 63;
            this.mnuSPointOfSales.Name = "mnuSPointOfSales";
            // 
            // mnuSChangeManagement
            // 
            this.mnuSChangeManagement.Caption = "Contact Management (Developing)";
            this.mnuSChangeManagement.Id = 64;
            this.mnuSChangeManagement.Name = "mnuSChangeManagement";
            // 
            // mnuSAccounting
            // 
            this.mnuSAccounting.Caption = "Accounting (Developing)";
            this.mnuSAccounting.Id = 65;
            this.mnuSAccounting.Name = "mnuSAccounting";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = global::Inventory.Properties.Settings.Default.strmnuWebsite;
            this.barButtonItem9.Id = 88;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // mnuRG
            // 
            this.mnuRG.Caption = "Report";
            this.mnuRG.Id = 103;
            this.mnuRG.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSReport)});
            this.mnuRG.Name = "mnuRG";
            // 
            // mnuSReport
            // 
            this.mnuSReport.Caption = "Report Generator";
            this.mnuSReport.Id = 104;
            this.mnuSReport.Name = "mnuSReport";
            this.mnuSReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSReport_ItemClick);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Caption = global::Inventory.Properties.Settings.Default.strmnuHelp;
            this.mnuHelp.Id = 66;
            this.mnuHelp.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSContents),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSAbout)});
            this.mnuHelp.Name = "mnuHelp";
            // 
            // mnuSContents
            // 
            this.mnuSContents.Caption = global::Inventory.Properties.Settings.Default.strmnuContents;
            this.mnuSContents.Id = 67;
            this.mnuSContents.Name = "mnuSContents";
            // 
            // mnuSAbout
            // 
            this.mnuSAbout.Caption = global::Inventory.Properties.Settings.Default.strmnuAbout;
            this.mnuSAbout.Id = 68;
            this.mnuSAbout.Name = "mnuSAbout";
            // 
            // mnuSRestore
            // 
            this.mnuSRestore.Id = 93;
            this.mnuSRestore.Name = "mnuSRestore";
            // 
            // mnuSPostPeriod
            // 
            this.mnuSPostPeriod.Caption = global::Inventory.Properties.Settings.Default.strmnuPostPeriod;
            this.mnuSPostPeriod.Id = 15;
            this.mnuSPostPeriod.Name = "mnuSPostPeriod";
            // 
            // mnuList
            // 
            this.mnuList.Caption = global::Inventory.Properties.Settings.Default.strmnuList;
            this.mnuList.Id = 31;
            this.mnuList.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem7),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem9),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem10)});
            this.mnuList.Name = "mnuList";
            // 
            // barSubItem6
            // 
            this.barSubItem6.Caption = global::Inventory.Properties.Settings.Default.strmnuItemMaster;
            this.barSubItem6.Id = 77;
            this.barSubItem6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSItems),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSBillOfMaterial)});
            this.barSubItem6.Name = "barSubItem6";
            // 
            // mnuSItems
            // 
            this.mnuSItems.Caption = global::Inventory.Properties.Settings.Default.strmnuItem;
            this.mnuSItems.Id = 32;
            this.mnuSItems.Name = "mnuSItems";
            this.mnuSItems.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSItems_ItemClick);
            // 
            // mnuSBillOfMaterial
            // 
            this.mnuSBillOfMaterial.Caption = global::Inventory.Properties.Settings.Default.strmnuBillofMaterial;
            this.mnuSBillOfMaterial.Id = 42;
            this.mnuSBillOfMaterial.Name = "mnuSBillOfMaterial";
            this.mnuSBillOfMaterial.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSBillOfMaterial_ItemClick);
            // 
            // barSubItem7
            // 
            this.barSubItem7.Caption = global::Inventory.Properties.Settings.Default.strmnuVenderMaster;
            this.barSubItem7.Id = 78;
            this.barSubItem7.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSVendor)});
            this.barSubItem7.Name = "barSubItem7";
            // 
            // mnuSVendor
            // 
            this.mnuSVendor.Caption = "Supplier";
            this.mnuSVendor.Id = 33;
            this.mnuSVendor.Name = "mnuSVendor";
            this.mnuSVendor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSVendor_ItemClick);
            // 
            // barSubItem9
            // 
            this.barSubItem9.Caption = global::Inventory.Properties.Settings.Default.strmnuCustomerMaster;
            this.barSubItem9.Id = 83;
            this.barSubItem9.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSCustomer)});
            this.barSubItem9.Name = "barSubItem9";
            // 
            // mnuSCustomer
            // 
            this.mnuSCustomer.Caption = global::Inventory.Properties.Settings.Default.strmnuCustomer;
            this.mnuSCustomer.Id = 34;
            this.mnuSCustomer.Name = "mnuSCustomer";
            this.mnuSCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSCustomer_ItemClick);
            // 
            // barSubItem10
            // 
            this.barSubItem10.Caption = global::Inventory.Properties.Settings.Default.strmnuOther;
            this.barSubItem10.Id = 84;
            this.barSubItem10.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSPaymentTerms),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSPaymentMethods),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, false, this.mnuSCustomerMessage, false),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSTaxCodeList),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSShipViaList)});
            this.barSubItem10.Name = "barSubItem10";
            // 
            // mnuSPaymentTerms
            // 
            this.mnuSPaymentTerms.Caption = global::Inventory.Properties.Settings.Default.strmnuPaymentTerms;
            this.mnuSPaymentTerms.Id = 37;
            this.mnuSPaymentTerms.Name = "mnuSPaymentTerms";
            this.mnuSPaymentTerms.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSPaymentTerms_ItemClick);
            // 
            // mnuSPaymentMethods
            // 
            this.mnuSPaymentMethods.Caption = global::Inventory.Properties.Settings.Default.strmnuPaymentMethods;
            this.mnuSPaymentMethods.Id = 38;
            this.mnuSPaymentMethods.Name = "mnuSPaymentMethods";
            this.mnuSPaymentMethods.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSPaymentMethods_ItemClick);
            // 
            // mnuSCustomerMessage
            // 
            this.mnuSCustomerMessage.Caption = global::Inventory.Properties.Settings.Default.strmnuCustomerMessage;
            this.mnuSCustomerMessage.Id = 39;
            this.mnuSCustomerMessage.Name = "mnuSCustomerMessage";
            // 
            // mnuSTaxCodeList
            // 
            this.mnuSTaxCodeList.Caption = global::Inventory.Properties.Settings.Default.strmnuTaxCodeList;
            this.mnuSTaxCodeList.Id = 40;
            this.mnuSTaxCodeList.Name = "mnuSTaxCodeList";
            this.mnuSTaxCodeList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSTaxCodeList_ItemClick);
            // 
            // mnuSShipViaList
            // 
            this.mnuSShipViaList.Caption = "Ship Via List (Developing)";
            this.mnuSShipViaList.Id = 41;
            this.mnuSShipViaList.Name = "mnuSShipViaList";
            // 
            // mnuSCustomerType
            // 
            this.mnuSCustomerType.Caption = global::Inventory.Properties.Settings.Default.strmnuCustomerType;
            this.mnuSCustomerType.Id = 35;
            this.mnuSCustomerType.Name = "mnuSCustomerType";
            // 
            // mnuSCurrency
            // 
            this.mnuSCurrency.Caption = global::Inventory.Properties.Settings.Default.strmnuCurrency;
            this.mnuSCurrency.Id = 43;
            this.mnuSCurrency.Name = "mnuSCurrency";
            this.mnuSCurrency.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSCurrency_ItemClick);
            // 
            // BarButtonItem1
            // 
            this.BarButtonItem1.Caption = "&New";
            this.BarButtonItem1.Id = 44;
            this.BarButtonItem1.Name = "BarButtonItem1";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = global::Inventory.Properties.Settings.Default.strmnuVenderType;
            this.barButtonItem5.Id = 79;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barSubItem8
            // 
            this.barSubItem8.Caption = global::Inventory.Properties.Settings.Default.strmnuWarehouse;
            this.barSubItem8.Id = 80;
            this.barSubItem8.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7)});
            this.barSubItem8.Name = "barSubItem8";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = global::Inventory.Properties.Settings.Default.strmnuWarehouse;
            this.barButtonItem6.Id = 81;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = global::Inventory.Properties.Settings.Default.strmnuLocation;
            this.barButtonItem7.Id = 82;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Settings";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 90;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barSubItem14
            // 
            this.barSubItem14.Caption = "Product Category";
            this.barSubItem14.Id = 95;
            this.barSubItem14.Name = "barSubItem14";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Backup / Restore";
            this.barButtonItem4.Id = 101;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // mnuReport
            // 
            this.mnuReport.Caption = "Report Generator";
            this.mnuReport.Id = 102;
            this.mnuReport.Name = "mnuReport";
            // 
            // mnuListOtherUOM
            // 
            this.mnuListOtherUOM.Caption = "UOM";
            this.mnuListOtherUOM.Id = 105;
            this.mnuListOtherUOM.Name = "mnuListOtherUOM";
            this.mnuListOtherUOM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuListOtherUOM_ItemClick);
            // 
            // mnuDeliveryMethod
            // 
            this.mnuDeliveryMethod.Caption = "Delivery Method (Developing)";
            this.mnuDeliveryMethod.Id = 109;
            this.mnuDeliveryMethod.Name = "mnuDeliveryMethod";
            this.mnuDeliveryMethod.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuDeliveryMethod_ItemClick);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Other";
            this.barButtonItem12.Id = 110;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.defaultLookAndFeel1.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnHelp);
            this.panelControl1.Controls.Add(this.btnPreview);
            this.panelControl1.Controls.Add(this.btnPrint);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnEdit);
            this.panelControl1.Controls.Add(this.btnNew);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(166, 22);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(543, 38);
            this.panelControl1.TabIndex = 6;
            this.panelControl1.Text = "panelControl1";
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // btnHelp
            // 
            this.btnHelp.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnHelp.ImageIndex = 5;
            this.btnHelp.ImageList = this.imageList1;
            this.btnHelp.Location = new System.Drawing.Point(271, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(32, 30);
            this.btnHelp.TabIndex = 16;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "BINOCULR.PNG");
            this.imageList1.Images.SetKeyName(1, "Delete.PNG");
            this.imageList1.Images.SetKeyName(2, "Document.PNG");
            this.imageList1.Images.SetKeyName(3, "Edit.png");
            this.imageList1.Images.SetKeyName(4, "Filter.PNG");
            this.imageList1.Images.SetKeyName(5, "Help.png");
            this.imageList1.Images.SetKeyName(6, "Preview.PNG");
            this.imageList1.Images.SetKeyName(7, "printer.PNG");
            this.imageList1.Images.SetKeyName(8, "Save.PNG");
            // 
            // btnPreview
            // 
            this.btnPreview.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnPreview.ImageIndex = 6;
            this.btnPreview.ImageList = this.imageList1;
            this.btnPreview.Location = new System.Drawing.Point(233, 4);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(32, 30);
            this.btnPreview.TabIndex = 15;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnPrint.ImageIndex = 7;
            this.btnPrint.ImageList = this.imageList1;
            this.btnPrint.Location = new System.Drawing.Point(195, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(32, 30);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSearch.ImageIndex = 0;
            this.btnSearch.ImageList = this.imageList1;
            this.btnSearch.Location = new System.Drawing.Point(158, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 30);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnDelete.ImageIndex = 1;
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(120, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 30);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnEdit.ImageIndex = 3;
            this.btnEdit.ImageList = this.imageList1;
            this.btnEdit.Location = new System.Drawing.Point(82, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(32, 30);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnNew.ImageIndex = 2;
            this.btnNew.ImageList = this.imageList1;
            this.btnNew.Location = new System.Drawing.Point(44, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(32, 30);
            this.btnNew.TabIndex = 9;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSave.Enabled = false;
            this.btnSave.ImageIndex = 8;
            this.btnSave.ImageList = this.imageList1;
            this.btnSave.Location = new System.Drawing.Point(6, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.dgrPrint});
            // 
            // dgrPrint
            // 
            this.dgrPrint.PrintingSystem = this.printingSystem1;
            // 
            // tvMenu
            // 
            this.tvMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvMenu.Location = new System.Drawing.Point(0, 22);
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.Size = new System.Drawing.Size(160, 319);
            this.tvMenu.TabIndex = 8;
            this.tvMenu.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvMenu_NodeMouseDoubleClick);
            this.tvMenu.Click += new System.EventHandler(this.tvMenu_Click);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(160, 22);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 319);
            this.splitterControl1.TabIndex = 9;
            this.splitterControl1.TabStop = false;
            // 
            // grdCustomer
            // 
            this.grdCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCustomer.EmbeddedNavigator.Name = "";
            this.grdCustomer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grdCustomer.Location = new System.Drawing.Point(166, 60);
            this.grdCustomer.MainView = this.gridView1;
            this.grdCustomer.Name = "grdCustomer";
            this.grdCustomer.Size = new System.Drawing.Size(543, 281);
            this.grdCustomer.TabIndex = 10;
            this.grdCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            this.grdCustomer.DoubleClick += new System.EventHandler(this.grdCustomer_DoubleClick);
            this.grdCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdCustomer_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdCustomer;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdCustomer;
            this.gridView2.Name = "gridView2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 341);
            this.Controls.Add(this.grdCustomer);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.tvMenu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strInventory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = global::Inventory.Properties.Settings.Default.strInventory;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Old Codes

        private BL_Customer blCustomer;
        PrintableComponentLink CustomerPrint;
        private int currentGrid = 0; // 0 = customer, 1 = supplier
        private void mnuSUserGroupSecurity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserGroupSecur frm = new UserGroupSecur();
            frm.ShowDialog(this);
            
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            doLanguageSettings();
        }
        private void doLanguageSettings()
        {
            LangSettings frm = new LangSettings();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                Globals.canExit = false;
                this.Close();
            }
        }
        private void MakeTVMenu()
        {            
            foreach (LinkPersistInfo nod in bar1.LinksPersistInfo)
            {
                TreeNode tn = tvMenu.Nodes.Add(nod.Item.Caption);

                BarSubItem bs = (BarSubItem)nod.Item;

                MakeTVItem(bs, tn);
            }

        }
        private void MakeTVItem(BarItem parent, TreeNode tnPar)
        {
            
            if (parent == null) return;
            if (parent is BarSubItem)
            {
                foreach (LinkPersistInfo nod in ((BarSubItem)parent).LinksPersistInfo)
                {
                    TreeNode tn = tnPar.Nodes.Add(nod.Item.Caption);
                    MakeTVItem(nod.Item, tn);
                    
                }

            }           

        }
        private GridView viewTemp;
        private DataTable tblCustomer;        
        private List<string> lstDeleteCustomer;
        private List<string> lstDeleteSupplier;
        private DataTable tblSupplier;
        private GridView gvSupplier;

        private const int SHOW_CUSTOMER = 0;
        private const int SHOW_SUPPLIER = 1;
        private const int SHOW_PURCHASE_ORDER = 3;
        private const int SHOW_SALE_ORDER = 4;
        private const int SHOW_DELIVERY_NOTE = 5;
        private const int SHOW_PICKING_LIST = 6;
        private const int SHOW_PACKING_LIST = 7;
        private const int SHOW_STOCK_TRANSFER = 8;
        private const int SHOW_INVENTORY_ADJUSTMENT = 9;
        private const int SHOW_PRODUCT = 10;
        private const int SHOW_BARCODE = 13;
        private const int SHOW_STOCK_IN = 11;
        private const int SHOW_STOCK_OUT = 12;
        private const int SHOW_PRODUCT_CATEGORY = 14;
        private const int SHOW_PRODUCT_FAMILY = 15;
        private const int SHOW_BOM = 16;
        private const int SHOW_INVENTORY_UPDATE = 17;
        private const int SHOW_PHYSICAL_TAKE = 18;
        private const int SHOW_WORK_ORDER = 19;
        private const int SHOW_PAYMENT_METHOD = 20;
        private const int SHOW_RECEIVED_GOOD = 21;
        private const int SHOW_CUSTOMER_PAYMENT = 22;
        private const int SHOW_VENDOR_PAYMENT = 23;

        private void LoadCustomerTab(DataTable tab)
        {
            currentGrid = SHOW_CUSTOMER;
            //System.Data.DataView v = new DataView(tab);
            //v.RowFilter = "[Last Name] LIKE '%s%'";
            if (grdCustomer.Views.Count > 0) ((GridView)grdCustomer.Views[0]).Columns.Clear();
            grdCustomer.DataSource = tab;

            GridView gridView = (GridView)grdCustomer.Views[0];
            viewTemp = gridView;


            //gridView.Columns[0].Visible = false;
            //gridView.Columns[1].Width = 30;
            //gridView.ScrollStyle = ScrollStyleFlags.LiveVertScroll | ScrollStyleFlags.LiveHorzScroll;
            //gvCustomer.Columns[0].FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;

            foreach (GridColumn cl in gridView.Columns)
            {
                cl.Visible = false;
                cl.MinWidth = 10;
                cl.AppearanceHeader.Font = Settings.Default.cfgDefaultFont;
                cl.AppearanceCell.Font = Settings.Default.cfgDefaultFont;
            }

            //gridView.Columns["Last Name"].VisibleIndex = 1;
            //gridView.Columns["Middle Name"].VisibleIndex = 2;
            //gridView.Columns["First Name"].VisibleIndex = 3;
            gridView.Columns["Customer ID"].VisibleIndex = 1;
            gridView.Columns["Company Name"].VisibleIndex = 2;
            gridView.Columns["Email Name"].VisibleIndex = 3;
            //gridView.Columns["Email Name"].VisibleIndex = 4;
            //gridView.Columns["Company Name"].VisibleIndex = 6;
            gridView.Columns["Phone 1"].VisibleIndex = 4;


            //gridView.Columns["Mr"].Visible = true;
            //gridView.Columns["Last Name"].Visible = true;
            //gridView.Columns["Middle Name"].Visible = true;
            //gridView.Columns["First Name"].Visible = true;
            gridView.Columns["Customer ID"].Visible = true;
            gridView.Columns["Company Name"].Visible = true;
            gridView.Columns["Email Name"].Visible = true;
            //gridView.Columns["Contact Name"].Visible = true;
            //gridView.Columns["Company Name"].Visible = true;
            gridView.Columns["Phone 1"].Visible = true;



        }

        private void loadCustomer()
        {
            blCustomer = new BL_Customer();
            BL_Customer customer =blCustomer;
            if (customer == null) return;
            tblCustomer = customer.View().Tables[0].Copy();
            tblCustomer.Columns.Add("RecStatus", typeof(int));
            tblCustomer.Columns.Add("CatRef", typeof(CategoryRec[]));
            LoadCustomerTab(tblCustomer);
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

           /* System.Globalization.NumberFormatInfo n = new System.Globalization.CultureInfo("en-US", false).NumberFormat;// new System.Globalization.NumberFormatInfo();
            
            
            n.NumberGroupSeparator = " ";
            n.NumberDecimalSeparator = ",";
            n.NumberGroupSeparator = ".";
            
            textEdit1.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            textEdit1.Properties.DisplayFormat.Format = n;
            textEdit1.Properties.DisplayFormat.FormatString = "N0";

            textEdit1.Properties.EditFormat.FormatType = FormatType.Numeric;
            
            textEdit1.Properties.EditFormat.Format = n;
            
            //Int64 i = 123456;
            ///MessageBox.Show(i.ToString("N", n));
            */
            

            CatUpdatedList = new List<CategoryRec[]>();
            blCustomer = new BL_Customer();

            Globals.SetDefaultFont(this);
            loadCustomer();
            currentGrid = SHOW_CUSTOMER;
            lstDeleteCustomer = new List<string>();
            lstDeleteSupplier = new List<string>();
            //tvMenu.Nodes.Clear();
            MakeTVMenu();
            CustomerPrint = new PrintableComponentLink(this.components);
            CustomerPrint.PrintingSystem = printingSystem1;
            CustomerPrint.Component = grdCustomer;

            Toolkit.DbToolKit.ConnectionString = Globals.strVISConnection;
            //Search frm = new Search();
            //frm.ShowDialog(this);
            //foreach (Object ob in gvCustomer.AppearancePrint.Preview) { }
            
            //gvCustomer.AppearancePrint.p
            //pageSetupDialog1.ShowDialog();
         /*   Object obj = this.Container;
            
            obj = this.components.Components[0];
            for (int i = 0; i < this.Controls.Count; i++ )
                obj = this.Controls[i];
            //printDialog1.ShowDialog();
            obj = ConfigurationManager.AppSettings;
            obj = global::Inventory.Properties.Settings.Default;
            string s = "";
            s =Settings.Default.Properties["hey a"].DefaultValue.ToString();
            */
           // foreach (Object sp in Settings.Default.Properties)
           // {
             //   s += sp.Name + "\n\r";
           // }/**/
            //Settings.Default.btnOK = "nghienpc";
            //Settings.Default.Save();

            this.CheckRunReorderProcess();
        }

        void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Exception ex = e.Exception;
            string strMessage = ex.Message;
            while (ex.InnerException != null)
            {
                strMessage += Environment.NewLine + ex.InnerException.Message;
                ex = ex.InnerException;
            }

            MessageBox.Show(strMessage, "Error");
        }

        private void loadSupplierTab(DataTable tab)
        {
            currentGrid = SHOW_SUPPLIER;
            if (grdCustomer.Views.Count > 0) ((GridView)grdCustomer.Views[0]).Columns.Clear();

            grdCustomer.DataSource = tab;

            GridView gridView = (GridView)grdCustomer.Views[0];
            gvSupplier = gridView;
            foreach (GridColumn cl in gridView.Columns)
            {
                cl.Visible = false;
                cl.MinWidth = 10;
                cl.AppearanceHeader.Font = Settings.Default.cfgDefaultFont;
                cl.AppearanceCell.Font = Settings.Default.cfgDefaultFont;
            }
            gridView.OptionsBehavior.Editable = false;
            //gridView.Columns["Mr"].VisibleIndex = 0;

            //gridView.Columns["Last Name"].VisibleIndex = 1;
            //gridView.Columns["Middle Name"].VisibleIndex = 2;
            //gridView.Columns["First Name"].VisibleIndex = 3;
            gridView.Columns["Supplier ID"].VisibleIndex = 1;
            gridView.Columns["Company Name"].VisibleIndex = 2;
            //gridView.Columns["Company Name"].Caption = "Company Name";
            gridView.Columns["Email Name"].VisibleIndex = 3;
            //gridView.Columns["Email Name"].VisibleIndex = 4;
            //gridView.Columns["Company Name"].VisibleIndex = 6;
            gridView.Columns["Phone 1"].VisibleIndex = 4;


            //gridView.Columns["Mr"].Visible = true;
            //gridView.Columns["Last Name"].Visible = true;
            //gridView.Columns["Middle Name"].Visible = true;
            //gridView.Columns["First Name"].Visible = true;
            gridView.Columns["Supplier ID"].Visible = true;
            gridView.Columns["Company Name"].Visible = true;
            gridView.Columns["Email Name"].Visible = true;
            //gridView.Columns["Contact Name"].Visible = true;
            //gridView.Columns["Company Name"].Visible = true;
            gridView.Columns["Phone 1"].Visible = true;


            //gridView.Columns["Mr"].Width = 20;
        }

        private void loadSupplier()
        {

            BL_Supplier supplier = new BL_Supplier();
            if (supplier == null) return;
            tblSupplier = supplier.View().Tables[0].Copy();
            tblSupplier.Columns.Add("RecStatus", typeof(int));
            tblSupplier.Columns.Add("CatRef", typeof(CategoryRec[]));
            loadSupplierTab(tblSupplier);
        }
        private void SaveDataSupplier()
        {
            /*
            if (tblSupplier == null) return;
            // cap nhat thong tin
            DataRow[] rows = tblSupplier.Select("RecStatus = 1 OR RecStatus = 2");
            BL_Supplier blSupplier = new BL_Supplier();
            Supplier sup = new Supplier();
            DA_Category daCategory = new DA_Category();
            foreach (DataRow row in rows)
            {
                sup.AssignDataRow(row);
                if (row["RecStatus"].ToString() == "1")
                {
                    blSupplier.Add(sup);

                }
                else if (row["RecStatus"].ToString() == "2") blSupplier.Update(sup);
                try
                {
                    CategoryRec[] cats = (CategoryRec[])row["CatRef"];
                    if (cats != null)
                    {
                        for (int i = 0; i < cats.Length; i++)
                            if (cats[i].status == 1) // add new
                                daCategory.Add(cats[i].ContactCatID, row["Contact ID"].ToString());
                            else if (cats[i].status == -1) // delete
                                daCategory.Delete(cats[i].ContactCatID, row["Contact ID"].ToString());
                    }
                }
                catch { }
             * 
            }

            foreach (string s in lstDeleteSupplier)
            {
                blSupplier.Delete(s);
                daCategory.Delete(s);
            }
            lstDeleteSupplier.Clear();
            */
        }

        private void newSupplier()
        {
            //if (Globals.CheckAccessRights(Globals.UserID,"25718886-82C9-41EC-A63C-E0025D6E082D",true))
            {

                AddEditSupplier frmSupplier = new AddEditSupplier("", "Add");
                frmSupplier.ShowDialog();
                loadSupplier();

            }

/*
            ModifySupplier frm = new ModifySupplier();
            if (frm.ShowDialog(this) != DialogResult.OK) return;
            Supplier sup = frm.SupplierData;
            tblSupplier.NewRow();
            gvSupplier.AddNewRow();
            gvSupplier.RefreshData();
            DataRow row = ((DataRowView)gvSupplier.GetRow(gvSupplier.RowCount - 1)).Row;
            sup.ToDataRow(row);// gan du lieu vao
            row["RecStatus"] = 1; //create new;
            row["Contact ID"] = ContactBase.GetID();
            row["CatRef"] = frm.Categories;
 
            SetModified(true);
 */
        }


        private void editSupplier()
        {

            if (gvSupplier.RowCount <= 0) return;
            int r = gvSupplier.GetSelectedRows()[0];// lay hang hien tai
            DataRow row = ((DataRowView)gvSupplier.GetRow(r)).Row;
  

            string cellValue = row["Contact ID"].ToString();
            //if (Globals.CheckAccessRights(Globals.UserID,"DB1FAF0A-A936-40D2-AE92-92987E78E700",true))
            {
                AddEditSupplier frmSupplier = new AddEditSupplier(cellValue, "Edit");
                frmSupplier.ShowDialog();
                loadSupplier();
            }
            /*
            if (gvSupplier.RowCount <= 0) return;
            int r = gvSupplier.GetSelectedRows()[0];// lay hang hien tai

            DataRow row = ((DataRowView)gvSupplier.GetRow(r)).Row;
            ModifySupplier frm = new ModifySupplier();
            Supplier sup = new Supplier();
            sup.AssignDataRow(row);
            try { frm.Categories = (CategoryRec[])row["CatRef"]; }
            catch { frm.Categories = null; }
            frm.SupplierData = sup;
            
            if (frm.ShowDialog(this) != DialogResult.OK) return;
            sup = frm.SupplierData;
            sup.ToDataRow(row);
            row["RecStatus"] = 2; //Modified;
            row["CatRef"] = frm.Categories;
            SetModified(true);
             */
        }
        private void DeleteSupplier()
        {

            if (gvSupplier.GetSelectedRows() == null) return;
            if (gvSupplier.GetSelectedRows().Length <= 0) return;
            int r = gvSupplier.GetSelectedRows()[0];// lay hang hien tai
            if (r < 0) return;
            if (gvSupplier.RowCount <= 0) return;
            if (MessageBox.Show(this, Settings.Default.strWarningDelete, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            DataRow row = ((DataRowView)gvSupplier.GetRow(r)).Row;
            DeleteSQL del = new DeleteSQL(new SqlConnection(Globals.strVISConnection));
            del.deleteCustomer(row["Contact ID"].ToString());
            loadSupplier();
        }

        private void searchSuppliers()
        {
            if (isModified)
                if (MessageBox.Show(this, "Do you want to save?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SaveData();
                    SaveDataSupplier();
                }
            Search frm = new Search();
            frm.setTable("VlistCustomers");
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    Data_Access.DoSqlCommand("SELECT * FROM VListSuppliers WHERE " + frm.getSearchStr());
                    tblSupplier = Data_Access.GetDataSet().Tables[0].Copy();
                    tblSupplier.Columns.Add("RecStatus", typeof(int));
                    tblSupplier.Columns.Add("CatRef", typeof(CategoryRec[]));
                    loadSupplierTab(tblSupplier);
                }
                catch { }
            }
        }
        private void SaveData()
        {
            /*
            DataRow[] rows = tblCustomer.Select("RecStatus = 1 OR RecStatus = 2");
            BL_Customer blCustomer = new BL_Customer();
            Customer cus = new Customer();
            DA_Category daCategory = new DA_Category();
            foreach (DataRow row in rows)
            {
                cus.AssignDataRow(row);
                if (row["RecStatus"].ToString() == "1")
                {
                    blCustomer.Add(cus);
                }
                else if (row["RecStatus"].ToString() == "2") blCustomer.Update(cus);
                try
                {
                    CategoryRec[] cats = (CategoryRec[])row["CatRef"];
                    if (cats != null)
                    {
                        for (int i = 0; i < cats.Length; i++)
                            if (cats[i].status == 1) // add new
                                daCategory.Add(cats[i].ContactCatID, row["Contact ID"].ToString());
                            else if (cats[i].status == -1) // delete
                                daCategory.Delete(cats[i].ContactCatID, row["Contact ID"].ToString());
                    }
                }
                catch (Exception e){ }
            }
           
            foreach (string s in lstDeleteCustomer)
            {
                daCategory.Delete(s); // xoa trong bang ContactCategory
                blCustomer.Delete(s);
            }
            lstDeleteCustomer.Clear();            
            */

        }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            CustomerPrint.PrintDlg();
            
            //doPrintSetup();
            
        }
        private void doPrintSetup()
        {
            printDialog1.Document = new PrintDocument();

            printDialog1.ShowDialog();

            //dgrPrint.DataGrid = 
            //printingSystem1.PrintDlg();
        }
        private void mnuSPageSetup_ItemClick(object sender, ItemClickEventArgs e)
        {

            CustomerPrint.EnablePageDialog = true;
            printingSystem1.PageSetup();
            //doPageSetup();
        }
        private void doPageSetup()
        {
            //grdCustomer.ShowPrintPreview();
            //grdCustomer.ShowPreview();
            PrintDocument prdoc = new PrintDocument();
            pageSetupDialog1.Document = prdoc;

            PrintableComponentLink prt = new PrintableComponentLink(this.components);
            prt.Component = grdCustomer;
            prt.PrintingSystem = printingSystem1;
            prt.EnablePageDialog = true;
            prt.PrintingSystem.PageSetup();
            //prdoc.Site = grdCustomer;
            //gvCustomer.AppearancePrint.
            //pageSetupDialog1.ShowDialog();
            
            //printingSystem1.
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            CustomerPrint.ShowPreview();
         //   grdCustomer.ShowPrintPreview();
            /*PrintPreview pr = new PrintPreview();
            pr.SetDataGrid(grdCustomer);
            pr.ShowDialog();
              */                    
        }
        private void SetModified(bool status)
        {
            if (status == isModified) return;
            isModified = status;
            btnSave.Enabled = status;
        }
        private void newPurchaseOrder()
        {
            //Ghep noi voi module cua Dung tai day
            //ModifyCustomer frm = new ModifyCustomer();
            //if (frm.ShowDialog(this) != DialogResult.OK) return;

            t_Purchase_Order_HeaderRec pur = new t_Purchase_Order_HeaderRec();//frm.CustomerData;
            
            //pur.ShipTo = "new ship";
            pur.PODate = DateTime.Now;
            pur.LastUpdatedDate = DateTime.Now;
            pur.CreatedDate = DateTime.Now;
            pur.DeliveryDate = DateTime.Now;
            //pur.PONo = ContactBase.GetID();
            pur.CreatedBy = Globals.UserID;
            pur.LastUpdatedBy = Globals.UserID;
            // hien form tai day
            PO_Form frm = new PO_Form();
            frm.PurchaseOrder = pur;
            if (frm.ShowDialog(this) != DialogResult.OK) return;
            pur = frm.PurchaseOrder;

            if (gvPurchaseOrder.DataSource is DataView) // neu vua moi search xong
            {
                dvPurchaseOrder.RowFilter = "";
                //dvPurchaseOrder.RowStateFilter = DataViewRowState.Added;
            }
            gvPurchaseOrder.AddNewRow();
            gvPurchaseOrder.UpdateCurrentRow();
            DataRow row = ((DataRowView)gvPurchaseOrder.GetRow(gvPurchaseOrder.RowCount - 1)).Row;
            gvPurchaseOrder.RefreshData();
            
            pur.AssignToDataRow(row);            
            SetModified(true);
            //row["PONo"] = ContactBase.GetID();
            
        }
        private void newSaleOrder()
        {
            //Ghep noi voi module cua Dung tai day
            //ModifyCustomer frm = new ModifyCustomer();
            //if (frm.ShowDialog(this) != DialogResult.OK) return;

            t_Sales_Order_HeaderRec sale = new t_Sales_Order_HeaderRec(); //frm.CustomerData;

            //sale.PayAmount = 132;
            
            sale.LastUpdatedDate = DateTime.Now;
            sale.CreatedDate = DateTime.Now;
            sale.SODate = DateTime.Now;
            sale.CreatedBy = Globals.UserID;
            sale.LastUpdatedBy = Globals.UserID;
            SO_Form frm = new SO_Form();
            frm.SaleOrder = sale;
            if (frm.ShowDialog(this) != DialogResult.OK) return;
            sale = frm.SaleOrder;

            if (gvSaleOrder.DataSource is DataView) // neu vua moi search xong
            {
                dvSaleOrder.RowFilter = "";                
            }
            gvSaleOrder.AddNewRow();
            gvSaleOrder.UpdateCurrentRow();
            DataRow row = ((DataRowView)gvSaleOrder.GetRow(gvSaleOrder.RowCount - 1)).Row;
            sale.AssignToDataRow(row);
            SetModified(true);
            //row["SONo"] = ContactBase.GetID();

        }
        private void newCustomer()
        {
            AddEditCustomer frmCustomer = new AddEditCustomer("", "Add");
            if (frmCustomer.ShowDialog() == DialogResult.OK)
            {
                //refresh list                
                loadCustomer(); 
            }
            /*
            Customer cus = frm.CustomerData;
            //blCustomer.Add(cus);                
            tblCustomer.NewRow();
            viewTemp.AddNewRow();
            viewTemp.RefreshData();
            DataRow row = ((DataRowView)viewTemp.GetRow(viewTemp.RowCount - 1)).Row;
            row["RecStatus"] = 1; //create new;            
            cus.ToDataRow(row);// gan du lieu vao
            SetModified(true);
            row["Contact ID"] = ContactBase.GetID();
            row["CatRef"] = frm.Categories;
            */
        }
        private List<CategoryRec[]> CatUpdatedList;


        private void editPurchaseOrder()
        {
            int r = getAndCheckSelectedRow(gvPurchaseOrder);
            if (r < 0) return;
            DataRow row = ((DataRowView)gvPurchaseOrder.GetRow(r)).Row;
            t_Purchase_Order_HeaderRec pur = new t_Purchase_Order_HeaderRec(row);

            // hien form tai day
            PO_Form frm = new PO_Form();
            frm.PurchaseOrder = pur;
            if (frm.ShowDialog(this) != DialogResult.OK) return;
            pur = frm.PurchaseOrder;
            //pur.ShipTo = "hey";
            pur.LastUpdatedBy = Globals.UserID;
            pur.LastUpdatedDate = DateTime.Now;
            pur.AssignToDataRow(row);            
            gvPurchaseOrder.RefreshData();            
            SetModified(true);
        }
        private void editSaleOrder()
        {
            int r = getAndCheckSelectedRow(gvSaleOrder);
            if (r < 0) return;
            DataRow row = ((DataRowView)gvSaleOrder.GetRow(r)).Row;
            t_Sales_Order_HeaderRec rec = new t_Sales_Order_HeaderRec(row);
            //rec.ShopID = "ggg";
            /* hien form tai day
            */
            SO_Form frm = new SO_Form();
            frm.SaleOrder = rec;
            if (frm.ShowDialog(this) != DialogResult.OK) return;

            rec = frm.SaleOrder;
            rec.LastUpdatedDate = DateTime.Now;
            rec.LastUpdatedBy = Globals.UserID;
            rec.AssignToDataRow(row);
            
            gvSaleOrder.RefreshData();
            SetModified(true);
        }
        private void editCustomer()
        {
            if (viewTemp.RowCount <= 0) return;
            int r = viewTemp.GetSelectedRows()[0];
            DataRow row = ((DataRowView)viewTemp.GetRow(r)).Row;
            bool blnHasRights = false;

            string cellValue = row["Contact ID"].ToString();
         // if (Globals.CheckAccessRights(Globals.UserID,"DB1FAF0A-A936-40D2-AE92-92987E78E700",true))
            {
                blnHasRights = true;
                AddEditCustomer frmCustomer = new AddEditCustomer(cellValue, "Edit");
                frmCustomer.ShowDialog();
                loadCustomer();
            }
            
            /*
            if (viewTemp.RowCount <= 0) return;
            int r = viewTemp.GetSelectedRows()[0];// lay hang hien tai
            DataRow row = ((DataRowView)viewTemp.GetRow(r)).Row;
            ModifyCustomer frm = new ModifyCustomer();
            Customer cus = new Customer();
            cus.AssignDataRow(row);
            try { frm.Categories = (CategoryRec[])(row["CatRef"]); }
            catch { frm.Categories = null; }
            frm.CustomerData = cus;
            
            
            if (frm.ShowDialog(this) != DialogResult.OK) return;
            cus = frm.CustomerData;
            cus.ToDataRow(row);
            row["RecStatus"] = 2; //Modified;
            SetModified(true);
            row["CatRef"] = frm.Categories;
             */
            
            
        }
        private int getAndCheckSelectedRow(GridView gv)
        {
            if (gv == null) return -1;
            if (gv.GetSelectedRows() == null) return -1;
            if (gv.GetSelectedRows().Length <= 0) return -1;
            int r = gv.GetSelectedRows()[0];// lay hang hien tai
            if (r < 0) return -1;
            if (gv.RowCount <= 0) return -1;
            return r;
        }
        private void DeletePurchaseOrder()
        {
            int row = getAndCheckSelectedRow(gvPurchaseOrder);
            if ( row < 0) return;
            if (MessageBox.Show(this, Settings.Default.strWarningDelete, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            DataRow field = ((DataRowView)gvPurchaseOrder.GetRow(row)).Row;
            t_Purchase_Order_HeaderRec rec = new t_Purchase_Order_HeaderRec(field);
            DataRow[] rows = Globals.purchaseOrderDetailTable.Select("PONo = '" + rec.PONo + "'");
            for (int i = 0; i < rows.Length; i++) rows[i].Delete();

            gvPurchaseOrder.DeleteRow(row);
            SetModified(true);
        }
        private void DeleteSaleOrder()
        {
            int row = getAndCheckSelectedRow(gvSaleOrder);
            if (row < 0) return;
            if (MessageBox.Show(this, Settings.Default.strWarningDelete, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            DataRow field = ((DataRowView)gvSaleOrder.GetRow(row)).Row;
            t_Sales_Order_HeaderRec rec = new t_Sales_Order_HeaderRec(field);
            DataRow[] rows = Globals.salesOrderDetailTable.Select("SONo = '" + rec.SONo + "'");
            for (int i = 0; i < rows.Length; i++) rows[i].Delete();

            gvSaleOrder.DeleteRow(row);
            SetModified(true);
        }
        private void DeleteCustomer()
        {
            if (viewTemp.GetSelectedRows() == null) return;
            if (viewTemp.GetSelectedRows().Length <= 0) return;
            int r = viewTemp.GetSelectedRows()[0];// lay hang hien tai
            if (r < 0) return;
            if (viewTemp.RowCount <= 0) return;

            if (MessageBox.Show(this, Settings.Default.strWarningDelete, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            return;
            DeleteSQL del = new DeleteSQL(new SqlConnection(Globals.strVISConnection));
            DataRow row = ((DataRowView)viewTemp.GetRow(r)).Row;
            del.deleteCustomer(row["Contact ID"].ToString());
            loadCustomer();
            /*
            DataRow row = ((DataRowView)viewTemp.GetRow(r)).Row;
            lstDeleteCustomer.Add(row["Contact ID"].ToString());

            row.Delete();
            
            viewTemp.RefreshData();
            SetModified(true);
            */
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (currentGrid == SHOW_CUSTOMER)
                searchCustomers();
            else if (currentGrid == SHOW_SUPPLIER)
                searchSuppliers();
            else if (currentGrid == SHOW_PURCHASE_ORDER)
                searchPurchaseOrders();
            else if (currentGrid == SHOW_PURCHASE_ORDER)
                searchSaleOrder();
        }
        private void searchPurchaseOrders()
        {
            AskSave();
            Search frm = new Search();
            frm.setTable("t_Purchase_Order_Header");
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                loadPurchaseOrder(frm.getSearchStr());
            }
        }
        private void searchSaleOrder()
        {
            AskSave();
            Search frm = new Search();
            frm.setTable("t_Sales_Order_Header");
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                loadSaleOrder(frm.getSearchStr());
            }
        }
        private void searchCustomers()
        {
            AskSave();
            Search frm = new Search();
            frm.setTable("VListCustomers");
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                Data_Access.DoSqlCommand("SELECT * FROM VListCustomers WHERE " + frm.getSearchStr());
                try
                {
                    tblCustomer = Data_Access.GetDataSet().Tables[0].Copy();
                    tblCustomer.Columns.Add("RecStatus", typeof(int));
                    tblCustomer.Columns.Add("CatRef", typeof(CategoryRec[]));
                    LoadCustomerTab(tblCustomer);
                }
                catch { }
            }
        }

        private void tvMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void tvMenu_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text == Settings.Default.strmnuLanguageSetting)
                doLanguageSettings();
            else if (e.Node.Text == Settings.Default.strmnuSystemParam)
                doSystemParam();
            else if (e.Node.Text == Settings.Default.strmnuVender && e.Node.Parent != null && e.Node.Parent.Text == Settings.Default.strmnuVenderMaster)
                ShowSuppliers();
            else if (e.Node.Text == Settings.Default.strmnuPageSetup)
                doPageSetup();
            else if (e.Node.Text == Settings.Default.strmnuPrinterSetup)
                doPrintSetup();
            else if (e.Node.Text == Settings.Default.strmnuCustomer && e.Node.Parent != null && e.Node.Parent.Text == Settings.Default.strmnuCustomerMaster)
            {
                AskSave();
                loadCustomer();
            }
            else if (e.Node.Text == Settings.Default.strmnuPurchaseOrder)
                showPurchaseOrder();
            else if (e.Node.Text == Settings.Default.strmnuSalesOrders)
                showSaleOder();
                
        }
        private void ShowSuppliers()
        {
            AskSave();
            loadSupplier();
          /*  Suppliers frm = new Suppliers();
            frm.ShowDialog(this);*/
        }
        private void barButtonItem3_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            doSystemParam();
        }
        private void doSystemParam()
        {
            FormatSettings frm = new FormatSettings();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                Globals.canExit = false;
                this.Close();
            }
        }
        private void AskSave()
        {
            if (isModified)
                if (MessageBox.Show(this, "Do you want to save?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SaveData();
                    SaveDataSupplier();
                    SetModified(false);
               }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AskSave();
        }

        private void mnuSCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {            
           loadCustomer();            
        }

        private void mnuSVendor_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowSuppliers();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textEdit1.Text);
        }

        private void textEdit1_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
           
        }

        private void textEdit1_FormatEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            
        }

        private void mnuSPurchaseOrders_ItemClick(object sender, ItemClickEventArgs e)
        {
            showPurchaseOrder();
        }
        private GridView gvPurchaseOrder;
        private GridView gvSaleOrder;
        private void showPurchaseOrder()
        {
            currentGrid = SHOW_PURCHASE_ORDER;                       
            
            
            //grdCustomer.DataSource = Globals.purchaseOrderHeaderTable;
            //gvPurchaseOrder.Columns[0].Visible = false;
            loadPurchaseOrder("");
        }
        private DataView dvPurchaseOrder;
        private DataView dvSaleOrder;
        private void loadPurchaseOrder(string strFilter)
        {

            gvPurchaseOrder = (GridView)grdCustomer.Views[0];
            gvPurchaseOrder.Columns.Clear();
            DataView view = new DataView(Globals.purchaseOrderHeaderTable);
            view.RowFilter = strFilter;            
            grdCustomer.DataSource = view;
            dvPurchaseOrder = view;
            gvPurchaseOrder = (GridView)grdCustomer.Views[0];
            foreach (GridColumn cl in gvPurchaseOrder.Columns)
            {
                cl.MinWidth = 10;
                cl.Visible = false;
            }
            gvPurchaseOrder.Columns["PODate"].Visible = true;
            gvPurchaseOrder.Columns["PODate"].DisplayFormat.FormatType = FormatType.DateTime;
            gvPurchaseOrder.Columns["PODate"].DisplayFormat.FormatString = Settings.Default.cfgDateFormat;

            gvPurchaseOrder.Columns["DeliveryDate"].Visible = true;
            gvPurchaseOrder.Columns["DeliveryDate"].DisplayFormat.FormatType = FormatType.DateTime;
            gvPurchaseOrder.Columns["DeliveryDate"].DisplayFormat.FormatString = Settings.Default.cfgDateFormat;
            gvPurchaseOrder.Columns["ShipTo"].Visible = true;
            gvPurchaseOrder.Columns["TotalAmt"].Visible = true;

            gvPurchaseOrder.Columns["PODate"].VisibleIndex = 0;
            gvPurchaseOrder.Columns["DeliveryDate"].VisibleIndex = 1;
            gvPurchaseOrder.Columns["ShipTo"].VisibleIndex = 2;
            gvPurchaseOrder.Columns["TotalAmt"].VisibleIndex = 3;

        }

        private void showSaleOder()
        {
            currentGrid = SHOW_SALE_ORDER;
            loadSaleOrder("");
            
        }
        private void loadSaleOrder(string strFilter)
        {
            gvSaleOrder = (GridView)grdCustomer.Views[0];
            gvSaleOrder.Columns.Clear();
            dvSaleOrder = new DataView(Globals.salesOrderHeaderTable);
            dvSaleOrder.RowFilter = strFilter;
            grdCustomer.DataSource = dvSaleOrder;
//            gvSaleOrder = (GridView)grdCustomer.Views[0];
            foreach (GridColumn cl in gvSaleOrder.Columns)
            {
                cl.MinWidth = 10;
                cl.Visible = false;
            }
            gvSaleOrder.Columns["SODate"].Visible = true;            
            gvSaleOrder.Columns["PayAmount"].Visible = true;
            gvSaleOrder.Columns["OSAmount"].Visible = true;
            gvSaleOrder.Columns["Discount"].Visible = true;

            gvSaleOrder.Columns["SODate"].VisibleIndex = 0;            
            gvSaleOrder.Columns["PayAmount"].VisibleIndex = 1;
            gvSaleOrder.Columns["OSAmount"].VisibleIndex = 2;
            gvSaleOrder.Columns["Discount"].VisibleIndex = 3;
        }
        private void mnuSSalesOrders_ItemClick(object sender, ItemClickEventArgs e)
        {
            showSaleOder();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        #endregion

        #region Button Events

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData();
                SaveDataSupplier();
                Globals.purchaseOrderDetailTable.Update();
                Globals.purchaseOrderHeaderTable.Update();
                Globals.salesOrderDetailTable.Update();
                Globals.salesOrderHeaderTable.Update();                
            }
            catch { }
            SetModified(false);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            /*
             * Codes add by DuongDN 13 May to support delivery note
             * packing list and picking list
             * 
             * */
            /*
            switch (CurrentTab)
            {
                case DisplayedTabs.DeliveryNotes:
                    Command comm = new NewDeliveryNoteCommand();
                    comm.Execute();
                    break;
            }
            */

            
            if (currentGrid == SHOW_CUSTOMER)
                newCustomer();
            else if (currentGrid == SHOW_SUPPLIER)
                newSupplier();
            else if (currentGrid == SHOW_PURCHASE_ORDER)
                newPurchaseOrder();
            else if (currentGrid == SHOW_SALE_ORDER)
                newSaleOrder();
            else if (currentGrid == SHOW_PICKING_LIST)
            {                
                NewPickingListCommand cmd = new NewPickingListCommand();                
                cmd.Execute();
                LoadDataTabs(DisplayedTabs.PickingList);
            }
            else if (currentGrid == SHOW_DELIVERY_NOTE)
            {
                Command comm = new NewDeliveryNoteCommand();
                comm.Execute();
                LoadDataTabs(DisplayedTabs.DeliveryNotes);
            }
            else if (currentGrid == SHOW_PACKING_LIST)
            {
                NewPackingListCommand cmd = new NewPackingListCommand();
                cmd.Execute();
                LoadDataTabs(DisplayedTabs.PackingList);
            }
            else if (currentGrid == SHOW_STOCK_TRANSFER)
            {
                NewStockTransferCommand cmd = new NewStockTransferCommand();
                cmd.Execute();
                LoadDataTabs(DisplayedTabs.StockTransfer);
            }
            else if (currentGrid == SHOW_INVENTORY_ADJUSTMENT)
            {
                NewInventoryAdjustmentCommand cmd = new NewInventoryAdjustmentCommand();
                cmd.Execute();
                LoadDataTabs(DisplayedTabs.InventoryAdjustment);
            }
            else if (currentGrid == SHOW_PRODUCT)
            {
                NewProductCommand cmd = new NewProductCommand();
                cmd.Execute();
                LoadDataTabs(DisplayedTabs.Product);
            }
            else if (currentGrid == SHOW_PRODUCT_CATEGORY)
            {
                NewProductCategoryCommand cmd = new NewProductCategoryCommand();
                cmd.Execute();
                LoadDataTabs(DisplayedTabs.ProductCategory);
            }
            else if (currentGrid == SHOW_PRODUCT_FAMILY)
            {
                NewProductFamilyCommand cmd = new NewProductFamilyCommand();
                cmd.Execute();
                LoadDataTabs(DisplayedTabs.ProductFamily);
            }
            else if (currentGrid == SHOW_BARCODE)
            {
                NewBarcodeCommand cmd = new NewBarcodeCommand();
                cmd.Execute();
                LoadDataTabs(DisplayedTabs.Barcode);
            }
            else if (currentGrid == SHOW_STOCK_OUT)
            {
                NewStockOutCommand cmd = new NewStockOutCommand();
                cmd.Execute();
                LoadDataTabs(DisplayedTabs.StockOut);
            }
            else if (currentGrid == SHOW_STOCK_IN)
            {
                NewStockInCommand cmd = new NewStockInCommand();
                cmd.Execute();
                LoadDataTabs(DisplayedTabs.StockIn);
            }
            else if (currentGrid == SHOW_BOM)
            {
                NewBOMCommand cmd = new NewBOMCommand();
                cmd.Execute();
                LoadDataTabs(DisplayedTabs.BOM);
            }
            else if (currentGrid == SHOW_INVENTORY_UPDATE)
            {
                NewInventoryUpdateCommand cmd = new NewInventoryUpdateCommand();
                cmd.Execute();
                LoadDataTabs(DisplayedTabs.InventoryUpdate);
            }
            else if (currentGrid == SHOW_PHYSICAL_TAKE)
            {
                NewPhysicalTakeCommand cmd = new NewPhysicalTakeCommand();
                cmd.Execute();
                LoadDataTabs(DisplayedTabs.PhysicalTake);
            }
            else if (currentGrid == SHOW_WORK_ORDER)
            {
                NewWorkOrderCommand cmd = new NewWorkOrderCommand();
                cmd.Execute();
                LoadDataTabs(DisplayedTabs.WorkOrder);
            }
            else if (currentGrid == SHOW_PAYMENT_METHOD)
            {
                NewPaymentMethodCommand cmd = new NewPaymentMethodCommand();
                cmd.Execute();
                LoadDataTabs(DisplayedTabs.PaymentMethod);
            }
            else if (currentGrid == SHOW_RECEIVED_GOOD)
            {
                frmReceivedGoods frmNewGood = new frmReceivedGoods();
                frmNewGood.ShowDialog();
                
                // Refresh data
                Refresh_Received_Food();
            }
            #region G8soft\20070728
            else if (currentGrid == SHOW_VENDOR_PAYMENT)
            {
                AddVendorPayment();
            }
            else if (currentGrid == SHOW_CUSTOMER_PAYMENT)
            {
                AddCustomerPayment();
            }
            else if (currentGrid == SHOW_UOM)
            {
                AddUOM();

            }
            else if (currentGrid == SHOW_WAREHOUSE_MASTER)
            {
                AddWarehouseMaster();
            }
            #endregion

            #region G8Soft\SaleReturn 20070804
            else if (currentGrid == SHOW_SALE_RETURN_MASTER)
            {
                AddSaleReturnMaster();
            }
            else if (currentGrid == SHOW_PURCHASE_RETURN_MASTER)
            {
                AddPurchaseReturnMaster();
            }
            #endregion

            else if (currentGrid == SHOW_DELIVERY_METHOD)
            {
                AddDeliveryMethod();
            }
            else if (currentGrid == SHOW_SHIP_VIA_METHOD)
            {
                AddShipViaMethod();
            }
            else if (currentGrid == SHOW_PACKAGE_TYPE)
            {
                AddPackageType();
            }
            else if (currentGrid == SHOW_OPERATION_PERIOD)
            {
                AddOperationPeriod();
            }
        }
       
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentGrid == SHOW_CUSTOMER)
                editCustomer();
            else if (currentGrid == SHOW_SUPPLIER)
                editSupplier();
            else if (currentGrid == SHOW_PURCHASE_ORDER)
                editPurchaseOrder();
            else if (currentGrid == SHOW_SALE_ORDER)
                editSaleOrder();
            else if (currentGrid == SHOW_PICKING_LIST)
            {
                EditPickingListCommand objCommand = new EditPickingListCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                //Transfer input data to EditPickingListCommand for binding data to PickingList dialog
                if (dr == null) return;
                objCommand.PickingListID = dr["PickingListId"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.PickingList);
            }
            else if (currentGrid == SHOW_PACKING_LIST)
            {
                EditPackingListCommand objCommand = new EditPackingListCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.PackingListId = dr["PackingListId"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.PackingList);
            }
            else if (currentGrid == SHOW_DELIVERY_NOTE)
            {
                EditDeliveryNoteCommand objCommand = new EditDeliveryNoteCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.DeliveryNoteId = dr["Id"].ToString();
                objCommand.DeliveryNoteDNID = dr["DNID"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.DeliveryNotes);
            }
            else if (currentGrid == SHOW_STOCK_TRANSFER)
            {
                EditStockTransferCommand objCommand = new EditStockTransferCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.StockTransferListId = dr["Id"].ToString();
                objCommand.StockTransferName = dr["Name"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.StockTransfer);
            }
            else if (currentGrid == SHOW_INVENTORY_ADJUSTMENT)
            {
                EditInventoryAdjustmentCommand objCommand = new EditInventoryAdjustmentCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.AdjustId = dr["Id"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.InventoryAdjustment);
            }
            else if (currentGrid == SHOW_PRODUCT)
            {
                EditProductCommand objCommand = new EditProductCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.ProductId= dr["ProductId"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.Product);
            }
            else if (currentGrid == SHOW_PRODUCT_CATEGORY)
            {
                EditProductCategoryCommand objCommand = new EditProductCategoryCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.ProductCategoryId = dr["CategoryId"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.ProductCategory);
            }
            else if (currentGrid == SHOW_PRODUCT_FAMILY)
            {
                EditProductFamilyCommand objCommand = new EditProductFamilyCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.ProductFamilyId = dr["FamilyId"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.ProductFamily);
            }
            else if (currentGrid == SHOW_BARCODE)
            {
                EditBarcodeCommand objCommand = new EditBarcodeCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.BarcodeId = dr["Id"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.Barcode);
            }
            else if (currentGrid == SHOW_STOCK_OUT)
            {
                EditStockOutCommand objCommand = new EditStockOutCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.Id = dr["Id"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.StockOut);
            }
            else if (currentGrid == SHOW_STOCK_IN)
            {
                EditStockInCommand objCommand = new EditStockInCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.Id = dr["Id"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.StockIn);
            }
            else if (currentGrid == SHOW_STOCK_IN)
            {
                EditStockInCommand objCommand = new EditStockInCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.Id = dr["Id"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.StockIn);
            }
            
            else if (currentGrid == SHOW_BOM)
            {
                EditBOMCommand objCommand = new EditBOMCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.Id = dr["Id"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.BOM);
            }
            else if (currentGrid == SHOW_INVENTORY_UPDATE)
            {
                EditInventoryUpdateCommand objCommand = new EditInventoryUpdateCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.InventoryUpdateId = dr["Id"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.InventoryUpdate);
            }
            else if (currentGrid == SHOW_PHYSICAL_TAKE)
            {
                EditPhysicalTakeCommand objCommand = new EditPhysicalTakeCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.PhysicalTakeId = dr["Id"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.PhysicalTake);
            }
            else if (currentGrid == SHOW_WORK_ORDER)
            {
                EditWorkOrderCommand objCommand = new EditWorkOrderCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.Number = (dr["Number"] == DBNull.Value)? 0: Convert.ToDouble(dr["Number"]);
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.WorkOrder);
            }
            else if (currentGrid == SHOW_PAYMENT_METHOD)
            {
                EditPaymentMethodCommand objCommand = new EditPaymentMethodCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.PaymentMethodId = dr["ID"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.PaymentMethod);
            }
            else if (currentGrid == SHOW_RECEIVED_GOOD)
            {
                GridView oView = (GridView)grdCustomer.Views[0];
                if (oView.SelectedRowsCount > 0)
                {
                    DataRow oRow = DevXpressUtils.GetSelectedRow(grdCustomer);
                    string strReceivedID = oRow["ID"].ToString();
                    frmReceivedGoods frmNewGood = new frmReceivedGoods(strReceivedID);
                    frmNewGood.ShowDialog();

                    // Refresh data
                    Refresh_Received_Food();
                }
            }
            #region G8Soft\KienDD\20070728
            else if (currentGrid == SHOW_VENDOR_PAYMENT)
            {
                EditVendorPayment();

            }
            else if (currentGrid == SHOW_CUSTOMER_PAYMENT)
            {
                EditCustomerPayment();

            }
            else if (currentGrid == SHOW_UOM)
            {
                EditUOM();
            }
            else if (currentGrid == SHOW_WAREHOUSE_MASTER)
            {
                EditWarehouseMaster();
            }
            #endregion
            else if (currentGrid == SHOW_DELIVERY_METHOD)
            {
                EditDeliveryMethod();
            }
            else if (currentGrid == SHOW_SALE_RETURN_MASTER)
            {
                EditSaleReturnMaster();
            }
            else if (currentGrid == SHOW_PURCHASE_RETURN_MASTER)
            {
                EditPurchaseReturnMaster();
            }
            else if (currentGrid == SHOW_SHIP_VIA_METHOD)
            {
                EditShipViaMethod();
            }
            else if (currentGrid == SHOW_PACKAGE_TYPE)
            {
                EditPackageType();
            }
            else if (currentGrid == SHOW_OPERATION_PERIOD)
            {
                EditOperationPeriod();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentGrid == SHOW_CUSTOMER)
                DeleteCustomer();
            else if (currentGrid == SHOW_SUPPLIER)
                DeleteSupplier();
            else if (currentGrid == SHOW_PURCHASE_ORDER)
                DeletePurchaseOrder();
            else if (currentGrid == SHOW_SALE_ORDER)
                DeleteSaleOrder();
            else if (currentGrid == SHOW_PICKING_LIST)
            {
                DeletePickingListCommand cmd = new DeletePickingListCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                cmd.PickingListID = dr["PickingListId"].ToString();
                cmd.Execute();
                LoadDataTabs(DisplayedTabs.PickingList);
            }
            else if (currentGrid == SHOW_DELIVERY_NOTE)
            {
                DeleteDeliveryNoteCommand objCommand = new DeleteDeliveryNoteCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.DeliveryNoteID = dr["Id"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.DeliveryNotes);
            }
            else if (currentGrid == SHOW_PACKING_LIST)
            {
                DeletePackingListCommand objCommand = new DeletePackingListCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.PackingListId = dr["PackingListId"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.PackingList);
            }
            else if (currentGrid == SHOW_STOCK_TRANSFER)
            {
                DeleteStockTransferCommand objCommand = new DeleteStockTransferCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.StockTransferListId = dr["Id"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.StockTransfer);
            }
            else if (currentGrid == SHOW_INVENTORY_ADJUSTMENT)
            {
                DeleteInventoryAdjustmentCommand objCommand = new DeleteInventoryAdjustmentCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.AdjustId = dr["Id"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.InventoryAdjustment);
            }
            else if (currentGrid == SHOW_PRODUCT)
            {
                DeleteProductCommand objCommand = new DeleteProductCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.ProductID = dr["ProductId"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.Product);
            }
            else if (currentGrid == SHOW_PRODUCT_CATEGORY)
            {
                DeleteProductCategoryCommand objCommand = new DeleteProductCategoryCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.ProductCategoryID = dr["CategoryId"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.ProductCategory);
            }
            else if (currentGrid == SHOW_PRODUCT_FAMILY)
            {
                DeleteProductFamilyCommand objCommand = new DeleteProductFamilyCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.ProductFamilyID = dr["FamilyId"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.ProductFamily);
            }
            else if (currentGrid == SHOW_BARCODE)
            {
                DeleteBarcodeCommand objCommand = new DeleteBarcodeCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.BarcodeId = dr["Id"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.Barcode);
            }
            else if (currentGrid == SHOW_STOCK_OUT)
            {
                DeleteStockOutCommand objCommand = new DeleteStockOutCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.Id = dr["Id"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.StockOut);
            }
            else if (currentGrid == SHOW_STOCK_IN)
            {
                DeleteStockInCommand objCommand = new DeleteStockInCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.Id = dr["Id"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.StockIn);
            }
            else if (currentGrid == SHOW_INVENTORY_UPDATE)
            {
                DeleteInventoryUpdateCommand objCommand = new DeleteInventoryUpdateCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.InventoryUpdateID = dr["Id"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.InventoryUpdate);
            }
            else if (currentGrid == SHOW_BOM)
            {
                DeleteBOMCommand objCommand = new DeleteBOMCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.Id = dr["Id"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.BOM);
            }
            else if (currentGrid == SHOW_PHYSICAL_TAKE)
            {
                DeletePhysicalTakeCommand objCommand = new DeletePhysicalTakeCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.PhysicalTakeID = dr["Id"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.PhysicalTake);
            }
            else if (currentGrid == SHOW_WORK_ORDER)
            {
                DeleteWorkOrderCommand objCommand = new DeleteWorkOrderCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.Number = (dr["Number"] == DBNull.Value) ? 0 : Convert.ToDouble(dr["Number"]);
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.WorkOrder);
            }

            else if (currentGrid == SHOW_PAYMENT_METHOD)
            {
                DeletePaymentMethodCommand objCommand = new DeletePaymentMethodCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.PaymentMethodId = dr["Id"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.PaymentMethod);
            }
            else if (currentGrid == SHOW_RECEIVED_GOOD)
            {
                GridView oView = (GridView)grdCustomer.Views[0];
                if (oView.SelectedRowsCount > 0)
                {
                    // Delete
                    DeleteReceivedGood();

                    // Refresh data
                    Refresh_Received_Food();
                }
            }
            #region G8Soft\KienDD\20070729
            else if (currentGrid == SHOW_UOM)
            {
                DeleteUOM();
            }
            else if (currentGrid == SHOW_WAREHOUSE_MASTER)
            {
                DeleteWarehouseMaster();
            }

            else if (currentGrid == SHOW_VENDOR_PAYMENT)
            {
                DeleteVendorPayment();
            }
            else if (currentGrid == SHOW_CUSTOMER_PAYMENT)
            {
                DeleteCustomerPayment();
            }
            #endregion
            #region G8Soft\SaleReturn 20070804
            else if (currentGrid == SHOW_SALE_RETURN_MASTER)
            {
                DeleteSaleReturnMaster();
            }
            #endregion

            else if (currentGrid == SHOW_DELIVERY_METHOD)
            {
                DeleteDeliveryMethod();
            }
            else if (currentGrid == SHOW_SHIP_VIA_METHOD)
            {
                DeleteShipViaMethod();
            }
            else if (currentGrid == SHOW_PACKAGE_TYPE)
            {
                DeletePackageType();
            }
        }

        private void DeleteReceivedGood()
        {
            // Connect to databse
            SqlConnection oConnection = new SqlConnection(Globals.strVISConnection);
            oConnection.Open();
            SqlCommand oCommand = new SqlCommand();            
            oCommand.Connection = oConnection;
            oCommand.Transaction = oConnection.BeginTransaction();

            GridView oView = (GridView)grdCustomer.Views[0];
            for (int nCount = 0; nCount < oView.GetSelectedRows().Length; nCount++)
            {
                DataRow oRow = oView.GetDataRow(oView.GetSelectedRows()[nCount]);
                string strReceivedID = oRow["ID"].ToString();
                oCommand.CommandText = String.Format("Delete inv_ReceivedGood Where inv_ReceivedGood.ID = '{0}'", strReceivedID);
                oCommand.ExecuteNonQuery();
                oCommand.Transaction.Commit();
            }           
            
            oConnection.Close();
        }
 
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printingSystem1.Print();                        
        }

       #endregion

        #region Grid Events

        private void grdCustomer_DoubleClick(object sender, EventArgs e)
        {
            /*
            if (currentGrid == SHOW_CUSTOMER)
                editCustomer();
            else if (currentGrid == SHOW_SUPPLIER)
                editSupplier();
            else if (currentGrid == SHOW_PURCHASE_ORDER)
                editPurchaseOrder();
            else if (currentGrid == SHOW_SALE_ORDER)
                editSaleOrder();
            else if (currentGrid == SHOW_PICKING_LIST)
            {
                EditPickingListCommand objCommand = new EditPickingListCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                //Transfer input data to EditPickingListCommand for binding data to PickingList dialog
                if (dr == null) return;
                objCommand.PickingListID = dr["PickingListId"].ToString();
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.PickingList);
            }
            else if (currentGrid == SHOW_PACKING_LIST)
            {
                EditPackingListCommand objCommand = new EditPackingListCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.PackingListId = dr["PackingListId"].ToString();
                
                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.PackingList);
            }
            else if (currentGrid == SHOW_DELIVERY_NOTE)
            {
                EditDeliveryNoteCommand objCommand = new EditDeliveryNoteCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.DeliveryNoteId = dr["Id"].ToString();

                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.DeliveryNotes);
            }
            else if (currentGrid == SHOW_STOCK_TRANSFER)
            {
                EditStockTransferCommand objCommand = new EditStockTransferCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.StockTransferListId = dr["Id"].ToString();

                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.StockTransfer);
            }
            else if (currentGrid == SHOW_INVENTORY_ADJUSTMENT)
            {
                EditInventoryAdjustmentCommand objCommand = new EditInventoryAdjustmentCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.AdjustId = dr["Id"].ToString();

                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.InventoryAdjustment);
            }
            else if (currentGrid == SHOW_PRODUCT)
            {
                EditProductCommand objCommand = new EditProductCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.ProductId = dr["ProductId"].ToString();

                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.Product);
            }
            else if (currentGrid == SHOW_PRODUCT_CATEGORY)
            {
                EditProductCategoryCommand objCommand = new EditProductCategoryCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.ProductCategoryId = dr["CategoryId"].ToString();

                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.ProductCategory);
            }
            else if (currentGrid == SHOW_PRODUCT_FAMILY)
            {
                EditProductFamilyCommand objCommand = new EditProductFamilyCommand();
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (dr == null) return;
                objCommand.ProductFamilyId = dr["FamilyId"].ToString();

                objCommand.Execute();
                LoadDataTabs(DisplayedTabs.ProductFamily);
            }
             * */
            btnEdit_Click(null, null);
        }
        
        private void grdCustomer_Click(object sender, EventArgs e)
        {
            
        }

        private void grdSupplier_Click(object sender, EventArgs e)
        {
            
        }

        private void grdSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void grdCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if (currentGrid == SHOW_CUSTOMER)
            {
                if (e.KeyCode == Keys.Delete)
                    DeleteCustomer();
                else if (e.KeyCode == Keys.Insert)
                    newCustomer();
                else if (e.KeyCode == Keys.Enter)
                    editCustomer();
            }
            else if (currentGrid == SHOW_SUPPLIER)
            {
                if (e.KeyCode == Keys.Delete)
                    DeleteSupplier();
                else if (e.KeyCode == Keys.Insert)
                    newSupplier();
                else if (e.KeyCode == Keys.Enter)
                    editSupplier();
            }
            else if (currentGrid == SHOW_PURCHASE_ORDER)
            {
                if (e.KeyCode == Keys.Delete)
                    DeletePurchaseOrder();
                else if (e.KeyCode == Keys.Insert)
                    newPurchaseOrder();
                else if (e.KeyCode == Keys.Enter)
                    editPurchaseOrder();

            }
            else if (currentGrid == SHOW_SALE_ORDER)
            {
                if (e.KeyCode == Keys.Delete)
                    DeleteSaleOrder();
                else if (e.KeyCode == Keys.Insert)
                    newSaleOrder();
                else if (e.KeyCode == Keys.Enter)
                    editSaleOrder();
            }
            else if (currentGrid == SHOW_PACKING_LIST)
            {
                DataRow dr = DevXpressUtils.GetSelectedRow(grdCustomer);
                if (e.KeyCode == Keys.Delete) 
                {
                    DeletePackingListCommand cmd = new DeletePackingListCommand();
                    cmd.PackingListId = dr["PackingListId"].ToString();
                    cmd.Execute();
                }

                else if (e.KeyCode == Keys.Insert)
                {
                    NewPackingListCommand cmd = new NewPackingListCommand();
                    cmd.Execute();
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    EditPackingListCommand cmd = new EditPackingListCommand();
                    cmd.PackingListId = dr["PackingListId"].ToString();
                    cmd.Execute();
                }
                LoadDataTabs(DisplayedTabs.PackingList);
            }
             * */
            if (e.KeyCode == Keys.Delete)
            {
                btnDelete_Click(null, null);
            }

            else if (e.KeyCode == Keys.Insert)
            {
                btnNew_Click(null, null);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnEdit_Click(null, null);
            }
        }

        private void grdSupplier_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void grdSupplier_KeyDown(object sender, KeyEventArgs e)
        {

        }

        #endregion
        
        #region Menu Events

        private void mnuSPickListing_ItemClick(object sender, ItemClickEventArgs e)
        {
            currentGrid = SHOW_PICKING_LIST;
            this.LoadDataTabs(DisplayedTabs.PickingList);
        }

        private void mnuSPackListing_ItemClick(object sender, ItemClickEventArgs e)
        {
            currentGrid = SHOW_PACKING_LIST;
            this.LoadDataTabs(DisplayedTabs.PackingList);
        }

        private void mnuSDeliveryNote_ItemClick(object sender, ItemClickEventArgs e)
        {
            currentGrid = SHOW_DELIVERY_NOTE;
            this.LoadDataTabs(DisplayedTabs.DeliveryNotes);           
        }

        private void mnuSTransfers_ItemClick(object sender, ItemClickEventArgs e)
        {
            currentGrid = SHOW_STOCK_TRANSFER;
            this.LoadDataTabs(DisplayedTabs.StockTransfer);
        
        }

        private void mnuSAdjustInventory_ItemClick(object sender, ItemClickEventArgs e)
        {
            currentGrid = SHOW_INVENTORY_ADJUSTMENT;
            this.LoadDataTabs(DisplayedTabs.InventoryAdjustment);
        }

        private void mnuSAlert_ItemClick(object sender, ItemClickEventArgs e)
        {
            Commands.Reorder.EditAlertSettingsCommand objAlert = new Inventory.Commands.Reorder.EditAlertSettingsCommand();
            objAlert.Execute();
        }

        private void mnuSBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Globals.CheckAccessRights(Globals.UserID,"D475ABD5-A9A7-43BE-BA80-A7BFAE6FAACB",true))
            {
                BackupAndRestoreSetting frm = new BackupAndRestoreSetting();
                frm.strCon = Globals.strVISConnection;
                frm.ShowDialog();
                /*
                Forms.Data.BackupRestore frmBackup = new Inventory.Forms.Data.BackupRestore();
                frmBackup.ShowDialog();
                 */
            }
        }

        private void mnuSImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            Commands.Data.ImportCommand cmdImport = new Inventory.Commands.Data.ImportCommand();
            cmdImport.Execute();
        }

        private void mnuSExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Data.ExportData frmExport = new Inventory.Forms.Data.ExportData();
            frmExport.ShowDialog();
        }

        private void mnuBarcode_ItemClick(object sender, ItemClickEventArgs e)
        {
            //BarCodeManager frmBarcode = new BarCodeManager();
            //frmBarcode.ShowDialog();

            //Inventory.Commands.Barcode.GenerateBarcodeCommand cmd = new Inventory.Commands.Barcode.GenerateBarcodeCommand();
            //cmd.Execute();

            currentGrid = SHOW_BARCODE;
            this.LoadDataTabs(DisplayedTabs.Barcode);
        }

        private void mnuSItems_ItemClick(object sender, ItemClickEventArgs e)
        {
            currentGrid = SHOW_PRODUCT;
            this.LoadDataTabs(DisplayedTabs.Product);
        }

        private void mnuDOpWhStockIn_ItemClick(object sender, ItemClickEventArgs e)
        {
            currentGrid = SHOW_STOCK_IN;
            this.LoadDataTabs(DisplayedTabs.StockIn);
        }

        private void mnuDOpWhStockOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            currentGrid = SHOW_STOCK_OUT;
            this.LoadDataTabs(DisplayedTabs.StockOut);
        }

        private void mnuSItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            currentGrid = SHOW_PRODUCT;
            this.LoadDataTabs(DisplayedTabs.Product);
        }


        private void mnuSProductFamily_ItemClick(object sender, ItemClickEventArgs e)
        {
            currentGrid = SHOW_PRODUCT_FAMILY;
            this.LoadDataTabs(DisplayedTabs.ProductFamily);
        }

        private void mnuSProductCategory_ItemClick(object sender, ItemClickEventArgs e)
        {
            currentGrid = SHOW_PRODUCT_CATEGORY;
            this.LoadDataTabs(DisplayedTabs.ProductCategory);
        }

        private void mnuSNewBillOfMaterial_ItemClick(object sender, ItemClickEventArgs e)
        {
            currentGrid = SHOW_BOM;
            LoadDataTabs(DisplayedTabs.BOM);
        }

        private void mnuSUpdateInventory_ItemClick(object sender, ItemClickEventArgs e)
        {
            currentGrid = SHOW_INVENTORY_UPDATE;
            LoadDataTabs(DisplayedTabs.InventoryUpdate);
        }

        private void mnuSPhysicalTake_ItemClick(object sender, ItemClickEventArgs e)
        {
            currentGrid = SHOW_PHYSICAL_TAKE;
            LoadDataTabs(DisplayedTabs.PhysicalTake);
        }

        private void mnuSPrintVariance_ItemClick(object sender, ItemClickEventArgs e)
        {
            Commands.StockTake.RunPrintVarianceCommand objVariance = new Commands.StockTake.RunPrintVarianceCommand();
            objVariance.Execute();
        }

        private void mnuSWordOrders_ItemClick(object sender, ItemClickEventArgs e)
        {
            currentGrid = SHOW_WORK_ORDER;
            LoadDataTabs(DisplayedTabs.WorkOrder);
        }

        private void mnuSPaymentMethods_ItemClick(object sender, ItemClickEventArgs e)
        {
            G8_POS.PaymentMethod frm = new G8_POS.PaymentMethod();
            frm.IsAdmin = true;
            frm.ShowDialog();
            frm.Dispose();
            //currentGrid = SHOW_PAYMENT_METHOD;
            //LoadDataTabs(DisplayedTabs.PaymentMethod);
        }

        private void mnuSPurgeData_ItemClick(object sender, ItemClickEventArgs e)
        {
            Commands.Data.PurgeCommand cmdPurge = new Commands.Data.PurgeCommand();
            cmdPurge.Execute();
        }

        private void mnuSSystemInformation_ItemClick(object sender, ItemClickEventArgs e)
        {
            Commands.SysInfos.EditSysInfosCommand cmdInfo = new Commands.SysInfos.EditSysInfosCommand();
            cmdInfo.Execute();
        }

        //private void mnuSClosePeriod_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    Commands.StockTake.ClosePeriodCommand cmdClose = new ClosePeriodCommand();
        //    cmdClose.Execute();
        //}

        #endregion

        #region Load Data Tabs

        private void LoadDataTabs(DisplayedTabs displayedTab)
        {
            this.CurrentTab = displayedTab;

            grdCustomer.DataSource = null;
            ((GridView)grdCustomer.Views[0]).Columns.Clear();
            GridView gridView = (GridView)grdCustomer.Views[0];
            gridView.OptionsBehavior.Editable = false;
            viewTemp = gridView;

            foreach (GridColumn cl in gridView.Columns)
            {
                cl.Visible = false;
                cl.MinWidth = 10;
                cl.AppearanceHeader.Font = Settings.Default.cfgDefaultFont;
                cl.AppearanceCell.Font = Settings.Default.cfgDefaultFont;
            }
            
            switch (displayedTab)
            {
                case DisplayedTabs.PickingList:
                    LoadPickingListTab();
                    break;
                case DisplayedTabs.PackingList:
                    LoadPackingListTab();
                    break;
                case DisplayedTabs.DeliveryNotes:
                    LoadDeliveryNotesTab();
                    break;
                case DisplayedTabs.StockTransfer:
                    LoadStockTransferTab();
                    break;
                case DisplayedTabs.InventoryAdjustment:
                    LoadInventoryAdjustmentTab();
                    break;
                case DisplayedTabs.Product:
                    LoadProductTab();
                    break;
                case DisplayedTabs.ProductCategory:
                    LoadProductCategoryTab();
                    break;
                case DisplayedTabs.ProductFamily:
                    LoadProductFamilyTab();
                    break;
                case DisplayedTabs.Barcode:
                    LoadBarcodeTab();
                    break;
                case DisplayedTabs.StockIn:
                    LoadStockInTab();
                    break;
                case DisplayedTabs.StockOut:
                    LoadStockOutTab();
                    break;
                case DisplayedTabs.BOM:
                    LoadBOMTab();
                    break;
                case DisplayedTabs.InventoryUpdate:
                    LoadInventoryUpdateTab();
                    break;
                case DisplayedTabs.PhysicalTake:
                    LoadPhysicalTakeTab();
                    break;
                case DisplayedTabs.WorkOrder:
                    LoadWorkOrderTab();
                    break;
                case DisplayedTabs.PaymentMethod:
                    LoadPaymentMethodTab();
                    break;
            }
            grdCustomer.Refresh();
        }

        private void LoadPaymentMethodTab()
        {
            grdCustomer.DataSource = mediator.GetAllPaymentMethod();
            GridView gridView = (GridView)grdCustomer.Views[0];
            viewTemp = gridView;

            foreach (GridColumn cl in gridView.Columns)
            {
                cl.MinWidth = 10;
                cl.AppearanceHeader.Font = Settings.Default.cfgDefaultFont;
                cl.AppearanceCell.Font = Settings.Default.cfgDefaultFont;
            }

            //Hide some colums
            gridView.Columns["ID"].Visible = false;
        }

        private void LoadBOMTab()
        {
            grdCustomer.DataSource = mediator.GetAllBOMMaster();
            GridView gridView = (GridView)grdCustomer.Views[0];
            viewTemp = gridView;

            foreach (GridColumn cl in gridView.Columns)
            {
                cl.MinWidth = 10;
                cl.AppearanceHeader.Font = Settings.Default.cfgDefaultFont;
                cl.AppearanceCell.Font = Settings.Default.cfgDefaultFont;
            }

            //Hide some colums
           gridView.Columns["ID"].Visible = false;
           gridView.Columns["ProductID"].Visible = false;
           gridView.Columns["UserID"].Visible = false;
        }


        private void LoadBarcodeTab()
        {
            grdCustomer.DataSource = mediator.GetAllBarcodeMaster();
            GridView gridView = (GridView)grdCustomer.Views[0];
            viewTemp = gridView;

            foreach (GridColumn cl in gridView.Columns)
            {
                cl.MinWidth = 10;
                cl.AppearanceHeader.Font = Settings.Default.cfgDefaultFont;
                cl.AppearanceCell.Font = Settings.Default.cfgDefaultFont;
            }

            //Hide some colums
            gridView.Columns["ID"].Visible = false;
        }


        private void LoadStockOutTab()
        {
            grdCustomer.DataSource = mediator.GetAllStockOutMasters();
            GridView gridView = (GridView)grdCustomer.Views[0];
            viewTemp = gridView;

            foreach (GridColumn cl in gridView.Columns)
            {
                cl.MinWidth = 10;
                cl.AppearanceHeader.Font = Settings.Default.cfgDefaultFont;
                cl.AppearanceCell.Font = Settings.Default.cfgDefaultFont;
            }

            //Hide some colums
            gridView.Columns["ID"].Visible = false;
        }

        private void LoadStockInTab()
        {
            grdCustomer.DataSource = mediator.GetAllStockInMasters();
            GridView gridView = (GridView)grdCustomer.Views[0];
            viewTemp = gridView;

            foreach (GridColumn cl in gridView.Columns)
            {
                cl.MinWidth = 10;
                cl.AppearanceHeader.Font = Settings.Default.cfgDefaultFont;
                cl.AppearanceCell.Font = Settings.Default.cfgDefaultFont;
            }

            //Hide some colums
            gridView.Columns["ID"].Visible = false;
        }


        private void LoadStockTransferTab()
        {
            grdCustomer.DataSource = mediator.GetAllStockTransferMasters();
            GridView gridView = (GridView)grdCustomer.Views[0];
            viewTemp = gridView;

            foreach (GridColumn cl in gridView.Columns)
            {
                cl.MinWidth = 10;
                cl.AppearanceHeader.Font = Settings.Default.cfgDefaultFont;
                cl.AppearanceCell.Font = Settings.Default.cfgDefaultFont;
            }

            //Hide some colums
            gridView.Columns["ID"].Visible = false;
        }

        private void LoadPickingListTab()
        {
            grdCustomer.DataSource = mediator.GetAllPickingListMaster();
            GridView gridView = (GridView)grdCustomer.Views[0];
            viewTemp = gridView;

            foreach (GridColumn cl in gridView.Columns)
            {
                cl.MinWidth = 10;
                cl.AppearanceHeader.Font = Settings.Default.cfgDefaultFont;
                cl.AppearanceCell.Font = Settings.Default.cfgDefaultFont;
            }

            //Hide some colums
            gridView.Columns["PickingListID"].Visible = false;
            gridView.Columns["UserID"].Visible = false;
            gridView.Columns["LastUpdatedDate"].Visible = false;
        }

        private void LoadPackingListTab()
        {
            grdCustomer.DataSource = mediator.GetAllPackingListMaster();
            GridView gridView = (GridView)grdCustomer.Views[0];
            foreach (GridColumn cl in gridView.Columns)
            {
                //cl.Visible = false;
                cl.MinWidth = 10;
                cl.AppearanceHeader.Font = Settings.Default.cfgDefaultFont;
                cl.AppearanceCell.Font = Settings.Default.cfgDefaultFont;
            }

            gridView.Columns["PackingListID"].Visible = false;
        }

        private void LoadDeliveryNotesTab()
        {
            grdCustomer.DataSource = mediator.GetAllDeliveryNoteMaster();
            GridView gridView = (GridView)grdCustomer.Views[0];
            gridView.Columns["ID"].Visible = false;
            gridView.Columns["DeliveryMethodID"].Visible = false;
            gridView.Columns["Cost1"].Visible = false;
            gridView.Columns["Cost2"].Visible = false;
            gridView.Columns["UserID"].Visible = false;
            gridView.Columns["LastUpdatedDate"].Visible = false;
            gridView.Columns["Notes"].Visible = false;
            gridView.Columns["CustomerID"].Visible = false;
            gridView.Columns["TypeOfDelivery"].Visible = false;
            gridView.Columns["Address"].Visible = false;

            
        }

        private void LoadInventoryAdjustmentTab()
        {
            grdCustomer.DataSource = mediator.GetAllInventoryAdjustment();
            ((GridView)grdCustomer.Views[0]).Columns["ID"].Visible = false;
        }

        private void LoadProductTab()
        {
            grdCustomer.DataSource = mediator.GetAllProductMaster();
            GridView gridView = (GridView)grdCustomer.Views[0];
            
            gridView.Columns["ProductID"].Visible = false;
            gridView.Columns["BarcodeID"].Visible = false;
            gridView.Columns["FamilyID"].Visible = false;
            gridView.Columns["CategoryID"].Visible = false;
            gridView.Columns["UOMID"].Visible = false;
            gridView.Columns["SubCategoryID"].Visible = false;
            gridView.Columns["SupplierID"].Visible = false;
            gridView.Columns["POSID"].Visible = false;
            gridView.Columns["InvID"].Visible = false;
            gridView.Columns["LeadTimeMin"].Visible = false;
            gridView.Columns["LeadTimeMax"].Visible = false;
            gridView.Columns["Qty"].Visible = false;
            gridView.Columns["BookedQty"].Visible = false;
            gridView.Columns["PhysicalStockLevel"].Visible = false;
            gridView.Columns["SafetyLevel"].Visible = false;
            gridView.Columns["MiniLevel"].Visible = false;
            gridView.Columns["MaxLevel"].Visible = false;
            gridView.Columns["ReorderLevel"].Visible = false;
            gridView.Columns["CurrencyID"].Visible = false;
            gridView.Columns["Cost1"].Visible = false;
            gridView.Columns["Cost2"].Visible = false;
            gridView.Columns["CostDiscount1"].Visible = false;
            gridView.Columns["CostDiscount2"].Visible = false;
            gridView.Columns["Price1"].Visible = false;
            gridView.Columns["Price2"].Visible = false;
            gridView.Columns["Price3"].Visible = false;
            gridView.Columns["PriceDiscount1"].Visible = false;
            gridView.Columns["PriceDiscount2"].Visible = false;
            gridView.Columns["PriceDiscount3"].Visible = false;
            gridView.Columns["TaxID1"].Visible = false;
            gridView.Columns["TaxID2"].Visible = false;
            gridView.Columns["Location_id"].Visible = false;
            gridView.Columns["Remarks1"].Visible = false;
            gridView.Columns["Remarks2"].Visible = false;
            gridView.Columns["ReservedField1"].Visible = false;
            gridView.Columns["ReservedField2"].Visible = false;
            gridView.Columns["ReservedField3"].Visible = false;
            gridView.Columns["ReservedField4"].Visible = false;
            gridView.Columns["ReservedField5"].Visible = false;
            gridView.Columns["ExpiredDate"].Visible = false;
            gridView.Columns["ShowOnWeb"].Visible = false;
            gridView.Columns["UserID"].Visible = false;
            gridView.Columns["Timestamp"].Visible = false;
            gridView.Columns["SafetyStockFactor"].Visible = false;
            //gridView.Columns["HoldingCost"].Visible = false;
            //gridView.Columns["BasePrice"].Visible = false;
            gridView.Columns["Photo"].Visible = false;
            gridView.Columns["IsPromotion"].Visible = false;
        }

        private void LoadProductCategoryTab()
        {
            grdCustomer.DataSource = mediator.GetAllProductCategory();
            GridView gridView = (GridView)grdCustomer.Views[0];

            gridView.Columns["CategoryID"].Visible = false;
            gridView.Columns["ParentCategoryID"].Visible = false;
        }

        private void LoadProductFamilyTab()
        {
            grdCustomer.DataSource = mediator.GetAllProductFamily();
            GridView gridView = (GridView)grdCustomer.Views[0];

            gridView.Columns["FamilyID"].Visible = false;
        }

        private void LoadInventoryUpdateTab()
        {
            grdCustomer.DataSource = mediator.GetAllInventoryUpdate();
            GridView gridView = (GridView)grdCustomer.Views[0];

            gridView.Columns["ID"].Visible = false;
        }

        private void LoadPhysicalTakeTab()
        {
            grdCustomer.DataSource = mediator.GetAllPhysicalTake();
            GridView gridView = (GridView)grdCustomer.Views[0];

            gridView.Columns["ID"].Visible = false;
        }

        private void LoadWorkOrderTab()
        {
            grdCustomer.DataSource = mediator.GetAllWorkOrder();
            GridView gridView = (GridView)grdCustomer.Views[0];
        }

        #endregion

        #region Methods

        private void CheckRunReorderProcess()
        {
            // check time to run process
            string strLastCheck = Mediator.GetInstance().GetConfigValue(Constants.Reorder.LastCheck);
            DateTime dtmLastCheck = DateTime.MinValue;
            try
            {
                dtmLastCheck = Convert.ToDateTime(strLastCheck);
            }
            catch{}

            if (dtmLastCheck != DateTime.MinValue) // not check before
            {
                int intCheckFreq = Convert.ToInt32(Mediator.GetInstance().GetConfigValue(Constants.Reorder.CheckFrequencyConfigName));
                if (dtmLastCheck.AddDays(intCheckFreq) > DateTime.Now)
                {
                    return;
                }
            }

            // run process in background
            System.ComponentModel.BackgroundWorker bgwReorderProcess = new BackgroundWorker();
            bgwReorderProcess.DoWork += new DoWorkEventHandler(bgwReorderProcess_DoWork);
            bgwReorderProcess.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwReorderProcess_RunWorkerCompleted);
            bgwReorderProcess.RunWorkerAsync();

            Commands.Reorder.ReorderCommand cmdReorder = new Inventory.Commands.Reorder.ReorderCommand();
            cmdReorder.UpdateLastCheck(DateTime.Now);
        }

        void bgwReorderProcess_DoWork(object sender, DoWorkEventArgs e)
        {
            Commands.Reorder.ReorderCommand cmdReorder = new Inventory.Commands.Reorder.ReorderCommand();
            cmdReorder.Execute();
        }

        void bgwReorderProcess_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Exception ex = e.Error;
                string strMessage = ex.Message;
                while (ex.InnerException != null)
                {
                    strMessage += Environment.NewLine + ex.InnerException.Message;
                    ex = ex.InnerException;
                }

                MessageBox.Show(strMessage, Constants.Message.MessageTitle);
            }
        }

        #endregion        

        private void mnuSInvoices_ItemClick(object sender, ItemClickEventArgs e)
        {
            SalesInvoice frmSalesInvoice = new SalesInvoice();
            frmSalesInvoice.Show();
        }

        private void mnuSPaymentTerms_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddEditPayment frm = new AddEditPayment();
            frm.ShowDialog();
        }

        private void mnuSTaxCodeList_ItemClick(object sender, ItemClickEventArgs e)
        {
             G8_POS.FrmTaxInformation frm = new G8_POS.FrmTaxInformation();
             frm.Connection = Globals.strVISConnection;
             frm.ShowDialog(this);
        }

        private void mnuSCurrency_ItemClick(object sender, ItemClickEventArgs e)
        {
             frmCurrencyManagement frm;
             frm = new frmCurrencyManagement();
             //G8_POS.frmCurrency frm;
             //frm = new G8_POS.frmCurrency();
             //if (IsHasRight(Globals.UserID,"6AF67D7F-965B-4D61-9D52-B585488252E9",false))
             //    frm.Administrator = true;
             //else
            //{
            //     frm.UserName = Globals.UserName;
            //     frm.UserID = Globals.UserID;
            // }
            // frm.Connection = Globals.strVISConnection;
             frm.ShowDialog(this);

        }
        private bool IsHasRight(string UserID,string FunctionID, bool EnableAlarmMessage)
        {
            bool enableAlarmMessage;
            enableAlarmMessage = EnableAlarmMessage;
            string cmdText = @"SELECT Count(t_Function.FunctionName) FROM t_User INNER JOIN t_RoleUser ON t_User.UserID=t_RoleUser.UserID 
                                INNER JOIN t_RoleFunction ON t_RoleFunction.RoleID=t_RoleUser.RoleID 
                                INNER JOIN t_Function ON t_RoleFunction.FunctionID=t_Function.FunctionID 
                                WHERE t_User.UserID ='" + UserID + "'AND t_Function.FunctionID='" + FunctionID + "'";
            SqlConnection sqlCon = new SqlConnection(Globals.strVISConnection);
            SqlCommand sqlCmd = new SqlCommand(cmdText, sqlCon);
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            int rowCount = Convert.ToInt32(sqlCmd.ExecuteScalar().ToString());
            sqlCon.Close();
            if (rowCount > 0)
            {
                return true;
            }

            else
            {
                if (enableAlarmMessage)
                {
                    MessageBox.Show("You may no right to access this function,please contact the administrator!!", "System Information");
                }
                return false;
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
             BackupAndRestoreSetting frm  = new BackupAndRestoreSetting();
             frm.strCon = Globals.strVISConnection;
             frm.ShowDialog();
        }

        private void mnuSReceiving_ItemClick(object sender, ItemClickEventArgs e)
        {
            currentGrid = SHOW_RECEIVED_GOOD;

            // Fill data into the grid
            Refresh_Received_Food();
        }

        private void Refresh_Received_Food()
        {
            // Fill data into the grid
            string strSQL = "Select inv_ReceivedGood.ID,ReceivedDate,PONo,ProductMaster.ProductName,inv_ReceivedGood.Quantity,inv_ReceivedGood.Cost From inv_ReceivedGood, ProductMaster Where inv_ReceivedGood.OrderProductID = ProductMaster.ProductID Order By inv_ReceivedGood.ReceivedDate";

            SqlConnection oConnection = new SqlConnection(Globals.strVISConnection);
            oConnection.Open();
            DataTable oTable = new DataTable();
            SqlDataAdapter oAdapter = new SqlDataAdapter(strSQL, oConnection);
            oAdapter.Fill(oTable);
            ((GridView)grdCustomer.Views[0]).Columns.Clear();
            grdCustomer.DataSource = oTable;
            oConnection.Close();

            // Display grid
            ((GridView)grdCustomer.Views[0]).Columns["ID"].Visible = false;
            ((GridView)grdCustomer.Views[0]).Columns["ProductName"].Caption = "Product Name";
            ((GridView)grdCustomer.Views[0]).Columns["ReceivedDate"].Caption = "Received Date";
        }

        private void mnuSLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            Login login = new Login();
            if (login.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
                return;
            }
            MainForm_Load(sender,e);
        }

        private void mnuSReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            SqlTest.frmMain frm = new frmMain();
            frm.SplitConnStr(Globals.strVISConnection);
            frm.ShowDialog();
        }

        private void mnuSBillOfMaterial_ItemClick(object sender, ItemClickEventArgs e)
        {
            currentGrid = SHOW_BOM;
            LoadDataTabs(DisplayedTabs.BOM);
        }

        private void mnuSNewVendor_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowSuppliers();
        }

        private void mnuSNewCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadCustomer();  
        }


        private void mnuSDelMethod_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowDeliveryMethod();
        }

        private void mnuSPackage_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowPackageType();
        }

        #region G8soft\KienDD\CustomerPayment20070809
        #region Variable
        private GridView grvCustomerPayment;
        private DataView dtvCustomerPayment;
        #endregion
        #region Method
        private void ShowCustomerPayment()
        {
            currentGrid = SHOW_CUSTOMER_PAYMENT;
            LoadCustomerPayment("");
        }

        private void LoadCustomerPayment(string strFilter)
        {
            if (Globals.dtCustomerPayment.Columns.Count == 12)
            {
                Globals.dtCustomerPayment.Columns.Add("UserName", typeof(string));

            }
            grvCustomerPayment = (GridView)grdCustomer.Views[0];
            grvCustomerPayment.Columns.Clear();
            dtvCustomerPayment = new DataView(Globals.dtCustomerPayment);
            dtvCustomerPayment.RowFilter = strFilter;
            grdCustomer.DataSource = dtvCustomerPayment;
            foreach (GridColumn cl in grvCustomerPayment.Columns)
            {
                cl.MinWidth = 10;
                cl.Visible = false;
            }


            grvCustomerPayment.Columns["CustomerPaymentNo"].VisibleIndex = 0;
            grvCustomerPayment.Columns["OrderID"].VisibleIndex = 1;
            grvCustomerPayment.Columns["OrderID"].Caption = "Sales No";
            grvCustomerPayment.Columns["PaidAmount"].VisibleIndex = 2;
            grvCustomerPayment.Columns["PaidAmount"].Caption = "Paid Amount";
            grvCustomerPayment.Columns["UserName"].VisibleIndex = 3;
            grvCustomerPayment.Columns["UserName"].Caption = "User Created";
            grvCustomerPayment.Columns["DateCreated"].VisibleIndex = 4;
            grvCustomerPayment.Columns["DateCreated"].Caption = "Date Created";
            grvCustomerPayment.Columns["TransactionDate"].VisibleIndex = 5;
            grvCustomerPayment.Columns["TransactionDate"].Caption = "Transaction Date";
            grvCustomerPayment.Columns["Description"].VisibleIndex = 6;

            for (int i = 0; i < grvCustomerPayment.RowCount; i++)
            {
                grvCustomerPayment.SetRowCellValue(i, "UserName", GetUserName(
                    grvCustomerPayment.GetRowCellValue(i, "UserCreated").ToString()));
            }

        }
        private void AddCustomerPayment()
        {
            frmAddEditCustomerPaymentForm frm = new frmAddEditCustomerPaymentForm();
            DataRow row = Globals.dtCustomerPayment.NewRow();
            row["CustomerPaymentID"] = System.Guid.NewGuid();
            frm.ProTypeAction = true;
            frm.ProRow = row;
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            LoadCustomerPayment("");
        }

        private void EditCustomerPayment()
        {
            if (grvCustomerPayment.RowCount == 0 || grvCustomerPayment.FocusedRowHandle < 0)
            {
                MessageBox.Show("There is no item to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmAddEditCustomerPaymentForm frm = new frmAddEditCustomerPaymentForm();
            DataRow row = grvCustomerPayment.GetDataRow(grvCustomerPayment.FocusedRowHandle);
            frm.ProTypeAction = false;
            frm.ProRow = row;
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            LoadCustomerPayment("");


        }
        private void DeleteCustomerPayment()
        {
            if (grvCustomerPayment.RowCount == 0 || grvCustomerPayment.FocusedRowHandle < 0)
            {
                MessageBox.Show("There is no item to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show(this, Settings.Default.strWarningDelete, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            grvCustomerPayment.GetDataRow(grvCustomerPayment.FocusedRowHandle).Delete();
            grvCustomerPayment.CloseEditor();
            grvCustomerPayment.UpdateCurrentRow();
            Globals.dtCustomerPayment.Update();
            LoadCustomerPayment("");

        }

        #endregion
        #endregion

        #region G8soft\KienDD\PaymenVendor20070728

        #region Variable
        private GridView grvVendorPayment;
        private DataView dtvVendorPayment;


        #endregion


        #region Method
        private void ShowVendorPayment()
        {
            currentGrid = SHOW_VENDOR_PAYMENT;
            LoadVendorPayment("");
        }

        private void LoadVendorPayment(string strFilter)
        {
            if (Globals.dtVendorPayment.Columns.Count == 12)
            {
                Globals.dtVendorPayment.Columns.Add("UserName", typeof(string));

            }
            grvVendorPayment = (GridView)grdCustomer.Views[0];
            grvVendorPayment.Columns.Clear();
            dtvVendorPayment = new DataView(Globals.dtVendorPayment);
            dtvVendorPayment.RowFilter = strFilter;
            grdCustomer.DataSource = dtvVendorPayment;
            foreach (GridColumn cl in grvVendorPayment.Columns)
            {
                cl.MinWidth = 10;
                cl.Visible = false;
            }


            grvVendorPayment.Columns["VendorPaymentNo"].VisibleIndex = 0;
            grvVendorPayment.Columns["OrderID"].VisibleIndex = 1;
            grvVendorPayment.Columns["OrderID"].Caption = "Purchase No";
            grvVendorPayment.Columns["PaidAmount"].VisibleIndex = 2;
            grvVendorPayment.Columns["PaidAmount"].Caption = "Paid Amount";
            grvVendorPayment.Columns["UserName"].VisibleIndex = 3;
            grvVendorPayment.Columns["UserName"].Caption = "User Created";

            grvVendorPayment.Columns["DateCreated"].VisibleIndex = 4;
            grvVendorPayment.Columns["DateCreated"].Caption = "Date Created";
            grvVendorPayment.Columns["TransactionDate"].VisibleIndex = 5;
            grvVendorPayment.Columns["TransactionDate"].Caption = "Transaction Date";
            grvVendorPayment.Columns["Description"].VisibleIndex = 6;

            for (int i = 0; i < grvVendorPayment.RowCount; i++)
            {
                grvVendorPayment.SetRowCellValue(i, "UserName", GetUserName(
                    grvVendorPayment.GetRowCellValue(i, "UserCreated").ToString()));
            }
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
        private void AddVendorPayment()
        {
            frmAddEditVendorPaymentForm frm = new frmAddEditVendorPaymentForm();
            DataRow row = Globals.dtVendorPayment.NewRow();
            row["VendorPaymentID"] = System.Guid.NewGuid();
            frm.ProTypeAction = true;
            frm.ProRow = row;
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            LoadVendorPayment("");
        }
        private void EditVendorPayment()
        {
            if (grvVendorPayment.RowCount == 0 || grvVendorPayment.FocusedRowHandle < 0)
            {
                MessageBox.Show("There is no item to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmAddEditVendorPaymentForm frm = new frmAddEditVendorPaymentForm();
            DataRow row = grvVendorPayment.GetDataRow(grvVendorPayment.FocusedRowHandle);
            frm.ProTypeAction = false;
            frm.ProRow = row;
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            LoadVendorPayment("");


        }
        private void DeleteVendorPayment()
        {
            if (grvVendorPayment.RowCount == 0 || grvVendorPayment.FocusedRowHandle < 0)
            {
                MessageBox.Show("There is no item to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show(this, Settings.Default.strWarningDelete, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            grvVendorPayment.GetDataRow(grvVendorPayment.FocusedRowHandle).Delete();
            grvVendorPayment.CloseEditor();
            grvVendorPayment.UpdateCurrentRow();
            Globals.dtVendorPayment.Update();
            LoadVendorPayment("");

        }

        private void SeachVendorPayment()
        {

        }
        #endregion

        private void mnuSVendorPayments_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowVendorPayment();
        }
        private void mnuSCustomerPayments_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowCustomerPayment();
        }

        #endregion

        #region G8soft\KienDD\20070729UOM

        #region Variable
        private GridView grvUOM;
        private DataView dtvUOM;
        private const int SHOW_UOM = 24;
        #endregion
        #region Method
        private void ShowUOM()
        {
            currentGrid = SHOW_UOM;
            LoadUOM("");
        }
        private void LoadUOM(string strFilter)
        {
            grvUOM = (GridView)grdCustomer.Views[0];
            grvUOM.Columns.Clear();
            dtvUOM = new DataView(Globals.dtUOM);
            dtvUOM.RowFilter = strFilter;
            grdCustomer.DataSource = dtvUOM;
            grvUOM.Columns["UOMID"].VisibleIndex = -1;
            grvUOM.Columns["Note"].VisibleIndex = 0;
            grvUOM.Columns["Note"].Caption = "UOM";
            grvUOM.Columns["ViewStatus"].VisibleIndex = 1;
            grvUOM.Columns["ViewStatus"].Caption = "View Status";
        }
        private void AddUOM()
        {
            frmAddEditUOM frm = new frmAddEditUOM();
            DataRow row = Globals.dtUOM.NewRow();


            frm.ProTypeAdd = true;
            frm.ProRow = row;
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            LoadUOM("");
        }
        private void EditUOM()
        {
            if (grvUOM.RowCount == 0 || grvUOM.FocusedRowHandle < 0)
            {
                MessageBox.Show("There is no item to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmAddEditUOM frm = new frmAddEditUOM();
            DataRow row = grvUOM.GetDataRow(grvUOM.FocusedRowHandle);
            frm.ProTypeAdd = false;
            frm.ProRow = row;
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            row = frm.ProRow;
            Globals.dtUOM.Update();
            LoadUOM("");


        }
        private void DeleteUOM()
        {
            if (grvUOM.RowCount == 0 || grvUOM.FocusedRowHandle < 0)
            {
                MessageBox.Show("There is no item to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CheckExistUOMInProduct(grvUOM.GetFocusedRowCellValue("UOMID").ToString()))
            {
                MessageBox.Show("Cannot delete this record because some table are using it", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show(this, Settings.Default.strWarningDelete, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            grvUOM.GetDataRow(grvUOM.FocusedRowHandle).Delete();
            grvUOM.CloseEditor();
            grvUOM.UpdateCurrentRow();
            Globals.dtUOM.Update();
            LoadUOM("");

        }
        private bool CheckExistUOMInProduct(string UOMID)
        {
            DA_DataTable dtProductMaster = new DA_DataTable("select * from ProductMaster where UOMID='" + UOMID + "'", false);
            if (dtProductMaster.Rows.Count > 0)
                return true;
            else
                return false;
        }
        #endregion
        #region Event
        private void mnuListOtherUOM_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowUOM();
        }

        #endregion


        #endregion

        #region G8Soft\KienDd\20070729\WarehouseLOcation
        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLocationMaster frm = new frmLocationMaster();
            frm.ShowDialog();
            frm.Dispose();

        }
        #endregion

        #region G8Soft\KienDD\20070729\Warehouse
        #region Variable

        private GridView grvWarehouseMaster;
        private DataView dtvWarehouseMaster;
        private const int SHOW_WAREHOUSE_MASTER = 25;
        #endregion
        #region Method
        private void ShowWarehouseMaster()
        {
            currentGrid = SHOW_WAREHOUSE_MASTER;
            LoadWarehouseMaster("");
        }

        private void LoadWarehouseMaster(string strFilter)
        {

            grvWarehouseMaster = (GridView)grdCustomer.Views[0];
            grvWarehouseMaster.Columns.Clear();
            dtvWarehouseMaster = new DataView(Globals.dtWarehouse_Master);
            dtvWarehouseMaster.RowFilter = strFilter;
            dtvWarehouseMaster.Sort = "Warehouse_code";
            grdCustomer.DataSource = dtvWarehouseMaster;
            foreach (GridColumn cl in grvWarehouseMaster.Columns)
            {
                cl.MinWidth = 10;
                cl.Visible = false;
            }
            //grvWarehouseMaster.Columns["Description"].VisibleIndex = 0;
            //grvWarehouseMaster.Columns["Address line"].VisibleIndex = 1;
            //grvWarehouseMaster.Columns["Country"].VisibleIndex = 2;
            //grvWarehouseMaster.Columns["Country"].Caption = "City";
            grvWarehouseMaster.Columns["Warehouse_code"].VisibleIndex = 0;
            grvWarehouseMaster.Columns["Description"].VisibleIndex = 1;

            grvWarehouseMaster.Columns["Warehouse_code"].Caption = "Warehouse Code";
            grvWarehouseMaster.Columns["Description"].Caption = "Warehouse Name";


        }
        private void AddWarehouseMaster()
        {
            DataRow row = Globals.dtWarehouse_Master.NewRow();
            frmAddEditWarehouse frm = new frmAddEditWarehouse();
            frm.ProRowWarehouse = row;
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                row = frm.ProRowWarehouse;
                row["UserID"] = Globals.UserID;
                row["Warehouse_id"] = System.Guid.NewGuid();
                Globals.dtWarehouse_Master.Rows.Add(row);
                Globals.dtWarehouse_Master.Update();
                LoadWarehouseMaster("");

            }

        }
        private void EditWarehouseMaster()
        {
            if (grvWarehouseMaster.RowCount == 0 || grvWarehouseMaster.FocusedRowHandle < 0)
            {
                MessageBox.Show("There is no item to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRow row = grvWarehouseMaster.GetDataRow(grvWarehouseMaster.FocusedRowHandle);
            frmAddEditWarehouse frm = new frmAddEditWarehouse();
            frm.ProRowWarehouse = row;
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                row = frm.ProRowWarehouse;
                Globals.dtWarehouse_Master.Update();
                LoadWarehouseMaster("");

            }



        }
        private void DeleteWarehouseMaster()
        {
            if (grvWarehouseMaster.RowCount == 0 || grvWarehouseMaster.FocusedRowHandle < 0)
            {
                MessageBox.Show("There is no item to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CheckExistWarehouseInLocation(grvWarehouseMaster.GetFocusedRowCellValue("Warehouse_id").ToString()))
            {
                MessageBox.Show("Cannot delete this record because some table are using it", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show(this, Settings.Default.strWarningDelete, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            grvWarehouseMaster.GetDataRow(grvWarehouseMaster.FocusedRowHandle).Delete();
            Globals.dtWarehouse_Master.Update();
            LoadWarehouseMaster("");

        }
        private bool CheckExistWarehouseInLocation(string warehouse_id)
        {
            DataRow[] arrRow = Globals.dtLocation_Master.Select("Warehouse_id='" + warehouse_id + "'");
            if (arrRow.Length > 0)
                return true;
            return false;

        }
        #endregion
        #region Event
        private void mnuSWarehouse_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowWarehouseMaster();
        }

        #endregion



        #endregion

        #region G8Soft\KienDD\20070804\Sale Return.
        #region Variable

        private GridView grvSaleReturnMaster;
        private DataView dtvSaleReturnMaster;
        private DA_DataTable dtSaleReturnMaster;
        private const int SHOW_SALE_RETURN_MASTER = 26;

        private GridView grvPurchaseReturnMaster;
        private DataView dtvPurchaseReturnMaster;
        private DA_DataTable dtPurchaseReturnMaster;
        private const int SHOW_PURCHASE_RETURN_MASTER = 30;
        #endregion
        #region Method
        private void ShowSaleReturnMaster()
        {
            currentGrid = SHOW_SALE_RETURN_MASTER;
            LoadSaleReturnMaster("");
        }
        private void LoadSaleReturnMaster(string strFilter)
        {
            dtSaleReturnMaster = new DA_DataTable("select * from SaleReturnMaster", false);
            grvSaleReturnMaster = (GridView)grdCustomer.Views[0];
            grvSaleReturnMaster.Columns.Clear();
            dtvSaleReturnMaster = new DataView(dtSaleReturnMaster);
            dtvSaleReturnMaster.RowFilter = strFilter;
            dtvSaleReturnMaster.Sort = "SaleReturnNo";
            grdCustomer.DataSource = dtvSaleReturnMaster;
            foreach (GridColumn cl in grvSaleReturnMaster.Columns)
            {
                cl.MinWidth = 10;
                cl.Visible = false;
            }
            grvSaleReturnMaster.Columns["SaleReturnNo"].VisibleIndex = 0;
            grvSaleReturnMaster.Columns["Notes"].VisibleIndex = 1;
            grvSaleReturnMaster.Columns["TotalAmount"].VisibleIndex = 3;
            grvSaleReturnMaster.Columns["SaleReturnNo"].Caption = "Sale Return No";
            grvSaleReturnMaster.Columns["Notes"].Caption = "Reasons";
            grvSaleReturnMaster.Columns["ReturnCharge"].Caption = "Return Charge";
            grvSaleReturnMaster.Columns["TotalAmount"].Caption = "Total Amount";
            grvSaleReturnMaster.Columns["SaleReturnDate"].Caption = "Sale Return Date";



        }

        private void AddSaleReturnMaster()
        {

            frmAddEditSaleReturnMaster frm = new frmAddEditSaleReturnMaster();
            frm.ProIsAdd = true;
            DataRow row = dtSaleReturnMaster.NewRow();

            frm.ProRow = row;
            if (frm.ShowDialog(this) == DialogResult.OK)
            {

                LoadSaleReturnMaster("");

            }

        }
        private void AddPurchaseReturnMaster()
        {

            frmAddEditPurchaseReturnMaster frm = new frmAddEditPurchaseReturnMaster();
            frm.ProIsAdd = true;
            DataRow row = dtPurchaseReturnMaster.NewRow();

            frm.ProRow = row;
            if (frm.ShowDialog(this) == DialogResult.OK)
            {

                LoadPurchaseReturnMaster("");

            }

        }
        private void EditSaleReturnMaster()
        {
            if (grvSaleReturnMaster.RowCount == 0 || grvSaleReturnMaster.FocusedRowHandle < 0)
            {
                MessageBox.Show("There is no item to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRow row = grvSaleReturnMaster.GetDataRow(grvSaleReturnMaster.FocusedRowHandle);
            frmAddEditSaleReturnMaster frm = new frmAddEditSaleReturnMaster();
            frm.ProIsAdd = false;
            frm.ProRow = row;
            if (frm.ShowDialog(this) == DialogResult.OK)
            {

                LoadSaleReturnMaster("");

            }



        }
        private void DeleteSaleReturnMaster()
        {
            if (grvSaleReturnMaster.RowCount == 0 || grvSaleReturnMaster.FocusedRowHandle < 0)
            {
                MessageBox.Show("There is no item to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show(this, Settings.Default.strWarningDelete, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            grvSaleReturnMaster.GetDataRow(grvSaleReturnMaster.FocusedRowHandle).Delete();
            dtSaleReturnMaster.Update();
            LoadSaleReturnMaster("");

        }
        private void ShowPurchaseReturnMaster()
        {
            currentGrid = SHOW_PURCHASE_RETURN_MASTER;
            LoadPurchaseReturnMaster("");
        }
        private void LoadPurchaseReturnMaster(string strFilter)
        {
            dtPurchaseReturnMaster = new DA_DataTable("select * from PurchaseReturnMaster", false);
            grvPurchaseReturnMaster = (GridView)grdCustomer.Views[0];
            grvPurchaseReturnMaster.Columns.Clear();
            dtvPurchaseReturnMaster = new DataView(dtPurchaseReturnMaster);
            dtvPurchaseReturnMaster.RowFilter = strFilter;
            dtvPurchaseReturnMaster.Sort = "PurchaseReturnNo";
            grdCustomer.DataSource = dtvPurchaseReturnMaster;
            foreach (GridColumn cl in grvPurchaseReturnMaster.Columns)
            {
                cl.MinWidth = 10;
                cl.Visible = false;
            }
            grvPurchaseReturnMaster.Columns["PurchaseReturnNo"].VisibleIndex = 0;
            grvPurchaseReturnMaster.Columns["Notes"].VisibleIndex = 1;
            grvPurchaseReturnMaster.Columns["TotalAmount"].VisibleIndex = 3;
            grvPurchaseReturnMaster.Columns["PurchaseReturnNo"].Caption = "Purchase Return No";
            grvPurchaseReturnMaster.Columns["Notes"].Caption = "Reasons";
            grvPurchaseReturnMaster.Columns["ReturnCharge"].Caption = "Return Charge";
            grvPurchaseReturnMaster.Columns["TotalAmount"].Caption = "Total Amount";
            grvPurchaseReturnMaster.Columns["PurchaseReturnDate"].Caption = "Purchase Return Date";



        }
        private void EditPurchaseReturnMaster()
        {
            if (grvPurchaseReturnMaster.RowCount == 0 || grvPurchaseReturnMaster.FocusedRowHandle < 0)
            {
                MessageBox.Show("There is no item to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRow row = grvPurchaseReturnMaster.GetDataRow(grvPurchaseReturnMaster.FocusedRowHandle);
            frmAddEditPurchaseReturnMaster frm = new frmAddEditPurchaseReturnMaster();
            frm.ProIsAdd = false;
            frm.ProRow = row;
            if (frm.ShowDialog(this) == DialogResult.OK)
            {

                LoadPurchaseReturnMaster("");

            }
        }
        private void DeletePurchaseReturnMaster()
        {
            if (grvPurchaseReturnMaster.RowCount == 0 || grvPurchaseReturnMaster.FocusedRowHandle < 0)
            {
                MessageBox.Show("There is no item to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show(this, Settings.Default.strWarningDelete, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            grvPurchaseReturnMaster.GetDataRow(grvPurchaseReturnMaster.FocusedRowHandle).Delete();
            dtPurchaseReturnMaster.Update();
            LoadPurchaseReturnMaster("");

        }

        #endregion
        #region Event
        private void mnuDailyOperationOrderingOrderReturn_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowSaleReturnMaster();
        }

        #endregion

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowPurchaseReturnMaster();
        }

        #endregion

        private void mnuSSR_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowSaleReturnMaster();
        }

        private void mnuSUOM_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowUOM();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCurrencyManagement frm;
            frm = new frmCurrencyManagement();
            //G8_POS.frmCurrency frm;
            //frm = new G8_POS.frmCurrency();
            //if (IsHasRight(Globals.UserID,"6AF67D7F-965B-4D61-9D52-B585488252E9",false))
            //    frm.Administrator = true;
            //else
            //{
            //     frm.UserName = Globals.UserName;
            //     frm.UserID = Globals.UserID;
            // }
            // frm.Connection = Globals.strVISConnection;
            frm.ShowDialog(this);
        }

        private void mnuSPayTerms_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddEditPayment frm = new AddEditPayment();
            frm.ShowDialog();
        }

        private void mnuSTax_ItemClick(object sender, ItemClickEventArgs e)
        {
            G8_POS.FrmTaxInformation frm = new G8_POS.FrmTaxInformation();
            frm.Connection = Globals.strVISConnection;
            frm.ShowDialog(this);
        }

        private void mnuSPayMethods_ItemClick(object sender, ItemClickEventArgs e)
        {
            G8_POS.PaymentMethod frm = new G8_POS.PaymentMethod();
            frm.IsAdmin = true;
            frm.ShowDialog();
            frm.Dispose();
        }

        #region KienPD\Delivery Method Management\20070804

        #region Variables
        private GridView grvDeliveryMethod;
        private DataView dtvDeliveryMethod;
        private const int SHOW_DELIVERY_METHOD = 27;
        #endregion

        #region Events
        private void mnuDeliveryMethod_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowDeliveryMethod();
        }
        #endregion
        #region Method
        private void ShowDeliveryMethod()
        {
            currentGrid = SHOW_DELIVERY_METHOD;
            LoadDeliveryMethod("");
        }

        private void LoadDeliveryMethod(string strFilter)
        {
            grvDeliveryMethod = (GridView)grdCustomer.Views[0];
            grvDeliveryMethod.Columns.Clear();
            dtvDeliveryMethod = new DataView(Globals.dtDeliveryMethod);
            dtvDeliveryMethod.RowFilter = strFilter;
            grdCustomer.DataSource = dtvDeliveryMethod;
            grvDeliveryMethod.Columns["DeliveryMethodID"].VisibleIndex = -1;
            grvDeliveryMethod.Columns["Name"].VisibleIndex = 0;
            grvDeliveryMethod.Columns["Notes"].VisibleIndex = 1;
            grvDeliveryMethod.Columns["ViewStatus"].VisibleIndex = 2;
            grvDeliveryMethod.Columns["ViewStatus"].Caption = "View Status";
        }

        private void AddDeliveryMethod()
        {
            frmAddEditDeliveryMethod frm = new frmAddEditDeliveryMethod();
            DataRow row = Globals.dtDeliveryMethod.NewRow();

            frm.ProTypeAdd = true;
            frm.ProRow = row;
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            LoadDeliveryMethod("");
        }

        private void EditDeliveryMethod()
        {
            if (grvDeliveryMethod.RowCount == 0 || grvDeliveryMethod.FocusedRowHandle < 0)
            {
                MessageBox.Show("There is no item to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmAddEditDeliveryMethod frm = new frmAddEditDeliveryMethod();
            DataRow row = grvDeliveryMethod.GetDataRow(grvDeliveryMethod.FocusedRowHandle);
            frm.ProTypeAdd = false;
            frm.ProRow = row;
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            row = frm.ProRow;
            Globals.dtDeliveryMethod.Update();
            LoadDeliveryMethod("");


        }
        private void DeleteDeliveryMethod()
        {
            if (grvDeliveryMethod.RowCount == 0 || grvDeliveryMethod.FocusedRowHandle < 0)
            {
                MessageBox.Show("There is no item to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show(this, Settings.Default.strWarningDelete, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            grvDeliveryMethod.GetDataRow(grvDeliveryMethod.FocusedRowHandle).Delete();
            grvDeliveryMethod.CloseEditor();
            grvDeliveryMethod.UpdateCurrentRow();
            Globals.dtDeliveryMethod.Update();
            LoadDeliveryMethod("");

        }
        #endregion


        #endregion

        #region KienPD\ShipVia Method\20070806
        #region Variables
        private GridView grvShipViaMethod;
        private DataView dtvShipViaMethod;
        private const int SHOW_SHIP_VIA_METHOD = 28;
        #endregion
        #region Method
        private void ShowShipViaMethod()
        {
            currentGrid = SHOW_SHIP_VIA_METHOD;
            LoadShipViaMethod("");
        }

        private void LoadShipViaMethod(string strFilter)
        {
            grvShipViaMethod = (GridView)grdCustomer.Views[0];
            grvShipViaMethod.Columns.Clear();
            dtvShipViaMethod = new DataView(Globals.dtShipViaMethod);
            dtvShipViaMethod.RowFilter = strFilter;
            grdCustomer.DataSource = dtvShipViaMethod;
            grvShipViaMethod.Columns["ID"].VisibleIndex = -1;
            grvShipViaMethod.Columns["Name"].VisibleIndex = 0;
            grvShipViaMethod.Columns["Notes"].VisibleIndex = 1;
            grvShipViaMethod.Columns["ViewStatus"].VisibleIndex = 2;
            grvShipViaMethod.Columns["ViewStatus"].Caption = "View Status";
        }

        private void AddShipViaMethod()
        {
            frmAddEditShipViaMethod frm = new frmAddEditShipViaMethod();
            DataRow row = Globals.dtShipViaMethod.NewRow();

            frm.ProTypeAdd = true;
            frm.ProRow = row;
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            LoadShipViaMethod("");
        }

        private void EditShipViaMethod()
        {
            if (grvShipViaMethod.RowCount == 0 || grvShipViaMethod.FocusedRowHandle < 0)
            {
                MessageBox.Show("There is no item to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmAddEditShipViaMethod frm = new frmAddEditShipViaMethod();
            DataRow row = grvShipViaMethod.GetDataRow(grvShipViaMethod.FocusedRowHandle);
            frm.ProTypeAdd = false;
            frm.ProRow = row;
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            row = frm.ProRow;
            Globals.dtShipViaMethod.Update();
            LoadShipViaMethod("");


        }
        private void DeleteShipViaMethod()
        {
            if (grvShipViaMethod.RowCount == 0 || grvShipViaMethod.FocusedRowHandle < 0)
            {
                MessageBox.Show("There is no item to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show(this, Settings.Default.strWarningDelete, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            grvShipViaMethod.GetDataRow(grvShipViaMethod.FocusedRowHandle).Delete();
            grvShipViaMethod.CloseEditor();
            grvShipViaMethod.UpdateCurrentRow();
            Globals.dtShipViaMethod.Update();
            LoadShipViaMethod("");

        }
        #endregion

        private void mnuSShipViaList_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowShipViaMethod();
        }
        #endregion

        #region KienPD\Package Type Master\20070806
        #region Variables
        private GridView grvPackageType;
        private DataView dtvPackageType;
        private const int SHOW_PACKAGE_TYPE = 29;
        #endregion
        private void mnuPackageTypeMaster_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowPackageType();
        }
        #region Method
        private void ShowPackageType()
        {
            currentGrid = SHOW_PACKAGE_TYPE;
            LoadPackageType("");
        }

        private void LoadPackageType(string strFilter)
        {
            grvPackageType = (GridView)grdCustomer.Views[0];
            grvPackageType.Columns.Clear();
            dtvPackageType = new DataView(Globals.dtPackageType);
            dtvPackageType.RowFilter = strFilter;
            grdCustomer.DataSource = dtvPackageType;
            grvPackageType.Columns["Package_type"].VisibleIndex = -1;
            grvPackageType.Columns["UserID"].VisibleIndex = -1;
            grvPackageType.Columns["Timestamp"].VisibleIndex = -1;
            grvPackageType.Columns["Notes"].VisibleIndex = -1;
            grvPackageType.Columns["Storage pack text"].VisibleIndex = 0;
            grvPackageType.Columns["Max_weight"].VisibleIndex = 1;
            grvPackageType.Columns["Max_length"].VisibleIndex = 2;
            grvPackageType.Columns["Max_height"].VisibleIndex = 3;
            grvPackageType.Columns["Max_width"].VisibleIndex = 4;
            grvPackageType.Columns["Storage_volume"].VisibleIndex = 5;
            grvPackageType.Columns["ViewStatus"].VisibleIndex = 6;
            grvPackageType.Columns["ViewStatus"].Caption = "View Status";
        }

        private void AddPackageType()
        {
            frmAddEditPackageTypeMaster frm = new frmAddEditPackageTypeMaster();
            DataRow row = Globals.dtPackageType.NewRow();

            frm.ProTypeAdd = true;
            frm.ProRow = row;
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            LoadPackageType("");
        }

        private void EditPackageType()
        {
            if (grvPackageType.RowCount == 0 || grvPackageType.FocusedRowHandle < 0)
            {
                MessageBox.Show("There is no item to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmAddEditPackageTypeMaster frm = new frmAddEditPackageTypeMaster();
            DataRow row = grvPackageType.GetDataRow(grvPackageType.FocusedRowHandle);
            frm.ProTypeAdd = false;
            frm.ProRow = row;
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            row = frm.ProRow;
            Globals.dtPackageType.Update();
            LoadPackageType("");


        }
        private void DeletePackageType()
        {
            if (grvPackageType.RowCount == 0 || grvPackageType.FocusedRowHandle < 0)
            {
                MessageBox.Show("There is no item to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show(this, Settings.Default.strWarningDelete, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            grvPackageType.GetDataRow(grvPackageType.FocusedRowHandle).Delete();
            grvPackageType.CloseEditor();
            grvPackageType.UpdateCurrentRow();
            Globals.dtPackageType.Update();
            LoadPackageType("");

        }
        #endregion

        private void mnuSPR_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowPurchaseReturnMaster();
        }




        #endregion

        private void mnuSShipVia_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowShipViaMethod();
        }

        #region KienPD\Operation Period\20070806
        private void mnuSClosePeriod_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Commands.StockTake.ClosePeriodCommand cmdClose = new ClosePeriodCommand();
            //cmdClose.Execute();
            ShowOperationPeriod();
        }
        #region Variables
        private GridView grvOperationPeriod;
        private DataView dtvOperationPeriod;
        private const int SHOW_OPERATION_PERIOD = 31;
        #endregion
        #region Method
        private void ShowOperationPeriod()
        {
            currentGrid = SHOW_OPERATION_PERIOD;
            LoadOperationPeriod("");
        }

        private void LoadOperationPeriod(string strFilter)
        {
            grvOperationPeriod = (GridView)grdCustomer.Views[0];
            grvOperationPeriod.Columns.Clear();
            dtvOperationPeriod = new DataView(Globals.dtOperationPeriod);
            dtvOperationPeriod.RowFilter = strFilter;
            grdCustomer.DataSource = dtvOperationPeriod;
            grvOperationPeriod.Columns["ID"].VisibleIndex = -1;
            grvOperationPeriod.Columns["PeriodTypeID"].VisibleIndex = -1;
            grvOperationPeriod.Columns["ViewStatus"].VisibleIndex = -1;
        }

        private void AddOperationPeriod()
        {
            Commands.StockTake.ClosePeriodCommand cmdClose = new ClosePeriodCommand();
            cmdClose.Execute();
            LoadOperationPeriod("");
        }

        private void EditOperationPeriod()
        {
            frmOpenClosePeriod frm = new frmOpenClosePeriod();
            if (frm.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            Globals.dtOperationPeriod.Update();

            LoadOperationPeriod("");
        }
        private void DeleteOperationPeriod()
        {
            if (grvOperationPeriod.RowCount == 0 || grvOperationPeriod.FocusedRowHandle < 0)
            {
                MessageBox.Show("There is no item to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show(this, Settings.Default.strWarningDelete, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            grvOperationPeriod.GetDataRow(grvOperationPeriod.FocusedRowHandle).Delete();
            grvOperationPeriod.CloseEditor();
            grvOperationPeriod.UpdateCurrentRow();
            Globals.dtOperationPeriod.Update();
            LoadOperationPeriod("");
        }
        #endregion
        #endregion
    }
}
