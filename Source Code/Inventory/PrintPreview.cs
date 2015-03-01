using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;

namespace Inventory
{
    /// <summary>
    /// Summary description for PrintPreview.
    /// </summary>
    public class PrintPreview : DevExpress.XtraEditors.XtraForm
    {
        private DevExpress.XtraPrinting.Control.PrintControl printControl1;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBar printPreviewBar1;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarButton printPreviewBarButton1;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarButton printPreviewBarButton2;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarButton printPreviewBarButton3;
        private ToolBarButton toolBarButton1;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarButton printPreviewBarButton4;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarButton printPreviewBarButton5;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarButton printPreviewBarButton6;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarButton printPreviewBarButton7;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarButton printPreviewBarButton8;
        private ToolBarButton toolBarButton2;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarButton printPreviewBarButton9;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarButton printPreviewBarButton10;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarButton printPreviewBarButton11;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarButton printPreviewBarButton12;
        private ToolBarButton toolBarButton3;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarButton printPreviewBarButton13;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarButton printPreviewBarButton14;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarButton printPreviewBarButton15;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarButton printPreviewBarButton16;
        private ToolBarButton toolBarButton4;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarButton printPreviewBarButton17;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarButton printPreviewBarButton18;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarButton printPreviewBarButton19;
        private ToolBarButton toolBarButton5;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarButton printPreviewBarButton20;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarButton printPreviewBarButton21;
        private ToolBarButton toolBarButton6;
        private DevExpress.XtraPrinting.Preview.PrintPreviewBarButton printPreviewBarButton22;
        private DevExpress.XtraPrinting.Preview.PrintPreviewStatus printPreviewStatus1;
        private DevExpress.XtraPrinting.Preview.PrintPreviewStatusPanel printPreviewStatusPanel1;
        private DevExpress.XtraPrinting.Preview.PrintPreviewStatusPanel printPreviewStatusPanel2;
        private DevExpress.XtraPrinting.Preview.PrintPreviewStatusPanel printPreviewStatusPanel3;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
        private PrintingSystem printingSystem1;
        private PrintableComponentLink printableComponentLink3;
        private GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private IContainer components;

        public PrintPreview()
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
            this.components = new System.ComponentModel.Container();
            this.printControl1 = new DevExpress.XtraPrinting.Control.PrintControl();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink3 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.printPreviewBar1 = new DevExpress.XtraPrinting.Preview.PrintPreviewBar();
            this.printPreviewBarButton1 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarButton();
            this.printPreviewBarButton2 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarButton();
            this.printPreviewBarButton3 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarButton();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.printPreviewBarButton4 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarButton();
            this.printPreviewBarButton5 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarButton();
            this.printPreviewBarButton6 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarButton();
            this.printPreviewBarButton7 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarButton();
            this.printPreviewBarButton8 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.printPreviewBarButton9 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarButton();
            this.printPreviewBarButton10 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarButton();
            this.printPreviewBarButton11 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarButton();
            this.printPreviewBarButton12 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.printPreviewBarButton13 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarButton();
            this.printPreviewBarButton14 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarButton();
            this.printPreviewBarButton15 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarButton();
            this.printPreviewBarButton16 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarButton();
            this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.printPreviewBarButton17 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarButton();
            this.printPreviewBarButton18 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarButton();
            this.printPreviewBarButton19 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarButton();
            this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.printPreviewBarButton20 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarButton();
            this.printPreviewBarButton21 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarButton();
            this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
            this.printPreviewBarButton22 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarButton();
            this.printPreviewStatus1 = new DevExpress.XtraPrinting.Preview.PrintPreviewStatus();
            this.printPreviewStatusPanel1 = new DevExpress.XtraPrinting.Preview.PrintPreviewStatusPanel();
            this.printPreviewStatusPanel2 = new DevExpress.XtraPrinting.Preview.PrintPreviewStatusPanel();
            this.printPreviewStatusPanel3 = new DevExpress.XtraPrinting.Preview.PrintPreviewStatusPanel();
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPreviewStatusPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPreviewStatusPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPreviewStatusPanel3)).BeginInit();
            this.SuspendLayout();
            // 
            // printControl1
            // 
            this.printControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printControl1.IsMetric = false;
            this.printControl1.Location = new System.Drawing.Point(0, 72);
            this.printControl1.Name = "printControl1";
            this.printControl1.PrintingSystem = this.printingSystem1;
            this.printControl1.Size = new System.Drawing.Size(566, 288);
            this.printControl1.TabIndex = 0;
            this.printControl1.TabStop = false;
            this.printControl1.Text = "printControl1";
            // 
            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.printableComponentLink3});
            // 
            // printableComponentLink3
            // 
            this.printableComponentLink3.Component = this.gridControl1;
            this.printableComponentLink3.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.printableComponentLink3.PaperName = "dddd";
            this.printableComponentLink3.PrintingSystem = this.printingSystem1;
            // 
            // gridControl1
            // 
            // 
            // 
            // 
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(275, 236);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(253, 91);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "gridColumn3";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // printPreviewBar1
            // 
            this.printPreviewBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.printPreviewBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.printPreviewBarButton1,
            this.printPreviewBarButton2,
            this.printPreviewBarButton3,
            this.toolBarButton1,
            this.printPreviewBarButton4,
            this.printPreviewBarButton5,
            this.printPreviewBarButton6,
            this.printPreviewBarButton7,
            this.printPreviewBarButton8,
            this.toolBarButton2,
            this.printPreviewBarButton9,
            this.printPreviewBarButton10,
            this.printPreviewBarButton11,
            this.printPreviewBarButton12,
            this.toolBarButton3,
            this.printPreviewBarButton13,
            this.printPreviewBarButton14,
            this.printPreviewBarButton15,
            this.printPreviewBarButton16,
            this.toolBarButton4,
            this.printPreviewBarButton17,
            this.printPreviewBarButton18,
            this.printPreviewBarButton19,
            this.toolBarButton5,
            this.printPreviewBarButton20,
            this.printPreviewBarButton21,
            this.toolBarButton6,
            this.printPreviewBarButton22});
            this.printPreviewBar1.ButtonSize = new System.Drawing.Size(16, 16);
            this.printPreviewBar1.DropDownArrows = true;
            this.printPreviewBar1.Location = new System.Drawing.Point(0, 0);
            this.printPreviewBar1.Name = "printPreviewBar1";
            this.printPreviewBar1.ShowToolTips = true;
            this.printPreviewBar1.Size = new System.Drawing.Size(566, 72);
            this.printPreviewBar1.TabIndex = 1;
            // 
            // printPreviewBarButton1
            // 
            this.printPreviewBarButton1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.DocumentMap;
            this.printPreviewBarButton1.Enabled = false;
            this.printPreviewBarButton1.ImageIndex = 19;
            this.printPreviewBarButton1.Name = "printPreviewBarButton1";
            this.printPreviewBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.printPreviewBarButton1.ToolTipText = "Document Map";
            // 
            // printPreviewBarButton2
            // 
            this.printPreviewBarButton2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Find;
            this.printPreviewBarButton2.Enabled = false;
            this.printPreviewBarButton2.ImageIndex = 20;
            this.printPreviewBarButton2.Name = "printPreviewBarButton2";
            this.printPreviewBarButton2.ToolTipText = "Search";
            // 
            // printPreviewBarButton3
            // 
            this.printPreviewBarButton3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HandTool;
            this.printPreviewBarButton3.Enabled = false;
            this.printPreviewBarButton3.ImageIndex = 16;
            this.printPreviewBarButton3.Name = "printPreviewBarButton3";
            this.printPreviewBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.printPreviewBarButton3.ToolTipText = "Hand Tool";
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // printPreviewBarButton4
            // 
            this.printPreviewBarButton4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Customize;
            this.printPreviewBarButton4.Enabled = false;
            this.printPreviewBarButton4.ImageIndex = 14;
            this.printPreviewBarButton4.Name = "printPreviewBarButton4";
            this.printPreviewBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.printPreviewBarButton4.ToolTipText = "Customize";
            // 
            // printPreviewBarButton5
            // 
            this.printPreviewBarButton5.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Print;
            this.printPreviewBarButton5.Enabled = false;
            this.printPreviewBarButton5.ImageIndex = 0;
            this.printPreviewBarButton5.Name = "printPreviewBarButton5";
            this.printPreviewBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.printPreviewBarButton5.ToolTipText = "Print";
            // 
            // printPreviewBarButton6
            // 
            this.printPreviewBarButton6.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect;
            this.printPreviewBarButton6.Enabled = false;
            this.printPreviewBarButton6.ImageIndex = 1;
            this.printPreviewBarButton6.Name = "printPreviewBarButton6";
            this.printPreviewBarButton6.ToolTipText = "Print Direct";
            // 
            // printPreviewBarButton7
            // 
            this.printPreviewBarButton7.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageSetup;
            this.printPreviewBarButton7.Enabled = false;
            this.printPreviewBarButton7.ImageIndex = 2;
            this.printPreviewBarButton7.Name = "printPreviewBarButton7";
            this.printPreviewBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.printPreviewBarButton7.ToolTipText = "Page Setup";
            // 
            // printPreviewBarButton8
            // 
            this.printPreviewBarButton8.Command = DevExpress.XtraPrinting.PrintingSystemCommand.EditPageHF;
            this.printPreviewBarButton8.Enabled = false;
            this.printPreviewBarButton8.ImageIndex = 15;
            this.printPreviewBarButton8.Name = "printPreviewBarButton8";
            this.printPreviewBarButton8.ToolTipText = "Header And Footer";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // printPreviewBarButton9
            // 
            this.printPreviewBarButton9.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Magnifier;
            this.printPreviewBarButton9.Enabled = false;
            this.printPreviewBarButton9.ImageIndex = 3;
            this.printPreviewBarButton9.Name = "printPreviewBarButton9";
            this.printPreviewBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.printPreviewBarButton9.ToolTipText = "Magnifier";
            // 
            // printPreviewBarButton10
            // 
            this.printPreviewBarButton10.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomIn;
            this.printPreviewBarButton10.Enabled = false;
            this.printPreviewBarButton10.ImageIndex = 4;
            this.printPreviewBarButton10.Name = "printPreviewBarButton10";
            this.printPreviewBarButton10.ToolTipText = "Zoom In";
            // 
            // printPreviewBarButton11
            // 
            this.printPreviewBarButton11.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomOut;
            this.printPreviewBarButton11.Enabled = false;
            this.printPreviewBarButton11.ImageIndex = 5;
            this.printPreviewBarButton11.Name = "printPreviewBarButton11";
            this.printPreviewBarButton11.ToolTipText = "Zoom Out";
            // 
            // printPreviewBarButton12
            // 
            this.printPreviewBarButton12.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Zoom;
            this.printPreviewBarButton12.Enabled = false;
            this.printPreviewBarButton12.ImageIndex = 6;
            this.printPreviewBarButton12.Name = "printPreviewBarButton12";
            this.printPreviewBarButton12.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
            this.printPreviewBarButton12.ToolTipText = "Zoom";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // printPreviewBarButton13
            // 
            this.printPreviewBarButton13.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowFirstPage;
            this.printPreviewBarButton13.Enabled = false;
            this.printPreviewBarButton13.ImageIndex = 7;
            this.printPreviewBarButton13.Name = "printPreviewBarButton13";
            this.printPreviewBarButton13.ToolTipText = "First Page";
            // 
            // printPreviewBarButton14
            // 
            this.printPreviewBarButton14.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowPrevPage;
            this.printPreviewBarButton14.Enabled = false;
            this.printPreviewBarButton14.ImageIndex = 8;
            this.printPreviewBarButton14.Name = "printPreviewBarButton14";
            this.printPreviewBarButton14.ToolTipText = "Previous Page";
            // 
            // printPreviewBarButton15
            // 
            this.printPreviewBarButton15.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowNextPage;
            this.printPreviewBarButton15.Enabled = false;
            this.printPreviewBarButton15.ImageIndex = 9;
            this.printPreviewBarButton15.Name = "printPreviewBarButton15";
            this.printPreviewBarButton15.ToolTipText = "Next Page";
            // 
            // printPreviewBarButton16
            // 
            this.printPreviewBarButton16.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowLastPage;
            this.printPreviewBarButton16.Enabled = false;
            this.printPreviewBarButton16.ImageIndex = 10;
            this.printPreviewBarButton16.Name = "printPreviewBarButton16";
            this.printPreviewBarButton16.ToolTipText = "Last Page";
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.Name = "toolBarButton4";
            this.toolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // printPreviewBarButton17
            // 
            this.printPreviewBarButton17.Command = DevExpress.XtraPrinting.PrintingSystemCommand.MultiplePages;
            this.printPreviewBarButton17.Enabled = false;
            this.printPreviewBarButton17.ImageIndex = 11;
            this.printPreviewBarButton17.Name = "printPreviewBarButton17";
            this.printPreviewBarButton17.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.printPreviewBarButton17.ToolTipText = "Multiple Pages";
            // 
            // printPreviewBarButton18
            // 
            this.printPreviewBarButton18.Command = DevExpress.XtraPrinting.PrintingSystemCommand.FillBackground;
            this.printPreviewBarButton18.Enabled = false;
            this.printPreviewBarButton18.ImageIndex = 12;
            this.printPreviewBarButton18.Name = "printPreviewBarButton18";
            this.printPreviewBarButton18.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.printPreviewBarButton18.ToolTipText = "Background";
            // 
            // printPreviewBarButton19
            // 
            this.printPreviewBarButton19.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Watermark;
            this.printPreviewBarButton19.Enabled = false;
            this.printPreviewBarButton19.ImageIndex = 21;
            this.printPreviewBarButton19.Name = "printPreviewBarButton19";
            this.printPreviewBarButton19.ToolTipText = "Watermark";
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.Name = "toolBarButton5";
            this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // printPreviewBarButton20
            // 
            this.printPreviewBarButton20.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportFile;
            this.printPreviewBarButton20.Enabled = false;
            this.printPreviewBarButton20.ImageIndex = 18;
            this.printPreviewBarButton20.Name = "printPreviewBarButton20";
            this.printPreviewBarButton20.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
            this.printPreviewBarButton20.ToolTipText = "Export Document...";
            // 
            // printPreviewBarButton21
            // 
            this.printPreviewBarButton21.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendFile;
            this.printPreviewBarButton21.Enabled = false;
            this.printPreviewBarButton21.ImageIndex = 17;
            this.printPreviewBarButton21.Name = "printPreviewBarButton21";
            this.printPreviewBarButton21.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
            this.printPreviewBarButton21.ToolTipText = "Send e-mail...";
            // 
            // toolBarButton6
            // 
            this.toolBarButton6.Name = "toolBarButton6";
            this.toolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // printPreviewBarButton22
            // 
            this.printPreviewBarButton22.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ClosePreview;
            this.printPreviewBarButton22.Enabled = false;
            this.printPreviewBarButton22.ImageIndex = 13;
            this.printPreviewBarButton22.Name = "printPreviewBarButton22";
            this.printPreviewBarButton22.ToolTipText = "Close Preview";
            // 
            // printPreviewStatus1
            // 
            this.printPreviewStatus1.Location = new System.Drawing.Point(0, 360);
            this.printPreviewStatus1.Name = "printPreviewStatus1";
            this.printPreviewStatus1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.printPreviewStatusPanel1,
            this.printPreviewStatusPanel2,
            this.printPreviewStatusPanel3});
            this.printPreviewStatus1.ShowPanels = true;
            this.printPreviewStatus1.Size = new System.Drawing.Size(566, 30);
            this.printPreviewStatus1.TabIndex = 2;
            this.printPreviewStatus1.Text = "printPreviewStatus1";
            // 
            // printPreviewStatusPanel1
            // 
            this.printPreviewStatusPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.printPreviewStatusPanel1.ID = "CurrentPageNo";
            this.printPreviewStatusPanel1.Name = "printPreviewStatusPanel1";
            this.printPreviewStatusPanel1.Text = "Current Page No:";
            this.printPreviewStatusPanel1.Width = 183;
            // 
            // printPreviewStatusPanel2
            // 
            this.printPreviewStatusPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.printPreviewStatusPanel2.ID = "TotalPageNo";
            this.printPreviewStatusPanel2.Name = "printPreviewStatusPanel2";
            this.printPreviewStatusPanel2.Text = "Total Page No:";
            this.printPreviewStatusPanel2.Width = 183;
            // 
            // printPreviewStatusPanel3
            // 
            this.printPreviewStatusPanel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.printPreviewStatusPanel3.ID = "ZoomFactor";
            this.printPreviewStatusPanel3.Name = "printPreviewStatusPanel3";
            this.printPreviewStatusPanel3.Text = "Zoom Factor:";
            this.printPreviewStatusPanel3.Width = 183;
            // 
            // printableComponentLink1
            // 
            this.printableComponentLink1.PrintingSystem = null;
            // 
            // PrintPreview
            // 
            this.ClientSize = new System.Drawing.Size(566, 390);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.printControl1);
            this.Controls.Add(this.printPreviewStatus1);
            this.Controls.Add(this.printPreviewBar1);
            this.Name = "PrintPreview";
            this.Text = "PrintPreview";
            this.Load += new System.EventHandler(this.PrintPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPreviewStatusPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPreviewStatusPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPreviewStatusPanel3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void PrintPreview_Load(object sender, EventArgs e)
        {
            //DataGrid gr = new DataGrid();
            //dataGridLink1.DataGrid = gr;
            //printControl1.Show();
            //printControl1.UpdatePageView();
            printControl1.UpdatePageView();
            printControl1.Refresh();
            
        }
        public void SetDataGrid(IPrintable cm)
        {
            //dataGridLink1.DataGrid = gr;
            //printableComponentLink1.Component = cm;
            //printingSystem1.Links.Add(printableComponentLink1);
            //printControl1.Refresh();
            
        }
    }
}

