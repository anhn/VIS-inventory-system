using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using Toolkit;

namespace Inventory
{
    public partial class AddEditPayment : DevExpress.XtraEditors.XtraForm
    {
        public AddEditPayment()
        {
            InitializeComponent();
        }
        public AddEditPayment(string id)
        {
            InitializeComponent();
            ID = id;

        }
        private string ID;
        private DataTable tblMemberShip;
        private SqlDataAdapter sqlAdapter;
        private DataSet dSet;
        private SqlConnection sqlCon;

        private void AddEditPayment_Load(object sender, EventArgs e)
        {
            try
            {
                //Create DataTable for Bindings
                tblMemberShip = new DataTable();

                //Create a Connection to database
                sqlCon = new SqlConnection(Globals.strVISConnection);

                //Open connection
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                //Create a Adapter
                sqlAdapter = new SqlDataAdapter("SELECT * FROM PaymentTermMaster", sqlCon);

                dSet = new DataSet();
                //Fill to table
                sqlAdapter.Fill(dSet, "PaymentTermMaster");
                //Set the datasource to DataNavigator
                tblMemberShip = dSet.Tables[0];
                dnPayment.DataSource = tblMemberShip;
                //Binding data to control                
                txtPaymentTermsName.DataBindings.Add("Text", tblMemberShip, "PaymentTermsName");
                rdoViewStatus.DataBindings.Add("EditValue", tblMemberShip, "ViewStatus");
                txtDiscountDay.DataBindings.Add("Text", tblMemberShip, "DiscountDay");
                txtDiscountPercent.DataBindings.Add("Text", tblMemberShip, "DiscountPercent");
                txtPaymentsDay.DataBindings.Add("Text", tblMemberShip, "PaymentsDay");
                txtUserID.DataBindings.Add("Text", tblMemberShip, "UserID");
                txtLastUpdatedDate.DataBindings.Add("Text", tblMemberShip, "LastUpdatedDate");
                memoNote.DataBindings.Add("EditValue", tblMemberShip, "Notes");
                txtId.DataBindings.Add("Text", tblMemberShip, "ID");
                if (ID != null)
                {
                    for (int i = 0; i < tblMemberShip.Rows.Count; i++)
                    {
                        if (tblMemberShip.Rows[i]["ID"].ToString() == ID)
                        {
                            dnPayment.Position = i;
                            break;
                        }
                    }
                }
                rdoViewStatus.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddEditPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                sqlCon.Close();
                sqlCon.Open();
                //Create command for update
                SqlCommandBuilder cmd = new SqlCommandBuilder(sqlAdapter);
                //Update all changes to database                
                sqlAdapter.Update(dSet, "PaymentTermMaster");
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error when saving data");
            }
        }

        private void dnPayment_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                txtUserID.Text = Globals.UserID;
                txtLastUpdatedDate.Text = DateTime.Now.ToShortDateString();
            } else if (e.Button.ButtonType == NavigatorButtonType.EndEdit)
            {
                if (Toolkit.DbToolKit.IsDataOfSqlExists("SELECT ID, PaymentTermsName FROM PaymentTermMaster WHERE PaymentTermsName = '" + txtPaymentTermsName.Text + "' AND ID <> '" + txtId.Text + "'"))
                {
                    MessageBox.Show("This name is already available, please select another one");
                    txtPaymentTermsName.Focus();
                    e.Handled = false;
                    return;
                }

                Validator objValidator = new Validator();
                if (!(objValidator.IsNonEmpty("Name", txtPaymentTermsName.Text)))
                {
                    txtPaymentTermsName.Focus();
                    e.Handled = false;
                    return;
                }

                if (txtId.Text.Length == 0)
                    txtId.Text = Guid.NewGuid().ToString();
                txtLastUpdatedDate.Text = DateTime.Now.ToShortDateString();
                MessageBox.Show("Record is saved");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (Globals.CheckAccessRights(Globals.UserID,"21BA90CE-048C-490D-B42A-69F83121623C",true))
            //{

                if (MessageBox.Show("This record will be deleted! Are you sure?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        foreach (DataRow row in tblMemberShip.Rows)
                        {
                            if (row["ID"].ToString() == txtId.Text)
                            {
                                //remove from table
                                DeleteSQL del = new DeleteSQL(new SqlConnection(Globals.strVISConnection));
                                if (del.deletePayment(txtId.Text))
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
 
    }
}