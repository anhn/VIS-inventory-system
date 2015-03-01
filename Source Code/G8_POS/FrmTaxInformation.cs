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

//using POS;
//using G8_Library;


// chu y
// gan connection string trong Global truoc khi goi 
namespace G8_POS
{
    /// <summary>
    /// Summary description for FrmTaxInformation1.
    /// </summary>
    public class FrmTaxInformation : DevExpress.XtraEditors.XtraForm
    {
        private PanelControl panelControl1;
        private SimpleButton btnSaveAndClose;
        private SimpleButton btnCancel;
        private SimpleButton btnSave;
        private SimpleButton btnAdd;
        private GroupControl grbRight;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel2;
        private DevExpress.XtraGrid.GridControl grdTax;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Label label1;
        private TextEdit txtTaxRate;
        private TextEdit txtTax;
        private CheckEdit chkHideTax;
        private Label label4;
        private Label label3;
        private Label label2;
        private IContainer components;
        TaxTypeTable taxTypeTable;
        Tax_code_masterTable tax_code_masterTable;
        private ImageComboBoxEdit icboLoadTaxType;
        private MemoEdit memRemarks;
        private ImageComboBoxEdit icboTaxType;
        private RepositoryItemTextEdit repositoryItemTextEdit1;
        private RepositoryItemTextEdit txtRateMast;
        private SimpleButton btnDelete;
        private GridView gvView;


        public FrmTaxInformation()
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveAndClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.grbRight = new DevExpress.XtraEditors.GroupControl();
            this.memRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.chkHideTax = new DevExpress.XtraEditors.CheckEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaxRate = new DevExpress.XtraEditors.TextEdit();
            this.txtTax = new DevExpress.XtraEditors.TextEdit();
            this.icboLoadTaxType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.defaultLookAndFeel2 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.grdTax = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtRateMast = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.icboTaxType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbRight)).BeginInit();
            this.grbRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkHideTax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icboLoadTaxType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRateMast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icboTaxType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnSaveAndClose);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 316);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(592, 50);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Text = "panelControl1";
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(185, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Location = new System.Drawing.Point(464, 14);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(103, 23);
            this.btnSaveAndClose.TabIndex = 16;
            this.btnSaveAndClose.Text = "Sa&ve and Close";
            this.btnSaveAndClose.Click += new System.EventHandler(this.btnSaveAndClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(369, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "&Close";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(276, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(92, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grbRight
            // 
            this.grbRight.Controls.Add(this.memRemarks);
            this.grbRight.Controls.Add(this.chkHideTax);
            this.grbRight.Controls.Add(this.label4);
            this.grbRight.Controls.Add(this.label3);
            this.grbRight.Controls.Add(this.label2);
            this.grbRight.Controls.Add(this.label1);
            this.grbRight.Controls.Add(this.txtTaxRate);
            this.grbRight.Controls.Add(this.txtTax);
            this.grbRight.Controls.Add(this.icboLoadTaxType);
            this.grbRight.Location = new System.Drawing.Point(233, 12);
            this.grbRight.Name = "grbRight";
            this.grbRight.Size = new System.Drawing.Size(347, 298);
            this.grbRight.TabIndex = 2;
            // 
            // memRemarks
            // 
            this.memRemarks.Location = new System.Drawing.Point(123, 119);
            this.memRemarks.Name = "memRemarks";
            this.memRemarks.Size = new System.Drawing.Size(204, 158);
            this.memRemarks.TabIndex = 11;
            this.memRemarks.EditValueChanged += new System.EventHandler(this.memRemarks_TextChanged);
            this.memRemarks.TextChanged += new System.EventHandler(this.memRemarks_TextChanged);
            // 
            // chkHideTax
            // 
            this.chkHideTax.Location = new System.Drawing.Point(18, 242);
            this.chkHideTax.Name = "chkHideTax";
            this.chkHideTax.Properties.Caption = "&Show Tax";
            this.chkHideTax.Size = new System.Drawing.Size(84, 19);
            this.chkHideTax.TabIndex = 12;
            this.chkHideTax.EditValueChanged += new System.EventHandler(this.chkHideTax_EditValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Re&marks:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tax &Rate (%):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tax &Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tax &Name:";
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(123, 86);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Properties.Mask.EditMask = "f2";
            this.txtTaxRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTaxRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTaxRate.Size = new System.Drawing.Size(204, 21);
            this.txtTaxRate.TabIndex = 9;
            this.txtTaxRate.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtTaxRate_EditValueChanging);
            this.txtTaxRate.TextChanged += new System.EventHandler(this.txtTaxRate_TextChanged);
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(123, 23);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(204, 21);
            this.txtTax.TabIndex = 5;
            this.txtTax.Leave += new System.EventHandler(this.txtTax_Leave);
            this.txtTax.TextChanged += new System.EventHandler(this.txtTax_TextChanged);
            // 
            // icboLoadTaxType
            // 
            this.icboLoadTaxType.Location = new System.Drawing.Point(123, 55);
            this.icboLoadTaxType.Name = "icboLoadTaxType";
            this.icboLoadTaxType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icboLoadTaxType.Size = new System.Drawing.Size(204, 21);
            this.icboLoadTaxType.TabIndex = 7;
            this.icboLoadTaxType.SelectedIndexChanged += new System.EventHandler(this.icboLoadTaxType_SelectedIndexChanged);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.defaultLookAndFeel1.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // grdTax
            // 
            this.grdTax.EmbeddedNavigator.Name = "";
            this.grdTax.Location = new System.Drawing.Point(12, 45);
            this.grdTax.MainView = this.gridView1;
            this.grdTax.Name = "grdTax";
            this.grdTax.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.txtRateMast});
            this.grdTax.Size = new System.Drawing.Size(215, 265);
            this.grdTax.TabIndex = 1;
            this.grdTax.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdTax;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // txtRateMast
            // 
            this.txtRateMast.AutoHeight = false;
            this.txtRateMast.Mask.EditMask = "f2";
            this.txtRateMast.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtRateMast.Mask.UseMaskAsDisplayFormat = true;
            this.txtRateMast.Name = "txtRateMast";
            // 
            // icboTaxType
            // 
            this.icboTaxType.Location = new System.Drawing.Point(12, 19);
            this.icboTaxType.Name = "icboTaxType";
            this.icboTaxType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icboTaxType.Size = new System.Drawing.Size(215, 21);
            this.icboTaxType.TabIndex = 13;
            this.icboTaxType.SelectedIndexChanged += new System.EventHandler(this.icboTaxType_SelectedIndexChanged);
            // 
            // FrmTaxInformation
            // 
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.Controls.Add(this.grdTax);
            this.Controls.Add(this.grbRight);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.icboTaxType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTaxInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tax Information";
            this.Load += new System.EventHandler(this.FrmTaxInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbRight)).EndInit();
            this.grbRight.ResumeLayout(false);
            this.grbRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkHideTax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icboLoadTaxType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRateMast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icboTaxType.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
		private string FConnection;
		public string Connection
		{
			get { return FConnection; }
			set { FConnection = value; }
		}
        private void FrmTaxInformation_Load(object sender, EventArgs e)
        {
            tax_code_masterTable = new Tax_code_masterTable(new SqlConnection(Connection));
            TaxTypeLoad();            

        }


        private void TaxTypeLoad()
        {

			taxTypeTable = new TaxTypeTable(new SqlConnection(Connection));
            //cboTaxType.DbDataTable = taxTypeTable;
            //cboTaxType.DisplayField = "TaxTypeName";
            icboTaxType.Properties.Items.Clear();
            icboTaxType.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("All", ""));
            for (int i = 0; i < taxTypeTable.Rows.Count; i++)
            {
                icboTaxType.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(taxTypeTable[i].TaxTypeName, taxTypeTable[i].TaxTypeID));

            }
            icboLoadTaxType.Properties.Items.Clear();
            icboLoadTaxType.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("All", ""));
            for (int i = 0; i < taxTypeTable.Rows.Count; i++)
            {
                icboLoadTaxType.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(taxTypeTable[i].TaxTypeName, taxTypeTable[i].TaxTypeID));

            }

            if (icboTaxType.SelectedIndex <= 0)
            {
                icboTaxType.SelectedIndex = 0;
                
            }
        }


        
        
        private void TaxLoad()
        {

            //tax_code_masterTable = new Tax_code_masterTable(Data_Access.getConnection());
            DataView dv = new DataView(tax_code_masterTable);
           // System.Data.DataRow row = ((DbComboItem)icboTaxType.SelectedItem).GetDataRow();
            if (icboTaxType.Value.ToString() != "")
            {
                dv.RowFilter = @"TaxTypeID='" + icboTaxType.Value.ToString() + "'";
            }

            grdTax.DataSource = dv;
            
            gvView = (GridView)grdTax.Views[0];
            gvView.Columns["TaxRate"].ColumnEdit = txtRateMast;
            gvView.Columns["Tax_code_desc"].OptionsColumn.AllowEdit = false;
            gvView.Columns["TaxRate"].OptionsColumn.AllowEdit = false;
             gvView.Columns["TaxTypeID"].Visible = false;
            gvView.Columns["Tax_code_id"].Visible = false;
            gvView.Columns["Note"].Visible = false;
            gvView.Columns["UserID"].Visible = false;
            gvView.Columns["Timestamp"].Visible = false;
            gvView.Columns["ViewStatus"].Visible = false;

            txtTax.DataBindings.Clear();
            txtTax.DataBindings.Add("EditValue", dv, "Tax_code_desc", true);//, true, DataSourceUpdateMode.OnPropertyChanged);
            txtTaxRate.DataBindings.Clear();
            txtTaxRate.DataBindings.Add("EditValue", dv, "TaxRate", true);
            memRemarks.DataBindings.Clear();
            memRemarks.DataBindings.Add("EditValue", dv, "Note", true);
            chkHideTax.DataBindings.Clear();
            chkHideTax.DataBindings.Add("Checked", dv, "ViewStatus", true);

            

           
            
        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {


            if (gvView.RowCount > 0)
            {
                int i = gvView.GetSelectedRows()[0];
                ((DataRowView)gvView.GetRow(i)).Row["Tax_code_desc"] = txtTax.Text;
            }
            
        }

        private void txtTaxRate_TextChanged(object sender, EventArgs e)
        {
            if (gvView.RowCount > 0)
            {

                int i = gvView.GetSelectedRows()[0];
                try
                {
                    ((DataRowView)gvView.GetRow(i)).Row["TaxRate"] = double.Parse(txtTaxRate.Text);
                }
                catch (Exception)
                {
                }

            }
        }

        private void memRemarks_TextChanged(object sender, EventArgs e)
        {
            if (gvView.RowCount > 0)
            {
                int i = gvView.GetSelectedRows()[0];
                ((DataRowView)gvView.GetRow(i)).Row["Note"] = memRemarks.Text;
            }
          
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (icboLoadTaxType.Value.ToString() != "")
            {
                
            }
            else
            {
                icboLoadTaxType.SelectedIndex = 1;
            }
           
            gvView.AddNewRow();
            int j = gvView.GetSelectedRows()[0];
            ((DataRowView)gvView.GetRow(j)).Row["TaxTypeID"] = icboLoadTaxType.Value;

            //
            txtTax.Text = "";
            txtTaxRate.Text = "0.00";
            memRemarks.Text = "";
            chkHideTax.Checked = true;
            txtTax.Focus();            
        }

        private void icboLoadTaxType_SelectedIndexChanged(object sender, EventArgs e)
        {

             int[] rows = gvView.GetSelectedRows();
             
            if ((rows == null) || (rows.Length <= 0) )
            {
                icboTaxType.Value= icboLoadTaxType.Value;
                txtTax.Text = "";
                txtTaxRate.EditValue = 0;
                memRemarks.Text = "";

                return;

            }
            
            else if (icboLoadTaxType.Value.ToString() == "")
            {
                int j = rows[0];
                if (((DataRowView)gvView.GetRow(j)).Row["Tax_Code_ID"].ToString()== "")
                {
                    icboLoadTaxType.Value = icboTaxType.Value;
                }
                else
                {
                    icboTaxType.Value = icboLoadTaxType.Value;
                }
            }
            else
            {
                int j = rows[0];

                string taxID;
                taxID = ((DataRowView)gvView.GetRow(j)).Row["Tax_Code_ID"].ToString();

                ((DataRowView)gvView.GetRow(j)).Row["TaxTypeID"] = icboLoadTaxType.Value;
                icboTaxType.Value = icboLoadTaxType.Value;

                for (int i = 0; i < gvView.RowCount; i++)
                {
                    try
                    {
                        if (((DataRowView)gvView.GetRow(i)).Row["Tax_Code_ID"].ToString() == taxID)
                        {
                            gvView.FocusedRowHandle = i;
                            break;
                        }
                    }
                    catch (Exception)
                    {
                    }

                }
            }
                 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int[] rows = gvView.GetSelectedRows();
                int j = rows[0];
                gvView.FocusedRowHandle = 0;
                gvView.FocusedRowHandle = 1;
                tax_code_masterTable.Update();

                gvView.FocusedRowHandle = j;
                MessageBox.Show("Save successfully.");
            }
            catch
            {
                MessageBox.Show("Error, can not save data");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            gvView.FocusedRowHandle = 0;
            gvView.FocusedRowHandle = 1;
            tax_code_masterTable.Update();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void icboTaxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaxLoad();
            icboLoadTaxType.Value = icboTaxType.Value;
        }

        private void txtTax_Leave(object sender, EventArgs e)
        {
            if (txtTax.Text.Trim() == "")
            {
                txtTax.Focus();
                MessageBox.Show("this field is not null");
            }
            for (int i = 0; i < gvView.RowCount; i++)
            {
                if (i != gvView.FocusedRowHandle)
                {
                    if (gvView.GetRowCellDisplayText(i, "Tax_code_desc") == txtTax.Text.Trim())
                    {
                        MessageBox.Show("This name exists. Please check again!!!");
                        txtTax.Focus();
                        return;
                    }
                }
            }
        }

        private void txtTaxRate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(e.NewValue) < 0)
                    e.Cancel = true;
            }
            catch { e.Cancel = true; }
        }

        private void chkHideTax_EditValueChanged(object sender, EventArgs e)
        {
            if (gvView.RowCount >= 1)
            {
                int i = gvView.GetSelectedRows()[0];
                ((DataRowView)gvView.GetRow(i)).Row["ViewStatus"] = chkHideTax.Checked;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvView.RowCount > 0)
            {
                if (gvView.FocusedRowHandle >= 0)
                {
                    String taxId = gvView.GetRowCellDisplayText(gvView.FocusedRowHandle, "Tax_code_id").ToString();
                    String sql = "SELECT * FROM MenuItem WHERE TaxID='" + taxId + "'";
                    SqlConnection conn = new SqlConnection(FConnection);
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("You can not delete this tax because it is using now");
                        return;
                    }
                    if(MessageBox.Show("Are you sure want delete this Item?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        for (int i = 0; i < tax_code_masterTable.Rows.Count; i++)
                        {
                            if (tax_code_masterTable.Rows[i].RowState != DataRowState.Deleted)
                            {
                                if (tax_code_masterTable.Rows[i]["Tax_code_id"].ToString() == gvView.GetRowCellDisplayText(gvView.FocusedRowHandle, "Tax_code_id"))
                                {
                                    tax_code_masterTable.Rows[i].Delete();                                    
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }




    }
}

