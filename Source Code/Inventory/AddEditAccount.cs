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
    /// Summary description for .
    /// </summary>
    public class AddEditAccount : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton btnCancel;
        private PanelControl panelControl1;
        private Label lblNotes;
        private TextEdit txtName;
        private Label lblName;
        private string ContactID = "";
        private string ID;
        private SimpleButton btnDelete;
        private TextEdit txtContactID;
        private RadioGroup rdoViewStatus;
        private TextEdit txtAccountNo;
        private Label label1;
        private Label lblViewStatus;
        private DataNavigator dnSaluation;
        private MemoEdit mmoNotes;
        private TextEdit txtID;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public AddEditAccount()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        public AddEditAccount(string contactID,string id)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            ContactID = contactID;
            ID = id;
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.mmoNotes = new DevExpress.XtraEditors.MemoEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.txtAccountNo = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.lblViewStatus = new System.Windows.Forms.Label();
            this.rdoViewStatus = new DevExpress.XtraEditors.RadioGroup();
            this.txtContactID = new DevExpress.XtraEditors.TextEdit();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.dnSaluation = new DevExpress.XtraEditors.DataNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmoNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoViewStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(290, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Close";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.mmoNotes);
            this.panelControl1.Controls.Add(this.txtID);
            this.panelControl1.Controls.Add(this.txtAccountNo);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.lblViewStatus);
            this.panelControl1.Controls.Add(this.rdoViewStatus);
            this.panelControl1.Controls.Add(this.txtContactID);
            this.panelControl1.Controls.Add(this.lblNotes);
            this.panelControl1.Controls.Add(this.txtName);
            this.panelControl1.Controls.Add(this.lblName);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(333, 202);
            this.panelControl1.TabIndex = 7;
            this.panelControl1.Text = "panelControl1";
            // 
            // mmoNotes
            // 
            this.mmoNotes.Location = new System.Drawing.Point(109, 78);
            this.mmoNotes.Name = "mmoNotes";
            this.mmoNotes.Size = new System.Drawing.Size(207, 53);
            this.mmoNotes.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(165, 94);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 56;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(109, 44);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(207, 20);
            this.txtAccountNo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Account No:";
            // 
            // lblViewStatus
            // 
            this.lblViewStatus.AutoSize = true;
            this.lblViewStatus.Location = new System.Drawing.Point(6, 159);
            this.lblViewStatus.Name = "lblViewStatus";
            this.lblViewStatus.Size = new System.Drawing.Size(67, 13);
            this.lblViewStatus.TabIndex = 54;
            this.lblViewStatus.Text = "View Status:";
            // 
            // rdoViewStatus
            // 
            this.rdoViewStatus.EditValue = true;
            this.rdoViewStatus.Location = new System.Drawing.Point(109, 156);
            this.rdoViewStatus.Name = "rdoViewStatus";
            this.rdoViewStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Enable"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Disable")});
            this.rdoViewStatus.Size = new System.Drawing.Size(207, 28);
            this.rdoViewStatus.TabIndex = 4;
            // 
            // txtContactID
            // 
            this.txtContactID.Location = new System.Drawing.Point(185, 94);
            this.txtContactID.Name = "txtContactID";
            this.txtContactID.Size = new System.Drawing.Size(80, 20);
            this.txtContactID.TabIndex = 4;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(6, 78);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(39, 13);
            this.lblNotes.TabIndex = 3;
            this.lblNotes.Text = "Notes:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Account Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(240, 220);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Tag = "";
            this.btnDelete.Text = "&Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dnSaluation
            // 
            this.dnSaluation.Buttons.Append.Hint = "Add record";
            this.dnSaluation.Buttons.CancelEdit.Hint = "Cancel Edit";
            this.dnSaluation.Buttons.EndEdit.Hint = "Save";
            this.dnSaluation.Buttons.First.Hint = "Go to the first record";
            this.dnSaluation.Buttons.Last.Hint = "Go to the last record";
            this.dnSaluation.Buttons.Next.Hint = "Go to the next record";
            this.dnSaluation.Buttons.NextPage.Visible = false;
            this.dnSaluation.Buttons.Prev.Hint = "Go to the previous record";
            this.dnSaluation.Buttons.PrevPage.Visible = false;
            this.dnSaluation.Buttons.Remove.Visible = false;
            this.dnSaluation.Location = new System.Drawing.Point(12, 220);
            this.dnSaluation.Name = "dnSaluation";
            this.dnSaluation.ShowToolTips = true;
            this.dnSaluation.Size = new System.Drawing.Size(214, 24);
            this.dnSaluation.TabIndex = 5;
            this.dnSaluation.Text = "dataNavigator1";
            this.dnSaluation.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.dnSaluation.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.dnSaluation_ButtonClick);
            // 
            // AddEditAccount
            // 
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(358, 256);
            this.Controls.Add(this.dnSaluation);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Account";
            this.Shown += new System.EventHandler(this.AddEditAccount_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditAccount_FormClosing);
            this.Load += new System.EventHandler(this.AddEditAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmoNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoViewStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private DataTable tblAccount;
        private SqlDataAdapter sqlAdapter;
        private SqlConnection sqlCon;

        private void AddEditAccount_Shown(object sender, EventArgs e)
        {
            try
            {
                //Create DataTable for Bindings
                tblAccount = new DataTable();

                //Create a Connection to database
                sqlCon = new SqlConnection(Globals.strVISConnection);

                //Open connection
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                //Create a Adapter
                sqlAdapter = new SqlDataAdapter("SELECT * FROM ContactBankAccount WHERE ContactID = '"+ContactID+"'", sqlCon);

                sqlAdapter.Fill(tblAccount);
                dnSaluation.DataSource = tblAccount;
                txtID.DataBindings.Add("Text", tblAccount, "ID");
                txtContactID.DataBindings.Add("Text", tblAccount, "ContactID");
                txtName.DataBindings.Add("Text", tblAccount, "AccountName");
                txtAccountNo.DataBindings.Add("Text", tblAccount, "AccountNo");
                mmoNotes.DataBindings.Add("Text", tblAccount, "Notes");
                rdoViewStatus.DataBindings.Add("EditValue", tblAccount, "ViewStatus");
                if (ID != null)
                {
                    for (int i = 0; i < tblAccount.Rows.Count; i++)
                    {
                        if (tblAccount.Rows[i]["ID"].ToString() == ID)
                        {
                            dnSaluation.Position = i;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Globals.CheckAccessRights(Globals.UserID,"6E4A61DE-2D14-40E7-9DF2-3599144369C0",true))
            {

                if (MessageBox.Show("This record will be deleted! Are you sure?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {

                        DeleteSQL del = new DeleteSQL(new SqlConnection(Globals.strVISConnection));
                        del.deleteContactBankAccount(txtID.Text);
                        tblAccount.Rows.RemoveAt(dnSaluation.Position);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void AddEditAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                sqlCon.Close();
                sqlCon.Open();
                //Create command for update
                SqlCommandBuilder cmd = new SqlCommandBuilder(sqlAdapter);
                //Update all changes to database                
                sqlAdapter.Update(tblAccount);
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }    
        }

        private void dnSaluation_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.EndEdit)
            {
                if (txtContactID.Text.Trim().Length == 0)
                    txtContactID.Text = ContactID;
                if (txtID.Text.Trim().Length == 0)
                    txtID.Text = Guid.NewGuid().ToString();

                MessageBox.Show("Record is saved");
            }
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                if (txtContactID.Text.Trim().Length == 0)
                    txtContactID.Text = ContactID;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void AddEditAccount_Load(object sender, EventArgs e)
        {
            /*
            if (LoginUser.strLoginGroup == "Administrator")
                rdoViewStatus.Enabled = true;
            else
             */
                rdoViewStatus.Enabled = true;
        }


    }
}

