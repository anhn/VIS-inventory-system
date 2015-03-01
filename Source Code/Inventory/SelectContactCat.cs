using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;
using System.Data.SqlClient;


using DevExpress.XtraEditors.Controls;


namespace Inventory
{
    /// <summary>
    /// Summary description for SelectContactCat.
    /// </summary>
    public class SelectContactCat : DevExpress.XtraEditors.XtraForm
    {
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private TextEdit txtCatName;
        private PanelControl panelControl1;
        private MemoEdit mmoDescription;
        private Label lblDescription;
        private Label lblCatName;
        private PanelControl panelControl2;
        private ListBoxControl lbcSelectedValues;
        private Label lblAvailableValues;
        private CheckedListBoxControl clbAvailableValues;
        private Label lblSelectedValues;
        private SimpleButton btnOK;
        private SimpleButton btnCancel;
        private SimpleButton btnEdit;
        private IContainer components;

        private SqlConnection cnContactMgmt = null;
        private DataTable dtSelectedCategory = null;
        private string strContactID;

        public SelectContactCat(DataTable dtCategory, string strID)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            dtSelectedCategory = dtCategory;
            strContactID = strID;
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
            this.txtCatName = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.mmoDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCatName = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lblSelectedValues = new System.Windows.Forms.Label();
            this.lbcSelectedValues = new DevExpress.XtraEditors.ListBoxControl();
            this.lblAvailableValues = new System.Windows.Forms.Label();
            this.clbAvailableValues = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtCatName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmoDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbcSelectedValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clbAvailableValues)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.defaultLookAndFeel1.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // txtCatName
            // 
            this.txtCatName.EditValue = "Dealer";
            this.txtCatName.Enabled = false;
            this.txtCatName.Location = new System.Drawing.Point(119, 11);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(254, 21);
            this.txtCatName.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.mmoDescription);
            this.panelControl1.Controls.Add(this.lblDescription);
            this.panelControl1.Controls.Add(this.lblCatName);
            this.panelControl1.Controls.Add(this.txtCatName);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(393, 107);
            this.panelControl1.TabIndex = 1;
            this.panelControl1.Text = "panelControl1";
            // 
            // mmoDescription
            // 
            this.mmoDescription.Enabled = false;
            this.mmoDescription.Location = new System.Drawing.Point(119, 38);
            this.mmoDescription.Name = "mmoDescription";
            this.mmoDescription.Size = new System.Drawing.Size(254, 58);
            this.mmoDescription.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(18, 38);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(71, 14);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(18, 14);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(95, 14);
            this.lblCatName.TabIndex = 1;
            this.lblCatName.Text = "Category Name:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.lblSelectedValues);
            this.panelControl2.Controls.Add(this.lbcSelectedValues);
            this.panelControl2.Controls.Add(this.lblAvailableValues);
            this.panelControl2.Controls.Add(this.clbAvailableValues);
            this.panelControl2.Location = new System.Drawing.Point(12, 125);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(393, 227);
            this.panelControl2.TabIndex = 4;
            this.panelControl2.Text = "panelControl2";
            // 
            // lblSelectedValues
            // 
            this.lblSelectedValues.AutoSize = true;
            this.lblSelectedValues.Location = new System.Drawing.Point(202, 7);
            this.lblSelectedValues.Name = "lblSelectedValues";
            this.lblSelectedValues.Size = new System.Drawing.Size(98, 14);
            this.lblSelectedValues.TabIndex = 7;
            this.lblSelectedValues.Text = "Selected Values:";
            // 
            // lbcSelectedValues
            // 
            this.lbcSelectedValues.Enabled = false;
            this.lbcSelectedValues.Location = new System.Drawing.Point(205, 24);
            this.lbcSelectedValues.Name = "lbcSelectedValues";
            this.lbcSelectedValues.Size = new System.Drawing.Size(168, 188);
            this.lbcSelectedValues.TabIndex = 8;
            // 
            // lblAvailableValues
            // 
            this.lblAvailableValues.AutoSize = true;
            this.lblAvailableValues.Location = new System.Drawing.Point(18, 7);
            this.lblAvailableValues.Name = "lblAvailableValues";
            this.lblAvailableValues.Size = new System.Drawing.Size(96, 14);
            this.lblAvailableValues.TabIndex = 5;
            this.lblAvailableValues.Text = "Available Values:";
            // 
            // clbAvailableValues
            // 
            this.clbAvailableValues.CheckOnClick = true;
            this.clbAvailableValues.Location = new System.Drawing.Point(21, 24);
            this.clbAvailableValues.Name = "clbAvailableValues";
            this.clbAvailableValues.Size = new System.Drawing.Size(160, 188);
            this.clbAvailableValues.TabIndex = 6;
            this.clbAvailableValues.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.clbAvailableValues_ItemCheck);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(249, 358);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(330, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(168, 358);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "E&dit...";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // SelectContactCat
            // 
            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(422, 386);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectContactCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Values for Category";
            this.Load += new System.EventHandler(this.SelectContactCat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCatName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmoDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbcSelectedValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clbAvailableValues)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if (Globals.CheckAccessRights(Globals.UserID,"126E6E1B-47A0-4F6F-A5B3-F135097365DE",true))
            //{

                AddEditContactCategoy frmContactCat = new AddEditContactCategoy();
                frmContactCat.ShowDialog();
                RefreshData();
            //}
        }

        private void SelectContactCat_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            // Create and Initalize the SQL Connection
            cnContactMgmt = new SqlConnection(Globals.strVISConnection);

            // Create SQL Statement
            string sSQL = "SELECT ContactCatID, ContactCatName FROM CategoryInContact";

            //Create SQL Command
            SqlCommand sCommand = new SqlCommand(sSQL, cnContactMgmt);

            DataTable dtCategory = new DataTable();

            if (cnContactMgmt.State == ConnectionState.Closed)
                cnContactMgmt.Open();

            SqlDataAdapter daCategory = new SqlDataAdapter(sSQL, cnContactMgmt);
            daCategory.Fill(dtCategory);

            clbAvailableValues.DataSource = dtCategory;
            clbAvailableValues.DisplayMember = "ContactCatName";
            clbAvailableValues.ValueMember = "ContactCatID";

            ListSelectedCategory();
        }

        //Check the selected category in the CheckedListBox
        private void ListSelectedCategory()
        {
            //int a = clbAvailableValues.FindItem(new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Customer"));
            foreach (DataRow datarow in dtSelectedCategory.Rows)
            {
                for (int i = 0; i < clbAvailableValues.ItemCount;i++)
                {
                    if (datarow["ContactCatID"].ToString() == clbAvailableValues.GetItemValue(i).ToString())
                    {
                        clbAvailableValues.SetItemChecked(i, true);
                        break;
                    }
                }
            }
        }

        //Add or remove the selected item to the Listbox
        private void clbAvailableValues_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (e.State == CheckState.Checked)
                lbcSelectedValues.Items.Add(clbAvailableValues.GetItemText(e.Index));                   
            else
                lbcSelectedValues.Items.Remove(clbAvailableValues.GetItemText(e.Index));

            txtCatName.Text = clbAvailableValues.GetItemText(e.Index);
            mmoDescription.Text = getCategoryDescription(clbAvailableValues.GetItemValue(e.Index).ToString());
        }

        public DataTable getCheckedItems()
        {

            dtSelectedCategory.Clear();

            for (int i = 0; i < clbAvailableValues.ItemCount;i++)
            {
                if (clbAvailableValues.GetItemChecked(i))
                {
                    dtSelectedCategory.Rows.Add(new object[] {  strContactID, clbAvailableValues.GetItemValue(i), clbAvailableValues.GetDisplayItemValue(i) });
                }
            }

            return dtSelectedCategory;

        }

        private string getCategoryDescription(string ContactCatID)
        {
            SqlDataReader reader = null;
            string catDescription = string.Empty;

            try
            {
                if (cnContactMgmt.State == ConnectionState.Closed)
                    cnContactMgmt.Open();

                // Create SQL Statement
                string sSQL = "SELECT Notes FROM CategoryInContact WHERE ContactCatID = '" + ContactCatID + "'";

                //Create SQL Command
                SqlCommand sCommand = new SqlCommand(sSQL, cnContactMgmt);

                reader = sCommand.ExecuteReader(CommandBehavior.CloseConnection);

                reader.Read();

                catDescription = reader["Notes"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                if (reader != null)
                    reader.Close();

            }
            return catDescription;
        }

    }
}

