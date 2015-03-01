using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;

namespace SqlTest
{
    /// <summary>
    /// Summary description for frmPrediction.
    /// </summary>
    public class frmPrediction : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton btnBack;
        private SimpleButton btnOk;
        private SimpleButton btnCancel;
        private SimpleButton btnAdd;
        public TabControl tabTablesViews;
        private TabPage tabTableAndViews;
        private Label label3;
        public ListBoxControl lstFields;
        private RadioGroup rdOperator;
        private TabPage tabNumber;
        private MemoEdit mmoEdit;
        private Label label5;
        public TextEdit txtNumber;
        private SimpleButton btnRemoveFromList;
        private SimpleButton btnAddToList;
        private Label label1;
        private TextEdit txtConditionName;
        public DataGridView grCondition;
        private Label label10;
        private SimpleButton btnUp;
        private SimpleButton btnDown;
        private ComboBoxEdit cbFormatCurrency;
        private Label label2;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmPrediction()
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
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.tabTablesViews = new System.Windows.Forms.TabControl();
            this.tabTableAndViews = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lstFields = new DevExpress.XtraEditors.ListBoxControl();
            this.tabNumber = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.rdOperator = new DevExpress.XtraEditors.RadioGroup();
            this.mmoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.btnRemoveFromList = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddToList = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConditionName = new DevExpress.XtraEditors.TextEdit();
            this.grCondition = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUp = new DevExpress.XtraEditors.SimpleButton();
            this.btnDown = new DevExpress.XtraEditors.SimpleButton();
            this.cbFormatCurrency = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.tabTablesViews.SuspendLayout();
            this.tabTableAndViews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstFields)).BeginInit();
            this.tabNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdOperator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConditionName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFormatCurrency.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnBack.Location = new System.Drawing.Point(282, 493);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 28);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "&Back";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(362, 493);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(74, 28);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "&Next";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnCancel.Location = new System.Drawing.Point(442, 493);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "&Cancel";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(442, 92);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 28);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabTablesViews
            // 
            this.tabTablesViews.Controls.Add(this.tabTableAndViews);
            this.tabTablesViews.Controls.Add(this.tabNumber);
            this.tabTablesViews.Location = new System.Drawing.Point(12, 129);
            this.tabTablesViews.Name = "tabTablesViews";
            this.tabTablesViews.SelectedIndex = 0;
            this.tabTablesViews.Size = new System.Drawing.Size(502, 159);
            this.tabTablesViews.TabIndex = 23;
            // 
            // tabTableAndViews
            // 
            this.tabTableAndViews.BackColor = System.Drawing.Color.Transparent;
            this.tabTableAndViews.Controls.Add(this.label3);
            this.tabTableAndViews.Controls.Add(this.lstFields);
            this.tabTableAndViews.Location = new System.Drawing.Point(4, 23);
            this.tabTableAndViews.Name = "tabTableAndViews";
            this.tabTableAndViews.Padding = new System.Windows.Forms.Padding(3);
            this.tabTableAndViews.Size = new System.Drawing.Size(494, 132);
            this.tabTableAndViews.TabIndex = 0;
            this.tabTableAndViews.Text = "Table And View";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fields:";
            // 
            // lstFields
            // 
            this.lstFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFields.Location = new System.Drawing.Point(89, 6);
            this.lstFields.Name = "lstFields";
            this.lstFields.Size = new System.Drawing.Size(399, 120);
            this.lstFields.TabIndex = 5;
            this.lstFields.DoubleClick += new System.EventHandler(this.btnAdd_Click);
            this.lstFields.SelectedIndexChanged += new System.EventHandler(this.lstTableFields_SelectedIndexChanged);
            // 
            // tabNumber
            // 
            this.tabNumber.Controls.Add(this.label5);
            this.tabNumber.Controls.Add(this.txtNumber);
            this.tabNumber.Location = new System.Drawing.Point(4, 23);
            this.tabNumber.Name = "tabNumber";
            this.tabNumber.Padding = new System.Windows.Forms.Padding(3);
            this.tabNumber.Size = new System.Drawing.Size(494, 132);
            this.tabNumber.TabIndex = 2;
            this.tabNumber.Text = "Number";
            this.tabNumber.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Number:";
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumber.Location = new System.Drawing.Point(89, 11);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(399, 20);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.EditValueChanged += new System.EventHandler(this.txtNumber_EditValueChanged);
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            this.txtNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumber_KeyDown);
            // 
            // rdOperator
            // 
            this.rdOperator.Location = new System.Drawing.Point(12, 87);
            this.rdOperator.Name = "rdOperator";
            this.rdOperator.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "*"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "/"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "+"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "-"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "("),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, ")")});
            this.rdOperator.Size = new System.Drawing.Size(399, 33);
            this.rdOperator.TabIndex = 24;
            // 
            // mmoEdit
            // 
            this.mmoEdit.Location = new System.Drawing.Point(12, 12);
            this.mmoEdit.Name = "mmoEdit";
            this.mmoEdit.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.mmoEdit.Properties.WordWrap = false;
            this.mmoEdit.Size = new System.Drawing.Size(502, 66);
            this.mmoEdit.TabIndex = 25;
            // 
            // btnRemoveFromList
            // 
            this.btnRemoveFromList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveFromList.Location = new System.Drawing.Point(440, 328);
            this.btnRemoveFromList.Name = "btnRemoveFromList";
            this.btnRemoveFromList.Size = new System.Drawing.Size(74, 28);
            this.btnRemoveFromList.TabIndex = 27;
            this.btnRemoveFromList.Text = "&Remove";
            this.btnRemoveFromList.Click += new System.EventHandler(this.btnRemoveFromList_Click);
            // 
            // btnAddToList
            // 
            this.btnAddToList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToList.Location = new System.Drawing.Point(440, 294);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(74, 28);
            this.btnAddToList.TabIndex = 26;
            this.btnAddToList.Text = "&Add";
            this.btnAddToList.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Prediction Name:";
            // 
            // txtConditionName
            // 
            this.txtConditionName.Location = new System.Drawing.Point(105, 298);
            this.txtConditionName.Name = "txtConditionName";
            this.txtConditionName.Size = new System.Drawing.Size(306, 20);
            this.txtConditionName.TabIndex = 29;
            // 
            // grCondition
            // 
            this.grCondition.AllowUserToAddRows = false;
            this.grCondition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grCondition.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grCondition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grCondition.Location = new System.Drawing.Point(14, 362);
            this.grCondition.MultiSelect = false;
            this.grCondition.Name = "grCondition";
            this.grCondition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grCondition.Size = new System.Drawing.Size(502, 125);
            this.grCondition.TabIndex = 30;
            this.grCondition.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grCondition_CellDoubleClick);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(108, 500);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "*Note: Double Click on List to Edit";
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Location = new System.Drawing.Point(10, 493);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(42, 28);
            this.btnUp.TabIndex = 32;
            this.btnUp.Text = "&Up";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Location = new System.Drawing.Point(58, 493);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(42, 28);
            this.btnDown.TabIndex = 33;
            this.btnDown.Text = "&Down";
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // cbFormatCurrency
            // 
            this.cbFormatCurrency.Location = new System.Drawing.Point(105, 328);
            this.cbFormatCurrency.Name = "cbFormatCurrency";
            this.cbFormatCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFormatCurrency.Properties.Items.AddRange(new object[] {
            "00.0",
            "00.00",
            "00.000",
            "00.0000",
            "0.0",
            "0.00",
            "0.000",
            "0.0000",
            "(#).#",
            "(#).##",
            "(#).###",
            "(#).####",
            "0,0",
            "0%",
            "Custom"});
            this.cbFormatCurrency.Size = new System.Drawing.Size(306, 25);
            this.cbFormatCurrency.TabIndex = 34;
            this.cbFormatCurrency.SelectedIndexChanged += new System.EventHandler(this.cbFormatCurrency_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Format:";
            // 
            // frmPrediction
            // 
            this.ClientSize = new System.Drawing.Size(529, 530);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFormatCurrency);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grCondition);
            this.Controls.Add(this.txtConditionName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveFromList);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.mmoEdit);
            this.Controls.Add(this.rdOperator);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabTablesViews);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrediction";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prediction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrediction_FormClosing);
            this.Load += new System.EventHandler(this.frmPrediction_Load);
            this.tabTablesViews.ResumeLayout(false);
            this.tabTableAndViews.ResumeLayout(false);
            this.tabTableAndViews.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstFields)).EndInit();
            this.tabNumber.ResumeLayout(false);
            this.tabNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdOperator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConditionName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFormatCurrency.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public DataTable dt;
        private bool edittingMode = false;
        private int oldSelectedRow = -1;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!btnAdd.Enabled) return;
            switch (tabTablesViews.SelectedIndex)
            {
                case 0:
                    if (lstFields.SelectedItem == null)
                    {
                        MessageBox.Show("You have to select field first");
                        return;
                    }
                    break;
                case 1:
                    if (txtNumber.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("You have to input number for this operation");
                        return;
                    }
                    break;
            }
            if (mmoEdit.Text.Trim().Length != 0)
            {
                mmoEdit.Text += " " + rdOperator.Properties.Items[rdOperator.SelectedIndex].Description + " ";
                string s = rdOperator.Properties.Items[rdOperator.SelectedIndex].Description;
                if (s == "(" || s == ")")
                {
                    txtNumber.Text = "";
                    return;
                }
            }
            switch (tabTablesViews.SelectedIndex)
            {
                case 0: //tables                    
                    mmoEdit.Text += lstFields.SelectedValue.ToString();
                    break;
                case 1: //numbers
                    mmoEdit.Text += txtNumber.Text;
                    break;
            }
            txtNumber.Text = "";           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            foreach (DataRow r in dt.Rows)
            {
                if (r["Prediction Alias"].ToString().ToUpper() == txtConditionName.Text.Trim().ToUpper())
                {
                    if (!(edittingMode && r == dt.Rows[oldSelectedRow]))
                    {
                        MessageBox.Show("This alias exists, choose another please");
                        txtConditionName.Select();
                        return;
                    }
                }
            }
            if (mmoEdit.Text.Trim().Length == 0)
            {
                MessageBox.Show("No condition to add");
                return;
            }
            if (txtConditionName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Prediction Name must not empty");
                txtConditionName.Select();
                return;
            }
            DataRow row;
            if (edittingMode)
            {
                row = dt.Rows[oldSelectedRow];
                row["Prediction Alias"] = txtConditionName.Text.Trim();
                row["Formula"] = mmoEdit.Text.Trim();
                row["Format"] = cbFormatCurrency.Text;
                disableEdittingMode();
                return;
            }
            row = dt.NewRow();
            row["Prediction Alias"] = txtConditionName.Text.Trim();
            row["Formula"] = mmoEdit.Text.Trim();
            row["Format"] = cbFormatCurrency.Text;
            dt.Rows.Add(row);
            mmoEdit.Text = "";
            txtNumber.Text = "";
            txtConditionName.Text = "";  
        }

        private void disableEdittingMode()
        {
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnBack.Enabled = true;
            btnOk.Enabled = true;
            btnCancel.Enabled = true;
            btnAddToList.Text = "Add";
            btnRemoveFromList.Text = "Remove";
            mmoEdit.Text = "";
            cbFormatCurrency.Text = "";
            txtConditionName.Text = "";
            edittingMode = false;
        }

        private void btnRemoveFromList_Click(object sender, EventArgs e)
        {
            if (edittingMode)
            {
                disableEdittingMode();
                return;
            }
            else if (grCondition.SelectedRows.Count != 0)
            {
                dt.Rows.RemoveAt(grCondition.SelectedRows[0].Index);
            }
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbViews_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lstTableFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            byte colType;
            if (lstFields.SelectedValue == null)
            {                
                return;
            }
            try
            {
                String tblName = lstFields.SelectedValue.ToString();
                String fieldName = tblName;
                tblName = tblName.Substring(0, tblName.LastIndexOf('.'));
                fieldName = fieldName.Substring(tblName.Length + 1);

                sql = "select systypes.name from syscolumns join systypes on syscolumns.xtype = systypes.xtype where id=object_id('" + tblName + "') and (syscolumns.name = '" + fieldName + "')";

                if (DbManager.OpenSQL(sql))
                {
                    DbManager.reader.Read();
                    string type = DbManager.reader[0].ToString();
                    colType = frmCriterial.GetFieldGroup(type.ToUpper());
                    switch (colType)
                    {
                        case frmCriterial.TYPE_CURRENCY:
                        case frmCriterial.TYPE_NUMBER:
                            btnAdd.Enabled = true;
                            break;
                        default:
                            btnAdd.Enabled = false;
                            break;
                    }
                }
                else
                {
                    btnAdd.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtNumber_EditValueChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = txtNumber.Text.Length > 0;
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        public void newDataTable()
        {
            dt = new DataTable("Prediction");
            dt.Columns.Add("Prediction Alias");
            dt.Columns.Add("Formula");
            dt.Columns.Add("Format");
            grCondition.DataSource = dt;
        }

        private void frmPrediction_Load(object sender, EventArgs e)
        {
            if (dt == null)
            {
                newDataTable();
            }
            frmOrderBy frm = (Tag as frmMain).fOrderBy;
            ArrayList arr = frm.arr;
            lstFields.Items.Clear();
            foreach (Record r in arr)
            {                
                byte colType = frmCriterial.GetFieldGroup(r.Type);
                if (colType == frmCriterial.TYPE_NUMBER || colType == frmCriterial.TYPE_CURRENCY) lstFields.Items.Add(r.Field);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            frmOrderBy frm = (Tag as frmMain).fOrderBy;
            String sql = "";
            foreach (DataRow r in dt.Rows)
            {
                if (sql.Length > 0) sql += ", ";
                sql += "SUM(" + r["Formula"] + ") AS [" + r["Prediction Alias"] + "]";
            }
            frmPredictionPreview fPre = (Tag as frmMain).fPredictionPreview;
            if (fPre.dt != null) fPre.dt.Rows.Clear();
            if (dt.Rows.Count == 0)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {                
                sql = "SELECT " + sql + " " + frm.otherStatement;
                try
                {
                    if (fPre.dt == null)
                    {
                        fPre.dt = new DataTable("PredictionPreview");
                        fPre.dt.Columns.Add("Prediction");
                        fPre.dt.Columns.Add("Value");
                    }
                    if (DbManager.OpenSQL(sql))
                    {
                        DbManager.reader.Read();
                        foreach (DataRow r in dt.Rows)
                        {
                            DataRow newRow = fPre.dt.NewRow();
                            newRow["Prediction"] = r["Prediction Alias"].ToString();
                            newRow["Value"] = DbManager.reader[r["Prediction Alias"].ToString()].ToString();
                            fPre.dt.Rows.Add(newRow);
                        }
                        fPre.sql = sql;
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Error when open sql statement, perhaps some fields contains invalid data or you input invalid formula. Check it again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (grCondition.SelectedRows.Count == 0) return;
            int id = grCondition.SelectedRows[0].Index;
            if (id == 0) return;
            DataRow r = dt.NewRow();
            r["Prediction Alias"] = dt.Rows[id]["Prediction Alias"].ToString();
            r["Formula"] = dt.Rows[id]["Formula"].ToString();
            r["Format"] = dt.Rows[id]["Format"].ToString();
            dt.Rows.RemoveAt(id);
            dt.Rows.InsertAt(r, id - 1);
            grCondition.Rows[id - 1].Selected = true;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (grCondition.SelectedRows.Count == 0) return;
            int id = grCondition.SelectedRows[0].Index;
            if (id == dt.Rows.Count - 1) return;
            DataRow r = dt.NewRow();
            r["Prediction Alias"] = dt.Rows[id]["Prediction Alias"].ToString();
            r["Formula"] = dt.Rows[id]["Formula"].ToString();
            r["Format"] = dt.Rows[id]["Format"].ToString();
            dt.Rows.RemoveAt(id);
            dt.Rows.InsertAt(r, id + 1);
            grCondition.Rows[id + 1].Selected = true;
        }

        private void cbFormatCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFormatCurrency.Text == "Custom")
            {
                frmFormatNumber fFormatNumber = new frmFormatNumber();
                if (fFormatNumber.ShowDialog() == DialogResult.OK)
                {
                    cbFormatCurrency.Text = fFormatNumber.txtFormat.Text;
                }
                else
                {
                    cbFormatCurrency.Text = "";
                }
            }
        }

        private void grCondition_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            edittingMode = true;
            int id = grCondition.SelectedRows[0].Index;
            oldSelectedRow = id;
            DataRow r = dt.Rows[id];
            cbFormatCurrency.Text = r["Format"].ToString();
            txtConditionName.Text = r["Prediction Alias"].ToString();
            mmoEdit.Text = r["Formula"].ToString();
            btnAddToList.Text = "OK";
            btnRemoveFromList.Text = "Cancel";
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnBack.Enabled = false;
            btnOk.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void frmPrediction_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = edittingMode;
        }
    }
}

