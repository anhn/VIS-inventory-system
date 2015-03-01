namespace Inventory
{
    partial class AddEditTax
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.dnTax = new DevExpress.XtraEditors.DataNavigator();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.lblName = new System.Windows.Forms.Label();
            this.txtTaxRate = new DevExpress.XtraEditors.TextEdit();
            this.lblViewStatus = new System.Windows.Forms.Label();
            this.rdoViewStatus = new DevExpress.XtraEditors.RadioGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.mmoDes = new DevExpress.XtraEditors.MemoEdit();
            this.txtUserID = new DevExpress.XtraEditors.TextEdit();
            this.txtTaxTypeID = new DevExpress.XtraEditors.TextEdit();
            this.cboTaxType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTax_code_id = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.mmoNote = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoViewStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmoDes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTaxType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTax_code_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoNote.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancel.Location = new System.Drawing.Point(304, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Close";
            // 
            // dnTax
            // 
            this.dnTax.Buttons.Append.Hint = "Add Record";
            this.dnTax.Buttons.CancelEdit.Hint = "Cancel Edit";
            this.dnTax.Buttons.EndEdit.Hint = "Save";
            this.dnTax.Buttons.First.Hint = "Go to the first Record";
            this.dnTax.Buttons.Last.Hint = "Go to the last Record";
            this.dnTax.Buttons.Next.Hint = "Go to the next Record";
            this.dnTax.Buttons.NextPage.Visible = false;
            this.dnTax.Buttons.Prev.Hint = "Go to the previous Record";
            this.dnTax.Buttons.PrevPage.Visible = false;
            this.dnTax.Buttons.Remove.Visible = false;
            this.dnTax.Location = new System.Drawing.Point(12, 319);
            this.dnTax.Name = "dnTax";
            this.dnTax.ShowToolTips = true;
            this.dnTax.Size = new System.Drawing.Size(225, 24);
            this.dnTax.TabIndex = 6;
            this.dnTax.Text = "dataNavigator1";
            this.dnTax.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.dnTax.Click += new System.EventHandler(this.dnTax_Click);
            this.dnTax.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.dnTax_ButtonClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(243, 320);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(5, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Description:";
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(91, 143);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTaxRate.Size = new System.Drawing.Size(134, 20);
            this.txtTaxRate.TabIndex = 3;
            // 
            // lblViewStatus
            // 
            this.lblViewStatus.AutoSize = true;
            this.lblViewStatus.Location = new System.Drawing.Point(5, 260);
            this.lblViewStatus.Name = "lblViewStatus";
            this.lblViewStatus.Size = new System.Drawing.Size(66, 13);
            this.lblViewStatus.TabIndex = 55;
            this.lblViewStatus.Text = "View Status:";
            // 
            // rdoViewStatus
            // 
            this.rdoViewStatus.EditValue = true;
            this.rdoViewStatus.Location = new System.Drawing.Point(91, 250);
            this.rdoViewStatus.Name = "rdoViewStatus";
            this.rdoViewStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Enable"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Disable")});
            this.rdoViewStatus.Size = new System.Drawing.Size(276, 28);
            this.rdoViewStatus.TabIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.mmoDes);
            this.panelControl1.Controls.Add(this.txtUserID);
            this.panelControl1.Controls.Add(this.txtTaxTypeID);
            this.panelControl1.Controls.Add(this.cboTaxType);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtTax_code_id);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.mmoNote);
            this.panelControl1.Controls.Add(this.rdoViewStatus);
            this.panelControl1.Controls.Add(this.lblViewStatus);
            this.panelControl1.Controls.Add(this.txtTaxRate);
            this.panelControl1.Controls.Add(this.lblName);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(384, 296);
            this.panelControl1.TabIndex = 9;
            this.panelControl1.Text = "panelControl1";
            // 
            // mmoDes
            // 
            this.mmoDes.Location = new System.Drawing.Point(91, 63);
            this.mmoDes.Name = "mmoDes";
            this.mmoDes.Size = new System.Drawing.Size(276, 57);
            this.mmoDes.TabIndex = 2;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(207, 91);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 68;
            // 
            // txtTaxTypeID
            // 
            this.txtTaxTypeID.Location = new System.Drawing.Point(112, 75);
            this.txtTaxTypeID.Name = "txtTaxTypeID";
            this.txtTaxTypeID.Size = new System.Drawing.Size(134, 20);
            this.txtTaxTypeID.TabIndex = 66;
            this.txtTaxTypeID.EditValueChanged += new System.EventHandler(this.txtTaxTypeID_EditValueChanged);
            // 
            // cboTaxType
            // 
            this.cboTaxType.Location = new System.Drawing.Point(91, 19);
            this.cboTaxType.Name = "cboTaxType";
            this.cboTaxType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cboTaxType.Properties.MaxLength = 50;
            this.cboTaxType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboTaxType.Size = new System.Drawing.Size(173, 20);
            this.cboTaxType.TabIndex = 1;
            this.cboTaxType.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cboTaxType_ButtonClick);
            this.cboTaxType.SelectedIndexChanged += new System.EventHandler(this.cboTaxType_SelectedIndexChanged);
            this.cboTaxType.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cboTaxType_ButtonPressed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Note:";
            // 
            // txtTax_code_id
            // 
            this.txtTax_code_id.Location = new System.Drawing.Point(207, 75);
            this.txtTax_code_id.Name = "txtTax_code_id";
            this.txtTax_code_id.Size = new System.Drawing.Size(134, 20);
            this.txtTax_code_id.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Rate:";
            // 
            // mmoNote
            // 
            this.mmoNote.Location = new System.Drawing.Point(91, 181);
            this.mmoNote.Name = "mmoNote";
            this.mmoNote.Size = new System.Drawing.Size(276, 57);
            this.mmoNote.TabIndex = 4;
            // 
            // AddEditTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 359);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dnTax);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditTax";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditTax";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditTax_FormClosing);
            this.Load += new System.EventHandler(this.AddEditTax_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoViewStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmoDes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTaxType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTax_code_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoNote.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.DataNavigator dnTax;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.Label lblName;
        private DevExpress.XtraEditors.TextEdit txtTaxRate;
        private System.Windows.Forms.Label lblViewStatus;
        private DevExpress.XtraEditors.RadioGroup rdoViewStatus;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.MemoEdit mmoNote;
        private DevExpress.XtraEditors.TextEdit txtTax_code_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit cboTaxType;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtTaxTypeID;
        private DevExpress.XtraEditors.MemoEdit mmoDes;
        private DevExpress.XtraEditors.TextEdit txtUserID;
    }
}