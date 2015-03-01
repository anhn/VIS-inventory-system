using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using Inventory.Process.StockTake;
using System.Data.SqlClient;
using Inventory.DataModels.StockTake;
using Inventory.Commands.StockTake;

namespace Inventory
{
    /// <summary>
    /// Summary description for frmOpenClosePeriod.
    /// </summary>
    public class frmOpenClosePeriod : DevExpress.XtraEditors.XtraForm
    {
        private DevExpress.XtraGrid.GridControl grdPeriod;
        private SimpleButton btLock;
        private SimpleButton btUnlock;
        private SimpleButton btClose;
        private SimpleButton btOK;
        private GridView gridView1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmOpenClosePeriod()
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
            this.grdPeriod = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btLock = new DevExpress.XtraEditors.SimpleButton();
            this.btUnlock = new DevExpress.XtraEditors.SimpleButton();
            this.btClose = new DevExpress.XtraEditors.SimpleButton();
            this.btOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPeriod
            // 
            this.grdPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.grdPeriod.EmbeddedNavigator.Name = "";
            this.grdPeriod.Location = new System.Drawing.Point(0, 0);
            this.grdPeriod.MainView = this.gridView1;
            this.grdPeriod.Name = "grdPeriod";
            this.grdPeriod.Size = new System.Drawing.Size(465, 331);
            this.grdPeriod.TabIndex = 0;
            this.grdPeriod.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdPeriod;
            this.gridView1.Name = "gridView1";
            // 
            // btLock
            // 
            this.btLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLock.Location = new System.Drawing.Point(12, 347);
            this.btLock.Name = "btLock";
            this.btLock.Size = new System.Drawing.Size(75, 23);
            this.btLock.TabIndex = 1;
            this.btLock.Text = "Lock";
            this.btLock.Click += new System.EventHandler(this.btLock_Click);
            // 
            // btUnlock
            // 
            this.btUnlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btUnlock.Location = new System.Drawing.Point(109, 347);
            this.btUnlock.Name = "btUnlock";
            this.btUnlock.Size = new System.Drawing.Size(75, 23);
            this.btUnlock.TabIndex = 2;
            this.btUnlock.Text = "Unlock";
            this.btUnlock.Click += new System.EventHandler(this.btUnlock_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.Location = new System.Drawing.Point(373, 347);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Close";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btOK
            // 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOK.Location = new System.Drawing.Point(276, 347);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 3;
            this.btOK.Text = "OK";
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // frmOpenClosePeriod
            // 
            this.ClientSize = new System.Drawing.Size(465, 382);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btUnlock);
            this.Controls.Add(this.btLock);
            this.Controls.Add(this.grdPeriod);
            this.Name = "frmOpenClosePeriod";
            this.Text = "frmOpenClosePeriod";
            this.Load += new System.EventHandler(this.frmOpenClosePeriod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private void btClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private DataView dtvPeriod;
        private GridView grvPeriod;

        private void frmOpenClosePeriod_Load(object sender, EventArgs e)
        {
            grvPeriod = (GridView)grdPeriod.Views[0];
            grvPeriod.Columns.Clear();
            dtvPeriod = new DataView(Globals.dtOperationPeriod);
            grdPeriod.DataSource = dtvPeriod;
            grvPeriod.Columns["ID"].VisibleIndex = -1;
            grvPeriod.Columns["PeriodTypeID"].VisibleIndex = -1;
            grvPeriod.Columns["ViewStatus"].VisibleIndex = -1;
            grvPeriod.Columns["Description"].OptionsColumn.AllowEdit = false;
            grvPeriod.Columns["StartDate"].OptionsColumn.AllowEdit = false;
            grvPeriod.Columns["EndDate"].OptionsColumn.AllowEdit = false;
            grvPeriod.Columns["Status"].OptionsColumn.AllowEdit = false;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save all records?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.DialogResult = DialogResult.OK;
            else this.DialogResult = DialogResult.Cancel;
        }

        private void btLock_Click(object sender, EventArgs e)
        {
            if (grvPeriod.RowCount == 0 || grvPeriod.FocusedRowHandle < 0)
            {
                MessageBox.Show("There is no item to lock", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRow row = grvPeriod.GetDataRow(grvPeriod.FocusedRowHandle);
            /*
            PeriodClosingModel model = new PeriodClosingModel();
            model.Description = row["Description"].ToString();
            model.Type = row["PeriodTypeID"].ToString();
            model.ID = row["ID"].ToString();
            model.EndDate = DateTime.Parse(row["EndDate"].ToString());
            model.StartDate = DateTime.Parse(row["StartDate"].ToString());
            model.Status = bool.Parse(row["ViewStatus"].ToString());
            if (row["Status"].ToString() == "Open")
                model.State = true;
            else model.State = false;
            string strSQL = "SELECT * FROM PeriodType WHERE ID = '" + model.Type + "'";
            if (!Data_Access.DoSqlCommand(strSQL)) return;
            row = Data_Access.GetDataSet().Tables[0].Copy().Rows[0];
            model.TypeName = row["Name"].ToString();
            ClosePeriodCommand cmdClose = new ClosePeriodCommand();
            cmdClose.Close(model);*/
            row["Status"] = "Close";
            MessageBox.Show("The period is closed");
            frmOpenClosePeriod_Load(null, null);
        }

        private void btUnlock_Click(object sender, EventArgs e)
        {
            if (grvPeriod.RowCount == 0 || grvPeriod.FocusedRowHandle < 0)
            {
                MessageBox.Show("There is no item to unlock", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRow row = grvPeriod.GetDataRow(grvPeriod.FocusedRowHandle);
            row["Status"] = "Open";
            MessageBox.Show("The period is opened");
            frmOpenClosePeriod_Load(null, null);
        }
    }
}

