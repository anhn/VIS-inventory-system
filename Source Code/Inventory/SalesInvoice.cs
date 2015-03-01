using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Inventory
{
    /// <summary>
    /// Summary description for SalesInvoice.
    /// </summary>
    public class SalesInvoice : DevExpress.XtraEditors.XtraForm
    {
        private GroupControl grpSO;
        private TextEdit txtDiscount;
        private Label lblSODiscount;
        private TextEdit txtPaymentAmount;
        private Label lblSOPaymentAmount;
        private Label lblSOPaymentType;
        private CheckEdit chkViewStatus;
        private ComboBoxEdit cbSOType;
        private Label lblSOCustomerPhone;
        private TextEdit txtSONo;
        private TextEdit txtCustomerPhone;
        private Label lblSOType;
        private Label lblSOShopName;
        private Label lblSOCustomerAdd2;
        private TextEdit txtAddress2;
        private Label lblSONo;
        private TextEdit txtAltCustomerID;
        private Label lblSOCustomerAdd1;
        private TextEdit txtAddress1;
        private Label lblSoCustomerName;
        private DateEdit dateEdit1;
        private TextEdit textEdit1;
        private Label label1;
        private DevExpress.XtraGrid.GridControl grdSalesDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtNumber;
        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private ButtonEdit bteCustName;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public SalesInvoice()
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
            this.grpSO = new DevExpress.XtraEditors.GroupControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.txtDiscount = new DevExpress.XtraEditors.TextEdit();
            this.lblSODiscount = new System.Windows.Forms.Label();
            this.txtPaymentAmount = new DevExpress.XtraEditors.TextEdit();
            this.lblSOPaymentAmount = new System.Windows.Forms.Label();
            this.lblSOPaymentType = new System.Windows.Forms.Label();
            this.chkViewStatus = new DevExpress.XtraEditors.CheckEdit();
            this.cbSOType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblSOCustomerPhone = new System.Windows.Forms.Label();
            this.txtSONo = new DevExpress.XtraEditors.TextEdit();
            this.txtCustomerPhone = new DevExpress.XtraEditors.TextEdit();
            this.lblSOType = new System.Windows.Forms.Label();
            this.lblSOShopName = new System.Windows.Forms.Label();
            this.lblSOCustomerAdd2 = new System.Windows.Forms.Label();
            this.txtAddress2 = new DevExpress.XtraEditors.TextEdit();
            this.lblSONo = new System.Windows.Forms.Label();
            this.txtAltCustomerID = new DevExpress.XtraEditors.TextEdit();
            this.lblSOCustomerAdd1 = new System.Windows.Forms.Label();
            this.txtAddress1 = new DevExpress.XtraEditors.TextEdit();
            this.lblSoCustomerName = new System.Windows.Forms.Label();
            this.grdSalesDetail = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtNumber = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.bteCustName = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSO)).BeginInit();
            this.grpSO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSOType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSONo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteCustName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSO
            // 
            this.grpSO.Controls.Add(this.bteCustName);
            this.grpSO.Controls.Add(this.textEdit1);
            this.grpSO.Controls.Add(this.label1);
            this.grpSO.Controls.Add(this.dateEdit1);
            this.grpSO.Controls.Add(this.txtDiscount);
            this.grpSO.Controls.Add(this.lblSODiscount);
            this.grpSO.Controls.Add(this.txtPaymentAmount);
            this.grpSO.Controls.Add(this.lblSOPaymentAmount);
            this.grpSO.Controls.Add(this.lblSOPaymentType);
            this.grpSO.Controls.Add(this.chkViewStatus);
            this.grpSO.Controls.Add(this.cbSOType);
            this.grpSO.Controls.Add(this.lblSOCustomerPhone);
            this.grpSO.Controls.Add(this.txtSONo);
            this.grpSO.Controls.Add(this.txtCustomerPhone);
            this.grpSO.Controls.Add(this.lblSOType);
            this.grpSO.Controls.Add(this.lblSOShopName);
            this.grpSO.Controls.Add(this.lblSOCustomerAdd2);
            this.grpSO.Controls.Add(this.txtAddress2);
            this.grpSO.Controls.Add(this.lblSONo);
            this.grpSO.Controls.Add(this.txtAltCustomerID);
            this.grpSO.Controls.Add(this.lblSOCustomerAdd1);
            this.grpSO.Controls.Add(this.txtAddress1);
            this.grpSO.Controls.Add(this.lblSoCustomerName);
            this.grpSO.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strGroupSaleOrder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.grpSO.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSO.Location = new System.Drawing.Point(0, 0);
            this.grpSO.Name = "grpSO";
            this.grpSO.Size = new System.Drawing.Size(636, 266);
            this.grpSO.TabIndex = 10;
            this.grpSO.Text = global::Inventory.Properties.Settings.Default.strGroupSaleOrder;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(148, 223);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Mask.EditMask = "n2";
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit1.Size = new System.Drawing.Size(125, 21);
            this.textEdit1.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strSaleOrderDiscount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Location = new System.Drawing.Point(22, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 14);
            this.label1.TabIndex = 91;
            this.label1.Text = global::Inventory.Properties.Settings.Default.strSaleOrderDiscount;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = new System.DateTime(2007, 7, 24, 0, 0, 0, 0);
            this.dateEdit1.Location = new System.Drawing.Point(483, 28);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(125, 21);
            this.dateEdit1.TabIndex = 89;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(148, 196);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Properties.Mask.EditMask = "n2";
            this.txtDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscount.Size = new System.Drawing.Size(125, 21);
            this.txtDiscount.TabIndex = 13;
            // 
            // lblSODiscount
            // 
            this.lblSODiscount.AutoSize = true;
            this.lblSODiscount.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strSaleOrderDiscount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSODiscount.Location = new System.Drawing.Point(22, 196);
            this.lblSODiscount.Name = "lblSODiscount";
            this.lblSODiscount.Size = new System.Drawing.Size(87, 14);
            this.lblSODiscount.TabIndex = 84;
            this.lblSODiscount.Text = global::Inventory.Properties.Settings.Default.strSaleOrderDiscount;
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(483, 55);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Properties.Mask.EditMask = "n2";
            this.txtPaymentAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPaymentAmount.Size = new System.Drawing.Size(125, 21);
            this.txtPaymentAmount.TabIndex = 12;
            // 
            // lblSOPaymentAmount
            // 
            this.lblSOPaymentAmount.AutoSize = true;
            this.lblSOPaymentAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strSaleOrderPayAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSOPaymentAmount.Location = new System.Drawing.Point(364, 58);
            this.lblSOPaymentAmount.Name = "lblSOPaymentAmount";
            this.lblSOPaymentAmount.Size = new System.Drawing.Size(89, 14);
            this.lblSOPaymentAmount.TabIndex = 82;
            this.lblSOPaymentAmount.Text = global::Inventory.Properties.Settings.Default.strSaleOrderPayAmount;
            // 
            // lblSOPaymentType
            // 
            this.lblSOPaymentType.AutoSize = true;
            this.lblSOPaymentType.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strSaleOrderPayType", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSOPaymentType.Location = new System.Drawing.Point(364, 31);
            this.lblSOPaymentType.Name = "lblSOPaymentType";
            this.lblSOPaymentType.Size = new System.Drawing.Size(80, 14);
            this.lblSOPaymentType.TabIndex = 80;
            this.lblSOPaymentType.Text = global::Inventory.Properties.Settings.Default.strSaleOrderPayType;
            // 
            // chkViewStatus
            // 
            this.chkViewStatus.Location = new System.Drawing.Point(25, 240);
            this.chkViewStatus.Name = "chkViewStatus";
            this.chkViewStatus.Properties.Caption = "View Status";
            this.chkViewStatus.Size = new System.Drawing.Size(108, 19);
            this.chkViewStatus.TabIndex = 16;
            // 
            // cbSOType
            // 
            this.cbSOType.Location = new System.Drawing.Point(148, 55);
            this.cbSOType.Name = "cbSOType";
            this.cbSOType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSOType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSOType.Size = new System.Drawing.Size(125, 21);
            this.cbSOType.TabIndex = 3;
            // 
            // lblSOCustomerPhone
            // 
            this.lblSOCustomerPhone.AutoSize = true;
            this.lblSOCustomerPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strSaleOrderCustomerPhone", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSOCustomerPhone.Location = new System.Drawing.Point(22, 169);
            this.lblSOCustomerPhone.Name = "lblSOCustomerPhone";
            this.lblSOCustomerPhone.Size = new System.Drawing.Size(42, 14);
            this.lblSOCustomerPhone.TabIndex = 47;
            this.lblSOCustomerPhone.Text = global::Inventory.Properties.Settings.Default.strSaleOrderCustomerPhone;
            // 
            // txtSONo
            // 
            this.txtSONo.Location = new System.Drawing.Point(148, 28);
            this.txtSONo.Name = "txtSONo";
            this.txtSONo.Size = new System.Drawing.Size(125, 21);
            this.txtSONo.TabIndex = 1;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(148, 169);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Properties.Mask.EditMask = "([(][0-9]+[)])?[0-9]+";
            this.txtCustomerPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCustomerPhone.Size = new System.Drawing.Size(125, 21);
            this.txtCustomerPhone.TabIndex = 10;
            // 
            // lblSOType
            // 
            this.lblSOType.AutoSize = true;
            this.lblSOType.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strSaleOrderType", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSOType.Location = new System.Drawing.Point(22, 58);
            this.lblSOType.Name = "lblSOType";
            this.lblSOType.Size = new System.Drawing.Size(78, 14);
            this.lblSOType.TabIndex = 78;
            this.lblSOType.Text = global::Inventory.Properties.Settings.Default.strSaleOrderType;
            // 
            // lblSOShopName
            // 
            this.lblSOShopName.AutoSize = true;
            this.lblSOShopName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strSaleOrderShopName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSOShopName.Location = new System.Drawing.Point(22, 87);
            this.lblSOShopName.Name = "lblSOShopName";
            this.lblSOShopName.Size = new System.Drawing.Size(79, 14);
            this.lblSOShopName.TabIndex = 13;
            this.lblSOShopName.Text = global::Inventory.Properties.Settings.Default.strSaleOrderShopName;
            // 
            // lblSOCustomerAdd2
            // 
            this.lblSOCustomerAdd2.AutoSize = true;
            this.lblSOCustomerAdd2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCell2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSOCustomerAdd2.Location = new System.Drawing.Point(364, 172);
            this.lblSOCustomerAdd2.Name = "lblSOCustomerAdd2";
            this.lblSOCustomerAdd2.Size = new System.Drawing.Size(29, 14);
            this.lblSOCustomerAdd2.TabIndex = 50;
            this.lblSOCustomerAdd2.Text = global::Inventory.Properties.Settings.Default.strCell2;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(483, 169);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(125, 21);
            this.txtAddress2.TabIndex = 8;
            // 
            // lblSONo
            // 
            this.lblSONo.AutoSize = true;
            this.lblSONo.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strSaleOrderNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSONo.Location = new System.Drawing.Point(22, 31);
            this.lblSONo.Name = "lblSONo";
            this.lblSONo.Size = new System.Drawing.Size(73, 14);
            this.lblSONo.TabIndex = 9;
            this.lblSONo.Text = global::Inventory.Properties.Settings.Default.strSaleOrderNo;
            // 
            // txtAltCustomerID
            // 
            this.txtAltCustomerID.Location = new System.Drawing.Point(148, 142);
            this.txtAltCustomerID.Name = "txtAltCustomerID";
            this.txtAltCustomerID.Size = new System.Drawing.Size(460, 21);
            this.txtAltCustomerID.TabIndex = 5;
            // 
            // lblSOCustomerAdd1
            // 
            this.lblSOCustomerAdd1.AutoSize = true;
            this.lblSOCustomerAdd1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strSaleOrderCustomerAdd1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSOCustomerAdd1.Location = new System.Drawing.Point(22, 142);
            this.lblSOCustomerAdd1.Name = "lblSOCustomerAdd1";
            this.lblSOCustomerAdd1.Size = new System.Drawing.Size(54, 14);
            this.lblSOCustomerAdd1.TabIndex = 45;
            this.lblSOCustomerAdd1.Text = global::Inventory.Properties.Settings.Default.strSaleOrderCustomerAdd1;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(148, 115);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(200, 21);
            this.txtAddress1.TabIndex = 7;
            // 
            // lblSoCustomerName
            // 
            this.lblSoCustomerName.AutoSize = true;
            this.lblSoCustomerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strSaleOrderCustomerName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSoCustomerName.Location = new System.Drawing.Point(22, 114);
            this.lblSoCustomerName.Name = "lblSoCustomerName";
            this.lblSoCustomerName.Size = new System.Drawing.Size(98, 14);
            this.lblSoCustomerName.TabIndex = 41;
            this.lblSoCustomerName.Text = global::Inventory.Properties.Settings.Default.strSaleOrderCustomerName;
            // 
            // grdSalesDetail
            // 
            this.grdSalesDetail.EmbeddedNavigator.Name = "";
            this.grdSalesDetail.Location = new System.Drawing.Point(0, 272);
            this.grdSalesDetail.MainView = this.gridView1;
            this.grdSalesDetail.Name = "grdSalesDetail";
            this.grdSalesDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtNumber});
            this.grdSalesDetail.Size = new System.Drawing.Size(635, 172);
            this.grdSalesDetail.TabIndex = 20;
            this.grdSalesDetail.UseEmbeddedNavigator = true;
            this.grdSalesDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdSalesDetail;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // txtNumber
            // 
            this.txtNumber.AutoHeight = false;
            this.txtNumber.Mask.EditMask = "n2";
            this.txtNumber.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNumber.Mask.UseMaskAsDisplayFormat = true;
            this.txtNumber.Name = "txtNumber";
            // 
            // btnCancel
            // 
            this.btnCancel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCancel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(115, 450);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = global::Inventory.Properties.Settings.Default.strCancel;
            // 
            // btnOK
            // 
            this.btnOK.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strOK", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(0, 450);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(109, 23);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = global::Inventory.Properties.Settings.Default.strOK;
            // 
            // bteCustName
            // 
            this.bteCustName.Location = new System.Drawing.Point(148, 84);
            this.bteCustName.Name = "bteCustName";
            this.bteCustName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteCustName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.bteCustName.Size = new System.Drawing.Size(125, 21);
            this.bteCustName.TabIndex = 92;
            // 
            // SalesInvoice
            // 
            this.ClientSize = new System.Drawing.Size(636, 478);
            this.Controls.Add(this.grdSalesDetail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpSO);
            this.Name = "SalesInvoice";
            this.Text = "Sales Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.grpSO)).EndInit();
            this.grpSO.ResumeLayout(false);
            this.grpSO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSOType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSONo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteCustName.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}

