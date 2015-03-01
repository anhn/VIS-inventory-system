using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;
using System.Data.SqlClient;

namespace SqlTest
{
    /// <summary>
    /// Summary description for frmOrderBy.
    /// </summary>     

    public class frmOrderBy : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton btnBack;
        private SimpleButton btnOk;
        private SimpleButton btnCancel;
        public DevExpress.XtraGrid.GridControl grMain;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn grclField;
        private DevExpress.XtraGrid.Columns.GridColumn grclAlias;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn grclOrderBy;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn grclGroup;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn grclShow;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private SimpleButton btnUp;
        private SimpleButton btnDown;
        private DevExpress.XtraGrid.Columns.GridColumn grclDescription;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmOrderBy()
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
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.grMain = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grclField = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grclAlias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.grclOrderBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.grclGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.grclShow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.grclDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUp = new DevExpress.XtraEditors.SimpleButton();
            this.btnDown = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnBack.Location = new System.Drawing.Point(449, 440);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 28);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "&Back";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(529, 440);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(74, 28);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "&Next";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnCancel.Location = new System.Drawing.Point(609, 440);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "&Cancel";
            // 
            // grMain
            // 
            this.grMain.EmbeddedNavigator.Name = "";
            this.grMain.Location = new System.Drawing.Point(12, 12);
            this.grMain.MainView = this.gridView1;
            this.grMain.Name = "grMain";
            this.grMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2});
            this.grMain.Size = new System.Drawing.Size(675, 424);
            this.grMain.TabIndex = 15;
            this.grMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grclField,
            this.grclAlias,
            this.grclOrderBy,
            this.grclGroup,
            this.grclShow,
            this.grclDescription});
            this.gridView1.GridControl = this.grMain;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEdit);
            // 
            // grclField
            // 
            this.grclField.Caption = "Field";
            this.grclField.FieldName = "Field";
            this.grclField.Name = "grclField";
            this.grclField.Visible = true;
            this.grclField.VisibleIndex = 0;
            this.grclField.Width = 179;
            // 
            // grclAlias
            // 
            this.grclAlias.Caption = "Alias";
            this.grclAlias.ColumnEdit = this.repositoryItemTextEdit1;
            this.grclAlias.FieldName = "Alias";
            this.grclAlias.Name = "grclAlias";
            this.grclAlias.Visible = true;
            this.grclAlias.VisibleIndex = 1;
            this.grclAlias.Width = 92;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // grclOrderBy
            // 
            this.grclOrderBy.Caption = "Order By";
            this.grclOrderBy.ColumnEdit = this.repositoryItemComboBox1;
            this.grclOrderBy.FieldName = "OrderBy";
            this.grclOrderBy.Name = "grclOrderBy";
            this.grclOrderBy.Visible = true;
            this.grclOrderBy.VisibleIndex = 2;
            this.grclOrderBy.Width = 53;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "",
            "ASC",
            "DESC"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // grclGroup
            // 
            this.grclGroup.Caption = "Group";
            this.grclGroup.ColumnEdit = this.repositoryItemCheckEdit1;
            this.grclGroup.FieldName = "Group";
            this.grclGroup.Name = "grclGroup";
            this.grclGroup.Visible = true;
            this.grclGroup.VisibleIndex = 3;
            this.grclGroup.Width = 36;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // grclShow
            // 
            this.grclShow.Caption = "Show";
            this.grclShow.ColumnEdit = this.repositoryItemCheckEdit2;
            this.grclShow.FieldName = "Show";
            this.grclShow.Name = "grclShow";
            this.grclShow.Visible = true;
            this.grclShow.VisibleIndex = 4;
            this.grclShow.Width = 41;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // grclDescription
            // 
            this.grclDescription.Caption = "Description";
            this.grclDescription.FieldName = "Description";
            this.grclDescription.Name = "grclDescription";
            this.grclDescription.Visible = true;
            this.grclDescription.VisibleIndex = 5;
            this.grclDescription.Width = 260;
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUp.Location = new System.Drawing.Point(12, 440);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(53, 28);
            this.btnUp.TabIndex = 16;
            this.btnUp.Text = "&Up";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDown.Location = new System.Drawing.Point(71, 440);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(50, 28);
            this.btnDown.TabIndex = 17;
            this.btnDown.Text = "&Down";
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // frmOrderBy
            // 
            this.ClientSize = new System.Drawing.Size(697, 480);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.grMain);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrderBy";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order and Group";
            this.Load += new System.EventHandler(this.frmOrderBy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        public ArrayList arr;
        public bool reload = true;
        public string sql;
        private void frmOrderBy_Load(object sender, EventArgs e)
        {           
            grMain.DataSource = arr;
            gridView1.RefreshData();
        }

        private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "Alias")
            {
                e.RepositoryItem = repositoryItemTextEdit1;
            }
            else if (e.Column.FieldName == "Order By")
                e.RepositoryItem = repositoryItemComboBox1;
            else if (e.Column.FieldName == "Group" || e.Column.FieldName == "Show")
                e.RepositoryItem = repositoryItemCheckEdit1;
        }

        private void repositoryItemTextEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        public String selectStatement;
        public String otherStatement;

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool orderOk = true;
            int i = 0;
            while (i < arr.Count)
            {
                if (!(arr[i] as Record).Group)
                {
                    while (i < arr.Count)
                    {
                        if ((arr[i] as Record).Group)
                        {
                            orderOk = false;
                            i = arr.Count;
                        }
                        i++;
                    }
                }
                i++;
            }

            if (!orderOk)
            {
                MessageBox.Show("Please bring group field to top order.");
                return;
            }

            Hashtable hst = new Hashtable();
            foreach (Record r in arr)
            {
                if (r.Alias == "") continue;
                if (hst.ContainsKey(r.Alias.ToUpper()))
                {
                    MessageBox.Show("There is more than one field has alias: " + r.Alias);
                    return;
                }
                else hst.Add(r.Alias.ToUpper(), r.Alias.ToUpper());
            }
            try
            {
                selectStatement = getSelectStatement();
                otherStatement = ((frmMain)Tag).fCriterial.getSqlCommand()
                                  + getOrderByStatement();
                sql = selectStatement + " " + otherStatement;
                SqlConnection con = new SqlConnection(DbManager.getConnectString());
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
                ((frmMain)Tag).fFilterPreview.grMain.DataSource = dt;
                ((frmMain)Tag).fFilterPreview.grView.PopulateColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is error, perhaps these fields could not be groupped. Please try again.");
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private string getOrderByStatement()
        {
            string orderBy = "";
            foreach (Record r in arr)
            {
                if (r.OrderBy != "")
                {
                    if (orderBy.Length != 0) orderBy += " , ";
                    orderBy += r.Field + " " + r.OrderBy;
                }                
            }
            if (orderBy.Length > 0)
                orderBy = " ORDER BY " + orderBy;
            return orderBy;
        }

        private string getGroupByStatement()
        {
            string groupBy = "";
            foreach (Record r in arr)
            {
                if (r.Group)
                {
                    if (groupBy.Length != 0) groupBy += " , ";
                    groupBy += r.Field;
                }                
            }
            if (groupBy.Length > 0)
                groupBy = " GROUP BY " + groupBy;
            return groupBy;
        }

        private string getSelectStatement()
        {
            string select = "";
            foreach (Record r in arr)
            {
                if (r.Show)
                {
                    if (select.Length != 0) select += " , ";
                    select += r.Field;
                    if (r.Alias.Trim().Length != 0) select += " AS [" + r.Alias.Trim() + "]";
                }            
            }
            select = "SELECT " + select;
            return select;
        }

        private void repositoryItemTextEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int[] selected = gridView1.GetSelectedRows();
            if (gridView1.SelectedRowsCount == 0 || selected[0] == 0) return;
            //exchange two row
            int id = selected[0];
            Record r = arr[id] as Record;
            arr.Remove(r);
            arr.Insert(id - 1, r);   
            gridView1.RefreshData();
            gridView1.FocusedRowHandle = id - 1;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int[] selected = gridView1.GetSelectedRows();
            if (gridView1.SelectedRowsCount == 0 || selected[0] == arr.Count - 1) return;
            //exchange two row
            int id = selected[0];
            Record r = arr[id] as Record;
            arr.Remove(r);
            arr.Insert(id + 1, r);
            gridView1.RefreshData();
            gridView1.FocusedRowHandle = id + 1;
        }
    }


    public class Record
    {
        private string fField;
        private string fAlias;
        private string fOrderBy;
        private bool fGroup;
        private bool fShow;
        private string fType;
        private string fDes;
        private string fFormat;
        private string fRate;
        private string fOther;
        private byte fIntType;
        public Record(string fcategory)
        {
            this.fField = fcategory;
            this.fAlias = "";
            this.fOrderBy = "";
            this.fOther = "";
            this.fRate = "";
            this.fFormat = "";
            this.fGroup = false;
            this.fShow = false;
        }

        public string Field
        {
            get { return fField; }
        }

        public string Type
        {
            get { return fType; }
            set { fType = value; fIntType = frmCriterial.GetFieldGroup(fType); }
        }

        public byte IntType
        {
            get {return fIntType; } 
        }

        public string Alias
        {
            get { return fAlias; }
            set { fAlias = value; }
        }

        public string Description
        {
            get { return fDes; }
            set { fDes = value; }
        }

        public string OrderBy
        {
            get { return fOrderBy; }
            set { fOrderBy = value; }
        }

        public bool Group
        {
            get { return fGroup; }
            set { fGroup = value; }
        }
        public bool Show
        {
            get { return fShow; }
            set { fShow = value; }
        }
        public string Format
        {
            get { return fFormat; }
            set { fFormat = value; }
        }

        public string Rate
        {
            get { return fRate; }
            set { fRate = value; }
        }

        public string Other
        {
            get { return fOther; }
            set { fOther = value; }
        }
    }
}

