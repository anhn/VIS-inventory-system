using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.Reporting.WinForms;

namespace Inventory
{
    /// <summary>
    /// Summary description for frmPOReport.
    /// </summary>
    public class frmPOReport : DevExpress.XtraEditors.XtraForm
    {
        private IContainer components;
        private _Vis_PODataSet _Vis_PODataSet;
        private Inventory._Vis_PODataSetTableAdapters.t_Purchase_Order_Detail_OneTableAdapter t_Purchase_Order_Detail_OneTableAdapter;
        private Inventory._Vis_PODataSetTableAdapters.t_Purchase_Order_Header_OneTableAdapter t_Purchase_Order_Header_OneTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BindingSource tPurchaseOrderHeaderOneBindingSource;
        private BindingSource tPurchaseOrderDetailOneBindingSource;
        private BindingSource t_Purchase_Order_Detail_OneBindingSource;
        private string m_strPONumber;

        public frmPOReport(string strPONumber)
        {
            m_strPONumber = strPONumber;
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
            this.t_Purchase_Order_Detail_OneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Vis_PODataSet = new Inventory._Vis_PODataSet();
            this.tPurchaseOrderHeaderOneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_Purchase_Order_Detail_OneTableAdapter = new Inventory._Vis_PODataSetTableAdapters.t_Purchase_Order_Detail_OneTableAdapter();
            this.t_Purchase_Order_Header_OneTableAdapter1 = new Inventory._Vis_PODataSetTableAdapters.t_Purchase_Order_Header_OneTableAdapter();
            this.tPurchaseOrderDetailOneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.t_Purchase_Order_Detail_OneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Vis_PODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPurchaseOrderHeaderOneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPurchaseOrderDetailOneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ID_Vis_PODataSet_t_Purchase_Order_Detail_One";
            reportDataSource1.Value = this.t_Purchase_Order_Detail_OneBindingSource;
            reportDataSource2.Name = "ID_Vis_PODataSet_t_Purchase_Order_Header_One";
            reportDataSource2.Value = this.tPurchaseOrderHeaderOneBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.rptPurchageOrderReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(842, 566);
            this.reportViewer1.TabIndex = 0;
            // 
            // t_Purchase_Order_Detail_OneBindingSource
            // 
            this.t_Purchase_Order_Detail_OneBindingSource.DataMember = "t_Purchase_Order_Detail_One";
            this.t_Purchase_Order_Detail_OneBindingSource.DataSource = this._Vis_PODataSet;
            // 
            // _Vis_PODataSet
            // 
            this._Vis_PODataSet.DataSetName = "_Vis_PODataSet";
            this._Vis_PODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tPurchaseOrderHeaderOneBindingSource
            // 
            this.tPurchaseOrderHeaderOneBindingSource.DataMember = "t_Purchase_Order_Header_One";
            this.tPurchaseOrderHeaderOneBindingSource.DataSource = this._Vis_PODataSet;
            // 
            // t_Purchase_Order_Detail_OneTableAdapter
            // 
            this.t_Purchase_Order_Detail_OneTableAdapter.ClearBeforeFill = true;
            // 
            // t_Purchase_Order_Header_OneTableAdapter1
            // 
            this.t_Purchase_Order_Header_OneTableAdapter1.ClearBeforeFill = true;
            // 
            // tPurchaseOrderDetailOneBindingSource
            // 
            this.tPurchaseOrderDetailOneBindingSource.DataMember = "t_Purchase_Order_Detail_One";
            this.tPurchaseOrderDetailOneBindingSource.DataSource = this._Vis_PODataSet;
            // 
            // frmPOReport
            // 
            this.ClientSize = new System.Drawing.Size(842, 566);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "frmPOReport";
            this.Text = "frmPOReport";
            this.Load += new System.EventHandler(this.frmPOReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t_Purchase_Order_Detail_OneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Vis_PODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPurchaseOrderHeaderOneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPurchaseOrderDetailOneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private void frmPOReport_Load(object sender, EventArgs e)
        {
            this.t_Purchase_Order_Header_OneTableAdapter1.Fill(this._Vis_PODataSet.t_Purchase_Order_Header_One, m_strPONumber);
            this.t_Purchase_Order_Detail_OneTableAdapter.Fill(this._Vis_PODataSet.t_Purchase_Order_Detail_One, m_strPONumber);
            this.reportViewer1.RefreshReport();
        }
    }
}

