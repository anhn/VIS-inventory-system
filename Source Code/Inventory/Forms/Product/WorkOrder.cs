using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Inventory.DataModels.Product;
using Inventory.DataModels;

namespace Inventory.Forms.Product
{
    /// <summary>
    /// Summary description for WorkOrder.
    /// </summary>
    public class WorkOrder : DevExpress.XtraEditors.XtraForm
    {
        private GroupControl groupControl1;
        private TextEdit txtNumber;
        private Label lblNumber;
        private Label lblOrderedBy;
        private Label lblReference;
        private Label lblStatus;
        private Label lblDueOn;
        private Label lblIssued;
        private GroupControl groupControl2;
        private Label lblState;
        private Label lblSuburb;
        private Label lblAddress;
        private Label lblName;
        private Label lblPhone;
        private Label lblFirm;
        private TextEdit txtPhone;
        private MemoEdit txtInstructions;
        private Label lblContact;
        private Label lblPostcost;
        private Label lblInstructions;
        private TextEdit txtContact;
        private TextEdit txtPostcost;
        private TextEdit txtState;
        private TextEdit txtSuburb;
        private TextEdit txtAddress;
        private TextEdit txtName;
        private DateEdit dtmDueOn;
        private DateEdit dtmIssued;
        private TextEdit txtReference;
        private SimpleButton btnClose;
        private SimpleButton btnSave;
        private ComboBoxEdit cboOrderedBy;
        private ComboBoxEdit cboFirm;
        private ComboBoxEdit cboStatus;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public WorkOrder()
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
            this.cboStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboOrderedBy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtmDueOn = new DevExpress.XtraEditors.DateEdit();
            this.dtmIssued = new DevExpress.XtraEditors.DateEdit();
            this.txtReference = new DevExpress.XtraEditors.TextEdit();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtInstructions = new DevExpress.XtraEditors.MemoEdit();
            this.lblDueOn = new System.Windows.Forms.Label();
            this.lblIssued = new System.Windows.Forms.Label();
            this.lblOrderedBy = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cboFirm = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtContact = new DevExpress.XtraEditors.TextEdit();
            this.txtPostcost = new DevExpress.XtraEditors.TextEdit();
            this.txtState = new DevExpress.XtraEditors.TextEdit();
            this.txtSuburb = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblPostcost = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFirm = new System.Windows.Forms.Label();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOrderedBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDueOn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmIssued.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInstructions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboFirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostcost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuburb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cboStatus);
            this.groupControl1.Controls.Add(this.cboOrderedBy);
            this.groupControl1.Controls.Add(this.dtmDueOn);
            this.groupControl1.Controls.Add(this.dtmIssued);
            this.groupControl1.Controls.Add(this.txtReference);
            this.groupControl1.Controls.Add(this.lblInstructions);
            this.groupControl1.Controls.Add(this.txtInstructions);
            this.groupControl1.Controls.Add(this.lblDueOn);
            this.groupControl1.Controls.Add(this.lblIssued);
            this.groupControl1.Controls.Add(this.lblOrderedBy);
            this.groupControl1.Controls.Add(this.lblReference);
            this.groupControl1.Controls.Add(this.lblStatus);
            this.groupControl1.Controls.Add(this.lblNumber);
            this.groupControl1.Controls.Add(this.txtNumber);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(308, 378);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Information";
            // 
            // cboStatus
            // 
            this.cboStatus.Location = new System.Drawing.Point(111, 74);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboStatus.Size = new System.Drawing.Size(124, 23);
            this.cboStatus.TabIndex = 2;
            // 
            // cboOrderedBy
            // 
            this.cboOrderedBy.Location = new System.Drawing.Point(111, 143);
            this.cboOrderedBy.Name = "cboOrderedBy";
            this.cboOrderedBy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboOrderedBy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboOrderedBy.Size = new System.Drawing.Size(124, 23);
            this.cboOrderedBy.TabIndex = 4;
            // 
            // dtmDueOn
            // 
            this.dtmDueOn.EditValue = new System.DateTime(2007, 6, 12, 0, 0, 0, 0);
            this.dtmDueOn.Location = new System.Drawing.Point(111, 212);
            this.dtmDueOn.Name = "dtmDueOn";
            this.dtmDueOn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmDueOn.Size = new System.Drawing.Size(124, 23);
            this.dtmDueOn.TabIndex = 6;
            // 
            // dtmIssued
            // 
            this.dtmIssued.EditValue = new System.DateTime(2007, 6, 12, 0, 0, 0, 0);
            this.dtmIssued.Location = new System.Drawing.Point(111, 177);
            this.dtmIssued.Name = "dtmIssued";
            this.dtmIssued.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmIssued.Size = new System.Drawing.Size(124, 23);
            this.dtmIssued.TabIndex = 5;
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(111, 110);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(124, 23);
            this.txtReference.TabIndex = 3;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(22, 255);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(71, 14);
            this.lblInstructions.TabIndex = 7;
            this.lblInstructions.Text = "Instructions";
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(25, 286);
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(265, 85);
            this.txtInstructions.TabIndex = 7;
            // 
            // lblDueOn
            // 
            this.lblDueOn.AutoSize = true;
            this.lblDueOn.Location = new System.Drawing.Point(22, 215);
            this.lblDueOn.Name = "lblDueOn";
            this.lblDueOn.Size = new System.Drawing.Size(47, 14);
            this.lblDueOn.TabIndex = 5;
            this.lblDueOn.Text = "Due on";
            // 
            // lblIssued
            // 
            this.lblIssued.AutoSize = true;
            this.lblIssued.Location = new System.Drawing.Point(22, 180);
            this.lblIssued.Name = "lblIssued";
            this.lblIssued.Size = new System.Drawing.Size(42, 14);
            this.lblIssued.TabIndex = 2;
            this.lblIssued.Text = "Issued";
            // 
            // lblOrderedBy
            // 
            this.lblOrderedBy.AutoSize = true;
            this.lblOrderedBy.Location = new System.Drawing.Point(22, 145);
            this.lblOrderedBy.Name = "lblOrderedBy";
            this.lblOrderedBy.Size = new System.Drawing.Size(69, 14);
            this.lblOrderedBy.TabIndex = 4;
            this.lblOrderedBy.Text = "Ordered By";
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Location = new System.Drawing.Point(22, 113);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(63, 14);
            this.lblReference.TabIndex = 3;
            this.lblReference.Text = "Reference";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(22, 77);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 14);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(22, 37);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(50, 14);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Number";
            // 
            // txtNumber
            // 
            this.txtNumber.Enabled = false;
            this.txtNumber.Location = new System.Drawing.Point(111, 31);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(124, 23);
            this.txtNumber.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cboFirm);
            this.groupControl2.Controls.Add(this.txtContact);
            this.groupControl2.Controls.Add(this.txtPostcost);
            this.groupControl2.Controls.Add(this.txtState);
            this.groupControl2.Controls.Add(this.txtSuburb);
            this.groupControl2.Controls.Add(this.txtAddress);
            this.groupControl2.Controls.Add(this.txtName);
            this.groupControl2.Controls.Add(this.lblContact);
            this.groupControl2.Controls.Add(this.lblPostcost);
            this.groupControl2.Controls.Add(this.lblState);
            this.groupControl2.Controls.Add(this.lblSuburb);
            this.groupControl2.Controls.Add(this.lblAddress);
            this.groupControl2.Controls.Add(this.lblName);
            this.groupControl2.Controls.Add(this.lblPhone);
            this.groupControl2.Controls.Add(this.lblFirm);
            this.groupControl2.Controls.Add(this.txtPhone);
            this.groupControl2.Location = new System.Drawing.Point(326, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(271, 378);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Issue to";
            // 
            // cboFirm
            // 
            this.cboFirm.Location = new System.Drawing.Point(105, 34);
            this.cboFirm.Name = "cboFirm";
            this.cboFirm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFirm.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboFirm.Size = new System.Drawing.Size(148, 23);
            this.cboFirm.TabIndex = 8;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(105, 292);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(148, 23);
            this.txtContact.TabIndex = 15;
            // 
            // txtPostcost
            // 
            this.txtPostcost.Location = new System.Drawing.Point(105, 252);
            this.txtPostcost.Name = "txtPostcost";
            this.txtPostcost.Size = new System.Drawing.Size(148, 23);
            this.txtPostcost.TabIndex = 14;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(105, 215);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(148, 23);
            this.txtState.TabIndex = 13;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(105, 180);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(148, 23);
            this.txtSuburb.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(105, 145);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(148, 23);
            this.txtAddress.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 23);
            this.txtName.TabIndex = 10;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(30, 295);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(50, 14);
            this.lblContact.TabIndex = 7;
            this.lblContact.Text = "Contact";
            // 
            // lblPostcost
            // 
            this.lblPostcost.AutoSize = true;
            this.lblPostcost.Location = new System.Drawing.Point(29, 255);
            this.lblPostcost.Name = "lblPostcost";
            this.lblPostcost.Size = new System.Drawing.Size(54, 14);
            this.lblPostcost.TabIndex = 6;
            this.lblPostcost.Text = "Postcost";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(29, 215);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(37, 14);
            this.lblState.TabIndex = 5;
            this.lblState.Text = "State";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(29, 180);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(46, 14);
            this.lblSuburb.TabIndex = 2;
            this.lblSuburb.Text = "Suburb";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(29, 145);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(50, 14);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 113);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 14);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(29, 77);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(42, 14);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone";
            // 
            // lblFirm
            // 
            this.lblFirm.AutoSize = true;
            this.lblFirm.Location = new System.Drawing.Point(29, 37);
            this.lblFirm.Name = "lblFirm";
            this.lblFirm.Size = new System.Drawing.Size(29, 14);
            this.lblFirm.TabIndex = 1;
            this.lblFirm.Text = "Firm";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(105, 70);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(148, 23);
            this.txtPhone.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(322, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Clos&e";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(211, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // WorkOrder
            // 
            this.AcceptButton = this.btnSave;
            this.ClientSize = new System.Drawing.Size(609, 436);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorkOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Work Order";
            this.Load += new System.EventHandler(this.WorkOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOrderedBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDueOn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmIssued.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInstructions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboFirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostcost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuburb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        //Stock Transfer Model
        private WorkOrderModel model = new WorkOrderModel();

        /// <summary>
        /// Get/set data model StockTransfer 
        /// </summary>
        public WorkOrderModel DataModel
        {
            get { return model; }
            set { model = value; }
        }

        /// <summary>
        /// Binding data to dialog
        /// </summary>
        /// <param name="objModel">WorkOrderModel</param>
        public void BindData(WorkOrderModel objModel)
        {

            //In case of adding new packing list, initialize the grid with nodata
            if (objModel == null)
            {
                model = new WorkOrderModel();
                model.Number = Convert.ToDouble(model.NewNumber());
            }
            else
            {
                model = objModel;
            }

            txtNumber.Text = model.Number.ToString();

            cboStatus.Properties.Items.Clear();
            DataTable dtStatus = Mediator.GetInstance().GetAllWorkOrderStatus();
            dtStatus.DefaultView.Sort = "Description";
            cboStatus.Properties.Items.Add(new TabItem("", "")); // None Status
            foreach (DataRow row in dtStatus.Rows)
            {
                cboStatus.Properties.Items.Add(new TabItem(row["ID"].ToString(), row["Description"].ToString()));
            }

            cboStatus.SelectedItem = TabItem.GetItemById(cboStatus.Properties.Items, model.StatusID);
            
            txtReference.Text = model.Reference;

            cboOrderedBy.Properties.Items.Clear();
            DataTable dtOrderedBy = Mediator.GetInstance().GetAllCustomerName();
            dtOrderedBy.DefaultView.Sort = "ContactName";
            cboOrderedBy.Properties.Items.Add(new TabItem("", "")); // None OrderedBy
            foreach (DataRow row in dtOrderedBy.Rows)
            {
                cboOrderedBy.Properties.Items.Add(new TabItem(row["CustomerId"].ToString(), row["ContactName"].ToString()));
            }

            cboOrderedBy.SelectedItem = TabItem.GetItemById(cboOrderedBy.Properties.Items, model.OrderedByID);

            dtmIssued.DateTime = model.IssuedDate;
            dtmDueOn.DateTime = model.DueOn;
            txtInstructions.Text = model.Instructions;

            cboFirm.Properties.Items.Clear();
            DataTable dtFirm = Mediator.GetInstance().GetAllSupplier();
            dtFirm.DefaultView.Sort = "AccountName";
            cboFirm.Properties.Items.Add(new TabItem("", "")); // None Firm
            foreach (DataRow row in dtFirm.Rows)
            {
                cboFirm.Properties.Items.Add(new TabItem(row["SupplierID"].ToString(), row["AccountName"].ToString()));
            }

            cboFirm.SelectedItem = TabItem.GetItemById(cboFirm.Properties.Items, model.SupplierID);
            
            txtPhone.Text = model.Phone;
            txtName.Text = model.Name;
            txtAddress.Text = model.Address;
            txtSuburb.Text = model.Suburb;
            txtState.Text = model.State;
            txtPostcost.Text = model.Postcode;
            txtContact.Text = model.Contact;
        }

        /// <summary>
        /// Implement Validate data
        /// </summary>
        /// <returns></returns>
        protected bool Validate()
        {
            Validator objValidator = new Validator();

            if (!objValidator.IsNonEmpty("Number", txtNumber.Text))
            {
                txtNumber.Focus();
                return false;
            }

            if (!objValidator.IsNonEmpty("Status", cboStatus.Text))
            {
                cboStatus.Focus();
                return false;
            }

            if (!objValidator.IsNonEmpty("Ordered By", cboOrderedBy.Text))
            {
                cboOrderedBy.Focus();
                return false;
            }

            if (!objValidator.IsNonEmpty("Firm", cboFirm.Text))
            {
                cboFirm.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Implement ReadToDataModel
        /// </summary>
        protected void ReadToDataModel()
        {
            model.Number = Convert.ToDouble(txtNumber.Text);
            model.StatusID = ((TabItem)cboStatus.SelectedItem).ItemID;
            model.Reference = txtReference.Text;
            model.OrderedByID = ((TabItem)cboOrderedBy.SelectedItem).ItemID;
            model.IssuedDate = dtmIssued.DateTime;
            model.DueOn = dtmDueOn.DateTime;
            model.Instructions = txtInstructions.Text;
            model.SupplierID = ((TabItem)cboFirm.SelectedItem).ItemID;
            model.Phone = txtPhone.Text;
            model.Name = txtName.Text;
            model.Address = txtAddress.Text;
            model.Suburb = txtSuburb.Text;
            model.State = txtState.Text;
            model.Postcode = txtPostcost.Text;
            model.Contact = txtContact.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validate()) return;
            ReadToDataModel();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // confirm to save data
            DialogResult dlgResult = MessageBox.Show(Constants.Message.Save_Prompt, Constants.Message.MessageTitle, MessageBoxButtons.YesNo);
            if (dlgResult == DialogResult.Yes)
            {
                btnSave_Click(btnSave, EventArgs.Empty);
            }
            else
            {
                this.Close();
            }
        }

        private void WorkOrder_Load(object sender, EventArgs e)
        {
            txtNumber.Focus();
        }
    }
}

