using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraEditors;
using System.Text.RegularExpressions;
using VIS.ControlSetting;
using Toolkit;

namespace Inventory
{
    /// <summary>
    /// Summary description for AddEditCustomer.
    /// </summary>
    public class AddEditCustomer : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private GroupControl grpInfo;
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
        private GroupControl grpNameAddress;
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
        private TextEdit txtMain2;
        private Label lblDivision;
        private TextEdit txtDivision;
        private Label lblDepartment;
        private TextEdit txtDepartment;
        private TextEdit txtFax2;
        private Label lblWebsite;
        private TextEdit txtWebsite;
        private Label label27;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        private string strContactID;
        private string strOrderStatus;

        private DataTable dtSelectedCat = new DataTable();
        private SqlConnection cnContactMgmt = null;
        private SqlDataAdapter daCompany;
        private Label label2;
        private TextEdit txtEmailName;
        private Label label1;
        private TextEdit txtContactName;
        private Label lblLastName;
        private TextEdit txtLastName;
        private Label lblMiddleName;
        private TextEdit txtMiddleName;
        private Label lblFirstName;
        private Label lblMr;
        private TextEdit txtFirstName;
        private Label label3;
        private TextEdit txtAlternateName;
        private TextEdit txtCell2;
        private Label label6;
        private TextEdit txtEmail3;
        private GroupControl groupControl1;
        private Label label4;
        private GroupControl groupControl2;
        private Label label5;
        private Label label8;
        private TextEdit txtCreditLimit;
        private Label label7;
        private Label label12;
        private TextEdit txtTaxAgent;
        private Label label11;
        private TextEdit txtDiscount;
        private Label label10;
        private TextEdit txtBalance;
        private Label label9;
        private TextEdit txtCurrency;
        private Label label14;
        private TextEdit txtBillCountry;
        private Label label15;
        private TextEdit txtBillZip;
        private Label label16;
        private TextEdit txtBillProvince;
        private Label label17;
        private TextEdit txtBillCity;
        private Label label13;
        private TextEdit txtBillAddress;
        private Label label19;
        private Label label18;
        private TextEdit txtPhone;
        private TextEdit txtEmail;
        private GroupControl groupControl3;
        private Label label20;
        private Label label21;
        private TextEdit txtShipPhone;
        private TextEdit txtShipEmail;
        private Label label22;
        private TextEdit txtShipCountry;
        private Label label23;
        private TextEdit textEdit17;
        private Label label24;
        private TextEdit textEdit18;
        private Label label25;
        private TextEdit txtShipCity;
        private Label label26;
        private TextEdit txtShipAddress;
        private CheckEdit chkSubscribe;
        private ButtonEdit bteCategory;
        private Label lblCategory;
        private Label lblViewStatus;
        private RadioGroup rdoViewStatus;
        private Label label28;
        private TextEdit txtShipParentId;
        private LookUpEdit lueMr;
        private LookUpEdit luePayment;
        private LookUpEdit lueTax;
        private LookUpEdit lueAccountNo;
        private Label label29;
        private TextEdit txtCustomerID;
        private DataSet dsCompany = new DataSet();
        private bool isSaved = false;
        private TextEdit txtActNo;
        private bool needDelete = false;
        public AddEditCustomer(string ID, string orderStatus)
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
            this.grpInfo = new DevExpress.XtraEditors.GroupControl();
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
            this.lblWebsite = new System.Windows.Forms.Label();
            this.txtWebsite = new DevExpress.XtraEditors.TextEdit();
            this.grpNameAddress = new DevExpress.XtraEditors.GroupControl();
            this.rdoViewStatus = new DevExpress.XtraEditors.RadioGroup();
            this.lueMr = new DevExpress.XtraEditors.LookUpEdit();
            this.chkSubscribe = new DevExpress.XtraEditors.CheckEdit();
            this.bteCategory = new DevExpress.XtraEditors.ButtonEdit();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblViewStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlternateName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContactName = new DevExpress.XtraEditors.TextEdit();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMr = new System.Windows.Forms.Label();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
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
            this.txtCompanyName = new DevExpress.XtraEditors.TextEdit();
            this.label27 = new System.Windows.Forms.Label();
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBillCountry = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBillZip = new DevExpress.XtraEditors.TextEdit();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBillProvince = new DevExpress.XtraEditors.TextEdit();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBillCity = new DevExpress.XtraEditors.TextEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBillAddress = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.label28 = new System.Windows.Forms.Label();
            this.txtShipParentId = new DevExpress.XtraEditors.TextEdit();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtShipPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtShipEmail = new DevExpress.XtraEditors.TextEdit();
            this.label22 = new System.Windows.Forms.Label();
            this.txtShipCountry = new DevExpress.XtraEditors.TextEdit();
            this.label23 = new System.Windows.Forms.Label();
            this.textEdit17 = new DevExpress.XtraEditors.TextEdit();
            this.label24 = new System.Windows.Forms.Label();
            this.textEdit18 = new DevExpress.XtraEditors.TextEdit();
            this.label25 = new System.Windows.Forms.Label();
            this.txtShipCity = new DevExpress.XtraEditors.TextEdit();
            this.label26 = new System.Windows.Forms.Label();
            this.txtShipAddress = new DevExpress.XtraEditors.TextEdit();
            this.label29 = new System.Windows.Forms.Label();
            this.txtCustomerID = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNameAddress)).BeginInit();
            this.grpNameAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdoViewStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSubscribe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlternateName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDivision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProvince.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillZip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillProvince.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipParentId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit17.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit18.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(403, 614);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(296, 614);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 23);
            this.btnOK.TabIndex = 52;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grpInfo
            // 
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
            this.grpInfo.Location = new System.Drawing.Point(403, 33);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(395, 235);
            this.grpInfo.TabIndex = 20;
            this.grpInfo.Text = "Other Information";
            // 
            // txtCell2
            // 
            this.txtCell2.Location = new System.Drawing.Point(261, 145);
            this.txtCell2.Name = "txtCell2";
            this.txtCell2.Properties.MaxLength = 50;
            this.txtCell2.Size = new System.Drawing.Size(126, 21);
            this.txtCell2.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 14);
            this.label6.TabIndex = 40;
            this.label6.Text = "Email 3:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtEmail3
            // 
            this.txtEmail3.Location = new System.Drawing.Point(92, 171);
            this.txtEmail3.Name = "txtEmail3";
            this.txtEmail3.Properties.MaxLength = 50;
            this.txtEmail3.Size = new System.Drawing.Size(127, 21);
            this.txtEmail3.TabIndex = 35;
            this.txtEmail3.EditValueChanged += new System.EventHandler(this.txtEmail3_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 37;
            this.label2.Text = "Email Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEmailName
            // 
            this.txtEmailName.Location = new System.Drawing.Point(92, 204);
            this.txtEmailName.Name = "txtEmailName";
            this.txtEmailName.Size = new System.Drawing.Size(127, 21);
            this.txtEmailName.TabIndex = 36;
            this.txtEmailName.EditValueChanged += new System.EventHandler(this.txtEmailName_EditValueChanged);
            // 
            // txtFax2
            // 
            this.txtFax2.Location = new System.Drawing.Point(261, 73);
            this.txtFax2.Name = "txtFax2";
            this.txtFax2.Properties.MaxLength = 50;
            this.txtFax2.Size = new System.Drawing.Size(126, 21);
            this.txtFax2.TabIndex = 32;
            // 
            // txtMain2
            // 
            this.txtMain2.Location = new System.Drawing.Point(92, 75);
            this.txtMain2.Name = "txtMain2";
            this.txtMain2.Properties.MaxLength = 50;
            this.txtMain2.Size = new System.Drawing.Size(127, 21);
            this.txtMain2.TabIndex = 30;
            // 
            // lblEmail2
            // 
            this.lblEmail2.AutoSize = true;
            this.lblEmail2.Location = new System.Drawing.Point(6, 154);
            this.lblEmail2.Name = "lblEmail2";
            this.lblEmail2.Size = new System.Drawing.Size(49, 14);
            this.lblEmail2.TabIndex = 33;
            this.lblEmail2.Text = "Email 2:";
            this.lblEmail2.Click += new System.EventHandler(this.lblEmail2_Click);
            // 
            // txtEmail2
            // 
            this.txtEmail2.Location = new System.Drawing.Point(92, 145);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Properties.MaxLength = 50;
            this.txtEmail2.Size = new System.Drawing.Size(127, 21);
            this.txtEmail2.TabIndex = 34;
            this.txtEmail2.EditValueChanged += new System.EventHandler(this.txtEmail2_EditValueChanged);
            // 
            // lblEmail1
            // 
            this.lblEmail1.AutoSize = true;
            this.lblEmail1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblEmail1.Location = new System.Drawing.Point(6, 129);
            this.lblEmail1.Name = "lblEmail1";
            this.lblEmail1.Size = new System.Drawing.Size(49, 14);
            this.lblEmail1.TabIndex = 31;
            this.lblEmail1.Text = "Email 1:";
            this.lblEmail1.Click += new System.EventHandler(this.lblEmail1_Click);
            // 
            // txtEmail1
            // 
            this.txtEmail1.Location = new System.Drawing.Point(92, 121);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Properties.MaxLength = 50;
            this.txtEmail1.Size = new System.Drawing.Size(127, 21);
            this.txtEmail1.TabIndex = 33;
            this.txtEmail1.EditValueChanged += new System.EventHandler(this.txtEmail1_EditValueChanged);
            // 
            // lblEmailAddr
            // 
            this.lblEmailAddr.AutoSize = true;
            this.lblEmailAddr.Location = new System.Drawing.Point(6, 106);
            this.lblEmailAddr.Name = "lblEmailAddr";
            this.lblEmailAddr.Size = new System.Drawing.Size(93, 14);
            this.lblEmailAddr.TabIndex = 30;
            this.lblEmailAddr.Text = "Email Addresses";
            this.lblEmailAddr.Click += new System.EventHandler(this.lblEmailAddr_Click);
            // 
            // lblCell
            // 
            this.lblCell.AutoSize = true;
            this.lblCell.Location = new System.Drawing.Point(221, 128);
            this.lblCell.Name = "lblCell";
            this.lblCell.Size = new System.Drawing.Size(29, 14);
            this.lblCell.TabIndex = 28;
            this.lblCell.Text = "Cell:";
            // 
            // txtCell
            // 
            this.txtCell.Location = new System.Drawing.Point(261, 120);
            this.txtCell.Name = "txtCell";
            this.txtCell.Properties.MaxLength = 50;
            this.txtCell.Size = new System.Drawing.Size(126, 21);
            this.txtCell.TabIndex = 37;
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(221, 48);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(29, 14);
            this.lblFax.TabIndex = 25;
            this.lblFax.Text = "Fax:";
            // 
            // txtFax1
            // 
            this.txtFax1.Location = new System.Drawing.Point(260, 44);
            this.txtFax1.Name = "txtFax1";
            this.txtFax1.Properties.MaxLength = 50;
            this.txtFax1.Size = new System.Drawing.Size(126, 21);
            this.txtFax1.TabIndex = 31;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(6, 47);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(35, 14);
            this.lblMain.TabIndex = 22;
            this.lblMain.Text = "Main:";
            // 
            // txtMain1
            // 
            this.txtMain1.Location = new System.Drawing.Point(92, 45);
            this.txtMain1.Name = "txtMain1";
            this.txtMain1.Properties.MaxLength = 50;
            this.txtMain1.Size = new System.Drawing.Size(127, 21);
            this.txtMain1.TabIndex = 29;
            this.txtMain1.EditValueChanged += new System.EventHandler(this.txtMain1_EditValueChanged);
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(6, 21);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(93, 14);
            this.lblPhoneNo.TabIndex = 21;
            this.lblPhoneNo.Text = "Phone numbers";
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Location = new System.Drawing.Point(5, 322);
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
            // grpNameAddress
            // 
            this.grpNameAddress.Controls.Add(this.rdoViewStatus);
            this.grpNameAddress.Controls.Add(this.lueMr);
            this.grpNameAddress.Controls.Add(this.chkSubscribe);
            this.grpNameAddress.Controls.Add(this.bteCategory);
            this.grpNameAddress.Controls.Add(this.lblCategory);
            this.grpNameAddress.Controls.Add(this.lblViewStatus);
            this.grpNameAddress.Controls.Add(this.label3);
            this.grpNameAddress.Controls.Add(this.txtAlternateName);
            this.grpNameAddress.Controls.Add(this.label1);
            this.grpNameAddress.Controls.Add(this.txtContactName);
            this.grpNameAddress.Controls.Add(this.lblLastName);
            this.grpNameAddress.Controls.Add(this.txtLastName);
            this.grpNameAddress.Controls.Add(this.lblMiddleName);
            this.grpNameAddress.Controls.Add(this.txtMiddleName);
            this.grpNameAddress.Controls.Add(this.lblFirstName);
            this.grpNameAddress.Controls.Add(this.lblMr);
            this.grpNameAddress.Controls.Add(this.txtFirstName);
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
            this.grpNameAddress.Controls.Add(this.txtCompanyName);
            this.grpNameAddress.Location = new System.Drawing.Point(12, 33);
            this.grpNameAddress.Name = "grpNameAddress";
            this.grpNameAddress.Size = new System.Drawing.Size(382, 424);
            this.grpNameAddress.TabIndex = 1;
            this.grpNameAddress.Text = "Name and address";
            // 
            // rdoViewStatus
            // 
            this.rdoViewStatus.EditValue = true;
            this.rdoViewStatus.Location = new System.Drawing.Point(231, 350);
            this.rdoViewStatus.Name = "rdoViewStatus";
            this.rdoViewStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Enable"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Disable")});
            this.rdoViewStatus.Size = new System.Drawing.Size(129, 28);
            this.rdoViewStatus.TabIndex = 19;
            // 
            // lueMr
            // 
            this.lueMr.Location = new System.Drawing.Point(11, 38);
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
            // chkSubscribe
            // 
            this.chkSubscribe.EditValue = true;
            this.chkSubscribe.Location = new System.Drawing.Point(7, 355);
            this.chkSubscribe.Name = "chkSubscribe";
            this.chkSubscribe.Properties.Caption = "Subscribe Newsletters";
            this.chkSubscribe.Size = new System.Drawing.Size(145, 19);
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
            this.lblCategory.Location = new System.Drawing.Point(4, 392);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(60, 14);
            this.lblCategory.TabIndex = 63;
            this.lblCategory.Text = "Category:";
            // 
            // lblViewStatus
            // 
            this.lblViewStatus.AutoSize = true;
            this.lblViewStatus.Location = new System.Drawing.Point(153, 356);
            this.lblViewStatus.Name = "lblViewStatus";
            this.lblViewStatus.Size = new System.Drawing.Size(77, 14);
            this.lblViewStatus.TabIndex = 64;
            this.lblViewStatus.Text = "View Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 14);
            this.label3.TabIndex = 49;
            this.label3.Text = "Alternate Name:";
            // 
            // txtAlternateName
            // 
            this.txtAlternateName.Location = new System.Drawing.Point(191, 76);
            this.txtAlternateName.Name = "txtAlternateName";
            this.txtAlternateName.Properties.MaxLength = 50;
            this.txtAlternateName.Size = new System.Drawing.Size(172, 21);
            this.txtAlternateName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 14);
            this.label1.TabIndex = 47;
            this.label1.Text = "Contact Name:";
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(13, 76);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Properties.MaxLength = 255;
            this.txtContactName.Size = new System.Drawing.Size(172, 21);
            this.txtContactName.TabIndex = 6;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(270, 21);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(68, 14);
            this.lblLastName.TabIndex = 45;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(284, 38);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Properties.MaxLength = 255;
            this.txtLastName.Size = new System.Drawing.Size(87, 21);
            this.txtLastName.TabIndex = 5;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(177, 21);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(80, 14);
            this.lblMiddleName.TabIndex = 44;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(191, 38);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Properties.MaxLength = 255;
            this.txtMiddleName.Size = new System.Drawing.Size(87, 21);
            this.txtMiddleName.TabIndex = 4;
            this.txtMiddleName.EditValueChanged += new System.EventHandler(this.txtMiddleName_EditValueChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(84, 21);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(68, 14);
            this.lblFirstName.TabIndex = 41;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblMr
            // 
            this.lblMr.AutoSize = true;
            this.lblMr.Location = new System.Drawing.Point(1, 21);
            this.lblMr.Name = "lblMr";
            this.lblMr.Size = new System.Drawing.Size(47, 14);
            this.lblMr.TabIndex = 38;
            this.lblMr.Text = "Mr/Mrs:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(98, 38);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Properties.MaxLength = 255;
            this.txtFirstName.Size = new System.Drawing.Size(87, 21);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(5, 173);
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
            this.lblDepartment.Location = new System.Drawing.Point(5, 148);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(77, 14);
            this.lblDepartment.TabIndex = 4;
            this.lblDepartment.Text = "Department:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(87, 147);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Properties.MaxLength = 255;
            this.txtDepartment.Size = new System.Drawing.Size(273, 21);
            this.txtDepartment.TabIndex = 9;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(187, 291);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(54, 14);
            this.lblCountry.TabIndex = 18;
            this.lblCountry.Text = "Country:";
            this.lblCountry.Click += new System.EventHandler(this.lblCountry_Click);
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(264, 287);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Properties.MaxLength = 255;
            this.txtCountry.Size = new System.Drawing.Size(96, 21);
            this.txtCountry.TabIndex = 16;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(5, 292);
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
            this.lblProvince.Location = new System.Drawing.Point(185, 264);
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
            this.lblCity.Location = new System.Drawing.Point(5, 265);
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
            this.lblAddress2.Location = new System.Drawing.Point(5, 238);
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
            this.lblAddress1.Location = new System.Drawing.Point(5, 211);
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
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(0, 105);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(103, 14);
            this.lblCompanyName.TabIndex = 2;
            this.lblCompanyName.Text = "*Company Name:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(12, 121);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Properties.MaxLength = 255;
            this.txtCompanyName.Size = new System.Drawing.Size(348, 21);
            this.txtCompanyName.TabIndex = 8;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 452);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(84, 14);
            this.label27.TabIndex = 45;
            this.label27.Text = "Created Date:";
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
            this.groupControl1.Location = new System.Drawing.Point(15, 463);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(382, 142);
            this.groupControl1.TabIndex = 26;
            this.groupControl1.Text = "Payment";
            // 
            // txtActNo
            // 
            this.txtActNo.Location = new System.Drawing.Point(82, 52);
            this.txtActNo.Name = "txtActNo";
            this.txtActNo.Size = new System.Drawing.Size(102, 21);
            this.txtActNo.TabIndex = 23;
            // 
            // luePayment
            // 
            this.luePayment.Location = new System.Drawing.Point(83, 25);
            this.luePayment.Name = "luePayment";
            this.luePayment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.luePayment.Properties.NullText = "";
            this.luePayment.Properties.ShowFooter = false;
            this.luePayment.Properties.ShowHeader = false;
            this.luePayment.Size = new System.Drawing.Size(102, 21);
            this.luePayment.TabIndex = 21;
            this.luePayment.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.luePayment_ButtonClick);
            // 
            // lueAccountNo
            // 
            this.lueAccountNo.EditValue = "";
            this.lueAccountNo.Location = new System.Drawing.Point(82, 52);
            this.lueAccountNo.Name = "lueAccountNo";
            this.lueAccountNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.lueAccountNo.Size = new System.Drawing.Size(103, 21);
            this.lueAccountNo.TabIndex = 23;
            this.lueAccountNo.Visible = false;
            this.lueAccountNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lueAccountNo_ButtonClick);
            // 
            // lueTax
            // 
            this.lueTax.Location = new System.Drawing.Point(271, 25);
            this.lueTax.Name = "lueTax";
            this.lueTax.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.lueTax.Properties.NullText = "";
            this.lueTax.Properties.ShowFooter = false;
            this.lueTax.Properties.ShowHeader = false;
            this.lueTax.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lueTax_Properties_ButtonClick);
            this.lueTax.Size = new System.Drawing.Size(90, 21);
            this.lueTax.TabIndex = 22;
            this.lueTax.EditValueChanged += new System.EventHandler(this.lueTax_EditValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(193, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 14);
            this.label12.TabIndex = 53;
            this.label12.Text = "Tax agent:";
            // 
            // txtTaxAgent
            // 
            this.txtTaxAgent.Location = new System.Drawing.Point(271, 104);
            this.txtTaxAgent.Name = "txtTaxAgent";
            this.txtTaxAgent.Properties.MaxLength = 36;
            this.txtTaxAgent.Size = new System.Drawing.Size(89, 21);
            this.txtTaxAgent.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 14);
            this.label11.TabIndex = 51;
            this.label11.Text = "Discount:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(82, 108);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Properties.DisplayFormat.FormatString = "n2";
            this.txtDiscount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDiscount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDiscount.Properties.Mask.EditMask = "n2";
            this.txtDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDiscount.Size = new System.Drawing.Size(103, 21);
            this.txtDiscount.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(193, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 14);
            this.label10.TabIndex = 49;
            this.label10.Text = "Balance:";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(271, 78);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Properties.DisplayFormat.FormatString = "n2";
            this.txtBalance.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtBalance.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtBalance.Properties.Mask.EditMask = "n2";
            this.txtBalance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBalance.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtBalance.Size = new System.Drawing.Size(89, 21);
            this.txtBalance.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 14);
            this.label9.TabIndex = 47;
            this.label9.Text = "Currency:";
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(271, 51);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Properties.MaxLength = 3;
            this.txtCurrency.Size = new System.Drawing.Size(89, 21);
            this.txtCurrency.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 14);
            this.label8.TabIndex = 45;
            this.label8.Text = "Credit Limit:";
            // 
            // txtCreditLimit
            // 
            this.txtCreditLimit.Location = new System.Drawing.Point(83, 81);
            this.txtCreditLimit.Name = "txtCreditLimit";
            this.txtCreditLimit.Properties.DisplayFormat.FormatString = "n2";
            this.txtCreditLimit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCreditLimit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCreditLimit.Properties.Mask.EditMask = "n2";
            this.txtCreditLimit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCreditLimit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCreditLimit.Size = new System.Drawing.Size(102, 21);
            this.txtCreditLimit.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 14);
            this.label7.TabIndex = 43;
            this.label7.Text = "Account No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tax:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "Payment:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label19);
            this.groupControl2.Controls.Add(this.label18);
            this.groupControl2.Controls.Add(this.txtPhone);
            this.groupControl2.Controls.Add(this.txtEmail);
            this.groupControl2.Controls.Add(this.label14);
            this.groupControl2.Controls.Add(this.txtBillCountry);
            this.groupControl2.Controls.Add(this.label15);
            this.groupControl2.Controls.Add(this.txtBillZip);
            this.groupControl2.Controls.Add(this.label16);
            this.groupControl2.Controls.Add(this.txtBillProvince);
            this.groupControl2.Controls.Add(this.label17);
            this.groupControl2.Controls.Add(this.txtBillCity);
            this.groupControl2.Controls.Add(this.label13);
            this.groupControl2.Controls.Add(this.txtBillAddress);
            this.groupControl2.Location = new System.Drawing.Point(403, 274);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(395, 142);
            this.groupControl2.TabIndex = 27;
            this.groupControl2.Text = "Billing";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(202, 108);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 14);
            this.label19.TabIndex = 35;
            this.label19.Text = "Email:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 110);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 14);
            this.label18.TabIndex = 34;
            this.label18.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(92, 106);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.MaxLength = 50;
            this.txtPhone.Size = new System.Drawing.Size(106, 21);
            this.txtPhone.TabIndex = 44;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(279, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.MaxLength = 50;
            this.txtEmail.Size = new System.Drawing.Size(96, 21);
            this.txtEmail.TabIndex = 45;
            this.txtEmail.EditValueChanged += new System.EventHandler(this.txtEmail_EditValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(202, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 14);
            this.label14.TabIndex = 26;
            this.label14.Text = "Country:";
            // 
            // txtBillCountry
            // 
            this.txtBillCountry.Location = new System.Drawing.Point(279, 78);
            this.txtBillCountry.Name = "txtBillCountry";
            this.txtBillCountry.Properties.MaxLength = 50;
            this.txtBillCountry.Size = new System.Drawing.Size(96, 21);
            this.txtBillCountry.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 14);
            this.label15.TabIndex = 25;
            this.label15.Text = "Zip/Postal:";
            // 
            // txtBillZip
            // 
            this.txtBillZip.Location = new System.Drawing.Point(92, 78);
            this.txtBillZip.Name = "txtBillZip";
            this.txtBillZip.Properties.MaxLength = 10;
            this.txtBillZip.Size = new System.Drawing.Size(106, 21);
            this.txtBillZip.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(200, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 14);
            this.label16.TabIndex = 24;
            this.label16.Text = "St/Province:";
            // 
            // txtBillProvince
            // 
            this.txtBillProvince.Location = new System.Drawing.Point(279, 51);
            this.txtBillProvince.Name = "txtBillProvince";
            this.txtBillProvince.Properties.MaxLength = 50;
            this.txtBillProvince.Size = new System.Drawing.Size(96, 21);
            this.txtBillProvince.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 14);
            this.label17.TabIndex = 23;
            this.label17.Text = "City/Town:";
            // 
            // txtBillCity
            // 
            this.txtBillCity.Location = new System.Drawing.Point(92, 51);
            this.txtBillCity.Name = "txtBillCity";
            this.txtBillCity.Properties.MaxLength = 50;
            this.txtBillCity.Size = new System.Drawing.Size(106, 21);
            this.txtBillCity.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 14);
            this.label13.TabIndex = 10;
            this.label13.Text = "Address";
            // 
            // txtBillAddress
            // 
            this.txtBillAddress.Location = new System.Drawing.Point(92, 24);
            this.txtBillAddress.Name = "txtBillAddress";
            this.txtBillAddress.Properties.MaxLength = 255;
            this.txtBillAddress.Size = new System.Drawing.Size(283, 21);
            this.txtBillAddress.TabIndex = 39;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.label28);
            this.groupControl3.Controls.Add(this.txtShipParentId);
            this.groupControl3.Controls.Add(this.label20);
            this.groupControl3.Controls.Add(this.label21);
            this.groupControl3.Controls.Add(this.txtShipPhone);
            this.groupControl3.Controls.Add(this.txtShipEmail);
            this.groupControl3.Controls.Add(this.label22);
            this.groupControl3.Controls.Add(this.txtShipCountry);
            this.groupControl3.Controls.Add(this.label23);
            this.groupControl3.Controls.Add(this.textEdit17);
            this.groupControl3.Controls.Add(this.label24);
            this.groupControl3.Controls.Add(this.textEdit18);
            this.groupControl3.Controls.Add(this.label25);
            this.groupControl3.Controls.Add(this.txtShipCity);
            this.groupControl3.Controls.Add(this.label26);
            this.groupControl3.Controls.Add(this.txtShipAddress);
            this.groupControl3.Location = new System.Drawing.Point(403, 427);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(395, 178);
            this.groupControl3.TabIndex = 28;
            this.groupControl3.Text = "Shipping";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(8, 139);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(54, 14);
            this.label28.TabIndex = 37;
            this.label28.Text = "ParentId";
            this.label28.Visible = false;
            // 
            // txtShipParentId
            // 
            this.txtShipParentId.Location = new System.Drawing.Point(92, 137);
            this.txtShipParentId.Name = "txtShipParentId";
            this.txtShipParentId.Properties.MaxLength = 36;
            this.txtShipParentId.Size = new System.Drawing.Size(106, 21);
            this.txtShipParentId.TabIndex = 51;
            this.txtShipParentId.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(204, 108);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 14);
            this.label20.TabIndex = 35;
            this.label20.Text = "Email:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 108);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 14);
            this.label21.TabIndex = 34;
            this.label21.Text = "Phone";
            // 
            // txtShipPhone
            // 
            this.txtShipPhone.Location = new System.Drawing.Point(92, 106);
            this.txtShipPhone.Name = "txtShipPhone";
            this.txtShipPhone.Properties.MaxLength = 50;
            this.txtShipPhone.Size = new System.Drawing.Size(106, 21);
            this.txtShipPhone.TabIndex = 51;
            // 
            // txtShipEmail
            // 
            this.txtShipEmail.Location = new System.Drawing.Point(279, 105);
            this.txtShipEmail.Name = "txtShipEmail";
            this.txtShipEmail.Properties.MaxLength = 50;
            this.txtShipEmail.Size = new System.Drawing.Size(96, 21);
            this.txtShipEmail.TabIndex = 52;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(204, 82);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 14);
            this.label22.TabIndex = 26;
            this.label22.Text = "Country:";
            // 
            // txtShipCountry
            // 
            this.txtShipCountry.Location = new System.Drawing.Point(279, 78);
            this.txtShipCountry.Name = "txtShipCountry";
            this.txtShipCountry.Properties.MaxLength = 50;
            this.txtShipCountry.Size = new System.Drawing.Size(96, 21);
            this.txtShipCountry.TabIndex = 50;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 81);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 14);
            this.label23.TabIndex = 25;
            this.label23.Text = "Zip/Postal:";
            // 
            // textEdit17
            // 
            this.textEdit17.Location = new System.Drawing.Point(92, 78);
            this.textEdit17.Name = "textEdit17";
            this.textEdit17.Properties.MaxLength = 10;
            this.textEdit17.Size = new System.Drawing.Size(106, 21);
            this.textEdit17.TabIndex = 49;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(202, 54);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 14);
            this.label24.TabIndex = 24;
            this.label24.Text = "St/Province:";
            // 
            // textEdit18
            // 
            this.textEdit18.Location = new System.Drawing.Point(279, 51);
            this.textEdit18.Name = "textEdit18";
            this.textEdit18.Properties.MaxLength = 50;
            this.textEdit18.Size = new System.Drawing.Size(96, 21);
            this.textEdit18.TabIndex = 48;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 53);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(68, 14);
            this.label25.TabIndex = 23;
            this.label25.Text = "City/Town:";
            // 
            // txtShipCity
            // 
            this.txtShipCity.Location = new System.Drawing.Point(92, 51);
            this.txtShipCity.Name = "txtShipCity";
            this.txtShipCity.Properties.MaxLength = 50;
            this.txtShipCity.Size = new System.Drawing.Size(106, 21);
            this.txtShipCity.TabIndex = 47;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(8, 27);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(50, 14);
            this.label26.TabIndex = 10;
            this.label26.Text = "Address";
            // 
            // txtShipAddress
            // 
            this.txtShipAddress.Location = new System.Drawing.Point(92, 24);
            this.txtShipAddress.Name = "txtShipAddress";
            this.txtShipAddress.Properties.MaxLength = 255;
            this.txtShipAddress.Size = new System.Drawing.Size(283, 21);
            this.txtShipAddress.TabIndex = 46;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(10, 10);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(79, 14);
            this.label29.TabIndex = 55;
            this.label29.Text = "Customer ID:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(87, 6);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(236, 21);
            this.txtCustomerID.TabIndex = 1;
            // 
            // AddEditCustomer
            // 
            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(810, 646);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpNameAddress);
            this.Controls.Add(this.grpInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Customer";
            this.Shown += new System.EventHandler(this.AddEditCustomer_Shown);
            this.Load += new System.EventHandler(this.AddEditCustomer_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNameAddress)).EndInit();
            this.grpNameAddress.ResumeLayout(false);
            this.grpNameAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdoViewStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSubscribe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlternateName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDivision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProvince.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillZip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillProvince.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipParentId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit17.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit18.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerID.Properties)).EndInit();
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
            if (txtCustomerID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Customer ID must not be empty");
                txtCustomerID.Focus();
                return;
            }
            if (Toolkit.DbToolKit.IsDataOfSqlExists("SELECT * FROM dbo.VListCustomers WHERE [Contact ID] <> '" + strContactID + "' AND [Customer ID] = '" + txtCustomerID.Text + "'"))
            {
                MessageBox.Show("Duplicate Customer ID is found");
                txtCustomerID.Focus();
                return;
            }

            if (Toolkit.DbToolKit.IsDataOfSqlExists("SELECT * FROM dbo.VListCustomers WHERE [Contact ID] <> '" + strContactID + "' AND [Company Name] = '" + txtCompanyName.Text + "'"))
            {
                MessageBox.Show("Duplicate Customer Name is found");
                txtCompanyName.Focus();
                return;
            }
            if (txtCompanyName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Company name must not be empty");
                txtCompanyName.Focus();
                return;
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
            if (txtCreditLimit.Text.Trim().Length == 0) txtCreditLimit.Text = "0";
            if (txtBalance.Text.Trim().Length == 0) txtBalance.Text = "0";
            if (txtDiscount.Text.Trim().Length == 0) txtDiscount.Text = "0";
         
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
            if (!IsValidEmailAddress(txtEmail3.Text.Trim()))
            {
                MessageBox.Show("Email3 is not valid format!");
                txtEmail3.Select();
                return;
            }
            if (txtEmailName.Text.Trim().Length == 0)
            {
                txtEmailName.Text = txtCompanyName.Text;
            }
            //End Cong

            if (Single.Parse(txtCreditLimit.EditValue.ToString()) < 0)
            {
                MessageBox.Show("Credit Limit cannot not negative");
                txtCreditLimit.Text = "0.00";
                txtCreditLimit.Focus();
                return;
            }

            Single i = Single.Parse(txtDiscount.EditValue.ToString());
            if (i < 0 || i > 100)
            {
                MessageBox.Show("The input range must be between 0 and 100");
                txtDiscount.Text = "0.00";
                txtDiscount.Focus();
                return;
            }



            if (strContactID == "")
                InsertCustomer();
            else
                UpdateCustomer();

            MessageBox.Show("Record is saved");
            DialogResult = DialogResult.OK;
        }

        private void InsertCustomer()
        {
            string strInsertCategory;

            SqlTransaction tx;

            string strContactID = Guid.NewGuid().ToString();

            //string strSQL = "INSERT INTO Contact (ContactID, ContactName, EmailName, Department, Division, Address1, Address2, " +
            //    "City, Province, Zip, Country, Phone1, Phone2, Fax1, Fax2, Cell1, Email1, Email2, " +
            //    "Website, ContactGroupID, MembershipID, SubscribeNews, ViewStatus" +
            //    ")Values('" + strContactID + "', '" + txtCompanyName.Text + "','" + txtEmailName.Text +
            //    "','" + txtDepartment.Text + "','" + txtDivision.Text + "','" + txtAddress1.Text + "','" + txtAddress2.Text + "','" +
            //    txtCity.Text + "','" + txtProvince.Text + "','" + txtZip.Text + "','" + txtCountry.Text + 
            //    "','" + txtMain1.Text + "','" + txtMain2.Text + "','" + txtFax1.Text + "','" + txtFax2.Text + "','" + txtCell.Text + "','" +
            //    txtEmail1.Text + "', '" + txtEmail2.Text + "'," + txtWebsite.Text + "', '2' , '1' , '" + 
            //    chkSubscribe.Checked + "', '" + rdoViewStatus.EditValue + "')";
            string dot = "', '";            
            string strSQL = "INSERT INTO Contact (ContactName, CompanyName, ContactID, Mr, FirstName, MiddleName, LastName, EmailName, " +
                "Department, Division, Address1, Address2, City, Province, Zip, Country, Website, Phone1, Phone2, Fax1, Fax2, Cell1, Cell2, Email1, Email2, Email3," +
                "ContactGroupID, SubscribeNews, ViewStatus, UserID)Values('" +
                txtContactName.Text + dot + txtCompanyName.Text + dot + 
                strContactID + dot + lueMr.Text + dot + txtFirstName.Text + dot + txtMiddleName.Text + dot + txtLastName.Text + dot +
                txtEmailName.Text + dot + txtDepartment.Text + dot + txtDivision.Text + dot + txtAddress1.Text + dot +
                txtAddress2.Text + dot + txtCity.Text + dot + txtProvince.Text + dot + textEdit17.Text + dot + txtCountry.Text + dot + txtWebsite.Text + dot + txtMain1.Text + dot +
                txtMain2.Text + dot + txtFax1.Text + dot + txtFax2.Text + dot + txtCell.Text + dot + txtCell2.Text + dot + txtEmail1.Text + dot +
                txtEmail2.Text + dot + txtEmail3.Text + dot + '2' + dot + chkSubscribe.Checked + dot +
                rdoViewStatus.EditValue + dot + Globals.UserID  + "')";
            strSQL += "; INSERT INTO ContactListForContact(ContactId, ContactPersonId) VALUES('" + strContactID + "', '" + strContactID + "')";
            strSQL += "; INSERT INTO CustomerContact( ContactId, CustomerID, Payment_Term_Id, Tax_Code_id," +
                      "Billing_Address, Billing_City, Billing_Country, Billing_State, Billing_Zip, Billing_Phone, Billing_Email," +
                      "Shipping_Address1, Shipping_City, Shipping_Country, Shipping_State, Shipping_Zip, Shipping_Phone, Shipping_Email," +
                      "Parent_id, Discount, Currency, Credit_Limit, Balance, Tax_Agent, Account_number) VALUES('" +
                      strContactID + dot + txtCustomerID.Text + dot + luePayment.EditValue + dot + lueTax.EditValue + dot +
                      txtBillAddress.Text + dot + txtBillCity.Text + dot + txtBillCountry.Text + dot + txtBillProvince.Text + dot + txtBillZip.Text + dot + txtPhone.Text + dot + txtEmail.Text + dot +
                      txtShipAddress.Text + dot + txtShipCity.Text + dot + txtShipCountry.Text + dot + textEdit18.Text + dot + txtZip.Text + dot + txtShipPhone.Text + dot + txtShipEmail.Text + dot +
                      txtShipParentId.Text + dot + txtDiscount.Text + dot + txtCurrency.Text + dot + txtCreditLimit.Text + dot + txtBalance.Text + dot + txtTaxAgent.Text + "', '" + txtActNo.Text + "')";

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
                    strInsertCategory = "INSERT INTO ContactCategory (ContactCatID, ContactID) Values ('" + datarow["ContactCatID"] + "', '" + strContactID + "')";
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

        private void UpdateCustomer()
        {
            string strSQLDeleteAll;
            string strInsertCategory;

            string strSQL = "UPDATE Contact SET " +
                "CompanyName = '" + txtCompanyName.Text +
                "',  ContactName = '" + txtContactName.Text +
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
                "', Zip = '" + txtZip.Text +
                "', Country = '" + txtCountry.Text +
                "', Phone1 = '" + txtMain1.Text +
                "', Phone2 = '" + txtMain2.Text +
                "', Fax1 = '" + txtFax1.Text +
                "', Fax2 = '" + txtFax2.Text +
                "', Cell1 = '" + txtCell.Text +
                "', Cell2 = '" + txtCell2.Text +
                "', Email1 = '" + txtEmail1.Text +
                "', Email2 = '" + txtEmail2.Text +
                "', Email3 = '" + txtEmail3.Text +
                "', Website = '" + txtWebsite.Text +
                "', SubscribeNews = '" + chkSubscribe.Checked +
                "', UserID = '" + Globals.UserID + 
                "', ViewStatus= '" + rdoViewStatus.EditValue +
                "' WHERE ContactID = '" + strContactID + "'";
            string dot = "' ,";
            strSQL += "; UPDATE CUSTOMERCONTACT SET Payment_Term_id = '" + luePayment.EditValue.ToString() + dot +
                      "CustomerID = '"+txtCustomerID.Text + dot +
                      "Tax_Code_id = '" + lueTax.EditValue.ToString() + dot +
                      "Billing_Address = '" + txtBillAddress.Text + dot +
                      "Billing_City = '" + txtBillCity.Text + dot +
                      "Billing_Country = '" + txtBillCountry.Text + dot +
                      "Billing_State = '" + txtBillProvince.Text + dot +
                      "Billing_Zip = '" + txtBillZip.Text + dot +
                      "Billing_Phone = '" + txtPhone.Text + dot +
                      "Billing_Email = '" + txtEmail.Text + dot +
                      "Shipping_Address1 = '" + txtShipAddress.Text + dot +
                      "Shipping_City = '" + txtShipCity.Text + dot +
                      "Shipping_Country = '" + txtShipCountry.Text + dot +
                      "Shipping_State = '" + textEdit18.Text + dot +
                      "Shipping_Zip = '" + textEdit17.Text + dot +
                      "Shipping_Phone = '" + txtShipPhone.Text + dot +
                      "Shipping_Email = '" + txtShipEmail.Text + dot +
                      "Parent_Id = '" + txtShipParentId.Text + dot +
                      "Discount = '" + txtDiscount.Text + dot +
                      "Account_number = '" + txtActNo.Text + dot +
                      "Currency = '" + txtCurrency.Text + dot +
                      "Credit_Limit = '" + txtCreditLimit.Text + dot +
                      "Balance = '" + txtBalance.Text + dot +
                      "Tax_Agent = '" + txtTaxAgent.Text + 
                      "' WHERE ContactID = '" + strContactID + "'";                                                                  
            SqlTransaction tx;

            if (cnContactMgmt.State == ConnectionState.Closed)
                cnContactMgmt.Open();

            SqlCommand cmdUpdate = cnContactMgmt.CreateCommand();

            tx = cnContactMgmt.BeginTransaction();

            //try
            //{
                this.Cursor = Cursors.WaitCursor;

                cmdUpdate.CommandText = strSQL;
                cmdUpdate.Transaction = tx;
                cmdUpdate.ExecuteNonQuery();

                strSQLDeleteAll = "DELETE FROM ContactCategory WHERE ContactID = '" + strContactID + "'";
                cmdUpdate.CommandText = strSQLDeleteAll;
                cmdUpdate.ExecuteNonQuery();

                foreach (DataRow datarow in dtSelectedCat.Rows)
                {
                    strInsertCategory = "INSERT INTO ContactCategory (ContactCatID, ContactID) Values ('" + datarow["ContactCatID"] + "', '" + strContactID + "')";
                    cmdUpdate.CommandText = strInsertCategory;
                    cmdUpdate.ExecuteNonQuery();
                }

                tx.Commit();
                this.Cursor = Cursors.Default;

            //}
            //catch (Exception exc)
            //{
            //    tx.Rollback();

            //    MessageBox.Show(exc.Message, "Exception");
            //    this.Cursor = Cursors.Default;
            //}
            //finally
            //{
            //    cnContactMgmt.Close();
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (needDelete)
                DeleteContact(strContactID);
            DialogResult = DialogResult.Cancel;
        }

        private void AddEditCustomer_Load(object sender, EventArgs e)
        {
            cnContactMgmt = new SqlConnection(Globals.strVISConnection);
            txtWebsite.Text = "http://";

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
                }
                /*
                if (LoginUser.strLoginGroup == "Administrator")
                    rdoViewStatus.Enabled = true;
                else
                    rdoViewStatus.Enabled = false;
                 */
                txtCustomerID.Select();
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

            daCompany = new SqlDataAdapter("SELECT * FROM VContactCategory" + " WHERE ContactID = '" + strContactID + "'", cnContactMgmt);
            daCompany.Fill(dsCompany, "ContactCategory");
            dtSelectedCat = dsCompany.Tables["ContactCategory"];

            fillInMrCombo();

            fillInPaymentCombo();

            fillInTaxCombo();
            LoadAccount(strContactID);
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
            SqlDataReader drCompany = null;

            string strSQL = "SELECT * FROM VListCustomers" + " WHERE [Contact ID] = '" + strContactID + "'";

            SqlCommand cmdSelect = new SqlCommand(strSQL, cnContactMgmt);

            try
            {
                if (cnContactMgmt.State == ConnectionState.Closed)
                    cnContactMgmt.Open();

                drCompany = cmdSelect.ExecuteReader();

                while (drCompany.Read())
                {
                    txtCustomerID.Text = drCompany["Customer ID"].ToString();
                    txtCompanyName.Text = drCompany["Company Name"].ToString();
                    txtDepartment.Text = drCompany["Department"].ToString();
                    txtDivision.Text = drCompany["Division"].ToString();
                    txtAddress1.Text = drCompany["Address 1"].ToString();
                    txtAddress2.Text = drCompany["Address 2"].ToString();
                    txtCity.Text = drCompany["City"].ToString();
                    txtProvince.Text = drCompany["Province"].ToString();
                    txtZip.Text = drCompany["Zip"].ToString();
                    txtCountry.Text = drCompany["Country"].ToString();
                    txtMain1.Text = drCompany["Phone 1"].ToString();
                    txtMain2.Text = drCompany["Phone 2"].ToString();
                    txtFax1.Text = drCompany["Fax 1"].ToString();
                    txtFax2.Text = drCompany["Fax 2"].ToString();
                    txtCell.Text = drCompany["Cell 1"].ToString();
                    txtCell2.Text = drCompany["Cell 2"].ToString();
                    txtEmail1.Text = drCompany["Email 1"].ToString();
                    txtEmail2.Text = drCompany["Email 2"].ToString();
                    txtEmail3.Text = drCompany["Email 3"].ToString();
                    txtEmailName.Text = drCompany["Email Name"].ToString();
                    txtWebsite.Text = drCompany["Website"].ToString();
                    chkSubscribe.Checked = (bool)drCompany["SubscribeNews"];
                    rdoViewStatus.EditValue = (bool)drCompany["ViewStatus"];
                    txtFirstName.Text = drCompany["First Name"].ToString();
                    txtMiddleName.Text = drCompany["Middle Name"].ToString();
                    txtLastName.Text = drCompany["Last Name"].ToString();
                    txtContactName.Text = drCompany["Contact Name"].ToString();
                    txtAlternateName.Text = drCompany["Alt Contact"].ToString();
                    txtCurrency.Text = drCompany["Currency"].ToString();
                    txtBalance.Text = drCompany["Balance"].ToString();
                    txtDiscount.Text = drCompany["Discount"].ToString();
                    txtTaxAgent.Text = drCompany["Tax Agent"].ToString();
                    txtBillAddress.Text = drCompany["Billing Address"].ToString();
                    txtBillCity.Text = drCompany["Billing City"].ToString();
                    txtBillCountry.Text = drCompany["Billing Country"].ToString();
                    txtBillProvince.Text = drCompany["Billing State"].ToString();
                    txtBillZip.Text = drCompany["Billing Zip"].ToString();
                    txtPhone.Text = drCompany["Billing Phone"].ToString();
                    txtEmail.Text = drCompany["Billing Email"].ToString();
                    txtShipAddress.Text = drCompany["Shipping Address"].ToString();
                    txtShipCity.Text = drCompany["Shipping City"].ToString();
                    txtShipCountry.Text = drCompany["Shipping Country"].ToString();
                    txtShipEmail.Text = drCompany["Shipping Email"].ToString();
                    txtShipParentId.Text = drCompany["Parent Customer Id"].ToString();
                    txtCreditLimit.Text = drCompany["Credit Limit"].ToString();
                    txtShipPhone.Text = drCompany["Shipping Phone"].ToString();
                    textEdit17.Text = drCompany["Shipping Zip"].ToString();
                    textEdit18.Text = drCompany["Shipping State"].ToString();
                    lueMr.Tag = drCompany["Mr"].ToString();
                    luePayment.Tag = drCompany["Payment term id"].ToString();
                    lueTax.Tag = drCompany["Tax code id"].ToString();
                    txtActNo.Text = drCompany["Account Number"].ToString();
                    //lueAccountNo.Tag = drCompany["Account Number"].ToString();
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }
            finally
            {
                if (drCompany != null)
                    drCompany.Close();

                if (cnContactMgmt.State == ConnectionState.Closed)
                    cnContactMgmt.Close();
            }

        }

        private void bteCategory_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SelectContactCat frmSelectContactCat = new SelectContactCat(dsCompany.Tables["ContactCategory"], strContactID);
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
        #region
        private void AddEditCustomer_Shown(object sender, EventArgs e)
        {

        }

        private void txtWebsite_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void txtWebsite_Enter(object sender, EventArgs e)
        {

        }

        private void cboMr_Properties_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void lblEmailAddr_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail1_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtEmailName_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lblCountry_Click(object sender, EventArgs e)
        {

        }

        private void txtMiddleName_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEmail_EditValueChanged(object sender, EventArgs e)
        {

        }
        #endregion
        private void lueMr_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                //if (Globals.CheckAccessRights(Globals.UserID,"D475ABD5-A9A7-43BE-BA80-A7BFAE6FAACB",true))
                {

                    AddEditMr frmAddEditMr = new AddEditMr(lueMr.Text);
                    frmAddEditMr.ShowDialog();
                    fillInMrCombo();
                }
            }
        }
        private void fillInMrCombo()
        {
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
        private void lueTax_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void fillInTaxCombo()
        {
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
                    fillInTaxCombo();
                }
            }
        }



        private void txtMain1_EditValueChanged(object sender, EventArgs e)
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
                if ((!isSaved)&&(strContactID == ""))//new and click first time
                {
                    if (txtCreditLimit.Text.Trim().Length == 0) txtCreditLimit.Text = "0";
                    if (txtBalance.Text.Trim().Length == 0) txtBalance.Text = "0";
                    if (txtDiscount.Text.Trim().Length == 0) txtDiscount.Text = "0";
                    InsertCustomer();
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

        private void luePayment_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                //if (Globals.CheckAccessRights(Globals.UserID,"89D4594C-CDA9-49D9-BDD1-308335559A92",true))
                {

                    AddEditPayment frm;
                    if (luePayment.EditValue!=null)
                        frm = new AddEditPayment(luePayment.EditValue.ToString());
                    else frm = new AddEditPayment("");
                    frm.ShowDialog();
                    fillInPaymentCombo();

                }
            }
        }
        private void fillInPaymentCombo()
        {
            luePayment.Properties.Columns.Clear();
            luePayment.DataBindings.Clear();
            DataTable dtPayment = new DataTable();

            string strSQL = "SELECT ID, PaymentTermsName FROM PaymentTermMaster WHERE ViewStatus = 'true'";

            cnContactMgmt.Close();
            cnContactMgmt.Open();

            SqlDataAdapter daPayment = new SqlDataAdapter(strSQL, cnContactMgmt);
            daPayment.Fill(dtPayment);
            ControlSetting.FillLookupEdit(luePayment, dtPayment, "PaymentTermsName", "ID");
        }

    }


}

