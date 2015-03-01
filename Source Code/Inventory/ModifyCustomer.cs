using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;
using Inventory.Properties;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Inventory
{
    /// <summary>
    /// Summary description for ModifyContact.
    /// </summary>
    public class ModifyCustomer : DevExpress.XtraEditors.XtraForm
    {
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel2;
        private OpenFileDialog openFileDialog1;
        private TextEdit textEdit40;
        private Label label53;
        private TextEdit textEdit41;
        private Label label54;
        private TextEdit textEdit42;
        private Label label55;
        private TextEdit textEdit43;
        private Label label56;
        private TextEdit textEdit44;
        private Label label57;
        private TextEdit textEdit45;
        private Label label58;
        private Label label59;
        private TextEdit textEdit46;
        private Label label60;
        private TextEdit textEdit47;
        private TextEdit textEdit48;
        private Label label61;
        private TextEdit textEdit49;
        private Label label62;
        private GroupControl groupControl8;
        private Label label79;
        private CheckEdit chkViewStatus;
        private CheckEdit chkSubscribeNew;
        private GroupControl groupControl7;
        private TextEdit txtShippingEmailAddr;
        private Label label82;
        private TextEdit txtShippingPhoneNo;
        private Label label17;
        private TextEdit txtShippingZip;
        private Label label81;
        private TextEdit txtShippingCountry;
        private Label label80;
        private TextEdit txtShippingState;
        private Label label84;
        private TextEdit txtShippingCity;
        private Label label85;
        private TextEdit txtShippingAddr;
        private Label label86;
        private GroupControl groupControl1;
        private TextEdit txtBillingEmailAddr;
        private TextEdit txtBillingCountry;
        private Label label74;
        private Label label78;
        private TextEdit txtBillingPhoneNo;
        private Label label77;
        private TextEdit txtBillingZip;
        private Label label76;
        private TextEdit txtBillingState;
        private Label label75;
        private TextEdit txtBillingCity;
        private Label label73;
        private TextEdit txtBillingAddress;
        private Label label11;
        private SimpleButton btnOK;
        private GroupControl groupControl6;
        private TextEdit txtWebsite;
        private Label label63;
        private TextEdit txtEmail3;
        private Label label64;
        private TextEdit txtEmail2;
        private Label label65;
        private TextEdit txtEmail1;
        private Label label66;
        private TextEdit txtCell2;
        private Label label67;
        private TextEdit txtCell1;
        private Label label68;
        private Label label69;
        private TextEdit txtFax2;
        private Label label70;
        private TextEdit txtFax1;
        private TextEdit txtPhoneNo2;
        private Label label71;
        private TextEdit txtPhoneNo1;
        private Label label72;
        private SimpleButton btnCancel;
        private GroupControl groupControl5;
        private TextEdit txtAltContact;
        private Label label39;
        private TextEdit txtCompanyName;
        private TextEdit txtContactName;
        private TextEdit txtEmailName;
        private Label label40;
        private TextEdit txtCountry;
        private Label label41;
        private TextEdit txtZip;
        private Label label42;
        private TextEdit txtProvince;
        private Label label43;
        private TextEdit txtCity;
        private Label label44;
        private TextEdit txtAddress2;
        private Label label45;
        private TextEdit txtAddress1;
        private Label label46;
        private Label label47;
        private Label label48;
        private Label label49;
        private TextEdit txtLastName;
        private Label label50;
        private TextEdit txtMiddleName;
        private Label label51;
        private ComboBoxEdit cmbMrMrs;
        private Label label52;
        private TextEdit txtFirstName;
        private GroupControl groupControl4;
        private MemoEdit memNotes;
        private Label label12;
        private Label label13;
        private Label label16;
        private TextEdit txtAccountName;
        private Label label18;
        private Label label19;
        private TextEdit txtDiscount;
        private Label label34;
        private TextEdit txtBalance;
        private Label label35;
        private TextEdit txtCurrency;
        private Label label36;
        private TextEdit txtCreditLimit;
        private Label label37;
        private TextEdit txtAccountNumber;
        private Label label38;
        private ComboBoxEdit cmbPaymentTermName;
        private ComboBoxEdit cmbTaxCode;
        private ButtonEdit bteParent;
        private ComboBoxEdit cmbTaxAgent;
        private ButtonEdit bteCategory;
        private Label label1;
        private IContainer components;

        private string ParentID = "";
        public ModifyCustomer()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            cmbMrMrs.Properties.Items.Add(Settings.Default.strMr);
            cmbMrMrs.Properties.Items.Add(Settings.Default.strMrs);
            cmbMrMrs.Properties.Items.Add(Settings.Default.strMiss);
            cmbMrMrs.Properties.Items.Add(Settings.Default.strMs);            
            ctmCustomer = new Customer();
            LoadTaxTab();
            LoadPaymentTab();
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
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.defaultLookAndFeel2 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textEdit40 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit41 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit42 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit43 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit44 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit45 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit46 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit47 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit48 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit49 = new DevExpress.XtraEditors.TextEdit();
            this.groupControl8 = new DevExpress.XtraEditors.GroupControl();
            this.bteCategory = new DevExpress.XtraEditors.ButtonEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.bteParent = new DevExpress.XtraEditors.ButtonEdit();
            this.label79 = new System.Windows.Forms.Label();
            this.chkViewStatus = new DevExpress.XtraEditors.CheckEdit();
            this.chkSubscribeNew = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.cmbTaxAgent = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbTaxCode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbPaymentTermName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.memNotes = new DevExpress.XtraEditors.MemoEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAccountName = new DevExpress.XtraEditors.TextEdit();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDiscount = new DevExpress.XtraEditors.TextEdit();
            this.label34 = new System.Windows.Forms.Label();
            this.txtBalance = new DevExpress.XtraEditors.TextEdit();
            this.label35 = new System.Windows.Forms.Label();
            this.txtCurrency = new DevExpress.XtraEditors.TextEdit();
            this.label36 = new System.Windows.Forms.Label();
            this.txtCreditLimit = new DevExpress.XtraEditors.TextEdit();
            this.label37 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new DevExpress.XtraEditors.TextEdit();
            this.label38 = new System.Windows.Forms.Label();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.txtShippingEmailAddr = new DevExpress.XtraEditors.TextEdit();
            this.label82 = new System.Windows.Forms.Label();
            this.txtShippingPhoneNo = new DevExpress.XtraEditors.TextEdit();
            this.label17 = new System.Windows.Forms.Label();
            this.txtShippingZip = new DevExpress.XtraEditors.TextEdit();
            this.label81 = new System.Windows.Forms.Label();
            this.txtShippingCountry = new DevExpress.XtraEditors.TextEdit();
            this.label80 = new System.Windows.Forms.Label();
            this.txtShippingState = new DevExpress.XtraEditors.TextEdit();
            this.label84 = new System.Windows.Forms.Label();
            this.txtShippingCity = new DevExpress.XtraEditors.TextEdit();
            this.label85 = new System.Windows.Forms.Label();
            this.txtShippingAddr = new DevExpress.XtraEditors.TextEdit();
            this.label86 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtBillingEmailAddr = new DevExpress.XtraEditors.TextEdit();
            this.txtBillingCountry = new DevExpress.XtraEditors.TextEdit();
            this.label74 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.txtBillingPhoneNo = new DevExpress.XtraEditors.TextEdit();
            this.label77 = new System.Windows.Forms.Label();
            this.txtBillingZip = new DevExpress.XtraEditors.TextEdit();
            this.label76 = new System.Windows.Forms.Label();
            this.txtBillingState = new DevExpress.XtraEditors.TextEdit();
            this.label75 = new System.Windows.Forms.Label();
            this.txtBillingCity = new DevExpress.XtraEditors.TextEdit();
            this.label73 = new System.Windows.Forms.Label();
            this.txtBillingAddress = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.txtWebsite = new DevExpress.XtraEditors.TextEdit();
            this.label63 = new System.Windows.Forms.Label();
            this.txtEmail3 = new DevExpress.XtraEditors.TextEdit();
            this.label64 = new System.Windows.Forms.Label();
            this.txtEmail2 = new DevExpress.XtraEditors.TextEdit();
            this.label65 = new System.Windows.Forms.Label();
            this.txtEmail1 = new DevExpress.XtraEditors.TextEdit();
            this.label66 = new System.Windows.Forms.Label();
            this.txtCell2 = new DevExpress.XtraEditors.TextEdit();
            this.label67 = new System.Windows.Forms.Label();
            this.txtCell1 = new DevExpress.XtraEditors.TextEdit();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.txtFax2 = new DevExpress.XtraEditors.TextEdit();
            this.label70 = new System.Windows.Forms.Label();
            this.txtFax1 = new DevExpress.XtraEditors.TextEdit();
            this.txtPhoneNo2 = new DevExpress.XtraEditors.TextEdit();
            this.label71 = new System.Windows.Forms.Label();
            this.txtPhoneNo1 = new DevExpress.XtraEditors.TextEdit();
            this.label72 = new System.Windows.Forms.Label();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.txtAltContact = new DevExpress.XtraEditors.TextEdit();
            this.label39 = new System.Windows.Forms.Label();
            this.txtCompanyName = new DevExpress.XtraEditors.TextEdit();
            this.txtContactName = new DevExpress.XtraEditors.TextEdit();
            this.txtEmailName = new DevExpress.XtraEditors.TextEdit();
            this.label40 = new System.Windows.Forms.Label();
            this.txtCountry = new DevExpress.XtraEditors.TextEdit();
            this.label41 = new System.Windows.Forms.Label();
            this.txtZip = new DevExpress.XtraEditors.TextEdit();
            this.label42 = new System.Windows.Forms.Label();
            this.txtProvince = new DevExpress.XtraEditors.TextEdit();
            this.label43 = new System.Windows.Forms.Label();
            this.txtCity = new DevExpress.XtraEditors.TextEdit();
            this.label44 = new System.Windows.Forms.Label();
            this.txtAddress2 = new DevExpress.XtraEditors.TextEdit();
            this.label45 = new System.Windows.Forms.Label();
            this.txtAddress1 = new DevExpress.XtraEditors.TextEdit();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.label50 = new System.Windows.Forms.Label();
            this.txtMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.label51 = new System.Windows.Forms.Label();
            this.cmbMrMrs = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label52 = new System.Windows.Forms.Label();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit40.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit41.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit42.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit43.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit44.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit45.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit46.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit47.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit48.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit49.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).BeginInit();
            this.groupControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteParent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSubscribeNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTaxAgent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTaxCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPaymentTermName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreditLimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShippingEmailAddr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShippingPhoneNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShippingZip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShippingCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShippingState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShippingCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShippingAddr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillingEmailAddr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillingCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillingPhoneNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillingZip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillingState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillingCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillingAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCell2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCell1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNo2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltContact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProvince.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMrMrs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.defaultLookAndFeel1.LookAndFeel.UseWindowsXPTheme = false;
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
            // textEdit40
            // 
            this.textEdit40.Location = new System.Drawing.Point(92, 167);
            this.textEdit40.Name = "textEdit40";
            this.textEdit40.Size = new System.Drawing.Size(368, 21);
            this.textEdit40.TabIndex = 59;
            // 
            // textEdit41
            // 
            this.textEdit41.Location = new System.Drawing.Point(334, 115);
            this.textEdit41.Name = "textEdit41";
            this.textEdit41.Size = new System.Drawing.Size(126, 21);
            this.textEdit41.TabIndex = 57;
            // 
            // textEdit42
            // 
            this.textEdit42.Location = new System.Drawing.Point(92, 141);
            this.textEdit42.Name = "textEdit42";
            this.textEdit42.Size = new System.Drawing.Size(126, 21);
            this.textEdit42.TabIndex = 55;
            // 
            // textEdit43
            // 
            this.textEdit43.Location = new System.Drawing.Point(92, 115);
            this.textEdit43.Name = "textEdit43";
            this.textEdit43.Size = new System.Drawing.Size(126, 21);
            this.textEdit43.TabIndex = 53;
            // 
            // textEdit44
            // 
            this.textEdit44.Location = new System.Drawing.Point(334, 80);
            this.textEdit44.Name = "textEdit44";
            this.textEdit44.Size = new System.Drawing.Size(126, 21);
            this.textEdit44.TabIndex = 51;
            // 
            // textEdit45
            // 
            this.textEdit45.Location = new System.Drawing.Point(92, 77);
            this.textEdit45.Name = "textEdit45";
            this.textEdit45.Size = new System.Drawing.Size(126, 21);
            this.textEdit45.TabIndex = 49;
            // 
            // textEdit46
            // 
            this.textEdit46.Location = new System.Drawing.Point(334, 53);
            this.textEdit46.Name = "textEdit46";
            this.textEdit46.Size = new System.Drawing.Size(126, 21);
            this.textEdit46.TabIndex = 46;
            // 
            // textEdit47
            // 
            this.textEdit47.Location = new System.Drawing.Point(92, 50);
            this.textEdit47.Name = "textEdit47";
            this.textEdit47.Size = new System.Drawing.Size(126, 21);
            this.textEdit47.TabIndex = 44;
            // 
            // textEdit48
            // 
            this.textEdit48.Location = new System.Drawing.Point(334, 24);
            this.textEdit48.Name = "textEdit48";
            this.textEdit48.Size = new System.Drawing.Size(126, 21);
            this.textEdit48.TabIndex = 42;
            // 
            // textEdit49
            // 
            this.textEdit49.Location = new System.Drawing.Point(92, 24);
            this.textEdit49.Name = "textEdit49";
            this.textEdit49.Size = new System.Drawing.Size(126, 21);
            this.textEdit49.TabIndex = 29;
            // 
            // groupControl8
            // 
            this.groupControl8.Controls.Add(this.bteCategory);
            this.groupControl8.Controls.Add(this.label1);
            this.groupControl8.Controls.Add(this.bteParent);
            this.groupControl8.Controls.Add(this.label79);
            this.groupControl8.Controls.Add(this.chkViewStatus);
            this.groupControl8.Controls.Add(this.chkSubscribeNew);
            this.groupControl8.Location = new System.Drawing.Point(11, 584);
            this.groupControl8.Name = "groupControl8";
            this.groupControl8.Size = new System.Drawing.Size(473, 77);
            this.groupControl8.TabIndex = 89;
            this.groupControl8.Text = "Member Detail";
            this.groupControl8.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl8_Paint);
            // 
            // bteCategory
            // 
            this.bteCategory.Location = new System.Drawing.Point(191, 49);
            this.bteCategory.Name = "bteCategory";
            this.bteCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteCategory.Properties.ReadOnly = true;
            this.bteCategory.Size = new System.Drawing.Size(264, 21);
            this.bteCategory.TabIndex = 76;
            this.bteCategory.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteCategory_ButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCategory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Location = new System.Drawing.Point(132, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 77;
            this.label1.Text = global::Inventory.Properties.Settings.Default.strCategory;
            // 
            // bteParent
            // 
            this.bteParent.Location = new System.Drawing.Point(191, 20);
            this.bteParent.Name = "bteParent";
            this.bteParent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteParent.Properties.ReadOnly = true;
            this.bteParent.Size = new System.Drawing.Size(264, 21);
            this.bteParent.TabIndex = 52;
            this.bteParent.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
            this.bteParent.EditValueChanged += new System.EventHandler(this.buttonEdit1_EditValueChanged);
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strParentID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label79.Location = new System.Drawing.Point(132, 25);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(59, 14);
            this.label79.TabIndex = 75;
            this.label79.Text = global::Inventory.Properties.Settings.Default.strParentID;
            // 
            // chkViewStatus
            // 
            this.chkViewStatus.Location = new System.Drawing.Point(9, 49);
            this.chkViewStatus.Name = "chkViewStatus";
            this.chkViewStatus.Properties.Caption = "View Status";
            this.chkViewStatus.Size = new System.Drawing.Size(108, 19);
            this.chkViewStatus.TabIndex = 50;
            // 
            // chkSubscribeNew
            // 
            this.chkSubscribeNew.Location = new System.Drawing.Point(9, 23);
            this.chkSubscribeNew.Name = "chkSubscribeNew";
            this.chkSubscribeNew.Properties.Caption = "Subscribe News";
            this.chkSubscribeNew.Size = new System.Drawing.Size(108, 19);
            this.chkSubscribeNew.TabIndex = 49;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.cmbTaxAgent);
            this.groupControl4.Controls.Add(this.cmbTaxCode);
            this.groupControl4.Controls.Add(this.cmbPaymentTermName);
            this.groupControl4.Controls.Add(this.memNotes);
            this.groupControl4.Controls.Add(this.label12);
            this.groupControl4.Controls.Add(this.label13);
            this.groupControl4.Controls.Add(this.label16);
            this.groupControl4.Controls.Add(this.txtAccountName);
            this.groupControl4.Controls.Add(this.label18);
            this.groupControl4.Controls.Add(this.label19);
            this.groupControl4.Controls.Add(this.txtDiscount);
            this.groupControl4.Controls.Add(this.label34);
            this.groupControl4.Controls.Add(this.txtBalance);
            this.groupControl4.Controls.Add(this.label35);
            this.groupControl4.Controls.Add(this.txtCurrency);
            this.groupControl4.Controls.Add(this.label36);
            this.groupControl4.Controls.Add(this.txtCreditLimit);
            this.groupControl4.Controls.Add(this.label37);
            this.groupControl4.Controls.Add(this.txtAccountNumber);
            this.groupControl4.Controls.Add(this.label38);
            this.groupControl4.Location = new System.Drawing.Point(490, 1);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(260, 433);
            this.groupControl4.TabIndex = 87;
            this.groupControl4.Text = "Financial Information";
            // 
            // cmbTaxAgent
            // 
            this.cmbTaxAgent.Location = new System.Drawing.Point(122, 236);
            this.cmbTaxAgent.Name = "cmbTaxAgent";
            this.cmbTaxAgent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTaxAgent.Size = new System.Drawing.Size(125, 21);
            this.cmbTaxAgent.TabIndex = 33;
            // 
            // cmbTaxCode
            // 
            this.cmbTaxCode.Location = new System.Drawing.Point(122, 51);
            this.cmbTaxCode.Name = "cmbTaxCode";
            this.cmbTaxCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTaxCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbTaxCode.Size = new System.Drawing.Size(125, 21);
            this.cmbTaxCode.TabIndex = 26;
            // 
            // cmbPaymentTermName
            // 
            this.cmbPaymentTermName.Location = new System.Drawing.Point(122, 25);
            this.cmbPaymentTermName.Name = "cmbPaymentTermName";
            this.cmbPaymentTermName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPaymentTermName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbPaymentTermName.Size = new System.Drawing.Size(125, 21);
            this.cmbPaymentTermName.TabIndex = 25;
            // 
            // memNotes
            // 
            this.memNotes.Location = new System.Drawing.Point(19, 289);
            this.memNotes.Name = "memNotes";
            this.memNotes.Size = new System.Drawing.Size(229, 138);
            this.memNotes.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strNotes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label12.Location = new System.Drawing.Point(16, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 14);
            this.label12.TabIndex = 80;
            this.label12.Text = global::Inventory.Properties.Settings.Default.strNotes;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPaymentTerm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label13.Location = new System.Drawing.Point(16, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 14);
            this.label13.TabIndex = 78;
            this.label13.Text = global::Inventory.Properties.Settings.Default.strPaymentTerm;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strTaxName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label16.Location = new System.Drawing.Point(16, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 14);
            this.label16.TabIndex = 72;
            this.label16.Text = global::Inventory.Properties.Settings.Default.strTaxName;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(122, 80);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(126, 21);
            this.txtAccountName.TabIndex = 27;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strAccountName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label18.Location = new System.Drawing.Point(16, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 14);
            this.label18.TabIndex = 68;
            this.label18.Text = global::Inventory.Properties.Settings.Default.strAccountName;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strTaxAgent", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label19.Location = new System.Drawing.Point(16, 239);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 14);
            this.label19.TabIndex = 66;
            this.label19.Text = global::Inventory.Properties.Settings.Default.strTaxAgent;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(122, 210);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDiscount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDiscount.Properties.Mask.EditMask = "n0";
            this.txtDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDiscount.Properties.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtDiscount_Properties_EditValueChanging);
            this.txtDiscount.Size = new System.Drawing.Size(126, 21);
            this.txtDiscount.TabIndex = 32;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strDiscount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label34.Location = new System.Drawing.Point(16, 213);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(54, 14);
            this.label34.TabIndex = 64;
            this.label34.Text = global::Inventory.Properties.Settings.Default.strDiscount;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(122, 184);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtBalance.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtBalance.Properties.Mask.EditMask = "N0";
            this.txtBalance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBalance.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtBalance.Properties.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtBalance_Properties_EditValueChanging);
            this.txtBalance.Size = new System.Drawing.Size(126, 21);
            this.txtBalance.TabIndex = 31;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strBalance", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label35.Location = new System.Drawing.Point(16, 187);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(48, 14);
            this.label35.TabIndex = 62;
            this.label35.Text = global::Inventory.Properties.Settings.Default.strBalance;
            // 
            // txtCurrency
            // 
            this.txtCurrency.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", global::Inventory.Properties.Settings.Default, "cfgDefaultCurrency", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCurrency.EditValue = global::Inventory.Properties.Settings.Default.cfgDefaultCurrency;
            this.txtCurrency.Location = new System.Drawing.Point(122, 158);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Properties.Mask.EditMask = "[a-zA-Z]{1,3}";
            this.txtCurrency.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCurrency.Size = new System.Drawing.Size(126, 21);
            this.txtCurrency.TabIndex = 30;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCurrency", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label36.Location = new System.Drawing.Point(16, 161);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(55, 14);
            this.label36.TabIndex = 60;
            this.label36.Text = global::Inventory.Properties.Settings.Default.strCurrency;
            // 
            // txtCreditLimit
            // 
            this.txtCreditLimit.Location = new System.Drawing.Point(122, 132);
            this.txtCreditLimit.Name = "txtCreditLimit";
            this.txtCreditLimit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCreditLimit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCreditLimit.Properties.Mask.EditMask = "N0";
            this.txtCreditLimit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCreditLimit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCreditLimit.Properties.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtCreditLimit_Properties_EditValueChanging);
            this.txtCreditLimit.Size = new System.Drawing.Size(126, 21);
            this.txtCreditLimit.TabIndex = 29;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCreditLimit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label37.Location = new System.Drawing.Point(16, 135);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(68, 14);
            this.label37.TabIndex = 58;
            this.label37.Text = global::Inventory.Properties.Settings.Default.strCreditLimit;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(122, 106);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAccountNumber.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAccountNumber.Properties.Mask.EditMask = "N0";
            this.txtAccountNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAccountNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtAccountNumber.Properties.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtAccountNumber_Properties_EditValueChanging);
            this.txtAccountNumber.Size = new System.Drawing.Size(126, 21);
            this.txtAccountNumber.TabIndex = 28;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strAccountNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label38.Location = new System.Drawing.Point(16, 109);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(99, 14);
            this.label38.TabIndex = 56;
            this.label38.Text = global::Inventory.Properties.Settings.Default.strAccountNumber;
            // 
            // groupControl7
            // 
            this.groupControl7.Controls.Add(this.txtShippingEmailAddr);
            this.groupControl7.Controls.Add(this.label82);
            this.groupControl7.Controls.Add(this.txtShippingPhoneNo);
            this.groupControl7.Controls.Add(this.label17);
            this.groupControl7.Controls.Add(this.txtShippingZip);
            this.groupControl7.Controls.Add(this.label81);
            this.groupControl7.Controls.Add(this.txtShippingCountry);
            this.groupControl7.Controls.Add(this.label80);
            this.groupControl7.Controls.Add(this.txtShippingState);
            this.groupControl7.Controls.Add(this.label84);
            this.groupControl7.Controls.Add(this.txtShippingCity);
            this.groupControl7.Controls.Add(this.label85);
            this.groupControl7.Controls.Add(this.txtShippingAddr);
            this.groupControl7.Controls.Add(this.label86);
            this.groupControl7.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strShipping", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupControl7.Location = new System.Drawing.Point(491, 451);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(260, 207);
            this.groupControl7.TabIndex = 90;
            this.groupControl7.Text = global::Inventory.Properties.Settings.Default.strShipping;
            // 
            // txtShippingEmailAddr
            // 
            this.txtShippingEmailAddr.Location = new System.Drawing.Point(122, 179);
            this.txtShippingEmailAddr.Name = "txtShippingEmailAddr";
            this.txtShippingEmailAddr.Properties.Mask.EditMask = "[a-zA-Z_0-9]+[@][a-zA-Z_0-9]+[.][a-zA-Z_0-9]+([.][a-zA-Z0-9]+)*";
            this.txtShippingEmailAddr.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtShippingEmailAddr.Size = new System.Drawing.Size(126, 21);
            this.txtShippingEmailAddr.TabIndex = 48;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strEmailAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label82.Location = new System.Drawing.Point(16, 182);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(81, 14);
            this.label82.TabIndex = 80;
            this.label82.Text = global::Inventory.Properties.Settings.Default.strEmailAddress;
            // 
            // txtShippingPhoneNo
            // 
            this.txtShippingPhoneNo.Location = new System.Drawing.Point(122, 153);
            this.txtShippingPhoneNo.Name = "txtShippingPhoneNo";
            this.txtShippingPhoneNo.Properties.Mask.EditMask = "([(][0-9]+[)])?[0-9]+";
            this.txtShippingPhoneNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtShippingPhoneNo.Size = new System.Drawing.Size(126, 21);
            this.txtShippingPhoneNo.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPhoneNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label17.Location = new System.Drawing.Point(16, 156);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 14);
            this.label17.TabIndex = 78;
            this.label17.Text = global::Inventory.Properties.Settings.Default.strPhoneNo;
            // 
            // txtShippingZip
            // 
            this.txtShippingZip.Location = new System.Drawing.Point(122, 127);
            this.txtShippingZip.Name = "txtShippingZip";
            this.txtShippingZip.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d-\\d\\d\\d\\d";
            this.txtShippingZip.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtShippingZip.Size = new System.Drawing.Size(126, 21);
            this.txtShippingZip.TabIndex = 46;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strZipPostal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label81.Location = new System.Drawing.Point(16, 130);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(60, 14);
            this.label81.TabIndex = 76;
            this.label81.Text = global::Inventory.Properties.Settings.Default.strZipPostal;
            // 
            // txtShippingCountry
            // 
            this.txtShippingCountry.Location = new System.Drawing.Point(122, 101);
            this.txtShippingCountry.Name = "txtShippingCountry";
            this.txtShippingCountry.Size = new System.Drawing.Size(126, 21);
            this.txtShippingCountry.TabIndex = 45;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCountry", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label80.Location = new System.Drawing.Point(16, 104);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(50, 14);
            this.label80.TabIndex = 74;
            this.label80.Text = global::Inventory.Properties.Settings.Default.strCountry;
            // 
            // txtShippingState
            // 
            this.txtShippingState.Location = new System.Drawing.Point(122, 75);
            this.txtShippingState.Name = "txtShippingState";
            this.txtShippingState.Size = new System.Drawing.Size(126, 21);
            this.txtShippingState.TabIndex = 44;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label84.Location = new System.Drawing.Point(16, 78);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(37, 14);
            this.label84.TabIndex = 72;
            this.label84.Text = global::Inventory.Properties.Settings.Default.strState;
            // 
            // txtShippingCity
            // 
            this.txtShippingCity.Location = new System.Drawing.Point(122, 49);
            this.txtShippingCity.Name = "txtShippingCity";
            this.txtShippingCity.Size = new System.Drawing.Size(126, 21);
            this.txtShippingCity.TabIndex = 43;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCityTown", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label85.Location = new System.Drawing.Point(16, 52);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(64, 14);
            this.label85.TabIndex = 70;
            this.label85.Text = global::Inventory.Properties.Settings.Default.strCityTown;
            // 
            // txtShippingAddr
            // 
            this.txtShippingAddr.Location = new System.Drawing.Point(122, 23);
            this.txtShippingAddr.Name = "txtShippingAddr";
            this.txtShippingAddr.Size = new System.Drawing.Size(126, 21);
            this.txtShippingAddr.TabIndex = 42;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label86.Location = new System.Drawing.Point(16, 26);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(50, 14);
            this.label86.TabIndex = 68;
            this.label86.Text = global::Inventory.Properties.Settings.Default.strAddress;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtBillingEmailAddr);
            this.groupControl1.Controls.Add(this.txtBillingCountry);
            this.groupControl1.Controls.Add(this.label74);
            this.groupControl1.Controls.Add(this.label78);
            this.groupControl1.Controls.Add(this.txtBillingPhoneNo);
            this.groupControl1.Controls.Add(this.label77);
            this.groupControl1.Controls.Add(this.txtBillingZip);
            this.groupControl1.Controls.Add(this.label76);
            this.groupControl1.Controls.Add(this.txtBillingState);
            this.groupControl1.Controls.Add(this.label75);
            this.groupControl1.Controls.Add(this.txtBillingCity);
            this.groupControl1.Controls.Add(this.label73);
            this.groupControl1.Controls.Add(this.txtBillingAddress);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strBilling", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupControl1.Location = new System.Drawing.Point(11, 451);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(473, 127);
            this.groupControl1.TabIndex = 88;
            this.groupControl1.Text = global::Inventory.Properties.Settings.Default.strBilling;
            // 
            // txtBillingEmailAddr
            // 
            this.txtBillingEmailAddr.Location = new System.Drawing.Point(334, 75);
            this.txtBillingEmailAddr.Name = "txtBillingEmailAddr";
            this.txtBillingEmailAddr.Properties.Mask.EditMask = "[a-zA-Z_0-9]+[@][a-zA-Z_0-9]+[.][a-zA-Z_0-9]+([.][a-zA-Z0-9]+)*";
            this.txtBillingEmailAddr.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtBillingEmailAddr.Size = new System.Drawing.Size(126, 21);
            this.txtBillingEmailAddr.TabIndex = 40;
            // 
            // txtBillingCountry
            // 
            this.txtBillingCountry.Location = new System.Drawing.Point(92, 101);
            this.txtBillingCountry.Name = "txtBillingCountry";
            this.txtBillingCountry.Size = new System.Drawing.Size(126, 21);
            this.txtBillingCountry.TabIndex = 42;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCountry", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label74.Location = new System.Drawing.Point(2, 104);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(50, 14);
            this.label74.TabIndex = 72;
            this.label74.Text = global::Inventory.Properties.Settings.Default.strCountry;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strEmailAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label78.Location = new System.Drawing.Point(244, 78);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(81, 14);
            this.label78.TabIndex = 78;
            this.label78.Text = global::Inventory.Properties.Settings.Default.strEmailAddress;
            // 
            // txtBillingPhoneNo
            // 
            this.txtBillingPhoneNo.Location = new System.Drawing.Point(334, 49);
            this.txtBillingPhoneNo.Name = "txtBillingPhoneNo";
            this.txtBillingPhoneNo.Properties.Mask.EditMask = "(\\(\\d\\d\\d\\))?\\d{1,3}-\\d\\d-\\d\\d";
            this.txtBillingPhoneNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtBillingPhoneNo.Size = new System.Drawing.Size(126, 21);
            this.txtBillingPhoneNo.TabIndex = 38;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPhoneNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label77.Location = new System.Drawing.Point(244, 52);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(89, 14);
            this.label77.TabIndex = 76;
            this.label77.Text = global::Inventory.Properties.Settings.Default.strPhoneNo;
            // 
            // txtBillingZip
            // 
            this.txtBillingZip.Location = new System.Drawing.Point(334, 23);
            this.txtBillingZip.Name = "txtBillingZip";
            this.txtBillingZip.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d-\\d\\d\\d\\d";
            this.txtBillingZip.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtBillingZip.Size = new System.Drawing.Size(126, 21);
            this.txtBillingZip.TabIndex = 36;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strZipPostal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label76.Location = new System.Drawing.Point(244, 26);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(60, 14);
            this.label76.TabIndex = 74;
            this.label76.Text = global::Inventory.Properties.Settings.Default.strZipPostal;
            // 
            // txtBillingState
            // 
            this.txtBillingState.Location = new System.Drawing.Point(92, 75);
            this.txtBillingState.Name = "txtBillingState";
            this.txtBillingState.Size = new System.Drawing.Size(126, 21);
            this.txtBillingState.TabIndex = 39;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label75.Location = new System.Drawing.Point(2, 78);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(37, 14);
            this.label75.TabIndex = 72;
            this.label75.Text = global::Inventory.Properties.Settings.Default.strState;
            // 
            // txtBillingCity
            // 
            this.txtBillingCity.Location = new System.Drawing.Point(92, 49);
            this.txtBillingCity.Name = "txtBillingCity";
            this.txtBillingCity.Size = new System.Drawing.Size(126, 21);
            this.txtBillingCity.TabIndex = 37;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCityTown", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label73.Location = new System.Drawing.Point(2, 52);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(64, 14);
            this.label73.TabIndex = 70;
            this.label73.Text = global::Inventory.Properties.Settings.Default.strCityTown;
            // 
            // txtBillingAddress
            // 
            this.txtBillingAddress.Location = new System.Drawing.Point(92, 23);
            this.txtBillingAddress.Name = "txtBillingAddress";
            this.txtBillingAddress.Size = new System.Drawing.Size(126, 21);
            this.txtBillingAddress.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label11.Location = new System.Drawing.Point(2, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 14);
            this.label11.TabIndex = 68;
            this.label11.Text = global::Inventory.Properties.Settings.Default.strAddress;
            // 
            // btnOK
            // 
            this.btnOK.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strOK", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnOK.Location = new System.Drawing.Point(10, 667);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(109, 23);
            this.btnOK.TabIndex = 91;
            this.btnOK.Text = global::Inventory.Properties.Settings.Default.strOK;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // groupControl6
            // 
            this.groupControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl6.Controls.Add(this.txtWebsite);
            this.groupControl6.Controls.Add(this.label63);
            this.groupControl6.Controls.Add(this.txtEmail3);
            this.groupControl6.Controls.Add(this.label64);
            this.groupControl6.Controls.Add(this.txtEmail2);
            this.groupControl6.Controls.Add(this.label65);
            this.groupControl6.Controls.Add(this.txtEmail1);
            this.groupControl6.Controls.Add(this.label66);
            this.groupControl6.Controls.Add(this.txtCell2);
            this.groupControl6.Controls.Add(this.label67);
            this.groupControl6.Controls.Add(this.txtCell1);
            this.groupControl6.Controls.Add(this.label68);
            this.groupControl6.Controls.Add(this.label69);
            this.groupControl6.Controls.Add(this.txtFax2);
            this.groupControl6.Controls.Add(this.label70);
            this.groupControl6.Controls.Add(this.txtFax1);
            this.groupControl6.Controls.Add(this.txtPhoneNo2);
            this.groupControl6.Controls.Add(this.label71);
            this.groupControl6.Controls.Add(this.txtPhoneNo1);
            this.groupControl6.Controls.Add(this.label72);
            this.groupControl6.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strOtherInform", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupControl6.Location = new System.Drawing.Point(11, 237);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(473, 197);
            this.groupControl6.TabIndex = 86;
            this.groupControl6.Text = global::Inventory.Properties.Settings.Default.strOtherInform;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(92, 167);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(368, 21);
            this.txtWebsite.TabIndex = 24;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strWebsite", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label63.Location = new System.Drawing.Point(6, 170);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(52, 14);
            this.label63.TabIndex = 58;
            this.label63.Text = global::Inventory.Properties.Settings.Default.strWebsite;
            // 
            // txtEmail3
            // 
            this.txtEmail3.Location = new System.Drawing.Point(92, 141);
            this.txtEmail3.Name = "txtEmail3";
            this.txtEmail3.Properties.Mask.EditMask = "[a-zA-Z_0-9]+[@][a-zA-Z_0-9]+[.][a-zA-Z_0-9]+([.][a-zA-Z0-9]+)*";
            this.txtEmail3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmail3.Size = new System.Drawing.Size(126, 21);
            this.txtEmail3.TabIndex = 23;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strEmail3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label64.Location = new System.Drawing.Point(5, 144);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(45, 14);
            this.label64.TabIndex = 56;
            this.label64.Text = global::Inventory.Properties.Settings.Default.strEmail3;
            // 
            // txtEmail2
            // 
            this.txtEmail2.Location = new System.Drawing.Point(334, 111);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Properties.Mask.EditMask = "[a-zA-Z_0-9]+[@][a-zA-Z_0-9]+[.][a-zA-Z_0-9]+([.][a-zA-Z0-9]+)*";
            this.txtEmail2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmail2.Size = new System.Drawing.Size(126, 21);
            this.txtEmail2.TabIndex = 22;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strEmail2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label65.Location = new System.Drawing.Point(248, 114);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(45, 14);
            this.label65.TabIndex = 54;
            this.label65.Text = global::Inventory.Properties.Settings.Default.strEmail2;
            // 
            // txtEmail1
            // 
            this.txtEmail1.Location = new System.Drawing.Point(92, 115);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Properties.Mask.EditMask = "[a-zA-Z_0-9]+[@][a-zA-Z_0-9]+[.][a-zA-Z_0-9]+([.][a-zA-Z0-9]+)*";
            this.txtEmail1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmail1.Size = new System.Drawing.Size(126, 21);
            this.txtEmail1.TabIndex = 21;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strEmail1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label66.Location = new System.Drawing.Point(6, 118);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(45, 14);
            this.label66.TabIndex = 52;
            this.label66.Text = global::Inventory.Properties.Settings.Default.strEmail1;
            // 
            // txtCell2
            // 
            this.txtCell2.Location = new System.Drawing.Point(334, 80);
            this.txtCell2.Name = "txtCell2";
            this.txtCell2.Size = new System.Drawing.Size(126, 21);
            this.txtCell2.TabIndex = 20;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCell2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label67.Location = new System.Drawing.Point(247, 83);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(36, 14);
            this.label67.TabIndex = 50;
            this.label67.Text = global::Inventory.Properties.Settings.Default.strCell2;
            // 
            // txtCell1
            // 
            this.txtCell1.Location = new System.Drawing.Point(92, 77);
            this.txtCell1.Name = "txtCell1";
            this.txtCell1.Size = new System.Drawing.Size(126, 21);
            this.txtCell1.TabIndex = 19;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCell1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label68.Location = new System.Drawing.Point(5, 80);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(36, 14);
            this.label68.TabIndex = 48;
            this.label68.Text = global::Inventory.Properties.Settings.Default.strCell1;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strFax1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label69.Location = new System.Drawing.Point(5, 53);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(36, 14);
            this.label69.TabIndex = 47;
            this.label69.Text = global::Inventory.Properties.Settings.Default.strFax1;
            // 
            // txtFax2
            // 
            this.txtFax2.Location = new System.Drawing.Point(334, 53);
            this.txtFax2.Name = "txtFax2";
            this.txtFax2.Properties.Mask.EditMask = "([(][0-9]+[)])?[0-9]+";
            this.txtFax2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtFax2.Size = new System.Drawing.Size(126, 21);
            this.txtFax2.TabIndex = 18;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strFax2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label70.Location = new System.Drawing.Point(247, 56);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(36, 14);
            this.label70.TabIndex = 45;
            this.label70.Text = global::Inventory.Properties.Settings.Default.strFax2;
            // 
            // txtFax1
            // 
            this.txtFax1.Location = new System.Drawing.Point(92, 50);
            this.txtFax1.Name = "txtFax1";
            this.txtFax1.Properties.Mask.EditMask = "([(][0-9]+[)])?[0-9]+";
            this.txtFax1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtFax1.Size = new System.Drawing.Size(126, 21);
            this.txtFax1.TabIndex = 17;
            // 
            // txtPhoneNo2
            // 
            this.txtPhoneNo2.Location = new System.Drawing.Point(334, 24);
            this.txtPhoneNo2.Name = "txtPhoneNo2";
            this.txtPhoneNo2.Properties.Mask.EditMask = "([(][0-9]+[)])?[0-9]+";
            this.txtPhoneNo2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPhoneNo2.Size = new System.Drawing.Size(126, 21);
            this.txtPhoneNo2.TabIndex = 16;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPhoneNo2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label71.Location = new System.Drawing.Point(247, 27);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(53, 14);
            this.label71.TabIndex = 41;
            this.label71.Text = global::Inventory.Properties.Settings.Default.strPhoneNo2;
            // 
            // txtPhoneNo1
            // 
            this.txtPhoneNo1.Location = new System.Drawing.Point(92, 24);
            this.txtPhoneNo1.Name = "txtPhoneNo1";
            this.txtPhoneNo1.Properties.Mask.EditMask = "([(][0-9]+[)])?[0-9]+";
            this.txtPhoneNo1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPhoneNo1.Size = new System.Drawing.Size(126, 21);
            this.txtPhoneNo1.TabIndex = 15;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPhoneNo1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label72.Location = new System.Drawing.Point(5, 27);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(53, 14);
            this.label72.TabIndex = 27;
            this.label72.Text = global::Inventory.Properties.Settings.Default.strPhoneNo1;
            // 
            // btnCancel
            // 
            this.btnCancel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCancel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(125, 667);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 23);
            this.btnCancel.TabIndex = 92;
            this.btnCancel.Text = global::Inventory.Properties.Settings.Default.strCancel;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // groupControl5
            // 
            this.groupControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl5.Controls.Add(this.txtAltContact);
            this.groupControl5.Controls.Add(this.label39);
            this.groupControl5.Controls.Add(this.txtCompanyName);
            this.groupControl5.Controls.Add(this.txtContactName);
            this.groupControl5.Controls.Add(this.txtEmailName);
            this.groupControl5.Controls.Add(this.label40);
            this.groupControl5.Controls.Add(this.txtCountry);
            this.groupControl5.Controls.Add(this.label41);
            this.groupControl5.Controls.Add(this.txtZip);
            this.groupControl5.Controls.Add(this.label42);
            this.groupControl5.Controls.Add(this.txtProvince);
            this.groupControl5.Controls.Add(this.label43);
            this.groupControl5.Controls.Add(this.txtCity);
            this.groupControl5.Controls.Add(this.label44);
            this.groupControl5.Controls.Add(this.txtAddress2);
            this.groupControl5.Controls.Add(this.label45);
            this.groupControl5.Controls.Add(this.txtAddress1);
            this.groupControl5.Controls.Add(this.label46);
            this.groupControl5.Controls.Add(this.label47);
            this.groupControl5.Controls.Add(this.label48);
            this.groupControl5.Controls.Add(this.label49);
            this.groupControl5.Controls.Add(this.txtLastName);
            this.groupControl5.Controls.Add(this.label50);
            this.groupControl5.Controls.Add(this.txtMiddleName);
            this.groupControl5.Controls.Add(this.label51);
            this.groupControl5.Controls.Add(this.cmbMrMrs);
            this.groupControl5.Controls.Add(this.label52);
            this.groupControl5.Controls.Add(this.txtFirstName);
            this.groupControl5.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strNameAndAddr", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupControl5.Location = new System.Drawing.Point(11, 1);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(473, 234);
            this.groupControl5.TabIndex = 85;
            this.groupControl5.Text = global::Inventory.Properties.Settings.Default.strNameAndAddr;
            // 
            // txtAltContact
            // 
            this.txtAltContact.Location = new System.Drawing.Point(353, 84);
            this.txtAltContact.Name = "txtAltContact";
            this.txtAltContact.Size = new System.Drawing.Size(107, 21);
            this.txtAltContact.TabIndex = 8;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strAltContact", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label39.Location = new System.Drawing.Point(350, 68);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(69, 14);
            this.label39.TabIndex = 30;
            this.label39.Text = global::Inventory.Properties.Settings.Default.strAltContact;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(220, 84);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(112, 21);
            this.txtCompanyName.TabIndex = 7;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(92, 84);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(109, 21);
            this.txtContactName.TabIndex = 6;
            // 
            // txtEmailName
            // 
            this.txtEmailName.Location = new System.Drawing.Point(9, 84);
            this.txtEmailName.Name = "txtEmailName";
            this.txtEmailName.Size = new System.Drawing.Size(77, 21);
            this.txtEmailName.TabIndex = 5;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCountry", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label40.Location = new System.Drawing.Point(266, 202);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(50, 14);
            this.label40.TabIndex = 25;
            this.label40.Text = global::Inventory.Properties.Settings.Default.strCountry;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(338, 195);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(122, 21);
            this.txtCountry.TabIndex = 14;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strZipPostal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label41.Location = new System.Drawing.Point(6, 198);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(60, 14);
            this.label41.TabIndex = 23;
            this.label41.Text = global::Inventory.Properties.Settings.Default.strZipPostal;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(92, 197);
            this.txtZip.Name = "txtZip";
            this.txtZip.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d-\\d\\d\\d\\d";
            this.txtZip.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtZip.Size = new System.Drawing.Size(122, 21);
            this.txtZip.TabIndex = 13;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strProvince", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label42.Location = new System.Drawing.Point(266, 171);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(53, 14);
            this.label42.TabIndex = 21;
            this.label42.Text = global::Inventory.Properties.Settings.Default.strProvince;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(338, 168);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(122, 21);
            this.txtProvince.TabIndex = 12;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCityTown", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label43.Location = new System.Drawing.Point(6, 171);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(64, 14);
            this.label43.TabIndex = 19;
            this.label43.Text = global::Inventory.Properties.Settings.Default.strCityTown;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(92, 168);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(122, 21);
            this.txtCity.TabIndex = 11;
            this.txtCity.EditValueChanged += new System.EventHandler(this.txtCity_EditValueChanged);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strAddress2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label44.Location = new System.Drawing.Point(6, 142);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(57, 14);
            this.label44.TabIndex = 17;
            this.label44.Text = global::Inventory.Properties.Settings.Default.strAddress2;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(92, 143);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(368, 21);
            this.txtAddress2.TabIndex = 10;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strAddress1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label45.Location = new System.Drawing.Point(6, 116);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(57, 14);
            this.label45.TabIndex = 15;
            this.label45.Text = global::Inventory.Properties.Settings.Default.strAddress1;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(92, 116);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(368, 21);
            this.txtAddress1.TabIndex = 9;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCompanyName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label46.Location = new System.Drawing.Point(220, 68);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(99, 14);
            this.label46.TabIndex = 13;
            this.label46.Text = global::Inventory.Properties.Settings.Default.strCompanyName;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strContactName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label47.Location = new System.Drawing.Point(89, 68);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(85, 14);
            this.label47.TabIndex = 11;
            this.label47.Text = global::Inventory.Properties.Settings.Default.strContactName;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strEmailName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label48.Location = new System.Drawing.Point(5, 68);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(69, 14);
            this.label48.TabIndex = 9;
            this.label48.Text = global::Inventory.Properties.Settings.Default.strEmailName;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strLastName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label49.Location = new System.Drawing.Point(350, 27);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(64, 14);
            this.label49.TabIndex = 7;
            this.label49.Text = global::Inventory.Properties.Settings.Default.strLastName;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(353, 45);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(107, 21);
            this.txtLastName.TabIndex = 4;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strMiddleName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label50.Location = new System.Drawing.Point(220, 27);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(76, 14);
            this.label50.TabIndex = 5;
            this.label50.Text = global::Inventory.Properties.Settings.Default.strMiddleName;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(220, 44);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(112, 21);
            this.txtMiddleName.TabIndex = 3;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strFirstName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label51.Location = new System.Drawing.Point(89, 28);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(64, 14);
            this.label51.TabIndex = 3;
            this.label51.Text = global::Inventory.Properties.Settings.Default.strFirstName;
            // 
            // cmbMrMrs
            // 
            this.cmbMrMrs.EditValue = "(Mr Table)";
            this.cmbMrMrs.Location = new System.Drawing.Point(9, 44);
            this.cmbMrMrs.Name = "cmbMrMrs";
            this.cmbMrMrs.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmbMrMrs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbMrMrs.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cboMr_Properties_ButtonClick);
            this.cmbMrMrs.Size = new System.Drawing.Size(77, 21);
            this.cmbMrMrs.TabIndex = 1;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strMrMrs", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label52.Location = new System.Drawing.Point(6, 27);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(43, 14);
            this.label52.TabIndex = 1;
            this.label52.Text = global::Inventory.Properties.Settings.Default.strMrMrs;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(92, 45);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(109, 21);
            this.txtFirstName.TabIndex = 2;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strWebsite", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label53.Location = new System.Drawing.Point(6, 170);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(46, 13);
            this.label53.TabIndex = 58;
            this.label53.Text = global::Inventory.Properties.Settings.Default.strWebsite;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strEmail3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label54.Location = new System.Drawing.Point(247, 118);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(44, 13);
            this.label54.TabIndex = 56;
            this.label54.Text = global::Inventory.Properties.Settings.Default.strEmail3;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strEmail2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label55.Location = new System.Drawing.Point(6, 144);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(74, 13);
            this.label55.TabIndex = 54;
            this.label55.Text = global::Inventory.Properties.Settings.Default.strEmail2;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strEmail1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label56.Location = new System.Drawing.Point(6, 118);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(44, 13);
            this.label56.TabIndex = 52;
            this.label56.Text = global::Inventory.Properties.Settings.Default.strEmail1;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCell2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label57.Location = new System.Drawing.Point(247, 83);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(36, 13);
            this.label57.TabIndex = 50;
            this.label57.Text = global::Inventory.Properties.Settings.Default.strCell2;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCell1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label58.Location = new System.Drawing.Point(5, 80);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(36, 13);
            this.label58.TabIndex = 48;
            this.label58.Text = global::Inventory.Properties.Settings.Default.strCell1;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strFax1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label59.Location = new System.Drawing.Point(5, 53);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(36, 13);
            this.label59.TabIndex = 47;
            this.label59.Text = global::Inventory.Properties.Settings.Default.strFax1;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strFax2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label60.Location = new System.Drawing.Point(247, 56);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(36, 13);
            this.label60.TabIndex = 45;
            this.label60.Text = global::Inventory.Properties.Settings.Default.strFax2;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPhoneNo2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label61.Location = new System.Drawing.Point(247, 27);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(90, 13);
            this.label61.TabIndex = 41;
            this.label61.Text = global::Inventory.Properties.Settings.Default.strPhoneNo2;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPhoneNo1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label62.Location = new System.Drawing.Point(5, 27);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(90, 13);
            this.label62.TabIndex = 27;
            this.label62.Text = global::Inventory.Properties.Settings.Default.strPhoneNo1;
            // 
            // ModifyCustomer
            // 
            this.ClientSize = new System.Drawing.Size(762, 698);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl8);
            this.Controls.Add(this.groupControl7);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupControl6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupControl5);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strEditCustomer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ModifyCustomer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = global::Inventory.Properties.Settings.Default.strEditCustomer;
            this.Load += new System.EventHandler(this.ModifyContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit40.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit41.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit42.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit43.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit44.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit45.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit46.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit47.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit48.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit49.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).EndInit();
            this.groupControl8.ResumeLayout(false);
            this.groupControl8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteParent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSubscribeNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTaxAgent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTaxCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPaymentTermName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreditLimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            this.groupControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShippingEmailAddr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShippingPhoneNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShippingZip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShippingCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShippingState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShippingCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShippingAddr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillingEmailAddr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillingCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillingPhoneNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillingZip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillingState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillingCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillingAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCell2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCell1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNo2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltContact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProvince.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMrMrs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private void cboSaluation_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void cboMr_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ModifyContact_Load(object sender, EventArgs e)
        {
            txtDiscount.Properties.Mask.Culture = Globals.getCulture();
            txtBalance.Properties.Mask.Culture = Globals.getCulture();
            txtAccountNumber.Properties.Mask.Culture = Globals.getCulture();
            txtCreditLimit.Properties.Mask.Culture = Globals.getCulture();
            Globals.SetDefaultFont(this);
            cmbMrMrs.SelectedIndex = 0;
        }
        private void LoadPaymentTab()
        {
            try
            {
                Data_Access.DoSqlCommand("SELECT * FROM Payment_Term_Master");
                DataTable tab = Data_Access.GetDataSet().Tables[0].Copy();
                cmbPaymentTermName.Properties.Items.Clear();
                foreach (DataRow row in tab.Rows)
                {
                    cmbPaymentTermName.Properties.Items.Add(new TabItem(row["Payment_term_id"].ToString(), row["Payment_term_desc"].ToString()));
                }
            }
            catch (Exception) { }
        }
        private void LoadTaxTab()
        {
            try
            {
                Data_Access.DoSqlCommand("SELECT * FROM Tax_code_master");
                DataTable tab = Data_Access.GetDataSet().Tables[0].Copy();
                cmbTaxCode.Properties.Items.Clear();
                foreach (DataRow row in tab.Rows)
                {
                    cmbTaxCode.Properties.Items.Add(new TabItem(row["Tax_code_id"].ToString(), row["Tax_code_desc"].ToString()));

                }
            }
            catch (Exception) { }
        }
       
        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void grpNameAddress_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit10_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void popupContainerEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (cmbPaymentTermName.Text == "")
            {
                MessageBox.Show(this, Settings.Default.strPaymentTerm + " cannot null", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPaymentTermName.Focus();
                return;
            } else if (cmbTaxCode.Text == "")
            {
                MessageBox.Show(this, Settings.Default.strTaxName + " cannot null", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTaxCode.Focus();
                return;
            }
            else if (txtCompanyName.Text == "")
            {
                MessageBox.Show(this, Settings.Default.strCompanyName + " cannot null", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCompanyName.Focus();
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {

        }
        private Customer ctmCustomer;
        public Customer CustomerData
        {
            get { return getAllData(); }
            set { ctmCustomer = value; SetAllData(); }
        }

        private void SetAllData()
        {

            txtAccountName.Text = ctmCustomer.AccountName;
            txtAccountNumber.Text = ctmCustomer.Account_number.ToString();
            txtAddress1.Text = ctmCustomer.Address1;
            txtAddress2.Text = ctmCustomer.Address2;
            txtAltContact.Text = ctmCustomer.Alt_contact;
            txtBalance.Text = ctmCustomer.Balance.ToString();
            txtBillingAddress.Text = ctmCustomer.Billing_address;
            txtBillingCity.Text = ctmCustomer.Billing_city;
            txtBillingCountry.Text = ctmCustomer.Billing_country;
            txtBillingEmailAddr.Text = ctmCustomer.Billing_email;
            txtBillingPhoneNo.Text = ctmCustomer.Billing_phone;
            txtBillingState.Text = ctmCustomer.Billing_state;
            txtBillingZip.Text = ctmCustomer.Billing_zip;
            txtCell1.Text = ctmCustomer.Cell1;
            txtCell2.Text = ctmCustomer.Cell2;
            txtCity.Text = ctmCustomer.City;
            txtCompanyName.Text = ctmCustomer.CompanyName;
            txtContactName.Text = ctmCustomer.ContactName;
            txtCountry.Text = ctmCustomer.Country;
            txtCreditLimit.Text = ctmCustomer.Credit_limit.ToString();
            txtCurrency.Text = ctmCustomer.Currency;
            txtDiscount.Text = ctmCustomer.Discount.ToString();
            txtEmail1.Text = ctmCustomer.Email1;
            txtEmail2.Text = ctmCustomer.Email2;
            txtEmail3.Text = ctmCustomer.Email3;
            txtEmailName.Text = ctmCustomer.EmailName;
            txtFax1.Text = ctmCustomer.Fax1;
            txtFax2.Text = ctmCustomer.Fax2;
            txtFirstName.Text = ctmCustomer.FirstName;
            txtLastName.Text = ctmCustomer.LastName;
            txtMiddleName.Text = ctmCustomer.MiddleName;
            //txtPaymentTermName.Text = ctmCustomer.Payment_term_Name;
            for (int i = 0; i < cmbPaymentTermName.Properties.Items.Count; i++)
            {
                TabItem item = (TabItem)cmbPaymentTermName.Properties.Items[i];
                if (item.ItemID == ctmCustomer.Payment_term_id)
                {
                    cmbPaymentTermName.SelectedIndex = i;
                    break;
                }
            }

            txtPhoneNo1.Text = ctmCustomer.Phone1;
            txtPhoneNo2.Text = ctmCustomer.Phone2;
            txtProvince.Text = ctmCustomer.Province;
            txtShippingAddr.Text = ctmCustomer.Shipping_address1;
            txtShippingCity.Text = ctmCustomer.Shipping_city;
            txtShippingCountry.Text = ctmCustomer.Shipping_country;
            txtShippingEmailAddr.Text = ctmCustomer.Shipping_email;
            txtShippingPhoneNo.Text = ctmCustomer.Shipping_phone;
            txtShippingState.Text = ctmCustomer.Shipping_state;
            txtShippingZip.Text = ctmCustomer.Shipping_zip;
            //txtTaxAgent.Text = ctmCustomer.Tax_agent;
            //txtTaxCodeName.Text = ctmCustomer.Tax_Code_Name;
            for (int i = 0; i < cmbTaxCode.Properties.Items.Count; i++)
            {
                TabItem item = (TabItem)cmbTaxCode.Properties.Items[i];
                if (item.ItemID == ctmCustomer.Tax_code_id)
                {
                    cmbTaxCode.SelectedIndex = i;
                    break;
                }
            }
            cmbMrMrs.Text = ctmCustomer.Mr;
            txtWebsite.Text = ctmCustomer.Website;
            txtZip.Text = ctmCustomer.Zip;
            memNotes.Text = ctmCustomer.Notes;
            chkSubscribeNew.Checked = ctmCustomer.SubscribeNews;
            chkViewStatus.Checked = ctmCustomer.ViewStatus;
            bteParent.Text = ContactBase.GetContactName(ctmCustomer.Parent_id);
            ParentID = ctmCustomer.Parent_id;
            if (catList == null)
                bteCategory.Text = DA_Category.getCategoriesName(ctmCustomer.ContactID);
            else
            bteCategory.Text = DA_Category.getCategoriesName(catList);
            
        }
        private Customer getAllData()
        {
            ctmCustomer.Mr = cmbMrMrs.Text;
            try
            {
                ctmCustomer.Account_number = Convert.ToInt32(txtAccountNumber.EditValue.ToString());
            }
            catch (Exception) { }
            ctmCustomer.AccountName = txtAccountName.Text;

            
            ctmCustomer.Alt_contact =txtAltContact.Text;
            try
            {
                ctmCustomer.Balance = Convert.ToInt32(txtBalance.EditValue.ToString());
            }
            catch (Exception) { }
            ctmCustomer.Billing_address = txtBillingAddress.Text;
            ctmCustomer.Billing_city = txtBillingCity.Text;
            ctmCustomer.Billing_country = txtBillingCountry.Text;
            ctmCustomer.Billing_email = txtBillingEmailAddr.Text;
            ctmCustomer.Billing_phone = txtBillingPhoneNo.Text;
            ctmCustomer.Billing_state = txtBillingState.Text;
            ctmCustomer.Billing_zip = txtBillingZip.Text;
            ctmCustomer.Cell1 = txtCell1.Text;
            ctmCustomer.Cell2 = txtCell2.Text;
            ctmCustomer.City = txtCity.Text;
            ctmCustomer.CompanyName = txtCompanyName.Text;
            ctmCustomer.ContactName = txtContactName.Text;
            ctmCustomer.Country = txtCountry.Text;
            ctmCustomer.Parent_id = ParentID;
            ctmCustomer.Address1 = txtAddress1.Text;
            ctmCustomer.Address2 = txtAddress2.Text;
            try
            {
                ctmCustomer.Credit_limit = Convert.ToInt32(txtCreditLimit.EditValue.ToString());
            }
            catch (Exception) { }
            ctmCustomer.Currency = txtCurrency.Text;
            try
            {
                ctmCustomer.Discount = Convert.ToInt32(txtDiscount.EditValue.ToString());
            }
            catch (Exception) { }
            ctmCustomer.Email1 = txtEmail1.Text;
            ctmCustomer.Email2 = txtEmail2.Text;
            ctmCustomer.Email3 = txtEmail3.Text;
            ctmCustomer.EmailName = txtEmailName.Text;
            ctmCustomer.Fax1 = txtFax1.Text;
            ctmCustomer.Fax2 = txtFax2.Text;
            ctmCustomer.FirstName = txtFirstName.Text;
            ctmCustomer.LastName = txtLastName.Text;
            ctmCustomer.MiddleName = txtMiddleName.Text;
            //ctmCustomer.Payment_term_Name = txtPaymentTermName.Text;
            ctmCustomer.Phone1 = txtPhoneNo1.Text;
            ctmCustomer.Phone2 = txtPhoneNo2.Text;
            ctmCustomer.Province = txtProvince.Text;
            ctmCustomer.Shipping_address1 = txtShippingAddr.Text;
            ctmCustomer.Shipping_city = txtShippingCity.Text;
            ctmCustomer.Shipping_country = txtShippingCountry.Text;
            ctmCustomer.Shipping_email = txtShippingEmailAddr.Text;
            ctmCustomer.Shipping_phone = txtShippingPhoneNo.Text;
            ctmCustomer.Shipping_state = txtShippingState.Text;
            ctmCustomer.Shipping_zip = txtShippingZip.Text;
            ctmCustomer.Tax_agent = cmbTaxAgent.Text;
            try
            {
                TabItem item = (TabItem)cmbTaxCode.SelectedItem;
                ctmCustomer.Tax_Code_Name = item.ItemName;
                ctmCustomer.Tax_code_id = item.ItemID;
            }
            catch (Exception) { }

            try
            {
                TabItem item = (TabItem)cmbPaymentTermName.SelectedItem;
                ctmCustomer.Payment_term_Name = item.ItemName;
                ctmCustomer.Payment_term_id = item.ItemID;
            }
            catch (Exception) { }
            ctmCustomer.Website = txtWebsite.Text;
            ctmCustomer.Zip = txtZip.Text;
            ctmCustomer.Notes = memNotes.Text;
            ctmCustomer.SubscribeNews = chkSubscribeNew.Checked;
            ctmCustomer.ViewStatus = chkViewStatus.Checked;
            ctmCustomer.UserID = Globals.UserID;
           
            return ctmCustomer;
        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SelectCustomer frm = new SelectCustomer();
            frm.CustomerID = ParentID;
            frm.ChildID = ctmCustomer.ContactID;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                bteParent.Text = frm.CustomerName;
                ParentID = frm.CustomerID;
            }
        }

        private void txtCity_EditValueChanged(object sender, EventArgs e)
        {
            
            
        }
        public CategoryRec[] Categories
        {
            get { return catList; }
            set { catList = value; }
        }
        private CategoryRec[] catList = null;
        private void bteCategory_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Category frm = new Category();
            frm.ContactID = ctmCustomer.ContactID;
            frm.SetCategories(catList);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                bteCategory.Text = "";
                CategoryRec[] recs = frm.GetCategories();
                catList = recs;
                foreach (CategoryRec r in recs)
                {
                 if (r.status != -1)
                    bteCategory.Text += " " + r.ToString() + ",";
                }
                if (bteCategory.Text.Length > 0)
                    bteCategory.Text = bteCategory.Text.Remove(bteCategory.Text.Length - 1);
            }    
        }

        private void txtDiscount_Properties_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue.ToString() == "") return;
            if (Convert.ToInt64(e.NewValue) > Int32.MaxValue) e.Cancel = true;
        }

        private void txtBalance_Properties_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue.ToString() == "") return;
            if (Convert.ToInt64(e.NewValue) > Int32.MaxValue) e.Cancel = true;
        }

        private void txtAccountNumber_Properties_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue.ToString() == "") return;
            if (Convert.ToInt64(e.NewValue) > Int32.MaxValue) e.Cancel = true;
        }

        private void txtCreditLimit_Properties_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue.ToString() == "") return;
            if (Convert.ToInt64(e.NewValue) > Int32.MaxValue) e.Cancel = true;
        }

        private void groupControl8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}

