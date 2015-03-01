using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Inventory.Forms.Location
{
    /// <summary>
    /// Summary description for frmLocationSelector.
    /// </summary>
    public class frmProductLocationSelector : DevExpress.XtraEditors.XtraForm
    {
        private GroupControl groupControl1;
        private Label label1;
        private Label label3;
        private Label label2;
        private GroupControl groupControl2;
        private TextEdit txtDescription;
        private TextEdit txtName;
        private TextEdit txtID;
        private SimpleButton btnSelect;
        private SimpleButton btnSearch;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.ComponentModel.Container components = null;
        private TextEdit txtAlternativeID;
        private Label label4;
        private SimpleButton btnAll;
        private string m_strProductID = "";

        public string ProductID
        {
            get
            {
                return m_strProductID;
            }
        }

        public frmProductLocationSelector()
        {
            InitializeComponent();
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtAlternativeID = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAll = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlternativeID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnAll);
            this.groupControl1.Controls.Add(this.txtAlternativeID);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.btnSelect);
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Controls.Add(this.txtDescription);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(575, 129);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Product description";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(495, 101);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Select";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(414, 101);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(98, 75);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(472, 20);
            this.txtDescription.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(343, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(98, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(195, 20);
            this.txtID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Location = new System.Drawing.Point(12, 147);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(575, 225);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "Double click a product item in the list below list to select it";
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(5, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(565, 200);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // txtAlternativeID
            // 
            this.txtAlternativeID.Location = new System.Drawing.Point(98, 49);
            this.txtAlternativeID.Name = "txtAlternativeID";
            this.txtAlternativeID.Size = new System.Drawing.Size(194, 20);
            this.txtAlternativeID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alternative ID:";
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(333, 101);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 5;
            this.btnAll.Text = "See all";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // frmProductLocationSelector
            // 
            this.ClientSize = new System.Drawing.Size(599, 384);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductLocationSelector";
            this.Text = "Product Location Selector";
            this.Load += new System.EventHandler(this.frmProductLocationSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlternativeID.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private void frmProductLocationSelector_Load(object sender, EventArgs e)
        {
            // Temporary do nothing
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the list of visible product
                string strCondition = "";
                if (!txtID.Text.Equals(""))
                {
                    strCondition += String.Format(" And ProductID like '%{0}%'", txtID.Text);
                }
                if (!txtAlternativeID.Text.Equals(""))
                {
                    strCondition += String.Format(" And AlternativeID like '%{0}%'", txtAlternativeID.Text);
                }
                if (!txtName.Text.Equals(""))
                {
                    strCondition += String.Format(" And ProductName like '%{0}%'", txtName.Text);
                }
                if (!txtDescription.Text.Equals(""))
                {
                    strCondition += String.Format(" And Description like '%{0}%'", txtDescription.Text);
                }

                string strSQL = String.Format("Select ProductID,AlternativeID,ProductName,Description From ProductMaster Where ViewStatus='True' {0} Order By ProductID", strCondition);
                gridControl1.DataSource = Toolkit.DbToolKit.OpenSqlReturnTable(strSQL);
                gridView1.Columns[0].Caption = "Product ID";
                gridView1.Columns[1].Caption = "Alternative ID";
                gridView1.Columns[2].Caption = "Product Name";
                gridView1.Columns[3].Caption = "Description";
            }
            catch (Exception oExc)
            {
                MessageBox.Show(String.Format("Error encountered while loading product list, {0}", oExc.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            btnSelect_Click(sender, e);
        }

        private void gridView1_FocusedRowChanged(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                txtID.Text = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]).ItemArray[0].ToString();
                txtAlternativeID.Text = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]).ItemArray[1].ToString();
                txtName.Text = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]).ItemArray[2].ToString();
                txtDescription.Text = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]).ItemArray[3].ToString();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 0)
            {
                MessageBox.Show("You still do not select product?", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Do you want to continue or select another product?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                m_strProductID = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]).ItemArray[0].ToString();
                this.Close();
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the list of visible product
                string strSQL = "Select ProductID,AlternativeID,ProductName,Description From ProductMaster Where ViewStatus='True' Order By ProductID";
                gridControl1.DataSource = Toolkit.DbToolKit.OpenSqlReturnTable(strSQL);
                gridView1.Columns[0].Caption = "Product ID";
                gridView1.Columns[1].Caption = "Alternative ID";
                gridView1.Columns[2].Caption = "Product Name";
                gridView1.Columns[3].Caption = "Description";
            }
            catch (Exception oExc)
            {
                MessageBox.Show(String.Format("Error encountered while loading product list, {0}", oExc.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        
    }
}

