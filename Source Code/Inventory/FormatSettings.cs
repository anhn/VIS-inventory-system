using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Inventory.Properties;

namespace Inventory
{
    /// <summary>
    /// Summary description for FormatSettings.
    /// </summary>
    public class FormatSettings : DevExpress.XtraEditors.XtraForm
    {
        private RadioGroup rdLanguages;
        private GroupControl groupControl1;
        private GroupControl groupControl2;
        private PanelControl panelControl1;
        private ButtonEdit bteFont;
        private Label label1;
        private TextEdit txtDefaultCurrency;
        private Label label2;
        private Label label3;
        private Label label4;
        private SimpleButton btnOK;
        private SimpleButton btnCancel;
        private FontDialog dlgFont;
        private Label label5;
        private ComboBoxEdit txtTimeFormat;
        private ComboBoxEdit txtDateFormat;
        private ComboBoxEdit txtNumberFormat;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public FormatSettings()
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
            this.rdLanguages = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtNumberFormat = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtDateFormat = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTimeFormat = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDefaultCurrency = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bteFont = new DevExpress.XtraEditors.ButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.rdLanguages.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberFormat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFormat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeFormat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDefaultCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteFont.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdLanguages
            // 
            this.rdLanguages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdLanguages.Location = new System.Drawing.Point(2, 20);
            this.rdLanguages.Name = "rdLanguages";
            this.rdLanguages.Properties.Columns = 1;
            this.rdLanguages.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Origin"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Language 1"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Language 2"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Language 3")});
            this.rdLanguages.Size = new System.Drawing.Size(131, 152);
            this.rdLanguages.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rdLanguages);
            this.groupControl1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strLanguageSettings", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupControl1.Location = new System.Drawing.Point(323, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(135, 174);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = global::Inventory.Properties.Settings.Default.strLanguageSettings;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtNumberFormat);
            this.groupControl2.Controls.Add(this.txtDateFormat);
            this.groupControl2.Controls.Add(this.txtTimeFormat);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.txtDefaultCurrency);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.bteFont);
            this.groupControl2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strAppearance", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(319, 174);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = global::Inventory.Properties.Settings.Default.strAppearance;
            // 
            // txtNumberFormat
            // 
            this.txtNumberFormat.EditValue = "";
            this.txtNumberFormat.Location = new System.Drawing.Point(112, 127);
            this.txtNumberFormat.Name = "txtNumberFormat";
            this.txtNumberFormat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNumberFormat.Properties.Items.AddRange(new object[] {
            "#,###,###.###",
            "#.###.###,###"});
            this.txtNumberFormat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtNumberFormat.Size = new System.Drawing.Size(150, 20);
            this.txtNumberFormat.TabIndex = 11;
            // 
            // txtDateFormat
            // 
            this.txtDateFormat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", global::Inventory.Properties.Settings.Default, "cfgDateFormat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDateFormat.EditValue = global::Inventory.Properties.Settings.Default.cfgDateFormat;
            this.txtDateFormat.Location = new System.Drawing.Point(112, 101);
            this.txtDateFormat.Name = "txtDateFormat";
            this.txtDateFormat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateFormat.Properties.Items.AddRange(new object[] {
            "M/d/yyyy",
            "d/M/yyyy"});
            this.txtDateFormat.Size = new System.Drawing.Size(150, 20);
            this.txtDateFormat.TabIndex = 10;
            // 
            // txtTimeFormat
            // 
            this.txtTimeFormat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", global::Inventory.Properties.Settings.Default, "cfgTimeFormat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtTimeFormat.EditValue = global::Inventory.Properties.Settings.Default.cfgTimeFormat;
            this.txtTimeFormat.Location = new System.Drawing.Point(112, 75);
            this.txtTimeFormat.Name = "txtTimeFormat";
            this.txtTimeFormat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTimeFormat.Properties.Items.AddRange(new object[] {
            "hh:mm tt",
            "hh:mm"});
            this.txtTimeFormat.Size = new System.Drawing.Size(150, 20);
            this.txtTimeFormat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strNumberFormat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label5.Location = new System.Drawing.Point(6, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = global::Inventory.Properties.Settings.Default.strNumberFormat;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strTimeFormat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label4.Location = new System.Drawing.Point(7, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = global::Inventory.Properties.Settings.Default.strTimeFormat;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strDateFormat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label3.Location = new System.Drawing.Point(7, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = global::Inventory.Properties.Settings.Default.strDateFormat;
            // 
            // txtDefaultCurrency
            // 
            this.txtDefaultCurrency.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", global::Inventory.Properties.Settings.Default, "cfgDefaultCurrency", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDefaultCurrency.EditValue = global::Inventory.Properties.Settings.Default.cfgDefaultCurrency;
            this.txtDefaultCurrency.Location = new System.Drawing.Point(112, 49);
            this.txtDefaultCurrency.Name = "txtDefaultCurrency";
            this.txtDefaultCurrency.Size = new System.Drawing.Size(150, 20);
            this.txtDefaultCurrency.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strDefaultCurrency", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = global::Inventory.Properties.Settings.Default.strDefaultCurrency;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strDefaultFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = global::Inventory.Properties.Settings.Default.strDefaultFont;
            // 
            // bteFont
            // 
            this.bteFont.EditValue = "";
            this.bteFont.Location = new System.Drawing.Point(112, 23);
            this.bteFont.Name = "bteFont";
            this.bteFont.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteFont.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.bteFont.Size = new System.Drawing.Size(150, 20);
            this.bteFont.TabIndex = 0;
            this.bteFont.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteFont_ButtonClick);
            this.bteFont.EditValueChanged += new System.EventHandler(this.bteFont_EditValueChanged);
            this.bteFont.Click += new System.EventHandler(this.bteFont_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnOK);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 177);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(458, 41);
            this.panelControl1.TabIndex = 3;
            this.panelControl1.Text = "panelControl1";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strCancel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(247, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 31);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = global::Inventory.Properties.Settings.Default.strCancel;
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("Arial", 8.25F);
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strOK", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnOK.Location = new System.Drawing.Point(71, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(117, 31);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = global::Inventory.Properties.Settings.Default.strOK;
            this.btnOK.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FormatSettings
            // 
            this.AcceptButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(458, 218);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Inventory.Properties.Settings.Default, "strFormat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormatSettings";
            this.Text = global::Inventory.Properties.Settings.Default.strFormat;
            this.Load += new System.EventHandler(this.FormatSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rdLanguages.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberFormat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateFormat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeFormat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDefaultCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteFont.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private Font fntSelected;
        private void FormatSettings_Load(object sender, EventArgs e)
        {
            //dlgFont.Font.;
            try
            {
                txtNumberFormat.SelectedIndex = Settings.Default.cfgNumberFormat;
            }
            catch { }
            bteFont.Text = Settings.Default.cfgDefaultFont.ToString();
            fntSelected = Settings.Default.cfgDefaultFont;
            txtDateFormat.Text = Settings.Default.cfgDateFormat;
            txtDefaultCurrency.Text = Settings.Default.cfgDefaultCurrency;
            txtTimeFormat.Text = Settings.Default.cfgTimeFormat;

            rdLanguages.Properties.Items[0].Description = Settings.Default.strOrigin;
            rdLanguages.Properties.Items[1].Description = Settings.Default.strLanguage1;
            rdLanguages.Properties.Items[2].Description = Settings.Default.strLanguage2;
            rdLanguages.Properties.Items[3].Description = Settings.Default.strLanguage3;
            rdLanguages.SelectedIndex = Settings.Default.cfgLanguage;
        }

        private void bteFont_Click(object sender, EventArgs e)
        {

        }

        private void bteFont_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void bteFont_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                dlgFont.Font = Settings.Default.cfgDefaultFont;
            }
            catch { }
            if (dlgFont.ShowDialog() == DialogResult.OK)
            {
                
                bteFont.Text = dlgFont.Font.ToString();
                fntSelected = dlgFont.Font;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Settings.Default.cfgLanguage = rdLanguages.SelectedIndex;
            Settings.Default.cfgDefaultFont = fntSelected;
            Settings.Default.cfgTimeFormat = txtTimeFormat.Text;
            Settings.Default.cfgDefaultCurrency = txtDefaultCurrency.Text;
            Settings.Default.cfgDateFormat = txtDateFormat.Text;
            Settings.Default.cfgNumberFormat = txtNumberFormat.SelectedIndex;
            Settings.Default.Save();            
            this.DialogResult = DialogResult.OK;
        }
    }
}

