using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;
using System.Xml;
using System.Data;
using System.Data.SqlClient;


using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Columns;
using System.Collections.Generic;
using DevExpress.Utils;



namespace Inventory
{
	/// <summary>
	/// Summary description for frmWareHouse.
	/// </summary>
	public class frmLocationMaster : DevExpress.XtraEditors.XtraForm
	{
		private GroupControl grbLeft;
		private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
		private GroupControl grbCenter;
		private SimpleButton btnDelete;
		private SimpleButton btnCreate;
		private Label label1;
        private Label label4;
		private TreeView treLeft;
		private ListView lsvLocation;
		private GroupControl groupControl2;
		private SimpleButton btnCancel;
		private SimpleButton btnOk;
        private GroupControl grbProductManager;
		private GroupControl grbTop;
		private SimpleButton btnAdd;
        private SimpleButton btnRemove;
        private Label label12;
        private SimpleButton btnEdit;
        private TextEdit txtWarehouse;
		private TextEdit txtParent_location_id;
        private TextEdit txtBin_location_id;
        private System.Windows.Forms.ComboBox cboLocationMaster;
        private GroupControl grbWarehouse;
        private Label label6;
        private Label label5;
        private TextEdit txtCity;
        private TextEdit txtDescription;
        private Label label7;
        private Label label9;
        private Label label10;
        private SimpleButton btnEditProduct;
        private DevExpress.XtraGrid.GridControl grdProduct;
        private GridView grvProduct;
        private Label lblNote;
        private MemoEdit memNotes;
        private Label label2;
        private MemoEdit memAddress_line_2;
        private MemoEdit memAddress__line;
		private IContainer components;

		public frmLocationMaster()
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
            this.components = new System.ComponentModel.Container();
            this.grbLeft = new DevExpress.XtraEditors.GroupControl();
            this.treLeft = new System.Windows.Forms.TreeView();
            this.cboLocationMaster = new System.Windows.Forms.ComboBox();
            this.grbWarehouse = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            this.memAddress_line_2 = new DevExpress.XtraEditors.MemoEdit();
            this.memAddress__line = new DevExpress.XtraEditors.MemoEdit();
            this.txtCity = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.lsvLocation = new System.Windows.Forms.ListView();
            this.grbCenter = new DevExpress.XtraEditors.GroupControl();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWarehouse = new DevExpress.XtraEditors.TextEdit();
            this.txtParent_location_id = new DevExpress.XtraEditors.TextEdit();
            this.txtBin_location_id = new DevExpress.XtraEditors.TextEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.memNotes = new DevExpress.XtraEditors.MemoEdit();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.grbProductManager = new DevExpress.XtraEditors.GroupControl();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.grbTop = new DevExpress.XtraEditors.GroupControl();
            this.grdProduct = new DevExpress.XtraGrid.GridControl();
            this.grvProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grbLeft)).BeginInit();
            this.grbLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbWarehouse)).BeginInit();
            this.grbWarehouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memAddress_line_2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memAddress__line.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbCenter)).BeginInit();
            this.grbCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarehouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParent_location_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBin_location_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbProductManager)).BeginInit();
            this.grbProductManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbTop)).BeginInit();
            this.grbTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // grbLeft
            // 
            this.grbLeft.Controls.Add(this.treLeft);
            this.grbLeft.Controls.Add(this.cboLocationMaster);
            this.grbLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbLeft.Location = new System.Drawing.Point(0, 0);
            this.grbLeft.Name = "grbLeft";
            this.grbLeft.ShowCaption = false;
            this.grbLeft.Size = new System.Drawing.Size(200, 518);
            this.grbLeft.TabIndex = 0;
            this.grbLeft.Text = "groupControl1";
            // 
            // treLeft
            // 
            this.treLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treLeft.Location = new System.Drawing.Point(2, 2);
            this.treLeft.Name = "treLeft";
            this.treLeft.Size = new System.Drawing.Size(196, 514);
            this.treLeft.TabIndex = 0;
            this.treLeft.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treLeft_MouseClick);
            this.treLeft.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treLeft_AfterSelect);
            // 
            // cboLocationMaster
            // 
            this.cboLocationMaster.FormattingEnabled = true;
            this.cboLocationMaster.Location = new System.Drawing.Point(51, 419);
            this.cboLocationMaster.Name = "cboLocationMaster";
            this.cboLocationMaster.Size = new System.Drawing.Size(121, 21);
            this.cboLocationMaster.TabIndex = 28;
            this.cboLocationMaster.SelectedValueChanged += new System.EventHandler(this.cboLocationMaster_SelectedValueChanged);
            // 
            // grbWarehouse
            // 
            this.grbWarehouse.Controls.Add(this.label2);
            this.grbWarehouse.Controls.Add(this.memAddress_line_2);
            this.grbWarehouse.Controls.Add(this.memAddress__line);
            this.grbWarehouse.Controls.Add(this.txtCity);
            this.grbWarehouse.Controls.Add(this.txtDescription);
            this.grbWarehouse.Controls.Add(this.label7);
            this.grbWarehouse.Controls.Add(this.label9);
            this.grbWarehouse.Controls.Add(this.label10);
            this.grbWarehouse.Controls.Add(this.label6);
            this.grbWarehouse.Location = new System.Drawing.Point(0, 0);
            this.grbWarehouse.Name = "grbWarehouse";
            this.grbWarehouse.ShowCaption = false;
            this.grbWarehouse.Size = new System.Drawing.Size(588, 273);
            this.grbWarehouse.TabIndex = 29;
            this.grbWarehouse.Text = "groupControl4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Address 2:";
            // 
            // memAddress_line_2
            // 
            this.memAddress_line_2.Location = new System.Drawing.Point(169, 174);
            this.memAddress_line_2.Name = "memAddress_line_2";
            this.memAddress_line_2.Size = new System.Drawing.Size(368, 46);
            this.memAddress_line_2.TabIndex = 2;
            // 
            // memAddress__line
            // 
            this.memAddress__line.Location = new System.Drawing.Point(169, 107);
            this.memAddress__line.Name = "memAddress__line";
            this.memAddress__line.Size = new System.Drawing.Size(368, 46);
            this.memAddress__line.TabIndex = 1;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(169, 237);
            this.txtCity.Name = "txtCity";
            this.txtCity.Properties.MaxLength = 20;
            this.txtCity.Size = new System.Drawing.Size(368, 20);
            this.txtCity.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(169, 70);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.MaxLength = 50;
            this.txtDescription.Size = new System.Drawing.Size(368, 20);
            this.txtDescription.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "City:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Address 1:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Warehouse Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(190, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Warehouse Information";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(304, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(116, 10);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "&Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.defaultLookAndFeel1.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // lsvLocation
            // 
            this.lsvLocation.AutoArrange = false;
            this.lsvLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvLocation.Location = new System.Drawing.Point(2, 2);
            this.lsvLocation.Name = "lsvLocation";
            this.lsvLocation.Size = new System.Drawing.Size(588, 205);
            this.lsvLocation.TabIndex = 1;
            this.lsvLocation.UseCompatibleStateImageBehavior = false;
            this.lsvLocation.View = System.Windows.Forms.View.List;
            this.lsvLocation.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvLocation_MouseDoubleClick);
            this.lsvLocation.SelectedIndexChanged += new System.EventHandler(this.lsvLocation_SelectedIndexChanged);
            // 
            // grbCenter
            // 
            this.grbCenter.Controls.Add(this.grbWarehouse);
            this.grbCenter.Controls.Add(this.label5);
            this.grbCenter.Controls.Add(this.txtWarehouse);
            this.grbCenter.Controls.Add(this.txtParent_location_id);
            this.grbCenter.Controls.Add(this.txtBin_location_id);
            this.grbCenter.Controls.Add(this.label12);
            this.grbCenter.Controls.Add(this.label4);
            this.grbCenter.Controls.Add(this.label1);
            this.grbCenter.Controls.Add(this.lblNote);
            this.grbCenter.Controls.Add(this.memNotes);
            this.grbCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbCenter.Location = new System.Drawing.Point(200, 209);
            this.grbCenter.Name = "grbCenter";
            this.grbCenter.ShowCaption = false;
            this.grbCenter.Size = new System.Drawing.Size(592, 309);
            this.grbCenter.TabIndex = 3;
            this.grbCenter.Text = "groupControl4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(207, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Location Information";
            // 
            // txtWarehouse
            // 
            this.txtWarehouse.Location = new System.Drawing.Point(280, 142);
            this.txtWarehouse.Name = "txtWarehouse";
            this.txtWarehouse.Properties.Mask.EditMask = "n0";
            this.txtWarehouse.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtWarehouse.Properties.ReadOnly = true;
            this.txtWarehouse.Size = new System.Drawing.Size(213, 20);
            this.txtWarehouse.TabIndex = 2;
            // 
            // txtParent_location_id
            // 
            this.txtParent_location_id.Location = new System.Drawing.Point(280, 106);
            this.txtParent_location_id.Name = "txtParent_location_id";
            this.txtParent_location_id.Properties.Mask.EditMask = "n0";
            this.txtParent_location_id.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtParent_location_id.Properties.ReadOnly = true;
            this.txtParent_location_id.Size = new System.Drawing.Size(213, 20);
            this.txtParent_location_id.TabIndex = 1;
            // 
            // txtBin_location_id
            // 
            this.txtBin_location_id.EditValue = " ";
            this.txtBin_location_id.Location = new System.Drawing.Point(280, 71);
            this.txtBin_location_id.Name = "txtBin_location_id";
            this.txtBin_location_id.Properties.Mask.EditMask = "G";
            this.txtBin_location_id.Properties.ReadOnly = true;
            this.txtBin_location_id.Size = new System.Drawing.Size(213, 20);
            this.txtBin_location_id.TabIndex = 0;
            this.txtBin_location_id.EditValueChanged += new System.EventHandler(this.txtBin_location_id_EditValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(112, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parent:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Warehouse:";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(112, 176);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(34, 13);
            this.lblNote.TabIndex = 44;
            this.lblNote.Text = "Note:";
            // 
            // memNotes
            // 
            this.memNotes.Location = new System.Drawing.Point(280, 174);
            this.memNotes.Name = "memNotes";
            this.memNotes.Size = new System.Drawing.Size(213, 57);
            this.memNotes.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(210, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnCancel);
            this.groupControl2.Controls.Add(this.btnOk);
            this.groupControl2.Controls.Add(this.btnEdit);
            this.groupControl2.Controls.Add(this.btnCreate);
            this.groupControl2.Controls.Add(this.btnDelete);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(200, 478);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(592, 40);
            this.groupControl2.TabIndex = 15;
            this.groupControl2.Text = "groupControl1";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(492, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cance&l";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(398, 10);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "&Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // grbProductManager
            // 
            this.grbProductManager.Controls.Add(this.btnRemove);
            this.grbProductManager.Controls.Add(this.btnEditProduct);
            this.grbProductManager.Controls.Add(this.btnAdd);
            this.grbProductManager.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbProductManager.Location = new System.Drawing.Point(493, 2);
            this.grbProductManager.Name = "grbProductManager";
            this.grbProductManager.ShowCaption = false;
            this.grbProductManager.Size = new System.Drawing.Size(97, 205);
            this.grbProductManager.TabIndex = 0;
            this.grbProductManager.Paint += new System.Windows.Forms.PaintEventHandler(this.grbProductManager_Paint);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(11, 132);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(12, 93);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(75, 23);
            this.btnEditProduct.TabIndex = 1;
            this.btnEditProduct.Text = "&Edit";
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grbTop
            // 
            this.grbTop.Controls.Add(this.grdProduct);
            this.grbTop.Controls.Add(this.grbProductManager);
            this.grbTop.Controls.Add(this.lsvLocation);
            this.grbTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbTop.Location = new System.Drawing.Point(200, 0);
            this.grbTop.Name = "grbTop";
            this.grbTop.ShowCaption = false;
            this.grbTop.Size = new System.Drawing.Size(592, 209);
            this.grbTop.TabIndex = 2;
            this.grbTop.Text = "groupControl2";
            // 
            // grdProduct
            // 
            this.grdProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProduct.EmbeddedNavigator.Name = "";
            this.grdProduct.Location = new System.Drawing.Point(2, 2);
            this.grdProduct.MainView = this.grvProduct;
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.Size = new System.Drawing.Size(491, 205);
            this.grdProduct.TabIndex = 0;
            this.grdProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvProduct});
            // 
            // grvProduct
            // 
            this.grvProduct.GridControl = this.grdProduct;
            this.grvProduct.Name = "grvProduct";
            this.grvProduct.OptionsBehavior.Editable = false;
            this.grvProduct.OptionsCustomization.AllowGroup = false;
            this.grvProduct.OptionsView.ShowGroupPanel = false;
            // 
            // frmLocationMaster
            // 
            this.ClientSize = new System.Drawing.Size(792, 518);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.grbCenter);
            this.Controls.Add(this.grbTop);
            this.Controls.Add(this.grbLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLocationMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Location";
            this.Load += new System.EventHandler(this.frmLocationMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grbLeft)).EndInit();
            this.grbLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbWarehouse)).EndInit();
            this.grbWarehouse.ResumeLayout(false);
            this.grbWarehouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memAddress_line_2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memAddress__line.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbCenter)).EndInit();
            this.grbCenter.ResumeLayout(false);
            this.grbCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarehouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParent_location_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBin_location_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbProductManager)).EndInit();
            this.grbProductManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbTop)).EndInit();
            this.grbTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProduct)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        #region Variable
        DataView dvProductLocation;
        DataTable dtProductLocation;
        #endregion
        #region Method

        private bool CheckExistLocationInProductLocation()
        {
            DataRow[] arrRow = Globals.dtProductLocation.Select("True");
            for (int i = 0; i<arrRow.Length; i++)
            {
                if (arrRow[i]["LocationID"].ToString() == txtBin_location_id.Text)
                {
                    return true;
                }
            }
            return false;
        }
        private void LoadButton()
        {
            
            if (!Globals.isAdministrator)
            {
                btnAdd.Enabled = false;
                btnEditProduct.Enabled = false;
                btnRemove.Enabled = false;
                btnCreate.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;

            }
            else
            {
                if (grvProduct.FocusedRowHandle < 0)
                {
                    btnEditProduct.Enabled = false;
                    btnRemove.Enabled = false;
                }
                else
                {
                    btnEditProduct.Enabled = true;
                    btnRemove.Enabled = true;
                }
                if (treLeft.Nodes.Count > 0 && treLeft.SelectedNode != null)
                {
                    try
                    {
                        if (treLeft.SelectedNode.Parent == null || Globals.dtLocation_Master.Rows.Count <= 0)
                        {
                            btnEdit.Enabled = false;
                            btnDelete.Enabled = false;
                        }
                        else
                        {
                            btnEdit.Enabled = true;
                            btnDelete.Enabled = true;
                        }
                    }
                    catch
                    {
                    }
                }
                else
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
                btnAdd.Enabled = true;
                btnCreate.Enabled = true;

            }
        }
        private void LoadProductLocation()
        {
            DataRow[] arrProductLocation=Globals.dtProductLocation.Select("LocationID='"+txtBin_location_id.Text+"'");
            DA_DataTable dtProductLocation = Globals.dtProductLocation.RowToDA_DataTable(arrProductLocation);
            grdProduct.DataSource = dtProductLocation;
            
         
            //dvProductLocation.RowFilter="LocationID='"+txtBin_location_id.Text+"'";
            for (int i = 0; i < dtProductLocation.Rows.Count; i++)
            {
                for (int j = 0; j < Globals.dtProductMaster.Rows.Count; j++)
                {
                    if (dtProductLocation.Rows[i]["ProductID"].ToString() == Globals.dtProductMaster.Rows[j]["ProductID"].ToString())
                    {
                        dtProductLocation.Rows[i]["ProductID"] = Globals.dtProductMaster.Rows[j]["ProductName"].ToString();
                    }
                }
            }
            foreach (GridColumn col in grvProduct.Columns)
            {
                col.VisibleIndex = -1;
            }
            if (dtProductLocation.Rows.Count > 0)
            {
                grvProduct.Columns["ProductID"].VisibleIndex = 0;
                grvProduct.Columns["Qty_allocated"].VisibleIndex = 1;
                grvProduct.Columns["Qty_on_hand"].VisibleIndex = 2;
                grvProduct.Columns["ProductID"].Caption = "Product Name";
                grvProduct.Columns["Qty_allocated"].Caption = "Quantity Allocated";
                grvProduct.Columns["Qty_on_hand"].Caption = "Quantity On Hand";
            }

        }
        private void LoadWarehouseName()
        {
            for (int i = 0; i < Globals.dtWarehouse_Master.Rows.Count;i++)
            {
                if (Globals.dtWarehouse_Master.Rows[i]["Warehouse_id"].ToString() == Globals.dtLocation_Master.Rows[cboLocationMaster.SelectedIndex]["Warehouse_id"].ToString())
                {
                    txtWarehouse.Text = Globals.dtWarehouse_Master.Rows[i]["Description"].ToString();
                }
            }
        }
        private void LoadNode()
        {
            treLeft.Nodes.Clear();

            for (int i = 0; i < Globals.dtWarehouse_Master.Rows.Count; i++)
            {
                TreeNode nodeRoot = new TreeNode(Globals.dtWarehouse_Master.Rows[i]["Description"].ToString());
                nodeRoot.Name = Globals.dtWarehouse_Master.Rows[i]["Warehouse_id"].ToString();
                treLeft.Nodes.Add(nodeRoot);
                foreach (DataRow dtRow in Globals.dtLocation_Master.Rows)
                {
                    if (dtRow.RowState != DataRowState.Deleted && dtRow["Warehouse_id"].ToString() == nodeRoot.Name)
                    {
                        if (dtRow["Parent_location_id"].ToString() == "" || dtRow["Parent_location_id"].ToString() == null)
                        {
                            TreeNode node = nodeRoot.Nodes.Add(dtRow["Bin_location_id"].ToString());
                            node.Name = dtRow["Bin_location_id"].ToString();
                            LoadNode(node, dtRow["Bin_location_id"].ToString());
                        }
                    }
                }
            }
            treLeft.ExpandAll();
            if (treLeft.Nodes.Count > 0)
            {
                treLeft.SelectedNode = treLeft.Nodes[0];
            }
        }
        private void LoadComponent()
        {

            LoadLocationInformation();
            LoadNode();
         }
        private void LoadLocationInformation()
        {
            
            for (int i = 0; i < Globals.dtLocation_Master.Rows.Count; i++)
            {

                if (Globals.dtLocation_Master.Rows[i].RowState != DataRowState.Deleted)
                {
                    try
                    {
                        if (Globals.dtLocation_Master.Rows[i]["Bin_location_id"].ToString() == treLeft.SelectedNode.Name)
                        {

                            txtBin_location_id.Text = Globals.dtLocation_Master.Rows[i]["Bin_location_id"].ToString();
                            memNotes.Text = Globals.dtLocation_Master.Rows[i]["Notes"].ToString();
                            txtParent_location_id.Text = Globals.dtLocation_Master.Rows[i]["Parent_location_id"].ToString();
                            return;
                        }
                    }
                    catch
                    {
                    }
           

                }
            }
           
        }
        private void LoadNode(TreeNode parentNode, string ParentID)
        {
            DataRow[] rows;

            rows = Globals.dtLocation_Master.Select("Parent_location_id = '" + ParentID + "'");
            foreach (DataRow dtRow in rows)
            {
                if (dtRow.RowState != DataRowState.Deleted)
                {
                    TreeNode node = parentNode.Nodes.Add(dtRow["Bin_location_id"].ToString(), dtRow["Bin_location_id"].ToString());
                    node.Name = dtRow["Bin_location_id"].ToString();
                    LoadNode(node, dtRow["Bin_location_id"].ToString());
                }
            }
        }

        private TreeNode tnCurrentNode;
        private void PerformDoubleClick(TreeNode note)
        {
            lsvLocation.Items.Clear();


            if (note.Nodes.Count == 0 && note.Parent != null)
            {// la
                grdProduct.Visible = true;
                grbProductManager.Visible = true;

                lsvLocation.Visible = true;
    
                tnCurrentNode = note;
            }
            else
            {
                grdProduct.Visible = false;
                grbProductManager.Visible = false;
                lsvLocation.Visible = true;
                for (int i = 0; i < note.Nodes.Count; i++)
                {
                    lsvLocation.Items.Add(note.Nodes[i].Text);

                }
            }
            // load data
            if (note.Parent != null)
            {
                if (note.Name != "")
                {
              
                    cboLocationMaster.SelectedValue = note.Name;
                }
                else
                {
                    if (cboLocationMaster.Items.Count > 0)
                    {
                        cboLocationMaster.SelectedIndex = 0;
                    }
                }
                tnCurrentNode = null;
                grbWarehouse.Visible = false;

                
                LoadLocationInformation();
            }
            else
            {
                grbWarehouse.Visible = true;
                
                foreach (DataRow row in Globals.dtWarehouse_Master.Rows)
                {
                    if (row["Warehouse_id"].ToString() == note.Name)
                    {
                        foreach (Control ctr in grbWarehouse.Controls)
                        {
                            if (ctr is TextEdit)
                            {
                                ((TextEdit)ctr).EditValue = row[ctr.Name.Substring(3).Replace("__"," ")];
                            }
                            if (ctr is MemoEdit)
                            {
                                ((MemoEdit)ctr).EditValue = row[ctr.Name.Substring(3).Replace("__", " ")];
                            }
                        }
                    }
                }
            }
            LoadButton();
        }
        private void LsvLocationClickEvent()
        {
            for (int i = 0; i < treLeft.SelectedNode.Nodes.Count; i++)
            {
                if (treLeft.SelectedNode.Nodes[i].Name == lsvLocation.FocusedItem.Text)
                {
                    treLeft.SelectedNode = treLeft.SelectedNode.Nodes[i];
                }
            }
            
        }

        #endregion
        #region Property
        #endregion
        #region Event
        private void lsvLocation_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //cboTemp.SelectedValue = lsvLocation.FocusedItem.Text;
            LsvLocationClickEvent();
        }
        private void frmLocationMaster_Load(object sender, EventArgs e)
        {
            txtBin_location_id.Properties.ReadOnly = true;
            txtParent_location_id.Properties.ReadOnly = true;
            memNotes.Properties.ReadOnly = true;
            txtWarehouse.Properties.ReadOnly = true;
            cboLocationMaster.DataSource = Globals.dtLocation_Master;
            cboLocationMaster.DisplayMember = "Bin_location_id";
            cboLocationMaster.ValueMember = "Bin_location_id";
            if(Globals.dtLocation_Master.Rows.Count>0){
            cboLocationMaster.SelectedIndex = 0;
            }
            
            //if (Globals.dtProductLocation.Columns.Count == 8)
            //{
            //    Globals.dtProductLocation.Columns.Add("ProductName", typeof(string));
            //}
            LoadLocationInformation();
            LoadComponent();
           
            LoadButton();

        }

   
        private void btnCreate_Click(object sender, EventArgs e)
        {

                DataRow row = Globals.dtLocation_Master.NewRow();
                frmLocationMasterEditor frm = new frmLocationMasterEditor();
                frm.ProRow = row;
                if (frm.ShowDialog(this) != DialogResult.OK) return;
                row = frm.ProRow;
                Globals.dtLocation_Master.Rows.Add(row);
                LoadComponent();
                LoadButton();
 
           
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditProductLocation frm = new frmAddEditProductLocation();
            DataRow row =Globals.dtProductLocation.NewRow();
            row["LocationID"] = txtBin_location_id.Text;
            frm.ProRow = row;
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            row = frm.ProRow;
            row["ID"] = System.Guid.NewGuid();
            Globals.dtProductLocation.Rows.Add(row);
            LoadProductLocation();
            LoadButton();
        }
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
         
            frmAddEditProductLocation frm = new frmAddEditProductLocation();
            for (int i = 0; i < Globals.dtProductLocation.Rows.Count; i++)
            {
                if (Globals.dtProductLocation.Rows[i].RowState != DataRowState.Deleted)
                {
                    if (Globals.dtProductLocation.Rows[i]["ID"].ToString() == grvProduct.GetRowCellValue(grvProduct.FocusedRowHandle, "ID").ToString())
                    {
                        DataRow row = Globals.dtProductLocation.Rows[i];
                        frm.ProRow = row;
                        if (frm.ShowDialog() != DialogResult.OK)
                        {
                            return;
                        }
                        row = frm.ProRow;
                        LoadProductLocation();
                        LoadButton();
                        return;
                    }
                }
            }
            
            
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this field?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < Globals.dtProductLocation.Rows.Count; i++)
                {
                    if(Globals.dtProductLocation.Rows[i].RowState!=DataRowState.Deleted)
                    if (Globals.dtProductLocation.Rows[i]["ID"].ToString() ==grvProduct.GetRowCellValue(grvProduct.FocusedRowHandle,"ID").ToString())
                    {
                        Globals.dtProductLocation.Rows[i].Delete();
                    }

                }
                LoadProductLocation();
                LoadButton();
            }


        }
        private void btnDelete_Click(object sender, EventArgs e)
        {


         
            bool isLeaf = true;
            if (txtBin_location_id.Text.Trim().Length > 0)
            {
                for (int i = 0; i < Globals.dtLocation_Master.Rows.Count; i++)
                {
                    if (Globals.dtLocation_Master.Rows[i].RowState != DataRowState.Deleted)
                    {
                        if (Globals.dtLocation_Master.Rows[i]["Parent_location_id"].ToString() == txtBin_location_id.Text)
                        {
                            isLeaf = false;
                            break;
                        }

                    }

                }


                if (isLeaf == false)
                {
                    MessageBox.Show("Can't delele this Node", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (isLeaf == true)
                {

                    if (CheckExistLocationInProductLocation())
                    {
                        MessageBox.Show("Can't delele this location because It contain some Products!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                    {
                        for (int i = 0; i < Globals.dtLocation_Master.Rows.Count; i++)
                        {
                            if (Globals.dtLocation_Master.Rows[i].RowState != DataRowState.Deleted)
                            {
                                if (Globals.dtLocation_Master.Rows[i]["Bin_location_id"].ToString() == txtBin_location_id.Text)
                                {
                                    Globals.dtLocation_Master.Rows[i].Delete();
                                }
                            }
                        }
                        

                        LoadNode();
                        LoadButton();
                    }
                }


            }
            treLeft.ExpandAll();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Globals.dtWarehouse_Master.Update();
            Globals.dtLocation_Master.Update();
            Globals.dtProductLocation.Update();
            
            this.Close();
        }

        private void treLeft_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void treLeft_AfterSelect(object sender, TreeViewEventArgs e)
        {
            PerformDoubleClick(treLeft.SelectedNode);
        }

     
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Globals.dtLocation_Master = new DA_DataTable("Select * from Location_Master", false);
            Globals.dtProductLocation = new DA_DataTable("Select * from ProductLocation", false);
            this.Close();
            this.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataRow row = Globals.dtLocation_Master.Rows[cboLocationMaster.SelectedIndex];
            frmLocationMasterEditor frm = new frmLocationMasterEditor();
            frm.ProRow = row;
            if (frm.ShowDialog(this) != DialogResult.OK) return;

            row = frm.ProRow;
            LoadComponent();
            treLeft.ExpandAll();
        }

        private void lsvLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            LsvLocationClickEvent();
        }
        private void txtBin_location_id_EditValueChanged(object sender, EventArgs e)
        {
            LoadWarehouseName();
            LoadProductLocation();
        }
        private void cboLocationMaster_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void grbProductManager_Paint(object sender, PaintEventArgs e)
        {

        }

   
 


	}
}

