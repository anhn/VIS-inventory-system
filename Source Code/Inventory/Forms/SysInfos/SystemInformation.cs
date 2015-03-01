using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using Inventory.DataModels.SysInfos;

namespace Inventory.Forms.SysInfo
{
    /// <summary>
    /// Summary description for SystemInformation.
    /// </summary>
    public class SystemInformation : DevExpress.XtraEditors.XtraForm
    {
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextEdit txtHost;
        private Label label4;
        private TextEdit txtPassword;
        private Label label3;
        private TextEdit txtUser;
        private Label label2;
        private TextEdit txtDatabase;
        private Label label1;
        private SimpleButton btnClose;
        private SimpleButton btnSave;
        private TabPage tabPage3;
        private Label label5;
        private SimpleButton btnTestConn;
        private TextEdit txtServer;
        private Label label7;
        private TextEdit txtReceiver;
        private Label label6;
        private TextEdit txtSender;
        private ComboBoxEdit cboLanguage;
        private Label label8;
        private TextEdit txtSenderName;
        private Label label9;
        private Label label10;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        Properties.Settings settings = Properties.Settings.Default;
        private SysInfosModel model = new SysInfosModel();

        public SysInfosModel DataModel
        {
            get { return model; }
        }

        public SystemInformation()
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboLanguage = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTestConn = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatabase = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHost = new DevExpress.XtraEditors.TextEdit();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtServer = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReceiver = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSenderName = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSender = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLanguage.Properties)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHost.Properties)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenderName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSender.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(531, 310);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cboLanguage);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(523, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboLanguage
            // 
            this.cboLanguage.Location = new System.Drawing.Point(123, 44);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLanguage.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboLanguage.Size = new System.Drawing.Size(160, 21);
            this.cboLanguage.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 14);
            this.label8.TabIndex = 2;
            this.label8.Text = "Language";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnTestConn);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtPassword);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtUser);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtDatabase);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtHost);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(523, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datasource";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnTestConn
            // 
            this.btnTestConn.Location = new System.Drawing.Point(29, 234);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(92, 23);
            this.btnTestConn.TabIndex = 8;
            this.btnTestConn.Text = "Test Connection";
            this.btnTestConn.Click += new System.EventHandler(this.btnTestConn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(118, 172);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(165, 21);
            this.txtPassword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "DB User";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(118, 128);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(165, 21);
            this.txtUser.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Database";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(118, 85);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(165, 21);
            this.txtDatabase.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(118, 44);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(165, 21);
            this.txtHost.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtServer);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtReceiver);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtSenderName);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtSender);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 21);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(523, 285);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Email";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(118, 172);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(165, 21);
            this.txtServer.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 14);
            this.label7.TabIndex = 4;
            this.label7.Text = "Host";
            // 
            // txtReceiver
            // 
            this.txtReceiver.Location = new System.Drawing.Point(118, 128);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(165, 21);
            this.txtReceiver.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 14);
            this.label6.TabIndex = 2;
            this.label6.Text = "Receiver Email";
            // 
            // txtSenderName
            // 
            this.txtSenderName.Location = new System.Drawing.Point(118, 44);
            this.txtSenderName.Name = "txtSenderName";
            this.txtSenderName.Size = new System.Drawing.Size(165, 21);
            this.txtSenderName.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(316, 14);
            this.label10.TabIndex = 0;
            this.label10.Text = "* Multi-emails is separated by comma (,) or semicolon (;)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 14);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sender Name";
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(118, 85);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(165, 21);
            this.txtSender.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sender Email";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(283, 329);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(171, 329);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save all";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SystemInformation
            // 
            this.AcceptButton = this.btnSave;
            this.ClientSize = new System.Drawing.Size(531, 364);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SystemInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Information";
            this.Load += new System.EventHandler(this.SystemInformation_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLanguage.Properties)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHost.Properties)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenderName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSender.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private void SystemInformation_Load(object sender, EventArgs e)
        {
            cboLanguage.Properties.Items.Add(settings.strLanguage1);
            cboLanguage.Properties.Items.Add(settings.strLanguage2);
            cboLanguage.Properties.Items.Add(settings.strLanguage3);
            cboLanguage.SelectedIndex = settings.cfgLanguage;

            txtHost.Text = settings.DB_Host;
            txtDatabase.Text = settings.DB_Database;
            txtUser.Text = settings.DB_User;
            txtPassword.Text = settings.DB_Password;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.SaveData();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnTestConn_Click(object sender, EventArgs e)
        {
            string strConnection = "Data Source={0};Initial Catalog={1};User ID={2};Password={3}";
            strConnection = string.Format(strConnection, txtHost.Text, txtDatabase.Text, txtUser.Text, txtPassword.Text);

            SqlConnection conn = new SqlConnection(strConnection);
            try
            {
                conn.Open();
                MessageBox.Show(Constants.Message.Sys_ConnectSuccess, Constants.Message.MessageTitle);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Constants.Message.MessageTitle);
            }
        }

        private void SaveData()
        {
            settings.cfgLanguage = cboLanguage.SelectedIndex;

            settings.DB_Host = txtHost.Text;
            settings.DB_Database = txtDatabase.Text;
            settings.DB_User = txtUser.Text;
            settings.DB_Password = txtPassword.Text;

            settings.Save();

            model.MailSender = txtSenderName.Text;
            model.MailFrom = txtSender.Text;
            model.MailTo = txtReceiver.Text;
            model.MailServer = txtServer.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // confirm to save data
            DialogResult dlgResult = MessageBox.Show(Constants.Message.Save_Prompt, Constants.Message.MessageTitle, MessageBoxButtons.YesNo);
            if (dlgResult == DialogResult.Yes)
            {
                btnSave_Click(btnSave, EventArgs.Empty);
            }
            else
            {
                this.Close();
            }
        }

        public void BindData(SysInfosModel sim)
        {
            this.model = sim;

            txtSenderName.Text = sim.MailSender;
            txtSender.Text = sim.MailFrom;
            txtReceiver.Text = sim.MailTo;
            txtServer.Text = sim.MailServer;
        }
    }
}

