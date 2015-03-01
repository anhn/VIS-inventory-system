using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
namespace Inventory
{
    /// <summary>
    /// Summary description for SelectSupplier.
    /// </summary>
    public class SelectSupplier : DevExpress.XtraEditors.XtraForm
    {
        private ImageList imageList1;
        private ImageList imageList2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.GridControl grdSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private PanelControl panelControl1;
        private SimpleButton btnSearch;
        private SimpleButton btnOK;
        private SimpleButton simpleButton1;
        private SimpleButton simpleButton2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private IContainer components;

        public SelectSupplier()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectSupplier));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdSupplier = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
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
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "BINOCULR.PNG");
            this.imageList2.Images.SetKeyName(1, "Delete.PNG");
            this.imageList2.Images.SetKeyName(2, "Document.PNG");
            this.imageList2.Images.SetKeyName(3, "Edit.png");
            this.imageList2.Images.SetKeyName(4, "Filter.PNG");
            this.imageList2.Images.SetKeyName(5, "Help.png");
            this.imageList2.Images.SetKeyName(6, "Preview.PNG");
            this.imageList2.Images.SetKeyName(7, "printer.PNG");
            this.imageList2.Images.SetKeyName(8, "Save.PNG");
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.grdSupplier;
            this.gridView4.Name = "gridView4";
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
            this.grdSupplier.Size = new System.Drawing.Size(545, 256);
            this.grdSupplier.TabIndex = 12;
            this.grdSupplier.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3,
            this.gridView4});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.grdSupplier;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btnOK);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(545, 41);
            this.panelControl1.TabIndex = 11;
            this.panelControl1.Text = "panelControl1";
            // 
            // simpleButton2
            // 
            this.simpleButton2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCancel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Location = new System.Drawing.Point(88, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(70, 31);
            this.simpleButton2.TabIndex = 15;
            this.simpleButton2.Text = global::Inventory.Properties.Settings.Default.strCancel;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strShowAll", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.simpleButton1.Location = new System.Drawing.Point(178, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(70, 31);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = global::Inventory.Properties.Settings.Default.strShowAll;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnOK
            // 
            this.btnOK.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strOK", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(12, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(70, 31);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = global::Inventory.Properties.Settings.Default.strOK;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSearch.ImageIndex = 0;
            this.btnSearch.ImageList = this.imageList2;
            this.btnSearch.Location = new System.Drawing.Point(254, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.defaultLookAndFeel1.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // SelectSupplier
            // 
            this.ClientSize = new System.Drawing.Size(545, 297);
            this.Controls.Add(this.grdSupplier);
            this.Controls.Add(this.panelControl1);
            this.Name = "SelectSupplier";
            this.Text = "SelectSupplier";
            this.Load += new System.EventHandler(this.SelectSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private string SID = "";
        private string strChildID = "";
        private void SelectSupplier_Load(object sender, EventArgs e)
        {
            Globals.SetDefaultFont(this);
            if (SID == "")
                SearchCmd("");
            else
                SearchCmd("[Contact ID] = '" + SID + "'");

        }
        private DataTable tblSupplier;
        private GridView gvSupplier;
        private void loadSupplierTab(DataTable tab)
        {
            grdSupplier.DataSource = tab;

            GridView gridView = (GridView)grdSupplier.Views[0];
            gvSupplier = gridView;
            foreach (GridColumn cl in gridView.Columns)
            {
                cl.Visible = false;
                cl.MinWidth = 10;
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
            loadSupplierTab(tblSupplier);
        }
        private void searchSuppliers()
        {
            Search frm = new Search();
            frm.setTable("VListSuppliers");
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                SearchCmd(frm.getSearchStr());
            }     
        }
        private void SearchCmd(string strSearch)
        {
            try
            {             
                             
                string strSQL = "SELECT * FROM VListSuppliers";
                string str2 = "";
                if (strSearch != "")
                {
                    str2 += strSearch;
                    if (strChildID != "")
                        str2 += " AND ";
                }
                
                if (strChildID != "")
                    str2 += "[Contact ID] <> '" + strChildID + "'";
                if (str2 != "") strSQL += " WHERE " + str2;
                Data_Access.DoSqlCommand(strSQL);
                tblSupplier = Data_Access.GetDataSet().Tables[0].Copy();
                tblSupplier.Columns.Add("RecStatus", typeof(int));
                loadSupplierTab(tblSupplier);
            }
            catch { }
        }
        public string ChildID
        {
            set { strChildID = value; }
            get { return strChildID; }
        }
        public string SupplierName
        {
            get
            {
                try
                {
                    if (gvSupplier.RowCount <= 0) return "";
                    int r = gvSupplier.GetSelectedRows()[0];// lay hang hien tai
                    DataRow row = ((DataRowView)gvSupplier.GetRow(r)).Row;

                    return row["Last Name"].ToString() + " " + row["Middle Name"].ToString() + " " + row["First Name"].ToString();
                }
                catch (Exception) { }
                return "";
            }
        }
        public string SupplierID
        {
            get
            {
                try
                {
                    if (gvSupplier.RowCount <= 0) return "";
                    int r = gvSupplier.GetSelectedRows()[0];// lay hang hien tai
                    DataRow row = ((DataRowView)gvSupplier.GetRow(r)).Row;                     
                    return row["Contact ID"].ToString();
                }
                catch (Exception) { }
                return "";
            }
            set
            {
                SID = value;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (SupplierID == "")
            {
                MessageBox.Show("You have to select parent!");
            }
            else this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SearchCmd("");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchSuppliers();
        }
    }
}

