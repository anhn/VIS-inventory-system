namespace SqlTest
{
    partial class frmServerSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.grServer = new DevExpress.XtraEditors.GroupControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.txtServerPath = new DevExpress.XtraEditors.TextEdit();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.lstDatabase = new DevExpress.XtraEditors.ListBoxControl();
            this.grDatabase = new DevExpress.XtraEditors.GroupControl();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grServer)).BeginInit();
            this.grServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDatabase)).BeginInit();
            this.grDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // grServer
            // 
            this.grServer.Controls.Add(this.label3);
            this.grServer.Controls.Add(this.label2);
            this.grServer.Controls.Add(this.btnConnect);
            this.grServer.Controls.Add(this.txtServerPath);
            this.grServer.Controls.Add(this.txtUsername);
            this.grServer.Controls.Add(this.label1);
            this.grServer.Controls.Add(this.txtPassword);
            this.grServer.Location = new System.Drawing.Point(17, 12);
            this.grServer.Name = "grServer";
            this.grServer.Size = new System.Drawing.Size(364, 101);
            this.grServer.TabIndex = 0;
            this.grServer.Text = "Server Config";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(277, 66);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(77, 28);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "C&onnect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtServerPath
            // 
            this.txtServerPath.EditValue = "";
            this.txtServerPath.Location = new System.Drawing.Point(74, 72);
            this.txtServerPath.Name = "txtServerPath";
            this.txtServerPath.Size = new System.Drawing.Size(198, 20);
            this.txtServerPath.TabIndex = 2;
            this.txtServerPath.EditValueChanged += new System.EventHandler(this.txtServerPath_EditValueChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.EditValue = "";
            this.txtUsername.Location = new System.Drawing.Point(74, 21);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(198, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.EditValueChanged += new System.EventHandler(this.txtUsername_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "User name:";
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "";
            this.txtPassword.Location = new System.Drawing.Point(74, 47);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(198, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(294, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 27);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(279, 95);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(77, 27);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "&OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lstDatabase
            // 
            this.lstDatabase.Location = new System.Drawing.Point(9, 20);
            this.lstDatabase.Name = "lstDatabase";
            this.lstDatabase.Size = new System.Drawing.Size(265, 168);
            this.lstDatabase.TabIndex = 4;
            this.lstDatabase.DoubleClick += new System.EventHandler(this.lstDatabase_DoubleClick);
            // 
            // grDatabase
            // 
            this.grDatabase.Controls.Add(this.lstDatabase);
            this.grDatabase.Controls.Add(this.btnOk);
            this.grDatabase.Enabled = false;
            this.grDatabase.Location = new System.Drawing.Point(15, 121);
            this.grDatabase.Name = "grDatabase";
            this.grDatabase.Size = new System.Drawing.Size(365, 196);
            this.grDatabase.TabIndex = 6;
            this.grDatabase.Text = "Select Database from List bellow";
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnBack.Location = new System.Drawing.Point(294, 249);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 27);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "&Back";
            // 
            // frmServerSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 332);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grDatabase);
            this.Controls.Add(this.grServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmServerSelection";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmServerSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grServer)).EndInit();
            this.grServer.ResumeLayout(false);
            this.grServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDatabase)).EndInit();
            this.grDatabase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grServer;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.GroupControl grDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        public DevExpress.XtraEditors.TextEdit txtServerPath;
        public DevExpress.XtraEditors.TextEdit txtPassword;
        public DevExpress.XtraEditors.TextEdit txtUsername;
        public DevExpress.XtraEditors.SimpleButton btnOk;
        public DevExpress.XtraEditors.SimpleButton btnConnect;
        public DevExpress.XtraEditors.ListBoxControl lstDatabase;


    }
}

