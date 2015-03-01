using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Inventory.DataModels.StockTake;
using Inventory.DataModels;

namespace Inventory.Forms.StockTake
{
    /// <summary>
    /// Summary description for StockVariance.
    /// </summary>
    public class StockVariance : DevExpress.XtraEditors.XtraForm
    {
        private Label lblStockTakeName;
        private ComboBoxEdit cboStockTakeName;
        private GroupControl groupControl5;
        private TextEdit txtVariance;
        private Label label3;
        private Label lblVariance;
        private Label lblSortBy;
        private ComboBoxEdit cboSortBy;
        private CheckEdit chkExcludeBoth;
        private CheckEdit chkOnlyMissing;
        private Label lblExcludeBothZero;
        private Label lblOnlyMissingItems;
        private SimpleButton btnRun;
        private SimpleButton btnClose;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public StockVariance()
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
            this.lblStockTakeName = new System.Windows.Forms.Label();
            this.cboStockTakeName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.chkExcludeBoth = new DevExpress.XtraEditors.CheckEdit();
            this.chkOnlyMissing = new DevExpress.XtraEditors.CheckEdit();
            this.txtVariance = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.lblExcludeBothZero = new System.Windows.Forms.Label();
            this.lblOnlyMissingItems = new System.Windows.Forms.Label();
            this.lblVariance = new System.Windows.Forms.Label();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.cboSortBy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnRun = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cboStockTakeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkExcludeBoth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOnlyMissing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVariance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortBy.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStockTakeName
            // 
            this.lblStockTakeName.AutoSize = true;
            this.lblStockTakeName.Location = new System.Drawing.Point(21, 18);
            this.lblStockTakeName.Name = "lblStockTakeName";
            this.lblStockTakeName.Size = new System.Drawing.Size(108, 14);
            this.lblStockTakeName.TabIndex = 25;
            this.lblStockTakeName.Text = "Stock Take Name:";
            // 
            // cboStockTakeName
            // 
            this.cboStockTakeName.Location = new System.Drawing.Point(151, 14);
            this.cboStockTakeName.Name = "cboStockTakeName";
            this.cboStockTakeName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStockTakeName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboStockTakeName.Size = new System.Drawing.Size(206, 23);
            this.cboStockTakeName.TabIndex = 1;
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.chkExcludeBoth);
            this.groupControl5.Controls.Add(this.chkOnlyMissing);
            this.groupControl5.Controls.Add(this.txtVariance);
            this.groupControl5.Controls.Add(this.label3);
            this.groupControl5.Controls.Add(this.lblExcludeBothZero);
            this.groupControl5.Controls.Add(this.lblOnlyMissingItems);
            this.groupControl5.Controls.Add(this.lblVariance);
            this.groupControl5.Controls.Add(this.lblSortBy);
            this.groupControl5.Controls.Add(this.cboSortBy);
            this.groupControl5.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strNameAndAddr", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupControl5.Location = new System.Drawing.Point(12, 53);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(419, 182);
            this.groupControl5.TabIndex = 89;
            this.groupControl5.Text = global::Inventory.Properties.Settings.Default.strNameAndAddr;
            // 
            // chkExcludeBoth
            // 
            this.chkExcludeBoth.Location = new System.Drawing.Point(155, 136);
            this.chkExcludeBoth.Name = "chkExcludeBoth";
            this.chkExcludeBoth.Properties.Caption = "";
            this.chkExcludeBoth.Size = new System.Drawing.Size(75, 19);
            this.chkExcludeBoth.TabIndex = 5;
            // 
            // chkOnlyMissing
            // 
            this.chkOnlyMissing.Location = new System.Drawing.Point(155, 106);
            this.chkOnlyMissing.Name = "chkOnlyMissing";
            this.chkOnlyMissing.Properties.Caption = "";
            this.chkOnlyMissing.Size = new System.Drawing.Size(75, 19);
            this.chkOnlyMissing.TabIndex = 4;
            // 
            // txtVariance
            // 
            this.txtVariance.EditValue = "0";
            this.txtVariance.Location = new System.Drawing.Point(139, 65);
            this.txtVariance.Name = "txtVariance";
            this.txtVariance.Size = new System.Drawing.Size(177, 23);
            this.txtVariance.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 14);
            this.label3.TabIndex = 25;
            this.label3.Text = "%";
            // 
            // lblExcludeBothZero
            // 
            this.lblExcludeBothZero.AutoSize = true;
            this.lblExcludeBothZero.Location = new System.Drawing.Point(40, 138);
            this.lblExcludeBothZero.Name = "lblExcludeBothZero";
            this.lblExcludeBothZero.Size = new System.Drawing.Size(112, 14);
            this.lblExcludeBothZero.TabIndex = 25;
            this.lblExcludeBothZero.Text = "Exclude Both Zero:";
            // 
            // lblOnlyMissingItems
            // 
            this.lblOnlyMissingItems.AutoSize = true;
            this.lblOnlyMissingItems.Location = new System.Drawing.Point(40, 106);
            this.lblOnlyMissingItems.Name = "lblOnlyMissingItems";
            this.lblOnlyMissingItems.Size = new System.Drawing.Size(111, 14);
            this.lblOnlyMissingItems.TabIndex = 25;
            this.lblOnlyMissingItems.Text = "Only Missing Items:";
            // 
            // lblVariance
            // 
            this.lblVariance.AutoSize = true;
            this.lblVariance.Location = new System.Drawing.Point(40, 68);
            this.lblVariance.Name = "lblVariance";
            this.lblVariance.Size = new System.Drawing.Size(73, 14);
            this.lblVariance.TabIndex = 25;
            this.lblVariance.Text = "% Variance:";
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Location = new System.Drawing.Point(40, 37);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(51, 14);
            this.lblSortBy.TabIndex = 25;
            this.lblSortBy.Text = "Sort by:";
            // 
            // cboSortBy
            // 
            this.cboSortBy.Location = new System.Drawing.Point(139, 34);
            this.cboSortBy.Name = "cboSortBy";
            this.cboSortBy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSortBy.Properties.Items.AddRange(new object[] {
            "",
            "Warehouse",
            "Location",
            "ProductID",
            "Product Name",
            "Current Quantity",
            "Counted Quantity",
            "Variance %"});
            this.cboSortBy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboSortBy.Size = new System.Drawing.Size(175, 23);
            this.cboSortBy.TabIndex = 2;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(129, 250);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "&Run";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(239, 250);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            // 
            // StockVariance
            // 
            this.AcceptButton = this.btnRun;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(443, 283);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.cboStockTakeName);
            this.Controls.Add(this.lblStockTakeName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockVariance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print Variance";
            this.Load += new System.EventHandler(this.StockVariance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboStockTakeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkExcludeBoth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOnlyMissing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVariance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSortBy.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        //Stock Transfer Model
        private PrintVarianceModel model = new PrintVarianceModel();

        /// <summary>
        /// Get/set data model StockTransfer 
        /// </summary>
        public PrintVarianceModel DataModel
        {
            get { return model; }
            set { model = value; }
        }

        public void BindData()
        {
            cboStockTakeName.Properties.Items.Clear();
            DataTable dtPhysicalTake = Mediator.GetInstance().GetAllPhysicalTake();
            dtPhysicalTake.DefaultView.Sort = "Name";
            //cboStockTakeName.Properties.Items.Add(new TabItem("", "")); // None family
            foreach (DataRow row in dtPhysicalTake.Rows)
            {
                cboStockTakeName.Properties.Items.Add(new TabItem(row["ID"].ToString(), row["Name"].ToString()));
            }


        }

        /// <summary>
        /// Implement ReadToDataModel
        /// </summary>
        protected void ReadToDataModel()
        {
            model.ID = ((TabItem)cboStockTakeName.SelectedItem).ItemID;
            model.Name = ((TabItem)cboStockTakeName.SelectedItem).ItemName;
            model.SortBy = cboSortBy.Text;
            model.Variance = Convert.ToDecimal(txtVariance.Text);
            model.OnlyMissingItems = chkOnlyMissing.Checked;
            model.ExcludeBothZero = chkExcludeBoth.Checked;
        }
        
        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!Validate()) return;
            ReadToDataModel();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public bool Validate()
        {
            Validator objValidator = new Validator();

            if (cboStockTakeName.SelectedItem == null)
            {
                MessageBox.Show("Please select a Stock Take Name.", Constants.Message.MessageTitle);
                return false;
            }

            if (!objValidator.IsDecimal("% Variance", txtVariance.Text))
            {
                return false;
            }

            return true;
        }

        private void StockVariance_Load(object sender, EventArgs e)
        {
            cboStockTakeName.Focus();
        }
    }
}

