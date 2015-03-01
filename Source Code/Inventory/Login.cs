using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Data;

using System.Data;
using System.Data.SqlClient;


namespace Inventory
{
    /// <summary>
    /// Summary description for Login.
    /// </summary>
    public class Login : DevExpress.XtraEditors.XtraForm
    {
        private Label lbUsername;
        private TextEdit txtUsername;
        private TextEdit txtPassword;
        private Label label1;
        private SimpleButton btnLogin;
        private SimpleButton btnExit;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Login()
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
            this.lbUsername = new System.Windows.Forms.Label();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(10, 18);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(65, 14);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "&Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(83, 14);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Mask.EditMask = "[a-zA-Z_0-9]{1,}";
            this.txtUsername.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtUsername.Size = new System.Drawing.Size(205, 21);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(83, 52);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(205, 21);
            this.txtPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "&Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(39, 87);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(95, 24);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "&Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(164, 87);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 24);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.ClientSize = new System.Drawing.Size(307, 123);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private SqlConnection sqlConn;
        private int loginCounts = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checkUsernamePassword(txtUsername.Text, txtPassword.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }
            if (loginCounts < 3)
            {
                MessageBox.Show("This is an incorrect Username or password. Please login!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else 
            {
                MessageBox.Show("This is an incorrect Username or password. Application will be exit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.No;
                this.Close();
            }
            loginCounts++;

        }

        private void Login_Load(object sender, EventArgs e)
        {
            Globals.SetDefaultFont(this);
            sqlConn = new SqlConnection(Globals.strVISConnection);
            sqlConn.Open();
            loginCounts = 0;
            txtUsername.Text = "administrator";
            txtPassword.Text = "222";
        }
        
        private bool checkUsernamePassword(string usr, string pass)
        {
            try
            {
                string strSQL = "select * from t_User where UPPER(UserName) = '" + usr.ToUpper() + "' and  Password = '" + pass + "'";
                
                SqlDataAdapter adapter = new SqlDataAdapter(strSQL, sqlConn);
                DataTable tb = new DataTable();
                adapter.Fill(tb);

                //SqlCommand cmd = new SqlCommand(strSQL, sqlConn);
                //SqlDataReader reader = cmd.ExecuteReader();
                
                if (tb.Rows.Count > 0)
                {
                                        
                    Globals.UserName = tb.Rows[0]["UserName"].ToString();
                    Globals.UserID = tb.Rows[0]["UserID"].ToString();
                    string sqlSql2 ="Select * from VUserSecurity where UserID='"+tb.Rows[0]["UserID"].ToString()+"'";
                    SqlDataAdapter adapter2 = new SqlDataAdapter(sqlSql2, sqlConn);
                    DataTable dt = new DataTable();
                    
                    adapter2.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (dt.Rows[i]["RoleName"].ToString().ToLower() == "administrator")
                            {
                                Globals.isAdministrator = true;
                                return true;
                            }
                        }
                    }
                    return true;
                }
            }
            catch (Exception) { }
            return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}

