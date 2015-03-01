namespace Inventory.Forms.StockTake
{
    partial class PeriodClosing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.chkViewState = new DevExpress.XtraEditors.CheckEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboEndYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboStartYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboEndMonth = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboStartMonth = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboEndDay = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboStartDay = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClosePeriod = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEndYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStartYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEndMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStartMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEndDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStartDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chkViewState);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txtDescription);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.cboEndYear);
            this.groupControl1.Controls.Add(this.cboStartYear);
            this.groupControl1.Controls.Add(this.cboEndMonth);
            this.groupControl1.Controls.Add(this.cboStartMonth);
            this.groupControl1.Controls.Add(this.cboEndDay);
            this.groupControl1.Controls.Add(this.cboStartDay);
            this.groupControl1.Controls.Add(this.cboType);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(12, 10);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(585, 133);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Period";
            // 
            // chkViewState
            // 
            this.chkViewState.EditValue = true;
            this.chkViewState.Location = new System.Drawing.Point(299, 106);
            this.chkViewState.Name = "chkViewState";
            this.chkViewState.Properties.Caption = "View State";
            this.chkViewState.Size = new System.Drawing.Size(100, 19);
            this.chkViewState.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(299, 36);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(273, 65);
            this.txtDescription.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "(YYYY-MM-DD)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "End Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Date";
            // 
            // cboEndYear
            // 
            this.cboEndYear.Enabled = false;
            this.cboEndYear.Location = new System.Drawing.Point(98, 82);
            this.cboEndYear.Name = "cboEndYear";
            this.cboEndYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboEndYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboEndYear.Size = new System.Drawing.Size(65, 23);
            this.cboEndYear.TabIndex = 5;
            // 
            // cboStartYear
            // 
            this.cboStartYear.Location = new System.Drawing.Point(98, 55);
            this.cboStartYear.Name = "cboStartYear";
            this.cboStartYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStartYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboStartYear.Size = new System.Drawing.Size(65, 23);
            this.cboStartYear.TabIndex = 2;
            this.cboStartYear.SelectedIndexChanged += new System.EventHandler(this.InputChangedEvent);
            // 
            // cboEndMonth
            // 
            this.cboEndMonth.Enabled = false;
            this.cboEndMonth.Location = new System.Drawing.Point(169, 82);
            this.cboEndMonth.Name = "cboEndMonth";
            this.cboEndMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboEndMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboEndMonth.Size = new System.Drawing.Size(45, 23);
            this.cboEndMonth.TabIndex = 6;
            // 
            // cboStartMonth
            // 
            this.cboStartMonth.Location = new System.Drawing.Point(169, 55);
            this.cboStartMonth.Name = "cboStartMonth";
            this.cboStartMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStartMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboStartMonth.Size = new System.Drawing.Size(45, 23);
            this.cboStartMonth.TabIndex = 3;
            this.cboStartMonth.SelectedIndexChanged += new System.EventHandler(this.InputChangedEvent);
            // 
            // cboEndDay
            // 
            this.cboEndDay.Enabled = false;
            this.cboEndDay.Location = new System.Drawing.Point(220, 82);
            this.cboEndDay.Name = "cboEndDay";
            this.cboEndDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboEndDay.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.cboEndDay.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboEndDay.Size = new System.Drawing.Size(44, 23);
            this.cboEndDay.TabIndex = 7;
            // 
            // cboStartDay
            // 
            this.cboStartDay.Location = new System.Drawing.Point(220, 55);
            this.cboStartDay.Name = "cboStartDay";
            this.cboStartDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStartDay.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.cboStartDay.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboStartDay.Size = new System.Drawing.Size(44, 23);
            this.cboStartDay.TabIndex = 4;
            this.cboStartDay.SelectedIndexChanged += new System.EventHandler(this.InputChangedEvent);
            // 
            // cboType
            // 
            this.cboType.Location = new System.Drawing.Point(98, 18);
            this.cboType.Name = "cboType";
            this.cboType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboType.Size = new System.Drawing.Size(166, 23);
            this.cboType.TabIndex = 1;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.InputChangedEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Period Type";
            // 
            // btnClosePeriod
            // 
            this.btnClosePeriod.Location = new System.Drawing.Point(433, 154);
            this.btnClosePeriod.Name = "btnClosePeriod";
            this.btnClosePeriod.Size = new System.Drawing.Size(81, 21);
            this.btnClosePeriod.TabIndex = 10;
            this.btnClosePeriod.Text = "Close &Period";
            this.btnClosePeriod.Click += new System.EventHandler(this.btnClosePeriod_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(529, 154);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 21);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "&Cancel";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PeriodClosing
            // 
            this.AcceptButton = this.btnClosePeriod;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(611, 181);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClosePeriod);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PeriodClosing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Close Period";
            this.Load += new System.EventHandler(this.PeriodClosing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEndYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStartYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEndMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStartMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEndDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStartDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboType.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnClosePeriod;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.CheckEdit chkViewState;
        private DevExpress.XtraEditors.ComboBoxEdit cboStartYear;
        private DevExpress.XtraEditors.ComboBoxEdit cboStartMonth;
        private DevExpress.XtraEditors.ComboBoxEdit cboStartDay;
        private DevExpress.XtraEditors.ComboBoxEdit cboEndYear;
        private DevExpress.XtraEditors.ComboBoxEdit cboEndMonth;
        private DevExpress.XtraEditors.ComboBoxEdit cboEndDay;
    }
}