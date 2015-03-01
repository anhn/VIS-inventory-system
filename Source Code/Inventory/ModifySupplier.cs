using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Inventory.Properties;

using System.Data;
using System.Data.SqlClient;

namespace Inventory
{
    /// <summary>
    /// Summary description for ModifyContact.
    /// </summary>
    public class ModifySupplier : DevExpress.XtraEditors.XtraForm
    {
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel2;
        private SimpleButton btnCancel;
        private SimpleButton btnOK;
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
        private GroupControl groupControl3;
        private CheckEdit chkViewStatus;
        private CheckEdit chkSubscribeNews;
        private GroupControl grpInfo;
        private TextEdit txtWebsite;
        private Label label10;
        private TextEdit txtEmail3;
        private Label label9;
        private TextEdit txtEmail2;
        private Label label8;
        private TextEdit txtEmail1;
        private Label label7;
        private TextEdit textEdit2;
        private Label label6;
        private TextEdit textEdit1;
        private Label label5;
        private Label label3;
        private TextEdit txtFax2;
        private Label label4;
        private TextEdit txtFax1;
        private TextEdit txtPhoneNo2;
        private Label label2;
        private TextEdit txtPhoneNo1;
        private Label lblPhoneNo;
        private GroupControl grpNameAddress;
        private TextEdit txtAltContact;
        private Label label1;
        private TextEdit txtCompanyName;
        private TextEdit txtContactName;
        private TextEdit txtEmailName;
        private Label lblCountry;
        private TextEdit txtCountry;
        private Label lblZip;
        private TextEdit txtZip;
        private Label lblProvince;
        private TextEdit txtProvince;
        private Label lblCity;
        private TextEdit txtCity;
        private Label lblAddress2;
        private TextEdit txtAddress2;
        private Label lblAddress1;
        private TextEdit txtAddress1;
        private Label lblOccpation;
        private Label lblSaluation;
        private Label lblGender;
        private Label lblLastName;
        private TextEdit txtLastName;
        private Label lblMiddleName;
        private TextEdit txtMiddleName;
        private Label lblFirstName;
        private ComboBoxEdit cmbMrMrs;
        private Label lblMr;
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
        private ComboBoxEdit cmbTaxCode;
        private ComboBoxEdit cmbPaymentTermName;
        private ComboBoxEdit cmbTaxAgent;
        private ButtonEdit txtParent;
        private Label label79;
        private ButtonEdit bteCategory;
        private Label label11;
        private IContainer components;

        public ModifySupplier()
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
            
            splSupplier = new Supplier();
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
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
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.bteCategory = new DevExpress.XtraEditors.ButtonEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.txtParent = new DevExpress.XtraEditors.ButtonEdit();
            this.label79 = new System.Windows.Forms.Label();
            this.chkViewStatus = new DevExpress.XtraEditors.CheckEdit();
            this.chkSubscribeNews = new DevExpress.XtraEditors.CheckEdit();
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
            this.grpInfo = new DevExpress.XtraEditors.GroupControl();
            this.txtWebsite = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail3 = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail2 = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail1 = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFax2 = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFax1 = new DevExpress.XtraEditors.TextEdit();
            this.txtPhoneNo2 = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneNo1 = new DevExpress.XtraEditors.TextEdit();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.grpNameAddress = new DevExpress.XtraEditors.GroupControl();
            this.txtAltContact = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompanyName = new DevExpress.XtraEditors.TextEdit();
            this.txtContactName = new DevExpress.XtraEditors.TextEdit();
            this.txtEmailName = new DevExpress.XtraEditors.TextEdit();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new DevExpress.XtraEditors.TextEdit();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtZip = new DevExpress.XtraEditors.TextEdit();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtProvince = new DevExpress.XtraEditors.TextEdit();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new DevExpress.XtraEditors.TextEdit();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtAddress2 = new DevExpress.XtraEditors.TextEdit();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtAddress1 = new DevExpress.XtraEditors.TextEdit();
            this.lblOccpation = new System.Windows.Forms.Label();
            this.lblSaluation = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cmbMrMrs = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblMr = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSubscribeNews.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.grpInfo)).BeginInit();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNo2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNameAddress)).BeginInit();
            this.grpNameAddress.SuspendLayout();
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
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(122, 581);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 23);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(7, 581);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(109, 23);
            this.btnOK.TabIndex = 38;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
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
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.bteCategory);
            this.groupControl3.Controls.Add(this.label11);
            this.groupControl3.Controls.Add(this.txtParent);
            this.groupControl3.Controls.Add(this.label79);
            this.groupControl3.Controls.Add(this.chkViewStatus);
            this.groupControl3.Controls.Add(this.chkSubscribeNews);
            this.groupControl3.Location = new System.Drawing.Point(12, 491);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(473, 84);
            this.groupControl3.TabIndex = 88;
            this.groupControl3.Text = "Details";
            // 
            // bteCategory
            // 
            this.bteCategory.Location = new System.Drawing.Point(190, 54);
            this.bteCategory.Name = "bteCategory";
            this.bteCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteCategory.Properties.ReadOnly = true;
            this.bteCategory.Size = new System.Drawing.Size(264, 21);
            this.bteCategory.TabIndex = 38;
            this.bteCategory.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteCategory_ButtonClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCategory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label11.Location = new System.Drawing.Point(132, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 14);
            this.label11.TabIndex = 86;
            this.label11.Text = global::Inventory.Properties.Settings.Default.strCategory;
            // 
            // txtParent
            // 
            this.txtParent.Location = new System.Drawing.Point(190, 28);
            this.txtParent.Name = "txtParent";
            this.txtParent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtParent.Properties.ReadOnly = true;
            this.txtParent.Size = new System.Drawing.Size(264, 21);
            this.txtParent.TabIndex = 37;
            this.txtParent.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtParent_ButtonClick);
            this.txtParent.DoubleClick += new System.EventHandler(this.txtParent_DoubleClick);
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strParentID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label79.Location = new System.Drawing.Point(131, 31);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(59, 14);
            this.label79.TabIndex = 84;
            this.label79.Text = global::Inventory.Properties.Settings.Default.strParentID;
            // 
            // chkViewStatus
            // 
            this.chkViewStatus.Location = new System.Drawing.Point(9, 54);
            this.chkViewStatus.Name = "chkViewStatus";
            this.chkViewStatus.Properties.Caption = "View Status";
            this.chkViewStatus.Size = new System.Drawing.Size(108, 19);
            this.chkViewStatus.TabIndex = 36;
            // 
            // chkSubscribeNews
            // 
            this.chkSubscribeNews.AllowDrop = true;
            this.chkSubscribeNews.Location = new System.Drawing.Point(9, 29);
            this.chkSubscribeNews.Name = "chkSubscribeNews";
            this.chkSubscribeNews.Properties.Caption = "Subscribe News";
            this.chkSubscribeNews.Size = new System.Drawing.Size(108, 19);
            this.chkSubscribeNews.TabIndex = 35;
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
            this.groupControl4.Location = new System.Drawing.Point(491, 12);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(260, 563);
            this.groupControl4.TabIndex = 87;
            this.groupControl4.Text = "Financial Information";
            // 
            // cmbTaxAgent
            // 
            this.cmbTaxAgent.Location = new System.Drawing.Point(122, 257);
            this.cmbTaxAgent.Name = "cmbTaxAgent";
            this.cmbTaxAgent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTaxAgent.Size = new System.Drawing.Size(125, 21);
            this.cmbTaxAgent.TabIndex = 33;
            // 
            // cmbTaxCode
            // 
            this.cmbTaxCode.Location = new System.Drawing.Point(123, 75);
            this.cmbTaxCode.Name = "cmbTaxCode";
            this.cmbTaxCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTaxCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbTaxCode.Size = new System.Drawing.Size(125, 21);
            this.cmbTaxCode.TabIndex = 26;
            // 
            // cmbPaymentTermName
            // 
            this.cmbPaymentTermName.Location = new System.Drawing.Point(123, 49);
            this.cmbPaymentTermName.Name = "cmbPaymentTermName";
            this.cmbPaymentTermName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPaymentTermName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbPaymentTermName.Size = new System.Drawing.Size(125, 21);
            this.cmbPaymentTermName.TabIndex = 25;
            // 
            // memNotes
            // 
            this.memNotes.Location = new System.Drawing.Point(19, 330);
            this.memNotes.Name = "memNotes";
            this.memNotes.Size = new System.Drawing.Size(229, 219);
            this.memNotes.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strNotes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label12.Location = new System.Drawing.Point(16, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 14);
            this.label12.TabIndex = 80;
            this.label12.Text = global::Inventory.Properties.Settings.Default.strNotes;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPaymentTerm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label13.Location = new System.Drawing.Point(16, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 14);
            this.label13.TabIndex = 78;
            this.label13.Text = global::Inventory.Properties.Settings.Default.strPaymentTerm;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strTaxName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label16.Location = new System.Drawing.Point(16, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 14);
            this.label16.TabIndex = 72;
            this.label16.Text = global::Inventory.Properties.Settings.Default.strTaxName;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(122, 101);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(126, 21);
            this.txtAccountName.TabIndex = 27;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strAccountName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label18.Location = new System.Drawing.Point(16, 104);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 14);
            this.label18.TabIndex = 68;
            this.label18.Text = global::Inventory.Properties.Settings.Default.strAccountName;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strTaxAgent", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label19.Location = new System.Drawing.Point(16, 260);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 14);
            this.label19.TabIndex = 66;
            this.label19.Text = global::Inventory.Properties.Settings.Default.strTaxAgent;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(122, 231);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDiscount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDiscount.Properties.Mask.EditMask = "n0";
            this.txtDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDiscount.Size = new System.Drawing.Size(126, 21);
            this.txtDiscount.TabIndex = 32;
            this.txtDiscount.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtDiscount_EditValueChanging);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strDiscount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label34.Location = new System.Drawing.Point(16, 234);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(54, 14);
            this.label34.TabIndex = 64;
            this.label34.Text = global::Inventory.Properties.Settings.Default.strDiscount;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(122, 205);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtBalance.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtBalance.Properties.Mask.EditMask = "N0";
            this.txtBalance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBalance.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtBalance.Size = new System.Drawing.Size(126, 21);
            this.txtBalance.TabIndex = 31;
            this.txtBalance.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtBalance_EditValueChanging);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strBalance", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label35.Location = new System.Drawing.Point(16, 208);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(48, 14);
            this.label35.TabIndex = 62;
            this.label35.Text = global::Inventory.Properties.Settings.Default.strBalance;
            // 
            // txtCurrency
            // 
            this.txtCurrency.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", global::Inventory.Properties.Settings.Default, "cfgDefaultCurrency", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCurrency.EditValue = global::Inventory.Properties.Settings.Default.cfgDefaultCurrency;
            this.txtCurrency.Location = new System.Drawing.Point(122, 179);
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
            this.label36.Location = new System.Drawing.Point(16, 182);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(55, 14);
            this.label36.TabIndex = 60;
            this.label36.Text = global::Inventory.Properties.Settings.Default.strCurrency;
            // 
            // txtCreditLimit
            // 
            this.txtCreditLimit.Location = new System.Drawing.Point(122, 153);
            this.txtCreditLimit.Name = "txtCreditLimit";
            this.txtCreditLimit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCreditLimit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCreditLimit.Properties.Mask.EditMask = "N0";
            this.txtCreditLimit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCreditLimit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCreditLimit.Size = new System.Drawing.Size(126, 21);
            this.txtCreditLimit.TabIndex = 29;
            this.txtCreditLimit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtCreditLimit_EditValueChanging);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCreditLimit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label37.Location = new System.Drawing.Point(16, 156);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(68, 14);
            this.label37.TabIndex = 58;
            this.label37.Text = global::Inventory.Properties.Settings.Default.strCreditLimit;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(122, 127);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAccountNumber.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAccountNumber.Properties.Mask.EditMask = "N0";
            this.txtAccountNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAccountNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtAccountNumber.Size = new System.Drawing.Size(126, 21);
            this.txtAccountNumber.TabIndex = 28;
            this.txtAccountNumber.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtAccountNumber_EditValueChanging);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strAccountNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label38.Location = new System.Drawing.Point(16, 130);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(99, 14);
            this.label38.TabIndex = 56;
            this.label38.Text = global::Inventory.Properties.Settings.Default.strAccountNumber;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.txtWebsite);
            this.grpInfo.Controls.Add(this.label10);
            this.grpInfo.Controls.Add(this.txtEmail3);
            this.grpInfo.Controls.Add(this.label9);
            this.grpInfo.Controls.Add(this.txtEmail2);
            this.grpInfo.Controls.Add(this.label8);
            this.grpInfo.Controls.Add(this.txtEmail1);
            this.grpInfo.Controls.Add(this.label7);
            this.grpInfo.Controls.Add(this.textEdit2);
            this.grpInfo.Controls.Add(this.label6);
            this.grpInfo.Controls.Add(this.textEdit1);
            this.grpInfo.Controls.Add(this.label5);
            this.grpInfo.Controls.Add(this.label3);
            this.grpInfo.Controls.Add(this.txtFax2);
            this.grpInfo.Controls.Add(this.label4);
            this.grpInfo.Controls.Add(this.txtFax1);
            this.grpInfo.Controls.Add(this.txtPhoneNo2);
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.Controls.Add(this.txtPhoneNo1);
            this.grpInfo.Controls.Add(this.lblPhoneNo);
            this.grpInfo.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strOtherInform", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.grpInfo.Location = new System.Drawing.Point(12, 252);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(473, 233);
            this.grpInfo.TabIndex = 86;
            this.grpInfo.Text = global::Inventory.Properties.Settings.Default.strOtherInform;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(92, 204);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(368, 21);
            this.txtWebsite.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strWebsite", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label10.Location = new System.Drawing.Point(6, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 14);
            this.label10.TabIndex = 58;
            this.label10.Text = global::Inventory.Properties.Settings.Default.strWebsite;
            // 
            // txtEmail3
            // 
            this.txtEmail3.Location = new System.Drawing.Point(93, 169);
            this.txtEmail3.Name = "txtEmail3";
            this.txtEmail3.Properties.Mask.EditMask = "[a-zA-Z_0-9]+[@][a-zA-Z_0-9]+[.][a-zA-Z_0-9]+([.][a-zA-Z0-9]+)*";
            this.txtEmail3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmail3.Size = new System.Drawing.Size(126, 21);
            this.txtEmail3.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strEmail3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label9.Location = new System.Drawing.Point(6, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 14);
            this.label9.TabIndex = 56;
            this.label9.Text = global::Inventory.Properties.Settings.Default.strEmail3;
            // 
            // txtEmail2
            // 
            this.txtEmail2.Location = new System.Drawing.Point(92, 141);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Properties.Mask.EditMask = "[a-zA-Z_0-9]+[@][a-zA-Z_0-9]+[.][a-zA-Z_0-9]+([.][a-zA-Z0-9]+)*";
            this.txtEmail2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmail2.Size = new System.Drawing.Size(126, 21);
            this.txtEmail2.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strEmail2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label8.Location = new System.Drawing.Point(6, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 14);
            this.label8.TabIndex = 54;
            this.label8.Text = global::Inventory.Properties.Settings.Default.strEmail2;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strEmail1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label7.Location = new System.Drawing.Point(6, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 14);
            this.label7.TabIndex = 52;
            this.label7.Text = global::Inventory.Properties.Settings.Default.strEmail1;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(334, 80);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(126, 21);
            this.textEdit2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCell2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label6.Location = new System.Drawing.Point(247, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 14);
            this.label6.TabIndex = 50;
            this.label6.Text = global::Inventory.Properties.Settings.Default.strCell2;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(92, 77);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(126, 21);
            this.textEdit1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCell1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label5.Location = new System.Drawing.Point(5, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 14);
            this.label5.TabIndex = 48;
            this.label5.Text = global::Inventory.Properties.Settings.Default.strCell1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strFax1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label3.Location = new System.Drawing.Point(5, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 14);
            this.label3.TabIndex = 47;
            this.label3.Text = global::Inventory.Properties.Settings.Default.strFax1;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strFax2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label4.Location = new System.Drawing.Point(247, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 14);
            this.label4.TabIndex = 45;
            this.label4.Text = global::Inventory.Properties.Settings.Default.strFax2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPhoneNo2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Location = new System.Drawing.Point(247, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 41;
            this.label2.Text = global::Inventory.Properties.Settings.Default.strPhoneNo2;
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
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPhoneNo1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPhoneNo.Location = new System.Drawing.Point(5, 27);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(53, 14);
            this.lblPhoneNo.TabIndex = 27;
            this.lblPhoneNo.Text = global::Inventory.Properties.Settings.Default.strPhoneNo1;
            // 
            // grpNameAddress
            // 
            this.grpNameAddress.Controls.Add(this.txtAltContact);
            this.grpNameAddress.Controls.Add(this.label1);
            this.grpNameAddress.Controls.Add(this.txtCompanyName);
            this.grpNameAddress.Controls.Add(this.txtContactName);
            this.grpNameAddress.Controls.Add(this.txtEmailName);
            this.grpNameAddress.Controls.Add(this.lblCountry);
            this.grpNameAddress.Controls.Add(this.txtCountry);
            this.grpNameAddress.Controls.Add(this.lblZip);
            this.grpNameAddress.Controls.Add(this.txtZip);
            this.grpNameAddress.Controls.Add(this.lblProvince);
            this.grpNameAddress.Controls.Add(this.txtProvince);
            this.grpNameAddress.Controls.Add(this.lblCity);
            this.grpNameAddress.Controls.Add(this.txtCity);
            this.grpNameAddress.Controls.Add(this.lblAddress2);
            this.grpNameAddress.Controls.Add(this.txtAddress2);
            this.grpNameAddress.Controls.Add(this.lblAddress1);
            this.grpNameAddress.Controls.Add(this.txtAddress1);
            this.grpNameAddress.Controls.Add(this.lblOccpation);
            this.grpNameAddress.Controls.Add(this.lblSaluation);
            this.grpNameAddress.Controls.Add(this.lblGender);
            this.grpNameAddress.Controls.Add(this.lblLastName);
            this.grpNameAddress.Controls.Add(this.txtLastName);
            this.grpNameAddress.Controls.Add(this.lblMiddleName);
            this.grpNameAddress.Controls.Add(this.txtMiddleName);
            this.grpNameAddress.Controls.Add(this.lblFirstName);
            this.grpNameAddress.Controls.Add(this.cmbMrMrs);
            this.grpNameAddress.Controls.Add(this.lblMr);
            this.grpNameAddress.Controls.Add(this.txtFirstName);
            this.grpNameAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strNameAndAddr", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.grpNameAddress.Location = new System.Drawing.Point(12, 12);
            this.grpNameAddress.Name = "grpNameAddress";
            this.grpNameAddress.Size = new System.Drawing.Size(473, 234);
            this.grpNameAddress.TabIndex = 85;
            this.grpNameAddress.Text = global::Inventory.Properties.Settings.Default.strNameAndAddr;
            // 
            // txtAltContact
            // 
            this.txtAltContact.Location = new System.Drawing.Point(353, 84);
            this.txtAltContact.Name = "txtAltContact";
            this.txtAltContact.Size = new System.Drawing.Size(107, 21);
            this.txtAltContact.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strAltContact", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Location = new System.Drawing.Point(350, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 30;
            this.label1.Text = global::Inventory.Properties.Settings.Default.strAltContact;
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
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCountry", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblCountry.Location = new System.Drawing.Point(266, 202);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(50, 14);
            this.lblCountry.TabIndex = 25;
            this.lblCountry.Text = global::Inventory.Properties.Settings.Default.strCountry;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(338, 195);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(122, 21);
            this.txtCountry.TabIndex = 14;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strZipPostal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblZip.Location = new System.Drawing.Point(6, 198);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(60, 14);
            this.lblZip.TabIndex = 23;
            this.lblZip.Text = global::Inventory.Properties.Settings.Default.strZipPostal;
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
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strProvince", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblProvince.Location = new System.Drawing.Point(266, 171);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(53, 14);
            this.lblProvince.TabIndex = 21;
            this.lblProvince.Text = global::Inventory.Properties.Settings.Default.strProvince;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(338, 168);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(122, 21);
            this.txtProvince.TabIndex = 12;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCityTown", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblCity.Location = new System.Drawing.Point(6, 171);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(64, 14);
            this.lblCity.TabIndex = 19;
            this.lblCity.Text = global::Inventory.Properties.Settings.Default.strCityTown;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(92, 168);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(122, 21);
            this.txtCity.TabIndex = 11;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strAddress2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblAddress2.Location = new System.Drawing.Point(6, 142);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(57, 14);
            this.lblAddress2.TabIndex = 17;
            this.lblAddress2.Text = global::Inventory.Properties.Settings.Default.strAddress2;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(92, 143);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(368, 21);
            this.txtAddress2.TabIndex = 10;
            this.txtAddress2.EditValueChanged += new System.EventHandler(this.txtAddress2_EditValueChanged);
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strAddress1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblAddress1.Location = new System.Drawing.Point(6, 116);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(57, 14);
            this.lblAddress1.TabIndex = 15;
            this.lblAddress1.Text = global::Inventory.Properties.Settings.Default.strAddress1;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(92, 116);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(368, 21);
            this.txtAddress1.TabIndex = 9;
            // 
            // lblOccpation
            // 
            this.lblOccpation.AutoSize = true;
            this.lblOccpation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCompanyName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblOccpation.Location = new System.Drawing.Point(220, 68);
            this.lblOccpation.Name = "lblOccpation";
            this.lblOccpation.Size = new System.Drawing.Size(92, 14);
            this.lblOccpation.TabIndex = 13;
            this.lblOccpation.Text = global::Inventory.Properties.Settings.Default.strCompanyName;
            // 
            // lblSaluation
            // 
            this.lblSaluation.AutoSize = true;
            this.lblSaluation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strContactName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSaluation.Location = new System.Drawing.Point(89, 68);
            this.lblSaluation.Name = "lblSaluation";
            this.lblSaluation.Size = new System.Drawing.Size(85, 14);
            this.lblSaluation.TabIndex = 11;
            this.lblSaluation.Text = global::Inventory.Properties.Settings.Default.strContactName;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strEmailName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblGender.Location = new System.Drawing.Point(5, 68);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(69, 14);
            this.lblGender.TabIndex = 9;
            this.lblGender.Text = global::Inventory.Properties.Settings.Default.strEmailName;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strLastName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblLastName.Location = new System.Drawing.Point(350, 27);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 14);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = global::Inventory.Properties.Settings.Default.strLastName;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(353, 45);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(107, 21);
            this.txtLastName.TabIndex = 4;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strMiddleName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblMiddleName.Location = new System.Drawing.Point(220, 27);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(76, 14);
            this.lblMiddleName.TabIndex = 5;
            this.lblMiddleName.Text = global::Inventory.Properties.Settings.Default.strMiddleName;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(220, 44);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(112, 21);
            this.txtMiddleName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strFirstName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblFirstName.Location = new System.Drawing.Point(89, 28);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(64, 14);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = global::Inventory.Properties.Settings.Default.strFirstName;
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
            // lblMr
            // 
            this.lblMr.AutoSize = true;
            this.lblMr.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strMrMrs", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblMr.Location = new System.Drawing.Point(6, 27);
            this.lblMr.Name = "lblMr";
            this.lblMr.Size = new System.Drawing.Size(43, 14);
            this.lblMr.TabIndex = 1;
            this.lblMr.Text = global::Inventory.Properties.Settings.Default.strMrMrs;
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
            // ModifySupplier
            // 
            this.ClientSize = new System.Drawing.Size(762, 610);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.grpNameAddress);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strEditSupplier", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ModifySupplier";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = global::Inventory.Properties.Settings.Default.strEditSupplier;
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSubscribeNews.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.grpInfo)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNo2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNameAddress)).EndInit();
            this.grpNameAddress.ResumeLayout(false);
            this.grpNameAddress.PerformLayout();
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
        private Supplier splSupplier;
        private string ParentID;
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

        public Supplier SupplierData
        {
            get { return getAllData(); }
            set { splSupplier = value; SetAllData(); }
        }

        private void SetAllData()
        {
            txtAccountName.Text = splSupplier.AccountName;
            txtAccountNumber.Text = splSupplier.Account_number.ToString();
            txtAddress1.Text = splSupplier.Address1;
            txtAddress2.Text = splSupplier.Address2;
            txtAltContact.Text = splSupplier.Alt_contact;
            txtBalance.Text = splSupplier.Balance.ToString();
            
            txtCity.Text = splSupplier.City;
            txtCompanyName.Text = splSupplier.CompanyName;
            txtContactName.Text = splSupplier.ContactName;
            txtCountry.Text = splSupplier.Country;
            txtCreditLimit.Text = splSupplier.Credit_limit.ToString();
            txtCurrency.Text = splSupplier.Currency;
            txtDiscount.Text = splSupplier.Discount.ToString();
            txtEmail1.Text = splSupplier.Email1;
            txtEmail2.Text = splSupplier.Email2;
            txtEmail3.Text = splSupplier.Email3;
            txtEmailName.Text = splSupplier.EmailName;
            txtFax1.Text = splSupplier.Fax1;
            txtFax2.Text = splSupplier.Fax2;
            txtFirstName.Text = splSupplier.FirstName;
            txtLastName.Text = splSupplier.LastName;
            txtMiddleName.Text = splSupplier.MiddleName;
            //txtPaymentTermName.Text = splSupplier.Payment_term_Name;
            for (int i = 0; i < cmbPaymentTermName.Properties.Items.Count; i++)
            {
                TabItem item = (TabItem)cmbPaymentTermName.Properties.Items[i];
                if (item.ItemID == splSupplier.Payment_term_id)
                {
                    cmbPaymentTermName.SelectedIndex = i;
                    break;
                }
            }

            txtPhoneNo1.Text = splSupplier.Phone1;
            txtPhoneNo2.Text = splSupplier.Phone2;
            txtProvince.Text = splSupplier.Province;
            
            //txtTaxAgent.Text = splSupplier.Tax_agent;
            //txtTaxCodeName.Text = splSupplier.Tax_Code_Name;
            for (int i = 0; i < cmbTaxCode.Properties.Items.Count; i++)
            {
                TabItem item = (TabItem)cmbTaxCode.Properties.Items[i];
                if (item.ItemID == splSupplier.Tax_code_id)
                {
                    cmbTaxCode.SelectedIndex = i;
                    break;
                }
            }
            txtWebsite.Text = splSupplier.Website;
            txtZip.Text = splSupplier.Zip;
            memNotes.Text = splSupplier.Notes;
            chkSubscribeNews.Checked = splSupplier.SubscribeNews;
            chkViewStatus.Checked = splSupplier.ViewStatus;
            txtParent.Text = ContactBase.GetContactName(splSupplier.Parent_id);
            ParentID = splSupplier.Parent_id;
            if (catList == null)
                bteCategory.Text = DA_Category.getCategoriesName(splSupplier.ContactID);
            else
                bteCategory.Text = DA_Category.getCategoriesName(catList);
        }
        private Supplier getAllData()
        {
            try
            {
                splSupplier.Account_number = Convert.ToInt32(txtAccountNumber.EditValue.ToString());
            }
            catch (Exception) { }
            splSupplier.AccountName = txtAccountName.Text;


            splSupplier.Alt_contact = txtAltContact.Text;
            try
            {
                splSupplier.Balance = Convert.ToInt32(txtBalance.EditValue.ToString());
            }
            catch (Exception) { }
            
            splSupplier.City = txtCity.Text;
            splSupplier.CompanyName = txtCompanyName.Text;
            splSupplier.ContactName = txtContactName.Text;
            splSupplier.Country = txtCountry.Text;
            try
            {
                splSupplier.Credit_limit = Convert.ToInt32(txtCreditLimit.EditValue.ToString());
            }
            catch (Exception) { }
            splSupplier.Currency = txtCurrency.Text;
            try
            {
                splSupplier.Discount = Convert.ToInt32(txtDiscount.EditValue.ToString());
            }
            catch (Exception) { }
            splSupplier.Email1 = txtEmail1.Text;
            splSupplier.Email2 = txtEmail2.Text;
            splSupplier.Email3 = txtEmail3.Text;
            splSupplier.EmailName = txtEmailName.Text;
            splSupplier.Fax1 = txtFax1.Text;
            splSupplier.Fax2 = txtFax2.Text;
            splSupplier.FirstName = txtFirstName.Text;
            splSupplier.LastName = txtLastName.Text;
            splSupplier.MiddleName = txtMiddleName.Text;
            //splSupplier.Payment_term_Name = txtPaymentTermName.Text;
            splSupplier.Phone1 = txtPhoneNo1.Text;
            splSupplier.Phone2 = txtPhoneNo2.Text;
            splSupplier.Province = txtProvince.Text;
            
            splSupplier.Tax_agent = cmbTaxAgent.Text;

            splSupplier.Address1 = txtAddress1.Text;
            splSupplier.Address2 = txtAddress2.Text;
            try
            {
                TabItem item = (TabItem)cmbTaxCode.SelectedItem;
                splSupplier.Tax_Code_Name = item.ItemName;
                splSupplier.Tax_code_id = item.ItemID;
            }
            catch (Exception) { }

            try
            {
                TabItem item = (TabItem)cmbPaymentTermName.SelectedItem;
                splSupplier.Payment_term_Name = item.ItemName;
                splSupplier.Payment_term_id = item.ItemID;
            }
            catch (Exception) { }
            splSupplier.Website = txtWebsite.Text;
            splSupplier.Zip = txtZip.Text;
            splSupplier.Notes = memNotes.Text;
            splSupplier.SubscribeNews = chkSubscribeNews.Checked;
            splSupplier.ViewStatus = chkViewStatus.Checked;
            splSupplier.UserID = Globals.UserID;
            splSupplier.Parent_id = ParentID;
                
            return splSupplier;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbPaymentTermName.Text == "")
            {
                MessageBox.Show(this, Settings.Default.strPaymentTerm + " cannot null", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPaymentTermName.Focus();
                return;
            }
            else if (cmbTaxCode.Text == "")
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

        private void txtParent_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void txtParent_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SelectSupplier frm = new SelectSupplier();
            frm.ChildID = splSupplier.ContactID;
            frm.SupplierID = ParentID;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtParent.Text = frm.SupplierName;
                ParentID = frm.SupplierID;
            }
        }

        private void txtAddress2_EditValueChanged(object sender, EventArgs e)
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
            frm.ContactID = splSupplier.ContactID;
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

        private void txtDiscount_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue.ToString() == "") return;
            if (Convert.ToInt64(e.NewValue) > Int32.MaxValue) e.Cancel = true;
        }

        private void txtBalance_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue.ToString() == "") return;
            if (Convert.ToInt64(e.NewValue) > Int32.MaxValue) e.Cancel = true;
        }

        private void txtCreditLimit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue.ToString() == "") return;
            if (Convert.ToInt64(e.NewValue) > Int32.MaxValue) e.Cancel = true;
        }

        private void txtAccountNumber_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue.ToString() == "") return;
            if (Convert.ToInt64(e.NewValue) > Int32.MaxValue) e.Cancel = true;
        }
    }
}

