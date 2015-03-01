using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;
using System.Data.SqlClient;
namespace G8_POS
{
    /// <summary>
    /// Summary description for ServiceCharge.
    /// </summary>
    public class ServiceCharge : DevExpress.XtraEditors.XtraForm
    {
		
        private PanelControl panelControl1;
        private SimpleButton btnOK;
        private Payment payment;
        private BindingSource serviceChargeBindingSource;
        private G8_POS.PaymentTableAdapters.ServiceChargeTableAdapter serviceChargeTableAdapter;
        private BindingNavigator serviceChargeBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton serviceChargeBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl serviceChargeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSCID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colChargeRate;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colViewStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit bteChargeRate;
        private SimpleButton btnClose;
        private IContainer components;

        public ServiceCharge()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceCharge));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.payment = new G8_POS.Payment();
            this.serviceChargeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceChargeTableAdapter = new G8_POS.PaymentTableAdapters.ServiceChargeTableAdapter();
            this.serviceChargeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.serviceChargeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.serviceChargeGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSCID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChargeRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bteChargeRate = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceChargeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceChargeBindingNavigator)).BeginInit();
            this.serviceChargeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceChargeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteChargeRate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnOK);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(632, 49);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Text = "panelControl1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(545, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::G8_POS.Properties.Settings.Default, "strOK", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnOK.Location = new System.Drawing.Point(464, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = global::G8_POS.Properties.Settings.Default.strOK;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // payment
            // 
            this.payment.DataSetName = "Payment";
            this.payment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceChargeBindingSource
            // 
            this.serviceChargeBindingSource.DataMember = "ServiceCharge";
            this.serviceChargeBindingSource.DataSource = this.payment;
            // 
            // serviceChargeTableAdapter
            // 
            this.serviceChargeTableAdapter.ClearBeforeFill = true;
            // 
            // serviceChargeBindingNavigator
            // 
            this.serviceChargeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.serviceChargeBindingNavigator.BindingSource = this.serviceChargeBindingSource;
            this.serviceChargeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.serviceChargeBindingNavigator.DeleteItem = null;
            this.serviceChargeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.serviceChargeBindingNavigatorSaveItem});
            this.serviceChargeBindingNavigator.Location = new System.Drawing.Point(0, 49);
            this.serviceChargeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.serviceChargeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.serviceChargeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.serviceChargeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.serviceChargeBindingNavigator.Name = "serviceChargeBindingNavigator";
            this.serviceChargeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.serviceChargeBindingNavigator.Size = new System.Drawing.Size(632, 25);
            this.serviceChargeBindingNavigator.TabIndex = 1;
            this.serviceChargeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // serviceChargeBindingNavigatorSaveItem
            // 
            this.serviceChargeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.serviceChargeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("serviceChargeBindingNavigatorSaveItem.Image")));
            this.serviceChargeBindingNavigatorSaveItem.Name = "serviceChargeBindingNavigatorSaveItem";
            this.serviceChargeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.serviceChargeBindingNavigatorSaveItem.Text = "Save Data";
            this.serviceChargeBindingNavigatorSaveItem.Click += new System.EventHandler(this.serviceChargeBindingNavigatorSaveItem_Click);
            // 
            // serviceChargeGridControl
            // 
            this.serviceChargeGridControl.DataSource = this.serviceChargeBindingSource;
            this.serviceChargeGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceChargeGridControl.EmbeddedNavigator.Name = "";
            this.serviceChargeGridControl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.serviceChargeGridControl_EmbeddedNavigator_ButtonClick);
            this.serviceChargeGridControl.Location = new System.Drawing.Point(0, 74);
            this.serviceChargeGridControl.MainView = this.gridView1;
            this.serviceChargeGridControl.Name = "serviceChargeGridControl";
            this.serviceChargeGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.bteChargeRate});
            this.serviceChargeGridControl.Size = new System.Drawing.Size(632, 307);
            this.serviceChargeGridControl.TabIndex = 2;
            this.serviceChargeGridControl.UseEmbeddedNavigator = true;
            this.serviceChargeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSCID,
            this.colName,
            this.colChargeRate,
            this.colNotes,
            this.colViewStatus});
            this.gridView1.GridControl = this.serviceChargeGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colSCID
            // 
            this.colSCID.Caption = "SCID";
            this.colSCID.FieldName = "SCID";
            this.colSCID.Name = "colSCID";
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colChargeRate
            // 
            this.colChargeRate.Caption = "ChargeRate";
            this.colChargeRate.ColumnEdit = this.bteChargeRate;
            this.colChargeRate.FieldName = "ChargeRate";
            this.colChargeRate.Name = "colChargeRate";
            this.colChargeRate.Visible = true;
            this.colChargeRate.VisibleIndex = 1;
            // 
            // bteChargeRate
            // 
            this.bteChargeRate.AutoHeight = false;
            this.bteChargeRate.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bteChargeRate.Mask.EditMask = "f";
            this.bteChargeRate.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.bteChargeRate.Mask.UseMaskAsDisplayFormat = true;
            this.bteChargeRate.Name = "bteChargeRate";
            this.bteChargeRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bteChargeRate_KeyPress);
            this.bteChargeRate.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.bteChargeRate_EditValueChanging);
            this.bteChargeRate.EditValueChanged += new System.EventHandler(this.bteChargeRate_EditValueChanged);
            // 
            // colNotes
            // 
            this.colNotes.Caption = "Notes";
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 2;
            // 
            // colViewStatus
            // 
            this.colViewStatus.Caption = "View Status";
            this.colViewStatus.FieldName = "View Status";
            this.colViewStatus.Name = "colViewStatus";
            this.colViewStatus.Visible = true;
            this.colViewStatus.VisibleIndex = 3;
            // 
            // ServiceCharge
            // 
            this.ClientSize = new System.Drawing.Size(632, 381);
            this.Controls.Add(this.serviceChargeGridControl);
            this.Controls.Add(this.serviceChargeBindingNavigator);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServiceCharge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Service Charge Administration";
            this.Load += new System.EventHandler(this.ServiceCharge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceChargeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceChargeBindingNavigator)).EndInit();
            this.serviceChargeBindingNavigator.ResumeLayout(false);
            this.serviceChargeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceChargeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteChargeRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void serviceChargeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.serviceChargeBindingSource.EndEdit();
            this.serviceChargeTableAdapter.Update(this.payment.ServiceCharge);

        }

        public string Connection;

        private void ServiceCharge_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payment.ServiceCharge' table. You can move, or remove it, as needed.
            this.serviceChargeTableAdapter.Fill(this.payment.ServiceCharge);
            if (isAdmin)
            {
                gridView1.Columns["View Status"].OptionsColumn.AllowEdit = true;
            }
            else
            {
                gridView1.Columns["View Status"].OptionsColumn.AllowEdit = false;
                serviceChargeBindingSource.Filter = "[View Status] = true";

            }

        }

        private bool isAdmin;

        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        private void bteChargeRate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
        }

        private void bteChargeRate_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void bteChargeRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-') e.Handled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
				for (int i = 0; i < gridView1.RowCount; i++)
				{
					if ((gridView1.GetDataRow(i))["Name"].ToString() == "" || (gridView1.GetDataRow(i))["Name"] == null)
					{

						gridView1.GetDataRow(i).Delete();
					}
					//else
					//{
					//    if ((gridView1.GetDataRow(i))["ChargeRate"].ToString() == "" || (gridView1.GetDataRow(i))["ChargeRate"] == null)
					//    gridView1.GetDataRow(i)["ChargeRate"] = 0;
					//    if(gridView1.GetDataRow(i)["ViewStatus"] == null)
					//    gridView1.GetDataRow(i)["ViewStatus"] = false;
					//}
					
				}
                Hashtable hst = new Hashtable();
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    String s = gridView1.GetDataRow(i)["Name"].ToString().Trim().ToUpper();
                    if (hst.ContainsKey(s))
                    {
                        MessageBox.Show("Dublicate item: " + gridView1.GetDataRow(i)["Name"].ToString().Trim());
                        return;
                    }
                    else
                        hst.Add(s, s);
                }

                serviceChargeTableAdapter.Update(payment);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

		private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
		{
			
			 
		}

		private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
		{
			//DevExpress.XtraGrid.Views.Base.ColumnView view = sender as DevExpress.XtraGrid.Views.Base.ColumnView;
			//view.SetRowCellValue(e.RowHandle, view.Columns["SCID"],System.Guid.NewGuid().ToString());
			InitProcess(e.RowHandle);
		}

		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			InitProcess(gridView1.RowCount-1);
			
		}
		private void InitProcess(int rowNumber)
		{
			gridView1.SetRowCellValue(rowNumber, gridView1.Columns["SCID"], System.Guid.NewGuid().ToString());
			gridView1.SetRowCellValue(rowNumber, gridView1.Columns["ChargeRate"], 0);
			gridView1.SetRowCellValue(rowNumber, gridView1.Columns["View Status"],false);
		}

        private void serviceChargeGridControl_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                SqlConnection con = new SqlConnection(Connection);
                con.Open();                
                    
                DataRow r = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
                String sql = "SELECT * FROM t_OrderMaster WHERE ServiceCharge = '" + r["SCID"].ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("This record cannot be deleted. This record may be using in other form");
                    e.Handled = true;
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connection);
            con.Open();

            DataRow r = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            String sql = "SELECT * FROM t_OrderMaster WHERE ServiceCharge = '" + r["SCID"].ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("This record cannot be deleted. This record may be using in other form");
                return;
            }
            serviceChargeGridControl.EmbeddedNavigator.Buttons.Remove.DoClick();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

