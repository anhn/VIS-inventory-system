using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;
using Inventory.Properties;
using System.Data;
using System.Data.SqlClient;
using DevExpress.Data;

namespace Inventory
{
    /// <summary>
    /// Summary description for LangSettings.
    /// </summary>
    public class LangSettings : DevExpress.XtraEditors.XtraForm
    {
        private DevExpress.XtraGrid.GridControl gridLanguages;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private PanelControl panelControl1;
        private SimpleButton simpleButton1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public LangSettings()
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
            this.gridLanguages = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridLanguages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridLanguages
            // 
            this.gridLanguages.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.gridLanguages.EmbeddedNavigator.Name = "";
            this.gridLanguages.Location = new System.Drawing.Point(0, 0);
            this.gridLanguages.MainView = this.gridView1;
            this.gridLanguages.Name = "gridLanguages";
            this.gridLanguages.Size = new System.Drawing.Size(745, 349);
            this.gridLanguages.TabIndex = 0;
            this.gridLanguages.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridLanguages;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 349);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(745, 36);
            this.panelControl1.TabIndex = 1;
            this.panelControl1.Text = "panelControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strClose", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.simpleButton1.Location = new System.Drawing.Point(19, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(136, 25);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = global::Inventory.Properties.Settings.Default.strClose;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // LangSettings
            // 
            this.ClientSize = new System.Drawing.Size(745, 385);
            this.Controls.Add(this.gridLanguages);
            this.Controls.Add(this.panelControl1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strLanguageSettings", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "LangSettings";
            this.Text = global::Inventory.Properties.Settings.Default.strLanguageSettings;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LangSettings_FormClosing);
            this.Load += new System.EventHandler(this.LangSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLanguages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView grvLanguage;
        private DataTable tblLanguage = new DataTable();
        private bool isLoading = true;
        private bool isModified = false;
        private void LoadLanguage()
        {
            try
            {
                string strSQL = "SELECT * FROM Languages";
                SqlDataAdapter addapter = new SqlDataAdapter(strSQL, sqlConn);
                addapter.Fill(tblLanguage);
                gridLanguages.DataSource = tblLanguage;
                grvLanguage = (DevExpress.XtraGrid.Views.Grid.GridView)gridLanguages.Views[0];
                grvLanguage.Columns["StringID"].Visible = false;
                grvLanguage.Columns["Lang1"].Caption = Settings.Default.strWord_Phrase;
                //grvLanguage.Columns["Lang1"].ColumnEdit.ReadOnly = true;
                grvLanguage.Columns["Lang1"].OptionsColumn.AllowEdit = false;
                grvLanguage.Columns["Lang2"].Caption = Settings.Default.strLanguage1;
                grvLanguage.Columns["Lang3"].Caption = Settings.Default.strLanguage2;
                grvLanguage.Columns["Lang4"].Caption = Settings.Default.strLanguage3;

                tblLanguage.RowChanged += new DataRowChangeEventHandler(tblLanguage_RowChanged);
            }
            catch (Exception) { }
        }

        void tblLanguage_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (isLoading) return;
            try
            {                
                string strSQL = "UPDATE Languages SET Lang2 = @Lang2, Lang3 = @Lang3, Lang4 = @Lang4  WHERE StringID = '" + e.Row["StringID"].ToString() + "'";
                SqlCommand cmdUpdate = new SqlCommand(strSQL, sqlConn);
                cmdUpdate.Parameters.AddWithValue("@Lang2", e.Row["Lang2"].ToString());
                cmdUpdate.Parameters.AddWithValue("@Lang3", e.Row["Lang3"].ToString());
                cmdUpdate.Parameters.AddWithValue("@Lang4", e.Row["Lang4"].ToString());
                cmdUpdate.ExecuteNonQuery();
                isModified = true;
            }
            catch (Exception) { }
        }
        private SqlConnection sqlConn;
        private void LangSettings_Load(object sender, EventArgs e)
        {
            Globals.SetDefaultFont(this);
            isLoading = true;
            sqlConn = new SqlConnection(Globals.strVISConnection);
            sqlConn.Open();
            LoadLanguage();
            isLoading = false;
            isModified = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LangSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isModified)
                this.DialogResult = DialogResult.OK;
            else this.DialogResult = DialogResult.Cancel;
        }
    }
}

