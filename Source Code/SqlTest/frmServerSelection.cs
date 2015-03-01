using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SqlTest
{
    public partial class frmServerSelection : Form
    {
        public frmServerSelection()
        {
            InitializeComponent();
        }

        private bool LoginOk = false;

        private void txtServerPath_EditValueChanged(object sender, EventArgs e)
        {
            btnConnect.Enabled = (txtServerPath.Text.Trim().Length != 0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void btnOk_Click(object sender, EventArgs e)
        {
            if (!LoginOk)
            {
                MessageBox.Show("Connect to server first. Try again!");
                txtServerPath.Select();
                return;
            }
            else if (lstDatabase.SelectedItem == null)
            {
                if ((Tag as frmMain).actionType == frmMain.ACTION_OPEN_REPORT)
                {
                    MessageBox.Show("Sorry, we can not find the database: " + DbManager.database + " in this server.");
                }
                else
                {
                    MessageBox.Show("Select database first.");
                    lstDatabase.Select();
                }
            }
            else
            {
                string db = lstDatabase.Items[lstDatabase.SelectedIndex].ToString();
                if (db != DbManager.database || (Tag as frmMain).actionType == frmMain.ACTION_OPEN_REPORT)
                {
                    DbManager.database = db;
                    DbManager.username = txtUsername.Text;
                    DbManager.password = txtPassword.Text;
                    DbManager.Connect();
                    ((frmMain)Tag).fAddTable.reload = true;
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        public void btnConnect_Click(object sender, EventArgs e)
        {
            ((frmMain)Tag).fAddTable.reload = true;
            string serverPath = txtServerPath.Text.Trim();
            try
            {
                SqlConnection con = new SqlConnection("Data Source=" + serverPath + ";User Id=" + txtUsername.Text.Trim() + ";Password=" + txtPassword.Text + ";");
                con.Open();

                //Create SQL statement
                string sql = "sp_databases";

                //Open a command object using the connection and prepare the sql statement.
                SqlCommand cmd = new SqlCommand(sql, con);

                //Run the command
                SqlDataReader reader = cmd.ExecuteReader();

                lstDatabase.Items.Clear();
                //Loop though and display the first column of the results.
                while (reader.Read())
                {
                    lstDatabase.Items.Add(reader[0]);
                }

                //Close The reader and connection
                reader.Close();
                con.Close();
                grDatabase.Enabled = true;
                lstDatabase.Select();
                DbManager.server = serverPath;
                LoginOk = true;
                if (((frmMain)Tag).actionType == frmMain.ACTION_OPEN_REPORT)
                {
                    lstDatabase.Enabled = false;
                    int i = 0;
                    foreach (String name in lstDatabase.Items)
                    {                        
                        if (name.ToUpper() == DbManager.database.ToUpper())
                        {
                            lstDatabase.SelectedIndex = i;
                            break;
                        }
                        i++;
                    }
                }
                else
                {
                    lstDatabase.Enabled = true;
                }
                string dbname = ((frmMain)Tag).database;
                if (dbname == null || dbname == "")
                    dbname = DbManager.database;
                lstDatabase.SelectedIndex = lstDatabase.FindString(dbname);
                btnOk_Click(sender, e);
            }
            catch (Exception ex)
            {
                LoginOk = false;
                MessageBox.Show("Could not connect to server: " + serverPath);
                txtServerPath.Select();
            }
        }

        private void frmServerSelection_Load(object sender, EventArgs e)
        {
            frmMain frm = Tag as frmMain;
            if (frm.actionType == frmMain.ACTION_OPEN_REPORT)
            {
                txtServerPath.Text = DbManager.server;
                txtUsername.Text = DbManager.username;
                txtPassword.Text = DbManager.password;
                lstDatabase.Items.Clear();
                btnConnect_Click(sender, e);
            }
            else
            {
                this.Update();
                btnConnect_Click(sender, e);
            }
        }

        private void lstDatabase_DoubleClick(object sender, EventArgs e)
        {
            btnOk_Click(sender, e);
        }

        private void txtUsername_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}