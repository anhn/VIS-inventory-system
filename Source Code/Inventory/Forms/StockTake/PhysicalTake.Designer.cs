namespace Inventory.Forms.StockTake
{
    partial class PhysicalTake
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
            this.chkViewStatus = new DevExpress.XtraEditors.CheckEdit();
            this.txtNotes = new DevExpress.XtraEditors.MemoEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.grdDetails = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repoWarehouseLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoLocationLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoProductLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoPackageLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoToWarehouseLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoToLocationLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(506, 57);
            this.btnFind.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(328, 57);
            this.btnAdd.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(417, 57);
            this.btnDelete.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(196, 333);
            this.btnSave.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(299, 333);
            this.btnClose.TabIndex = 10;
            // 
            // dtmDateCreated
            // 
            this.dtmDateCreated.Location = new System.Drawing.Point(422, 16);
            this.dtmDateCreated.Size = new System.Drawing.Size(159, 21);
            this.dtmDateCreated.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(324, 19);
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.Text = "Date Created:";
            // 
            // chkViewStatus
            // 
            this.chkViewStatus.Location = new System.Drawing.Point(389, 264);
            this.chkViewStatus.Name = "chkViewStatus";
            this.chkViewStatus.Properties.Caption = "Show Physical Take";
            this.chkViewStatus.Size = new System.Drawing.Size(143, 19);
            this.chkViewStatus.TabIndex = 8;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(62, 265);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(298, 53);
            this.txtNotes.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 14);
            this.label7.TabIndex = 26;
            this.label7.Text = "Notes:";
            // 
            // grdDetails
            // 
            this.grdDetails.EmbeddedNavigator.Name = "";
            this.grdDetails.Location = new System.Drawing.Point(19, 86);
            this.grdDetails.MainView = this.gridView1;
            this.grdDetails.Name = "grdDetails";
            this.grdDetails.Size = new System.Drawing.Size(575, 158);
            this.grdDetails.TabIndex = 6;
            this.grdDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdDetails;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(62, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 21);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 23;
            this.label2.Text = "*Name:";
            // 
            // PhysicalTake
            // 
            this.ClientSize = new System.Drawing.Size(606, 364);
            this.Controls.Add(this.chkViewStatus);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grdDetails);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "PhysicalTake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Physical Take";
            this.Load += new System.EventHandler(this.PhysicalTake_Load);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.dtmDateCreated, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.grdDetails, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtNotes, 0);
            this.Controls.SetChildIndex(this.chkViewStatus, 0);
            ((System.ComponentModel.ISupportInitialize)(this.repoWarehouseLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoLocationLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoProductLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoPackageLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoToWarehouseLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoToLocationLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkViewStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit chkViewStatus;
        private DevExpress.XtraEditors.MemoEdit txtNotes;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.GridControl grdDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private System.Windows.Forms.Label label2;
    }
}
