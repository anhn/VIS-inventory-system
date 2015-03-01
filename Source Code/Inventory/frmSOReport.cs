using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Inventory
{
    /// <summary>
    /// Summary description for frmSOReport.
    /// </summary>
    public class frmSOReport : DevExpress.XtraEditors.XtraForm
    {
        private IContainer components;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BindingSource t_Sales_Order_Header_OneBindingSource;
        private _Vis_SODataSet _Vis_SODataSet;
        private Inventory._Vis_SODataSetTableAdapters.t_Sales_Order_Header_OneTableAdapter t_Sales_Order_Header_OneTableAdapter;
        private BindingSource t_Sales_Order_Detail_OneBindingSource;
        private BindingSource tSalesOrderDetailOneBindingSource;
        private Inventory._Vis_SODataSetTableAdapters.t_Sales_Order_Detail_OneTableAdapter t_Sales_Order_Detail_OneTableAdapter;
        private string m_strSO;

        public frmSOReport(string strSO)
        {
            m_strSO = strSO;
            InitializeComponent();
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this._Vis_SODataSet = new Inventory._Vis_SODataSet();
            this.t_Sales_Order_Header_OneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_Sales_Order_Header_OneTableAdapter = new Inventory._Vis_SODataSetTableAdapters.t_Sales_Order_Header_OneTableAdapter();
            this.tSalesOrderDetailOneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_Sales_Order_Detail_OneTableAdapter = new Inventory._Vis_SODataSetTableAdapters.t_Sales_Order_Detail_OneTableAdapter();
            this.t_Sales_Order_Detail_OneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._Vis_SODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Sales_Order_Header_OneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSalesOrderDetailOneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Sales_Order_Detail_OneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ID_Vis_SODataSet_t_Sales_Order_Header_One";
            reportDataSource1.Value = this.t_Sales_Order_Header_OneBindingSource;
            reportDataSource2.Name = "ID_Vis_SODataSet_t_Sales_Order_Detail_One";
            reportDataSource2.Value = this.t_Sales_Order_Detail_OneBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.rptSOReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(842, 566);
            this.reportViewer1.TabIndex = 0;
            // 
            // _Vis_SODataSet
            // 
            this._Vis_SODataSet.DataSetName = "_Vis_SODataSet";
            this._Vis_SODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_Sales_Order_Header_OneBindingSource
            // 
            this.t_Sales_Order_Header_OneBindingSource.DataMember = "t_Sales_Order_Header_One";
            this.t_Sales_Order_Header_OneBindingSource.DataSource = this._Vis_SODataSet;
            // 
            // t_Sales_Order_Header_OneTableAdapter
            // 
            this.t_Sales_Order_Header_OneTableAdapter.ClearBeforeFill = true;
            // 
            // tSalesOrderDetailOneBindingSource
            // 
            this.tSalesOrderDetailOneBindingSource.DataMember = "t_Sales_Order_Detail_One";
            this.tSalesOrderDetailOneBindingSource.DataSource = this._Vis_SODataSet;
            // 
            // t_Sales_Order_Detail_OneTableAdapter
            // 
            this.t_Sales_Order_Detail_OneTableAdapter.ClearBeforeFill = true;
            // 
            // t_Sales_Order_Detail_OneBindingSource
            // 
            this.t_Sales_Order_Detail_OneBindingSource.DataMember = "t_Sales_Order_Detail_One";
            this.t_Sales_Order_Detail_OneBindingSource.DataSource = this._Vis_SODataSet;
            // 
            // frmSOReport
            // 
            this.ClientSize = new System.Drawing.Size(842, 566);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "frmSOReport";
            this.Text = "frmSOReport";
            this.Load += new System.EventHandler(this.frmSOReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Vis_SODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Sales_Order_Header_OneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSalesOrderDetailOneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Sales_Order_Detail_OneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private void frmSOReport_Load(object sender, EventArgs e)
        {
            this.t_Sales_Order_Header_OneTableAdapter.Fill(this._Vis_SODataSet.t_Sales_Order_Header_One, m_strSO);
            this.t_Sales_Order_Detail_OneTableAdapter.Fill(this._Vis_SODataSet.t_Sales_Order_Detail_One, m_strSO);
            this.reportViewer1.RefreshReport();
        }
    }
}

