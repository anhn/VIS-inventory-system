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
    /// Summary description for frmAddEditPurchaseOrderReturn.
    /// </summary>
    public class frmAddEditPurchaseReturnMaster : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmAddEditPurchaseReturnMaster()
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
            this.cboPurchaseOrderId = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTotalAmount = new DevExpress.XtraEditors.TextEdit();
            this.txtReturnCharge = new DevExpress.XtraEditors.TextEdit();
            this.txtPurchaseReturnDate = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPurchaseReturnNo = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grdPurchaseReturnDetail = new DevExpress.XtraGrid.GridControl();
            this.grvPurchaseReturnDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtQty = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtPrice = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtAmount = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPurchaseOrderId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReturnCharge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchaseReturnDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchaseReturnNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchaseReturnDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPurchaseReturnDetail)).BeginInit();
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
            this.groupControl1.Controls.Add(this.cboPurchaseOrderId);
            this.groupControl1.Controls.Add(this.txtTotalAmount);
            this.groupControl1.Controls.Add(this.txtReturnCharge);
            this.groupControl1.Controls.Add(this.txtPurchaseReturnDate);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txtPurchaseReturnNo);
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
            this.groupControl1.Text = "Purchase Return Master";
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
            // cboPurchaseOrderId
            // 
            this.cboPurchaseOrderId.Location = new System.Drawing.Point(149, 74);
            this.cboPurchaseOrderId.Name = "cboPurchaseOrderId";
            this.cboPurchaseOrderId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPurchaseOrderId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboPurchaseOrderId.Size = new System.Drawing.Size(172, 20);
            this.cboPurchaseOrderId.TabIndex = 1;
            this.cboPurchaseOrderId.SelectedIndexChanged += new System.EventHandler(this.cboPurchaseOrderId_SelectedIndexChanged);
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
            // txtPurchaseReturnDate
            // 
            this.txtPurchaseReturnDate.Location = new System.Drawing.Point(494, 39);
            this.txtPurchaseReturnDate.Name = "txtPurchaseReturnDate";
            this.txtPurchaseReturnDate.Properties.DisplayFormat.FormatString = "d";
            this.txtPurchaseReturnDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtPurchaseReturnDate.Properties.EditFormat.FormatString = "d";
            this.txtPurchaseReturnDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtPurchaseReturnDate.Properties.Mask.EditMask = "d";
            this.txtPurchaseReturnDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtPurchaseReturnDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPurchaseReturnDate.Size = new System.Drawing.Size(167, 20);
            this.txtPurchaseReturnDate.TabIndex = 3;
            this.txtPurchaseReturnDate.EditValueChanged += new System.EventHandler(this.txtPurchaseReturnDate_EditValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Amount:";
            // 
            // txtPurchaseReturnNo
            // 
            this.txtPurchaseReturnNo.Location = new System.Drawing.Point(149, 39);
            this.txtPurchaseReturnNo.Name = "txtPurchaseReturnNo";
            this.txtPurchaseReturnNo.Properties.ReadOnly = true;
            this.txtPurchaseReturnNo.Size = new System.Drawing.Size(172, 20);
            this.txtPurchaseReturnNo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Return Charge:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Purchase Return Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Reasons:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Purchase Order:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase Return No:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.grdPurchaseReturnDetail);
            this.groupControl2.Controls.Add(this.btnSearch);
            this.groupControl2.Controls.Add(this.btnDelete);
            this.groupControl2.Controls.Add(this.btnAdd);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 216);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(692, 260);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Purchase Return Details";
            // 
            // grdPurchaseReturnDetail
            // 
            this.grdPurchaseReturnDetail.EmbeddedNavigator.Name = "";
            this.grdPurchaseReturnDetail.Location = new System.Drawing.Point(2, 45);
            this.grdPurchaseReturnDetail.MainView = this.grvPurchaseReturnDetail;
            this.grdPurchaseReturnDetail.Name = "grdPurchaseReturnDetail";
            this.grdPurchaseReturnDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtQty,
            this.txtPrice,
            this.txtAmount});
            this.grdPurchaseReturnDetail.Size = new System.Drawing.Size(688, 213);
            this.grdPurchaseReturnDetail.TabIndex = 3;
            this.grdPurchaseReturnDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPurchaseReturnDetail});
            // 
            // grvPurchaseReturnDetail
            // 
            this.grvPurchaseReturnDetail.GridControl = this.grdPurchaseReturnDetail;
            this.grvPurchaseReturnDetail.Name = "grvPurchaseReturnDetail";
            this.grvPurchaseReturnDetail.OptionsView.ShowFooter = true;
            this.grvPurchaseReturnDetail.OptionsView.ShowGroupPanel = false;
            this.grvPurchaseReturnDetail.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvPurchaseReturnDetail_FocusedRowChanged);
            this.grvPurchaseReturnDetail.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grvPurchaseReturnDetail_ValidateRow);
            this.grvPurchaseReturnDetail.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvPurchaseReturnDetail_InitNewRow);
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
            // frmAddEditPurchaseReturnMaster
            // 
            this.ClientSize = new System.Drawing.Size(692, 473);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditPurchaseReturnMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Edit Purchase Return Master";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditPurchaseReturnMaster_FormClosing);
            this.Load += new System.EventHandler(this.frmAddEditPurchaseReturnMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPurchaseOrderId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReturnCharge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchaseReturnDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchaseReturnNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchaseReturnDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPurchaseReturnDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private GroupControl groupControl1;
        private GroupControl groupControl2;
        private ComboBoxEdit cboPurchaseOrderId;
        private SimpleButton btnSearch;
        private TextEdit txtReturnCharge;
        private TextEdit txtPurchaseReturnDate;
        private TextEdit txtPurchaseReturnNo;
        private Label label1;
        private DevExpress.XtraGrid.GridControl grdPurchaseReturnDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPurchaseReturnDetail;
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
        DA_DataTable  dtPurchase_Order_Header;
        DA_DataTable dtPurchases_Order_Details;
        DA_DataTable dtProductMaster;
        DA_DataTable dtPurchaseReturnDetail;
        DA_DataTable dtWarehouse_Master;
        DA_DataTable dtMaxPurchaseReturnMaster;
        DA_DataTable dtPurchaseReturnMaster;
        private RepositoryItemTextEdit txtQty;
        private RepositoryItemTextEdit txtPrice;
        private RepositoryItemTextEdit txtAmount;
        bool ProTypeAction=true;

        #endregion
        #region Method
        private void CheckButton() 
        {
            
            if (grvPurchaseReturnDetail.RowCount <= 0)
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
            if (Decimal.Parse ( txtReturnCharge.Text) < 0) 
            {
                MessageBox.Show("Return charge must be an positive number !", "Data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtReturnCharge.Focus();
                return false;
            }
            if (((DateTime.Parse(txtPurchaseReturnDate.Text).Year < 1753 || (DateTime.Parse(txtPurchaseReturnDate.Text).Year > 9999))))
            {
                MessageBox.Show("Purchase Return Date must be between 1/1/1753 12:00:00 AM and 12/31/9999 11:59:59 PM.", "Data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
            
        
        }
        
        private void LoadData()
        {
            dtPurchaseReturnMaster = new DA_DataTable("select * from PurchaseReturnMaster", false);
            
            if (!ProIsAdd)
            {
                txtPurchaseReturnNo.EditValue = ProRow["PurchaseReturnNo"];
                txtPurchaseReturnDate.EditValue = ProRow["PurchaseReturnDate"];
                txtReturnCharge.EditValue = ProRow["ReturnCharge"];
                txtTotalAmount.EditValue = ProRow["TotalAmount"];
                memNotes.EditValue = ProRow["Notes"];
                cboPurchaseOrderId.Enabled = false;
                


            }
            else
            {
                ProRow["PurchaseReturnId"] = System.Guid.NewGuid().ToString();
                txtPurchaseReturnNo.EditValue = GetPurchaseReturnNumber();
                txtPurchaseReturnDate.EditValue =DateTime.Today;
                
                
                txtReturnCharge.EditValue = 0;
                txtTotalAmount.EditValue = 0;
                memNotes.EditValue = "";
                cboPurchaseOrderId.Enabled = true;
            }
        }
        private void SaveAllData()
        {
            
            ProRow["PurchaseReturnNo"] = txtPurchaseReturnNo.EditValue;
            ProRow["PurchaseReturnDate"] = txtPurchaseReturnDate.EditValue;
            ProRow["TotalAmount"] = grvPurchaseReturnDetail.Columns["Amount"].SummaryText;
            ProRow["ReturnCharge"] = txtReturnCharge.EditValue;
            
            ProRow["Notes"] = memNotes.EditValue;
            ProRow["PurchaseOrderID"] = cboPurchaseOrderId.SelectedItem.ToString();
            grvPurchaseReturnDetail.CloseEditor();
            if (ProIsAdd)
            {
                DataRow newRow = dtPurchaseReturnMaster.NewRow();
                newRow["PurchaseReturnId"] = ProRow["PurchaseReturnId"].ToString();
                newRow["PurchaseReturnNo"] = txtPurchaseReturnNo.EditValue;
                newRow["PurchaseReturnDate"] = txtPurchaseReturnDate.EditValue;
                newRow["TotalAmount"] = grvPurchaseReturnDetail.Columns["Amount"].SummaryText;
                newRow["ReturnCharge"] = txtReturnCharge.EditValue;
                newRow["Notes"] = memNotes.EditValue;
                newRow["PurchaseOrderID"] = cboPurchaseOrderId.SelectedItem.ToString();
                dtPurchaseReturnMaster.Rows.Add(newRow);
                dtPurchaseReturnMaster.Update();
                dtPurchaseReturnDetail.Update();
                dtPurchases_Order_Details.Update();


            }
            else
            {
                for (int i = 0; i < dtPurchaseReturnMaster.Rows.Count; i++)
                {
                    if (dtPurchaseReturnMaster.Rows[i]["PurchaseReturnId"].ToString() == ProRow["PurchaseReturnId"].ToString())
                    {
                        DataRow newRow = dtPurchaseReturnMaster.Rows[i];
                        newRow["PurchaseReturnId"] = ProRow["PurchaseReturnId"].ToString();
                        newRow["PurchaseReturnNo"] = txtPurchaseReturnNo.EditValue;
                        newRow["PurchaseReturnDate"] = txtPurchaseReturnDate.EditValue;
                        newRow["TotalAmount"] = grvPurchaseReturnDetail.Columns["Amount"].SummaryText;
                        newRow["ReturnCharge"] = txtReturnCharge.EditValue;
                        newRow["Notes"] = memNotes.EditValue;
                        newRow["PurchaseOrderID"] = cboPurchaseOrderId.SelectedItem.ToString();
                        dtPurchaseReturnMaster.Update();
                        dtPurchaseReturnDetail.Update();
                        dtPurchases_Order_Details.Update();
                    }
                }
            }


            grvPurchaseReturnDetail.UpdateCurrentRow();
            
            this.DialogResult = DialogResult.OK;
             isSave= true;
            this.Close();

        }
        public string GetPurchaseReturnNumber()
        {
            dtMaxPurchaseReturnMaster = new DA_DataTable("Select * from PurchaseReturnMaster Order by PurchaseReturnNo Desc", false);
            string orderNumber = "200701010001";

            orderNumber = DateTime.Today.ToString("yyyyMMdd") + "0001";
            if (dtMaxPurchaseReturnMaster.Rows.Count > 0)
            {
                if (dtMaxPurchaseReturnMaster.Rows[0]["PurchaseReturnNo"].ToString() != "")
                {
                    if (Int64.Parse(dtMaxPurchaseReturnMaster.Rows[0]["PurchaseReturnNo"].ToString()) >= Int64.Parse(orderNumber))
                    {
                        orderNumber = Int64.Parse(dtMaxPurchaseReturnMaster.Rows[0]["PurchaseReturnNo"].ToString()) + 1 + "";
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
        private void LoadPurchaseReturnDetail()
        {

            dtPurchaseReturnDetail = new DA_DataTable("Select * from PurchaseReturnDetail where PurchaseReturnId='" + ProRow["PurchaseReturnId"].ToString() + "' ", false);
            dtPurchaseReturnDetail.Columns.Add("Amount", typeof(decimal));
            dtPurchaseReturnDetail.Columns.Add("WarehouseName", typeof(string));
            dtPurchaseReturnDetail.Columns.Add("LocationName", typeof(string));
            dtPurchaseReturnDetail.Columns.Add("UOM", typeof(string));
            dtPurchaseReturnDetail.Columns.Add("Price", typeof(decimal));
            grdPurchaseReturnDetail.DataSource = dtPurchaseReturnDetail;
            foreach (GridColumn col in grvPurchaseReturnDetail.Columns)
            {
                col.VisibleIndex = -1;
            }
            grvPurchaseReturnDetail.Columns["ProductId"].VisibleIndex = 0;
            grvPurchaseReturnDetail.Columns["WarehouseName"].VisibleIndex = 1;
            grvPurchaseReturnDetail.Columns["LocationName"].VisibleIndex = 2;
            grvPurchaseReturnDetail.Columns["Qty"].VisibleIndex = 3;
            grvPurchaseReturnDetail.Columns["UOM"].VisibleIndex = 4;
            grvPurchaseReturnDetail.Columns["Price"].VisibleIndex = 5;
            grvPurchaseReturnDetail.Columns["Amount"].VisibleIndex = 6;

            grvPurchaseReturnDetail.Columns["ProductId"].Caption = "Product Name";
            grvPurchaseReturnDetail.Columns["WarehouseName"].Caption = "Warehouse";
            grvPurchaseReturnDetail.Columns["LocationName"].Caption = "Location";
            grvPurchaseReturnDetail.Columns["Qty"].Caption = "Quantity";
            grvPurchaseReturnDetail.Columns["UOM"].Caption = "Product Unit";
            grvPurchaseReturnDetail.Columns["Price"].Caption = "Price";
            grvPurchaseReturnDetail.Columns["Amount"].Caption = "Amount";


            
            for (int i = 0; i < grvPurchaseReturnDetail.RowCount; i++)
            {
                decimal price = 0;
                decimal qty = 0;
                if (grvPurchaseReturnDetail.GetRowCellValue(i, "Qty").ToString() != "")
                {
                    qty = decimal.Parse(grvPurchaseReturnDetail.GetRowCellValue(i, "Qty").ToString());
                }
                if (grvPurchaseReturnDetail.GetRowCellValue(i, "Price").ToString() != "")
                {
                    price = decimal.Parse(grvPurchaseReturnDetail.GetRowCellValue(i, "Price").ToString());
                }
                grvPurchaseReturnDetail.SetRowCellValue(i, "Amount", qty * price);
            }
            grvPurchaseReturnDetail.Columns["WarehouseName"].OptionsColumn.ReadOnly = true;
            grvPurchaseReturnDetail.Columns["LocationName"].OptionsColumn.ReadOnly = true;
            grvPurchaseReturnDetail.Columns["Price"].OptionsColumn.ReadOnly = true;
            grvPurchaseReturnDetail.Columns["Amount"].OptionsColumn.ReadOnly = true;
            grvPurchaseReturnDetail.Columns["UOM"].OptionsColumn.ReadOnly = true;

            grvPurchaseReturnDetail.Columns["Qty"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            grvPurchaseReturnDetail.Columns["Qty"].DisplayFormat.FormatString = "f2";
            grvPurchaseReturnDetail.Columns["Price"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            grvPurchaseReturnDetail.Columns["Price"].DisplayFormat.FormatString = "f2";
            grvPurchaseReturnDetail.Columns["Amount"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            grvPurchaseReturnDetail.Columns["Amount"].DisplayFormat.FormatString = "f2";
            if (!ProIsAdd)
            {
                for (int i = 0; i < grvPurchaseReturnDetail.RowCount; i++)
                {
                    for (int j = 0; j < dtPurchases_Order_Details.Rows.Count; j++)
                    {
                        if (dtPurchases_Order_Details.Rows[j]["POProductID"].ToString() ==
                            grvPurchaseReturnDetail.GetRowCellValue(i, "ProductId").ToString())
                        {
                            grvPurchaseReturnDetail.SetRowCellValue(i, "WarehouseName",
                                GetWarehouseName(dtPurchases_Order_Details.Rows[j]["Warehouse_id"].ToString()));
                            grvPurchaseReturnDetail.SetRowCellValue(i, "LocationName",
                                dtPurchases_Order_Details.Rows[j]["Location_id"].ToString());

                            grvPurchaseReturnDetail.SetRowCellValue(i, "Price",
                                dtPurchases_Order_Details.Rows[j]["UnitPrice"]);
                            grvPurchaseReturnDetail.SetRowCellValue(i, "UOM",
                                dtPurchases_Order_Details.Rows[j]["ProductUnit"].ToString());
                        }
                    }
                }
                for (int i = 0; i < grvPurchaseReturnDetail.RowCount; i++)
                {
                    decimal price = 0;
                    decimal qty = 0;
                    if (grvPurchaseReturnDetail.GetRowCellValue(i, "Qty").ToString() != "")
                    {
                        qty = decimal.Parse(grvPurchaseReturnDetail.GetRowCellValue(i, "Qty").ToString());
                    }
                    if (grvPurchaseReturnDetail.GetRowCellValue(i, "Price").ToString() != "")
                    {
                        price = decimal.Parse(grvPurchaseReturnDetail.GetRowCellValue(i, "Price").ToString());
                    }
                    grvPurchaseReturnDetail.SetRowCellValue(i, "Amount", qty * price);
                }
            }
            grvPurchaseReturnDetail.Columns["ProductId"].ColumnEdit = resProduct;
            grvPurchaseReturnDetail.Columns["Qty"].ColumnEdit = txtQty;
            grvPurchaseReturnDetail.Columns["Price"].ColumnEdit = txtPrice;
            grvPurchaseReturnDetail.Columns["Amount"].ColumnEdit = txtAmount;

            grvPurchaseReturnDetail.Columns["Amount"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
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
        private void LoadcboPurchaseOrderId()
        {
            dtPurchase_Order_Header = new DA_DataTable("select * from t_Purchase_Order_Header", false);
            for (int i = 0; i <  dtPurchase_Order_Header.Rows.Count; i++)
            {
                cboPurchaseOrderId.Properties.Items.Add( dtPurchase_Order_Header.Rows[i]["PONo"].ToString());
            }
            if (!ProIsAdd)
            {
                cboPurchaseOrderId.SelectedItem = ProRow["PurchaseOrderID"].ToString();
                cboPurchaseOrderId.Enabled = false;
            }
            else
            {

                if (dtPurchase_Order_Header.Rows.Count > 0)
                    cboPurchaseOrderId.SelectedIndex = 0;
                cboPurchaseOrderId.Enabled = true;
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
        private void frmAddEditPurchaseReturnMaster_Load(object sender, EventArgs e)
        {
            
            LoadcboPurchaseOrderId();
            this.resProduct.NullText = "Please Select a Product";
            resProduct.EditValueChanged += new EventHandler(resProduct_EditValueChanged);
            CheckButton();
       
            
            
        }

        void resProduct_EditValueChanged(object sender, EventArgs e)
        {
            grvPurchaseReturnDetail.SetRowCellValue(grvPurchaseReturnDetail.FocusedRowHandle, "Qty",
                0);
            grvPurchaseReturnDetail.SetRowCellValue(grvPurchaseReturnDetail.FocusedRowHandle, "UOM",
               ((LookUpEdit)sender).GetColumnValue("ProductUnit"));
            grvPurchaseReturnDetail.SetRowCellValue(grvPurchaseReturnDetail.FocusedRowHandle, "Price",
                ((LookUpEdit)sender).GetColumnValue("UnitPrice"));
            grvPurchaseReturnDetail.SetRowCellValue(grvPurchaseReturnDetail.FocusedRowHandle, "LocationName",
                ((LookUpEdit)sender).GetColumnValue("Location_id"));
            grvPurchaseReturnDetail.SetRowCellValue(grvPurchaseReturnDetail.FocusedRowHandle, "WarehouseName",
                GetWarehouseName(((LookUpEdit)sender).GetColumnValue("Warehouse_id").ToString()));
            
        }


        private void cboPurchaseOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grvPurchaseReturnDetail.RowCount > 0)
            {
                if (MessageBox.Show("Do you want to save order?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    SaveAllData();
                else
                {
                    LoadPurchasesOrderDetail();
                }
            }
            else
            {
                LoadPurchasesOrderDetail();
            }
     
        }

        private void LoadPurchasesOrderDetail()
        {
            dtPurchases_Order_Details = new DA_DataTable("select * from t_Purchase_Order_Detail where PONo='" + cboPurchaseOrderId.Text + "'", false);

            dtPurchases_Order_Details.Columns.Add("ProductName", typeof(string));
            dtPurchases_Order_Details.Columns.Add("WarehouseName", typeof(string));

            foreach (DataRow row in dtPurchases_Order_Details.Rows)
            {
                if (row["POProductID"].ToString().Length > 0)
                {
                    row["ProductName"] = GetProductName(row["POProductID"].ToString());
                }
                if (row["Warehouse_id"].ToString().Length > 0)
                {
                    row["WarehouseName"] = GetWarehouseName(row["Warehouse_id"].ToString());
                }
            }
            LoadLueProductName();
            LoadPurchaseReturnDetail();

        }
        private void LoadLueProductName()
        {
            resProduct.Columns.Clear();
            resProduct.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", 50, "Product Name"));
            resProduct.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("POProductID", 50, "Product ID"));
            resProduct.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Location_id", 50, "Location"));
            resProduct.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Warehouse_id", 50, "Warehouse"));
            resProduct.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitProduct", 50, "UOM"));

            resProduct.DataSource = dtPurchases_Order_Details;
            resProduct.ValueMember = "POProductID";
            resProduct.DisplayMember = "ProductName";
            resProduct.Columns["Warehouse_id"].Visible = false;
            resProduct.Columns["Location_id"].Visible = false;
            resProduct.Columns["UnitProduct"].Visible = false;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            grvPurchaseReturnDetail.AddNewRow();
            CheckButton();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            grdPurchaseReturnDetail.EmbeddedNavigator.Buttons.Remove.DoClick();
            CheckButton();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ArrayList arrList = new ArrayList();
            for (int i = 0; i < dtPurchases_Order_Details.Columns.Count; i++)
            {
                if (dtPurchases_Order_Details.Columns[i].ColumnName != "ProductName")
                {
                    arrList.Add(dtPurchases_Order_Details.Columns[i].ColumnName);
                }
            }

            frmSearch frm = new frmSearch(dtPurchases_Order_Details, arrList, "POProductID");
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            grvPurchaseReturnDetail.SetRowCellValue(grvPurchaseReturnDetail.FocusedRowHandle, "ProductId", frm.StrRetrieve);

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

        private void grvPurchaseReturnDetail_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            txtTotalAmount.Text = grvPurchaseReturnDetail.Columns["Amount"].SummaryText;
        }

        private void grvPurchaseReturnDetail_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtTotalAmount.Text = grvPurchaseReturnDetail.Columns["Amount"].SummaryText;
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
            txtTotalAmount.Text = grvPurchaseReturnDetail.Columns["Amount"].SummaryText;
        }

        private void txtPrice_EditValueChanged(object sender, EventArgs e)
        {
            txtTotalAmount.Text = grvPurchaseReturnDetail.Columns["Amount"].SummaryText;
        }

        private void grvPurchaseReturnDetail_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            grvPurchaseReturnDetail.SetRowCellValue(e.RowHandle, "PurchaseReturnDetailId", System.Guid.NewGuid().ToString());

            grvPurchaseReturnDetail.SetRowCellValue(e.RowHandle, "PurchaseReturnId", ProRow["PurchaseReturnId"]);
            grvPurchaseReturnDetail.SetRowCellValue(e.RowHandle, "Qty", 0);
            grvPurchaseReturnDetail.SetRowCellValue(e.RowHandle, "Price", 0);
            grvPurchaseReturnDetail.SetRowCellValue(e.RowHandle, "Amount", 0 * 0);
            txtTotalAmount.Text = grvPurchaseReturnDetail.Columns["Amount"].SummaryText;
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
            if (grvPurchaseReturnDetail.GetRowCellValue(grvPurchaseReturnDetail.FocusedRowHandle, "Price").ToString() != "")
            {
                price = (Decimal)grvPurchaseReturnDetail.GetRowCellValue(grvPurchaseReturnDetail.FocusedRowHandle, "Price");
            }
            amount = qty * price;
            grvPurchaseReturnDetail.SetRowCellValue(grvPurchaseReturnDetail.FocusedRowHandle, "Amount", amount);
        }

        private void frmAddEditPurchaseReturnMaster_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtPurchaseReturnDate_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtReturnCharge_EditValueChanged(object sender, EventArgs e)
        {

        }

       
        
    }
}

