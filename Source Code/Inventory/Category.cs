using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Inventory.Properties
{
    /// <summary>
    /// Summary description for Category.
    /// </summary>
    public class Category : DevExpress.XtraEditors.XtraForm
    {
        private MemoEdit txtDescription;
        private TextEdit txtName;
        private Label label1;
        private Label label2;
        private GroupControl groupControl1;
        private PanelControl panelControl1;
        private GroupControl groupControl2;
        private ListBoxControl lstDest;
        private ListBoxControl lstSource;
        private SimpleButton btnRemoveAll;
        private SimpleButton btnRemove;
        private SimpleButton btnAddAll;
        private SimpleButton btnAdd;
        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Category()
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
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lstSource = new DevExpress.XtraEditors.ListBoxControl();
            this.lstDest = new DevExpress.XtraEditors.ListBoxControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemoveAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDest)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(97, 51);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(310, 48);
            this.txtDescription.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 20);
            this.txtName.Name = "txtName";
            this.txtName.Properties.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(309, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strDescription", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = global::Inventory.Properties.Settings.Default.strDescription;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCategoryName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = global::Inventory.Properties.Settings.Default.strCategoryName;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtDescription);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCategoryInformation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(455, 111);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = global::Inventory.Properties.Settings.Default.strCategoryInformation;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnOK);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 336);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(455, 51);
            this.panelControl1.TabIndex = 5;
            this.panelControl1.Text = "panelControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnRemoveAll);
            this.groupControl2.Controls.Add(this.btnRemove);
            this.groupControl2.Controls.Add(this.btnAddAll);
            this.groupControl2.Controls.Add(this.btnAdd);
            this.groupControl2.Controls.Add(this.lstDest);
            this.groupControl2.Controls.Add(this.lstSource);
            this.groupControl2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCategorySelect", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 111);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(455, 225);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = global::Inventory.Properties.Settings.Default.strCategorySelect;
            // 
            // lstSource
            // 
            this.lstSource.Location = new System.Drawing.Point(6, 23);
            this.lstSource.Name = "lstSource";
            this.lstSource.Size = new System.Drawing.Size(178, 197);
            this.lstSource.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.lstSource.TabIndex = 0;
            this.lstSource.SelectedValueChanged += new System.EventHandler(this.lstSource_SelectedValueChanged);
            this.lstSource.Leave += new System.EventHandler(this.lstSource_Leave);
            this.lstSource.Enter += new System.EventHandler(this.lstSource_Enter);
            // 
            // lstDest
            // 
            this.lstDest.Location = new System.Drawing.Point(271, 22);
            this.lstDest.Name = "lstDest";
            this.lstDest.Size = new System.Drawing.Size(178, 197);
            this.lstDest.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.lstDest.TabIndex = 1;
            this.lstDest.Leave += new System.EventHandler(this.lstDest_Leave);
            this.lstDest.Enter += new System.EventHandler(this.lstDest_Enter);
            this.lstDest.SelectedIndexChanged += new System.EventHandler(this.lstDest_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(196, 54);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 20);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = ">";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(196, 80);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(58, 20);
            this.btnAddAll.TabIndex = 3;
            this.btnAddAll.Text = ">>";
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(196, 120);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(58, 20);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "<";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(196, 146);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(58, 20);
            this.btnRemoveAll.TabIndex = 5;
            this.btnRemoveAll.Text = "<<";
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnOK
            // 
            this.btnOK.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strOK", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(15, 15);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(115, 25);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = global::Inventory.Properties.Settings.Default.strOK;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCancel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnCancel.Location = new System.Drawing.Point(170, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = global::Inventory.Properties.Settings.Default.strCancel;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Category
            // 
            this.ClientSize = new System.Drawing.Size(455, 387);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCategory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Category";
            this.Text = global::Inventory.Properties.Settings.Default.strCategory;
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDest)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private CategoryRec[] CatExist = null;// luu nhung Cat da duoc thiet lap
        private void Category_Load(object sender, EventArgs e)
        {
            Globals.SetDefaultFont(this);
            LoadCategory();
        }
        private string strContactID = "";
        public string ContactID
        {
            get { return strContactID; }
            set
            {
                strContactID = value;
            }
        }
        private void LoadCategory()
        {
            DataTable destTable = null;
            DataTable sourceTable = null;
            string strSQL;
            if (CatExist != null)
            {
                /*
                // load ContactCategory Table
                strSQL = "SELECT CategoryInContact.ContactCatID, ContactCatName, Notes, ViewStatus, UserID FROM CategoryInContact  WHERE not (ContactCatID in (SELECT ContactCatID FROM ContactCategory WHERE ContactID = '" + strContactID + "')) AND CategoryInContact.ViewStatus = 'true'";
                if (!Data_Access.DoSqlCommand(strSQL)) return;
                sourceTable = Data_Access.GetDataSet().Tables[0].Copy();

                // load ContactCategory Table
                strSQL = "SELECT CategoryInContact.ContactCatID, ContactCatName, Notes, ViewStatus, UserID FROM ContactCategory, CategoryInContact WHERE ContactCategory.ContactCatID = CategoryInContact.ContactCatID AND ContactCategory.ContactID = '" + strContactID + "' AND CategoryInContact.ViewStatus = 'true'";
                if (!Data_Access.DoSqlCommand(strSQL)) return;
                destTable = Data_Access.GetDataSet().Tables[0].Copy();
                 */
                strSQL = "SELECT * FROM CategoryInContact WHERE CategoryInContact.ViewStatus = 'true'";
                //if (strContactID != "")            
                lstDest.Items.Clear();
                lstSource.Items.Clear();
                if (!Data_Access.DoSqlCommand(strSQL)) return;
                DataTable tb = Data_Access.GetDataSet().Tables[0].Copy();
                foreach (DataRow row in tb.Rows)
                {
                    CategoryRec rec = new CategoryRec();
                    rec.AssignFromDataRow(row);
                    rec.status = 0;
                    CategoryRec rec2 = isExist(row["ContactCatID"].ToString());
                    if  ( rec2 != null && rec2.status != -1)
                    {
                        lstDest.Items.Add(rec2);
                    } else  if (rec2 != null && rec2.status == - 1)
                        lstSource.Items.Add(rec2);
                    else lstSource.Items.Add(rec);
                }
            }
            else
            {
                // load Category Table
                strSQL = "SELECT * FROM CategoryInContact WHERE CategoryInContact.ViewStatus = 'true'";
                //if (strContactID != "")                
                if (!Data_Access.DoSqlCommand(strSQL)) return;

                sourceTable = Data_Access.GetDataSet().Tables[0].Copy();
                if (destTable != null)
                {
                    CatExist = new CategoryRec[destTable.Rows.Count];
                    int i = 0;
                    lstSource.Items.Clear();
                    foreach (DataRow dr in destTable.Rows)
                    {
                        CategoryRec rec = new CategoryRec();
                        rec.AssignFromDataRow(dr);
                        rec.status = 0;
                        lstDest.Items.Add(rec);
                        CatExist[i++] = rec;
                    }
                }
            }
/*
            // xuat thong tin ra list
            lstDest.Items.Clear();            
            foreach (DataRow dr in sourceTable.Rows)
            {
                CategoryRec rec = new CategoryRec();
                rec.AssignFromDataRow(dr);
                lstSource.Items.Add(rec);
            }
  */         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstSource.SelectedItem != null)
            {
                lstDest.Items.Add(lstSource.SelectedItem);
                ((CategoryRec)lstSource.SelectedItem).status = 1; //add
                lstSource.Items.Remove(lstSource.SelectedItem);                
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstDest.SelectedItem != null)
            {
                lstSource.Items.Add(lstDest.SelectedItem);
                ((CategoryRec)lstDest.SelectedItem).status = -1; //remove
                lstDest.Items.Remove(lstDest.SelectedItem);
                
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            foreach (object obj in lstSource.Items)
            {
                lstDest.Items.Add(obj);
                ((CategoryRec)obj).status = 1; //add
            }
            lstSource.Items.Clear();
            
            
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (object obj in lstDest.Items)
            {
                lstSource.Items.Add(obj);
                ((CategoryRec)obj).status = -1; //remove
            }
            lstDest.Items.Clear();
        }
        // kiem tra xem rec co nam trong CatExist khong
        private bool isExist(CategoryRec rec)
        {
            if (CatExist == null) return false;
            foreach (CategoryRec r in CatExist)
                if (r == rec) return true;
            return false;
        }
        private CategoryRec isExist(string CatID)
        {
            if (CatExist == null) return null;
            foreach (CategoryRec r in CatExist)
                if (r.ContactCatID == CatID) return r;
            return null;
        }
        public void SetCategories(CategoryRec[] cats)
        {
            CatExist = cats;
            if (CatExist == null)
            {
                List<CategoryRec> lst = new List<CategoryRec>();
                string strSQL = "SELECT CategoryInContact.ContactCatID, ContactCatName, Notes, ViewStatus, UserID FROM ContactCategory, CategoryInContact WHERE ContactCategory.ContactCatID = CategoryInContact.ContactCatID AND ContactCategory.ContactID = '" + strContactID + "' AND CategoryInContact.ViewStatus = 'true'";
                if (!Data_Access.DoSqlCommand(strSQL)) return;
                DataTable tb = Data_Access.GetDataSet().Tables[0].Copy();
                foreach (DataRow row in tb.Rows)
                {
                    CategoryRec rec = new CategoryRec();
                    rec.AssignFromDataRow(row);
                    rec.status = 0;
                    lst.Add(rec);
                }
                CatExist = lst.ToArray();
            }
        }
        // lay ve danh sach categories
        public CategoryRec[] GetCategories()
        {

            List<CategoryRec> ret = new List<CategoryRec>();
            if (CatExist != null)
            {
                for (int i = 0; i < CatExist.Length; i++)
                {
                    ret.Add(CatExist[i]);
                }
            }
            for (int i = 0; i < lstDest.Items.Count; i++)
            {
                CategoryRec item = (CategoryRec)lstDest.Items[i];
                if (isExist(item)) item.status = 0;
                if (item.status == 1) ret.Add(item);
            }

            return ret.ToArray();

        }

        private void lstSource_SelectedValueChanged(object sender, EventArgs e)
        {
            ShowCatInform((CategoryRec)lstSource.SelectedItem);
            

        }
        private void ShowCatInform(CategoryRec cat)
        {
            if (cat != null)
            {
                txtName.Text = cat.ContactCatName;
                txtDescription.Text = cat.Notes;
            }
            
        }

        private void lstDest_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCatInform((CategoryRec)lstDest.SelectedItem);
        }

        private void lstSource_Leave(object sender, EventArgs e)
        {
            
        }

        private void lstDest_Leave(object sender, EventArgs e)
        {
            
        }

        private void lstSource_Enter(object sender, EventArgs e)
        {
            lstDest.SelectedIndex = -1;
        }

        private void lstDest_Enter(object sender, EventArgs e)
        {
            lstSource.SelectedIndex = -1;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CategoryRec[] rr = GetCategories();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        
    }
    
}

