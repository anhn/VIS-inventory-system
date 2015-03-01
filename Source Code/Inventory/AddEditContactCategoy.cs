using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Data;
using System.Data.SqlClient;
using System.Data;


namespace Inventory
{
    /// <summary>
    /// Summary description for ContactCategoy.
    /// </summary>
    public class AddEditContactCategoy : DevExpress.XtraEditors.XtraForm
    {
        private PanelControl panelControl1;
        private Label lblNotes;
        private TextEdit txtContactCatName;
        private MemoEdit mmoDescription;
        private Label lblContactCatName;
        private DataNavigator dnCategory;
        private SimpleButton btnCancel;
        private Label label1;
        private RadioGroup rdoViewStatus;
        private TextEdit txtContactCatId;
        private SimpleButton btnDelete;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public AddEditContactCategoy()
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoViewStatus = new DevExpress.XtraEditors.RadioGroup();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtContactCatName = new DevExpress.XtraEditors.TextEdit();
            this.lblContactCatName = new System.Windows.Forms.Label();
            this.mmoDescription = new DevExpress.XtraEditors.MemoEdit();
            this.txtContactCatId = new DevExpress.XtraEditors.TextEdit();
            this.dnCategory = new DevExpress.XtraEditors.DataNavigator();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdoViewStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactCatName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactCatId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.rdoViewStatus);
            this.panelControl1.Controls.Add(this.lblNotes);
            this.panelControl1.Controls.Add(this.txtContactCatName);
            this.panelControl1.Controls.Add(this.lblContactCatName);
            this.panelControl1.Controls.Add(this.mmoDescription);
            this.panelControl1.Controls.Add(this.txtContactCatId);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(333, 138);
            this.panelControl1.TabIndex = 3;
            this.panelControl1.Text = "panelControl1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "View Status";
            // 
            // rdoViewStatus
            // 
            this.rdoViewStatus.EditValue = true;
            this.rdoViewStatus.Location = new System.Drawing.Point(109, 96);
            this.rdoViewStatus.Name = "rdoViewStatus";
            this.rdoViewStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Enable"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Disable")});
            this.rdoViewStatus.Size = new System.Drawing.Size(207, 28);
            this.rdoViewStatus.TabIndex = 59;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(4, 38);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(64, 13);
            this.lblNotes.TabIndex = 3;
            this.lblNotes.Text = "Description:";
            // 
            // txtContactCatName
            // 
            this.txtContactCatName.Location = new System.Drawing.Point(109, 10);
            this.txtContactCatName.Name = "txtContactCatName";
            this.txtContactCatName.Size = new System.Drawing.Size(207, 22);
            this.txtContactCatName.TabIndex = 2;
            // 
            // lblContactCatName
            // 
            this.lblContactCatName.AutoSize = true;
            this.lblContactCatName.Location = new System.Drawing.Point(4, 12);
            this.lblContactCatName.Name = "lblContactCatName";
            this.lblContactCatName.Size = new System.Drawing.Size(86, 13);
            this.lblContactCatName.TabIndex = 1;
            this.lblContactCatName.Text = "Category Name:";
            // 
            // mmoDescription
            // 
            this.mmoDescription.Location = new System.Drawing.Point(109, 37);
            this.mmoDescription.Name = "mmoDescription";
            this.mmoDescription.Size = new System.Drawing.Size(207, 53);
            this.mmoDescription.TabIndex = 4;
            // 
            // txtContactCatId
            // 
            this.txtContactCatId.Location = new System.Drawing.Point(149, 59);
            this.txtContactCatId.Name = "txtContactCatId";
            this.txtContactCatId.Size = new System.Drawing.Size(107, 22);
            this.txtContactCatId.TabIndex = 61;
            // 
            // dnCategory
            // 
            this.dnCategory.Buttons.Append.Hint = "Add record";
            this.dnCategory.Buttons.CancelEdit.Hint = "Cancel Edit";
            this.dnCategory.Buttons.EndEdit.Hint = "Save";
            this.dnCategory.Buttons.First.Hint = "Go to the first record";
            this.dnCategory.Buttons.Last.Hint = "Go to the last record";
            this.dnCategory.Buttons.Next.Hint = "Go to the next record";
            this.dnCategory.Buttons.NextPage.Visible = false;
            this.dnCategory.Buttons.Prev.Hint = "Go to the previous record";
            this.dnCategory.Buttons.PrevPage.Visible = false;
            this.dnCategory.Buttons.Remove.Hint = "Delete record";
            this.dnCategory.Buttons.Remove.Visible = false;
            this.dnCategory.Location = new System.Drawing.Point(12, 156);
            this.dnCategory.Name = "dnCategory";
            this.dnCategory.ShowToolTips = true;
            this.dnCategory.Size = new System.Drawing.Size(213, 24);
            this.dnCategory.TabIndex = 5;
            this.dnCategory.Text = "dataNavigator1";
            this.dnCategory.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.dnCategory.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this.dnCategory.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.dnCategory_ButtonClick);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(286, 157);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Close";
            this.btnCancel.ToolTip = "Close";
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(235, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.ToolTip = "Delete this record";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AddEditContactCategoy
            // 
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(360, 190);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dnCategory);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditContactCategoy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Contact List Category";
            this.Shown += new System.EventHandler(this.AddEditContactCategoy_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditContactCategoy_FormClosing);
            this.Load += new System.EventHandler(this.ContactCategoy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdoViewStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactCatName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactCatId.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ContactCategoy_Load(object sender, EventArgs e)
        {
            /*
            if (LoginUser.strLoginGroup == "Administrator")
                rdoViewStatus.Enabled = true;
            else
             */
                rdoViewStatus.Enabled = false;
        }
        //Written by Cong
        //Date: 04/03/2007
        private DataTable tblContactCat;
        private SqlDataAdapter sqlAdapter;
        private SqlConnection sqlCon;
        private void AddEditContactCategoy_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                sqlCon.Close();
                sqlCon.Open();
                //Create command for update
                SqlCommandBuilder cmd = new SqlCommandBuilder(sqlAdapter);
                //Update all changes to database
                sqlAdapter.Update(tblContactCat);
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error when saving data");
            }    
        }

        private void AddEditContactCategoy_Shown(object sender, EventArgs e)
        {
            try
            {
                //Create DataTable for Bindings
                tblContactCat = new DataTable();

                //Create a Connection to database
                sqlCon = new SqlConnection(Globals.strVISConnection);

                //Open connection
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                //Create a Adapter
                sqlAdapter = new SqlDataAdapter("SELECT * FROM CategoryInContact", sqlCon);

                //Fill to table
                sqlAdapter.Fill(tblContactCat);
                //Set the datasource to DataNavigator
                dnCategory.DataSource = tblContactCat;
                //Binding data to control
                txtContactCatName.DataBindings.Add("Text", tblContactCat, "ContactCatName");
                mmoDescription.DataBindings.Add("Text", tblContactCat, "Notes");
                txtContactCatId.DataBindings.Add("Text", tblContactCat, "ContactCatId");
                rdoViewStatus.DataBindings.Add("EditValue", tblContactCat, "ViewStatus");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error when read data");
            }
        }

        private void dnCategory_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.EndEdit)
            {
                if (txtContactCatId.Text.Trim().Length == 0)
                {
                    txtContactCatId.Text = Guid.NewGuid().ToString();
                }
                MessageBox.Show("Record is saved");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (Globals.CheckAccessRights(Globals.UserID,"708628A5-4B47-45A4-84AA-2D45A71EDDAB",true))
            //{

                if (MessageBox.Show("This record and all related records will be deleted! Are you sure?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //remove from table
                    try
                    {
                        foreach (DataRow row in tblContactCat.Rows)
                        {
                            if (row["ContactCatID"].ToString() == txtContactCatId.Text)
                            {
                                //remove from table
                                DeleteSQL del = new DeleteSQL(new SqlConnection(Globals.strVISConnection));
                                del.deleteCategory(txtContactCatId.Text);
                                tblContactCat.Rows.Remove(row);
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            //}
        }

        //End Cong
    }
}

