using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Inventory.Properties;

namespace Inventory
{
    /// <summary>
    /// Summary description for Suppliers.
    /// </summary>
    public class Suppliers : DevExpress.XtraEditors.XtraForm
    {
        private ImageList imageList1;
        private PanelControl panelControl1;
        private SimpleButton btnHelp;
        private SimpleButton btnPreview;
        private SimpleButton btnPrint;
        private SimpleButton btnSearch;
        private SimpleButton btnDelete;
        private SimpleButton btnEdit;
        private SimpleButton btnNew;
        private SimpleButton btnSave;
        private DevExpress.XtraGrid.GridControl grdSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private IContainer components;

        public Suppliers()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            btnSave.ToolTip = Settings.Default.strSave;
            btnNew.ToolTip = Settings.Default.strAdd;
            btnEdit.ToolTip = Settings.Default.strEdit;
            btnDelete.ToolTip = Settings.Default.strDelete;
            btnPrint.ToolTip = Settings.Default.strPrint;
            btnPreview.ToolTip = Settings.Default.strPreview;
            btnHelp.ToolTip = Settings.Default.strHelp;
            btnSearch.ToolTip = Settings.Default.strSearch;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnHelp = new DevExpress.XtraEditors.SimpleButton();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.grdSupplier = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "BINOCULR.PNG");
            this.imageList1.Images.SetKeyName(1, "Delete.PNG");
            this.imageList1.Images.SetKeyName(2, "Document.PNG");
            this.imageList1.Images.SetKeyName(3, "Edit.png");
            this.imageList1.Images.SetKeyName(4, "Filter.PNG");
            this.imageList1.Images.SetKeyName(5, "Help.png");
            this.imageList1.Images.SetKeyName(6, "Preview.PNG");
            this.imageList1.Images.SetKeyName(7, "printer.PNG");
            this.imageList1.Images.SetKeyName(8, "Save.PNG");
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnHelp);
            this.panelControl1.Controls.Add(this.btnPreview);
            this.panelControl1.Controls.Add(this.btnPrint);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnEdit);
            this.panelControl1.Controls.Add(this.btnNew);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(672, 41);
            this.panelControl1.TabIndex = 7;
            this.panelControl1.Text = "panelControl1";
            // 
            // btnHelp
            // 
            this.btnHelp.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnHelp.ImageIndex = 5;
            this.btnHelp.ImageList = this.imageList1;
            this.btnHelp.Location = new System.Drawing.Point(271, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(32, 32);
            this.btnHelp.TabIndex = 16;
            // 
            // btnPreview
            // 
            this.btnPreview.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnPreview.ImageIndex = 6;
            this.btnPreview.ImageList = this.imageList1;
            this.btnPreview.Location = new System.Drawing.Point(233, 4);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(32, 32);
            this.btnPreview.TabIndex = 15;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnPrint.ImageIndex = 7;
            this.btnPrint.ImageList = this.imageList1;
            this.btnPrint.Location = new System.Drawing.Point(195, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(32, 32);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSearch.ImageIndex = 0;
            this.btnSearch.ImageList = this.imageList1;
            this.btnSearch.Location = new System.Drawing.Point(158, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnDelete.ImageIndex = 1;
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(120, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 32);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnEdit.ImageIndex = 3;
            this.btnEdit.ImageList = this.imageList1;
            this.btnEdit.Location = new System.Drawing.Point(82, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(32, 32);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnNew.ImageIndex = 2;
            this.btnNew.ImageList = this.imageList1;
            this.btnNew.Location = new System.Drawing.Point(44, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(32, 32);
            this.btnNew.TabIndex = 9;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSave.Enabled = false;
            this.btnSave.ImageIndex = 8;
            this.btnSave.ImageList = this.imageList1;
            this.btnSave.Location = new System.Drawing.Point(6, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 32);
            this.btnSave.TabIndex = 8;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grdSupplier
            // 
            this.grdSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.grdSupplier.EmbeddedNavigator.Name = "";
            this.grdSupplier.Location = new System.Drawing.Point(0, 41);
            this.grdSupplier.MainView = this.gridView3;
            this.grdSupplier.Name = "grdSupplier";
            this.grdSupplier.Size = new System.Drawing.Size(672, 310);
            this.grdSupplier.TabIndex = 10;
            this.grdSupplier.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3,
            this.gridView4});
            this.grdSupplier.DoubleClick += new System.EventHandler(this.grdSupplier_DoubleClick);
            this.grdSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSupplier_KeyDown);
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.grdSupplier;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.grdSupplier;
            this.gridView4.Name = "gridView4";
            // 
            // Suppliers
            // 
            this.ClientSize = new System.Drawing.Size(672, 351);
            this.Controls.Add(this.grdSupplier);
            this.Controls.Add(this.panelControl1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strSuppliers", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "Suppliers";
            this.Text = global::Inventory.Properties.Settings.Default.strSuppliers;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Suppliers_FormClosing);
            this.Load += new System.EventHandler(this.Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        
        private bool isModified = false;
        private List<string> lstDeleteSupplier;
        private DataTable tblSupplier;
        private GridView gvSupplier;
        private void Suppliers_Load(object sender, EventArgs e)
        {
            lstDeleteSupplier = new List<string>();
            loadSupplier();
            Globals.SetDefaultFont(this);
        }
        private void loadSupplierTab(DataTable tab)
        {
            grdSupplier.DataSource = tab;

            GridView gridView = (GridView)grdSupplier.Views[0];
            gvSupplier = gridView;
            foreach (GridColumn cl in gridView.Columns)
            {
                cl.Visible = false;
                cl.MinWidth = 10;
                cl.AppearanceHeader.Font = Settings.Default.cfgDefaultFont;
                cl.AppearanceCell.Font = Settings.Default.cfgDefaultFont;
            }
            gridView.OptionsBehavior.Editable = false;
            gridView.Columns["Mr"].VisibleIndex = 0;

            gridView.Columns["Last Name"].VisibleIndex = 1;
            gridView.Columns["Middle Name"].VisibleIndex = 2;
            gridView.Columns["First Name"].VisibleIndex = 3;
            gridView.Columns["Email Name"].VisibleIndex = 4;
            gridView.Columns["Contact Name"].VisibleIndex = 5;
            gridView.Columns["Company Name"].VisibleIndex = 6;
            gridView.Columns["Phone 1"].VisibleIndex = 7;


            gridView.Columns["Mr"].Visible = true;

            gridView.Columns["Last Name"].Visible = true;
            gridView.Columns["Middle Name"].Visible = true;
            gridView.Columns["First Name"].Visible = true;
            gridView.Columns["Email Name"].Visible = true;
            gridView.Columns["Contact Name"].Visible = true;
            gridView.Columns["Company Name"].Visible = true;
            gridView.Columns["Phone 1"].Visible = true;


            gridView.Columns["Mr"].Width = 20;
        }
        private void loadSupplier()
        {
            BL_Supplier supplier = new BL_Supplier();
            if (supplier == null) return;
            tblSupplier = supplier.View().Tables[0].Copy();
            tblSupplier.Columns.Add("RecStatus", typeof(int));
            tblSupplier.Columns.Add("CatRef", typeof(CategoryRec[]));
            loadSupplierTab(tblSupplier);
        }
        private void SaveDataSupplier()
        {
            
            // cap nhat thong tin
            DataRow[] rows = tblSupplier.Select("RecStatus = 1 OR RecStatus = 2");
            BL_Supplier blSupplier = new BL_Supplier();
            Supplier sup = new Supplier();
            DA_Category daCategory = new DA_Category();
            foreach (DataRow row in rows)
            {
                sup.AssignDataRow(row);
                if (row["RecStatus"].ToString() == "1")
                {
                    blSupplier.Add(sup);

                }
                else if (row["RecStatus"].ToString() == "2") blSupplier.Update(sup);
                try
                {
                    CategoryRec[] cats = (CategoryRec[])row["CatRef"];
                    if (cats != null)
                    {
                        for (int i = 0; i < cats.Length; i++)
                            if (cats[i].status == 1) // add new
                                daCategory.Add(cats[i].ContactCatID, row["Contact ID"].ToString());
                            else if (cats[i].status == -1) // delete
                                daCategory.Delete(cats[i].ContactCatID, row["Contact ID"].ToString());
                    }
                }
                catch { }
            }

            foreach (string s in lstDeleteSupplier)
            {
                blSupplier.Delete(s);
                daCategory.Delete(s);
            }
            lstDeleteSupplier.Clear();

        }
       
        private void newSupplier()
        {
            ModifySupplier frm = new ModifySupplier();
            if (frm.ShowDialog(this) != DialogResult.OK) return;
            Supplier sup = frm.SupplierData;
            tblSupplier.NewRow();
            gvSupplier.AddNewRow();
            gvSupplier.RefreshData();
            DataRow row = ((DataRowView)gvSupplier.GetRow(gvSupplier.RowCount - 1)).Row;
            sup.ToDataRow(row);// gan du lieu vao
            row["RecStatus"] = 1; //create new;
            row["Contact ID"] = ContactBase.GetID();            
            row["CatRef"] = frm.Categories;
            SetModified(true);
        }

       
        private void editSupplier()
        {
            if (gvSupplier.RowCount <= 0) return;
            int r = gvSupplier.GetSelectedRows()[0];// lay hang hien tai

            DataRow row = ((DataRowView)gvSupplier.GetRow(r)).Row;
            ModifySupplier frm = new ModifySupplier();
            Supplier sup = new Supplier();
            sup.AssignDataRow(row);
            frm.SupplierData = sup;
            if (frm.ShowDialog(this) != DialogResult.OK) return;
            sup = frm.SupplierData;
            sup.ToDataRow(row);
            row["RecStatus"] = 2; //Modified;
            row["CatRef"] = frm.Categories;
            SetModified(true);
        }
        private void DeleteSupplier()
        {
            if (gvSupplier.GetSelectedRows() == null) return;
            if (gvSupplier.GetSelectedRows().Length <= 0) return;
            int r = gvSupplier.GetSelectedRows()[0];// lay hang hien tai
            if (r < 0) return;
            if (gvSupplier.RowCount <= 0) return;
            if (MessageBox.Show(this, Settings.Default.strWarningDelete, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            DataRow row = ((DataRowView)gvSupplier.GetRow(r)).Row;
            lstDeleteSupplier.Add(row["Contact ID"].ToString());

            row.Delete();
            gvSupplier.DeleteRow(r);
            gvSupplier.RefreshData();
            SetModified(true);
        }

        private void searchSuppliers()
        {
            Search frm = new Search();
            frm.setTable("VListSupplier");
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    Data_Access.DoSqlCommand("SELECT * FROM VListSuppliers WHERE " + frm.getSearchStr());
                    tblSupplier = Data_Access.GetDataSet().Tables[0].Copy();
                    tblSupplier.Columns.Add("RecStatus", typeof(int));
                    tblSupplier.Columns.Add("CatRef", typeof(CategoryRec[]));
                    loadSupplierTab(tblSupplier);
                }
                catch { }
            }
        }


        private void SetModified(bool status)
        {
            if (status == isModified) return;
            isModified = status;
            btnSave.Enabled = status;
        }
        
        private void btnPreview_Click(object sender, EventArgs e)
        {
            grdSupplier.ShowPrintPreview();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newSupplier();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            editSupplier();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveDataSupplier();
            SetModified(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSupplier();
        }
        
        private void grdSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                DeleteSupplier();
            else if (e.KeyCode == Keys.Insert)
                newSupplier();
            else if (e.KeyCode == Keys.Enter)
                editSupplier();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchSuppliers();
        }
        

        private void grdSupplier_DoubleClick(object sender, EventArgs e)
        {
            editSupplier();
        }

        private void Suppliers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isModified)
                if (MessageBox.Show(this, "Do you want to save?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SaveDataSupplier();
                }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            grdSupplier.Print();
        }
    }
}

