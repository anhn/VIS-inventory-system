using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Inventory
{
    /// <summary>
    /// Summary description for AddEditPurchaseOrder.
    /// </summary>
    public class AddEditPurchaseOrder : DevExpress.XtraEditors.XtraForm
    {
        private GroupControl grpPO;
        private ButtonEdit bteSupplierName;
        private CheckEdit chkPOStatus;
        private MemoEdit memoNotes;
        private TextEdit txtShipTo;
        private Label lblPONote;
        private Label lblPOShipTo;
        private TextEdit txtTotalAmt;
        private Label lblPOTotalAmt;
        private ComboBoxEdit cbPOType;
        private TextEdit txtDeliveryDate;
        private TextEdit txtPODate;
        private Label lblSupplierPhone;
        private TextEdit txtPONo;
        private TextEdit txtSupplierPhone;
        private Label lblPOType;
        private Label lblPODeliveryDate;
        private Label lblSupplierAdd2;
        private TextEdit txtSupplierAdd2;
        private Label lblPODate;
        private Label lblPONo;
        private Label lblSupplierAdd1;
        private TextEdit txtSupplierAdd1;
        private Label lblPOSupplierName;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public AddEditPurchaseOrder()
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
            this.grpPO = new DevExpress.XtraEditors.GroupControl();
            this.bteSupplierName = new DevExpress.XtraEditors.ButtonEdit();
            this.chkPOStatus = new DevExpress.XtraEditors.CheckEdit();
            this.memoNotes = new DevExpress.XtraEditors.MemoEdit();
            this.txtShipTo = new DevExpress.XtraEditors.TextEdit();
            this.lblPONote = new System.Windows.Forms.Label();
            this.lblPOShipTo = new System.Windows.Forms.Label();
            this.txtTotalAmt = new DevExpress.XtraEditors.TextEdit();
            this.lblPOTotalAmt = new System.Windows.Forms.Label();
            this.cbPOType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtDeliveryDate = new DevExpress.XtraEditors.TextEdit();
            this.txtPODate = new DevExpress.XtraEditors.TextEdit();
            this.lblSupplierPhone = new System.Windows.Forms.Label();
            this.txtPONo = new DevExpress.XtraEditors.TextEdit();
            this.txtSupplierPhone = new DevExpress.XtraEditors.TextEdit();
            this.lblPOType = new System.Windows.Forms.Label();
            this.lblPODeliveryDate = new System.Windows.Forms.Label();
            this.lblSupplierAdd2 = new System.Windows.Forms.Label();
            this.txtSupplierAdd2 = new DevExpress.XtraEditors.TextEdit();
            this.lblPODate = new System.Windows.Forms.Label();
            this.lblPONo = new System.Windows.Forms.Label();
            this.lblSupplierAdd1 = new System.Windows.Forms.Label();
            this.txtSupplierAdd1 = new DevExpress.XtraEditors.TextEdit();
            this.lblPOSupplierName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grpPO)).BeginInit();
            this.grpPO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteSupplierName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPOStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPOType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPODate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPONo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierAdd2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierAdd1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPO
            // 
            this.grpPO.Controls.Add(this.bteSupplierName);
            this.grpPO.Controls.Add(this.chkPOStatus);
            this.grpPO.Controls.Add(this.memoNotes);
            this.grpPO.Controls.Add(this.txtShipTo);
            this.grpPO.Controls.Add(this.lblPONote);
            this.grpPO.Controls.Add(this.lblPOShipTo);
            this.grpPO.Controls.Add(this.txtTotalAmt);
            this.grpPO.Controls.Add(this.lblPOTotalAmt);
            this.grpPO.Controls.Add(this.cbPOType);
            this.grpPO.Controls.Add(this.txtDeliveryDate);
            this.grpPO.Controls.Add(this.txtPODate);
            this.grpPO.Controls.Add(this.lblSupplierPhone);
            this.grpPO.Controls.Add(this.txtPONo);
            this.grpPO.Controls.Add(this.txtSupplierPhone);
            this.grpPO.Controls.Add(this.lblPOType);
            this.grpPO.Controls.Add(this.lblPODeliveryDate);
            this.grpPO.Controls.Add(this.lblSupplierAdd2);
            this.grpPO.Controls.Add(this.txtSupplierAdd2);
            this.grpPO.Controls.Add(this.lblPODate);
            this.grpPO.Controls.Add(this.lblPONo);
            this.grpPO.Controls.Add(this.lblSupplierAdd1);
            this.grpPO.Controls.Add(this.txtSupplierAdd1);
            this.grpPO.Controls.Add(this.lblPOSupplierName);
            this.grpPO.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPurchaseOrderGroup", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.grpPO.Location = new System.Drawing.Point(12, 1);
            this.grpPO.Name = "grpPO";
            this.grpPO.Size = new System.Drawing.Size(637, 227);
            this.grpPO.TabIndex = 115;
            this.grpPO.Text = global::Inventory.Properties.Settings.Default.strPurchaseOrderGroup;
            // 
            // bteSupplierName
            // 
            this.bteSupplierName.Location = new System.Drawing.Point(414, 31);
            this.bteSupplierName.Name = "bteSupplierName";
            this.bteSupplierName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteSupplierName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.bteSupplierName.Size = new System.Drawing.Size(201, 21);
            this.bteSupplierName.TabIndex = 9;
            // 
            // chkPOStatus
            // 
            this.chkPOStatus.Location = new System.Drawing.Point(23, 200);
            this.chkPOStatus.Name = "chkPOStatus";
            this.chkPOStatus.Properties.Caption = "View Status";
            this.chkPOStatus.Size = new System.Drawing.Size(108, 19);
            this.chkPOStatus.TabIndex = 8;
            // 
            // memoNotes
            // 
            this.memoNotes.Location = new System.Drawing.Point(366, 139);
            this.memoNotes.Name = "memoNotes";
            this.memoNotes.Size = new System.Drawing.Size(248, 80);
            this.memoNotes.TabIndex = 14;
            // 
            // txtShipTo
            // 
            this.txtShipTo.Location = new System.Drawing.Point(116, 135);
            this.txtShipTo.Name = "txtShipTo";
            this.txtShipTo.Size = new System.Drawing.Size(125, 21);
            this.txtShipTo.TabIndex = 5;
            // 
            // lblPONote
            // 
            this.lblPONote.AutoSize = true;
            this.lblPONote.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPurchaseOrderNote", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPONote.Location = new System.Drawing.Point(300, 141);
            this.lblPONote.Name = "lblPONote";
            this.lblPONote.Size = new System.Drawing.Size(39, 14);
            this.lblPONote.TabIndex = 48;
            this.lblPONote.Text = global::Inventory.Properties.Settings.Default.strPurchaseOrderNote;
            // 
            // lblPOShipTo
            // 
            this.lblPOShipTo.AutoSize = true;
            this.lblPOShipTo.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPurchaseOrderShipTo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPOShipTo.Location = new System.Drawing.Point(20, 138);
            this.lblPOShipTo.Name = "lblPOShipTo";
            this.lblPOShipTo.Size = new System.Drawing.Size(49, 14);
            this.lblPOShipTo.TabIndex = 30;
            this.lblPOShipTo.Text = global::Inventory.Properties.Settings.Default.strPurchaseOrderShipTo;
            // 
            // txtTotalAmt
            // 
            this.txtTotalAmt.Location = new System.Drawing.Point(116, 161);
            this.txtTotalAmt.Name = "txtTotalAmt";
            this.txtTotalAmt.Properties.Mask.EditMask = "n2";
            this.txtTotalAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalAmt.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotalAmt.Size = new System.Drawing.Size(125, 21);
            this.txtTotalAmt.TabIndex = 7;
            // 
            // lblPOTotalAmt
            // 
            this.lblPOTotalAmt.AutoSize = true;
            this.lblPOTotalAmt.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPurchaseOrderTotalAmt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPOTotalAmt.Location = new System.Drawing.Point(20, 164);
            this.lblPOTotalAmt.Name = "lblPOTotalAmt";
            this.lblPOTotalAmt.Size = new System.Drawing.Size(62, 14);
            this.lblPOTotalAmt.TabIndex = 52;
            this.lblPOTotalAmt.Text = global::Inventory.Properties.Settings.Default.strPurchaseOrderTotalAmt;
            // 
            // cbPOType
            // 
            this.cbPOType.Location = new System.Drawing.Point(116, 83);
            this.cbPOType.Name = "cbPOType";
            this.cbPOType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPOType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbPOType.Size = new System.Drawing.Size(125, 21);
            this.cbPOType.TabIndex = 3;
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Location = new System.Drawing.Point(116, 109);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.Properties.DisplayFormat.FormatString = "d";
            this.txtDeliveryDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDeliveryDate.Properties.Mask.EditMask = "d";
            this.txtDeliveryDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtDeliveryDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDeliveryDate.Size = new System.Drawing.Size(125, 21);
            this.txtDeliveryDate.TabIndex = 4;
            this.txtDeliveryDate.ToolTip = "Date must >= 1/1/1753 and  <= 12/31/9999";
            // 
            // txtPODate
            // 
            this.txtPODate.Location = new System.Drawing.Point(116, 57);
            this.txtPODate.Name = "txtPODate";
            this.txtPODate.Properties.DisplayFormat.FormatString = "d";
            this.txtPODate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtPODate.Properties.Mask.EditMask = "d";
            this.txtPODate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtPODate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPODate.Size = new System.Drawing.Size(125, 21);
            this.txtPODate.TabIndex = 2;
            this.txtPODate.ToolTip = "Date must >= 1/1/1753 and  <= 12/31/9999";
            // 
            // lblSupplierPhone
            // 
            this.lblSupplierPhone.AutoSize = true;
            this.lblSupplierPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPurchaseOrderSupplierPhone", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSupplierPhone.Location = new System.Drawing.Point(300, 114);
            this.lblSupplierPhone.Name = "lblSupplierPhone";
            this.lblSupplierPhone.Size = new System.Drawing.Size(89, 14);
            this.lblSupplierPhone.TabIndex = 47;
            this.lblSupplierPhone.Text = global::Inventory.Properties.Settings.Default.strPurchaseOrderSupplierPhone;
            // 
            // txtPONo
            // 
            this.txtPONo.Location = new System.Drawing.Point(116, 31);
            this.txtPONo.Name = "txtPONo";
            this.txtPONo.Properties.Mask.EditMask = "[0-9]{0,}";
            this.txtPONo.Size = new System.Drawing.Size(125, 21);
            this.txtPONo.TabIndex = 1;
            // 
            // txtSupplierPhone
            // 
            this.txtSupplierPhone.Location = new System.Drawing.Point(414, 111);
            this.txtSupplierPhone.Name = "txtSupplierPhone";
            this.txtSupplierPhone.Properties.Mask.EditMask = "([(][0-9]+[)])?[0-9]+";
            this.txtSupplierPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSupplierPhone.Size = new System.Drawing.Size(200, 21);
            this.txtSupplierPhone.TabIndex = 13;
            // 
            // lblPOType
            // 
            this.lblPOType.AutoSize = true;
            this.lblPOType.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPurchaseOrderType", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPOType.Location = new System.Drawing.Point(20, 85);
            this.lblPOType.Name = "lblPOType";
            this.lblPOType.Size = new System.Drawing.Size(55, 14);
            this.lblPOType.TabIndex = 78;
            this.lblPOType.Text = global::Inventory.Properties.Settings.Default.strPurchaseOrderType;
            // 
            // lblPODeliveryDate
            // 
            this.lblPODeliveryDate.AutoSize = true;
            this.lblPODeliveryDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPurchaseOrderDevDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPODeliveryDate.Location = new System.Drawing.Point(20, 111);
            this.lblPODeliveryDate.Name = "lblPODeliveryDate";
            this.lblPODeliveryDate.Size = new System.Drawing.Size(79, 14);
            this.lblPODeliveryDate.TabIndex = 13;
            this.lblPODeliveryDate.Text = global::Inventory.Properties.Settings.Default.strPurchaseOrderDevDate;
            // 
            // lblSupplierAdd2
            // 
            this.lblSupplierAdd2.AutoSize = true;
            this.lblSupplierAdd2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPurchaseOrderSupplierAdd2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSupplierAdd2.Location = new System.Drawing.Point(300, 85);
            this.lblSupplierAdd2.Name = "lblSupplierAdd2";
            this.lblSupplierAdd2.Size = new System.Drawing.Size(108, 14);
            this.lblSupplierAdd2.TabIndex = 50;
            this.lblSupplierAdd2.Text = global::Inventory.Properties.Settings.Default.strPurchaseOrderSupplierAdd2;
            // 
            // txtSupplierAdd2
            // 
            this.txtSupplierAdd2.Location = new System.Drawing.Point(414, 82);
            this.txtSupplierAdd2.Name = "txtSupplierAdd2";
            this.txtSupplierAdd2.Size = new System.Drawing.Size(200, 21);
            this.txtSupplierAdd2.TabIndex = 11;
            // 
            // lblPODate
            // 
            this.lblPODate.AutoSize = true;
            this.lblPODate.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPurchaseOrderDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPODate.Location = new System.Drawing.Point(20, 60);
            this.lblPODate.Name = "lblPODate";
            this.lblPODate.Size = new System.Drawing.Size(53, 14);
            this.lblPODate.TabIndex = 11;
            this.lblPODate.Text = global::Inventory.Properties.Settings.Default.strPurchaseOrderDate;
            // 
            // lblPONo
            // 
            this.lblPONo.AutoSize = true;
            this.lblPONo.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPurchaseOrderNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPONo.Location = new System.Drawing.Point(20, 34);
            this.lblPONo.Name = "lblPONo";
            this.lblPONo.Size = new System.Drawing.Size(61, 14);
            this.lblPONo.TabIndex = 9;
            this.lblPONo.Text = global::Inventory.Properties.Settings.Default.strPurchaseOrderNo;
            // 
            // lblSupplierAdd1
            // 
            this.lblSupplierAdd1.AutoSize = true;
            this.lblSupplierAdd1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPurchaseOrderSupplierAdd1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSupplierAdd1.Location = new System.Drawing.Point(300, 60);
            this.lblSupplierAdd1.Name = "lblSupplierAdd1";
            this.lblSupplierAdd1.Size = new System.Drawing.Size(108, 14);
            this.lblSupplierAdd1.TabIndex = 45;
            this.lblSupplierAdd1.Text = global::Inventory.Properties.Settings.Default.strPurchaseOrderSupplierAdd1;
            // 
            // txtSupplierAdd1
            // 
            this.txtSupplierAdd1.Location = new System.Drawing.Point(414, 57);
            this.txtSupplierAdd1.Name = "txtSupplierAdd1";
            this.txtSupplierAdd1.Size = new System.Drawing.Size(200, 21);
            this.txtSupplierAdd1.TabIndex = 10;
            // 
            // lblPOSupplierName
            // 
            this.lblPOSupplierName.AutoSize = true;
            this.lblPOSupplierName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strPurchaseOrderSupplierName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPOSupplierName.Location = new System.Drawing.Point(300, 34);
            this.lblPOSupplierName.Name = "lblPOSupplierName";
            this.lblPOSupplierName.Size = new System.Drawing.Size(85, 14);
            this.lblPOSupplierName.TabIndex = 41;
            this.lblPOSupplierName.Text = global::Inventory.Properties.Settings.Default.strPurchaseOrderSupplierName;
            // 
            // AddEditPurchaseOrder
            // 
            this.ClientSize = new System.Drawing.Size(656, 446);
            this.Controls.Add(this.grpPO);
            this.Name = "AddEditPurchaseOrder";
            this.Text = "AddEditPurchaseOrder";
            ((System.ComponentModel.ISupportInitialize)(this.grpPO)).EndInit();
            this.grpPO.ResumeLayout(false);
            this.grpPO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteSupplierName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPOStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPOType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPODate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPONo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierAdd2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierAdd1.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}

