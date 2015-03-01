namespace Inventory
{
    partial class AddEditPayment
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.memoNote = new DevExpress.XtraEditors.MemoEdit();
            this.txtLastUpdatedDate = new DevExpress.XtraEditors.TextEdit();
            this.txtUserID = new DevExpress.XtraEditors.TextEdit();
            this.txtPaymentsDay = new DevExpress.XtraEditors.TextEdit();
            this.txtDiscountDay = new DevExpress.XtraEditors.TextEdit();
            this.txtDiscountPercent = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoViewStatus = new DevExpress.XtraEditors.RadioGroup();
            this.lblViewStatus = new System.Windows.Forms.Label();
            this.txtPaymentTermsName = new DevExpress.XtraEditors.TextEdit();
            this.lblName = new System.Windows.Forms.Label();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.dnPayment = new DevExpress.XtraEditors.DataNavigator();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastUpdatedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentsDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoViewStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentTermsName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.memoNote);
            this.panelControl1.Controls.Add(this.txtLastUpdatedDate);
            this.panelControl1.Controls.Add(this.txtUserID);
            this.panelControl1.Controls.Add(this.txtPaymentsDay);
            this.panelControl1.Controls.Add(this.txtDiscountDay);
            this.panelControl1.Controls.Add(this.txtDiscountPercent);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.rdoViewStatus);
            this.panelControl1.Controls.Add(this.lblViewStatus);
            this.panelControl1.Controls.Add(this.txtPaymentTermsName);
            this.panelControl1.Controls.Add(this.lblName);
            this.panelControl1.Controls.Add(this.txtId);
            this.panelControl1.Location = new System.Drawing.Point(12, 13);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(430, 277);
            this.panelControl1.TabIndex = 12;
            this.panelControl1.Text = "panelControl1";
            // 
            // memoNote
            // 
            this.memoNote.Location = new System.Drawing.Point(140, 33);
            this.memoNote.Name = "memoNote";
            this.memoNote.Size = new System.Drawing.Size(272, 89);
            this.memoNote.TabIndex = 2;
            // 
            // txtLastUpdatedDate
            // 
            this.txtLastUpdatedDate.Location = new System.Drawing.Point(220, 59);
            this.txtLastUpdatedDate.Name = "txtLastUpdatedDate";
            this.txtLastUpdatedDate.Size = new System.Drawing.Size(100, 21);
            this.txtLastUpdatedDate.TabIndex = 67;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(230, 83);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 21);
            this.txtUserID.TabIndex = 66;
            // 
            // txtPaymentsDay
            // 
            this.txtPaymentsDay.EditValue = "0";
            this.txtPaymentsDay.Location = new System.Drawing.Point(140, 130);
            this.txtPaymentsDay.Name = "txtPaymentsDay";
            this.txtPaymentsDay.Size = new System.Drawing.Size(100, 21);
            this.txtPaymentsDay.TabIndex = 3;
            // 
            // txtDiscountDay
            // 
            this.txtDiscountDay.EditValue = "0";
            this.txtDiscountDay.Location = new System.Drawing.Point(140, 162);
            this.txtDiscountDay.Name = "txtDiscountDay";
            this.txtDiscountDay.Size = new System.Drawing.Size(100, 21);
            this.txtDiscountDay.TabIndex = 4;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.EditValue = "0.00";
            this.txtDiscountPercent.Location = new System.Drawing.Point(140, 202);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.Properties.Mask.EditMask = "n2";
            this.txtDiscountPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscountPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDiscountPercent.Size = new System.Drawing.Size(100, 21);
            this.txtDiscountPercent.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 14);
            this.label4.TabIndex = 65;
            this.label4.Text = "Discount Percent:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 14);
            this.label3.TabIndex = 64;
            this.label3.Text = "Payments Day:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 63;
            this.label2.Text = "Discount Day:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 62;
            this.label1.Text = "Note:";
            // 
            // rdoViewStatus
            // 
            this.rdoViewStatus.EditValue = true;
            this.rdoViewStatus.Location = new System.Drawing.Point(140, 238);
            this.rdoViewStatus.Name = "rdoViewStatus";
            this.rdoViewStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Enable"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Disable")});
            this.rdoViewStatus.Size = new System.Drawing.Size(176, 26);
            this.rdoViewStatus.TabIndex = 6;
            // 
            // lblViewStatus
            // 
            this.lblViewStatus.AutoSize = true;
            this.lblViewStatus.Location = new System.Drawing.Point(6, 252);
            this.lblViewStatus.Name = "lblViewStatus";
            this.lblViewStatus.Size = new System.Drawing.Size(77, 14);
            this.lblViewStatus.TabIndex = 57;
            this.lblViewStatus.Text = "View Status:";
            // 
            // txtPaymentTermsName
            // 
            this.txtPaymentTermsName.Location = new System.Drawing.Point(140, 9);
            this.txtPaymentTermsName.Name = "txtPaymentTermsName";
            this.txtPaymentTermsName.Size = new System.Drawing.Size(272, 21);
            this.txtPaymentTermsName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 14);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Payment Terms Name:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(190, 92);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(79, 21);
            this.txtId.TabIndex = 60;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancel.Location = new System.Drawing.Point(373, 307);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 21);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Close";
            // 
            // dnPayment
            // 
            this.dnPayment.Buttons.Append.Hint = "Add Record";
            this.dnPayment.Buttons.CancelEdit.Hint = "Cancel Edit";
            this.dnPayment.Buttons.EndEdit.Hint = "Save";
            this.dnPayment.Buttons.First.Hint = "Go to the first Record";
            this.dnPayment.Buttons.Last.Hint = "Go to the last Record";
            this.dnPayment.Buttons.Next.Hint = "Go to the next Record";
            this.dnPayment.Buttons.NextPage.Visible = false;
            this.dnPayment.Buttons.Prev.Hint = "Go to the previous Record";
            this.dnPayment.Buttons.PrevPage.Visible = false;
            this.dnPayment.Buttons.Remove.Visible = false;
            this.dnPayment.Location = new System.Drawing.Point(12, 306);
            this.dnPayment.Name = "dnPayment";
            this.dnPayment.ShowToolTips = true;
            this.dnPayment.Size = new System.Drawing.Size(214, 22);
            this.dnPayment.TabIndex = 7;
            this.dnPayment.Text = "dataNavigator1";
            this.dnPayment.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.dnPayment.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.dnPayment_ButtonClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(242, 306);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 21);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AddEditPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 340);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dnPayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditPayment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditPayment_FormClosing);
            this.Load += new System.EventHandler(this.AddEditPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastUpdatedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentsDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoViewStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentTermsName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtPaymentTermsName;
        private System.Windows.Forms.Label lblName;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.DataNavigator dnPayment;
        private DevExpress.XtraEditors.RadioGroup rdoViewStatus;
        private System.Windows.Forms.Label lblViewStatus;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtPaymentsDay;
        private DevExpress.XtraEditors.TextEdit txtDiscountDay;
        private DevExpress.XtraEditors.TextEdit txtDiscountPercent;
        private DevExpress.XtraEditors.MemoEdit memoNote;
        private DevExpress.XtraEditors.TextEdit txtLastUpdatedDate;
        private DevExpress.XtraEditors.TextEdit txtUserID;
    }
}