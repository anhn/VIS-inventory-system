using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;


namespace Inventory
{
    /// <summary>
    /// Summary description for frmAddEditSaleOrderReturn.
    /// </summary>
    public class frmAddEditSaleReturnMaster : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmAddEditSaleReturnMaster()
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
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.memNotes = new DevExpress.XtraEditors.MemoEdit();
            this.cboSaleOrderId = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTotalAmount = new DevExpress.XtraEditors.TextEdit();
            this.txtReturnCharge = new DevExpress.XtraEditors.TextEdit();
            this.txtSaleReturnDate = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSaleReturnNo = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grdSaleReturnDetail = new DevExpress.XtraGrid.GridControl();
            this.grvSaleReturnDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtQty = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtPrice = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtAmount = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSaleOrderId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReturnCharge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleReturnDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleReturnNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSaleReturnDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSaleReturnDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.memNotes);
            this.groupControl1.Controls.Add(this.cboSaleOrderId);
            this.groupControl1.Controls.Add(this.txtTotalAmount);
            this.groupControl1.Controls.Add(this.txtReturnCharge);
            this.groupControl1.Controls.Add(this.txtSaleReturnDate);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txtSaleReturnNo);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(692, 216);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Sale Return Master";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(586, 168);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(493, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // memNotes
            // 
            this.memNotes.Location = new System.Drawing.Point(149, 117);
            this.memNotes.Name = "memNotes";
            this.memNotes.Size = new System.Drawing.Size(172, 74);
            this.memNotes.TabIndex = 2;
            // 
            // cboSaleOrderId
            // 
            this.cboSaleOrderId.Location = new System.Drawing.Point(149, 74);
            this.cboSaleOrderId.Name = "cboSaleOrderId";
            this.cboSaleOrderId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSaleOrderId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboSaleOrderId.Size = new System.Drawing.Size(172, 20);
            this.cboSaleOrderId.TabIndex = 1;
            this.cboSaleOrderId.SelectedIndexChanged += new System.EventHandler(this.cboSaleOrderId_SelectedIndexChanged);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(494, 116);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Properties.DisplayFormat.FormatString = "f2";
            this.txtTotalAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalAmount.Properties.Mask.EditMask = "f2";
            this.txtTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotalAmount.Properties.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(167, 20);
            this.txtTotalAmount.TabIndex = 5;
            // 
            // txtReturnCharge
            // 
            this.txtReturnCharge.Location = new System.Drawing.Point(494, 74);
            this.txtReturnCharge.Name = "txtReturnCharge";
            this.txtReturnCharge.Properties.DisplayFormat.FormatString = "f2";
            this.txtReturnCharge.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtReturnCharge.Properties.Mask.EditMask = "f2";
            this.txtReturnCharge.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtReturnCharge.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtReturnCharge.Size = new System.Drawing.Size(167, 20);
            this.txtReturnCharge.TabIndex = 4;
            this.txtReturnCharge.EditValueChanged += new System.EventHandler(this.txtReturnCharge_EditValueChanged);
            // 
            // txtSaleReturnDate
            // 
            this.txtSaleReturnDate.Location = new System.Drawing.Point(494, 39);
            this.txtSaleReturnDate.Name = "txtSaleReturnDate";
            this.txtSaleReturnDate.Properties.Mask.EditMask = "d";
            this.txtSaleReturnDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtSaleReturnDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            
            this.txtSaleReturnDate.Size = new System.Drawing.Size(167, 20);
            this.txtSaleReturnDate.TabIndex = 3;
            this.txtSaleReturnDate.EditValueChanged += new System.EventHandler(this.txtSaleReturnDate_EditValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Amount:";
            // 
            // txtSaleReturnNo
            // 
            this.txtSaleReturnNo.Location = new System.Drawing.Point(149, 39);
            this.txtSaleReturnNo.Name = "txtSaleReturnNo";
            this.txtSaleReturnNo.Properties.ReadOnly = true;
            this.txtSaleReturnNo.Size = new System.Drawing.Size(172, 20);
            this.txtSaleReturnNo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Return Charge:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sale Return Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Reasons:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sale Order:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sale Return No:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.grdSaleReturnDetail);
            this.groupControl2.Controls.Add(this.btnSearch);
            this.groupControl2.Controls.Add(this.btnDelete);
            this.groupControl2.Controls.Add(this.btnAdd);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 216);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(692, 260);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Sale Return Details";
            // 
            // grdSaleReturnDetail
            // 
            this.grdSaleReturnDetail.EmbeddedNavigator.Name = "";
            this.grdSaleReturnDetail.Location = new System.Drawing.Point(2, 45);
            this.grdSaleReturnDetail.MainView = this.grvSaleReturnDetail;
            this.grdSaleReturnDetail.Name = "grdSaleReturnDetail";
            this.grdSaleReturnDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtQty,
            this.txtPrice,
            this.txtAmount});
            this.grdSaleReturnDetail.Size = new System.Drawing.Size(688, 213);
            this.grdSaleReturnDetail.TabIndex = 3;
            this.grdSaleReturnDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvSaleReturnDetail});
            // 
            // grvSaleReturnDetail
            // 
            this.grvSaleReturnDetail.GridControl = this.grdSaleReturnDetail;
            this.grvSaleReturnDetail.Name = "grvSaleReturnDetail";
            this.grvSaleReturnDetail.OptionsView.ShowFooter = true;
            this.grvSaleReturnDetail.OptionsView.ShowGroupPanel = false;
            this.grvSaleReturnDetail.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvSaleReturnDetail_FocusedRowChanged);
            this.grvSaleReturnDetail.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grvSaleReturnDetail_ValidateRow);
            this.grvSaleReturnDetail.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvSaleReturnDetail_InitNewRow);
            // 
            // txtQty
            // 
            this.txtQty.AutoHeight = false;
            this.txtQty.Mask.EditMask = "f2";
            this.txtQty.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQty.Mask.UseMaskAsDisplayFormat = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtQty_EditValueChanging);
            this.txtQty.EditValueChanged += new System.EventHandler(this.txtQty_EditValueChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.AutoHeight = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.EditValueChanged += new System.EventHandler(this.txtPrice_EditValueChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.AutoHeight = false;
            this.txtAmount.Name = "txtAmount";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(586, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "&Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(493, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "&Delete Item";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(398, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add Item";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddEditSaleReturnMaster
            // 
            this.ClientSize = new System.Drawing.Size(692, 473);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditSaleReturnMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Edit Sale Return Master";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditSaleReturnMaster_FormClosing);
            this.Load += new System.EventHandler(this.frmAddEditSaleReturnMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSaleOrderId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReturnCharge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleReturnDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleReturnNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSaleReturnDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSaleReturnDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private GroupControl groupControl1;
        private GroupControl groupControl2;
        private ComboBoxEdit cboSaleOrderId;
        private SimpleButton btnSearch;
        private TextEdit txtReturnCharge;
        private TextEdit txtSaleReturnDate;
        private TextEdit txtSaleReturnNo;
        private Label label1;
        private DevExpress.XtraGrid.GridControl grdSaleReturnDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView grvSaleReturnDetail;
        private MemoEdit memNotes;
        private SimpleButton btnAdd;
        private SimpleButton btnDelete;
        private Label label4;
        private Label label3;
        private Label label2;
        private SimpleButton btnClose;
        private SimpleButton btnSave;
        private TextEdit txtTotalAmount;
        private Label label6;
        private Label label7;
        #region Variable
        bool isAdd;
        bool isSave;
        RepositoryItemLookUpEdit resProduct = new RepositoryItemLookUpEdit();
      
        
        DataRow row;
        DA_DataTable  dtSale_Order_Header;
        DA_DataTable dtSales_Order_Details;
        DA_DataTable dtProductMaster;
        DA_DataTable dtSaleReturnDetail;
        DA_DataTable dtWarehouse_Master;
        DA_DataTable dtMaxSaleReturnMaster;
        DA_DataTable dtSaleReturnMaster;
        private RepositoryItemTextEdit txtQty;
        private RepositoryItemTextEdit txtPrice;
        private RepositoryItemTextEdit txtAmount;
        bool ProTypeAction=true;

        #endregion
        #region Method
        private void CheckButton()
        {

            if (grvSaleReturnDetail.RowCount <= 0)
            {
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
                btnSave.Enabled = true;

            }
        }
        private bool CheckValidate()
        {
            if (Decimal.Parse(txtReturnCharge.Text) < 0)
            {
                MessageBox.Show("Return charge must be an positive number !", "Data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtReturnCharge.Focus();
                return false;
            }
            if (((DateTime.Parse(txtSaleReturnDate.Text).Year < 1753 || (DateTime.Parse(txtSaleReturnDate.Text).Year > 9999))))
            {
                MessageBox.Show("Sale Return Date must be between 1/1/1753 12:00:00 AM and 12/31/9999 11:59:59 PM.", "Data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                return true;


        }
        
        private void LoadData()
        {
            dtSaleReturnMaster = new DA_DataTable("select * from SaleReturnMaster", false);
            
            if (!ProIsAdd)
            {
                txtSaleReturnNo.EditValue = ProRow["SaleReturnNo"];
                txtSaleReturnDate.EditValue = ProRow["SaleReturnDate"];
                txtReturnCharge.EditValue = ProRow["ReturnCharge"];
                txtTotalAmount.EditValue = ProRow["TotalAmount"];
                memNotes.EditValue = ProRow["Notes"];
                cboSaleOrderId.Enabled = false;
                


            }
            else
            {
                ProRow["SaleReturnId"] = System.Guid.NewGuid().ToString();
                txtSaleReturnNo.EditValue = GetSaleReturnNumber();
                txtSaleReturnDate.EditValue =DateTime.Today;
                
                
                txtReturnCharge.EditValue = 0;
                txtTotalAmount.EditValue = 0;
                memNotes.EditValue = "";
                cboSaleOrderId.Enabled = true;
            }
        }
        private void SaveAllData()
        {
            
            ProRow["SaleReturnNo"] = txtSaleReturnNo.EditValue;
            ProRow["SaleReturnDate"] = txtSaleReturnDate.EditValue;
            ProRow["TotalAmount"] = grvSaleReturnDetail.Columns["Amount"].SummaryText;
            ProRow["ReturnCharge"] = txtReturnCharge.EditValue;
            
            ProRow["Notes"] = memNotes.EditValue;
            ProRow["SaleOrderID"] = cboSaleOrderId.SelectedItem.ToString();
            grvSaleReturnDetail.CloseEditor();
            if (ProIsAdd)
            {
                DataRow newRow = dtSaleReturnMaster.NewRow();
                newRow["SaleReturnId"] = ProRow["SaleReturnId"].ToString();
                newRow["SaleReturnNo"] = txtSaleReturnNo.EditValue;
                newRow["SaleReturnDate"] = txtSaleReturnDate.EditValue;
                newRow["TotalAmount"] = grvSaleReturnDetail.Columns["Amount"].SummaryText;
                newRow["ReturnCharge"] = txtReturnCharge.EditValue;
                newRow["Notes"] = memNotes.EditValue;
                newRow["SaleOrderID"] = cboSaleOrderId.SelectedItem.ToString();
                dtSaleReturnMaster.Rows.Add(newRow);
                dtSaleReturnMaster.Update();
                dtSaleReturnDetail.Update();
                dtSales_Order_Details.Update();


            }
            else
            {
                for (int i = 0; i < dtSaleReturnMaster.Rows.Count; i++)
                {
                    if (dtSaleReturnMaster.Rows[i]["SaleReturnId"].ToString() == ProRow["SaleReturnId"].ToString())
                    {
                        DataRow newRow = dtSaleReturnMaster.Rows[i];
                        newRow["SaleReturnId"] = ProRow["SaleReturnId"].ToString();
                        newRow["SaleReturnNo"] = txtSaleReturnNo.EditValue;
                        newRow["SaleReturnDate"] = txtSaleReturnDate.EditValue;
                        newRow["TotalAmount"] = grvSaleReturnDetail.Columns["Amount"].SummaryText;
                        newRow["ReturnCharge"] = txtReturnCharge.EditValue;
                        newRow["Notes"] = memNotes.EditValue;
                        newRow["SaleOrderID"] = cboSaleOrderId.SelectedItem.ToString();
                        dtSaleReturnMaster.Update();
                        dtSaleReturnDetail.Update();
                        dtSales_Order_Details.Update();
                    }
                }
            }


            grvSaleReturnDetail.UpdateCurrentRow();
            
            this.DialogResult = DialogResult.OK;
             isSave= true;
            this.Close();

        }
        public string GetSaleReturnNumber()
        {
            dtMaxSaleReturnMaster = new DA_DataTable("Select * from SaleReturnMaster Order by SaleReturnNo Desc", false);
            string orderNumber = "200701010001";

            orderNumber = DateTime.Today.ToString("yyyyMMdd") + "0001";
            if (dtMaxSaleReturnMaster.Rows.Count > 0)
            {
                if (dtMaxSaleReturnMaster.Rows[0]["SaleReturnNo"].ToString() != "")
                {
                    if (Int64.Parse(dtMaxSaleReturnMaster.Rows[0]["SaleReturnNo"].ToString()) >= Int64.Parse(orderNumber))
                    {
                        orderNumber = Int64.Parse(dtMaxSaleReturnMaster.Rows[0]["SaleReturnNo"].ToString()) + 1 + "";
                    }
                }
            }
            return orderNumber;
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
        private void LoadSaleReturnDetail()
        {

            dtSaleReturnDetail = new DA_DataTable("Select * from SaleReturnDetail where SaleReturnId='" + ProRow["SaleReturnId"].ToString() + "' ", false);
            dtSaleReturnDetail.Columns.Add("Amount", typeof(decimal));
            dtSaleReturnDetail.Columns.Add("WarehouseName", typeof(string));
            dtSaleReturnDetail.Columns.Add("LocationName", typeof(string));
            dtSaleReturnDetail.Columns.Add("UOM", typeof(string));
            dtSaleReturnDetail.Columns.Add("Price", typeof(decimal));
            grdSaleReturnDetail.DataSource = dtSaleReturnDetail;
            foreach (GridColumn col in grvSaleReturnDetail.Columns)
            {
                col.VisibleIndex = -1;
            }

            grvSaleReturnDetail.Columns["ProductId"].VisibleIndex = 0;
            grvSaleReturnDetail.Columns["WarehouseName"].VisibleIndex = 1;
            grvSaleReturnDetail.Columns["LocationName"].VisibleIndex = 2;
            grvSaleReturnDetail.Columns["Qty"].VisibleIndex = 3;
            grvSaleReturnDetail.Columns["UOM"].VisibleIndex = 4;
            grvSaleReturnDetail.Columns["Price"].VisibleIndex = 5;
            grvSaleReturnDetail.Columns["Amount"].VisibleIndex = 6;

            grvSaleReturnDetail.Columns["ProductId"].Caption = "Product Name";
            grvSaleReturnDetail.Columns["WarehouseName"].Caption = "Warehouse";
            grvSaleReturnDetail.Columns["LocationName"].Caption = "Location";
            grvSaleReturnDetail.Columns["Qty"].Caption = "Quantity";
            grvSaleReturnDetail.Columns["UOM"].Caption = "Product Unit";
            grvSaleReturnDetail.Columns["Price"].Caption = "Price";
            grvSaleReturnDetail.Columns["Amount"].Caption = "Amount";

            for (int i = 0; i < grvSaleReturnDetail.RowCount; i++)
            {
                decimal price = 0;
                decimal qty = 0;
                if (grvSaleReturnDetail.GetRowCellValue(i, "Qty").ToString() != "")
                {
                    qty = decimal.Parse(grvSaleReturnDetail.GetRowCellValue(i, "Qty").ToString());
                }
                if (grvSaleReturnDetail.GetRowCellValue(i, "Price").ToString() != "")
                {
                    price = decimal.Parse(grvSaleReturnDetail.GetRowCellValue(i, "Price").ToString());
                }
                grvSaleReturnDetail.SetRowCellValue(i, "Amount", qty * price);
            }
            grvSaleReturnDetail.Columns["WarehouseName"].OptionsColumn.ReadOnly = true;
            grvSaleReturnDetail.Columns["LocationName"].OptionsColumn.ReadOnly = true;
            grvSaleReturnDetail.Columns["Price"].OptionsColumn.ReadOnly = true;
            grvSaleReturnDetail.Columns["Amount"].OptionsColumn.ReadOnly = true;
            grvSaleReturnDetail.Columns["UOM"].OptionsColumn.ReadOnly = true;

            grvSaleReturnDetail.Columns["Qty"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            grvSaleReturnDetail.Columns["Qty"].DisplayFormat.FormatString = "f2";
            grvSaleReturnDetail.Columns["Price"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            grvSaleReturnDetail.Columns["Price"].DisplayFormat.FormatString = "f2";
            grvSaleReturnDetail.Columns["Amount"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            grvSaleReturnDetail.Columns["Amount"].DisplayFormat.FormatString = "f2";
            if (!ProIsAdd)
            {
                for (int i = 0; i < grvSaleReturnDetail.RowCount; i++)
                {
                    for (int j = 0; j < dtSales_Order_Details.Rows.Count; j++)
                    {
                        if (dtSales_Order_Details.Rows[j]["ProductID"].ToString() ==
                            grvSaleReturnDetail.GetRowCellValue(i, "ProductId").ToString())
                        {
                            grvSaleReturnDetail.SetRowCellValue(i, "WarehouseName",
                                GetWarehouseName(dtSales_Order_Details.Rows[j]["Warehouse_id"].ToString()));
                            grvSaleReturnDetail.SetRowCellValue(i, "LocationName",
                                dtSales_Order_Details.Rows[j]["Location_id"].ToString());
                            grvSaleReturnDetail.SetRowCellValue(i, "Price",
                                dtSales_Order_Details.Rows[j]["UnitPrice"]);
                            grvSaleReturnDetail.SetRowCellValue(i, "UOM",
                                dtSales_Order_Details.Rows[j]["ProductUnit"].ToString());
                        }
                    }
                }
                for (int i = 0; i < grvSaleReturnDetail.RowCount; i++)
                {
                    decimal price = 0;
                    decimal qty = 0;
                    if (grvSaleReturnDetail.GetRowCellValue(i, "Qty").ToString() != "")
                    {
                        qty = decimal.Parse(grvSaleReturnDetail.GetRowCellValue(i, "Qty").ToString());
                    }
                    if (grvSaleReturnDetail.GetRowCellValue(i, "Price").ToString() != "")
                    {
                        price = decimal.Parse(grvSaleReturnDetail.GetRowCellValue(i, "Price").ToString());
                    }
                    grvSaleReturnDetail.SetRowCellValue(i, "Amount", qty * price);
                }
            }
            grvSaleReturnDetail.Columns["ProductId"].ColumnEdit = resProduct;
            grvSaleReturnDetail.Columns["Qty"].ColumnEdit = txtQty;
            grvSaleReturnDetail.Columns["Price"].ColumnEdit = txtPrice;
            grvSaleReturnDetail.Columns["Amount"].ColumnEdit = txtAmount;

            grvSaleReturnDetail.Columns["Amount"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
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
        private bool CheckValidated()
        {
            return true;
        }
        private void LoadcboSaleOrderId()
        {
             dtSale_Order_Header = new DA_DataTable("select * from t_Sales_Order_Header", false);
            for (int i = 0; i <  dtSale_Order_Header.Rows.Count; i++)
            {
                cboSaleOrderId.Properties.Items.Add( dtSale_Order_Header.Rows[i]["SONo"].ToString());
            }
            if (!ProIsAdd)
            {
                cboSaleOrderId.SelectedItem = ProRow["SaleOrderID"].ToString();
                cboSaleOrderId.Enabled = false;
            }
            else
            {

                if (dtSale_Order_Header.Rows.Count > 0)
                    cboSaleOrderId.SelectedIndex = 0;
                cboSaleOrderId.Enabled = true;
            }
        }
        #endregion
        #region Property
        public bool ProIsAdd
        {
            get
            {
                return this.isAdd;
            }
            set
            {
                isAdd = value;
            }
        }
        public DataRow ProRow
        {
            get
            {
                return this.row;
            }
            set
            {
                row = value;
                LoadData();
            }
        }
        #endregion
        #region Event
        private void frmAddEditSaleReturnMaster_Load(object sender, EventArgs e)
        {
            
            LoadcboSaleOrderId();
            this.resProduct.NullText = "Please Select a Product";
            resProduct.EditValueChanged += new EventHandler(resProduct_EditValueChanged);
            CheckButton();
            
            
        }

        void resProduct_EditValueChanged(object sender, EventArgs e)
        {
            grvSaleReturnDetail.SetRowCellValue(grvSaleReturnDetail.FocusedRowHandle, "Qty",
                0);
            grvSaleReturnDetail.SetRowCellValue(grvSaleReturnDetail.FocusedRowHandle, "UOM",
               ((LookUpEdit)sender).GetColumnValue("ProductUnit"));
            grvSaleReturnDetail.SetRowCellValue(grvSaleReturnDetail.FocusedRowHandle, "Price",
                ((LookUpEdit)sender).GetColumnValue("UnitPrice"));
            grvSaleReturnDetail.SetRowCellValue(grvSaleReturnDetail.FocusedRowHandle, "LocationName",
                ((LookUpEdit)sender).GetColumnValue("Location_id"));
            grvSaleReturnDetail.SetRowCellValue(grvSaleReturnDetail.FocusedRowHandle, "WarehouseName",
                GetWarehouseName(((LookUpEdit)sender).GetColumnValue("Warehouse_id").ToString()));
            
        }


        private void cboSaleOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grvSaleReturnDetail.RowCount > 0)
            {
                if (MessageBox.Show("Do you want to save order?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    SaveAllData();
                else
                {
                    LoadSalesOrderDetail();
                }
            }
            else
            {
                LoadSalesOrderDetail();
            }
     
        }

        private void LoadSalesOrderDetail()
        {
            dtSales_Order_Details = new DA_DataTable("select * from t_Sales_Order_Detail where SONo='" + cboSaleOrderId.Text + "'", false);

            dtSales_Order_Details.Columns.Add("ProductName", typeof(string));
            dtSales_Order_Details.Columns.Add("WarehouseName", typeof(string));

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
            LoadLueProductName();
            LoadSaleReturnDetail();

        }
        private void LoadLueProductName()
        {
            resProduct.Columns.Clear();
            resProduct.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", 50, "Product Name"));
            resProduct.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductID", 50, "Product ID"));
            resProduct.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Location_id", 50, "Location"));
            resProduct.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Warehouse_id", 50, "Warehouse"));
            resProduct.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitProduct", 50, "UOM"));

            resProduct.DataSource = dtSales_Order_Details;
            resProduct.ValueMember = "ProductID";
            resProduct.DisplayMember = "ProductName";
            resProduct.Columns["Warehouse_id"].Visible = false;
            resProduct.Columns["Location_id"].Visible = false;
            resProduct.Columns["UnitProduct"].Visible = false;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            grvSaleReturnDetail.AddNewRow();
            CheckButton();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            grdSaleReturnDetail.EmbeddedNavigator.Buttons.Remove.DoClick();
            CheckButton();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ArrayList arrList = new ArrayList();
            for (int i = 0; i < dtSales_Order_Details.Columns.Count; i++)
            {
                if (dtSales_Order_Details.Columns[i].ColumnName != "ProductName")
                {
                    arrList.Add(dtSales_Order_Details.Columns[i].ColumnName);
                }
            }

            frmSearch frm = new frmSearch(dtSales_Order_Details, arrList, "ProductID");
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            grvSaleReturnDetail.SetRowCellValue(grvSaleReturnDetail.FocusedRowHandle, "ProductId", frm.StrRetrieve);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                SaveAllData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grvSaleReturnDetail_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            txtTotalAmount.Text = grvSaleReturnDetail.Columns["Amount"].SummaryText;
        }

        private void grvSaleReturnDetail_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtTotalAmount.Text = grvSaleReturnDetail.Columns["Amount"].SummaryText;
            }
            catch
            {
            }
        }
        #endregion

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void txtQty_EditValueChanged(object sender, EventArgs e)
        {
            txtTotalAmount.Text = grvSaleReturnDetail.Columns["Amount"].SummaryText;
        }

        private void txtPrice_EditValueChanged(object sender, EventArgs e)
        {
            txtTotalAmount.Text = grvSaleReturnDetail.Columns["Amount"].SummaryText;
        }

        private void grvSaleReturnDetail_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            grvSaleReturnDetail.SetRowCellValue(e.RowHandle, "SaleReturnDetailId", System.Guid.NewGuid().ToString());

            grvSaleReturnDetail.SetRowCellValue(e.RowHandle, "SaleReturnId", ProRow["SaleReturnId"]);
            grvSaleReturnDetail.SetRowCellValue(e.RowHandle, "Qty", 0);
            grvSaleReturnDetail.SetRowCellValue(e.RowHandle, "Price", 0);
            grvSaleReturnDetail.SetRowCellValue(e.RowHandle, "Amount", 0 * 0);
            txtTotalAmount.Text = grvSaleReturnDetail.Columns["Amount"].SummaryText;
        }

        private void txtQty_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            decimal qty=0;
            decimal price=0;
            decimal amount = 0;
            if (e.NewValue.ToString() != "")
            {
                qty = decimal.Parse(e.NewValue.ToString());
            }
            if (grvSaleReturnDetail.GetRowCellValue(grvSaleReturnDetail.FocusedRowHandle, "Price").ToString() != "")
            {
                price = (Decimal)grvSaleReturnDetail.GetRowCellValue(grvSaleReturnDetail.FocusedRowHandle, "Price");
            }
            amount = qty * price;
            grvSaleReturnDetail.SetRowCellValue(grvSaleReturnDetail.FocusedRowHandle, "Amount", amount);
        }

        private void frmAddEditSaleReturnMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSave)
            {
                string str = MessageBox.Show("Do you want save your changes", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (str == "Yes")
                {
                    btnSave.PerformClick();
                }
                else
                {
                }
            }
        }

        private void txtSaleReturnDate_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtReturnCharge_EditValueChanged(object sender, EventArgs e)
        {

        }

       
        
    }
}

