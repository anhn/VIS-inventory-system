using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Xml;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace SqlTest
{
    /// <summary>
    /// Summary description for frmMain.
    /// </summary>    
    public class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public SaveFileDialog saveDlg;
        private IContainer components;

        public const byte ACTION_NEW_REPORT = 0;
        public string server, user, pass, database;
        private OpenFileDialog openDlg;
        private GroupControl groupControl1;
        private LinkLabel lnkOpenExistsReport;
        private LinkLabel lnkCreateReport;
        private Label label1;
        private SimpleButton btnClose;
        private Label label3;
        private Label label2;
        public const byte ACTION_OPEN_REPORT = 1;

        public void SplitConnStr(string s)
        {
            //Data Source=ACER-684C9A655D\SQLEXPRESS;Initial Catalog=VIS-POS;Persist Security Info=True;User ID=sa;Password=smart            
            String[] arr = s.Split(';');
            foreach (string m in arr)
            {
                if (m.IndexOf("Source") > 0 && m.IndexOf("Data") >= 0)
                {
                    server = m.Substring(m.IndexOf("=") + 1).Trim();
                }
                else if (m.IndexOf("Initial") >= 0 && m.IndexOf("Catalog") > 0)
                {
                    database = m.Substring(m.IndexOf("=") + 1).Trim();
                }
                else if (m.IndexOf("User") >= 0 && m.IndexOf("ID") > 0)
                {
                    user = m.Substring(m.IndexOf("=") + 1).Trim();
                }
                else if (m.IndexOf("Password") >= 0)
                {
                    pass = m.Substring(m.IndexOf("=") + 1).Trim();
                }
            }
        }

        public frmMain()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.saveDlg = new System.Windows.Forms.SaveFileDialog();
            this.openDlg = new System.Windows.Forms.OpenFileDialog();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lnkCreateReport = new System.Windows.Forms.LinkLabel();
            this.lnkOpenExistsReport = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveDlg
            // 
            this.saveDlg.Filter = "Report Management File (*.rmf)|*.rmf|All file (*.*)|*.*";
            // 
            // openDlg
            // 
            this.openDlg.Filter = "Report Management File (*.rmf)|*.rmf|All file (*.*)|*.*";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.lnkOpenExistsReport);
            this.groupControl1.Controls.Add(this.lnkCreateReport);
            this.groupControl1.Location = new System.Drawing.Point(15, 46);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(311, 209);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "What do you want to do?";
            // 
            // lnkCreateReport
            // 
            this.lnkCreateReport.AutoSize = true;
            this.lnkCreateReport.Location = new System.Drawing.Point(16, 28);
            this.lnkCreateReport.Name = "lnkCreateReport";
            this.lnkCreateReport.Size = new System.Drawing.Size(136, 13);
            this.lnkCreateReport.TabIndex = 4;
            this.lnkCreateReport.TabStop = true;
            this.lnkCreateReport.Text = "Create New Report Wizard";
            this.lnkCreateReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCreateReport_LinkClicked);
            // 
            // lnkOpenExistsReport
            // 
            this.lnkOpenExistsReport.AutoSize = true;
            this.lnkOpenExistsReport.Location = new System.Drawing.Point(16, 132);
            this.lnkOpenExistsReport.Name = "lnkOpenExistsReport";
            this.lnkOpenExistsReport.Size = new System.Drawing.Size(100, 13);
            this.lnkOpenExistsReport.TabIndex = 5;
            this.lnkOpenExistsReport.TabStop = true;
            this.lnkOpenExistsReport.Text = "Open Exists Report";
            this.lnkOpenExistsReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOpenExistsReport_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "WELCOME TO REPORT MANAGEMENT";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(251, 265);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 70);
            this.label2.TabIndex = 6;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 42);
            this.label3.TabIndex = 7;
            this.label3.Text = "You can also open exists report that you created before. You can quickly open rep" +
                "ort or reconfig it.";
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(343, 300);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Coffee";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Management";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void mnuExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        public frmAddTable fAddTable;
        public frmSelectType fSelectType;
        public frmServerSelection fServerSelection;
        public frmCriterial fCriterial;
        public frmReportDetails fReportDetails;
        public frmTemplateSelection fTemplateSelection;
        public frmOrderBy fOrderBy;
        public frmFilterPreview fFilterPreview;
        public frmPrediction fPrediction;
        public frmPredictionPreview fPredictionPreview;
        public frmFinishWizard fFinisihWizard;
        public frmChartConfig fChartConfig;
        public frmGroupingConfig fGroupingConfig;
        public frmOpenAction fOpenAction;

        private void showCriterial()
        {
            DialogResult ret = fCriterial.ShowDialog();
            if (ret == DialogResult.Retry)
                showAddTable();
            else if (ret == DialogResult.OK)
                showOrderBy();
        }

        private void showPrediction()
        {
            DialogResult ret = fPrediction.ShowDialog();
            if (ret == DialogResult.Retry)
            {
                showFilterPreview();
            }
            else if (ret == DialogResult.OK)
            {
                showPredictionPreview();
            }
        }

        private void showSelectType()
        {
            DialogResult ret = fSelectType.ShowDialog();
            if (ret == DialogResult.Retry) showPredictionPreview();
            else if (ret == DialogResult.No) showReportIDE();
            else if (ret == DialogResult.Yes) showTemplateSelection();
        }

        private void showTemplateSelection()
        {
            DialogResult ret = fTemplateSelection.ShowDialog();
            if (ret == DialogResult.OK)
            {
                switch (fTemplateSelection.lstTemplate.SelectedIndex)
                {
                    case 0:
                        showFinishWizard();
                        break;
                    case 1:
                        showGroupingConfig();
                        break;
                    case 2:
                        break;
                }
            }
            else if (ret == DialogResult.Retry)
                showSelectType();
            else if (ret == DialogResult.Abort)
            {
                fReportDetails.callFromTemplateSelection = true;
                showReportDetails();
            }
        }

        private void showReportIDE()
        {

        }

        private void showServerSelection()
        {
            fServerSelection.txtPassword.Text = pass;
            fServerSelection.txtUsername.Text = user;
            fServerSelection.txtServerPath.Text = server;
            DialogResult ret = fServerSelection.ShowDialog();
            if (ret == DialogResult.OK)
            {
                fAddTable.reload = true;
                showAddTable();
            }
            else if (ret == DialogResult.Retry) showReportDetails();
        }

        private void showFilterPreview()
        {
            DialogResult ret = fFilterPreview.ShowDialog();
            if (ret == DialogResult.Retry)
                showOrderBy();
            else if (ret == DialogResult.OK)
                showPrediction();
        }

        private void showFinishWizard()
        {
            DialogResult ret = fFinisihWizard.ShowDialog();
            if (ret == DialogResult.Retry)
            {
                switch (fTemplateSelection.lstTemplate.SelectedIndex)
                {
                    case 0:
                        showTemplateSelection();
                        break;
                    case 1:
                        showGroupingConfig();
                        break;
                    case 2:
                        showChartConfig();
                        break;
                }
            }                
        }

        private void showChartConfig()
        {
            DialogResult ret = fChartConfig.ShowDialog();
            if (ret == DialogResult.OK)
            {
                showFinishWizard();
            }
            else if (ret == DialogResult.Retry)
            {
                showTemplateSelection();
            }
        }

        private void showOrderBy()
        {
            DialogResult ret = fOrderBy.ShowDialog();
            if (ret == DialogResult.Retry) showCriterial();
            else if (ret == DialogResult.OK) showFilterPreview();
        }

        private void showAddTable()
        {
            DialogResult ret = fAddTable.ShowDialog();
            if (ret == DialogResult.Retry)
                showServerSelection();
            else if (ret == DialogResult.OK)
                showCriterial();
        }

        private void showReportDetails()
        {
            if (fReportDetails.ShowDialog() == DialogResult.OK)
            {
                if (fReportDetails.callFromTemplateSelection)
                {
                    fReportDetails.callFromTemplateSelection = false;
                    showTemplateSelection();
                }
                else
                showServerSelection();
            }
        }

        private void showPredictionPreview()
        {
            DialogResult ret = fPredictionPreview.ShowDialog();
            if (ret == DialogResult.OK) showSelectType();
            else if (ret == DialogResult.Retry) showPrediction();
        }

        private void showGroupingConfig()
        {
            DialogResult ret = fGroupingConfig.ShowDialog();
            if (ret == DialogResult.Retry)
                showTemplateSelection();
            else if (ret == DialogResult.OK)
                showFinishWizard();
        }

        private void newAllForm()
        {
            fServerSelection = new frmServerSelection();            
            fAddTable = new frmAddTable();
            fSelectType = new frmSelectType();
            fCriterial = new frmCriterial();
            fReportDetails = new frmReportDetails();
            fTemplateSelection = new frmTemplateSelection();
            fFilterPreview = new frmFilterPreview();
            fOpenAction = new frmOpenAction();
            fPrediction = new frmPrediction();
            fOrderBy = new frmOrderBy();
            fPredictionPreview = new frmPredictionPreview();
            fChartConfig = new frmChartConfig();
            fFinisihWizard = new frmFinishWizard();
            fGroupingConfig = new frmGroupingConfig();
            fGroupingConfig.Tag = this;            
            fChartConfig.Tag = this;
            fFinisihWizard.Tag = this;
            fPredictionPreview.Tag = this;
            fServerSelection.Tag = this;
            fPrediction.Tag = this;
            fTemplateSelection.Tag = this;
            fAddTable.Tag = this;
            fCriterial.Tag = this;
            fOrderBy.Tag = this;
        }

        private void mnuNewReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        public byte actionType;

        public bool ReadFile(string filepath)
        {
            try
            {
                FileStream file = new FileStream(filepath, FileMode.Open);
                TextReader reader = new StreamReader(file);
                //read server path first
                if (fServerSelection == null) {
                    newAllForm();
                }                
                //begin read
                DbManager.server = reader.ReadLine();
                DbManager.username = reader.ReadLine();
                DbManager.password = reader.ReadLine();
                DbManager.database = reader.ReadLine();
                //read title, header, footer
                fReportDetails.txtCompanyLogo.Text = reader.ReadLine();
                fReportDetails.txtTitle.Text = reader.ReadLine();
                fReportDetails.txtHeader.Text = reader.ReadLine();
                fReportDetails.txtFooter.Text = reader.ReadLine();
                fReportDetails.txtCaption.Text = reader.ReadLine();
                //load condition
                fCriterial.createDataSource();
                int cnt = int.Parse(reader.ReadLine());
                for (int i = 0; i < cnt; i++)
                {
                    DataRow r = fCriterial.dt.NewRow();
                    r["Table"] = reader.ReadLine();
                    r["View"] = reader.ReadLine();
                    r["Field"] = reader.ReadLine();
                    r["Logical"] = reader.ReadLine();
                    r["Condition"] = reader.ReadLine();
                    r["Value"] = reader.ReadLine();
                    r["Value2"] = reader.ReadLine();
                    r["Rate"] = reader.ReadLine();
                    r["Format"] = reader.ReadLine();
                    r["Type"] = reader.ReadLine();
                    r["Other"] = reader.ReadLine();
                    fCriterial.dt.Rows.Add(r);
                }
                //load alias, order and group
                cnt = int.Parse(reader.ReadLine());
                fOrderBy.arr = new ArrayList();
                for (int i = 0; i < cnt; i++)
                {
                    Record r = new Record(reader.ReadLine());
                    r.Alias = reader.ReadLine();
                    r.Group = bool.Parse(reader.ReadLine());
                    r.OrderBy = reader.ReadLine();
                    r.Show = bool.Parse(reader.ReadLine());
                    r.Type = reader.ReadLine();
                    r.Description = reader.ReadLine();
                    r.Format = reader.ReadLine();
                    r.Rate = reader.ReadLine();
                    r.Other = reader.ReadLine();
                    fOrderBy.arr.Add(r);                    
                }
                //load prediction
                if (fPrediction.dt == null)
                {
                    fPrediction.newDataTable();
                }
                fPrediction.dt.Rows.Clear();
                cnt = int.Parse(reader.ReadLine());
                for (int i = 0; i < cnt; i++)
                {
                    DataRow r = fPrediction.dt.NewRow();
                    r["Prediction Alias"] = reader.ReadLine();
                    r["Formula"] = reader.ReadLine();
                    r["Format"] = reader.ReadLine();
                    fPrediction.dt.Rows.Add(r);
                }
                //read type of template
                fSelectType.rbTemplate.Checked = bool.Parse(reader.ReadLine());
                fTemplateSelection.chkAddPrediction.Checked = bool.Parse(reader.ReadLine());
                fReportDetails.cbFooterAlign.SelectedIndex = int.Parse(reader.ReadLine());
                fReportDetails.cbHeaderAlign.SelectedIndex = int.Parse(reader.ReadLine());              
                //read template file
                fTemplateSelection.lstTemplate.SelectedIndex = int.Parse(reader.ReadLine());
                fTemplateSelection.chkAddPrediction.Checked = bool.Parse(reader.ReadLine());
                fGroupingConfig.rdBlock.Checked = bool.Parse(reader.ReadLine());
                fGroupingConfig.rdSeparate.Checked = bool.Parse(reader.ReadLine());
                fGroupingConfig.rdStepped.Checked = bool.Parse(reader.ReadLine());
                fOrderBy.sql = reader.ReadLine();
                fPredictionPreview.sql = reader.ReadLine();
                fReportDetails.rdLandscape.Checked = bool.Parse(reader.ReadLine());
                fReportDetails.rdPortrait.Checked = bool.Parse(reader.ReadLine());
                fReportDetails.cbPageNumberAlign.SelectedIndex = int.Parse(reader.ReadLine());
                fReportDetails.cbPageNumberPos.SelectedIndex = int.Parse(reader.ReadLine());                
                file.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Corrupt file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void SaveFile(string filename)
        {
            if (fServerSelection == null) return;            
            try
            {
                FileStream file = new FileStream(filename, FileMode.OpenOrCreate);
                TextWriter writer = new StreamWriter(file);
                //write server path first
                writer.WriteLine(DbManager.server);
                //write user name and password
                writer.WriteLine(DbManager.username);
                writer.WriteLine(DbManager.password);
                //write database
                writer.WriteLine(DbManager.database);
                //write title, header & footer
                writer.WriteLine(fReportDetails.txtCompanyLogo.Text);
                writer.WriteLine(fReportDetails.txtTitle.Text);
                writer.WriteLine(fReportDetails.txtHeader.Text);
                writer.WriteLine(fReportDetails.txtFooter.Text);
                writer.WriteLine(fReportDetails.txtCaption.Text);
                //write number of condition
                writer.WriteLine(fCriterial.dt.Rows.Count.ToString());
                //write condition
                foreach (DataRow r in fCriterial.dt.Rows)
                {
                    writer.WriteLine(r["Table"].ToString());
                    writer.WriteLine(r["View"].ToString());
                    writer.WriteLine(r["Field"].ToString());
                    writer.WriteLine(r["Logical"].ToString());
                    writer.WriteLine(r["Condition"].ToString());
                    writer.WriteLine(r["Value"].ToString());
                    writer.WriteLine(r["Value2"].ToString());
                    writer.WriteLine(r["Rate"].ToString());
                    writer.WriteLine(r["Format"].ToString());
                    writer.WriteLine(r["Type"].ToString());
                    writer.WriteLine(r["Other"].ToString());
                }
                //write number of alias
                //writer.WriteLine(fOrderBy.rec.GetLength(0));
                writer.WriteLine(fOrderBy.arr.Count);
                //write alias, order and group
                foreach (Record r in fOrderBy.arr)
                {
                    writer.WriteLine(r.Field);
                    writer.WriteLine(r.Alias);
                    writer.WriteLine(r.Group.ToString());
                    writer.WriteLine(r.OrderBy.ToString());
                    writer.WriteLine(r.Show.ToString());
                    writer.WriteLine(r.Type);
                    writer.WriteLine(r.Description);
                    writer.WriteLine(r.Format);
                    writer.WriteLine(r.Rate);
                    writer.WriteLine(r.Other);
                }
                //write prediction
                writer.WriteLine(fPrediction.dt.Rows.Count);
                foreach (DataRow r in fPrediction.dt.Rows)
                {
                    writer.WriteLine(r["Prediction Alias"].ToString());
                    writer.WriteLine(r["Formula"].ToString());
                    writer.WriteLine(r["Format"].ToString());
                }
                //write type of template
                writer.WriteLine(fSelectType.rbTemplate.Checked.ToString());
                writer.WriteLine(fTemplateSelection.chkAddPrediction.Checked.ToString());
                writer.WriteLine(fReportDetails.cbFooterAlign.SelectedIndex.ToString());
                writer.WriteLine(fReportDetails.cbHeaderAlign.SelectedIndex.ToString());
                //write template name or report file name
                writer.WriteLine(fTemplateSelection.lstTemplate.SelectedIndex.ToString());
                writer.WriteLine(fTemplateSelection.chkAddPrediction.Checked.ToString());
                writer.WriteLine(fGroupingConfig.rdBlock.Checked.ToString());
                writer.WriteLine(fGroupingConfig.rdSeparate.Checked.ToString());
                writer.WriteLine(fGroupingConfig.rdStepped.Checked.ToString());
                writer.WriteLine(fOrderBy.sql);
                writer.WriteLine(fPredictionPreview.sql);
                writer.WriteLine(fReportDetails.rdLandscape.Checked.ToString());
                writer.WriteLine(fReportDetails.rdPortrait.Checked.ToString());
                writer.WriteLine(fReportDetails.cbPageNumberAlign.SelectedIndex.ToString());
                writer.WriteLine(fReportDetails.cbPageNumberPos.SelectedIndex.ToString());
                writer.Flush();
                file.Close();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void mnuSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (saveDlg.ShowDialog() != DialogResult.OK) return;
            SaveFile(saveDlg.FileName);
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void mnuOpenExists_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fReportDetails != null) showReportDetails();
            else MessageBox.Show("No report avaiable");
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fFilterPreview.grMain.DataSource as DataTable == null)
            {
                MessageBox.Show("There are no data to import");
            }
            else
            {
                showTemplateSelection();
            }
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fServerSelection == null)
            {
                MessageBox.Show("No Report Avaialbe");
            }
            else
            {
                showServerSelection();
            }
        }

        private void lnkCreateReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            actionType = ACTION_NEW_REPORT;
            newAllForm();
            showReportDetails();
        }

        private void lnkOpenExistsReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                if (ReadFile(openDlg.FileName))
                {
                    actionType = ACTION_OPEN_REPORT;
                    fCriterial.reload = false;
                    fOrderBy.reload = false;
                    if (fOpenAction.ShowDialog() == DialogResult.OK)
                    {
                        if (fOpenAction.rbCreateReport.Checked)
                        {
                            frmProgress frm = new frmProgress();
                            //connect to the database first
                            frm.Show();
                            frm.lblAction.Text = "Connect to database...";
                            DataTable dt;
                            DataTable preDt;
                            frm.Update();
                            DbManager.Connect();
                            try
                            {
                                DbManager.con.Open();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Could not connect to the database!");
                                frm.Hide();
                                return;
                            }
                            try
                            {
                                frm.proMain.Position = 20;
                                frm.lblAction.Text = "Receiving data: Filtering data...";
                                frm.Update();
                                dt = new DataTable("Tbl1");
                                SqlDataAdapter da = new SqlDataAdapter(fOrderBy.sql, DbManager.con);
                                da.Fill(dt);
                                preDt = new DataTable("PreTbl");
                                frm.proMain.Position = 40;
                                frm.lblAction.Text = "Receiving data: Prediction data...";
                                frm.Update();
                                DbManager.con.Close();
                                DbManager.con.Open();
                                preDt.Columns.Add("Prediction");
                                preDt.Columns.Add("Value");
                                if (fPredictionPreview.sql.Length != 0)
                                {
                                    DbManager.OpenSQL(fPredictionPreview.sql);
                                    DbManager.reader.Read();
                                    foreach (DataRow r in fPrediction.dt.Rows)
                                    {
                                        DataRow newRow = preDt.NewRow();
                                        newRow["Prediction"] = r["Prediction Alias"].ToString();
                                        newRow["Value"] = DbManager.reader[r["Prediction Alias"].ToString()].ToString();
                                        preDt.Rows.Add(newRow);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Could not receive data from database. Perhaps database changed.");
                                frm.Hide();
                                return;
                            }
                            try
                            {
                                frm.proMain.Position = 70;
                                frm.lblAction.Text = "Creating report...";
                                frm.Update();
                                fTemplateSelection.TabularTemplate(dt, preDt);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error creating report.");
                                frm.Hide();
                                return;
                            }
                            frm.proMain.Position = 100;
                            frm.Update();
                            frm.Hide();
                        }
                        else showReportDetails();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

