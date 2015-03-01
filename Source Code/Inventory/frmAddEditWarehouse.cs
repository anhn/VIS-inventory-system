using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;

namespace Inventory
{
    /// <summary>
    /// Summary description for frmAddEditWarehouse.
    /// </summary>
    public class frmAddEditWarehouse : DevExpress.XtraEditors.XtraForm
    {
        private GroupControl grbWarehouse;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupControl groupControl2;
        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private TextEdit txtDescription;
        private TextEdit txtCountry;
        private TextEdit txtPostal_Code;
        private MemoEdit memAddress_line;
        private TextEdit txtDivision_Code;
        private Label label5;
        private MemoEdit memAddress_line_2;
        private Label label6;
        private Label label7;
        private TextEdit txtWarehouse_code;
        private Label label8;
        private Label label9;
        private TextEdit txtCity;
        private TextEdit txtDistrict;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmAddEditWarehouse()
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
            this.grbWarehouse = new DevExpress.XtraEditors.GroupControl();
            this.txtCity = new DevExpress.XtraEditors.TextEdit();
            this.txtDistrict = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWarehouse_code = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.memAddress_line_2 = new DevExpress.XtraEditors.MemoEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDivision_Code = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.memAddress_line = new DevExpress.XtraEditors.MemoEdit();
            this.txtCountry = new DevExpress.XtraEditors.TextEdit();
            this.txtPostal_Code = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grbWarehouse)).BeginInit();
            this.grbWarehouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistrict.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarehouse_code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memAddress_line_2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDivision_Code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memAddress_line.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostal_Code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbWarehouse
            // 
            this.grbWarehouse.Controls.Add(this.txtCity);
            this.grbWarehouse.Controls.Add(this.txtDistrict);
            this.grbWarehouse.Controls.Add(this.label7);
            this.grbWarehouse.Controls.Add(this.txtWarehouse_code);
            this.grbWarehouse.Controls.Add(this.label8);
            this.grbWarehouse.Controls.Add(this.label9);
            this.grbWarehouse.Controls.Add(this.memAddress_line_2);
            this.grbWarehouse.Controls.Add(this.label6);
            this.grbWarehouse.Controls.Add(this.txtDivision_Code);
            this.grbWarehouse.Controls.Add(this.label5);
            this.grbWarehouse.Controls.Add(this.memAddress_line);
            this.grbWarehouse.Controls.Add(this.txtCountry);
            this.grbWarehouse.Controls.Add(this.txtPostal_Code);
            this.grbWarehouse.Controls.Add(this.txtDescription);
            this.grbWarehouse.Controls.Add(this.label4);
            this.grbWarehouse.Controls.Add(this.label3);
            this.grbWarehouse.Controls.Add(this.label2);
            this.grbWarehouse.Controls.Add(this.label1);
            this.grbWarehouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbWarehouse.Location = new System.Drawing.Point(0, 0);
            this.grbWarehouse.Name = "grbWarehouse";
            this.grbWarehouse.ShowCaption = false;
            this.grbWarehouse.Size = new System.Drawing.Size(694, 434);
            this.grbWarehouse.TabIndex = 0;
            this.grbWarehouse.Text = "groupControl1";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(234, 267);
            this.txtCity.Name = "txtCity";
            this.txtCity.Properties.MaxLength = 50;
            this.txtCity.Size = new System.Drawing.Size(341, 20);
            this.txtCity.TabIndex = 5;
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(234, 230);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Properties.MaxLength = 50;
            this.txtDistrict.Size = new System.Drawing.Size(341, 20);
            this.txtDistrict.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Warehouse Code:";
            // 
            // txtWarehouse_code
            // 
            this.txtWarehouse_code.Location = new System.Drawing.Point(234, 40);
            this.txtWarehouse_code.Name = "txtWarehouse_code";
            this.txtWarehouse_code.Properties.MaxLength = 10;
            this.txtWarehouse_code.Size = new System.Drawing.Size(341, 20);
            this.txtWarehouse_code.TabIndex = 0;
            this.txtWarehouse_code.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtWarehouse_code_EditValueChanging);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "City:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(119, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "District:";
            // 
            // memAddress_line_2
            // 
            this.memAddress_line_2.Location = new System.Drawing.Point(234, 172);
            this.memAddress_line_2.Name = "memAddress_line_2";
            this.memAddress_line_2.Properties.MaxLength = 1000;
            this.memAddress_line_2.Size = new System.Drawing.Size(341, 41);
            this.memAddress_line_2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Address 2:";
            // 
            // txtDivision_Code
            // 
            this.txtDivision_Code.Location = new System.Drawing.Point(234, 340);
            this.txtDivision_Code.Name = "txtDivision_Code";
            this.txtDivision_Code.Properties.MaxLength = 20;
            this.txtDivision_Code.Size = new System.Drawing.Size(341, 20);
            this.txtDivision_Code.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Division Code:";
            // 
            // memAddress_line
            // 
            this.memAddress_line.Location = new System.Drawing.Point(234, 114);
            this.memAddress_line.Name = "memAddress_line";
            this.memAddress_line.Properties.MaxLength = 1000;
            this.memAddress_line.Size = new System.Drawing.Size(341, 41);
            this.memAddress_line.TabIndex = 2;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(234, 304);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Properties.MaxLength = 20;
            this.txtCountry.Size = new System.Drawing.Size(341, 20);
            this.txtCountry.TabIndex = 6;
            // 
            // txtPostal_Code
            // 
            this.txtPostal_Code.Location = new System.Drawing.Point(234, 375);
            this.txtPostal_Code.Name = "txtPostal_Code";
            this.txtPostal_Code.Properties.MaxLength = 20;
            this.txtPostal_Code.Size = new System.Drawing.Size(341, 20);
            this.txtPostal_Code.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(234, 77);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.MaxLength = 50;
            this.txtDescription.Size = new System.Drawing.Size(341, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Country:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Postal Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Address 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Warehouse Name:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnCancel);
            this.groupControl2.Controls.Add(this.btnOK);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 434);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(694, 41);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "groupControl2";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(607, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Close";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(526, 7);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&Save";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmAddEditWarehouse
            // 
            this.ClientSize = new System.Drawing.Size(694, 475);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.grbWarehouse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Edit Warehouse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditWarehouse_FormClosing);
            this.Load += new System.EventHandler(this.frmAddEditWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grbWarehouse)).EndInit();
            this.grbWarehouse.ResumeLayout(false);
            this.grbWarehouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistrict.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarehouse_code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memAddress_line_2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDivision_Code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memAddress_line.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostal_Code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Variable
        bool isSave;
        #endregion
        #region Method
        private void LoadComponent()
        {
            if (ProRowWarehouse["Description"].ToString() != "")
            {
                //txtDescription.Enabled = false;
            }
            for (int i = 0; i < ProRowWarehouse.Table.Columns.Count; i++)
            {
                foreach (Control col in grbWarehouse.Controls)
                {
                    if (col is TextEdit && col.Name.Substring(0, 3) == "txt")
                    {
                        if (ProRowWarehouse.Table.Columns[i].Caption.Replace(" ","_") == col.Name.Substring(3))
                        {
                            ((TextEdit)col).EditValue = ProRowWarehouse[i];
                        }
                    }
                    else if(col is MemoEdit)
                    {
                        if (ProRowWarehouse.Table.Columns[i].Caption.Replace(" ","_") == col.Name.Substring(3))
                        {
                            ((MemoEdit)col).EditValue = ProRowWarehouse[i];
                        }
                        
                    }
                }
            }
        }

        private bool CheckValidate()
        {
            if (txtDescription.Text == "")
            {
                MessageBox.Show("Field  Warehouse Name empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return false;
            }
            if (txtWarehouse_code.Text == "")
            {
                MessageBox.Show("Field  Warehouse Code empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWarehouse_code.Focus();
                return false;
            }
            if (ProRowWarehouse["Warehouse_id"].ToString() != "")
            {

                if (ExistWarehouse() > 0 && txtDescription.Text != ProRowWarehouse["Description"].ToString())
                {

                    MessageBox.Show("This name is already avaiable, please select another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescription.Focus();

                    return false;
                }
                if (ExistWarehouseCode() > 0 && txtWarehouse_code.Text != ProRowWarehouse["Warehouse_code"].ToString())
                {

                    MessageBox.Show("This Warehouse Code is already avaiable, please select another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtWarehouse_code.Focus();

                    return false;
                }
            }
            else
            {
                if (ExistWarehouse() > 0)
                {
                    MessageBox.Show("This name is already avaiable, please select another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescription.Focus();
                    return false;
                }
                if (ExistWarehouseCode()>0)
                {

                    MessageBox.Show("This Warehouse Code is already avaiable, please select another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtWarehouse_code.Focus();

                    return false;
                }
            }
            
            return true;
        }
        private int ExistWarehouse()
        {
            int count=0;
            for (int i=0; i < Globals.dtWarehouse_Master.Rows.Count; i++)
            {
                if (Globals.dtWarehouse_Master.Rows[i].RowState != DataRowState.Deleted)
                {
                    if (Globals.dtWarehouse_Master.Rows[i]["Description"].ToString() == txtDescription.Text)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        private int ExistWarehouseCode()
        {
            int count = 0;
            for (int i = 0; i < Globals.dtWarehouse_Master.Rows.Count; i++)
            {
                if (Globals.dtWarehouse_Master.Rows[i].RowState != DataRowState.Deleted)
                {
                    if (Globals.dtWarehouse_Master.Rows[i]["Warehouse_code"].ToString().Trim() == txtWarehouse_code.Text.Trim())
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        private void SaveData()
        {
            if (!CheckValidate())
            {
                return;
            }
            this.DialogResult = DialogResult.OK;
            isSave = true;
            txtWarehouse_code.Text = txtWarehouse_code.Text.TrimEnd();
            txtWarehouse_code.Text = txtWarehouse_code.Text.TrimStart();

            foreach (Control col in grbWarehouse.Controls)
            {

                for (int i = 0; i < ProRowWarehouse.Table.Columns.Count; i++)
                {
                    if (col.Name.Substring(0, 3) == "txt" && col is TextEdit)
                    {

                        if (ProRowWarehouse.Table.Columns[i].Caption.Replace(" ", "_") == col.Name.Substring(3))
                        {
                            ProRowWarehouse[i] = ((TextEdit)col).EditValue;
                        }

                    }
                    else if (col is MemoEdit)
                    {
                        if (ProRowWarehouse.Table.Columns[i].Caption.Replace(" ", "_") == col.Name.Substring(3))
                        {
                            ProRowWarehouse[i] = ((MemoEdit)col).EditValue;
                        }
                    }
                }

            }
            this.Close();
        }
        #endregion
        #region Property
        DataRow rowWarehouse;
        public DataRow ProRowWarehouse
        {
            get
            {
                return this.rowWarehouse;
            }
            set
            {
                rowWarehouse = value;
            }
        }
        #endregion
        #region Event
        #endregion


        private void frmAddEditWarehouse_Load(object sender, EventArgs e)
        {
            LoadComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveData();

        }

  

        private void frmAddEditWarehouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSave)
            {
                string str = MessageBox.Show("Do you want save your changes", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (str == "Yes")
                {
                    btnOK.PerformClick();
                }
                else
                {
                  
                }
            }
            
            
        }

        private void txtWarehouse_code_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
        
        }

       
    }
}

