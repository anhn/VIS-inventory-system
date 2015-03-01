using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using VIS.ControlSetting;
using Toolkit;

namespace Inventory
{
    /// <summary>
    /// Summary description for AddEditSupplier.
    /// </summary>
    public class AddEditSupplier : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;


        private string strContactID;
        private string strOrderStatus;

        private DataTable dtSelectedCat = new DataTable();
        private SqlDataAdapter daSupplier;
        private SqlConnection cnContactMgmt;
        private GroupControl groupControl1;
        private LookUpEdit luePayment;
        private LookUpEdit lueTax;
        private Label label12;
        private TextEdit txtTaxAgent;
        private Label label11;
        private TextEdit txtDiscount;
        private Label label10;
        private TextEdit txtBalance;
        private Label label9;
        private TextEdit txtCurrency;
        private Label label8;
        private TextEdit txtCreditLimit;
        private Label label7;
        private Label label5;
        private Label label4;
        private GroupControl grpNameAddress;
        private CheckEdit chkSubscribe;
        private ButtonEdit bteCategory;
        private Label lblCategory;
        private Label lblViewStatus;
        private RadioGroup rdoViewStatus;
        private Label label3;
        private TextEdit txtAlternateName;
        private Label lblLastName;
        private TextEdit txtLastName;
        private Label lblMiddleName;
        private TextEdit txtMiddleName;
        private Label lblFirstName;
        private Label lblMr;
        private TextEdit txtFirstName;
        private Label lblWebsite;
        private TextEdit txtWebsite;
        private Label lblDivision;
        private TextEdit txtDivision;
        private Label lblDepartment;
        private TextEdit txtDepartment;
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
        private Label lblCompanyName;
        private TextEdit txtCompanyName;
        private GroupControl grpInfo;
        private TextEdit txtCell2;
        private Label label6;
        private TextEdit txtEmail3;
        private Label label2;
        private TextEdit txtEmailName;
        private TextEdit txtFax2;
        private TextEdit txtMain2;
        private Label lblEmail2;
        private TextEdit txtEmail2;
        private Label lblEmail1;
        private TextEdit txtEmail1;
        private Label lblEmailAddr;
        private Label lblCell;
        private TextEdit txtCell;
        private Label lblFax;
        private TextEdit txtFax1;
        private Label lblMain;
        private TextEdit txtMain1;
        private Label lblPhoneNo;
        private Label label13;
        private RichTextBox txtNotes;
        private Label label14;
        private TextEdit txtSupplierName;
        private LookUpEdit lueMr;
        private LookUpEdit lueAccountNo;
        private Label label1;
        private TextEdit txtSupplierID;
        private DataSet dsSupplier = new DataSet();
        private bool isSaved = false;
        private TextEdit txtActNo;
        private bool needDelete = false;
        public AddEditSupplier(string ID, string orderStatus)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            strContactID = ID;
            strOrderStatus = orderStatus;
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtActNo = new DevExpress.XtraEditors.TextEdit();
            this.luePayment = new DevExpress.XtraEditors.LookUpEdit();
            this.lueAccountNo = new DevExpress.XtraEditors.LookUpEdit();
            this.lueTax = new DevExpress.XtraEditors.LookUpEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTaxAgent = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiscount = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBalance = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCurrency = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCreditLimit = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpNameAddress = new DevExpress.XtraEditors.GroupControl();
            this.lueMr = new DevExpress.XtraEditors.LookUpEdit();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.txtMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.txtCompanyName = new DevExpress.XtraEditors.TextEdit();
            this.rdoViewStatus = new DevExpress.XtraEditors.RadioGroup();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSupplierName = new DevExpress.XtraEditors.TextEdit();
            this.chkSubscribe = new DevExpress.XtraEditors.CheckEdit();
            this.bteCategory = new DevExpress.XtraEditors.ButtonEdit();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblViewStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlternateName = new DevExpress.XtraEditors.TextEdit();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMr = new System.Windows.Forms.Label();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.txtWebsite = new DevExpress.XtraEditors.TextEdit();
            this.lblDivision = new System.Windows.Forms.Label();
            this.txtDivision = new DevExpress.XtraEditors.TextEdit();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtDepartment = new DevExpress.XtraEditors.TextEdit();
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
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.grpInfo = new DevExpress.XtraEditors.GroupControl();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.txtCell2 = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail3 = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailName = new DevExpress.XtraEditors.TextEdit();
            this.txtFax2 = new DevExpress.XtraEditors.TextEdit();
            this.txtMain2 = new DevExpress.XtraEditors.TextEdit();
            this.lblEmail2 = new System.Windows.Forms.Label();
            this.txtEmail2 = new DevExpress.XtraEditors.TextEdit();
            this.lblEmail1 = new System.Windows.Forms.Label();
            this.txtEmail1 = new DevExpress.XtraEditors.TextEdit();
            this.lblEmailAddr = new System.Windows.Forms.Label();
            this.lblCell = new System.Windows.Forms.Label();
            this.txtCell = new DevExpress.XtraEditors.TextEdit();
            this.lblFax = new System.Windows.Forms.Label();
            this.txtFax1 = new DevExpress.XtraEditors.TextEdit();
            this.lblMain = new System.Windows.Forms.Label();
            this.txtMain1 = new DevExpress.XtraEditors.TextEdit();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSupplierID = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtActNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePayment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAccountNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxAgent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreditLimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNameAddress)).BeginInit();
            this.grpNameAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueMr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoViewStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSubscribe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlternateName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDivision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProvince.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpInfo)).BeginInit();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCell2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMain2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMain1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(401, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 23);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(292, 465);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 23);
            this.btnOK.TabIndex = 40;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtActNo);
            this.groupControl1.Controls.Add(this.luePayment);
            this.groupControl1.Controls.Add(this.lueAccountNo);
            this.groupControl1.Controls.Add(this.lueTax);
            this.groupControl1.Controls.Add(this.label12);
            this.groupControl1.Controls.Add(this.txtTaxAgent);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.txtDiscount);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.txtBalance);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.txtCurrency);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.txtCreditLimit);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Location = new System.Drawing.Point(400, 313);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(395, 142);
            this.groupControl1.TabIndex = 30;
            this.groupControl1.Text = "Payment";
            // 
            // txtActNo
            // 
            this.txtActNo.Location = new System.Drawing.Point(79, 52);
            this.txtActNo.Name = "txtActNo";
            this.txtActNo.Size = new System.Drawing.Size(106, 21);
            this.txtActNo.TabIndex = 34;
            // 
            // luePayment
            // 
            this.luePayment.Location = new System.Drawing.Point(79, 24);
            this.luePayment.Name = "luePayment";
            this.luePayment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.luePayment.Properties.NullText = "";
            this.luePayment.Properties.ShowFooter = false;
            this.luePayment.Properties.ShowHeader = false;
            this.luePayment.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.luePayment_Properties_ButtonClick);
            this.luePayment.Size = new System.Drawing.Size(106, 21);
            this.luePayment.TabIndex = 32;
            // 
            // lueAccountNo
            // 
            this.lueAccountNo.EditValue = "";
            this.lueAccountNo.Location = new System.Drawing.Point(79, 50);
            this.lueAccountNo.Name = "lueAccountNo";
            this.lueAccountNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.lueAccountNo.Properties.NullText = "";
            this.lueAccountNo.Size = new System.Drawing.Size(106, 21);
            this.lueAccountNo.TabIndex = 32;
            this.lueAccountNo.Visible = false;
            this.lueAccountNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lueAccountNo_ButtonClick);
            // 
            // lueTax
            // 
            this.lueTax.Location = new System.Drawing.Point(281, 24);
            this.lueTax.Name = "lueTax";
            this.lueTax.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.lueTax.Properties.NullText = "";
            this.lueTax.Properties.ShowFooter = false;
            this.lueTax.Properties.ShowHeader = false;
            this.lueTax.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lueTax_Properties_ButtonClick);
            this.lueTax.Size = new System.Drawing.Size(90, 21);
            this.lueTax.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(205, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 14);
            this.label12.TabIndex = 53;
            this.label12.Text = "Tax agent:";
            // 
            // txtTaxAgent
            // 
            this.txtTaxAgent.Location = new System.Drawing.Point(280, 108);
            this.txtTaxAgent.Name = "txtTaxAgent";
            this.txtTaxAgent.Properties.MaxLength = 36;
            this.txtTaxAgent.Size = new System.Drawing.Size(90, 21);
            this.txtTaxAgent.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 14);
            this.label11.TabIndex = 51;
            this.label11.Text = "Discount:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(79, 108);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Properties.DisplayFormat.FormatString = "n2";
            this.txtDiscount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDiscount.Properties.EditFormat.FormatString = "n2";
            this.txtDiscount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDiscount.Properties.Mask.EditMask = "n2";
            this.txtDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDiscount.Size = new System.Drawing.Size(106, 21);
            this.txtDiscount.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(205, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 14);
            this.label10.TabIndex = 49;
            this.label10.Text = "Balance:";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(281, 81);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Properties.Mask.EditMask = "n";
            this.txtBalance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBalance.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtBalance.Size = new System.Drawing.Size(89, 21);
            this.txtBalance.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 14);
            this.label9.TabIndex = 47;
            this.label9.Text = "Currency:";
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(281, 51);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Properties.MaxLength = 3;
            this.txtCurrency.Size = new System.Drawing.Size(89, 21);
            this.txtCurrency.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 14);
            this.label8.TabIndex = 45;
            this.label8.Text = "Credit Limit:";
            // 
            // txtCreditLimit
            // 
            this.txtCreditLimit.Location = new System.Drawing.Point(79, 81);
            this.txtCreditLimit.Name = "txtCreditLimit";
            this.txtCreditLimit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCreditLimit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCreditLimit.Properties.Mask.EditMask = "n";
            this.txtCreditLimit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCreditLimit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCreditLimit.Size = new System.Drawing.Size(106, 21);
            this.txtCreditLimit.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 14);
            this.label7.TabIndex = 43;
            this.label7.Text = "Account No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tax:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "Payment:";
            // 
            // grpNameAddress
            // 
            this.grpNameAddress.Controls.Add(this.lueMr);
            this.grpNameAddress.Controls.Add(this.txtLastName);
            this.grpNameAddress.Controls.Add(this.txtMiddleName);
            this.grpNameAddress.Controls.Add(this.txtFirstName);
            this.grpNameAddress.Controls.Add(this.txtCompanyName);
            this.grpNameAddress.Controls.Add(this.rdoViewStatus);
            this.grpNameAddress.Controls.Add(this.label14);
            this.grpNameAddress.Controls.Add(this.txtSupplierName);
            this.grpNameAddress.Controls.Add(this.chkSubscribe);
            this.grpNameAddress.Controls.Add(this.bteCategory);
            this.grpNameAddress.Controls.Add(this.lblCategory);
            this.grpNameAddress.Controls.Add(this.lblViewStatus);
            this.grpNameAddress.Controls.Add(this.label3);
            this.grpNameAddress.Controls.Add(this.txtAlternateName);
            this.grpNameAddress.Controls.Add(this.lblLastName);
            this.grpNameAddress.Controls.Add(this.lblMiddleName);
            this.grpNameAddress.Controls.Add(this.lblFirstName);
            this.grpNameAddress.Controls.Add(this.lblMr);
            this.grpNameAddress.Controls.Add(this.lblWebsite);
            this.grpNameAddress.Controls.Add(this.txtWebsite);
            this.grpNameAddress.Controls.Add(this.lblDivision);
            this.grpNameAddress.Controls.Add(this.txtDivision);
            this.grpNameAddress.Controls.Add(this.lblDepartment);
            this.grpNameAddress.Controls.Add(this.txtDepartment);
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
            this.grpNameAddress.Controls.Add(this.lblCompanyName);
            this.grpNameAddress.Location = new System.Drawing.Point(12, 31);
            this.grpNameAddress.Name = "grpNameAddress";
            this.grpNameAddress.Size = new System.Drawing.Size(382, 424);
            this.grpNameAddress.TabIndex = 28;
            this.grpNameAddress.Text = "Name and address";
            this.grpNameAddress.Paint += new System.Windows.Forms.PaintEventHandler(this.grpNameAddress_Paint);
            // 
            // lueMr
            // 
            this.lueMr.Location = new System.Drawing.Point(7, 40);
            this.lueMr.Name = "lueMr";
            this.lueMr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.lueMr.Properties.MaxLength = 50;
            this.lueMr.Properties.NullText = "";
            this.lueMr.Properties.ShowFooter = false;
            this.lueMr.Properties.ShowHeader = false;
            this.lueMr.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lueMr_Properties_ButtonClick);
            this.lueMr.Size = new System.Drawing.Size(62, 21);
            this.lueMr.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(280, 40);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Properties.MaxLength = 255;
            this.txtLastName.Size = new System.Drawing.Size(87, 21);
            this.txtLastName.TabIndex = 5;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(185, 40);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Properties.MaxLength = 255;
            this.txtMiddleName.Size = new System.Drawing.Size(87, 21);
            this.txtMiddleName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(87, 40);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Properties.MaxLength = 255;
            this.txtFirstName.Size = new System.Drawing.Size(87, 21);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(86, 79);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Properties.MaxLength = 255;
            this.txtCompanyName.Size = new System.Drawing.Size(126, 21);
            this.txtCompanyName.TabIndex = 6;
            // 
            // rdoViewStatus
            // 
            this.rdoViewStatus.EditValue = true;
            this.rdoViewStatus.Location = new System.Drawing.Point(231, 345);
            this.rdoViewStatus.Name = "rdoViewStatus";
            this.rdoViewStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Enable"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Disable")});
            this.rdoViewStatus.Size = new System.Drawing.Size(129, 28);
            this.rdoViewStatus.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 14);
            this.label14.TabIndex = 65;
            this.label14.Text = "Contact Name:";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(86, 114);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Properties.MaxLength = 255;
            this.txtSupplierName.Size = new System.Drawing.Size(274, 21);
            this.txtSupplierName.TabIndex = 8;
            // 
            // chkSubscribe
            // 
            this.chkSubscribe.EditValue = true;
            this.chkSubscribe.Location = new System.Drawing.Point(8, 352);
            this.chkSubscribe.Name = "chkSubscribe";
            this.chkSubscribe.Properties.Caption = "Subscribe Newsletters";
            this.chkSubscribe.Size = new System.Drawing.Size(143, 19);
            this.chkSubscribe.TabIndex = 18;
            // 
            // bteCategory
            // 
            this.bteCategory.EditValue = "";
            this.bteCategory.Location = new System.Drawing.Point(87, 391);
            this.bteCategory.Name = "bteCategory";
            this.bteCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteCategory.Size = new System.Drawing.Size(273, 21);
            this.bteCategory.TabIndex = 20;
            this.bteCategory.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteCategory_ButtonClick);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(10, 392);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(60, 14);
            this.lblCategory.TabIndex = 63;
            this.lblCategory.Text = "Category:";
            // 
            // lblViewStatus
            // 
            this.lblViewStatus.AutoSize = true;
            this.lblViewStatus.Location = new System.Drawing.Point(155, 352);
            this.lblViewStatus.Name = "lblViewStatus";
            this.lblViewStatus.Size = new System.Drawing.Size(77, 14);
            this.lblViewStatus.TabIndex = 64;
            this.lblViewStatus.Text = "View Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 14);
            this.label3.TabIndex = 49;
            this.label3.Text = "Alternate Name:";
            // 
            // txtAlternateName
            // 
            this.txtAlternateName.Location = new System.Drawing.Point(231, 80);
            this.txtAlternateName.Name = "txtAlternateName";
            this.txtAlternateName.Properties.MaxLength = 50;
            this.txtAlternateName.Size = new System.Drawing.Size(129, 21);
            this.txtAlternateName.TabIndex = 7;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(272, 25);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(68, 14);
            this.lblLastName.TabIndex = 45;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(179, 25);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(80, 14);
            this.lblMiddleName.TabIndex = 44;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(86, 25);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(68, 14);
            this.lblFirstName.TabIndex = 41;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblMr
            // 
            this.lblMr.AutoSize = true;
            this.lblMr.Location = new System.Drawing.Point(3, 25);
            this.lblMr.Name = "lblMr";
            this.lblMr.Size = new System.Drawing.Size(47, 14);
            this.lblMr.TabIndex = 38;
            this.lblMr.Text = "Mr/Mrs:";
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Location = new System.Drawing.Point(4, 322);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(56, 14);
            this.lblWebsite.TabIndex = 37;
            this.lblWebsite.Text = "Website:";
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(87, 318);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Properties.MaxLength = 255;
            this.txtWebsite.Size = new System.Drawing.Size(273, 21);
            this.txtWebsite.TabIndex = 17;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(6, 173);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(50, 14);
            this.lblDivision.TabIndex = 6;
            this.lblDivision.Text = "Division:";
            // 
            // txtDivision
            // 
            this.txtDivision.Location = new System.Drawing.Point(87, 174);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Properties.MaxLength = 255;
            this.txtDivision.Size = new System.Drawing.Size(273, 21);
            this.txtDivision.TabIndex = 10;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(5, 143);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(77, 14);
            this.lblDepartment.TabIndex = 4;
            this.lblDepartment.Text = "Department:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(87, 142);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Properties.MaxLength = 255;
            this.txtDepartment.Size = new System.Drawing.Size(273, 21);
            this.txtDepartment.TabIndex = 9;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(186, 289);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(54, 14);
            this.lblCountry.TabIndex = 18;
            this.lblCountry.Text = "Country:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(264, 288);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Properties.MaxLength = 255;
            this.txtCountry.Size = new System.Drawing.Size(96, 21);
            this.txtCountry.TabIndex = 16;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(5, 290);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(64, 14);
            this.lblZip.TabIndex = 16;
            this.lblZip.Text = "Zip/Postal:";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(87, 287);
            this.txtZip.Name = "txtZip";
            this.txtZip.Properties.MaxLength = 10;
            this.txtZip.Size = new System.Drawing.Size(96, 21);
            this.txtZip.TabIndex = 15;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(184, 262);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(74, 14);
            this.lblProvince.TabIndex = 14;
            this.lblProvince.Text = "St/Province:";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(264, 260);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Properties.MaxLength = 255;
            this.txtProvince.Size = new System.Drawing.Size(96, 21);
            this.txtProvince.TabIndex = 14;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(5, 262);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(68, 14);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "City/Town:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(87, 260);
            this.txtCity.Name = "txtCity";
            this.txtCity.Properties.MaxLength = 255;
            this.txtCity.Size = new System.Drawing.Size(96, 21);
            this.txtCity.TabIndex = 13;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(6, 234);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(61, 14);
            this.lblAddress2.TabIndex = 10;
            this.lblAddress2.Text = "Address2:";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(87, 233);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Properties.MaxLength = 255;
            this.txtAddress2.Size = new System.Drawing.Size(273, 21);
            this.txtAddress2.TabIndex = 12;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(7, 207);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(61, 14);
            this.lblAddress1.TabIndex = 8;
            this.lblAddress1.Text = "Address1:";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(87, 206);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Properties.MaxLength = 255;
            this.txtAddress1.Size = new System.Drawing.Size(273, 21);
            this.txtAddress1.TabIndex = 11;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Location = new System.Drawing.Point(4, 105);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(85, 31);
            this.lblCompanyName.TabIndex = 2;
            this.lblCompanyName.Text = "*Supplier Name:";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.label13);
            this.grpInfo.Controls.Add(this.txtNotes);
            this.grpInfo.Controls.Add(this.txtCell2);
            this.grpInfo.Controls.Add(this.label6);
            this.grpInfo.Controls.Add(this.txtEmail3);
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.Controls.Add(this.txtEmailName);
            this.grpInfo.Controls.Add(this.txtFax2);
            this.grpInfo.Controls.Add(this.txtMain2);
            this.grpInfo.Controls.Add(this.lblEmail2);
            this.grpInfo.Controls.Add(this.txtEmail2);
            this.grpInfo.Controls.Add(this.lblEmail1);
            this.grpInfo.Controls.Add(this.txtEmail1);
            this.grpInfo.Controls.Add(this.lblEmailAddr);
            this.grpInfo.Controls.Add(this.lblCell);
            this.grpInfo.Controls.Add(this.txtCell);
            this.grpInfo.Controls.Add(this.lblFax);
            this.grpInfo.Controls.Add(this.txtFax1);
            this.grpInfo.Controls.Add(this.lblMain);
            this.grpInfo.Controls.Add(this.txtMain1);
            this.grpInfo.Controls.Add(this.lblPhoneNo);
            this.grpInfo.Location = new System.Drawing.Point(400, 31);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(395, 276);
            this.grpInfo.TabIndex = 29;
            this.grpInfo.Text = "Other Information";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(229, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 14);
            this.label13.TabIndex = 42;
            this.label13.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(228, 130);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(154, 137);
            this.txtNotes.TabIndex = 31;
            this.txtNotes.Text = "";
            // 
            // txtCell2
            // 
            this.txtCell2.Location = new System.Drawing.Point(92, 130);
            this.txtCell2.Name = "txtCell2";
            this.txtCell2.Properties.MaxLength = 50;
            this.txtCell2.Size = new System.Drawing.Size(126, 21);
            this.txtCell2.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 14);
            this.label6.TabIndex = 40;
            this.label6.Text = "Email 3:";
            // 
            // txtEmail3
            // 
            this.txtEmail3.Location = new System.Drawing.Point(92, 216);
            this.txtEmail3.Name = "txtEmail3";
            this.txtEmail3.Properties.MaxLength = 50;
            this.txtEmail3.Size = new System.Drawing.Size(127, 21);
            this.txtEmail3.TabIndex = 29;
            this.txtEmail3.EditValueChanged += new System.EventHandler(this.txtEmail3_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 37;
            this.label2.Text = "Email Name:";
            // 
            // txtEmailName
            // 
            this.txtEmailName.Location = new System.Drawing.Point(92, 249);
            this.txtEmailName.Name = "txtEmailName";
            this.txtEmailName.Properties.MaxLength = 255;
            this.txtEmailName.Size = new System.Drawing.Size(127, 21);
            this.txtEmailName.TabIndex = 30;
            // 
            // txtFax2
            // 
            this.txtFax2.Location = new System.Drawing.Point(256, 74);
            this.txtFax2.Name = "txtFax2";
            this.txtFax2.Properties.MaxLength = 50;
            this.txtFax2.Size = new System.Drawing.Size(126, 21);
            this.txtFax2.TabIndex = 24;
            // 
            // txtMain2
            // 
            this.txtMain2.Location = new System.Drawing.Point(92, 75);
            this.txtMain2.Name = "txtMain2";
            this.txtMain2.Properties.MaxLength = 50;
            this.txtMain2.Size = new System.Drawing.Size(127, 21);
            this.txtMain2.TabIndex = 22;
            // 
            // lblEmail2
            // 
            this.lblEmail2.AutoSize = true;
            this.lblEmail2.Location = new System.Drawing.Point(1, 192);
            this.lblEmail2.Name = "lblEmail2";
            this.lblEmail2.Size = new System.Drawing.Size(49, 14);
            this.lblEmail2.TabIndex = 33;
            this.lblEmail2.Text = "Email 2:";
            // 
            // txtEmail2
            // 
            this.txtEmail2.Location = new System.Drawing.Point(92, 190);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Properties.MaxLength = 50;
            this.txtEmail2.Size = new System.Drawing.Size(127, 21);
            this.txtEmail2.TabIndex = 28;
            // 
            // lblEmail1
            // 
            this.lblEmail1.AutoSize = true;
            this.lblEmail1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblEmail1.Location = new System.Drawing.Point(1, 167);
            this.lblEmail1.Name = "lblEmail1";
            this.lblEmail1.Size = new System.Drawing.Size(49, 14);
            this.lblEmail1.TabIndex = 31;
            this.lblEmail1.Text = "Email 1:";
            // 
            // txtEmail1
            // 
            this.txtEmail1.Location = new System.Drawing.Point(92, 166);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Properties.MaxLength = 50;
            this.txtEmail1.Size = new System.Drawing.Size(127, 21);
            this.txtEmail1.TabIndex = 27;
            // 
            // lblEmailAddr
            // 
            this.lblEmailAddr.AutoSize = true;
            this.lblEmailAddr.Location = new System.Drawing.Point(1, 145);
            this.lblEmailAddr.Name = "lblEmailAddr";
            this.lblEmailAddr.Size = new System.Drawing.Size(93, 14);
            this.lblEmailAddr.TabIndex = 30;
            this.lblEmailAddr.Text = "Email Addresses";
            // 
            // lblCell
            // 
            this.lblCell.AutoSize = true;
            this.lblCell.Location = new System.Drawing.Point(35, 104);
            this.lblCell.Name = "lblCell";
            this.lblCell.Size = new System.Drawing.Size(29, 14);
            this.lblCell.TabIndex = 28;
            this.lblCell.Text = "Cell:";
            // 
            // txtCell
            // 
            this.txtCell.Location = new System.Drawing.Point(92, 104);
            this.txtCell.Name = "txtCell";
            this.txtCell.Properties.MaxLength = 50;
            this.txtCell.Size = new System.Drawing.Size(126, 21);
            this.txtCell.TabIndex = 25;
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(223, 50);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(29, 14);
            this.lblFax.TabIndex = 25;
            this.lblFax.Text = "Fax:";
            // 
            // txtFax1
            // 
            this.txtFax1.Location = new System.Drawing.Point(256, 48);
            this.txtFax1.Name = "txtFax1";
            this.txtFax1.Properties.MaxLength = 50;
            this.txtFax1.Size = new System.Drawing.Size(126, 21);
            this.txtFax1.TabIndex = 23;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(33, 51);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(35, 14);
            this.lblMain.TabIndex = 22;
            this.lblMain.Text = "Main:";
            // 
            // txtMain1
            // 
            this.txtMain1.Location = new System.Drawing.Point(92, 48);
            this.txtMain1.Name = "txtMain1";
            this.txtMain1.Properties.MaxLength = 50;
            this.txtMain1.Size = new System.Drawing.Size(127, 21);
            this.txtMain1.TabIndex = 21;
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(1, 26);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(93, 14);
            this.lblPhoneNo.TabIndex = 21;
            this.lblPhoneNo.Text = "Phone numbers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 41;
            this.label1.Text = "Supplier ID:";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(101, 4);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(198, 21);
            this.txtSupplierID.TabIndex = 1;
            // 
            // AddEditSupplier
            // 
            this.ClientSize = new System.Drawing.Size(810, 500);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grpNameAddress);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Supplier";
            this.Load += new System.EventHandler(this.AddEditSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtActNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePayment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAccountNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxAgent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreditLimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNameAddress)).EndInit();
            this.grpNameAddress.ResumeLayout(false);
            this.grpNameAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueMr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoViewStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSubscribe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlternateName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDivision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProvince.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpInfo)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCell2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMain2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCell.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMain1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        //Writen by Cong
        //Date 15/3/2007
        public static bool IsValidEmailAddress(string sEmail)
        {
            if (sEmail == null) return false;
            sEmail = sEmail.ToLower();
            if (sEmail.Trim().Length == 0) return true;
            else
            {
                return Regex.IsMatch(sEmail, @"^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\.(com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|[a-zA-Z]{2})$", RegexOptions.IgnorePatternWhitespace);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtCreditLimit.Text.Trim().Length == 0) txtCreditLimit.Text = "0";
            if (txtBalance.Text.Trim().Length == 0) txtBalance.Text = "0";

            if (txtDiscount.Text.Trim().Length == 0) txtDiscount.Text = "0.";
            if (txtSupplierID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Supplier ID must not be empty");
                txtSupplierID.Focus();
                return;
            }
            if (Toolkit.DbToolKit.IsDataOfSqlExists("SELECT * FROM VListSuppliers WHERE [Contact ID] <> '" + strContactID + "' AND [Supplier ID] = '" + txtSupplierID.Text + "'"))
            {
                MessageBox.Show("Duplicate Supplier ID is found");
                txtSupplierID.Focus();
                return;
            }

            if (Toolkit.DbToolKit.IsDataOfSqlExists("SELECT * FROM VListSuppliers WHERE [Contact ID] <> '" + strContactID + "' AND [Company Name] = '" + txtSupplierName.Text + "'"))
            {
                MessageBox.Show("Duplicate Supplier Name is found");
                txtSupplierName.Focus();
                return;
            }
            if (txtSupplierName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Supplier Name must not be empty");
                txtSupplierName.Focus();
                return;                    
            }

            //validate email
            if (!IsValidEmailAddress(txtEmail1.Text.Trim()))
            {
                MessageBox.Show("Email1 is not valid format!");
                return;
            }
            if (!IsValidEmailAddress(txtEmail2.Text.Trim()))
            {
                MessageBox.Show("Email2 is not valid format!");
                return;
            }
            if (txtEmailName.Text.Trim().Length == 0)
            {
                txtEmailName.Text = txtSupplierName.Text;
            }
            if (luePayment.Text.Trim() == "")
            {
                MessageBox.Show("Payment must not be empty");
                luePayment.Focus();
                return;
            }
            if (lueTax.Text.Trim() == "")
            {
                MessageBox.Show("Tax must not be empty");
                lueTax.Focus();
                return;
            }
            if (Single.Parse(txtCreditLimit.EditValue.ToString()) < 0)
            {
                MessageBox.Show("Credit Limit cannot not negative");
                txtCreditLimit.Text = "0.00";
                txtCreditLimit.Focus();
                return;
            }

            Single i = Single.Parse(txtDiscount.EditValue.ToString());
            if (i < 0 || i > 100) {
                MessageBox.Show("The input range must be between 0 and 100");
                txtDiscount.Text = "0.00";
                txtDiscount.Focus();
                return;
            }




            //End Cong
            if (strContactID == "")
                InsertSupplier();
            else
                UpdateSupplier();

            MessageBox.Show("Record is saved");
            DialogResult = DialogResult.OK;
        }

        private void InsertSupplier()
        {
            string strInsertCategory;

            SqlTransaction tx;

            string strContactID = Guid.NewGuid().ToString();

            //string strSQL = "INSERT INTO Contact (ContactID, ContactName, EmailName, Department, Division, Address1, Address2" +
            //    "City, Province, Zip, Country, Phone1, Phone2, Fax1, Fax2, Cell1, Email1, Email2, " +
            //    "Website, ContactGroupID, MembershipID, SubscribeNews, ViewStatus" +
            //    ")Values('" + strContactID + "', '" +  txtSupplierName.Text + "','" + txtEmailName.Text +
            //    "','" + txtDepartment.Text + "','" + txtDivision.Text + "','" + txtAddress1.Text + "','" + txtAddress2.Text + "','" +
            //    txtCity.Text + "','" + txtProvince.Text + "','" + txtZip.Text + "','" + txtCountry.Text +
            //    "','" + txtMain1.Text + "','" + txtMain2.Text + "','" + txtFax1.Text + "','" + txtFax2.Text + "','" + txtCell.Text + "','" +
            //    txtEmail1.Text + "', '" + txtEmail2.Text + "'," + txtWebsite.Text + "', '3', '1', '" +
            //    chkSubscribe.Checked + 
            //    "', '" + rdoViewStatus.EditValue + "')";

            string dot = "', '";
            string strSQL = "INSERT INTO Contact (ContactName, CompanyName, Alt_contact, ContactID, Mr, FirstName, MiddleName, LastName, EmailName, " +
                "Department, Division, Address1, Address2, City, Province, Zip, Country, Website, Phone1, Phone2, Fax1, Fax2, Cell1, Cell2, Email1, Email2, Email3," +
                "ContactGroupID, SubscribeNews, ViewStatus, Notes, UserID)Values('" +
                txtCompanyName.Text + dot + txtSupplierName.Text + dot + txtAlternateName.Text + dot +
                strContactID + dot + lueMr.Text + dot + txtFirstName.Text + dot + txtMiddleName.Text + dot + txtLastName.Text + dot +
                txtEmailName.Text + dot + txtDepartment.Text + dot + txtDivision.Text + dot + txtAddress1.Text + dot +
                txtAddress2.Text + dot + txtCity.Text + dot + txtProvince.Text + dot + txtZip.Text + dot + txtCountry.Text + dot + txtWebsite.Text + dot + txtMain1.Text + dot +
                txtMain2.Text + dot + txtFax1.Text + dot + txtFax2.Text + dot + txtCell.Text + dot + txtCell2.Text + dot + txtEmail1.Text + dot +
                txtEmail2.Text + dot + txtEmail3.Text + dot + '3' + dot + chkSubscribe.Checked + dot +
                rdoViewStatus.EditValue + dot + txtNotes.Text + dot + Globals.UserID + "')";

            strSQL += "; INSERT INTO ContactListForContact(ContactId, ContactPersonId) VALUES('" + strContactID + "', '" + strContactID + "')";

            strSQL += "; INSERT INTO SupplierContact( ContactId, SupplierID, Payment_Term_Id, Tax_Code_id," +
                      "Discount, Currency, Credit_Limit, Balance, Tax_Agent, Account_number) VALUES('" +
                      strContactID + dot + txtSupplierID.Text + dot + luePayment.EditValue + dot + lueTax.EditValue + dot +
                      txtDiscount.Text + dot + txtCurrency.Text + dot + txtCreditLimit.Text + dot + txtBalance.Text + dot + txtTaxAgent.Text + "', '" + txtActNo.Text + "')";
            //strSQL += "; INSERT INTO MemberContact(ContactID, MembershipCardID, MembershipID) VALUES ('" + strContactID + "', '1', '1')";
            if (cnContactMgmt.State == ConnectionState.Closed)
                cnContactMgmt.Open();

            SqlCommand cmdUpdate = cnContactMgmt.CreateCommand();


            tx = cnContactMgmt.BeginTransaction();

            try
            {
                this.Cursor = Cursors.WaitCursor;

                cmdUpdate.CommandText = strSQL;
                cmdUpdate.Transaction = tx;
                cmdUpdate.ExecuteNonQuery();

                foreach (DataRow datarow in dtSelectedCat.Rows)
                {
                    strInsertCategory = "INSERT INTO ContactCategory (ContactCatID, ContactID) Values ('" + datarow["ContactCatID"].ToString() + "', '" + strContactID + "')";
                    cmdUpdate.CommandText = strInsertCategory;
                    cmdUpdate.ExecuteNonQuery();
                }

                tx.Commit();
                this.Cursor = Cursors.Default;
                this.strContactID = strContactID;

            }
            catch (Exception exc)
            {
                tx.Rollback();

                MessageBox.Show(exc.Message, "Exception");
                this.Cursor = Cursors.Default;
            }
            finally
            {
                cnContactMgmt.Close();
            }
        }

        private void UpdateSupplier()
        {
            string strSQLDeleteAll;
            string strInsertCategory;

            string strSQL = "UPDATE Contact SET " +
                            "CompanyName = '" + txtSupplierName.Text +
                            "',  ContactName = '" + txtCompanyName.Text +
                            "',  Alt_Contact = '" + txtAlternateName.Text +
                            "',  FirstName = '" + txtFirstName.Text +
                            "', MiddleName = '" + txtMiddleName.Text +
                            "', LastName = '" + txtLastName.Text +
                            "', Mr = '" + lueMr.Text +
                            "', EmailName = '" + txtEmailName.Text +
                            "', Department = '" + txtDepartment.Text +
                            "', Division = '" + txtDivision.Text +
                            "', Address1 = '" + txtAddress1.Text +
                            "', Address2 = '" + txtAddress2.Text +
                            "', City = '" + txtCity.Text +
                            "', Province = '" + txtProvince.Text +
                            "', Zip = '" + txtZip.Text.Trim() +
                            "', Country = '" + txtCountry.Text +
                            "', Phone1 = '" + txtMain1.Text +
                            "', Phone2 = '" + txtMain2.Text +
                            "', Notes = '" + txtNotes.Text +
                            "', Fax1 = '" + txtFax1.Text +
                            "', Fax2 = '" + txtFax2.Text +
                            "', Cell1 = '" + txtCell.Text +
                            "', Cell2 = '" + txtCell2.Text +
                            "', Website = '" + txtWebsite.Text +
                            "', Email1 = '" + txtEmail1.Text +
                            "', Email2 = '" + txtEmail2.Text +
                            "', Email3 = '" + txtEmail3.Text +   
                            "', SubscribeNews = '" + chkSubscribe.Checked +
                            "', UserID = '" + Globals.UserID + 
                            "', ViewStatus= '" + rdoViewStatus.EditValue +
                            "' WHERE ContactID = '" + strContactID + "'";
            if (txtBalance.Text.Trim().Length == 0) txtBalance.Text = "0";
            string dot = "' ,";
            strSQL += "; UPDATE SupplierContact SET Payment_Term_id = '" + luePayment.EditValue.ToString() + dot +
                      "SupplierID = '" + txtSupplierID.Text + dot + 
                      "Tax_Code_id = '" + lueTax.EditValue.ToString() + dot +
                      "Discount = '" +  txtDiscount.EditValue + dot +
                      "Currency = '" + txtCurrency.Text + dot +
                      "Credit_Limit = '" + txtCreditLimit.Text + dot +
                      "Balance = '" + txtBalance.Text + dot +
                      "Tax_Agent = '" + txtTaxAgent.Text + dot + 
                      //"Account_number = '" + lueAccountNo.Text +
                      "Account_number = '" + txtActNo.Text + 
                      "' WHERE ContactID = '" + strContactID + "'";      
            SqlTransaction tx;

            if (cnContactMgmt.State == ConnectionState.Closed)
                cnContactMgmt.Open();

            SqlCommand cmdUpdate = cnContactMgmt.CreateCommand();

            tx = cnContactMgmt.BeginTransaction();

            try
            {
                this.Cursor = Cursors.WaitCursor;

                cmdUpdate.CommandText = strSQL;
                cmdUpdate.Transaction = tx;
                cmdUpdate.ExecuteNonQuery();

                strSQLDeleteAll = "DELETE FROM ContactCategory WHERE ContactID = '" + strContactID + "'";
                cmdUpdate.CommandText = strSQLDeleteAll;
                cmdUpdate.ExecuteNonQuery();

                foreach (DataRow datarow in dtSelectedCat.Rows)
                {
                    strInsertCategory = "INSERT INTO ContactCategory (ContactCatID, ContactID) Values ('" + datarow["ContactCatID"].ToString() + "', '" + strContactID + "')";
                    cmdUpdate.CommandText = strInsertCategory;
                    cmdUpdate.ExecuteNonQuery();
                }

                tx.Commit();
                this.Cursor = Cursors.Default;

            }
            catch (Exception exc)
            {
                tx.Rollback();

                MessageBox.Show(exc.Message, "Exception");
                this.Cursor = Cursors.Default;
            }
            finally
            {
                cnContactMgmt.Close();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (needDelete)
                DeleteContact(strContactID);
            DialogResult = DialogResult.Cancel;
        }

        private void AddEditSupplier_Load(object sender, EventArgs e)
        {
            cnContactMgmt = new SqlConnection(Globals.strVISConnection);

            try
            {
                if (strContactID != "")
                {
                    LoadData();
                    LoadCategoryData();
                    bteCategory.Text = ListCategory();
                }
                else
                {
                    LoadCategoryData();
                    txtWebsite.Text = "http://";
                }
                /*
                if (LoginUser.strLoginGroup == "Administrator")
                    rdoViewStatus.Enabled = true;
                else
                 */
                    rdoViewStatus.Enabled = true;

                    txtSupplierID.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadCategoryData()
        {
            if (cnContactMgmt.State == ConnectionState.Closed)
                cnContactMgmt.Open();

            daSupplier = new SqlDataAdapter("SELECT * FROM VContactCategory" + " WHERE ContactID = '" + strContactID + "'", cnContactMgmt);
            daSupplier.Fill(dsSupplier, "ContactCategory");
            dtSelectedCat = dsSupplier.Tables["ContactCategory"];

            DataTable dtMr = new DataTable();

            String strSQL = "SELECT MrName, MrId FROM Mr";

            cnContactMgmt.Close();
            cnContactMgmt.Open();

            SqlDataAdapter daMr = new SqlDataAdapter(strSQL, cnContactMgmt);
            daMr.Fill(dtMr);
            ControlSetting.FillLookupEdit(lueMr, dtMr, dtMr.Columns["MrName"].ColumnName, "MrId");

            dtMr = new DataTable();

            strSQL = "SELECT ID, PaymentTermsName FROM PaymentTermMaster WHERE ViewStatus = 'true'";

            cnContactMgmt.Close();
            cnContactMgmt.Open();

            daMr = new SqlDataAdapter(strSQL, cnContactMgmt);
            daMr.Fill(dtMr);
            ControlSetting.FillLookupEdit(luePayment, dtMr, "PaymentTermsName", "ID");

            dtMr = new DataTable();

            strSQL = "SELECT Tax_code_id, Tax_code_desc FROM Tax_Code_Master WHERE ViewStatus = 'true'";

            cnContactMgmt.Close();
            cnContactMgmt.Open();

            daMr = new SqlDataAdapter(strSQL, cnContactMgmt);
            daMr.Fill(dtMr);
            ControlSetting.FillLookupEdit(lueTax, dtMr, "Tax_code_desc", "Tax_code_id");

            if (luePayment.Tag != null)
                luePayment.EditValue = luePayment.Tag.ToString();
            if (lueTax.Tag != null)
                lueTax.EditValue = lueTax.Tag.ToString();
            if (lueMr.Tag != null)
            lueMr.EditValue = lueMr.Properties.GetKeyValueByDisplayText(lueMr.Tag.ToString());
            if (lueAccountNo.Tag != null)
            lueAccountNo.EditValue = lueAccountNo.Properties.GetKeyValueByDisplayText(lueAccountNo.Tag.ToString());
        }

        private void LoadData()
        {
            SqlDataReader drSupplier = null;

            string strSQL = "SELECT * FROM VListSuppliers" + " WHERE [Contact ID] = '" + strContactID + "'";

            SqlCommand cmdSelect = new SqlCommand(strSQL, cnContactMgmt);

            try
            {
                if (cnContactMgmt.State == ConnectionState.Closed)
                    cnContactMgmt.Open();

                drSupplier = cmdSelect.ExecuteReader();

                while (drSupplier.Read())
                {
                    //txtSupplierName.Text = drSupplier["Company Name"].ToString();
                    //txtDepartment.Text = drSupplier["Department"].ToString();
                    //txtDivision.Text = drSupplier["Division"].ToString();
                    //txtAddress1.Text = drSupplier["Address 1"].ToString();
                    //txtAddress2.Text = drSupplier["Address 2"].ToString();
                    //txtCity.Text = drSupplier["City"].ToString();
                    //txtProvince.Text = drSupplier["Province"].ToString();
                    //txtZip.Text = drSupplier["Zip"].ToString();
                    //txtCountry.Text = drSupplier["Country"].ToString();
                    //txtMain1.Text = drSupplier["Phone 1"].ToString();
                    //txtMain2.Text = drSupplier["Phone 2"].ToString();
                    //txtFax1.Text = drSupplier["Fax 1"].ToString();
                    //txtFax2.Text = drSupplier["Fax 2"].ToString();
                    //txtCell.Text = drSupplier["Cell"].ToString();
                    //txtEmail1.Text = drSupplier["Email 1"].ToString();
                    //txtEmail2.Text = drSupplier["Email 2"].ToString();
                    //txtEmailName.Text = drSupplier["Email Name"].ToString();
                    
                    //chkSubscribe.Checked = (bool)drSupplier["SubscribeNews"];
                    //rdoViewStatus.EditValue = (bool)drSupplier["ViewStatus"];
                    txtCompanyName.Text = drSupplier["Contact Name"].ToString();
                    txtDepartment.Text = drSupplier["Department"].ToString();
                    txtDivision.Text = drSupplier["Division"].ToString();
                    txtAddress1.Text = drSupplier["Address 1"].ToString();
                    txtAddress2.Text = drSupplier["Address 2"].ToString();
                    txtCity.Text = drSupplier["City"].ToString();
                    txtProvince.Text = drSupplier["Province"].ToString();
                    txtZip.Text = drSupplier["Zip"].ToString();
                    txtCountry.Text = drSupplier["Country"].ToString();
                    txtMain1.Text = drSupplier["Phone 1"].ToString();
                    txtMain2.Text = drSupplier["Phone 2"].ToString();
                    txtFax1.Text = drSupplier["Fax 1"].ToString();
                    txtNotes.Text = drSupplier["Notes"].ToString();
                    txtFax2.Text = drSupplier["Fax 2"].ToString();
                    txtCell.Text = drSupplier["Cell 1"].ToString();
                    txtCell2.Text = drSupplier["Cell 2"].ToString();
                    txtEmail1.Text = drSupplier["Email 1"].ToString();
                    txtEmail2.Text = drSupplier["Email 2"].ToString();
                    txtEmail3.Text = drSupplier["Email 3"].ToString();
                    txtEmailName.Text = drSupplier["Email Name"].ToString();
                    txtWebsite.Text = drSupplier["Website"].ToString();
                    chkSubscribe.Checked = (bool)drSupplier["SubscribeNews"];
                    rdoViewStatus.EditValue = (bool)drSupplier["ViewStatus"];
                    txtFirstName.Text = drSupplier["First Name"].ToString();
                    txtMiddleName.Text = drSupplier["Middle Name"].ToString();
                    txtLastName.Text = drSupplier["Last Name"].ToString();
                    txtSupplierName.Text = drSupplier["Company Name"].ToString();
                    txtAlternateName.Text = drSupplier["Alt Contact"].ToString();
                    txtCreditLimit.Text = drSupplier["Credit Limit"].ToString();
                    txtCurrency.Text = drSupplier["Currency"].ToString();
                    txtBalance.Text = drSupplier["Balance"].ToString();
                    txtDiscount.Text = drSupplier["Discount"].ToString();
                    txtTaxAgent.Text = drSupplier["Tax Agent"].ToString();
                    txtWebsite.Text = drSupplier["Website"].ToString();
                    lueMr.Tag = drSupplier["Mr"].ToString();
                    luePayment.Tag = drSupplier["Payment term id"].ToString();
                    lueTax.Tag = drSupplier["Tax code id"].ToString();
                    //lueAccountNo.Tag = drSupplier["Account Number"].ToString();
                    txtActNo.Text = drSupplier["Account Number"].ToString();
                    txtSupplierID.Text = drSupplier["Supplier ID"].ToString();
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }
            finally
            {
                if (drSupplier != null)
                    drSupplier.Close();

                if (cnContactMgmt.State == ConnectionState.Closed)
                    cnContactMgmt.Close();
            }
            LoadAccount(strContactID);
        }

        private void bteCategory_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SelectContactCat frmSelectContactCat = new SelectContactCat(dsSupplier.Tables["ContactCategory"], strContactID);
            frmSelectContactCat.ShowDialog();

            dtSelectedCat = frmSelectContactCat.getCheckedItems();
            bteCategory.Text = ListCategory();
        }

        private string ListCategory()
        {
            string strCategoryList = string.Empty;

            if (dtSelectedCat.Rows.Count > 0)
            {
                foreach (DataRow row in dtSelectedCat.Rows)
                {
                    strCategoryList += row["ContactCatName"].ToString() + ", ";
                }
                strCategoryList = strCategoryList.Remove(strCategoryList.Length - 2);
            }

            return strCategoryList;
        }

        private void txtWebsite_Enter(object sender, EventArgs e)
        {
            if (txtWebsite.Text.Trim().Equals("http://"))
            {
                txtWebsite.SelectionStart = 7;
                txtWebsite.SelectionLength = 0;
            }
        }

        private void txtEmail3_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void lueMr_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                //if (Globals.CheckAccessRights(Globals.UserID,"D475ABD5-A9A7-43BE-BA80-A7BFAE6FAACB",true))
                {

                    AddEditMr frmAddEditMr = new AddEditMr(lueMr.Text);
                    frmAddEditMr.ShowDialog();
                    lueMr.Properties.Columns.Clear();
                    lueMr.DataBindings.Clear();
                    DataTable dtMr = new DataTable();

                    String strSQL = "SELECT MrName, MrId FROM Mr";

                    cnContactMgmt.Close();
                    cnContactMgmt.Open();

                    SqlDataAdapter daMr = new SqlDataAdapter(strSQL, cnContactMgmt);
                    daMr.Fill(dtMr);
                    ControlSetting.FillLookupEdit(lueMr, dtMr, dtMr.Columns["MrName"].ColumnName, "MrId");
                }
            }
        }

        private void lueTax_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                //if (Globals.CheckAccessRights(Globals.UserID,"89D4594C-CDA9-49D9-BDD1-308335559A92",true))
                {

                    AddEditTax frm;
                    if (lueTax.EditValue != null)
                        frm = new AddEditTax(lueTax.EditValue.ToString());
                    else frm = new AddEditTax("");
                    frm.ShowDialog();
                    lueTax.Properties.Columns.Clear();
                    lueTax.DataBindings.Clear();
                    DataTable dtMr = new DataTable();

                    string strSQL = "SELECT Tax_code_id, Tax_code_desc FROM Tax_Code_Master WHERE ViewStatus = 'true'";

                    cnContactMgmt.Close();
                    cnContactMgmt.Open();

                    SqlDataAdapter daMr = new SqlDataAdapter(strSQL, cnContactMgmt);
                    daMr.Fill(dtMr);
                    ControlSetting.FillLookupEdit(lueTax, dtMr, "Tax_code_desc", "Tax_code_id");
                }
            }
        }

        private void luePayment_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                //if (Globals.CheckAccessRights(Globals.UserID,"6E76E7ED-610C-4179-95BA-769B45DE0368",true))
                {

                    AddEditPayment frm;
                    if (luePayment.EditValue != null)
                        frm = new AddEditPayment(luePayment.EditValue.ToString());
                    else frm = new AddEditPayment("");
                    frm.ShowDialog();
                    luePayment.Properties.Columns.Clear();
                    luePayment.DataBindings.Clear();

                    DataTable dtMr = new DataTable();

                    string strSQL = "SELECT ID, PaymentTermsName FROM PaymentTermMaster WHERE ViewStatus = 'true'";

                    cnContactMgmt.Close();
                    cnContactMgmt.Open();

                    SqlDataAdapter daMr = new SqlDataAdapter(strSQL, cnContactMgmt);
                    daMr.Fill(dtMr);
                    ControlSetting.FillLookupEdit(luePayment, dtMr, "PaymentTermsName", "ID");
                }
            }
        }

        private void grpNameAddress_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadAccount(string ID)
        {
            lueAccountNo.Properties.Columns.Clear();
            lueAccountNo.DataBindings.Clear();
            DataTable dtAccount = new DataTable();

            string strSQL = "SELECT ID,AccountNo FROM ContactBankAccount WHERE ContactID = '" + ID + "'";

            try
            {
                cnContactMgmt.Close();
                cnContactMgmt.Open();

                SqlDataAdapter daAccount = new SqlDataAdapter(strSQL, cnContactMgmt);
                daAccount.Fill(dtAccount);
                ControlSetting.FillLookupEdit(lueAccountNo, dtAccount, "AccountNo", "ID");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                if (cnContactMgmt.State == ConnectionState.Closed)
                    cnContactMgmt.Close();
            }
        }


        private int DeleteContact(string ID)
        {
            SqlCommand cmd = new SqlCommand();
            Int32 rowsAffected;
            string strSQL = "DELETE FROM ContactBankAccount WHERE ContactId like '" + ID + "';" +
                "DELETE FROM SupplierContact WHERE ContactId like '" + ID + "';" +
                "DELETE FROM ContactListForContact WHERE ContactId like '" + ID + "';" +
                "DELETE FROM Contact WHERE ContactID like '" + ID + "';" +
                "DELETE FROM ContactCategory WHERE ContactID like '" + ID + "';";
            cmd.CommandText = strSQL;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnContactMgmt;
            try
            {
                if (cnContactMgmt.State == ConnectionState.Closed)
                    cnContactMgmt.Open();

                rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnContactMgmt.Close();
            }
            return 0;
        }

        private void lueAccountNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                if ((!isSaved) && (strContactID == ""))//new and click first time
                {
                    if (txtCreditLimit.Text.Trim().Length == 0) txtCreditLimit.Text = "0";
                    if (txtBalance.Text.Trim().Length == 0) txtBalance.Text = "0";
                    if (txtDiscount.Text.Trim().Length == 0) txtDiscount.Text = "0";
                    InsertSupplier();
                    isSaved = true;
                    needDelete = true;
                }
                AddEditAccount frmAddEditAccount;
                if (lueAccountNo.EditValue != null)
                    frmAddEditAccount = new AddEditAccount(strContactID, lueAccountNo.EditValue.ToString());
                else frmAddEditAccount = new AddEditAccount(strContactID, "");
                frmAddEditAccount.ShowDialog();
                lueAccountNo.Text = "";
                LoadAccount(strContactID);
            }
        }
    }
}

