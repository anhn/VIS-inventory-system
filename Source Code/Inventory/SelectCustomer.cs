using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using System.Data;
using System.Data.SqlClient;

namespace Inventory
{
    /// <summary>
    /// Summary description for SelectCustomer.
    /// </summary>
    public class SelectCustomer : DevExpress.XtraEditors.XtraForm
    {
        private ImageList imageList1;
        private DevExpress.XtraGrid.GridControl grdCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private PanelControl panelControl1;
        private SimpleButton btnSearch;
        private SimpleButton simpleButton1;
        private SimpleButton simpleButton2;
        private SimpleButton simpleButton3;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private IContainer components;

        public SelectCustomer()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            cID = "";
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectCustomer));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grdCustomer = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            // grdCustomer
            // 
            this.grdCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.grdCustomer.EmbeddedNavigator.Name = "";
            this.grdCustomer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grdCustomer.Location = new System.Drawing.Point(0, 41);
            this.grdCustomer.MainView = this.gridView1;
            this.grdCustomer.Name = "grdCustomer";
            this.grdCustomer.Size = new System.Drawing.Size(516, 313);
            this.grdCustomer.TabIndex = 12;
            this.grdCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdCustomer;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdCustomer;
            this.gridView2.Name = "gridView2";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(516, 41);
            this.panelControl1.TabIndex = 11;
            this.panelControl1.Text = "panelControl1";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCancel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.simpleButton3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton3.ImageIndex = 0;
            this.simpleButton3.Location = new System.Drawing.Point(77, 4);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(59, 32);
            this.simpleButton3.TabIndex = 15;
            this.simpleButton3.Text = global::Inventory.Properties.Settings.Default.strCancel;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strOK", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.simpleButton1.ImageIndex = 0;
            this.simpleButton1.Location = new System.Drawing.Point(12, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(59, 32);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Text = global::Inventory.Properties.Settings.Default.strOK;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSearch.ImageIndex = 0;
            this.btnSearch.ImageList = this.imageList1;
            this.btnSearch.Location = new System.Drawing.Point(223, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strShowAll", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.simpleButton2.ImageIndex = 0;
            this.simpleButton2.Location = new System.Drawing.Point(163, 5);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(54, 32);
            this.simpleButton2.TabIndex = 14;
            this.simpleButton2.Text = global::Inventory.Properties.Settings.Default.strShowAll;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.defaultLookAndFeel1.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // SelectCustomer
            // 
            this.ClientSize = new System.Drawing.Size(516, 354);
            this.Controls.Add(this.grdCustomer);
            this.Controls.Add(this.panelControl1);
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.Name = "SelectCustomer";
            this.Text = "SelectCustomer";
            this.Load += new System.EventHandler(this.SelectCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private void SelectCustomer_Load(object sender, EventArgs e)
        {
            Globals.SetDefaultFont(this);
            if (cID == "")
                SearchCmd("");
            else
                SearchCmd("[Contact ID] ='" + cID + "'");
        }
        private GridView gvCustomer;
        private DataTable tblCustomer;
        

        private void LoadCustomerTab(DataTable tab)
        {
            grdCustomer.DataSource = tab;

            GridView gridView = (GridView)grdCustomer.Views[0];
            gvCustomer = gridView;

            //gridView.Columns[0].Visible = false;
            //gridView.Columns[1].Width = 30;
            //gridView.ScrollStyle = ScrollStyleFlags.LiveVertScroll | ScrollStyleFlags.LiveHorzScroll;

            foreach (GridColumn cl in gridView.Columns)
            {
                cl.Visible = false;
                cl.MinWidth = 10;
            }

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
            gridView.OptionsBehavior.Editable = false;
            gridView.Columns["Mr"].Width = 20;

        }
        private void loadCustomer()
        {
            BL_Customer customer = new BL_Customer();
            if (customer == null) return;
            tblCustomer = customer.View().Tables[0].Copy();
            tblCustomer.Columns.Add("RecStatus", typeof(int));
            LoadCustomerTab(tblCustomer);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchCustomers();
        }
        private void searchCustomers()
        {
            Search frm = new Search();
            frm.setTable("VListCustomers");
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                SearchCmd(frm.getSearchStr());
            }
        }
        private void SearchCmd(string searchStr)
        {
            try
            {
                string strSQL = "SELECT * FROM VListCustomers";
                string str2 = "";
                if (searchStr != "")
                {
                    str2 += searchStr;
                    if (strChildID != "")
                        str2 += " AND ";
                }
                
                if (strChildID != "")
                    str2 += " [Contact ID] <> '" + strChildID + "'";
                if (str2 != "") strSQL += " WHERE " + str2;
                Data_Access.DoSqlCommand(strSQL);
                tblCustomer = Data_Access.GetDataSet().Tables[0].Copy();
                tblCustomer.Columns.Add("RecStatus", typeof(int));
                LoadCustomerTab(tblCustomer);
            }
            catch { }
        }
        private string cID = "";
        private string strChildID = "";
        public string CustomerName
        {
            get
            {
                try
                {
                    if (gvCustomer.RowCount <= 0) return "";
                    int r = gvCustomer.GetSelectedRows()[0];// lay hang hien tai
                    DataRow row = ((DataRowView)gvCustomer.GetRow(r)).Row;

                    return row["Last Name"].ToString() + " " + row["Middle Name"].ToString() + " " + row["First Name"].ToString();
                }
                catch (Exception) { }
                return "";
            }
        }
        public string CustomerID
        {
            get
            {
                try
                {
                    if (gvCustomer.RowCount <= 0) return "";
                    int r = gvCustomer.GetSelectedRows()[0];// lay hang hien tai
                    DataRow row = ((DataRowView)gvCustomer.GetRow(r)).Row;

                    return row["Contact ID"].ToString();
                }
                catch (Exception) { }
                return "";
            }
            set 
            {
                cID = value;    
            }
        }
        public string ChildID
        {
            set { strChildID = value; }
            get { return strChildID; }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (CustomerID == "")
            {
                MessageBox.Show("You have to select parent!");
            }
            else this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SearchCmd("");
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

