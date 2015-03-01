using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Inventory.Forms.StockTake
{
    /// <summary>
    /// Summary description for PrintInventorySheet.
    /// </summary>
    public class PrintInventorySheet : DevExpress.XtraEditors.XtraForm
    {
        private TextEdit txtQtyTo;
        private Label label6;
        private TextEdit txtQtyFrom;
        private Label lblQtyOnHand;
        private Label lblProductFamily;
        private Label lblProductCategory;
        private Label lblProduct;
        private ComboBoxEdit cboProductFamily;
        private ComboBoxEdit cboProductCategory;
        private ComboBoxEdit cboLocation;
        private Label lblLocation;
        private Label lblWarehouse;
        private ComboBoxEdit cboWarehouse;
        private SimpleButton btnClose;
        private SimpleButton btnPrint;
        private GroupBox groupBox1;
        private TextEdit txtProductName;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public PrintInventorySheet()
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
            this.txtQtyTo = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQtyFrom = new DevExpress.XtraEditors.TextEdit();
            this.lblQtyOnHand = new System.Windows.Forms.Label();
            this.lblProductFamily = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cboProductFamily = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboProductCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboLocation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.cboWarehouse = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtyTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtyFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProductFamily.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProductCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboWarehouse.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQtyTo
            // 
            this.txtQtyTo.Location = new System.Drawing.Point(264, 158);
            this.txtQtyTo.Name = "txtQtyTo";
            this.txtQtyTo.Size = new System.Drawing.Size(100, 20);
            this.txtQtyTo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "To";
            // 
            // txtQtyFrom
            // 
            this.txtQtyFrom.Location = new System.Drawing.Point(133, 158);
            this.txtQtyFrom.Name = "txtQtyFrom";
            this.txtQtyFrom.Size = new System.Drawing.Size(100, 20);
            this.txtQtyFrom.TabIndex = 9;
            // 
            // lblQtyOnHand
            // 
            this.lblQtyOnHand.AutoSize = true;
            this.lblQtyOnHand.Location = new System.Drawing.Point(30, 158);
            this.lblQtyOnHand.Name = "lblQtyOnHand";
            this.lblQtyOnHand.Size = new System.Drawing.Size(94, 13);
            this.lblQtyOnHand.TabIndex = 8;
            this.lblQtyOnHand.Text = "Quantity On-hand";
            // 
            // lblProductFamily
            // 
            this.lblProductFamily.AutoSize = true;
            this.lblProductFamily.Location = new System.Drawing.Point(31, 73);
            this.lblProductFamily.Name = "lblProductFamily";
            this.lblProductFamily.Size = new System.Drawing.Size(77, 13);
            this.lblProductFamily.TabIndex = 5;
            this.lblProductFamily.Text = "Product Family";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Location = new System.Drawing.Point(32, 113);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(92, 13);
            this.lblProductCategory.TabIndex = 4;
            this.lblProductCategory.Text = "Product Category";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(31, 34);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "Product";
            // 
            // cboProductFamily
            // 
            this.cboProductFamily.Location = new System.Drawing.Point(134, 70);
            this.cboProductFamily.Name = "cboProductFamily";
            this.cboProductFamily.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboProductFamily.Size = new System.Drawing.Size(100, 20);
            this.cboProductFamily.TabIndex = 2;
            // 
            // cboProductCategory
            // 
            this.cboProductCategory.Location = new System.Drawing.Point(135, 110);
            this.cboProductCategory.Name = "cboProductCategory";
            this.cboProductCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboProductCategory.Size = new System.Drawing.Size(100, 20);
            this.cboProductCategory.TabIndex = 1;
            // 
            // cboLocation
            // 
            this.cboLocation.Location = new System.Drawing.Point(396, 70);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLocation.Size = new System.Drawing.Size(100, 20);
            this.cboLocation.TabIndex = 24;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(293, 73);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(47, 13);
            this.lblLocation.TabIndex = 23;
            this.lblLocation.Text = "Location";
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Location = new System.Drawing.Point(293, 30);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(62, 13);
            this.lblWarehouse.TabIndex = 22;
            this.lblWarehouse.Text = "Warehouse";
            // 
            // cboWarehouse
            // 
            this.cboWarehouse.Location = new System.Drawing.Point(396, 30);
            this.cboWarehouse.Name = "cboWarehouse";
            this.cboWarehouse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboWarehouse.Size = new System.Drawing.Size(100, 20);
            this.cboWarehouse.TabIndex = 21;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(280, 202);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "&Close";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(179, 202);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Text = "&Run";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboLocation);
            this.groupBox1.Controls.Add(this.lblLocation);
            this.groupBox1.Controls.Add(this.lblWarehouse);
            this.groupBox1.Controls.Add(this.cboWarehouse);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.txtQtyTo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtQtyFrom);
            this.groupBox1.Controls.Add(this.lblQtyOnHand);
            this.groupBox1.Controls.Add(this.lblProductFamily);
            this.groupBox1.Controls.Add(this.lblProductCategory);
            this.groupBox1.Controls.Add(this.lblProduct);
            this.groupBox1.Controls.Add(this.cboProductFamily);
            this.groupBox1.Controls.Add(this.cboProductCategory);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Parameters";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(134, 31);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 0;
            // 
            // PrintInventorySheet
            // 
            this.ClientSize = new System.Drawing.Size(530, 243);
            this.Controls.Add(this.groupBox1);
            this.Name = "PrintInventorySheet";
            this.Text = "PrintInventorySheet";
            ((System.ComponentModel.ISupportInitialize)(this.txtQtyTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtyFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProductFamily.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProductCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboWarehouse.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}

