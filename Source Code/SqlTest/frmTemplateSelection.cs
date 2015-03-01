using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Word;
using System.Reflection;
using System.Data;
using System.IO;
using System.Xml;

namespace SqlTest
{
    /// <summary>
    /// Summary description for frmTemplateSelection.
    /// </summary>
    public class frmTemplateSelection : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton btnBack;
        private SimpleButton btnOk;
        private SimpleButton btnCancel;
        private GroupControl groupControl1;
        private PictureEdit ptLayout;
        private Label label1;
        public ListBoxControl lstTemplate;
        private PanelControl panelControl1;
        private SimpleButton btnReportDetails;
        public CheckEdit chkAddPrediction;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmTemplateSelection()
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
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ptLayout = new DevExpress.XtraEditors.PictureEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTemplate = new DevExpress.XtraEditors.ListBoxControl();
            this.btnReportDetails = new DevExpress.XtraEditors.SimpleButton();
            this.chkAddPrediction = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptLayout.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAddPrediction.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnBack.Location = new System.Drawing.Point(220, 336);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 28);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "&Back";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(300, 336);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 28);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "&Next";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnCancel.Location = new System.Drawing.Point(381, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "&Cancel";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.lstTemplate);
            this.groupControl1.Location = new System.Drawing.Point(13, 18);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(443, 280);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Select template from list bellow";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.ptLayout);
            this.panelControl1.Location = new System.Drawing.Point(249, 53);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(174, 205);
            this.panelControl1.TabIndex = 3;
            this.panelControl1.Text = "panelControl1";
            // 
            // ptLayout
            // 
            this.ptLayout.Location = new System.Drawing.Point(7, 7);
            this.ptLayout.Name = "ptLayout";
            this.ptLayout.Size = new System.Drawing.Size(160, 191);
            this.ptLayout.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click on the item to see layout of the report";
            // 
            // lstTemplate
            // 
            this.lstTemplate.Items.AddRange(new object[] {
            "Tabular",
            "Tabular with grouping",
            "Chart"});
            this.lstTemplate.Location = new System.Drawing.Point(17, 53);
            this.lstTemplate.Name = "lstTemplate";
            this.lstTemplate.Size = new System.Drawing.Size(178, 206);
            this.lstTemplate.TabIndex = 0;
            this.lstTemplate.SelectedIndexChanged += new System.EventHandler(this.lstTemplate_SelectedIndexChanged);
            // 
            // btnReportDetails
            // 
            this.btnReportDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportDetails.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnReportDetails.Location = new System.Drawing.Point(30, 336);
            this.btnReportDetails.Name = "btnReportDetails";
            this.btnReportDetails.Size = new System.Drawing.Size(80, 28);
            this.btnReportDetails.TabIndex = 17;
            this.btnReportDetails.Text = "Page setup";
            // 
            // chkAddPrediction
            // 
            this.chkAddPrediction.Location = new System.Drawing.Point(30, 309);
            this.chkAddPrediction.Name = "chkAddPrediction";
            this.chkAddPrediction.Properties.Caption = "Add Prediction To Report";
            this.chkAddPrediction.Size = new System.Drawing.Size(426, 19);
            this.chkAddPrediction.TabIndex = 18;
            this.chkAddPrediction.CheckedChanged += new System.EventHandler(this.chkAddPrediction_CheckedChanged);
            // 
            // frmTemplateSelection
            // 
            this.ClientSize = new System.Drawing.Size(479, 378);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chkAddPrediction);
            this.Controls.Add(this.btnReportDetails);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTemplateSelection";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Template";
            this.Load += new System.EventHandler(this.frmTemplateSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptLayout.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAddPrediction.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        //String header, String footer, String Title, String Caption, String LogoFile, DataTable tbl
        private string GetFormated(Record r, string value)
        {
            double x;
            string txt = value;
            switch (r.IntType)
            {
                case frmCriterial.TYPE_CURRENCY:
                    x = double.Parse(txt);
                    if (r.Rate.Length > 0) x *= double.Parse(r.Rate);
                    txt = x.ToString(r.Format);
                    break;
                case frmCriterial.TYPE_DATETIME:
                    DateTime dt = DateTime.Parse(txt);
                    string format = r.Format;
                    format = format.Replace('D', 'd');
                    format = format.Replace('Y', 'y');
                    txt = dt.ToString(format);
                    break;
                case frmCriterial.TYPE_NUMBER:
                    if (r.Format.Length > 0)
                    {
                        x = double.Parse(txt);
                        txt = x.ToString(r.Format);
                    }
                    break;
            }
            return txt;
        }

        public void TabularTemplate(DataTable tbl, DataTable prTbl)
        {
            #region page setup
            frmMain frmM = Tag as frmMain;
            bool isGroup = frmM.fTemplateSelection.lstTemplate.SelectedIndex == 1;
            bool isStepped = frmM.fGroupingConfig.rdStepped.Checked;
            bool isSeparate = frmM.fGroupingConfig.rdSeparate.Checked;
            String Caption = frmM.fReportDetails.txtCaption.Text;
            String Title = frmM.fReportDetails.txtTitle.Text;
            String LogoFile = frmM.fReportDetails.txtCompanyLogo.Text;
            String header = frmM.fReportDetails.txtHeader.Text;
            String footer = frmM.fReportDetails.txtFooter.Text;

            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */

            //Start Word and create a new document.
            Word._Application oWord;
            Word._Document oDoc;

            oWord = new Word.Application();
            oWord.Visible = true;
            
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
                ref oMissing, ref oMissing);
            header = header.Replace("[#Date]", DateTime.Now.ToShortDateString());
            footer = footer.Replace("[#Date]", DateTime.Now.ToShortDateString());
            
            oDoc.Sections[1].Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range.Text = header;
            
            frmReportDetails frm = (Tag as frmMain).fReportDetails;
            if (frm.rdLandscape.Checked)
            {
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
            }
            else
            {
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientPortrait;           
            }

            switch (frm.cbHeaderAlign.SelectedIndex)
            {
                case 0:
                    oDoc.Sections[1].Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                    break;
                case 1:
                    oDoc.Sections[1].Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;                    
                    break;
                case 2:
                    oDoc.Sections[1].Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                    break;
            }

            oDoc.Sections[1].Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range.Text = footer;
            
            switch (frm.cbFooterAlign.SelectedIndex)
            {
                case 0:
                    oDoc.Sections[1].Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                    break;
                case 1:
                    oDoc.Sections[1].Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    break;
                case 2:
                    oDoc.Sections[1].Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                    break;
            }

            switch (frm.cbPageNumberAlign.SelectedIndex)
            {
                case 0:
                    oMissing = Word.WdPageNumberAlignment.wdAlignPageNumberLeft;
                    break;
                case 1:
                    oMissing = Word.WdPageNumberAlignment.wdAlignPageNumberCenter;
                    break;
                case 2:
                    oMissing = Word.WdPageNumberAlignment.wdAlignPageNumberRight;
                    break;
            }

            object firstPage = true;

            switch (frm.cbPageNumberPos.SelectedIndex)
            {
                    //header
                case 1:                    
                    oDoc.Sections[1].Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].PageNumbers.Add(ref oMissing, ref firstPage);
                    break;
                case 2:
                    oDoc.Sections[1].Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].PageNumbers.Add(ref oMissing, ref firstPage);
                    break;
            }

            Word.Table oTable = null;
            oMissing = Missing.Value;
            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

            Word.Paragraph oPara1;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara1.Range.Font.Size = 17;
            oPara1.Range.Font.Color = Word.WdColor.wdColorRose;
            oPara1.Range.Text = "\n" + Title;
            oPara1.Range.InsertParagraphAfter();
                        
            Word.Paragraph oPara3;
            object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara3 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara3.Range.Text = Caption + "\n";
            oPara3.Format.SpaceAfter = 6;
            oPara3.Range.InsertParagraphAfter();

            if (File.Exists(LogoFile))
            {
                try
                {
                    object x = oWord.InchesToPoints(4.2f) as object, y = oWord.InchesToPoints(0.1f) as object;
                    object w = oWord.InchesToPoints(1.4f) as object, h = oWord.InchesToPoints(2.27f) as object;
                    oPara1.Range.Document.Shapes.AddPicture(LogoFile, ref oMissing, ref oMissing, ref x, ref y, ref h, ref w, ref oMissing);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error load picture");
                }
            }
            wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            #endregion
            int i = 1;
            ArrayList arr = (Tag as frmMain).fOrderBy.arr;

            ArrayList shTbl = new ArrayList();
            for (int j = 0; j < arr.Count; j++)
            {
                Record tmp = arr[j] as Record;
                if (tmp.Show) shTbl.Add(tmp);
            }

            //for group template
            ArrayList array = new ArrayList(); ;
            ArrayList capArr = new ArrayList(); ;
            if (isGroup)
            {
                i = 0;
                foreach (Record rec in frmM.fOrderBy.arr)
                {
                    if (rec.Group && rec.Show) array.Add(i);
                    i++;
                }
            }

            if (array.Count == 0) isGroup = false;
            if (isGroup && isSeparate)
            {
                #region new type of report
                String oldGroup = "";
                i = 2;
                foreach (DataRow r in tbl.Rows)
                {
                    String group = "\n";                    
                    Record record;
                    for (int k = 0; k < array.Count; k++)
                    {                        
                        record = shTbl[(int)array[k]] as Record;
                        if (group.Length > 1) group += ",  ";
                        group += tbl.Columns[k].ToString() + ":  " + GetFormated(record, r[k].ToString());
                    }
                    if (oldGroup != group)
                    {
                        //add new line
                        oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                        oPara3 = oDoc.Content.Paragraphs.Add(ref oRng);
                        oPara3.Range.Text = group;
                        oPara3.Format.SpaceAfter = 6;
                        oPara3.Range.InsertParagraphAfter();
                        oldGroup = group;
                        //add new table
                        wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                        oMissing = Missing.Value;
                        oTable = oDoc.Tables.Add(wrdRng, 2, tbl.Columns.Count - array.Count, ref oMissing, ref oMissing);
                        oTable.Rows[1].Shading.BackgroundPatternColor = Word.WdColor.wdColorTan;
                        oTable.Range.ParagraphFormat.SpaceAfter = 6;
                        for (int k = 1; k < tbl.Columns.Count - array.Count + 1; k++)
                        {
                            oTable.Cell(1, k).Range.Text = tbl.Columns[k + array.Count - 1].Caption;
                        }
                        i = 2;
                    }
                    else
                    {                        
                        //oMissing = oTable.Rows[i - 1];
                        oMissing = Missing.Value;
                        oTable.Rows.Add(ref oMissing);
                    }
                    for (int k = 1; k < tbl.Columns.Count - array.Count + 1; k++)
                    {
                        record = shTbl[k + array.Count - 1] as Record;
                        oTable.Cell(i, k).Range.Text = GetFormated(record, r[k + array.Count - 1].ToString());
                    }
                    i++;
                }
                #endregion
            }
            else
            {
                i = 1;
                #region old type of report
                oTable = oDoc.Tables.Add(wrdRng, tbl.Rows.Count + 1, tbl.Columns.Count, ref oMissing, ref oMissing);
                oTable.Range.ParagraphFormat.SpaceAfter = 6;
                foreach (DataColumn c in tbl.Columns)
                {
                    Record r = arr[i - 1] as Record;
                    string txt = c.Caption;
                    if (r.IntType == frmCriterial.TYPE_CURRENCY)
                    {
                        if (r.Other.Trim().Length > 0) txt += " (" + r.Other.Trim() + ")";
                    }
                    oTable.Cell(1, i).Range.Text = txt;
                    i++;
                }
                oTable.Rows[1].Shading.BackgroundPatternColor = Word.WdColor.wdColorTan;
                oTable.Borders.Enable = 1;
                oTable.Rows[1].Alignment = Word.WdRowAlignment.wdAlignRowCenter;
                oTable.Rows[1].Range.Font.Bold = 1;                

                i = 2;

                foreach (DataRow r in tbl.Rows)
                {
                    int j = 1;
                    foreach (DataColumn c in tbl.Columns)
                    {
                        Record rec = arr[j - 1] as Record;
                        string txt = r[c.Caption].ToString();
                        txt = GetFormated(rec, txt);
                        //group template
                        if (isGroup && array.Contains(j - 1))
                        {

                            int p = array.IndexOf(j - 1, 0);
                            if (i == 2 || (isStepped && i == 2 + p))
                            {
                                oTable.Cell(i, j).Range.Text = txt;
                                if (isStepped)
                                {
                                    if (i + 1 < oTable.Rows.Count)
                                    {
                                        oMissing = oTable.Rows[i + 1];
                                        oTable.Rows.Add(ref oMissing);
                                    }
                                    i++;
                                }
                                capArr.Add(txt);
                            }
                            else if (capArr[p].ToString().Trim() != txt.Trim())
                            {
                                oTable.Cell(i, j).Range.Text = txt;
                                if (isStepped && (i + 1 < oTable.Rows.Count))
                                {
                                    oMissing = oTable.Rows[i + 1];
                                    oTable.Rows.Add(ref oMissing);
                                    i++;
                                }
                                capArr[p] = txt;
                                //if (p < array.Count - 1)
                                for (int k = p + 1; k < array.Count; k++)
                                    capArr[k] = "";
                            }

                        }
                        else
                            oTable.Cell(i, j).Range.Text = txt;
                        j++;
                    }
                    i++;
                }
                #endregion
            }

            #region input prediction paragraph
            if (!chkAddPrediction.Checked) return;
            if (prTbl == null || prTbl.Rows.Count == 0) return;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            Word.Paragraph oPara2 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara2.Range.Text = "";
            oPara2.Format.SpaceAfter = 6;
            oPara2.Range.InsertParagraphAfter();
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara2 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara2.Range.Text = "Prediction";
            oPara2.Range.InsertParagraphAfter();
            i = 0;
            foreach (DataRow r in prTbl.Rows)
            {
                oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oPara2 = oDoc.Content.Paragraphs.Add(ref oRng);
                double x = double.Parse(r["Value"].ToString());
                oPara2.Range.Text = r["Prediction"] + ":  " + x.ToString((Tag as frmMain).fPrediction.dt.Rows[i]["Format"].ToString());
                oPara2.Range.InsertParagraphAfter();
                i++;
            }
#endregion
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lstTemplate.SelectedItem == null)
            {
                MessageBox.Show("Select a template!");
                return;
            }

            try
            {
                switch (lstTemplate.SelectedValue.ToString())
                {
                    case "Tabular with grouping":
                        break;
                    case "Tabular":
                        TabularTemplate((Tag as frmMain).fFilterPreview.grMain.DataSource as DataTable, (Tag as frmMain).fPredictionPreview.dt);
                        break;
                    default:
                        MessageBox.Show("This template is not avaiable now");
                        break;
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when create report! Error Details: " + ex.ToString());
            }
        }

        private void frmTemplateSelection_Load(object sender, EventArgs e)
        {
            
        }

        private void lstTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(System.Windows.Forms.Application.StartupPath + "\\Template\\" + lstTemplate.SelectedValue.ToString() + ".jpg"))
                    ptLayout.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\Template\\" + lstTemplate.SelectedValue.ToString() + ".jpg");
                else
                    ptLayout.Image = null;
            }
            catch (Exception ex)
            {
                ptLayout.Image = null;
            }
        }

        private void chkAddPrediction_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

