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
    /// Summary description for AddEditMr.
    /// </summary>
    public class AddEditMr : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton btnCancel;
        private DataNavigator dnSaluation;
        private PanelControl panelControl1;
        private Label lblDescription;
        private TextEdit txtName;
        private Label lblName;
        private string Name;
        private SimpleButton btnDelete;
        private MemoEdit mmoDescription;
        private TextEdit txtMrID;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public AddEditMr()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        public AddEditMr(string name)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            Name = name;
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
            this.dnSaluation = new DevExpress.XtraEditors.DataNavigator();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.mmoDescription = new DevExpress.XtraEditors.MemoEdit();
            this.txtMrID = new DevExpress.XtraEditors.TextEdit();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmoDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMrID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(293, 119);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(52, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Close";
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
            this.dnSaluation.Location = new System.Drawing.Point(12, 118);
            this.dnSaluation.Name = "dnSaluation";
            this.dnSaluation.ShowToolTips = true;
            this.dnSaluation.Size = new System.Drawing.Size(214, 24);
            this.dnSaluation.TabIndex = 3;
            this.dnSaluation.Text = "dataNavigator1";
            this.dnSaluation.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.dnSaluation.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.dnSaluation_ButtonClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.mmoDescription);
            this.panelControl1.Controls.Add(this.txtMrID);
            this.panelControl1.Controls.Add(this.lblDescription);
            this.panelControl1.Controls.Add(this.txtName);
            this.panelControl1.Controls.Add(this.lblName);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(333, 100);
            this.panelControl1.TabIndex = 7;
            this.panelControl1.Text = "panelControl1";
            // 
            // mmoDescription
            // 
            this.mmoDescription.Location = new System.Drawing.Point(109, 36);
            this.mmoDescription.Name = "mmoDescription";
            this.mmoDescription.Size = new System.Drawing.Size(207, 53);
            this.mmoDescription.TabIndex = 2;
            // 
            // txtMrID
            // 
            this.txtMrID.Location = new System.Drawing.Point(185, 51);
            this.txtMrID.Name = "txtMrID";
            this.txtMrID.Size = new System.Drawing.Size(80, 20);
            this.txtMrID.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 36);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(64, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
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
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(236, 119);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(46, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AddEditMr
            // 
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(358, 151);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dnSaluation);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditMr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Mr";
            this.Shown += new System.EventHandler(this.AddEditMr_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditMr_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmoDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMrID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        //Writen by Cong
        //Date: 03/03/2007
        private DataTable tblMr;
        private SqlDataAdapter sqlAdapter;
        private DataSet dSet;
        private SqlConnection sqlCon;

        private void AddEditMr_Shown(object sender, EventArgs e)
        {
            try
            {
                //Create DataTable for Bindings
                tblMr = new DataTable();

                //Create a Connection to database
                sqlCon = new SqlConnection(Globals.strVISConnection);

                //Open connection
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                //Create a Adapter
                sqlAdapter = new SqlDataAdapter("SELECT * FROM Mr", sqlCon);

                dSet = new DataSet();
                //Fill to table
                sqlAdapter.Fill(dSet, "Mr");
                //Set the datasource to DataNavigator
                tblMr = dSet.Tables[0];
                dnSaluation.DataSource = tblMr;
                //Binding data to control
                txtName.DataBindings.Add("Text", tblMr, "MrName");
                txtMrID.DataBindings.Add("Text", tblMr, "MrID");
                mmoDescription.DataBindings.Add("Text", tblMr, "Notes");
                if (Name != null)
                {
                    for (int i = 0; i < tblMr.Rows.Count; i++)
                    {
                        if (tblMr.Rows[i]["MrName"].ToString() == Name)
                        {
                            dnSaluation.Position = i;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error when read data");
            }
        }

        private void AddEditMr_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                sqlCon.Close();
                sqlCon.Open();
                //Create command for update
                SqlCommandBuilder cmd = new SqlCommandBuilder(sqlAdapter);
                //Update all changes to database
                sqlAdapter.Update(dSet, "Mr");
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error when saving data");
            }            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (Globals.CheckAccessRights(Globals.UserID,"1F8F74F7-364C-4AF3-8244-483B5C6A5934",true))
            //{

                if (MessageBox.Show("This record will be deleted! Are you sure?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        foreach (DataRow row in tblMr.Rows)
                        {
                            if (row["MrID"].ToString() == txtMrID.Text)
                            {
                                //remove from table
                                DeleteSQL del = new DeleteSQL(new SqlConnection(Globals.strVISConnection));
                                del.deleteMr(txtMrID.Text);
                                tblMr.Rows.Remove(row);
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

        private void dnSaluation_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.EndEdit)
            {
                if (txtMrID.Text.Trim().Length == 0)
                {
                    txtMrID.Text = Guid.NewGuid().ToString();
                }
                MessageBox.Show("Record is saved");
            }
        }
        
    }
}

