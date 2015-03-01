using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Data;

namespace SqlTest
{
    /// <summary>
    /// Summary description for frmAddTable.
    /// </summary>
    public class frmAddTable : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton btnClose;
        private DevExpress.XtraTab.XtraTabControl tabTable;
        private DevExpress.XtraTab.XtraTabPage tbTable;
        private ListBoxControl lstTable;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private SimpleButton btnBack;
        private SimpleButton btnRemoveTable;
        private SimpleButton btnAddTable;
        public ListBoxControl lstAddedTable;
        private SimpleButton btnRemoveViews;
        private SimpleButton btnAddViews;
        public ListBoxControl lstAddedViews;
        private ListBoxControl lstViews;
        private Label label1;
        private SimpleButton btnCancel;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmAddTable()
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
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.tabTable = new DevExpress.XtraTab.XtraTabControl();
            this.tbTable = new DevExpress.XtraTab.XtraTabPage();
            this.btnRemoveTable = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddTable = new DevExpress.XtraEditors.SimpleButton();
            this.lstAddedTable = new DevExpress.XtraEditors.ListBoxControl();
            this.lstTable = new DevExpress.XtraEditors.ListBoxControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnRemoveViews = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddViews = new DevExpress.XtraEditors.SimpleButton();
            this.lstAddedViews = new DevExpress.XtraEditors.ListBoxControl();
            this.lstViews = new DevExpress.XtraEditors.ListBoxControl();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabTable)).BeginInit();
            this.tabTable.SuspendLayout();
            this.tbTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstAddedTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstTable)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstAddedViews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstViews)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(367, 335);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Next";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabTable
            // 
            this.tabTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTable.Location = new System.Drawing.Point(12, 12);
            this.tabTable.Name = "tabTable";
            this.tabTable.SelectedTabPage = this.tbTable;
            this.tabTable.Size = new System.Drawing.Size(517, 317);
            this.tabTable.TabIndex = 2;
            this.tabTable.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tbTable,
            this.xtraTabPage1});
            this.tabTable.Text = ">>";
            // 
            // tbTable
            // 
            this.tbTable.Controls.Add(this.btnRemoveTable);
            this.tbTable.Controls.Add(this.btnAddTable);
            this.tbTable.Controls.Add(this.lstAddedTable);
            this.tbTable.Controls.Add(this.lstTable);
            this.tbTable.Name = "tbTable";
            this.tbTable.Size = new System.Drawing.Size(511, 291);
            this.tbTable.Text = "Tables";
            // 
            // btnRemoveTable
            // 
            this.btnRemoveTable.Location = new System.Drawing.Point(238, 136);
            this.btnRemoveTable.Name = "btnRemoveTable";
            this.btnRemoveTable.Size = new System.Drawing.Size(26, 26);
            this.btnRemoveTable.TabIndex = 9;
            this.btnRemoveTable.Text = "<<";
            this.btnRemoveTable.Click += new System.EventHandler(this.btnRemoveTable_Click_1);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(238, 104);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(26, 26);
            this.btnAddTable.TabIndex = 8;
            this.btnAddTable.Text = ">>";
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // lstAddedTable
            // 
            this.lstAddedTable.Location = new System.Drawing.Point(270, 14);
            this.lstAddedTable.Name = "lstAddedTable";
            this.lstAddedTable.Size = new System.Drawing.Size(228, 264);
            this.lstAddedTable.TabIndex = 6;
            this.lstAddedTable.DoubleClick += new System.EventHandler(this.lstAddedTable_DoubleClick);
            // 
            // lstTable
            // 
            this.lstTable.Location = new System.Drawing.Point(13, 14);
            this.lstTable.Name = "lstTable";
            this.lstTable.Size = new System.Drawing.Size(219, 264);
            this.lstTable.TabIndex = 0;
            this.lstTable.DoubleClick += new System.EventHandler(this.lstTable_DoubleClick);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnRemoveViews);
            this.xtraTabPage1.Controls.Add(this.btnAddViews);
            this.xtraTabPage1.Controls.Add(this.lstAddedViews);
            this.xtraTabPage1.Controls.Add(this.lstViews);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(511, 291);
            this.xtraTabPage1.Text = "Views";
            // 
            // btnRemoveViews
            // 
            this.btnRemoveViews.Location = new System.Drawing.Point(238, 136);
            this.btnRemoveViews.Name = "btnRemoveViews";
            this.btnRemoveViews.Size = new System.Drawing.Size(26, 26);
            this.btnRemoveViews.TabIndex = 7;
            this.btnRemoveViews.Text = "<<";
            this.btnRemoveViews.Click += new System.EventHandler(this.btnRemoveViews_Click_1);
            // 
            // btnAddViews
            // 
            this.btnAddViews.Location = new System.Drawing.Point(238, 104);
            this.btnAddViews.Name = "btnAddViews";
            this.btnAddViews.Size = new System.Drawing.Size(26, 26);
            this.btnAddViews.TabIndex = 6;
            this.btnAddViews.Text = ">>";
            this.btnAddViews.Click += new System.EventHandler(this.btnAddViews_Click_1);
            // 
            // lstAddedViews
            // 
            this.lstAddedViews.Location = new System.Drawing.Point(270, 14);
            this.lstAddedViews.Name = "lstAddedViews";
            this.lstAddedViews.Size = new System.Drawing.Size(228, 264);
            this.lstAddedViews.TabIndex = 5;
            this.lstAddedViews.DoubleClick += new System.EventHandler(this.lstAddedViews_DoubleClick);
            // 
            // lstViews
            // 
            this.lstViews.Location = new System.Drawing.Point(13, 14);
            this.lstViews.Name = "lstViews";
            this.lstViews.Size = new System.Drawing.Size(219, 264);
            this.lstViews.TabIndex = 4;
            this.lstViews.DoubleClick += new System.EventHandler(this.lstViews_DoubleClick);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnBack.Location = new System.Drawing.Point(284, 335);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 28);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "&Back";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "*Double Click on Item to Add/Remove Table/View";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnCancel.Location = new System.Drawing.Point(450, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            // 
            // frmAddTable
            // 
            this.ClientSize = new System.Drawing.Size(541, 375);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabTable);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddTable";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Tables and Views";
            this.Load += new System.EventHandler(this.frmAddTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabTable)).EndInit();
            this.tabTable.ResumeLayout(false);
            this.tbTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstAddedTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstTable)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstAddedViews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstViews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        public frmCriterial frm;
        private void moveSelectedItem(ListBoxControl lstSrc, ListBoxControl lstDesc)
        {
            if (lstSrc.SelectedItem != null)
            {
                lstDesc.Items.Add(lstSrc.SelectedItem);
                lstSrc.Items.Remove(lstSrc.SelectedItem);
                if ((Tag as frmMain).fCriterial.dt != null && (Tag as frmMain).fCriterial.dt.Rows.Count > 0)
                {
                    (Tag as frmMain).fCriterial.reload = false;
                }
            }
        }

        public bool reload = true;

        private void frmAddTable_Load(object sender, EventArgs e)
        {
            if (!reload) return;
            reload = false;
            try
            {
                DbManager.OpenSQL("select name from sys.tables order by name");
                lstTable.Items.Clear();
                lstAddedTable.Items.Clear();
                lstAddedViews.Items.Clear();
                //Loop though and display the first column of the results.
                while (DbManager.reader.Read())
                {
                    lstTable.Items.Add(DbManager.reader[0]);
                }

                //Close The reader and connection
                DbManager.reader.Close();
                DbManager.OpenSQL("select name from sys.views order by name");
                lstViews.Items.Clear();
                while (DbManager.reader.Read())
                    lstViews.Items.Add(DbManager.reader[0]);
                DbManager.reader.Close();
                lstTable.Select();
                frmMain frm = Tag as frmMain;

                if (frm.actionType == frmMain.ACTION_OPEN_REPORT)
                {
                    Hashtable hst = new Hashtable();
                    foreach (DataRow r in frm.fCriterial.dt.Rows)
                    {
                        string str = r["Table"].ToString() + r["View"].ToString();
                        if (!hst.ContainsKey(str)) hst.Add(str, null);
                    }

                    int cnt = lstTable.Items.Count;
                    int i = 0;
                    while (i < cnt)
                    {
                        string name = lstTable.Items[i].ToString();
                        if (hst.ContainsKey(name))
                        {
                            lstAddedTable.Items.Add(lstTable.Items[i]);
                            lstTable.Items.RemoveAt(i);
                            cnt--;
                            i--;
                        }
                        i++;
                    }

                    cnt = lstViews.Items.Count;
                    i = 0;
                    while (i < cnt)
                    {
                        string name = lstViews.Items[i].ToString();
                        if (hst.ContainsKey(name))
                        {
                            lstAddedViews.Items.Add(lstViews.Items[i]);
                            lstViews.Items.RemoveAt(i);
                            cnt--;
                            i--;
                        }
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading views and tables in database: " + DbManager.database);
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            moveSelectedItem(lstTable, lstAddedTable);
        }

        private void btnRemoveTable_Click_1(object sender, EventArgs e)
        {
            moveSelectedItem(lstAddedTable, lstTable);
        }

        private void btnAddViews_Click_1(object sender, EventArgs e)
        {
            moveSelectedItem(lstViews, lstAddedViews);
        }

        private void btnRemoveViews_Click_1(object sender, EventArgs e)
        {
            moveSelectedItem(lstAddedViews, lstViews);
        }

        private void lstTable_DoubleClick(object sender, EventArgs e)
        {
            btnAddTable_Click(sender, e);
        }

        private void lstAddedTable_DoubleClick(object sender, EventArgs e)
        {
            btnRemoveTable_Click_1(sender, e);
        }

        private void lstViews_DoubleClick(object sender, EventArgs e)
        {
            btnAddViews_Click_1(sender, e);
        }

        private void lstAddedViews_DoubleClick(object sender, EventArgs e)
        {
            btnRemoveViews_Click_1(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (lstAddedTable.ItemCount + lstAddedViews.ItemCount == 0)
            {
                MessageBox.Show("No talbe or view was added.");
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}

