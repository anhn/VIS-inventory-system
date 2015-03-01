using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Data;

using System.Data;
using System.Data.SqlClient;

using Inventory.Properties;
namespace Inventory
{
    /// <summary>
    /// Summary description for UserGroupSecur.
    /// </summary>
    public class UserGroupSecur : DevExpress.XtraEditors.XtraForm
    {
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private PanelControl panelControl1;
        private SimpleButton simpleButton1;
        private DevExpress.XtraTab.XtraTabPage tabGroup;
        private DevExpress.XtraTab.XtraTabPage tabDepartment;
        private DevExpress.XtraTab.XtraTabPage tabUser;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtUsernameInput;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtPhoneNoInput;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtEmailInput;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private SplitterControl splitterControl1;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.GridControl gridControl5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit5;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit6;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmbFunctionSelect;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmbUserSelect;
        private DevExpress.XtraTab.XtraTabPage tabModules;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl gridControl6;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox5;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit7;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit8;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit9;
        private DevExpress.XtraGrid.GridControl gridControl7;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox6;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit10;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit11;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit12;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmbModuleSelect;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraGrid.GridControl gridControl8;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox7;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit13;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit14;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit15;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtPasswordInput;
        
        private IContainer components;

        public UserGroupSecur()
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
        private SqlConnection sqlConn;

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tabGroup = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.cmbUserSelect = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.cmbFunctionSelect = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl5 = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tabModules = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl7 = new DevExpress.XtraGrid.GridControl();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemComboBox6 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemTextEdit10 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit11 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit12 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.cmbModuleSelect = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.txtUsernameInput = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtPhoneNoInput = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtEmailInput = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tabDepartment = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabUser = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.txtPasswordInput = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl6 = new DevExpress.XtraGrid.GridControl();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemComboBox5 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemTextEdit7 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit8 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit9 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl8 = new DevExpress.XtraGrid.GridControl();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemComboBox7 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemTextEdit13 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit14 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit15 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tabGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFunctionSelect)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit6)).BeginInit();
            this.tabModules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbModuleSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsernameInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNoInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailInput)).BeginInit();
            this.tabDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tabUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit9)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit15)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.defaultLookAndFeel1.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(815, 44);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Text = "panelControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strExit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.simpleButton1.Location = new System.Drawing.Point(7, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(119, 33);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = global::Inventory.Properties.Settings.Default.strExit;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tabGroup
            // 
            this.tabGroup.Controls.Add(this.xtraTabControl2);
            this.tabGroup.Controls.Add(this.splitterControl1);
            this.tabGroup.Controls.Add(this.gridControl3);
            this.tabGroup.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strGroup", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabGroup.Name = "tabGroup";
            this.tabGroup.Size = new System.Drawing.Size(806, 370);
            this.tabGroup.Text = global::Inventory.Properties.Settings.Default.strGroup;
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl2.Location = new System.Drawing.Point(0, 144);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl2.Size = new System.Drawing.Size(806, 226);
            this.xtraTabControl2.TabIndex = 3;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.tabModules});
            this.xtraTabControl2.Text = "xtraTabControl2";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl4);
            this.xtraTabPage1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strGroupUser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(797, 195);
            this.xtraTabPage1.Text = global::Inventory.Properties.Settings.Default.strGroupUser;
            // 
            // gridControl4
            // 
            this.gridControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl4.EmbeddedNavigator.Name = "";
            this.gridControl4.Location = new System.Drawing.Point(0, 0);
            this.gridControl4.MainView = this.gridView4;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox2,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit1,
            this.cmbUserSelect,
            this.cmbFunctionSelect});
            this.gridControl4.Size = new System.Drawing.Size(797, 197);
            this.gridControl4.TabIndex = 2;
            this.gridControl4.UseEmbeddedNavigator = true;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gridControl4;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            this.repositoryItemComboBox2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Mask.EditMask = "[a-zA-Z_0-9]{1,}";
            this.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Mask.EditMask = "([(][0-9]+[)])?[0-9]+";
            this.repositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "[a-zA-Z_0-9]+[@][a-zA-Z_0-9]+[.][a-zA-Z_0-9]+([.][a-zA-Z0-9]+)*";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // cmbUserSelect
            // 
            this.cmbUserSelect.AutoHeight = false;
            this.cmbUserSelect.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUserSelect.Name = "cmbUserSelect";
            this.cmbUserSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // cmbFunctionSelect
            // 
            this.cmbFunctionSelect.AutoHeight = false;
            this.cmbFunctionSelect.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFunctionSelect.Name = "cmbFunctionSelect";
            this.cmbFunctionSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl5);
            this.xtraTabPage2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strGroupUserRole", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(797, 195);
            this.xtraTabPage2.Text = global::Inventory.Properties.Settings.Default.strGroupUserRole;
            // 
            // gridControl5
            // 
            this.gridControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl5.EmbeddedNavigator.Name = "";
            this.gridControl5.Location = new System.Drawing.Point(0, 0);
            this.gridControl5.MainView = this.gridView5;
            this.gridControl5.Name = "gridControl5";
            this.gridControl5.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox4,
            this.repositoryItemTextEdit4,
            this.repositoryItemTextEdit5,
            this.repositoryItemTextEdit6});
            this.gridControl5.Size = new System.Drawing.Size(797, 197);
            this.gridControl5.TabIndex = 3;
            this.gridControl5.UseEmbeddedNavigator = true;
            this.gridControl5.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.gridControl5;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemComboBox4
            // 
            this.repositoryItemComboBox4.Name = "repositoryItemComboBox4";
            this.repositoryItemComboBox4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Mask.EditMask = "[a-zA-Z_0-9]{1,}";
            this.repositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // repositoryItemTextEdit5
            // 
            this.repositoryItemTextEdit5.AutoHeight = false;
            this.repositoryItemTextEdit5.Mask.EditMask = "([(][0-9]+[)])?[0-9]+";
            this.repositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit5.Name = "repositoryItemTextEdit5";
            // 
            // repositoryItemTextEdit6
            // 
            this.repositoryItemTextEdit6.AutoHeight = false;
            this.repositoryItemTextEdit6.Mask.EditMask = "[a-zA-Z_0-9]+[@][a-zA-Z_0-9]+[.][a-zA-Z_0-9]+([.][a-zA-Z0-9]+)*";
            this.repositoryItemTextEdit6.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit6.Name = "repositoryItemTextEdit6";
            // 
            // tabModules
            // 
            this.tabModules.Controls.Add(this.gridControl7);
            this.tabModules.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strGroupModules", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabModules.Name = "tabModules";
            this.tabModules.Size = new System.Drawing.Size(797, 197);
            this.tabModules.Text = global::Inventory.Properties.Settings.Default.strGroupModules;
            // 
            // gridControl7
            // 
            this.gridControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl7.EmbeddedNavigator.Name = "";
            this.gridControl7.Location = new System.Drawing.Point(0, 0);
            this.gridControl7.MainView = this.gridView7;
            this.gridControl7.Name = "gridControl7";
            this.gridControl7.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox6,
            this.repositoryItemTextEdit10,
            this.repositoryItemTextEdit11,
            this.repositoryItemTextEdit12,
            this.cmbModuleSelect});
            this.gridControl7.Size = new System.Drawing.Size(797, 197);
            this.gridControl7.TabIndex = 4;
            this.gridControl7.UseEmbeddedNavigator = true;
            this.gridControl7.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView7});
            // 
            // gridView7
            // 
            this.gridView7.GridControl = this.gridControl7;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemComboBox6
            // 
            this.repositoryItemComboBox6.Name = "repositoryItemComboBox6";
            this.repositoryItemComboBox6.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryItemTextEdit10
            // 
            this.repositoryItemTextEdit10.AutoHeight = false;
            this.repositoryItemTextEdit10.Mask.EditMask = "[a-zA-Z_0-9]{1,}";
            this.repositoryItemTextEdit10.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit10.Name = "repositoryItemTextEdit10";
            // 
            // repositoryItemTextEdit11
            // 
            this.repositoryItemTextEdit11.AutoHeight = false;
            this.repositoryItemTextEdit11.Mask.EditMask = "([(][0-9]+[)])?[0-9]+";
            this.repositoryItemTextEdit11.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit11.Name = "repositoryItemTextEdit11";
            // 
            // repositoryItemTextEdit12
            // 
            this.repositoryItemTextEdit12.AutoHeight = false;
            this.repositoryItemTextEdit12.Mask.EditMask = "[a-zA-Z_0-9]+[@][a-zA-Z_0-9]+[.][a-zA-Z_0-9]+([.][a-zA-Z0-9]+)*";
            this.repositoryItemTextEdit12.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit12.Name = "repositoryItemTextEdit12";
            // 
            // cmbModuleSelect
            // 
            this.cmbModuleSelect.AutoHeight = false;
            this.cmbModuleSelect.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbModuleSelect.Name = "cmbModuleSelect";
            this.cmbModuleSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(0, 138);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(806, 6);
            this.splitterControl1.TabIndex = 2;
            this.splitterControl1.TabStop = false;
            // 
            // gridControl3
            // 
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl3.EmbeddedNavigator.Name = "";
            this.gridControl3.Location = new System.Drawing.Point(0, 0);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox3,
            this.txtUsernameInput,
            this.txtPhoneNoInput,
            this.txtEmailInput});
            this.gridControl3.Size = new System.Drawing.Size(806, 138);
            this.gridControl3.TabIndex = 1;
            this.gridControl3.UseEmbeddedNavigator = true;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            this.repositoryItemComboBox3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // txtUsernameInput
            // 
            this.txtUsernameInput.AutoHeight = false;
            this.txtUsernameInput.Mask.EditMask = "[a-zA-Z_0-9]{1,}";
            this.txtUsernameInput.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtUsernameInput.Name = "txtUsernameInput";
            // 
            // txtPhoneNoInput
            // 
            this.txtPhoneNoInput.AutoHeight = false;
            this.txtPhoneNoInput.Mask.EditMask = "([(][0-9]+[)])?[0-9]+";
            this.txtPhoneNoInput.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPhoneNoInput.Name = "txtPhoneNoInput";
            // 
            // txtEmailInput
            // 
            this.txtEmailInput.AutoHeight = false;
            this.txtEmailInput.Mask.EditMask = "[a-zA-Z_0-9]+[@][a-zA-Z_0-9]+[.][a-zA-Z_0-9]+([.][a-zA-Z0-9]+)*";
            this.txtEmailInput.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmailInput.Name = "txtEmailInput";
            // 
            // tabDepartment
            // 
            this.tabDepartment.Controls.Add(this.gridControl2);
            this.tabDepartment.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strDepartment", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabDepartment.Name = "tabDepartment";
            this.tabDepartment.Size = new System.Drawing.Size(806, 370);
            this.tabDepartment.Text = global::Inventory.Properties.Settings.Default.strDepartment;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.EmbeddedNavigator.Name = "";
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(806, 370);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.UseEmbeddedNavigator = true;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.gridControl1);
            this.tabUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strUser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabUser.Name = "tabUser";
            this.tabUser.Size = new System.Drawing.Size(806, 370);
            this.tabUser.Text = global::Inventory.Properties.Settings.Default.strUser;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.txtPasswordInput});
            this.gridControl1.Size = new System.Drawing.Size(806, 370);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.Sorted = true;
            this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // txtPasswordInput
            // 
            this.txtPasswordInput.AutoHeight = false;
            this.txtPasswordInput.Name = "txtPasswordInput";
            this.txtPasswordInput.PasswordChar = '*';
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strUser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 44);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabUser;
            this.xtraTabControl1.Size = new System.Drawing.Size(815, 401);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabUser,
            this.tabDepartment,
            this.tabGroup,
            this.xtraTabPage3,
            this.xtraTabPage4});
            this.xtraTabControl1.Text = global::Inventory.Properties.Settings.Default.strUser;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.gridControl6);
            this.xtraTabPage3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strModules", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(806, 370);
            this.xtraTabPage3.Text = global::Inventory.Properties.Settings.Default.strModules;
            // 
            // gridControl6
            // 
            this.gridControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl6.EmbeddedNavigator.Name = "";
            this.gridControl6.Location = new System.Drawing.Point(0, 0);
            this.gridControl6.MainView = this.gridView6;
            this.gridControl6.Name = "gridControl6";
            this.gridControl6.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox5,
            this.repositoryItemTextEdit7,
            this.repositoryItemTextEdit8,
            this.repositoryItemTextEdit9});
            this.gridControl6.Size = new System.Drawing.Size(806, 370);
            this.gridControl6.TabIndex = 2;
            this.gridControl6.UseEmbeddedNavigator = true;
            this.gridControl6.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView6});
            // 
            // gridView6
            // 
            this.gridView6.GridControl = this.gridControl6;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemComboBox5
            // 
            this.repositoryItemComboBox5.Name = "repositoryItemComboBox5";
            this.repositoryItemComboBox5.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryItemTextEdit7
            // 
            this.repositoryItemTextEdit7.AutoHeight = false;
            this.repositoryItemTextEdit7.Mask.EditMask = "[a-zA-Z_0-9]{1,}";
            this.repositoryItemTextEdit7.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit7.Name = "repositoryItemTextEdit7";
            // 
            // repositoryItemTextEdit8
            // 
            this.repositoryItemTextEdit8.AutoHeight = false;
            this.repositoryItemTextEdit8.Mask.EditMask = "([(][0-9]+[)])?[0-9]+";
            this.repositoryItemTextEdit8.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit8.Name = "repositoryItemTextEdit8";
            // 
            // repositoryItemTextEdit9
            // 
            this.repositoryItemTextEdit9.AutoHeight = false;
            this.repositoryItemTextEdit9.Mask.EditMask = "[a-zA-Z_0-9]+[@][a-zA-Z_0-9]+[.][a-zA-Z_0-9]+([.][a-zA-Z0-9]+)*";
            this.repositoryItemTextEdit9.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit9.Name = "repositoryItemTextEdit9";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.gridControl8);
            this.xtraTabPage4.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strFunctions", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(806, 370);
            this.xtraTabPage4.Text = global::Inventory.Properties.Settings.Default.strFunctions;
            // 
            // gridControl8
            // 
            this.gridControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl8.EmbeddedNavigator.Name = "";
            this.gridControl8.Location = new System.Drawing.Point(0, 0);
            this.gridControl8.MainView = this.gridView8;
            this.gridControl8.Name = "gridControl8";
            this.gridControl8.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox7,
            this.repositoryItemTextEdit13,
            this.repositoryItemTextEdit14,
            this.repositoryItemTextEdit15});
            this.gridControl8.Size = new System.Drawing.Size(806, 370);
            this.gridControl8.TabIndex = 3;
            this.gridControl8.UseEmbeddedNavigator = true;
            this.gridControl8.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView8});
            // 
            // gridView8
            // 
            this.gridView8.GridControl = this.gridControl8;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemComboBox7
            // 
            this.repositoryItemComboBox7.Name = "repositoryItemComboBox7";
            this.repositoryItemComboBox7.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryItemTextEdit13
            // 
            this.repositoryItemTextEdit13.AutoHeight = false;
            this.repositoryItemTextEdit13.Mask.EditMask = "[a-zA-Z_0-9]{1,}";
            this.repositoryItemTextEdit13.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit13.Name = "repositoryItemTextEdit13";
            // 
            // repositoryItemTextEdit14
            // 
            this.repositoryItemTextEdit14.AutoHeight = false;
            this.repositoryItemTextEdit14.Mask.EditMask = "([(][0-9]+[)])?[0-9]+";
            this.repositoryItemTextEdit14.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit14.Name = "repositoryItemTextEdit14";
            // 
            // repositoryItemTextEdit15
            // 
            this.repositoryItemTextEdit15.AutoHeight = false;
            this.repositoryItemTextEdit15.Mask.EditMask = "[a-zA-Z_0-9]+[@][a-zA-Z_0-9]+[.][a-zA-Z_0-9]+([.][a-zA-Z0-9]+)*";
            this.repositoryItemTextEdit15.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit15.Name = "repositoryItemTextEdit15";
            // 
            // UserGroupSecur
            // 
            this.ClientSize = new System.Drawing.Size(815, 445);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "UserGroupSecur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = global::Inventory.Properties.Settings.Default.strUser_Group_security;
            this.Load += new System.EventHandler(this.UserGroupSecur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tabGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFunctionSelect)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit6)).EndInit();
            this.tabModules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbModuleSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsernameInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNoInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailInput)).EndInit();
            this.tabDepartment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tabUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit9)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit15)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        
        private void UserGroupSecur_Load(object sender, EventArgs e)
        {
            Globals.SetDefaultFont(this);
            sqlConn = new SqlConnection(Globals.strVISConnection);
            sqlConn.Open();
            LoadModuleFunctions();
            loadModules();
            LoadDepartment();
            LoadShop();
            LoadUserInform(sender, e);
            LoadDepartmentInform();
            LoadRoleInform();
            loadFunction();
            //loadGroupUserInform("d890509f-a261-490e-a9a2-4bc1e52d77e1");
            isLoading = false;
            
        }

        DataTable tblUser = new DataTable();
        DataTable tblDepart = new DataTable();
        DataTable tblRole = new DataTable();
        DataTable tblGroupUser = new DataTable();
        DataTable tblGroupUserRole = new DataTable();
        DataTable tblModuleFunctions = new DataTable();
        DataTable tblModules = new DataTable();
        DataTable tblGroupModules = new DataTable();
        DataTable tblFunctions = new DataTable();

        private bool isLoading = true;
        private bool isAfterAddnew = false;
        private bool isAfterDepAddnew = false;
        private bool isAfterRoleAddNew = false;
        private bool isAfterGroupUserAddNew = false;
        private bool isAfterGroupUserRoleAddNew = false;
        private bool isAfterModueAddnew = false;
        private bool isAfterGroupModuleAddnew = false;
        private bool isAfterFunctionAddnew = false;
        private bool isCanDelete = false;
        private bool isFunctionCanDelete = false;

        DevExpress.XtraGrid.Views.Grid.GridView grdUser;
        DevExpress.XtraGrid.Views.Grid.GridView grdDepartment;
        DevExpress.XtraGrid.Views.Grid.GridView grdRole;
        DevExpress.XtraGrid.Views.Grid.GridView grdGroupUser;
        DevExpress.XtraGrid.Views.Grid.GridView grdGroupUserRole;
        DevExpress.XtraGrid.Views.Grid.GridView grdModules;
        DevExpress.XtraGrid.Views.Grid.GridView grdGroupModules;
        DevExpress.XtraGrid.Views.Grid.GridView grdFunctions;

        private string CurrentRoleID = "";
        private void LoadDepartmentInform()
        {
            try
            {
                string strSQL = "SELECT * FROM t_Department";

                SqlDataAdapter adapter = new SqlDataAdapter(strSQL, sqlConn);
                tblDepart = new DataTable();
                adapter.Fill(tblDepart);
                gridControl2.DataSource = tblDepart;
                grdDepartment = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl2.Views[0];
                grdDepartment.Columns["DepartmentID"].Visible = false;
                grdDepartment.Columns["DepartmentName"].Caption = Settings.Default.strDepartmentName;
                grdDepartment.Columns["ViewStatus"].Caption = Settings.Default.strViewStatus;
                //grdDepartment.Columns["DepartmentID"].Caption = Settings.Default

                grdDepartment.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(grdDepartment_ValidateRow);
                tblDepart.RowChanged += new DataRowChangeEventHandler(tblDepart_RowChanged);
                tblDepart.RowDeleting += new DataRowChangeEventHandler(tblDepart_RowDeleting);
                tblDepart.TableNewRow += new DataTableNewRowEventHandler(tblDepart_TableNewRow);
            }
            catch (Exception) { }
        }

        private void loadModules()
        {
            try
            {
                string strSQL = "SELECT * FROM Module";

                SqlDataAdapter adapter = new SqlDataAdapter(strSQL, sqlConn);
                tblModules.Clear();
                adapter.Fill(tblModules);

                gridControl6.DataSource = tblModules;
                grdModules = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl6.Views[0];
                grdModules.Columns["ModuleID"].Visible = false;
                grdModules.Columns["ModuleName"].Caption = Settings.Default.strModuleName;

                grdModules.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(grdModules_ValidateRow);

                tblModules.RowChanged += new DataRowChangeEventHandler(tblModules_RowChanged);
                tblModules.RowDeleting += new DataRowChangeEventHandler(tblModules_RowDeleting);
                tblModules.TableNewRow += new DataTableNewRowEventHandler(tblModules_TableNewRow);
                tblModules.RowDeleted += new DataRowChangeEventHandler(tblModules_RowDeleted);
                tblModules.AcceptChanges();
                RefreshModuleCmb();
                
            }
            catch (Exception) { }
        }
        private void RefreshModuleCmb()
        {
            cmbModuleSelect.Items.Clear();
            foreach (DataRow dtr in tblModules.Rows)
            {
                cmbModuleSelect.Items.Add(dtr["ModuleName"].ToString());
            }
        }
        private void loadFunction()
        {
            try
            {
                string strSQL = "SELECT FunctionID, FunctionName, ModuleName, Notes FROM t_ModuleFunctions, Module Where t_ModuleFunctions.ModuleID = Module.ModuleID";

                SqlDataAdapter adapter = new SqlDataAdapter(strSQL, sqlConn);
                tblFunctions.Clear();
                adapter.Fill(tblFunctions);

                gridControl8.DataSource = tblFunctions;
                grdFunctions = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl8.Views[0];
                grdFunctions.Columns["FunctionID"].Visible = false;

                grdFunctions.Columns["ModuleName"].ColumnEdit = cmbModuleSelect;
                grdFunctions.Columns["FunctionName"].Caption = Settings.Default.strFunctionName;
                grdFunctions.Columns["ModuleName"].Caption = Settings.Default.strModuleName;
                grdFunctions.Columns["Notes"].Caption = Settings.Default.strNotes;

                RefreshModuleCmb();

                tblFunctions.RowChanged += new DataRowChangeEventHandler(tblFunctions_RowChanged);
                tblFunctions.RowDeleting += new DataRowChangeEventHandler(tblFunctions_RowDeleting);
                tblFunctions.RowDeleted += new DataRowChangeEventHandler(tblFunctions_RowDeleted);
                tblFunctions.TableNewRow += new DataTableNewRowEventHandler(tblFunctions_TableNewRow);
                grdFunctions.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(grdFunctions_ValidateRow);
            }
            catch (Exception) { }
        }

        void grdFunctions_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            // check data
            if (isLoading) return;
            if (((DataRowView)e.Row)["FunctionName"].ToString().Trim() == "")
            {
                MessageBox.Show("Function name cannot null!");
                e.Valid = false;
                return;
            }
            if (((DataRowView)e.Row)["ModuleName"].ToString().Trim() == "")
            {
                MessageBox.Show("Module name cannot null!");
                e.Valid = false;
                return;
            }
            DataRow Row = ((DataRowView)e.Row).Row;
            DataRow[] dtr = tblFunctions.Select("FunctionName = '" + Row["FunctionName"].ToString() + "'");

            if (dtr.Length > 0 && dtr[0]["FunctionID"] != Row["FunctionID"])
            {
                MessageBox.Show("Function name is an unique value");
                e.Valid = false;
                return;
            }
        }

        void tblFunctions_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            // add new data
            // new row
            if (isLoading) return;
            isAfterFunctionAddnew = true;
        }

        void tblFunctions_RowDeleted(object sender, DataRowChangeEventArgs e)
        {
            // check for delete data
            if (!isFunctionCanDelete) tblFunctions.RejectChanges();
        }

        void tblFunctions_RowDeleting(object sender, DataRowChangeEventArgs e)
        {
            // delete data
            try
            {
                if (!canDeleteFunction(e.Row["FunctionID"].ToString()))
                {
                    MessageBox.Show("This function is refered by some item. You cannot delete it!");
                    isFunctionCanDelete = false;
                    return;
                }
                isFunctionCanDelete = true;
                string strSQL = "DELETE FROM t_ModuleFunctions WHERE FunctionID = '" + e.Row["FunctionID"].ToString() + "'";
                SqlCommand cmdUpdate = new SqlCommand(strSQL, sqlConn);
                cmdUpdate.ExecuteNonQuery();
                //LoadModuleFunctions();
            }
            catch (Exception oExc)
            {
                MessageBox.Show(String.Format("Can't delete the selected module-function, {0}", oExc.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void tblFunctions_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            //update data
            if (isLoading) return;
            try
            {
                DataRow Row = e.Row;
                string strSQL = "";
                DataRow[] dtr = tblModules.Select("ModuleName = '" + Row["ModuleName"].ToString() + "'");
                string ModuleID = dtr[0]["ModuleID"].ToString();
                if (isAfterFunctionAddnew)
                {
                    strSQL = "INSERT INTO t_ModuleFunctions(FunctionName, ModuleID, Notes) values(@FunctionName, @ModuleID, @Notes)";
                    isAfterFunctionAddnew = false;
                }
                else
                    strSQL = "UPDATE t_ModuleFunctions SET FunctionName = @FunctionName, ModuleID = @ModuleID, Notes = @Notes WHERE FunctionID = '" + Row["FunctionID"].ToString() + "'";
                SqlCommand cmdUpdate = new SqlCommand(strSQL, sqlConn);
                cmdUpdate.Parameters.AddWithValue("@FunctionName", Row["FunctionName"].ToString());
                cmdUpdate.Parameters.AddWithValue("@ModuleID", ModuleID);
                cmdUpdate.Parameters.AddWithValue("@Notes", Row["Notes"].ToString());
                cmdUpdate.ExecuteNonQuery();
                //LoadModuleFunctions();

            }
            catch (Exception oExc) 
            {
                MessageBox.Show(String.Format("Can't insert or update the module-function, {0}", oExc.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        void tblModules_RowDeleted(object sender, DataRowChangeEventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");
            if (!isCanDelete) tblModules.RejectChanges();
        }

        void tblModules_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            // new row
            if (isLoading) return;
            isAfterModueAddnew = true;
        }
        private bool canDeleteFunction(string FunctionID)
        {
            try
            {
                SqlDataReader dtReader;
                string strSQL = "SELECT * FROM t_ModuleFunctions WHERE FunctionID = '" + FunctionID + "'";
                SqlCommand cmdUpdate = new SqlCommand(strSQL, sqlConn);
                dtReader = cmdUpdate.ExecuteReader();
                if (dtReader.HasRows)
                {
                    dtReader.Close();
                    return false;
                }
                else
                {
                    dtReader.Close();
                    return true;
                }                
            }
            catch (Exception) { }
            return false;
        }
        private bool canDeleteModule(string ModuleID)
        {
            try
            {
                SqlDataReader dtReader;
                string strSQL = "SELECT * FROM t_ModuleFunctions WHERE ModuleID = '" + ModuleID + "'";
                SqlCommand cmdUpdate = new SqlCommand(strSQL, sqlConn);


                dtReader = cmdUpdate.ExecuteReader();
                if (dtReader.HasRows)
                {
                    dtReader.Close();
                    return false;
                }
                dtReader.Close();                

                strSQL = "SELECT * FROM RoleInModule WHERE ModuleID = '" + ModuleID + "'";
                cmdUpdate = new SqlCommand(strSQL, sqlConn);
                dtReader = cmdUpdate.ExecuteReader();
                if (dtReader.HasRows)
                {
                    dtReader.Close();
                    return false;
                }
                dtReader.Close();
                strSQL = "SELECT * FROM Resource WHERE ModuleID = '" + ModuleID + "'";
                cmdUpdate = new SqlCommand(strSQL, sqlConn);

                dtReader = cmdUpdate.ExecuteReader();
                if (dtReader.HasRows)
                {
                    dtReader.Close();
                    return false;
                }
                dtReader.Close();

                return true;
            }
            catch (Exception) { }
            return false;
        }
        void tblModules_RowDeleting(object sender, DataRowChangeEventArgs e)
        {
            // delete data           
            try
            {
                if (!canDeleteModule(e.Row["ModuleID"].ToString()))
                {
                    MessageBox.Show("This module is refered by some item. You cannot delete it!");
                    isCanDelete = false;
                    //tblModules.RejectChanges();
                    //gridControl6.RefreshDataSource();
                    //grdModules.RefreshData();
                    return;
                }
                isCanDelete = true;
                string strSQL = "DELETE FROM Module WHERE ModuleID = '" + e.Row["ModuleID"].ToString() + "'";
                SqlCommand cmdUpdate = new SqlCommand(strSQL, sqlConn);
                cmdUpdate.ExecuteNonQuery();
                RefreshModuleCmb();
            }
            catch (Exception oExc)
            {
                MessageBox.Show(String.Format("Can't delete the selected module, {0}", oExc.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void tblModules_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            //update data
            if (isLoading) return;
            try
            {
                DataRow Row = e.Row;
                string strSQL = "";
                
                if (isAfterModueAddnew)
                {
                    strSQL = "INSERT INTO Module(ModuleName) values(@ModuleName)";
                    isAfterModueAddnew = false;
                }
                else
                    strSQL = "UPDATE Module SET ModuleName = @ModuleName WHERE ModuleID = '" + Row["ModuleID"].ToString() + "'";
                SqlCommand cmdUpdate = new SqlCommand(strSQL, sqlConn);
                cmdUpdate.Parameters.AddWithValue("@ModuleName", Row["ModuleName"].ToString());
                cmdUpdate.ExecuteNonQuery();
                RefreshModuleCmb();
            }
            catch (Exception oExc)
            {
                MessageBox.Show(String.Format("Can't insert or update the module, {0}", oExc.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void grdModules_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //check data
            if (isLoading) return;
            if (((DataRowView)e.Row)["ModuleName"].ToString().Trim() == "")
            {
                MessageBox.Show("Module name cannot null!");
                e.Valid = false;
                return;
            }
            DataRow Row = ((DataRowView)e.Row).Row;
            DataRow[] dtr = tblModules.Select("ModuleName = '" + Row["ModuleName"].ToString() + "'");

            if (dtr.Length > 0 && dtr[0]["ModuleID"] != Row["ModuleID"])
            {
                MessageBox.Show("Module name is an unique value");
                e.Valid = false;
                return;
            }
            
        }
        private void LoadModuleFunctions()
        {
            try
            {
                string strSQL = "SELECT * FROM t_ModuleFunctions";

                SqlDataAdapter adapter = new SqlDataAdapter(strSQL, sqlConn);
                tblModuleFunctions.Clear();
                adapter.Fill(tblModuleFunctions);
                
            }
            catch (Exception) { }
        }

        private void loadGroupUserRoleInform(string RoleID)
        {
            isLoading = true;
            try
            {
                
                CurrentRoleID = RoleID;
                string strSQL = "SELECT t_RoleFunction.RoleFunctionID, t_ModuleFunctions.FunctionID, t_ModuleFunctions.FunctionName  FROM t_RoleFunction, t_ModuleFunctions"
                        + " WHERE t_RoleFunction.RoleID = '" + RoleID + "' and t_RoleFunction.FunctionID = t_ModuleFunctions.FunctionID";
                    

                SqlDataAdapter adapter = new SqlDataAdapter(strSQL, sqlConn);
                tblGroupUserRole.Clear();
                adapter.Fill(tblGroupUserRole);
                gridControl5.DataSource = tblGroupUserRole;
                grdGroupUserRole = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl5.Views[0];
                grdGroupUserRole.Columns["FunctionID"].Visible = false;
                grdGroupUserRole.Columns["RoleFunctionID"].Visible = false;
                grdGroupUserRole.Columns["FunctionName"].Caption = Settings.Default.strFunctionName; ;

                tblGroupUserRole.RowChanged += new DataRowChangeEventHandler(tblGroupUserRole_RowChanged);
                tblGroupUserRole.RowDeleting += new DataRowChangeEventHandler(tblGroupUserRole_RowDeleting);
                tblGroupUserRole.TableNewRow += new DataTableNewRowEventHandler(tblGroupUserRole_TableNewRow);


                grdGroupUserRole.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(grdGroupUserRole_ValidateRow);
                // load User into combobox
                cmbFunctionSelect.Items.Clear();
                LoadModuleFunctions();
                foreach (DataRow dtr in tblModuleFunctions.Rows)
                {
                    cmbFunctionSelect.Items.Add(dtr["FunctionName"].ToString());
                }

                grdGroupUserRole.Columns["FunctionName"].ColumnEdit = cmbFunctionSelect;
                
            }
            catch (Exception) { }
            isLoading = false;
        }
        private void loadGroupModuleInform(string RoleID)
        {
            isLoading = true;
            try
            {

                CurrentRoleID = RoleID;
                string strSQL = "SELECT RoleInModule.RoleID, RoleInModule.ModuleID, Module.ModuleName  FROM RoleInModule, Module"
                        + " WHERE RoleID = '" + RoleID + "' and RoleInModule.ModuleID = Module.ModuleID";


                SqlDataAdapter adapter = new SqlDataAdapter(strSQL, sqlConn);
                tblGroupModules.Clear();
                adapter.Fill(tblGroupModules);
                gridControl7.DataSource = tblGroupModules;
                grdGroupModules = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl7.Views[0];
                grdGroupModules.Columns["RoleID"].Visible = false;
                grdGroupModules.Columns["ModuleID"].Visible = false;
                grdGroupModules.Columns["ModuleName"].Caption = Settings.Default.strModuleName;

                grdGroupModules.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(grdGroupModules_ValidateRow);
                tblGroupModules.RowDeleting += new DataRowChangeEventHandler(tblGroupModules_RowDeleting);
                tblGroupModules.RowChanged += new DataRowChangeEventHandler(tblGroupModules_RowChanged);
                tblGroupModules.TableNewRow += new DataTableNewRowEventHandler(tblGroupModules_TableNewRow);

                // load User into combobox
                cmbModuleSelect.Items.Clear();
                RefreshModuleCmb();
                grdGroupModules.Columns["ModuleName"].ColumnEdit = cmbModuleSelect;

            }
            catch (Exception) { }
            isLoading = false;
        }

        void tblGroupModules_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            // add new data
            if (isLoading) return;
            isAfterGroupModuleAddnew = true;
        }

        void tblGroupModules_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            // update data
            if (isLoading) return;
            try
            {
                DataRow Row = e.Row;
                string strSQL = "";
                //get FunctionID from UserName
                DataRow[] dtr = tblModules.Select("ModuleName = '" + Row["ModuleName"].ToString() + "'");
                string ModuleID = dtr[0]["ModuleID"].ToString();
                if (isAfterGroupModuleAddnew)
                {
                    strSQL = "INSERT INTO RoleInModule(RoleID, ModuleID) values('" + CurrentRoleID + "', '" + ModuleID + "')";
                    isAfterGroupModuleAddnew = false;
                }
                else
                    strSQL = "UPDATE RoleInModule SET ModuleID = '" + ModuleID + "' WHERE RoleID = '" + Row["RoleID"].ToString() + "' and ModuleID = '" + Row["ModuleID"].ToString() + "'";
                SqlCommand cmdUpdate = new SqlCommand(strSQL, sqlConn);
                cmdUpdate.ExecuteNonQuery();

            }
            catch (Exception oExc) 
            {
                MessageBox.Show(String.Format("Can't insert or update the role-module, {0}", oExc.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void tblGroupModules_RowDeleting(object sender, DataRowChangeEventArgs e)
        {
            // delete data
            try
            {
                string strSQL = "DELETE FROM RoleInModule WHERE RoleID = '" + e.Row["RoleID"].ToString() + "' and ModuleID ='" + e.Row["ModuleID"].ToString() + "'";
                SqlCommand cmdUpdate = new SqlCommand(strSQL, sqlConn);
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception oExc) 
            {
                MessageBox.Show(String.Format("Can't delete the selected role-module, {0}", oExc.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void grdGroupModules_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (isLoading) return;
            if (((DataRowView)e.Row)["ModuleName"].ToString().Trim() == "")
            {
                MessageBox.Show("Module name cannot null!");
                e.Valid = false;
                return;
            }
            DataRow Row = ((DataRowView)e.Row).Row;
            DataRow[] dtr = tblGroupModules.Select("ModuleName = '" + Row["ModuleName"].ToString() + "'");

            if (dtr.Length > 0 && !(dtr[0]["RoleID"] == Row["RoleID"] && dtr[0]["ModuleID"] == Row["ModuleID"]))
            {
                MessageBox.Show("Module name is an unique value");
                e.Valid = false;
                return;
            }
        }
        void grdGroupUserRole_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (isLoading) return;
            if (((DataRowView)e.Row)["FunctionName"].ToString().Trim() == "")
            {
                MessageBox.Show("Function name cannot null!");
                e.Valid = false;
                return;
            }
            DataRow Row = ((DataRowView)e.Row).Row;
            DataRow[] dtr = tblGroupUserRole.Select("FunctionName = '" + Row["FunctionName"].ToString() + "'");

            if (dtr.Length > 0 && dtr[0]["RoleFunctionID"] != Row["RoleFunctionID"])
            {
                MessageBox.Show("Function name is an unique value");                
                
                e.Valid = false;
                return;
            }
        }

        void tblGroupUserRole_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            // add new data
            if (isLoading) return;
            isAfterGroupUserRoleAddNew = true;
        }

        void tblGroupUserRole_RowDeleting(object sender, DataRowChangeEventArgs e)
        {
            // delete data
            try
            {
                string strSQL = "DELETE FROM t_RoleFunction WHERE RoleFunctionID = '" + e.Row["RoleFunctionID"].ToString() + "'";
                SqlCommand cmdUpdate = new SqlCommand(strSQL, sqlConn);
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception oExc) 
            {
                MessageBox.Show(String.Format("Can't delete the selected group, {0}", oExc.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void tblGroupUserRole_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            // update data
            if (isLoading) return;
            try
            {
                DataRow Row = e.Row;
                string strSQL = "";
                //get FunctionID from UserName
                DataRow[] dtr = tblModuleFunctions.Select("FunctionName = '" + Row["FunctionName"].ToString() + "'");
                string FunctionID = dtr[0]["FunctionID"].ToString();
                if (isAfterGroupUserRoleAddNew)
                {
                    strSQL = "INSERT INTO t_RoleFunction(RoleID, FunctionID) values('" + CurrentRoleID + "', '" + FunctionID + "')";
                    isAfterGroupUserRoleAddNew = false;
                }
                else
                    strSQL = "UPDATE t_RoleFunction SET FunctionID = '" + FunctionID + "' WHERE RoleFunctionID = '" + Row["RoleFunctionID"].ToString() + "'";
                SqlCommand cmdUpdate = new SqlCommand(strSQL, sqlConn);
                cmdUpdate.ExecuteNonQuery();

            }
            catch (Exception oExc) 
            {
                MessageBox.Show(String.Format("Can't add or update the selected role-function, {0}", oExc.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadGroupUserInform(string RoleID)
        {
            isLoading = true;
            try
            {
                CurrentRoleID = RoleID;
                string strSQL = "SELECT t_RoleUser.RoleUserID, t_User.UserID, t_User.UserName  FROM t_RoleUser, t_User"
                        + " WHERE t_RoleUser.RoleID = '" + RoleID + "' and t_RoleUser.UserID = t_User.UserID";

                SqlDataAdapter adapter = new SqlDataAdapter(strSQL, sqlConn);
                tblGroupUser.Clear();
                adapter.Fill(tblGroupUser);
                gridControl4.DataSource = tblGroupUser;
                grdGroupUser = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl4.Views[0];
                grdGroupUser.Columns["UserID"].Visible = false;
                grdGroupUser.Columns["RoleUserID"].Visible = false;
                grdGroupUser.Columns["UserName"].Caption = Settings.Default.strUserName;

                grdGroupUser.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(grdGroupUser_ValidateRow);
                tblGroupUser.RowChanged += new DataRowChangeEventHandler(tblGroupUser_RowChanged);
                tblGroupUser.TableNewRow += new DataTableNewRowEventHandler(tblGroupUser_TableNewRow);
                tblGroupUser.RowDeleting += new DataRowChangeEventHandler(tblGroupUser_RowDeleting);

                // load User into combobox
                cmbUserSelect.Items.Clear();
                foreach (DataRow dtr in tblUser.Rows)
                {
                    cmbUserSelect.Items.Add(dtr["UserName"].ToString());
                }

                grdGroupUser.Columns["UserName"].ColumnEdit = cmbUserSelect;

            }
            catch (Exception) { }
            isLoading = false;

        }
        void tblGroupUser_RowDeleting(object sender, DataRowChangeEventArgs e)
        {
            // delete data
            try
            {
                string strSQL = "DELETE FROM t_RoleUser WHERE RoleUserID = '" + e.Row["RoleUserID"].ToString() + "'";
                SqlCommand cmdUpdate = new SqlCommand(strSQL, sqlConn);
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception oExc) 
            {
                MessageBox.Show(String.Format("Can't delete the selected role-user, {0}", oExc.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void tblGroupUser_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            if (isLoading) return;
            isAfterGroupUserAddNew = true;
        }

        void tblGroupUser_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (isLoading) return;
            try
            {
                DataRow Row = e.Row;
                string strSQL = "";
                //get UserID from UserName
                DataRow[] dtr = tblUser.Select("UserName = '" + Row["UserName"].ToString() + "'");
                string UserID = dtr[0]["UserID"].ToString();
                if (isAfterGroupUserAddNew)
                {
                    strSQL = "INSERT INTO t_RoleUser(RoleID, UserID) values('" + CurrentRoleID + "', '" + UserID + "')";
                    isAfterGroupUserAddNew = false;
                } else
                    strSQL = "UPDATE t_RoleUser SET UserID = '" + UserID + "' WHERE RoleUserID = '" + Row["RoleUserID"].ToString() + "'";
                SqlCommand cmdUpdate = new SqlCommand(strSQL, sqlConn);
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception oExc) 
            {
                MessageBox.Show(String.Format("Can't insert the role-user, {0}", oExc.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void grdGroupUser_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (isLoading) return;
            if (((DataRowView)e.Row)["UserName"].ToString().Trim() == "")
            {
                MessageBox.Show("User name cannot null!");
                e.Valid = false;
                return;
            }
            DataRow Row = ((DataRowView)e.Row).Row;
            DataRow[] dtr = tblGroupUser.Select("UserName = '" + Row["UserName"].ToString() + "'");

            if (dtr.Length > 0 && dtr[0]["RoleUserID"] != Row["RoleUserID"])
            {
                MessageBox.Show("User name name is an unique value");                                
                e.Valid = false;
                return;
            }            
        }

        
        void tblDepart_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            if (isLoading) return;
            isAfterDepAddnew = true;
        }
        private void LoadRoleInform()
        {
            try
            {
                string strSQL = "SELECT * FROM t_Role";

                SqlDataAdapter adapter = new SqlDataAdapter(strSQL, sqlConn);
                tblRole.Clear();
                adapter.Fill(tblRole);
                gridControl3.DataSource = tblRole;
                grdRole = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl3.Views[0];
                grdRole.Columns["RoleID"].Visible = false;
                grdRole.Columns["RoleName"].Caption = Settings.Default.strRoleName;
                tblRole.RowChanged += new DataRowChangeEventHandler(tblRole_RowChanged);
                tblRole.RowDeleting += new DataRowChangeEventHandler(tblRole_RowDeleting);
                grdRole.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(grdRole_ValidateRow);
                tblRole.TableNewRow += new DataTableNewRowEventHandler(tblRole_TableNewRow);

                grdRole.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(grdRole_FocusedRowChanged);
            }
            catch (Exception) { }
        }

        void grdRole_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            //MessageBox.Show();
            string RoleID = ((DataRowView)grdRole.GetRow(e.FocusedRowHandle)).Row["RoleID"].ToString();
            
            loadGroupUserInform(RoleID);
            loadGroupUserRoleInform(RoleID);
            loadGroupModuleInform(RoleID);
            
        }

        void tblRole_RowChanging(object sender, DataRowChangeEventArgs e)
        {
            
        }

        void tblRole_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            if (isLoading) return;
            isAfterRoleAddNew = true;
        }
        // Kiem tra tinh hop le cua dong moi nhap vao
        void grdRole_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");
            //check here
            DataRow Row = ((DataRowView)e.Row).Row;

            if (Row["RoleName"].ToString() == "")
            {
                MessageBox.Show("Role name cannot null!");
                e.Valid = false;
                return;
            }
            //e.Valid = false;
            DataRow[] dtr = tblRole.Select("RoleName = '" + Row["RoleName"].ToString() + "'");

            if (dtr.Length > 0 && dtr[0]["RoleID"] != Row["RoleID"])
            {
                MessageBox.Show("Role name is an unique value");
                
                e.Valid = false;
                return;
            }
            
        }

        void tblRole_RowDeleting(object sender, DataRowChangeEventArgs e)
        {
            // delete data
            try
            {
                string strSQL = "DELETE FROM t_Role WHERE RoleID = '" + e.Row["RoleID"].ToString() + "'";
                SqlCommand cmdUpdate = new SqlCommand(strSQL, sqlConn);
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception oExc) 
            {
                MessageBox.Show(String.Format("Can't delete the selected role, {0}", oExc.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void tblRole_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            // update data
            if (isLoading) return;
            try
            {
                string strSQL = "";
                
                if (isAfterRoleAddNew)
                {
                    strSQL = "INSERT INTO t_Role(RoleName, Notes) values (@RoleName, @Notes)";                    
                    isAfterRoleAddNew = false;
                }
                else
                {
                    strSQL = "UPDATE t_Role SET RoleName = @RoleName, Notes = @Notes WHERE RoleID = '" + e.Row["RoleID"].ToString() + "'";

                }

                SqlCommand cmdUpdate = new SqlCommand(strSQL, sqlConn);
                cmdUpdate.Parameters.AddWithValue("@RoleName", e.Row["RoleName"].ToString());
                cmdUpdate.Parameters.AddWithValue("@Notes", e.Row["Notes"].ToString());               
                int i = cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception oExc) 
            {
                MessageBox.Show(String.Format("Can't insert or update the role, {0}", oExc.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void tblDepart_RowDeleting(object sender, DataRowChangeEventArgs e)
        {
            // delete here
            try
            {
                string strDeptID = e.Row["DepartmentID"].ToString();

                // Set department of all related users to null
                string strSQL = String.Format("Update t_User Set DepartmentID = Null WHERE DepartmentID = '{0}'", strDeptID);

                // Delete the department
                strSQL = strSQL + String.Format(";DELETE FROM t_Department WHERE DepartmentID = '{0}'", strDeptID);
                SqlCommand cmdUpdate = new SqlCommand(strSQL, sqlConn);
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception oExc) 
            {
                MessageBox.Show(String.Format("Can't delete the selected department, {0}", oExc.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void tblDepart_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            // change here
            if (isLoading) return;
            try
            {
                string strSQL = "";
                if (isAfterDepAddnew)
                {
                    strSQL = "INSERT INTO t_Department(DepartmentName, ViewStatus) values('" + e.Row["DepartmentName"] + "', '" + e.Row["ViewStatus"].ToString() + "')";
                    isAfterDepAddnew = false;
                }
                else
                    strSQL = "UPDATE t_Department SET DepartmentName = '" + e.Row["DepartmentName"] + "', ViewStatus = '" + e.Row["ViewStatus"].ToString() + "' " 
                            + " WHERE DepartmentID = '" + e.Row["DepartmentID"] + "'";

                SqlCommand cmdUpdate = new SqlCommand(strSQL, sqlConn);
                cmdUpdate.ExecuteNonQuery();
    
            }
            catch (Exception oExc) 
            {
                MessageBox.Show(String.Format("Can't delete the selected department, {0}", oExc.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       

        void grdDepartment_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //check here
            DataRow Row = ((DataRowView)e.Row).Row;
            //e.Valid = false;
            DataRow[] dtr = tblDepart.Select("DepartmentName = '" + Row["DepartmentName"].ToString() + "'");

            if (dtr.Length > 0 && dtr[0]["DepartmentID"] != Row["DepartmentID"])
            {
                MessageBox.Show("Department name is an unique value");
                
                e.Valid = false;
                return;
            }
            if (Row["DepartmentName"].ToString() == "")
            {
                e.Valid = false;
                return;
            }
        }

        private void LoadUserInform(object sender, EventArgs e)
        {
            // Add handle for these below events of user grid
            tblUser.RowChanged += new DataRowChangeEventHandler(tblUser_RowChanged);
            tblUser.TableNewRow += new DataTableNewRowEventHandler(tblUser_TableNewRow);            
            tblUser.RowDeleting += new DataRowChangeEventHandler(tblUser_RowDeleting);

            // Fill data into User table
            string strSQL = "SELECT UserID, UserName, Password, t_User.Address, PhoneNo," +
                            "(Select DepartmentName From t_Department Where t_User.DepartmentID = t_Department.DepartmentID) as DepartmentName, " +
                            "(Select ShopName From t_shop where t_User.ShopID = t_Shop.ShopID) as ShopName, " +
                            "EmailAddress, Notes, t_User.ViewStatus " +
                            "FROM t_User";

            SqlDataAdapter adapter = new SqlDataAdapter(strSQL, sqlConn);
            tblUser.Clear();
            adapter.Fill(tblUser);            
            gridControl1.DataSource = tblUser;
            grdUser = (DevExpress.XtraGrid.Views.Grid.GridView)gridControl1.Views[0];
            grdUser.Columns[0].Visible = false;
            
            // Set look&feel of the grid            
            grdUser.Columns["DepartmentName"].ColumnEdit = repositoryItemComboBox1;
            grdUser.Columns["DepartmentName"].Caption = Settings.Default.strDepartmentName;

            grdUser.Columns["ShopName"].ColumnEdit = repositoryItemComboBox3;
            grdUser.Columns["ShopName"].Caption = Settings.Default.strShopName;
            grdUser.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(grdUser_ValidateRow);

            grdUser.Columns["PhoneNo"].ColumnEdit = txtPhoneNoInput;
            grdUser.Columns["UserName"].ColumnEdit = txtUsernameInput;
            grdUser.Columns["UserName"].Caption = Settings.Default.strUserName;

            grdUser.Columns["EmailAddress"].ColumnEdit = txtEmailInput;
            grdUser.Columns["Password"].ColumnEdit = txtPasswordInput;
            grdUser.Columns["Password"].Caption = Settings.Default.strPassword;

            grdUser.Columns["PhoneNo"].Caption = Settings.Default.strPhoneNo;
            grdUser.Columns["Address"].Caption = Settings.Default.strAddress;
            grdUser.Columns["EmailAddress"].Caption = Settings.Default.strEmailAddress;
            grdUser.Columns["Notes"].Caption = Settings.Default.strNotes;
        }

        void tblUser_RowDeleting(object sender, DataRowChangeEventArgs e)
        {
            try
            {             
                string strSQL = "DELETE FROM t_User WHERE UserID = '" + e.Row["UserID"].ToString() + "'";
                SqlCommand cmdUpdate = new SqlCommand(strSQL, sqlConn);
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception oExc) 
            {
                MessageBox.Show(String.Format("Can't delete the selected user, {0}", oExc.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        

        void grdUser_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            
            DataRow Row = ((DataRowView)e.Row).Row;
            //e.Valid = false;
            DataRow[] dtr = tblUser.Select("Username = '" + Row["Username"].ToString() + "'");

            if (dtr.Length > 0 && dtr[0]["UserID"] != Row["UserID"])
            {
                MessageBox.Show("Username is an unique value");
                
                e.Valid = false;
                return;
            }
            if (!checkUserTabValues(Row))
            {
                e.Valid = false;
                return;
            }
        }

       
        
            
        void tblUser_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            if (isLoading) return;
            isAfterAddnew = true;
            
        }
        private bool checkUserTabValues(DataRow Row)
        {
            try
            {
                DataRow[] dtr;
                if (Row["Username"].ToString().Trim() == "")
                {
                    MessageBox.Show("Username cannot null");
                    dtr = tblUser.Select("UserID = '" + Row["UserID"].ToString() + "'");

                    Row["Username"] = dtr[0]["Username"];
                    return false;
                }
                if (Row["DepartmentName"].ToString().Trim() == "")
                {
                    MessageBox.Show("Department name cannot null");
                    dtr = tblUser.Select("UserID = '" + Row["UserID"] + "'");
                    Row["DepartmentName"] = dtr[0]["DepartmentName"];
                    return false;
                }
                if (Row["ShopName"].ToString().Trim() == "")
                {
                    MessageBox.Show("Shop name cannot null");
                    dtr = tblUser.Select("UserID = '" + Row["UserID"] + "'");
                    Row["ShopName"] = dtr[0]["ShopName"];
                    return false;
                }
                return true;
            }
            catch (Exception) { return false; }
        }
        void tblUser_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (isLoading) return;
            try
            {                               
                
                string strSQL = "";
                if (isAfterAddnew) // insert new record if after addnew action
                {
                    strSQL = "INSERT INTO t_User (Username, Password, Address, PhoneNo, DepartmentID, ShopID, EmailAddress, ViewStatus) "
                                + "values('" + e.Row["UserName"].ToString() + "', '"
                                + e.Row["Password"].ToString() + "', '"
                                + e.Row["Address"].ToString() + "','"
                                + e.Row["PhoneNo"].ToString() + "', '"
                                + GetDepartmentID(e.Row["DepartmentName"].ToString()) + "','"
                                + GetShopID(e.Row["ShopName"].ToString()) + "', '" + e.Row["EmailAddress"].ToString() + "','"
                                + e.Row["ViewStatus"].ToString() + "')";
                    isAfterAddnew = false;
                }
                else // update record
                {
                    strSQL = "UPDATE t_User SET UserName = '" + e.Row["UserName"].ToString() + "',"
                    + " Password = '" + e.Row["Password"].ToString() + "', Address = '" + e.Row["Address"].ToString() + "',"
                    + " PhoneNo = '" + e.Row["PhoneNo"].ToString() + "', DepartmentID ='" + GetDepartmentID(e.Row["DepartmentName"].ToString()) + "',"
                    + " ShopID = '" + GetShopID(e.Row["ShopName"].ToString()) + "',"
                    + " EmailAddress = '" + e.Row["EmailAddress"].ToString() + "',"
                    + " ViewStatus = '" + e.Row["ViewStatus"].ToString() + "' WHERE UserID = '" + e.Row["UserID"] + "'";
                }
                SqlCommand cmdUpdate = new SqlCommand(strSQL, sqlConn);
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception) { }

        }

        
        private string GetDepartmentID(string departName)
        {
            try
            {
                string strSQL = "SELECT * FROM t_Department WHERE DepartmentName = '" + departName + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(strSQL, sqlConn);
                DataTable tblDepart = new DataTable();

                adapter.Fill(tblDepart);
                if (tblDepart.Rows.Count > 0)
                    return tblDepart.Rows[0]["DepartmentID"].ToString();
            }
            catch (Exception) { }
            return "";
        }
        private string GetShopID(string shopName)
        {
            try
            {
                string strSQL = "SELECT * FROM t_Shop WHERE ShopName = '" + shopName + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(strSQL, sqlConn);
                DataTable tbl = new DataTable();

                adapter.Fill(tbl);
                if (tbl.Rows.Count > 0)
                    return tbl.Rows[0]["ShopID"].ToString();
            }
            catch (Exception) { }
            return "";
        }
        private void LoadDepartment()
        {
            try
            {
                string strSQL = "SELECT * FROM t_Department";

                SqlDataAdapter adapter = new SqlDataAdapter(strSQL, sqlConn);                

                adapter.Fill(tblDepart);

                foreach (DataRow dtr in tblDepart.Rows)
                {

                    repositoryItemComboBox1.Items.Add(dtr["DepartmentName"].ToString());
                }
            }
            catch (Exception) { }
        }
        private void LoadShop()
        {
            try
            {
                string strSQL = "SELECT * FROM t_Shop";

                SqlDataAdapter adapter = new SqlDataAdapter(strSQL, sqlConn);
                DataTable tblShop = new DataTable();

                adapter.Fill(tblShop);

                foreach (DataRow dtr in tblShop.Rows)
                {
                    repositoryItemComboBox3.Items.Add(dtr["ShopName"].ToString());
                }
            }
            catch (Exception) { }
        }
        private void gridControl2_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

