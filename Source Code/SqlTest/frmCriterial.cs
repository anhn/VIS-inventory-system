using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors.Controls;

namespace SqlTest
{
    /// <summary>
    /// Summary description for frmCriterial.
    /// </summary>
    public class frmCriterial : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton btnCancel;
        private SimpleButton btnOk;
        public DataGridView grFilters;
        private TabControl tabTablesViews;
        private TabPage tabTable;
        private TabPage tabViews;
        private Label label1;
        private Label label2;
        private ComboBoxEdit cbViews;
        private ListBoxControl lstViewFields;
        private Label label3;
        private ComboBoxEdit cbTable;
        private ListBoxControl lstTableFields;
        private Label label4;
        private GroupControl grCriterial;
        private Label lblValueText;
        private ComboBoxEdit cbConditionBool;
        private Label label6;
        private ComboBoxEdit cbLogical;
        private Label label5;
        private SimpleButton btnRemove;
        private SimpleButton btnAdd;
        private TextEdit txtValueText;
        private DateEdit dtBeginValue;
        private Label label10;
        private SimpleButton btnBack;
        private Label lblHint;
        private CheckEdit chkCondition;
        private Panel pnBoolean;
        private Label lblValueBoolean;
        private Panel pnText;
        private ComboBoxEdit cbConditionText;
        private Label label12;
        private Panel pnNumber;
        private Label lblFormatNumber;
        private TextEdit txtFormatNumber;
        private TextEdit txtEndValueNumber;
        private Label lblEndValueNumber;
        private ComboBoxEdit cbConditionNumber;
        private Label label15;
        private Label lblBeginValueNumber;
        private TextEdit txtValueNumber;
        private Panel pnDateTime;
        private Label lblFormatDate;
        private Label lblEndValueDate;
        private ComboBoxEdit cbConditionDateTime;
        private Label label20;
        private Label lblBeginValueDate;
        private DateEdit dtEndValue;
        private Panel pnCurrency;
        private TextEdit txtExchangeRate;
        private Label lblExchangeRate;
        private Label lblFormatCurrency;
        private TextEdit txtEndValueCurrency;
        private Label lblEnvalueCurrency;
        private ComboBoxEdit cbCoditionCurrency;
        private Label label25;
        private Label lblBeginValueCurrency;
        private TextEdit txtBeginValueCurrency;
        private TextEdit txtCurrency;
        private Label label7;
        private Label lblTableDescription;
        private Label label8;
        private Label lblViewsDescription;
        private Label label11;
        private ComboBoxEdit cbDateTime;
        private TextEdit txtFormatCurrency;
        private ComboBoxEdit cbFormatNumber;
        private ComboBoxEdit cbFormatCurrency;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmCriterial()
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.grFilters = new System.Windows.Forms.DataGridView();
            this.tabTablesViews = new System.Windows.Forms.TabControl();
            this.tabTable = new System.Windows.Forms.TabPage();
            this.lblTableDescription = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTable = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lstTableFields = new DevExpress.XtraEditors.ListBoxControl();
            this.label4 = new System.Windows.Forms.Label();
            this.tabViews = new System.Windows.Forms.TabPage();
            this.lblViewsDescription = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbViews = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lstViewFields = new DevExpress.XtraEditors.ListBoxControl();
            this.label1 = new System.Windows.Forms.Label();
            this.grCriterial = new DevExpress.XtraEditors.GroupControl();
            this.cbLogical = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.pnNumber = new System.Windows.Forms.Panel();
            this.cbFormatNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblFormatNumber = new System.Windows.Forms.Label();
            this.txtFormatNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtEndValueNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblEndValueNumber = new System.Windows.Forms.Label();
            this.cbConditionNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.lblBeginValueNumber = new System.Windows.Forms.Label();
            this.txtValueNumber = new DevExpress.XtraEditors.TextEdit();
            this.pnDateTime = new System.Windows.Forms.Panel();
            this.cbDateTime = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtEndValue = new DevExpress.XtraEditors.DateEdit();
            this.lblFormatDate = new System.Windows.Forms.Label();
            this.lblEndValueDate = new System.Windows.Forms.Label();
            this.cbConditionDateTime = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtBeginValue = new DevExpress.XtraEditors.DateEdit();
            this.label20 = new System.Windows.Forms.Label();
            this.lblBeginValueDate = new System.Windows.Forms.Label();
            this.pnBoolean = new System.Windows.Forms.Panel();
            this.lblValueBoolean = new System.Windows.Forms.Label();
            this.cbConditionBool = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chkCondition = new DevExpress.XtraEditors.CheckEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.pnText = new System.Windows.Forms.Panel();
            this.cbConditionText = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.lblValueText = new System.Windows.Forms.Label();
            this.txtValueText = new DevExpress.XtraEditors.TextEdit();
            this.pnCurrency = new System.Windows.Forms.Panel();
            this.cbFormatCurrency = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtCurrency = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExchangeRate = new DevExpress.XtraEditors.TextEdit();
            this.lblExchangeRate = new System.Windows.Forms.Label();
            this.lblFormatCurrency = new System.Windows.Forms.Label();
            this.txtFormatCurrency = new DevExpress.XtraEditors.TextEdit();
            this.txtEndValueCurrency = new DevExpress.XtraEditors.TextEdit();
            this.lblEnvalueCurrency = new System.Windows.Forms.Label();
            this.cbCoditionCurrency = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label25 = new System.Windows.Forms.Label();
            this.lblBeginValueCurrency = new System.Windows.Forms.Label();
            this.txtBeginValueCurrency = new DevExpress.XtraEditors.TextEdit();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.lblHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grFilters)).BeginInit();
            this.tabTablesViews.SuspendLayout();
            this.tabTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstTableFields)).BeginInit();
            this.tabViews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbViews.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstViewFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCriterial)).BeginInit();
            this.grCriterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbLogical.Properties)).BeginInit();
            this.pnNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFormatNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormatNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndValueNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbConditionNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValueNumber.Properties)).BeginInit();
            this.pnDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDateTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbConditionDateTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginValue.Properties)).BeginInit();
            this.pnBoolean.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbConditionBool.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCondition.Properties)).BeginInit();
            this.pnText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbConditionText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValueText.Properties)).BeginInit();
            this.pnCurrency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFormatCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormatCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndValueCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCoditionCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeginValueCurrency.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnCancel.Location = new System.Drawing.Point(765, 482);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(685, 482);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(74, 28);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "&Next";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // grFilters
            // 
            this.grFilters.AllowUserToAddRows = false;
            this.grFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grFilters.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grFilters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grFilters.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grFilters.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.grFilters.Location = new System.Drawing.Point(19, 249);
            this.grFilters.Name = "grFilters";
            this.grFilters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grFilters.Size = new System.Drawing.Size(821, 227);
            this.grFilters.TabIndex = 2;
            this.grFilters.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grFilters_CellDoubleClick);
            // 
            // tabTablesViews
            // 
            this.tabTablesViews.Controls.Add(this.tabTable);
            this.tabTablesViews.Controls.Add(this.tabViews);
            this.tabTablesViews.Location = new System.Drawing.Point(18, 12);
            this.tabTablesViews.Name = "tabTablesViews";
            this.tabTablesViews.SelectedIndex = 0;
            this.tabTablesViews.Size = new System.Drawing.Size(363, 231);
            this.tabTablesViews.TabIndex = 3;
            // 
            // tabTable
            // 
            this.tabTable.Controls.Add(this.lblTableDescription);
            this.tabTable.Controls.Add(this.label8);
            this.tabTable.Controls.Add(this.label3);
            this.tabTable.Controls.Add(this.cbTable);
            this.tabTable.Controls.Add(this.lstTableFields);
            this.tabTable.Controls.Add(this.label4);
            this.tabTable.Location = new System.Drawing.Point(4, 23);
            this.tabTable.Name = "tabTable";
            this.tabTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabTable.Size = new System.Drawing.Size(355, 204);
            this.tabTable.TabIndex = 0;
            this.tabTable.Text = "Table";
            this.tabTable.UseVisualStyleBackColor = true;
            // 
            // lblTableDescription
            // 
            this.lblTableDescription.Location = new System.Drawing.Point(76, 176);
            this.lblTableDescription.Name = "lblTableDescription";
            this.lblTableDescription.Size = new System.Drawing.Size(266, 13);
            this.lblTableDescription.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fields:";
            // 
            // cbTable
            // 
            this.cbTable.Location = new System.Drawing.Point(69, 9);
            this.cbTable.Name = "cbTable";
            this.cbTable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTable.Size = new System.Drawing.Size(273, 25);
            this.cbTable.TabIndex = 6;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // lstTableFields
            // 
            this.lstTableFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lstTableFields.Location = new System.Drawing.Point(69, 37);
            this.lstTableFields.Name = "lstTableFields";
            this.lstTableFields.Size = new System.Drawing.Size(273, 128);
            this.lstTableFields.TabIndex = 5;
            this.lstTableFields.DoubleClick += new System.EventHandler(this.lstTableFields_DoubleClick);
            this.lstTableFields.SelectedIndexChanged += new System.EventHandler(this.lstTableFields_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Table:";
            // 
            // tabViews
            // 
            this.tabViews.Controls.Add(this.lblViewsDescription);
            this.tabViews.Controls.Add(this.label11);
            this.tabViews.Controls.Add(this.label2);
            this.tabViews.Controls.Add(this.cbViews);
            this.tabViews.Controls.Add(this.lstViewFields);
            this.tabViews.Controls.Add(this.label1);
            this.tabViews.Location = new System.Drawing.Point(4, 23);
            this.tabViews.Name = "tabViews";
            this.tabViews.Padding = new System.Windows.Forms.Padding(3);
            this.tabViews.Size = new System.Drawing.Size(355, 204);
            this.tabViews.TabIndex = 1;
            this.tabViews.Text = "View";
            this.tabViews.UseVisualStyleBackColor = true;
            // 
            // lblViewsDescription
            // 
            this.lblViewsDescription.Location = new System.Drawing.Point(76, 176);
            this.lblViewsDescription.Name = "lblViewsDescription";
            this.lblViewsDescription.Size = new System.Drawing.Size(266, 13);
            this.lblViewsDescription.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fields:";
            // 
            // cbViews
            // 
            this.cbViews.Location = new System.Drawing.Point(69, 9);
            this.cbViews.Name = "cbViews";
            this.cbViews.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbViews.Size = new System.Drawing.Size(273, 25);
            this.cbViews.TabIndex = 2;
            this.cbViews.SelectedIndexChanged += new System.EventHandler(this.cbViews_SelectedIndexChanged);
            // 
            // lstViewFields
            // 
            this.lstViewFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lstViewFields.Location = new System.Drawing.Point(69, 37);
            this.lstViewFields.Name = "lstViewFields";
            this.lstViewFields.Size = new System.Drawing.Size(273, 128);
            this.lstViewFields.TabIndex = 1;
            this.lstViewFields.DoubleClick += new System.EventHandler(this.lstViewFields_DoubleClick);
            this.lstViewFields.SelectedIndexChanged += new System.EventHandler(this.lstTableFields_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "View:";
            // 
            // grCriterial
            // 
            this.grCriterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grCriterial.Controls.Add(this.cbLogical);
            this.grCriterial.Controls.Add(this.label5);
            this.grCriterial.Controls.Add(this.pnNumber);
            this.grCriterial.Controls.Add(this.pnDateTime);
            this.grCriterial.Controls.Add(this.pnBoolean);
            this.grCriterial.Controls.Add(this.pnText);
            this.grCriterial.Controls.Add(this.pnCurrency);
            this.grCriterial.Enabled = false;
            this.grCriterial.Location = new System.Drawing.Point(404, 17);
            this.grCriterial.Name = "grCriterial";
            this.grCriterial.Size = new System.Drawing.Size(335, 226);
            this.grCriterial.TabIndex = 4;
            this.grCriterial.Text = "Criterial";
            this.grCriterial.Paint += new System.Windows.Forms.PaintEventHandler(this.grCriterial_Paint);
            // 
            // cbLogical
            // 
            this.cbLogical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLogical.EditValue = "AND";
            this.cbLogical.Location = new System.Drawing.Point(108, 17);
            this.cbLogical.Name = "cbLogical";
            this.cbLogical.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLogical.Properties.Items.AddRange(new object[] {
            "AND",
            "OR",
            "AND NOT",
            "OR NOT"});
            this.cbLogical.Size = new System.Drawing.Size(211, 25);
            this.cbLogical.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Logical:";
            // 
            // pnNumber
            // 
            this.pnNumber.Controls.Add(this.cbFormatNumber);
            this.pnNumber.Controls.Add(this.lblFormatNumber);
            this.pnNumber.Controls.Add(this.txtFormatNumber);
            this.pnNumber.Controls.Add(this.txtEndValueNumber);
            this.pnNumber.Controls.Add(this.lblEndValueNumber);
            this.pnNumber.Controls.Add(this.cbConditionNumber);
            this.pnNumber.Controls.Add(this.label15);
            this.pnNumber.Controls.Add(this.lblBeginValueNumber);
            this.pnNumber.Controls.Add(this.txtValueNumber);
            this.pnNumber.Location = new System.Drawing.Point(2, 38);
            this.pnNumber.Name = "pnNumber";
            this.pnNumber.Size = new System.Drawing.Size(328, 123);
            this.pnNumber.TabIndex = 12;
            this.pnNumber.Visible = false;
            // 
            // cbFormatNumber
            // 
            this.cbFormatNumber.Location = new System.Drawing.Point(105, 94);
            this.cbFormatNumber.Name = "cbFormatNumber";
            this.cbFormatNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFormatNumber.Properties.Items.AddRange(new object[] {
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
            this.cbFormatNumber.Size = new System.Drawing.Size(214, 25);
            this.cbFormatNumber.TabIndex = 26;
            this.cbFormatNumber.SelectedIndexChanged += new System.EventHandler(this.cbFormatNumber_SelectedIndexChanged);
            // 
            // lblFormatNumber
            // 
            this.lblFormatNumber.AutoSize = true;
            this.lblFormatNumber.Location = new System.Drawing.Point(10, 97);
            this.lblFormatNumber.Name = "lblFormatNumber";
            this.lblFormatNumber.Size = new System.Drawing.Size(45, 13);
            this.lblFormatNumber.TabIndex = 25;
            this.lblFormatNumber.Text = "Format:";
            // 
            // txtFormatNumber
            // 
            this.txtFormatNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFormatNumber.Location = new System.Drawing.Point(105, 94);
            this.txtFormatNumber.Name = "txtFormatNumber";
            this.txtFormatNumber.Size = new System.Drawing.Size(213, 20);
            this.txtFormatNumber.TabIndex = 24;
            // 
            // txtEndValueNumber
            // 
            this.txtEndValueNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndValueNumber.Enabled = false;
            this.txtEndValueNumber.Location = new System.Drawing.Point(105, 68);
            this.txtEndValueNumber.Name = "txtEndValueNumber";
            this.txtEndValueNumber.Size = new System.Drawing.Size(213, 20);
            this.txtEndValueNumber.TabIndex = 23;
            // 
            // lblEndValueNumber
            // 
            this.lblEndValueNumber.AutoSize = true;
            this.lblEndValueNumber.Enabled = false;
            this.lblEndValueNumber.Location = new System.Drawing.Point(10, 71);
            this.lblEndValueNumber.Name = "lblEndValueNumber";
            this.lblEndValueNumber.Size = new System.Drawing.Size(37, 13);
            this.lblEndValueNumber.TabIndex = 22;
            this.lblEndValueNumber.Text = "Value:";
            // 
            // cbConditionNumber
            // 
            this.cbConditionNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbConditionNumber.Location = new System.Drawing.Point(105, 11);
            this.cbConditionNumber.Name = "cbConditionNumber";
            this.cbConditionNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbConditionNumber.Properties.Items.AddRange(new object[] {
            "",
            ">",
            ">=",
            "=",
            "<",
            "<=",
            "BETWEEN"});
            this.cbConditionNumber.Size = new System.Drawing.Size(213, 25);
            this.cbConditionNumber.TabIndex = 21;
            this.cbConditionNumber.SelectedIndexChanged += new System.EventHandler(this.cbConditionNumber_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Condition:";
            // 
            // lblBeginValueNumber
            // 
            this.lblBeginValueNumber.AutoSize = true;
            this.lblBeginValueNumber.Enabled = false;
            this.lblBeginValueNumber.Location = new System.Drawing.Point(10, 42);
            this.lblBeginValueNumber.Name = "lblBeginValueNumber";
            this.lblBeginValueNumber.Size = new System.Drawing.Size(37, 13);
            this.lblBeginValueNumber.TabIndex = 10;
            this.lblBeginValueNumber.Text = "Value:";
            // 
            // txtValueNumber
            // 
            this.txtValueNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValueNumber.Enabled = false;
            this.txtValueNumber.Location = new System.Drawing.Point(105, 39);
            this.txtValueNumber.Name = "txtValueNumber";
            this.txtValueNumber.Size = new System.Drawing.Size(213, 20);
            this.txtValueNumber.TabIndex = 12;
            // 
            // pnDateTime
            // 
            this.pnDateTime.Controls.Add(this.cbDateTime);
            this.pnDateTime.Controls.Add(this.dtEndValue);
            this.pnDateTime.Controls.Add(this.lblFormatDate);
            this.pnDateTime.Controls.Add(this.lblEndValueDate);
            this.pnDateTime.Controls.Add(this.cbConditionDateTime);
            this.pnDateTime.Controls.Add(this.dtBeginValue);
            this.pnDateTime.Controls.Add(this.label20);
            this.pnDateTime.Controls.Add(this.lblBeginValueDate);
            this.pnDateTime.Location = new System.Drawing.Point(2, 38);
            this.pnDateTime.Name = "pnDateTime";
            this.pnDateTime.Size = new System.Drawing.Size(328, 120);
            this.pnDateTime.TabIndex = 13;
            this.pnDateTime.Visible = false;
            // 
            // cbDateTime
            // 
            this.cbDateTime.EditValue = "DD/MM/YYYY";
            this.cbDateTime.Location = new System.Drawing.Point(104, 87);
            this.cbDateTime.Name = "cbDateTime";
            this.cbDateTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDateTime.Properties.Items.AddRange(new object[] {
            "DD/MM/YYYY",
            "MM/DD/YYYY",
            "YYYY/MM/DD",
            "YYYY/DD/MM",
            "MM-DD-YYYY",
            "DD-MM-YYYY",
            "YYYY-MM-DD",
            "YYYY-DD-MM",
            "Custom"});
            this.cbDateTime.Size = new System.Drawing.Size(213, 25);
            this.cbDateTime.TabIndex = 27;
            this.cbDateTime.SelectedIndexChanged += new System.EventHandler(this.cbDateTime_SelectedIndexChanged);
            // 
            // dtEndValue
            // 
            this.dtEndValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtEndValue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtEndValue.EditValue = new System.DateTime(2007, 4, 13, 0, 0, 0, 0);
            this.dtEndValue.Enabled = false;
            this.dtEndValue.Location = new System.Drawing.Point(104, 61);
            this.dtEndValue.Name = "dtEndValue";
            this.dtEndValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEndValue.Size = new System.Drawing.Size(213, 25);
            this.dtEndValue.TabIndex = 26;
            // 
            // lblFormatDate
            // 
            this.lblFormatDate.AutoSize = true;
            this.lblFormatDate.Location = new System.Drawing.Point(9, 90);
            this.lblFormatDate.Name = "lblFormatDate";
            this.lblFormatDate.Size = new System.Drawing.Size(45, 13);
            this.lblFormatDate.TabIndex = 25;
            this.lblFormatDate.Text = "Format:";
            // 
            // lblEndValueDate
            // 
            this.lblEndValueDate.AutoSize = true;
            this.lblEndValueDate.Enabled = false;
            this.lblEndValueDate.Location = new System.Drawing.Point(9, 64);
            this.lblEndValueDate.Name = "lblEndValueDate";
            this.lblEndValueDate.Size = new System.Drawing.Size(37, 13);
            this.lblEndValueDate.TabIndex = 22;
            this.lblEndValueDate.Text = "Value:";
            // 
            // cbConditionDateTime
            // 
            this.cbConditionDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbConditionDateTime.EditValue = "";
            this.cbConditionDateTime.Location = new System.Drawing.Point(104, 4);
            this.cbConditionDateTime.Name = "cbConditionDateTime";
            this.cbConditionDateTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbConditionDateTime.Properties.Items.AddRange(new object[] {
            "",
            "BEFORE",
            "AFTER",
            "EQUAL TO",
            "BETWEEN"});
            this.cbConditionDateTime.Size = new System.Drawing.Size(213, 25);
            this.cbConditionDateTime.TabIndex = 21;
            this.cbConditionDateTime.SelectedIndexChanged += new System.EventHandler(this.cbConditionDateTime_SelectedIndexChanged);
            // 
            // dtBeginValue
            // 
            this.dtBeginValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtBeginValue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtBeginValue.EditValue = new System.DateTime(2007, 4, 13, 0, 0, 0, 0);
            this.dtBeginValue.Enabled = false;
            this.dtBeginValue.Location = new System.Drawing.Point(104, 32);
            this.dtBeginValue.Name = "dtBeginValue";
            this.dtBeginValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBeginValue.Size = new System.Drawing.Size(213, 25);
            this.dtBeginValue.TabIndex = 16;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 7);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "Condition:";
            // 
            // lblBeginValueDate
            // 
            this.lblBeginValueDate.AutoSize = true;
            this.lblBeginValueDate.Enabled = false;
            this.lblBeginValueDate.Location = new System.Drawing.Point(9, 35);
            this.lblBeginValueDate.Name = "lblBeginValueDate";
            this.lblBeginValueDate.Size = new System.Drawing.Size(37, 13);
            this.lblBeginValueDate.TabIndex = 10;
            this.lblBeginValueDate.Text = "Value:";
            // 
            // pnBoolean
            // 
            this.pnBoolean.Controls.Add(this.lblValueBoolean);
            this.pnBoolean.Controls.Add(this.cbConditionBool);
            this.pnBoolean.Controls.Add(this.chkCondition);
            this.pnBoolean.Controls.Add(this.label6);
            this.pnBoolean.Location = new System.Drawing.Point(2, 38);
            this.pnBoolean.Name = "pnBoolean";
            this.pnBoolean.Size = new System.Drawing.Size(328, 68);
            this.pnBoolean.TabIndex = 10;
            this.pnBoolean.Visible = false;
            // 
            // lblValueBoolean
            // 
            this.lblValueBoolean.AutoSize = true;
            this.lblValueBoolean.Enabled = false;
            this.lblValueBoolean.Location = new System.Drawing.Point(11, 38);
            this.lblValueBoolean.Name = "lblValueBoolean";
            this.lblValueBoolean.Size = new System.Drawing.Size(37, 13);
            this.lblValueBoolean.TabIndex = 18;
            this.lblValueBoolean.Text = "Value:";
            // 
            // cbConditionBool
            // 
            this.cbConditionBool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbConditionBool.EditValue = "";
            this.cbConditionBool.Location = new System.Drawing.Point(106, 12);
            this.cbConditionBool.Name = "cbConditionBool";
            this.cbConditionBool.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbConditionBool.Properties.Items.AddRange(new object[] {
            "",
            "EQUAL TO"});
            this.cbConditionBool.Size = new System.Drawing.Size(211, 25);
            this.cbConditionBool.TabIndex = 9;
            this.cbConditionBool.SelectedIndexChanged += new System.EventHandler(this.cbConditionBool_SelectedIndexChanged);
            // 
            // chkCondition
            // 
            this.chkCondition.Enabled = false;
            this.chkCondition.Location = new System.Drawing.Point(106, 38);
            this.chkCondition.Name = "chkCondition";
            this.chkCondition.Properties.Caption = "True";
            this.chkCondition.Size = new System.Drawing.Size(44, 19);
            this.chkCondition.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Condition:";
            // 
            // pnText
            // 
            this.pnText.Controls.Add(this.cbConditionText);
            this.pnText.Controls.Add(this.label12);
            this.pnText.Controls.Add(this.lblValueText);
            this.pnText.Controls.Add(this.txtValueText);
            this.pnText.Location = new System.Drawing.Point(2, 38);
            this.pnText.Name = "pnText";
            this.pnText.Size = new System.Drawing.Size(328, 68);
            this.pnText.TabIndex = 11;
            this.pnText.Visible = false;
            // 
            // cbConditionText
            // 
            this.cbConditionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbConditionText.Location = new System.Drawing.Point(106, 11);
            this.cbConditionText.Name = "cbConditionText";
            this.cbConditionText.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbConditionText.Properties.Items.AddRange(new object[] {
            "",
            "LIKES",
            "EQUAL TO",
            "START WITH",
            "END WITH"});
            this.cbConditionText.Size = new System.Drawing.Size(213, 25);
            this.cbConditionText.TabIndex = 21;
            this.cbConditionText.SelectedIndexChanged += new System.EventHandler(this.cbConditionText_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Condition:";
            // 
            // lblValueText
            // 
            this.lblValueText.AutoSize = true;
            this.lblValueText.Enabled = false;
            this.lblValueText.Location = new System.Drawing.Point(11, 42);
            this.lblValueText.Name = "lblValueText";
            this.lblValueText.Size = new System.Drawing.Size(37, 13);
            this.lblValueText.TabIndex = 10;
            this.lblValueText.Text = "Value:";
            // 
            // txtValueText
            // 
            this.txtValueText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValueText.Enabled = false;
            this.txtValueText.Location = new System.Drawing.Point(106, 39);
            this.txtValueText.Name = "txtValueText";
            this.txtValueText.Size = new System.Drawing.Size(213, 20);
            this.txtValueText.TabIndex = 12;
            // 
            // pnCurrency
            // 
            this.pnCurrency.Controls.Add(this.cbFormatCurrency);
            this.pnCurrency.Controls.Add(this.txtCurrency);
            this.pnCurrency.Controls.Add(this.label7);
            this.pnCurrency.Controls.Add(this.txtExchangeRate);
            this.pnCurrency.Controls.Add(this.lblExchangeRate);
            this.pnCurrency.Controls.Add(this.lblFormatCurrency);
            this.pnCurrency.Controls.Add(this.txtFormatCurrency);
            this.pnCurrency.Controls.Add(this.txtEndValueCurrency);
            this.pnCurrency.Controls.Add(this.lblEnvalueCurrency);
            this.pnCurrency.Controls.Add(this.cbCoditionCurrency);
            this.pnCurrency.Controls.Add(this.label25);
            this.pnCurrency.Controls.Add(this.lblBeginValueCurrency);
            this.pnCurrency.Controls.Add(this.txtBeginValueCurrency);
            this.pnCurrency.Location = new System.Drawing.Point(2, 38);
            this.pnCurrency.Name = "pnCurrency";
            this.pnCurrency.Size = new System.Drawing.Size(328, 182);
            this.pnCurrency.TabIndex = 18;
            // 
            // cbFormatCurrency
            // 
            this.cbFormatCurrency.Location = new System.Drawing.Point(106, 129);
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
            this.cbFormatCurrency.Size = new System.Drawing.Size(214, 25);
            this.cbFormatCurrency.TabIndex = 30;
            this.cbFormatCurrency.SelectedIndexChanged += new System.EventHandler(this.cbFormatNumber_SelectedIndexChanged);
            // 
            // txtCurrency
            // 
            this.txtCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrency.Location = new System.Drawing.Point(106, 155);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(213, 20);
            this.txtCurrency.TabIndex = 29;
            this.txtCurrency.EditValueChanged += new System.EventHandler(this.txtCurrency_EditValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Currency:";
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExchangeRate.Location = new System.Drawing.Point(106, 45);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Size = new System.Drawing.Size(213, 20);
            this.txtExchangeRate.TabIndex = 27;
            this.txtExchangeRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExchangeRate_KeyPress);
            this.txtExchangeRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExchangeRate_KeyDown);
            // 
            // lblExchangeRate
            // 
            this.lblExchangeRate.AutoSize = true;
            this.lblExchangeRate.Location = new System.Drawing.Point(11, 48);
            this.lblExchangeRate.Name = "lblExchangeRate";
            this.lblExchangeRate.Size = new System.Drawing.Size(84, 13);
            this.lblExchangeRate.TabIndex = 26;
            this.lblExchangeRate.Text = "Exchange Rate:";
            // 
            // lblFormatCurrency
            // 
            this.lblFormatCurrency.AutoSize = true;
            this.lblFormatCurrency.Location = new System.Drawing.Point(11, 132);
            this.lblFormatCurrency.Name = "lblFormatCurrency";
            this.lblFormatCurrency.Size = new System.Drawing.Size(45, 13);
            this.lblFormatCurrency.TabIndex = 25;
            this.lblFormatCurrency.Text = "Format:";
            // 
            // txtFormatCurrency
            // 
            this.txtFormatCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFormatCurrency.Location = new System.Drawing.Point(106, 129);
            this.txtFormatCurrency.Name = "txtFormatCurrency";
            this.txtFormatCurrency.Size = new System.Drawing.Size(213, 20);
            this.txtFormatCurrency.TabIndex = 24;
            // 
            // txtEndValueCurrency
            // 
            this.txtEndValueCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndValueCurrency.Location = new System.Drawing.Point(106, 103);
            this.txtEndValueCurrency.Name = "txtEndValueCurrency";
            this.txtEndValueCurrency.Size = new System.Drawing.Size(213, 20);
            this.txtEndValueCurrency.TabIndex = 23;
            // 
            // lblEnvalueCurrency
            // 
            this.lblEnvalueCurrency.AutoSize = true;
            this.lblEnvalueCurrency.Location = new System.Drawing.Point(11, 106);
            this.lblEnvalueCurrency.Name = "lblEnvalueCurrency";
            this.lblEnvalueCurrency.Size = new System.Drawing.Size(37, 13);
            this.lblEnvalueCurrency.TabIndex = 22;
            this.lblEnvalueCurrency.Text = "Value:";
            // 
            // cbCoditionCurrency
            // 
            this.cbCoditionCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCoditionCurrency.Location = new System.Drawing.Point(106, 15);
            this.cbCoditionCurrency.Name = "cbCoditionCurrency";
            this.cbCoditionCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCoditionCurrency.Properties.Items.AddRange(new object[] {
            "",
            ">",
            ">=",
            "=",
            "<",
            "<=",
            "BETWEEN"});
            this.cbCoditionCurrency.Size = new System.Drawing.Size(213, 25);
            this.cbCoditionCurrency.TabIndex = 21;
            this.cbCoditionCurrency.SelectedIndexChanged += new System.EventHandler(this.cbCoditionCurrency_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(9, 18);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(56, 13);
            this.label25.TabIndex = 20;
            this.label25.Text = "Condition:";
            // 
            // lblBeginValueCurrency
            // 
            this.lblBeginValueCurrency.AutoSize = true;
            this.lblBeginValueCurrency.Location = new System.Drawing.Point(11, 77);
            this.lblBeginValueCurrency.Name = "lblBeginValueCurrency";
            this.lblBeginValueCurrency.Size = new System.Drawing.Size(37, 13);
            this.lblBeginValueCurrency.TabIndex = 10;
            this.lblBeginValueCurrency.Text = "Value:";
            // 
            // txtBeginValueCurrency
            // 
            this.txtBeginValueCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBeginValueCurrency.Location = new System.Drawing.Point(106, 74);
            this.txtBeginValueCurrency.Name = "txtBeginValueCurrency";
            this.txtBeginValueCurrency.Size = new System.Drawing.Size(213, 20);
            this.txtBeginValueCurrency.TabIndex = 12;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(748, 215);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 28);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(748, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 28);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 487);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "*Note: Double Click On Grid to Edit";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnBack.Location = new System.Drawing.Point(605, 482);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 28);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "&Back";
            // 
            // lblHint
            // 
            this.lblHint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHint.Location = new System.Drawing.Point(745, 20);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(94, 143);
            this.lblHint.TabIndex = 9;
            this.lblHint.Text = "Select Table or View, then Field, input creterial and click add";
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmCriterial
            // 
            this.ClientSize = new System.Drawing.Size(851, 518);
            this.Controls.Add(this.tabTablesViews);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.grCriterial);
            this.Controls.Add(this.grFilters);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmCriterial";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criterial";
            this.Shown += new System.EventHandler(this.frmCriterial_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCriterial_FormClosing);
            this.Load += new System.EventHandler(this.frmCriterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grFilters)).EndInit();
            this.tabTablesViews.ResumeLayout(false);
            this.tabTable.ResumeLayout(false);
            this.tabTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstTableFields)).EndInit();
            this.tabViews.ResumeLayout(false);
            this.tabViews.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbViews.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstViewFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCriterial)).EndInit();
            this.grCriterial.ResumeLayout(false);
            this.grCriterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbLogical.Properties)).EndInit();
            this.pnNumber.ResumeLayout(false);
            this.pnNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFormatNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormatNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndValueNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbConditionNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValueNumber.Properties)).EndInit();
            this.pnDateTime.ResumeLayout(false);
            this.pnDateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDateTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbConditionDateTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginValue.Properties)).EndInit();
            this.pnBoolean.ResumeLayout(false);
            this.pnBoolean.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbConditionBool.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCondition.Properties)).EndInit();
            this.pnText.ResumeLayout(false);
            this.pnText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbConditionText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValueText.Properties)).EndInit();
            this.pnCurrency.ResumeLayout(false);
            this.pnCurrency.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFormatCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormatCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndValueCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCoditionCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeginValueCurrency.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion       
        public bool reload = true;
        private void frmCriterial_Load(object sender, EventArgs e)
        {
            frmAddTable frm = ((frmMain)Tag).fAddTable;
            cbTable.Properties.Items.Clear();
            cbViews.Properties.Items.Clear();
            int cnt = frm.lstAddedTable.ItemCount;
            for (int i = 0; i < cnt; i++)
            {
                cbTable.Properties.Items.Add(frm.lstAddedTable.Items[i]);
            }
            cnt = frm.lstAddedViews.ItemCount;
            for (int i = 0; i < cnt; i++)
            {
                cbViews.Properties.Items.Add(frm.lstAddedViews.Items[i]);
            }
            lstTableFields.Items.Clear();
            lstViewFields.Items.Clear();
            cbTable.SelectedIndex = -1;
            cbViews.SelectedIndex = -1;
            lstTableFields.SelectedIndex = -1;
            lstViewFields.SelectedIndex = -1;
            if (reload)
            {
                #region reload form
                reload = false;
                createDataSource();
                #endregion
            }
            else
            {
                #region update form
                Hashtable oldTbl = new Hashtable();
                foreach (DataRow r in dt.Rows)
                {
                    String name = r["Table"].ToString() + r["View"].ToString();
                    if (!oldTbl.ContainsKey(name)) oldTbl.Add(name, name);
                }

                Hashtable newTbl = new Hashtable();
                foreach (String itm in frm.lstAddedTable.Items)
                {
                    newTbl.Add(itm, itm);
                }

                foreach (String itm in frm.lstAddedViews.Items)
                {
                    newTbl.Add(itm, itm);
                }

                Hashtable delete = new Hashtable();
                foreach (String name in oldTbl.Keys)
                {
                    if (!newTbl.ContainsKey(name))
                    {
                        delete.Add(name, name);
                    }
                }

                if (delete.Count > 0)
                {
                    String tmp = "";
                    foreach (String s in delete.Keys)
                    {
                        tmp += "\n" + s;
                    }
                    if (MessageBox.Show("Do you want to delete all condition on tables or views: " + tmp, "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //delete row in data source
                        cnt = dt.Rows.Count;
                        int i = 0;
                        while (i < cnt)
                        {
                            DataRow r = dt.Rows[i];
                            String tbl = r["Table"].ToString() + r["View"].ToString();
                            if (delete.ContainsKey(tbl))
                            {
                                dt.Rows.RemoveAt(i);
                                i--;
                                cnt--;
                            }
                            i++;
                        }
                        ArrayList arr = (Tag as frmMain).fOrderBy.arr;
                        if (arr != null)
                        {
                            cnt = arr.Count;
                            i = 0;
                            while (i < cnt)
                            {
                                string s = (arr[i] as Record).Field;
                                s = s.Substring(0, s.LastIndexOf("."));
                                if (delete.ContainsKey(s))
                                {
                                    arr.RemoveAt(i);
                                    i--; cnt--;
                                }
                                i++;
                            }
                        }
                    }
                }
                #endregion
            }
        }

        public void createDataSource()
        {
            ds = new DataSet("tblFilters");
            dt = new DataTable("tblFilters");
            dt.Columns.Add("Table");
            dt.Columns.Add("View");
            dt.Columns.Add("Field");
            dt.Columns.Add("Logical");
            dt.Columns.Add("Condition");
            dt.Columns.Add("Value");
            dt.Columns.Add("Value2");
            dt.Columns.Add("Rate");
            dt.Columns.Add("Format");
            dt.Columns.Add("Type");
            dt.Columns.Add("Other");
            ds.Tables.Add(dt);
            grFilters.DataMember = "tblFilters";
            grFilters.DataSource = ds;
        }

        private void frmCriterial_Shown(object sender, EventArgs e)
        {

        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTable.SelectedItem == null) return;
            if (DbManager.OpenSQL("select name from syscolumns where id=object_id('" + cbTable.SelectedItem.ToString() + "')"))
            {
                lstTableFields.Items.Clear();
                while (DbManager.reader.Read())
                    lstTableFields.Items.Add(DbManager.reader[0]);
                DbManager.reader.Close();
            }
        }
        
        private void cbViews_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbViews.SelectedItem == null) return;
            if (DbManager.OpenSQL("select name from syscolumns where id=object_id('" + cbViews.SelectedItem.ToString() + "')"))
            {
                lstViewFields.Items.Clear();
                while (DbManager.reader.Read())
                    lstViewFields.Items.Add(DbManager.reader[0]);
                DbManager.reader.Close();
            }
        }

        private byte colType;
        public const byte TYPE_DATETIME = 0;
        public const byte TYPE_BOOL = 1;
        public const byte TYPE_CURRENCY = 2;
        public const byte TYPE_NUMBER = 3;
        public const byte TYPE_TEXT = 4;
        public const byte TYPE_OTHER = 6;
        public DataTable dt;
        public DataSet ds;
        private String type;
        private bool editting = false;
        private string field;
        private string tbl;
        private int selectedRow;
        private frmFormatNumber fFormatNumber;
        private int oldSelectedId = -1;

        private void ClearControl()
        {
            pnBoolean.Visible = false;
            pnCurrency.Visible = false;
            pnDateTime.Visible = false;
            pnNumber.Visible = false;
            pnText.Visible = false;
            cbCoditionCurrency.SelectedIndex = 0;
            cbConditionBool.SelectedIndex = 0;
            chkCondition.Checked = false;
            cbConditionDateTime.SelectedIndex = 0;
            cbConditionNumber.SelectedIndex = 0;
            cbConditionText.SelectedIndex = 0;
            cbLogical.SelectedIndex = 0;           
            dtBeginValue.DateTime = DateTime.Now;
            dtEndValue.DateTime = DateTime.Now;
            txtBeginValueCurrency.Text = "";
            txtEndValueCurrency.Text = "";
            txtEndValueNumber.Text = "";
            txtExchangeRate.Text = "1";
            txtFormatCurrency.Text = "";
            cbFormatCurrency.SelectedIndex = -1;
            cbFormatNumber.SelectedIndex = -1;
            txtFormatNumber.Text = "";
            cbDateTime.SelectedIndex = 0;
            txtValueNumber.Text = "";
            txtValueText.Text = "";
        }

        public static byte GetFieldGroup(string value)
        {
            switch (value.ToUpper())
            {
                case "BIT": return TYPE_BOOL;
                case "SQL_VARIANT":
                case "VARBINARY":
                case "BINARY":
                case "XML":
                case "IMAGE":                
                    return TYPE_OTHER;
                case "DATETIME":
                case "TIMESTAMP":
                case "SMALLDATETIME":
                    return TYPE_DATETIME;
                case "MONEY":
                case "SMALLMONEY":
                    return TYPE_CURRENCY;
                case "REAL":
                case "DECIMAL":
                case "NUMERIC":
                case "TINYINT":
                case "INT":
                case "SMALLINT":
                case "FLOAT":
                    return TYPE_NUMBER;
                default: return TYPE_TEXT;
            }
        }

        private void lstTableFields_SelectedIndexChanged(object sender, EventArgs e)
        {            
            string sql;
            if (sender == lstTableFields)
            {
                if (cbTable.SelectedItem == null) return;
                if (lstTableFields.SelectedValue == null || cbTable.SelectedItem.ToString().Length == 0)
                {
                    grCriterial.Enabled = false;
                    return;
                }
                tbl = cbTable.SelectedItem.ToString();
                field = lstTableFields.SelectedValue.ToString();
                if (cbTable.SelectedItem == null) return;
                sql = "select systypes.name from syscolumns join systypes on syscolumns.xtype = systypes.xtype where id=object_id('" + cbTable.SelectedItem.ToString() + "') and (syscolumns.name = '" + lstTableFields.SelectedValue + "')";
            }
            else
            {
                if (cbViews.SelectedItem == null) return;
                if (lstViewFields.SelectedValue == null || cbViews.SelectedItem.ToString().Length == 0)
                {
                    grCriterial.Enabled = false;
                    return;
                }
                if (cbViews.SelectedItem == null) return;
                tbl = cbViews.SelectedItem.ToString();
                field = lstViewFields.SelectedValue.ToString();
                sql = "select systypes.name from syscolumns join systypes on syscolumns.xtype = systypes.xtype where id=object_id('" + cbViews.SelectedItem.ToString() + "') and (syscolumns.name = '" + lstViewFields.SelectedValue + "')";
            }

            if (DbManager.OpenSQL(sql))
            {
                DbManager.reader.Read();
                type = DbManager.reader[0].ToString();
                lblHint.Text = "Field type: " + type;
                colType = GetFieldGroup(type.ToUpper());
                ClearControl();
                grCriterial.Enabled = true;
                switch (colType)
                {
                    case TYPE_BOOL: pnBoolean.Visible = true; break;
                    case TYPE_CURRENCY: pnCurrency.Visible = true; break;
                    case TYPE_DATETIME: pnDateTime.Visible = true; break;
                    case TYPE_NUMBER: pnNumber.Visible = true; break;
                    case TYPE_TEXT: pnText.Visible = true; break;
                    case TYPE_OTHER: grCriterial.Enabled = false; break;
                }
                sql = "SELECT [Description] = ex.value FROM sys.columns c LEFT OUTER JOIN sys.extended_properties ex ON ex.major_id = c.object_id AND ex.minor_id = c.column_id AND ex.name = 'MS_Description' WHERE OBJECT_NAME(c.object_id) = '" + tbl +"' AND c.name = '" + field + "'";
                string des = "";
                if (DbManager.OpenSQL(sql))
                {
                    DbManager.reader.Read();
                    if (DbManager.reader["Description"] != null)
                    {
                        des = DbManager.reader["Description"].ToString();
                    }
                }
                if (sender == lstTableFields) lblTableDescription.Text = des;
                else lblViewsDescription.Text = des;
                foreach (DataRow r in dt.Rows)
                {
                    if (r["Table"].ToString() + r["View"].ToString() == tbl && r["Field"].ToString() == field)
                    {
                        if (colType == TYPE_CURRENCY)
                        {
                            txtFormatCurrency.Text = r["Format"].ToString();
                            txtCurrency.Text = r["Other"].ToString();
                            txtExchangeRate.Text = r["Rate"].ToString();
                        }
                        if (colType == TYPE_NUMBER) txtFormatNumber.Text = r["Format"].ToString();
                        if (colType == TYPE_DATETIME)
                        {
                            int i = 0;
                            foreach (string item in cbDateTime.Properties.Items)
                            {
                                if (item == r["Format"].ToString())
                                {
                                    cbDateTime.SelectedIndex = i;
                                    break;
                                }
                                i++;
                            }
                        }
                        break;
                    }
                }
            }
            else
            {
                grCriterial.Enabled = false;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (editting)
            {
                btnAdd.Text = "&Add";
                btnRemove.Text = "&Remove";
                tabTablesViews.Enabled = true;
                grFilters.Enabled = true;
                btnBack.Enabled = true;
                btnOk.Enabled = true;
                btnCancel.Enabled = true;
                editting = false;
                return;
            }
            
            if (grFilters.SelectedRows.Count == 0)
            {
                MessageBox.Show("There is no row to delete");
                return;
            }
            if (grFilters.SelectedRows[0].Index >= 0) //enable to remove
            {
                try
                {                                        
                    DataRow g = dt.Rows[grFilters.SelectedRows[0].Index];
                    String name = g["Table"].ToString() + g["View"].ToString() + "." + g["Field"].ToString();
                    ds.Tables["tblFilters"].Rows.RemoveAt(grFilters.SelectedRows[0].Index);
                    if (dt.Rows.Count > 0) ds.Tables["tblFilters"].Rows[0]["Logical"] = "";
                    bool needDelete = true;
                    foreach (DataRow r in dt.Rows)
                    {
                        String rName = r["Table"].ToString() + r["View"].ToString() + "." + r["Field"].ToString();
                        if (rName.Equals(name))
                        {
                            needDelete = false;
                            break;
                        }
                    }
                    ArrayList arr = (Tag as frmMain).fOrderBy.arr;
                    if (needDelete && arr != null)
                    {
                        for (int i = 0; i < arr.Count; i++)
                        {
                            Record r = (Record) arr[i];
                            if (r.Field == name)
                            {
                                arr.RemoveAt(i);
                                break;
                            }
                        }
                    }
                }
                catch { }
            }
        }

        //this function used to validate the data in a textbox
        private bool ValidateTextbox(TextEdit txt)
        {
            if (txt.Enabled && txt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Input value please");
                txt.Select();
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Validate form
            if (tabTablesViews.SelectedIndex == 0)
            {
                if (cbTable.SelectedItem == null)
                {
                    MessageBox.Show("You have select table first!");
                    cbTable.Select();
                    return;
                }
                if (lstTableFields.SelectedItem == null)
                {
                    MessageBox.Show("Select field from the list please.");
                    lstTableFields.Select();
                    return;
                }
            }
            else
            {
                    if (cbViews.SelectedItem == null)
                    {
                        MessageBox.Show("You have select table first!");
                        cbViews.Select();
                        return;
                    }
                    if (lstViewFields.SelectedItem == null)
                    {
                        MessageBox.Show("Select field from the list please.");
                        lstViewFields.Select();
                        return;
                    }
            }

            switch (colType)
            {
                case TYPE_CURRENCY:
                    if (!ValidateTextbox(txtBeginValueCurrency)) return;
                    if (!ValidateTextbox(txtExchangeRate)) return;
                    if (!ValidateTextbox(txtEndValueCurrency)) return;                    
                    break;
                case TYPE_TEXT:
                    if (!ValidateTextbox(txtValueText)) return;
                    break;
                case TYPE_NUMBER:
                    if (!ValidateTextbox(txtValueNumber)) return;
                    if (!ValidateTextbox(txtEndValueNumber)) return;
                    break;
                case TYPE_OTHER:
                    MessageBox.Show("Sorry, we dose not support this type in report!");
                    return;
            }
            #endregion
            #region Add new row
            DataRow row;
            if (!editting)
            {
                row = dt.NewRow();
            }
            else
            {
                row = dt.Rows[selectedRow];
            }
            row["Logical"] = cbLogical.SelectedItem.ToString();
            row["Type"] = type;
            if (tabTablesViews.SelectedIndex == 0)
            {
                row["Table"] = cbTable.SelectedItem.ToString();
                row["Field"] = lstTableFields.SelectedValue.ToString();
            }
            else
            {
                row["View"] = cbViews.SelectedItem.ToString();
                row["Field"] = lstViewFields.SelectedValue.ToString();
            }
            switch (colType)
            {
                case TYPE_BOOL:
                    if (cbConditionBool.SelectedIndex != 0)
                    {
                        if (chkCondition.Enabled) row["Value"] = chkCondition.Checked.ToString();
                        else row["Value"] = "";
                        row["Condition"] = cbConditionBool.Text;
                    }
                    break;
                case TYPE_CURRENCY:
                    if (cbCoditionCurrency.SelectedIndex != 0)
                    {
                        if (txtBeginValueCurrency.Enabled) row["Value"] = txtBeginValueCurrency.Text;
                        else row["Value"] = "";
                        row["Condition"] = cbCoditionCurrency.Text;
                        row["Format"] = txtFormatCurrency.Text;
                        if (txtEndValueCurrency.Enabled) row["Value2"] = txtEndValueCurrency.Text;
                        else row["Value2"] = "";
                        row["Rate"] = txtExchangeRate.Text;
                        row["Other"] = txtCurrency.Text;
                    }
                    break;
                case TYPE_DATETIME:
                    if (dtBeginValue.Enabled) row["Value"] = dtBeginValue.Text;
                    else row["Value"] = "";
                    if (dtEndValue.Enabled) row["Value2"] = dtEndValue.Text;
                    else row["Value2"] = "";
                    row["Condition"] = cbConditionDateTime.Text;
                    row["Format"] = cbDateTime.Text;
                    break;
                case TYPE_TEXT:
                    row["Condition"] = cbConditionText.Text;
                    if (txtValueText.Enabled) row["Value"] = txtValueText.Text;
                    else row["Value"] = "";
                    break;
                case TYPE_NUMBER:
                    if (txtValueNumber.Enabled) row["Value"] = txtValueNumber.Text;
                    else row["Value"] = "";
                    if (txtEndValueNumber.Enabled) row["Value2"] = txtEndValueNumber.Text;
                    else row["Value2"] = "";
                    row["Condition"] = cbConditionNumber.Text;
                    row["Format"] = txtFormatNumber.Text;
                    break;
            }
            if (!editting)
                dt.Rows.Add(row);
            else
            {
                btnAdd.Text = "&Add";
                btnRemove.Text = "&Remove";
                tabTablesViews.Enabled = true;
                grFilters.Enabled = true;
                btnBack.Enabled = true;
                btnOk.Enabled = true;
                btnCancel.Enabled = true;
                editting = false;
            }
            changeInfor();
            Record r = new Record(row["Table"].ToString() + row["View"].ToString() + "." + row["Field"].ToString());
            r.Format = row["Format"].ToString();
            r.Other = row["Other"].ToString();
            r.Rate = row["Rate"].ToString();
            r.Type = type;
            if ((Tag as frmMain).fOrderBy.arr == null) (Tag as frmMain).fOrderBy.arr = new ArrayList();
            ArrayList arr = (Tag as frmMain).fOrderBy.arr;
            for (int i = 0; i < arr.Count; i++)
            {
                if ((arr[i] as Record).Field == r.Field)
                {
                    (arr[i] as Record).Format = row["Format"].ToString();
                    (arr[i] as Record).Other = row["Other"].ToString();
                    (arr[i] as Record).Rate = row["Rate"].ToString();
                    return;
                }
            }
            r.Show = true;
            if (tabTablesViews.SelectedIndex == 0)
                r.Description = lblTableDescription.Text;
            else r.Description = lblViewsDescription.Text;
            arr.Add(r);
            #endregion
        }

        private void grCriterial_Paint(object sender, PaintEventArgs e)
        {

        }

        private const string SEP = ":#@://\\^&*()!~";

        private String getFromStatement(Hashtable tblHaveRel)
        {
            String from = "";
            Hashtable addedTable = new Hashtable();
            Queue qu = new Queue(tblHaveRel.Keys);
            //foreach (String name in tblHaveRel.Keys)
            while (qu.Count > 0)
            {
                String name = qu.Peek().ToString();
                String onStatement = " ON ";
                DbManager.OpenSQL("exec sp_fkeys '" + name + "'");
                while (DbManager.reader.Read())
                {
                    String tblName = DbManager.reader["FKTABLE_NAME"].ToString();
                    if (addedTable.ContainsKey(tblName))
                    {
                        if (onStatement.Length > 4) onStatement += " AND ";
                        onStatement += "(" + name + "." + DbManager.reader["PKCOLUMN_NAME"] + "=" +
                                                 tblName + "." + DbManager.reader["FKCOLUMN_NAME"] + ")";
                    }
                }
                foreach (String kname in addedTable.Keys)
                {
                    DbManager.OpenSQL("exec sp_fkeys '" + kname + "'");
                    while (DbManager.reader.Read())
                    {
                        String tblName = DbManager.reader["FKTABLE_NAME"].ToString();
                        if (tblName.Equals(name))
                        {
                            if (onStatement.Length > 4) onStatement += " AND ";
                            onStatement += "(" + kname + "." + DbManager.reader["PKCOLUMN_NAME"] + "=" +
                                                     name + "." + DbManager.reader["FKCOLUMN_NAME"] + ")";
                        }
                    }
                }                
                if (addedTable.Count == 0) {
                    addedTable.Add(name, name);
                    qu.Dequeue();
                    from = name;  
                    continue;
                }
                if (from.IndexOf(" ") >= 0) from = "(" + from + ")";
                if (onStatement.Length > 4)
                {
                    from += " INNER JOIN " + name + onStatement;
                    addedTable.Add(name, name);
                    qu.Dequeue();
                }
                else qu.Enqueue(qu.Dequeue());
            }
            return from;
        }

        private void addToHash(Hashtable hst, String tbl, Hashtable des, Hashtable addedTable)
        {
            if (des.ContainsKey(tbl)) return;
            if (addedTable.ContainsKey(tbl)) return;
            des.Add(tbl, tbl);
            DbManager.OpenSQL("exec sp_fkeys '" + tbl + "'");
            while (DbManager.reader.Read())
            {
                String tblName = DbManager.reader["FKTABLE_NAME"].ToString();
                if (hst.ContainsKey(tblName))
                    addToHash(hst, tblName, des, addedTable);
            }
            
            foreach (String name in hst.Keys)
            {
                if (des.ContainsKey(name)) continue;
                DbManager.OpenSQL("exec sp_fkeys '" + name + "'");
                while (DbManager.reader.Read())
                {
                    String tblName = DbManager.reader["FKTABLE_NAME"].ToString();
                    if (des.ContainsKey(tblName))
                    {
                        addToHash(hst, name, des, addedTable);
                    }
                }
            }
            addedTable.Add(tbl, tbl);
        }

        public string getSqlCommand()
        {
            #region FROM statement
            //get table and view first
            Hashtable tbl = new Hashtable();
            foreach (DataRow row in dt.Rows)
            {
                String name = row["Table"].ToString() + row["View"].ToString();
                if (tbl.ContainsKey(name)) continue;
                tbl.Add(name, name);
            }

            Hashtable tmpTbl = new Hashtable(tbl);
            Hashtable addedTbl = new Hashtable();
            String from = "";
            while (tmpTbl.Count > addedTbl.Count)
            {
                Hashtable group = new Hashtable();
                String name = "";
                foreach (String k in tmpTbl.Keys)
                {
                    if (!addedTbl.ContainsKey(k))
                    {
                        name = k;
                        break;
                    }
                }
                addToHash(tmpTbl, name, group, addedTbl);
                if (from.Length != 0) from += ", ";
                from += getFromStatement(group);
            }
            from = " FROM " + from;
            #endregion
            #region Select, Order, Where Statement
            //create select command
            string where = "";
            foreach (DataRow row in dt.Rows)
            {
                
                    string fieldname = row["Table"].ToString() + row["View"].ToString() + "." + row["Field"];
                    //where                    
                    string condition = "";
                    switch (row["Condition"].ToString())
                    {
                        case "EQUAL TO":
                        case "=":
                            condition = fieldname + " = '" + row["Value"] + "'";
                            break;
                        case "<=":
                            condition = fieldname + " <= '" + row["Value"] + "'";
                            break;
                        case ">=":
                            condition = fieldname + " >= '" + row["Value"] + "'";
                            break;
                        case "AFTER":
                        case "GREATER THAN":
                        case ">":
                            condition = fieldname + " > '" + row["Value"] + "'";
                            break;                        
                        case "BEFORE":
                        case "LESS THAN":
                        case "<":
                            condition = fieldname + " < '" + row["Value"] + "'";
                            break;
                        case "BETWEEN":
                            condition = fieldname + " BETWEEN '" + row["Value"] + "' AND '" + row["Value2"] + "'";
                            break;
                        case "LIKES":
                            condition = fieldname + " LIKE '%" + row["Value"] + "%'";
                            break;
                        case "START WITH":
                            condition = fieldname + " LIKE '" + row["Value"] + "%'";
                            break;
                        case "END WITH":
                            condition = fieldname + " LIKE '%" + row["Value"] + "'";
                            break;
                    }
                    if (condition.Length != 0)
                    {
                        if (where.Length > 0) where = where + " " + row["Logical"] + " ";
                        else if (row["Logical"].ToString().IndexOf("NOT") > 0) where += "NOT ";
                        where += "(" + condition +")";
                    }

            }
            if (where.Length > 0) where = " WHERE " + where;
            #endregion
            return from + where;
        }

        private void cbConditionDateTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBeginValueDate.Enabled = (cbConditionDateTime.SelectedIndex != 0);
            lblEndValueDate.Enabled = (cbConditionDateTime.Text == "BETWEEN");
            dtBeginValue.Enabled = lblBeginValueDate.Enabled;
            dtEndValue.Enabled = lblEndValueDate.Enabled;
        }

        private void cbConditionNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBeginValueNumber.Enabled = (cbConditionNumber.SelectedIndex != 0);
            txtValueNumber.Enabled = lblBeginValueNumber.Enabled;
            lblEndValueNumber.Enabled = (cbConditionNumber.Text == "BETWEEN");
            txtEndValueNumber.Enabled = lblEndValueNumber.Enabled;
        }

        private void cbCoditionCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBeginValueCurrency.Enabled = (cbCoditionCurrency.SelectedIndex != 0);
            lblEnvalueCurrency.Enabled = (cbCoditionCurrency.Text == "BETWEEN");
            txtBeginValueCurrency.Enabled = lblBeginValueCurrency.Enabled;
            txtEndValueCurrency.Enabled = lblEnvalueCurrency.Enabled;
        }

        private void cbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbConditionText_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValueText.Enabled = cbConditionText.SelectedIndex != 0;
            txtValueText.Enabled = lblValueText.Enabled;
        }

        private void cbConditionBool_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValueBoolean.Enabled = cbConditionBool.SelectedIndex != 0;
            chkCondition.Enabled = lblValueBoolean.Enabled;
        }

        private void btnShowSQL_Click(object sender, EventArgs e)
        {
          
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No creteria found.");
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void selectValueInCombo(ComboBoxEdit cb, String value)
        {
            int i = 0;
            foreach (String item in cb.Properties.Items)
            {
                if (item.ToUpper().Equals(value.ToUpper()))
                {
                    cb.SelectedIndex = i;
                    break;
                }
                i++;
            }
        }

        private void grFilters_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grFilters.SelectedRows.Count == 0) return;            
            DataRow r = dt.Rows[grFilters.SelectedRows[0].Index];
            String tbl = r["Table"].ToString() + r["View"].ToString();
            String field = r["Field"].ToString();
            Boolean isTable = r["Table"].ToString().Length > 0;
            ComboBoxEdit cb;
            ListBoxControl lb;
            if (isTable)
            {
                cb = cbTable;
                lb = lstTableFields;
            }
            else
            {
                cb = cbViews;
                lb = lstViewFields;
            }

            Boolean found = false;
            int i = 0;
            foreach (String item in cb.Properties.Items)
            {
                if (item.Equals(tbl, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    cb.SelectedIndex = i;
                    if (isTable) cbTable_SelectedIndexChanged(cb, e);
                    else cbViews_SelectedIndexChanged(cb, e);
                    break;
                }
                i++;
            }
            if (!found)
            {
                MessageBox.Show("Sorry, we could not find table or view: " + tbl);
                return;
            }
            found = false;
            i = 0;
            foreach (String item in lb.Items)
            {
                if (item.Equals(field, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    lb.SelectedIndex = i;
                    lstTableFields_SelectedIndexChanged(lb, e);
                    break;
                }
                i++;
            }
            if (!found)
            {
                MessageBox.Show("Sorry, we could not find field: " + field);
                return;
            }
            if (isTable) tabTablesViews.SelectedIndex = 0;
            else tabTablesViews.SelectedIndex = 1;
            tabTablesViews.Enabled = false;

            selectedRow = grFilters.SelectedRows[0].Index;
            editting = true;
            btnAdd.Text = "&OK";
            btnRemove.Text = "&Cancel";
            btnCancel.Enabled = false;
            btnBack.Enabled = false;
            btnOk.Enabled = false;
            byte colType = GetFieldGroup(type);
            selectValueInCombo(cbLogical, r["Logical"].ToString());
            switch (colType)
            {
                case TYPE_BOOL:
                    selectValueInCombo(cbConditionBool, r["Condition"].ToString());
                    chkCondition.Checked = bool.Parse(r["Value"].ToString());
                    break;
                case TYPE_CURRENCY:
                    selectValueInCombo(cbCoditionCurrency, r["Condition"].ToString());
                    txtFormatCurrency.Text = r["Format"].ToString();
                    txtCurrency.Text = r["Other"].ToString();
                    txtExchangeRate.Text = r["Rate"].ToString();
                    cbFormatCurrency.Text = txtFormatCurrency.Text;
                    txtBeginValueCurrency.Text = r["Value"].ToString();
                    txtEndValueCurrency.Text = r["Value2"].ToString();
                    break;
                case TYPE_DATETIME:
                    selectValueInCombo(cbConditionDateTime, r["Condition"].ToString());
                    cbDateTime.Text = r["Format"].ToString();
                    dtBeginValue.Text = r["Value"].ToString();
                    dtEndValue.Text = r["Value2"].ToString();
                    break;
                case TYPE_NUMBER:
                    selectValueInCombo(cbConditionNumber, r["Condition"].ToString());
                    cbFormatNumber.Text = r["Format"].ToString();
                    txtValueNumber.Text = r["Value"].ToString();
                    txtFormatNumber.Text = r["Format"].ToString();
                    txtEndValueNumber.Text = r["Value2"].ToString();                    
                    break;
                case TYPE_OTHER:
                    break;
                case TYPE_TEXT:
                    selectValueInCombo(cbConditionText, r["Condition"].ToString());
                    txtValueText.Text = (r["Value"].ToString());                    
                    break;
            }
        }

        private void frmCriterial_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = editting;
        }

        private void lstTableFields_DoubleClick(object sender, EventArgs e)
        {
            btnAdd_Click(btnAdd, e);
        }

        private void lstViewFields_DoubleClick(object sender, EventArgs e)
        {
            btnAdd_Click(btnAdd, e);
        }

        private void txtExchangeRate_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtExchangeRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '.' || e.KeyChar == ',') ;
            else e.KeyChar = (char)0;
        }

        private void changeInfor()
        {
            string cur = "";
            string format = "";
            string rate = "";
            switch (colType)
            {
                case TYPE_CURRENCY:
                    cur = txtCurrency.Text;
                    format = txtFormatCurrency.Text;
                    rate = txtExchangeRate.Text;
                    break;
                case TYPE_BOOL:
                case TYPE_OTHER:
                case TYPE_TEXT:
                    break;
                case TYPE_NUMBER:
                    format = txtFormatNumber.Text;
                    break;
                case TYPE_DATETIME:
                    format = cbDateTime.Text;
                    break;
            }            
            foreach (DataRow r in dt.Rows)
            {
                if (r["Table"].ToString() + r["View"].ToString() == tbl &&
                    r["Field"].ToString() == field)
                {
                    r["Other"] = cur;
                    r["Format"] = format;
                    r["Rate"] = rate;
                }
            }
        }

        private void txtCurrency_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cbFormatNumber_SelectedIndexChanged(object sender, EventArgs e)
        {            
            ComboBoxEdit cb = sender as ComboBoxEdit;
            TextEdit txt;
            if (sender == cbFormatNumber)
            {
                txt = txtFormatNumber;
            }
            else
            {
                txt = txtFormatCurrency;
            }
            if (cb.Text == "Custom")
            {
                fFormatNumber = new frmFormatNumber();
                if (fFormatNumber.ShowDialog() == DialogResult.OK)
                {
                    cb.Text = fFormatNumber.txtFormat.Text;
                    txt.Text = fFormatNumber.txtFormat.Text;
                }
                else
                {
                    cb.SelectedIndex = oldSelectedId;
                }
            }
            else
            {
                txt.Text = cb.Text;
            }
            oldSelectedId = cb.SelectedIndex;
        }

        private void cbDateTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDateTime.Text == "Custom")
            {
                frmFormatDateTime frm = new frmFormatDateTime();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    cbDateTime.Text = frm.txtFormat.Text;
                }
                else
                    cbDateTime.SelectedIndex = oldSelectedId;
            }
            oldSelectedId = cbDateTime.SelectedIndex;
        }
    }
}

