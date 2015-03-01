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
    public class AddEditTaxType : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton btnCancel;
        private DataNavigator dnSaluation;
        private PanelControl panelControl1;
        private Label lblDescription;
        private TextEdit txtName;
        private Label lblName;
        private string Name;
        private SimpleButton btnDelete;
        private MemoEdit mmoNote;
        private TextEdit txtTaxTypeID;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public AddEditTaxType()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        public AddEditTaxType(string name)
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
            this.mmoNote = new DevExpress.XtraEditors.MemoEdit();
            this.txtTaxTypeID = new DevExpress.XtraEditors.TextEdit();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmoNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxTypeID.Properties)).BeginInit();
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
            this.dnSaluation.Size = new System.Drawing.Size(225, 24);
            this.dnSaluation.TabIndex = 3;
            this.dnSaluation.Text = "dataNavigator1";
            this.dnSaluation.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.dnSaluation.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.dnSaluation_ButtonClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.mmoNote);
            this.panelControl1.Controls.Add(this.txtTaxTypeID);
            this.panelControl1.Controls.Add(this.lblDescription);
            this.panelControl1.Controls.Add(this.txtName);
            this.panelControl1.Controls.Add(this.lblName);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(333, 100);
            this.panelControl1.TabIndex = 7;
            this.panelControl1.Text = "panelControl1";
            // 
            // mmoNote
            // 
            this.mmoNote.Location = new System.Drawing.Point(109, 36);
            this.mmoNote.Name = "mmoNote";
            this.mmoNote.Size = new System.Drawing.Size(207, 53);
            this.mmoNote.TabIndex = 2;
            // 
            // txtTaxTypeID
            // 
            this.txtTaxTypeID.Location = new System.Drawing.Point(185, 51);
            this.txtTaxTypeID.Name = "txtTaxTypeID";
            this.txtTaxTypeID.Size = new System.Drawing.Size(80, 21);
            this.txtTaxTypeID.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(4, 34);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(38, 14);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Note:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 21);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(4, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 14);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(243, 119);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(46, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AddEditTaxType
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
            this.Name = "AddEditTaxType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/EditTaxType";
            this.Shown += new System.EventHandler(this.AddEditTaxType_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditTaxType_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmoNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion


        private DataTable tblTaxType;
        private SqlDataAdapter sqlAdapter;
        private DataSet dSet;
        private SqlConnection sqlCon;

        private void AddEditTaxType_Shown(object sender, EventArgs e)
        {
            try
            {
                //Create DataTable for Bindings
                tblTaxType = new DataTable();

                //Create a Connection to database
                sqlCon = new SqlConnection(Globals.strVISConnection);

                //Open connection
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                //Create a Adapter
                sqlAdapter = new SqlDataAdapter("SELECT * FROM TaxType", sqlCon);

                dSet = new DataSet();
                //Fill to table
                sqlAdapter.Fill(dSet, "TaxType");
                //Set the datasource to DataNavigator
                tblTaxType = dSet.Tables[0];
                dnSaluation.DataSource = tblTaxType;
                //Binding data to control
                txtName.DataBindings.Add("Text", tblTaxType, "TaxTypeName");
                txtTaxTypeID.DataBindings.Add("Text", tblTaxType, "TaxTypeID");
                mmoNote.DataBindings.Add("Text", tblTaxType, "Note");
                if (Name != null)
                {
                    for (int i = 0; i < tblTaxType.Rows.Count; i++)
                    {
                        if (tblTaxType.Rows[i]["TaxTypeName"].ToString() == Name)
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

        private void AddEditTaxType_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                sqlCon.Close();
                sqlCon.Open();
                //Create command for update
                SqlCommandBuilder cmd = new SqlCommandBuilder(sqlAdapter);
                //Update all changes to database
                sqlAdapter.Update(dSet, "TaxType");
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error when saving data");
            }            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("This record and all related records will be deleted! Are you sure?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    foreach (DataRow row in tblTaxType.Rows)
                    {
                        if (row["TaxTypeID"].ToString() == txtTaxTypeID.Text)
                        {
                            //remove from table
                            DeleteSQL del = new DeleteSQL(new SqlConnection(Globals.strVISConnection));
                            del.deleteTaxType(txtTaxTypeID.Text);
                            tblTaxType.Rows.Remove(row);
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void dnSaluation_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.EndEdit)
            {
                if (txtTaxTypeID.Text.Trim().Length == 0)
                {
                    txtTaxTypeID.Text = Guid.NewGuid().ToString();
                }
                MessageBox.Show("Record is saved");
            }
        }
        //End Cong
    }
}

