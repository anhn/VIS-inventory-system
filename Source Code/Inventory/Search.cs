using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using System.Data;
using System.Data.SqlClient;

using System.IO;
using Inventory.Properties;
namespace Inventory
{
    /// <summary>
    /// Summary description for Search.
    /// </summary>
    public class Search : DevExpress.XtraEditors.XtraForm
    {
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private GroupControl groupControl4;
        private ComboBoxEdit cboField;
        private MemoEdit memoStatement;
        private ComboBoxEdit cboCombination;
        private ComboBoxEdit cboOperator;
        private SimpleButton btnAddItem;
        private GroupControl groupControl3;
        private SimpleButton btnCancel;
        private SimpleButton btnSave;
        private SimpleButton btnOK;
        private GroupControl groupControl2;
        private SimpleButton btnDelete;
        private SimpleButton btnEdit;
        private SimpleButton btnAddStatement;
        private GroupControl groupControl1;
        private ListBoxControl lstStatements;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBoxEdit cboValue;
        private SimpleButton btnClear;
        private IContainer components;

        public Search()
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
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.cboValue = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddItem = new DevExpress.XtraEditors.SimpleButton();
            this.cboCombination = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboOperator = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboField = new DevExpress.XtraEditors.ComboBoxEdit();
            this.memoStatement = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddStatement = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lstStatements = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCombination.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOperator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoStatement.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstStatements)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.defaultLookAndFeel1.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnClear);
            this.groupControl4.Controls.Add(this.cboValue);
            this.groupControl4.Controls.Add(this.label4);
            this.groupControl4.Controls.Add(this.label3);
            this.groupControl4.Controls.Add(this.label2);
            this.groupControl4.Controls.Add(this.label1);
            this.groupControl4.Controls.Add(this.btnAddItem);
            this.groupControl4.Controls.Add(this.cboCombination);
            this.groupControl4.Controls.Add(this.cboOperator);
            this.groupControl4.Controls.Add(this.cboField);
            this.groupControl4.Controls.Add(this.memoStatement);
            this.groupControl4.Location = new System.Drawing.Point(5, 5);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(599, 157);
            this.groupControl4.TabIndex = 4;
            this.groupControl4.Text = "Search statement";
            // 
            // btnClear
            // 
            this.btnClear.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strClear", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(484, 135);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 22);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = global::Inventory.Properties.Settings.Default.strClear;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cboValue
            // 
            this.cboValue.Location = new System.Drawing.Point(312, 124);
            this.cboValue.Name = "cboValue";
            this.cboValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboValue.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboValue.Size = new System.Drawing.Size(152, 20);
            this.cboValue.TabIndex = 4;
            this.cboValue.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cboValue_EditValueChanging);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Operator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Field";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Combination";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(484, 107);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(94, 22);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // cboCombination
            // 
            this.cboCombination.Enabled = false;
            this.cboCombination.Location = new System.Drawing.Point(5, 124);
            this.cboCombination.Name = "cboCombination";
            this.cboCombination.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCombination.Properties.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cboCombination.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboCombination.Size = new System.Drawing.Size(70, 20);
            this.cboCombination.TabIndex = 1;
            // 
            // cboOperator
            // 
            this.cboOperator.Location = new System.Drawing.Point(208, 124);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboOperator.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboOperator.Size = new System.Drawing.Size(98, 20);
            this.cboOperator.TabIndex = 3;
            // 
            // cboField
            // 
            this.cboField.Location = new System.Drawing.Point(85, 124);
            this.cboField.Name = "cboField";
            this.cboField.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboField.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboField.Size = new System.Drawing.Size(117, 20);
            this.cboField.TabIndex = 2;
            this.cboField.SelectedValueChanged += new System.EventHandler(this.cboField_SelectedValueChanged);
            // 
            // memoStatement
            // 
            this.memoStatement.Location = new System.Drawing.Point(5, 23);
            this.memoStatement.Name = "memoStatement";
            this.memoStatement.Properties.AcceptsReturn = false;
            this.memoStatement.Properties.ReadOnly = true;
            this.memoStatement.Size = new System.Drawing.Size(588, 83);
            this.memoStatement.TabIndex = 0;
            this.memoStatement.EditValueChanged += new System.EventHandler(this.memoEdit1_EditValueChanged);
            this.memoStatement.KeyDown += new System.Windows.Forms.KeyEventHandler(this.memoStatement_KeyDown);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnCancel);
            this.groupControl3.Controls.Add(this.btnSave);
            this.groupControl3.Controls.Add(this.btnOK);
            this.groupControl3.Location = new System.Drawing.Point(305, 168);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(299, 56);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "Search Management";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(203, 23);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(109, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(19, 23);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnDelete);
            this.groupControl2.Controls.Add(this.btnEdit);
            this.groupControl2.Controls.Add(this.btnAddStatement);
            this.groupControl2.Location = new System.Drawing.Point(5, 168);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(294, 56);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Query Management";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(205, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(108, 23);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddStatement
            // 
            this.btnAddStatement.Enabled = false;
            this.btnAddStatement.Location = new System.Drawing.Point(12, 23);
            this.btnAddStatement.Name = "btnAddStatement";
            this.btnAddStatement.Size = new System.Drawing.Size(75, 23);
            this.btnAddStatement.TabIndex = 1;
            this.btnAddStatement.Text = "Add";
            this.btnAddStatement.Click += new System.EventHandler(this.btnAddStatement_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lstStatements);
            this.groupControl1.Location = new System.Drawing.Point(5, 230);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(599, 104);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "List Query";
            // 
            // lstStatements
            // 
            this.lstStatements.Location = new System.Drawing.Point(5, 23);
            this.lstStatements.Name = "lstStatements";
            this.lstStatements.Size = new System.Drawing.Size(589, 71);
            this.lstStatements.TabIndex = 0;
            this.lstStatements.SelectedValueChanged += new System.EventHandler(this.lstStatements_SelectedValueChanged);
            this.lstStatements.SelectedIndexChanged += new System.EventHandler(this.lstStatements_SelectedIndexChanged);
            // 
            // Search
            // 
            this.ClientSize = new System.Drawing.Size(612, 342);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl4);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strSearch", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Search";
            this.Text = global::Inventory.Properties.Settings.Default.strSearch;
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCombination.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOperator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoStatement.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstStatements)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private void checkedListBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void setNumberOperator()
        {
            cboOperator.Properties.Items.Clear();
            cboOperator.Properties.Items.Add(new TabItem(">", ">"));
            cboOperator.Properties.Items.Add(new TabItem(">=", ">="));
            cboOperator.Properties.Items.Add(new TabItem("<", "<"));
            cboOperator.Properties.Items.Add(new TabItem("<=", "<="));
            cboOperator.Properties.Items.Add(new TabItem("=", "="));
            cboOperator.Properties.Items.Add(new TabItem("<>", "<>"));
        }
        private void setStringOperator()
        {
            cboOperator.Properties.Items.Clear();
            cboOperator.Properties.Items.Add(new TabItem("=", "Exact Phrase"));
            cboOperator.Properties.Items.Add(new TabItem("LIKE", "Any of words"));
            cboOperator.Properties.Items.Add(new TabItem("START", "Start of words"));

        }
        private void setBoolOperator()
        {
            cboOperator.Properties.Items.Clear();
            cboOperator.Properties.Items.Add(new TabItem("=", "="));
            cboOperator.Properties.Items.Add(new TabItem("<>", "<>"));
        }
        private void SetOperator()
        {
            TabItem item = (TabItem)cboField.SelectedItem;
            cboOperator.Text = "";
            cboOperator.Properties.Items.Clear();
    
            cboValue.Properties.Items.Clear();
            if (item.ItemID == strBoolean)
            {
                setBoolOperator();
                cboValue.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;                
                cboValue.Properties.Items.Add("TRUE");
                cboValue.Properties.Items.Add("FALSE");
            }
            else if (item.ItemID == strInt32)
            {
                setNumberOperator();
                cboValue.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                cboValue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

            }
            else if (item.ItemID == strDateTime)
            {
                setNumberOperator();
                cboValue.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                cboValue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
                cboValue.Properties.Mask.Culture = Globals.getCulture();

            } 
            else if (item.ItemID == strString)
            {
                setStringOperator();
                cboValue.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            }
        }
        private const string strInt32 = "Int32";
        private const string strBoolean = "Boolean";
        private const string strString = "String";
        private const string strDateTime = "DateTime";
        private bool isModified = false;
        public void setTable(string tabName)
        {
            try
            {
                Data_Access.DoSqlCommand("SELECT * FROM " + tabName + " WHERE 1 = 2");
                DataTable table = Data_Access.GetDataSet().Tables[0];
                cboField.Properties.Items.Clear();
                //table.Columns[0]
                foreach (DataColumn cl in table.Columns)
                {
                    string s = cl.Caption.ToUpper().Trim();
                    string dataType = cl.DataType.Name;
                    if (dataType == strInt32 || dataType == strString || 
                        dataType == strBoolean || dataType == strDateTime)
                    {                        
                        cboField.Properties.Items.Add(new TabItem(dataType, cl.Caption));
                        
                        //cboField.Properties.Items.Add(new TabItem(cl.Caption, cl.DataType.Name));
                    }
                }
            }
            catch (Exception) { }
        }
        private void Search_Load(object sender, EventArgs e)
        {
            LoadData();
            //setTable("VListCustomers");
        }

        private void cboField_SelectedValueChanged(object sender, EventArgs e)
        {
            SetOperator();
        }

        private void memoEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (memoStatement.Text.Trim() != "")
            {
                cboCombination.Enabled = true;
                btnAddStatement.Enabled = true;
                btnClear.Enabled = true;
            }
            else
            {
                cboCombination.Enabled = false;
                btnAddStatement.Enabled = false;
                btnClear.Enabled = false;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (check())
                MakeSentent();
         
        }
        private bool check()
        {
            if (cboField.Text == "")
            {
                MessageBox.Show(this, "Field cannot null", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboField.Focus();
                return false;
            }
            if (cboOperator.Text == "")
            {
                MessageBox.Show(this, "Operator cannot null", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboOperator.Focus();
                return false;
            }
            if (cboValue.Text == "")
            {
                MessageBox.Show(this, "Value cannot null", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboValue.Focus();
                return false;
            }

            if (memoStatement.Text.Trim() != "")
            {
                if (cboCombination.Text == "")
                {
                    MessageBox.Show(this, "Combination cannot null", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboCombination.Focus();
                    return false;
                }

            }
            return true;

        }
        private void MakeSentent()
        {
               TabItem item = (TabItem)cboField.SelectedItem;
               string value = cboValue.Text.Trim();
               TabItem oper = (TabItem)cboOperator.SelectedItem;
               
               string stat = "";
               if (item.ItemID == strString)
               {
                   // them cac dau nhay

                   if (!value.StartsWith("'")) value = "'" + value;
                   if (!value.EndsWith("'")) value += "'";
                   
                   if (oper.ItemID == "=")
                       stat = "[" + cboField.Text + "] = " + value;
                   else if (oper.ItemID == "LIKE")
                        //stat = "CharIndex(" + value + ", [" + cboField.Text + "]) > 0";
                       stat = "[" + cboField.Text + "] LIKE " + value.Insert(value.Length - 1, "%").Insert(1, "%");
                    else if (oper.ItemID == "START")
                    {

                        stat = "[" + cboField.Text + "] LIKE " + value.Insert(value.Length - 1, "%");
                    }
               }
               else if (item.ItemID == strBoolean)
               {
                   stat = "[" + item.ItemName + "] " + oper.ItemName + " " + value;
               }
               else if (item.ItemID == strInt32)
               {
                   stat = "[" + item.ItemName + "] " + oper.ItemName + " " + value;
               }
               else if (item.ItemID == strDateTime)
               {
                   stat = "[" + item.ItemName + "] " + oper.ItemName + " '" + value + "'";
               } 
            if (memoStatement.Text.Trim() != "")
               memoStatement.Text += " " + cboCombination.Text + " " + stat;
            else
               memoStatement.Text = stat;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            memoStatement.Properties.ReadOnly = false;
            memoStatement.SelectAll();
            memoStatement.Focus();
        }
        private TabItem currentItem = null;
        private void btnAddStatement_Click(object sender, EventArgs e)
        {
            currentItem = new TabItem("", memoStatement.Text);
            lstStatements.Items.Add(currentItem);
            SetModified(true);            
        }

        private void lstStatements_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lstStatements_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (currentItem != null)
            {
                currentItem.ItemName = memoStatement.Text;
                memoStatement.Properties.ReadOnly = true;
            }
            
            currentItem = (TabItem)lstStatements.SelectedItem;
            if (currentItem != null)
                memoStatement.Text = currentItem.ItemName;
        }

        private void memoStatement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                deleteItem();
            

        }
        private void SetModified(bool status)
        {
            isModified = status;
            btnSave.Enabled = status;
        }
        private void deleteItem()
        {
            if (lstStatements.SelectedItem != null)
            {
                lstStatements.Items.Remove(lstStatements.SelectedItem);
                SetModified(true);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteItem();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            SetModified(false);
        }
        private void SaveData()
        {
            try
            {
                FileStream fs = new FileStream("search.cfg", FileMode.Create);
                StreamWriter wt = new StreamWriter(fs);
                foreach (TabItem item in lstStatements.Items)
                {
                    wt.WriteLine(item.ItemName);
                }
                wt.Close();
                fs.Close();
            }
            catch (Exception) { }
        }
        private void LoadData()
        {
            try
            {
                FileStream fs = new FileStream("search.cfg", FileMode.Open);
                StreamReader rd = new StreamReader(fs);
                while (!rd.EndOfStream)
                {
                    lstStatements.Items.Add(new TabItem("", rd.ReadLine()));
                }
                rd.Close();
                fs.Close();
            }
            catch (Exception) { }
        }
        public string getSearchStr()
        {
            return memoStatement.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {            
            if (checkSave())
                this.Close();
            this.DialogResult = DialogResult.Cancel;
        }
        private bool checkSave()
        {
            if (isModified)
            {
                DialogResult result = MessageBox.Show(this, "Do you want to save?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Cancel) return false;
                else if (result == DialogResult.Yes)                    
                    SaveData();
            }
            return true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
         if (checkSave())
                this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            memoStatement.Text = "";
        }

        private void cboValue_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            string s = e.NewValue.ToString();
            if ((s.IndexOf("'") >= 0) || (s.IndexOf("%") >= 0) || (s.IndexOf("_") >= 0)) e.Cancel = true;
        }
    }
}


