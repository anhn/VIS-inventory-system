using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace Inventory
{
    public partial class AddEditTax : Form
    {
        public AddEditTax()
        {
            InitializeComponent();
        }
        public AddEditTax(string tax_code_id)
        {
            InitializeComponent();
            Tax_code_id = tax_code_id;
        }
        private string Tax_code_id;
        private DataTable tblMemberShip;
        private DataTable tblTaxType;
        private SqlDataAdapter sqlAdapter,sqlAdapterTaxType;
        private DataSet dSet;
        private SqlConnection sqlCon;

        private void AddEditTax_Load(object sender, EventArgs e)
        {
            try
            {
                //Create DataTable for Bindings
                tblMemberShip = new DataTable();
                tblTaxType = new DataTable();

                //Create a Connection to database
                sqlCon = new SqlConnection(Globals.strVISConnection);

                //Open connection
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                //Create a Adapter
                sqlAdapter = new SqlDataAdapter("SELECT * FROM Tax_Code_Master", sqlCon);

                dSet = new DataSet();
                //Fill to table
                sqlAdapter.Fill(dSet, "Tax_Code_Master");
                //Set the datasource to DataNavigator
                //Open connection
                /*

                 */
                tblMemberShip = dSet.Tables[0];
                dnTax.DataSource = tblMemberShip;
                //Binding data to control
                txtTax_code_id.DataBindings.Add("Text", tblMemberShip, "Tax_code_id");
                txtTaxTypeID.DataBindings.Add("Text", tblMemberShip, "TaxTypeID");
                txtTaxRate.DataBindings.Add("Text", tblMemberShip, "TaxRate");
                mmoDes.DataBindings.Add("Text", tblMemberShip, "Tax_code_desc");
                mmoNote.DataBindings.Add("Text", tblMemberShip, "Note");
                rdoViewStatus.DataBindings.Add("EditValue", tblMemberShip, "ViewStatus");
                txtUserID.DataBindings.Add("Text", tblMemberShip, "UserID");
                if (Tax_code_id != null)
                {
                    for (int i = 0; i < tblMemberShip.Rows.Count; i++)
                    {
                        if (tblMemberShip.Rows[i]["Tax_code_id"].ToString() == Tax_code_id)
                        {
                            dnTax.Position = i;
                            break;
                        }
                    }
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error when read data");
            }
        }
        private void LoadData()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            //Create a Adapter
            tblTaxType = new DataTable();
            sqlAdapterTaxType = new SqlDataAdapter("SELECT * FROM TaxType", sqlCon);
            sqlAdapterTaxType.Fill(tblTaxType);
            cboTaxType.Properties.Items.Clear();
            foreach (DataRow dr in tblTaxType.Rows)
            {
                cboTaxType.Properties.Items.Add(dr["TaxTypeName"].ToString());
                if (dr["TaxTypeID"].ToString() == txtTaxTypeID.Text)
                {
                    cboTaxType.Text = dr["TaxTypeName"].ToString();
                }
            }
        }
        private void AddEditTax_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                sqlCon.Close();
                sqlCon.Open();
                //Create command for update
                SqlCommandBuilder cmd = new SqlCommandBuilder(sqlAdapter);
                //Update all changes to database                
                sqlAdapter.Update(dSet, "Tax_Code_Master");
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void dnTax_Click(object sender, EventArgs e)
        {
            
        }

        private void dnTax_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                txtUserID.Text = Globals.UserID;
            }
            else if (e.Button.ButtonType == NavigatorButtonType.EndEdit)
            {
                if (txtTax_code_id.Text.Length == 0)
                    txtTax_code_id.Text = Guid.NewGuid().ToString();
                MessageBox.Show("Record is saved");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (Globals.CheckAccessRights(Globals.UserID,"21BA90CE-048C-490D-B42A-69F83121623C",true))
            //{
                if (MessageBox.Show("This record and all related records will be deleted! Are you sure?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        foreach (DataRow row in tblMemberShip.Rows)
                        {
                            if (row["Tax_code_id"].ToString() == txtTax_code_id.Text)
                            {
                                //remove from table
                                DeleteSQL del = new DeleteSQL(new SqlConnection(Globals.strVISConnection));
                                if (del.deleteTax(txtTax_code_id.Text))
                                    tblMemberShip.Rows.Remove(row);
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

        private void cboTaxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTaxType.SelectedIndex >= 0)
            {
                txtTaxTypeID.Text = tblTaxType.Rows[cboTaxType.SelectedIndex]["TaxTypeID"].ToString();
            }
        }

        private void txtTaxTypeID_EditValueChanged(object sender, EventArgs e)
        {
            cboTaxType.Text = "";
            foreach (DataRow dr in tblTaxType.Rows)
            {
                if (dr["TaxTypeID"].ToString() == txtTaxTypeID.Text)
                    cboTaxType.Text = dr["TaxTypeName"].ToString();
            }
        }

        private void cboTaxType_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                AddEditTaxType frmAddEditTaxType = new AddEditTaxType(cboTaxType.Text);
                frmAddEditTaxType.ShowDialog();
                LoadData();
                cboTaxType.Text = "";
                foreach (DataRow dr in tblTaxType.Rows)
                {
                    if (dr["TaxTypeID"].ToString() == txtTaxTypeID.Text)
                        cboTaxType.Text = dr["TaxTypeName"].ToString();
                }
            }
        }

        private void cboTaxType_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
        }
    }
}