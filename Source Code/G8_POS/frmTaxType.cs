using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;

using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Data.SqlClient;
using G8_POS.Properties;
using DevExpress.XtraEditors.Repository;


namespace G8_POS
{
	/// <summary>
	/// Summary description for frmTaxType.
	/// </summary>
	public class frmTaxType : DevExpress.XtraEditors.XtraForm
	{
		private GroupControl grdMain;
		private TextEdit txtTaxTypeName;
		private MemoEdit txtNote;
		private GroupControl groupControl2;
		private GroupControl groupControl3;
		private DevExpress.XtraGrid.GridControl grdTax;
		private GridView gvTax;
		private SimpleButton btnSaveAndClose;
		private SimpleButton simpleButton1;
		private SimpleButton btnSave;
		private SimpleButton btnAdd;
        private SimpleButton btnDelete;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaxType()
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
		private string FConnection;
		public string Connection
		{
			get { return FConnection; }
			set { FConnection = value; }
		}
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.Label taxTypeNameLabel;
            System.Windows.Forms.Label noteLabel;
            this.grdMain = new DevExpress.XtraEditors.GroupControl();
            this.txtTaxTypeName = new DevExpress.XtraEditors.TextEdit();
            this.txtNote = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveAndClose = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.grdTax = new DevExpress.XtraGrid.GridControl();
            this.gvTax = new DevExpress.XtraGrid.Views.Grid.GridView();
            taxTypeNameLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            this.grdMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTax)).BeginInit();
            this.SuspendLayout();
            // 
            // taxTypeNameLabel
            // 
            taxTypeNameLabel.AutoSize = true;
            taxTypeNameLabel.Location = new System.Drawing.Point(18, 12);
            taxTypeNameLabel.Name = "taxTypeNameLabel";
            taxTypeNameLabel.Size = new System.Drawing.Size(92, 13);
            taxTypeNameLabel.TabIndex = 4;
            taxTypeNameLabel.Text = "*Tax Type Name:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new System.Drawing.Point(18, 48);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(34, 13);
            noteLabel.TabIndex = 5;
            noteLabel.Text = "Note:";
            // 
            // grdMain
            // 
            this.grdMain.Controls.Add(this.txtTaxTypeName);
            this.grdMain.Controls.Add(taxTypeNameLabel);
            this.grdMain.Controls.Add(noteLabel);
            this.grdMain.Controls.Add(this.txtNote);
            this.grdMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.grdMain.Location = new System.Drawing.Point(237, 0);
            this.grdMain.Name = "grdMain";
            this.grdMain.ShowCaption = false;
            this.grdMain.Size = new System.Drawing.Size(355, 223);
            this.grdMain.TabIndex = 0;
            this.grdMain.Text = "groupControl1";
            // 
            // txtTaxTypeName
            // 
            this.txtTaxTypeName.Location = new System.Drawing.Point(122, 12);
            this.txtTaxTypeName.Name = "txtTaxTypeName";
            this.txtTaxTypeName.Size = new System.Drawing.Size(216, 20);
            this.txtTaxTypeName.TabIndex = 2;
            this.txtTaxTypeName.Leave += new System.EventHandler(this.txtTaxTypeName_Leave);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(122, 48);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(216, 149);
            this.txtNote.TabIndex = 3;
            this.txtNote.Leave += new System.EventHandler(this.txtNote_Leave);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnDelete);
            this.groupControl2.Controls.Add(this.btnSaveAndClose);
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.btnSave);
            this.groupControl2.Controls.Add(this.btnAdd);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 223);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(592, 52);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(186, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Location = new System.Drawing.Point(472, 17);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(103, 23);
            this.btnSaveAndClose.TabIndex = 20;
            this.btnSaveAndClose.Text = "Sa&ve and Close";
            this.btnSaveAndClose.Click += new System.EventHandler(this.btnSaveAndClose_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(377, 17);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 19;
            this.simpleButton1.Text = "&Close";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(284, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(93, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.grdTax);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(237, 223);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "groupControl3";
            // 
            // grdTax
            // 
            this.grdTax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTax.EmbeddedNavigator.Name = "";
            this.grdTax.Location = new System.Drawing.Point(4, 4);
            this.grdTax.MainView = this.gvTax;
            this.grdTax.Name = "grdTax";
            this.grdTax.Size = new System.Drawing.Size(229, 215);
            this.grdTax.TabIndex = 0;
            this.grdTax.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTax});
            // 
            // gvTax
            // 
            this.gvTax.GridControl = this.grdTax;
            this.gvTax.Name = "gvTax";
            this.gvTax.OptionsBehavior.Editable = false;
            this.gvTax.OptionsView.ShowFilterPanel = false;
            // 
            // frmTaxType
            // 
            this.ClientSize = new System.Drawing.Size(592, 275);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.grdMain);
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaxType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tax Type";
            this.Load += new System.EventHandler(this.frmTaxType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            this.grdMain.ResumeLayout(false);
            this.grdMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTax)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
		TaxTypeTable dtTaxType;
        Tax_code_masterTable dtTaxMaster;
		private void frmTaxType_Load(object sender, EventArgs e)
		{
			
			LoadComponent();

		}
		
		private void LoadComponent()
		{
            dtTaxType = new TaxTypeTable(new SqlConnection(Connection));
            dtTaxMaster = new Tax_code_masterTable(new SqlConnection(Connection));
			grdTax.DataSource = dtTaxType;
			gvTax = (GridView)grdTax.Views[0];
			gvTax.Columns["TaxTypeID"].Visible = false;
			gvTax.Columns["Note"].Visible = false;
			txtTaxTypeName.DataBindings.Clear();
			txtTaxTypeName.DataBindings.Add("Editvalue", dtTaxType, "TaxTypeName");
			txtNote.DataBindings.Clear();
			txtNote.DataBindings.Add("Editvalue", dtTaxType, "Note");
			
		}

		private void txtTaxTypeName_Leave(object sender, EventArgs e)
		{
            if (txtTaxTypeName.Text.Trim().Length != 0)
            {
                for (int i = 0; i < gvTax.RowCount; i++)
                {
                    if (i != gvTax.FocusedRowHandle)
                    {
                        if (gvTax.GetRowCellDisplayText(i,"TaxTypeName") == txtTaxTypeName.Text)
                        {
                            MessageBox.Show("This name exists. Please check again!!!");
                            txtTaxTypeName.Focus();
                            return;
                        }
                    }
                }
                
                gvTax.CloseEditor();
                gvTax.UpdateCurrentRow();
                

            }
            else
            {
                MessageBox.Show("Tax Type Name can not null!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaxTypeName.Focus();
            }
		}

		private void txtNote_Leave(object sender, EventArgs e)
		{
			gvTax.CloseEditor();
			gvTax.UpdateCurrentRow();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			//gvView.AddNewRow();
			//gv
			//int j = gvView.GetSelectedRows()[0];
			//((DataRowView)gvView.GetRow(j)).Row["TaxTypeID"] = icboLoadTaxType.Value;
			gvTax.AddNewRow();
            txtTaxTypeName.Focus();

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
            try
            {
                int j = gvTax.FocusedRowHandle;
                SaveData();
                LoadComponent();
                gvTax.FocusedRowHandle = j;
                MessageBox.Show("Save successfully.");
            }
            catch 
            {
                MessageBox.Show("Error, can not save data");
            }
		}
        private void SaveData()
        {
            
            gvTax.FocusedRowHandle = 0;
            gvTax.FocusedRowHandle = 1;
            gvTax.UpdateCurrentRow();
            gvTax.CloseEditor();
            dtTaxType.Update();
            
        }

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSaveAndClose_Click(object sender, EventArgs e)
		{
            SaveData();
			this.Close();
		}
        private bool CheckExistTaxType(string taxTypeID)
        {
            foreach (DataRow row in dtTaxMaster.Rows)
            {
                if (row["TaxTypeID"].ToString() == taxTypeID)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvTax.RowCount > 0)
            {
                if (gvTax.FocusedRowHandle >= 0)
                {
                    if (CheckExistTaxType(gvTax.GetRowCellDisplayText(gvTax.FocusedRowHandle, "TaxTypeID")))
                    {
                        MessageBox.Show("This TaxType esixt in TaxMaster table. You can't delete it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (MessageBox.Show("Are you sure delete this TaxType?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        gvTax.DeleteRow(gvTax.FocusedRowHandle);
                        return;
                    }
                }
                //if (gvTax.FocusedRowHandle >= 0)
                //{
                //    if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //    {
                
                //        //for (int i = 0; i < dtTaxType.Rows.Count; i++)
                //        //{
                //        //    if (dtTaxType.Rows[i].RowState != DataRowState.Deleted)
                //        //    {
                //        //        if (dtTaxType.Rows[i]["TaxTypeID"].ToString() == gvTax.GetRowCellDisplayText(gvTax.FocusedRowHandle, "TaxTypeID"))
                //        //        {
                //        //            dtTaxType.Rows[i].Delete();
                //        //            return;
                //        //        }
                //        //    }

                //        //}
                //    }
                //}
            }
        }
	}
}

