using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
//using POS.ViewVB;

namespace G8_POS
{
    /// <summary>
    /// Summary description for PaymentMethod.
    /// </summary>
    public class PaymentMethod : DevExpress.XtraEditors.XtraForm
    {
        private PanelControl panelControl1;
        private Payment payment;
        private BindingSource paymentMethodBindingSource;
        private G8_POS.PaymentTableAdapters.PaymentMethodTableAdapter paymentMethodTableAdapter;
        private BindingNavigator paymentMethodBindingNavigator;
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
        private ToolStripButton paymentMethodBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl paymentMethodGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPMID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colViewStatus;
        private SimpleButton btnOK;
        private SimpleButton simpleButton1;
        private IContainer components;

        public PaymentMethod()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentMethod));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.payment = new G8_POS.Payment();
            this.paymentMethodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentMethodTableAdapter = new G8_POS.PaymentTableAdapters.PaymentMethodTableAdapter();
            this.paymentMethodBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.paymentMethodBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.paymentMethodGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingNavigator)).BeginInit();
            this.paymentMethodBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btnOK);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(469, 37);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Text = "panelControl1";
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(309, 8);
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
            // paymentMethodBindingSource
            // 
            this.paymentMethodBindingSource.DataMember = "PaymentMethod";
            this.paymentMethodBindingSource.DataSource = this.payment;
            // 
            // paymentMethodTableAdapter
            // 
            this.paymentMethodTableAdapter.ClearBeforeFill = true;
            // 
            // paymentMethodBindingNavigator
            // 
            this.paymentMethodBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.paymentMethodBindingNavigator.BindingSource = this.paymentMethodBindingSource;
            this.paymentMethodBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.paymentMethodBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.paymentMethodBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.paymentMethodBindingNavigatorSaveItem});
            this.paymentMethodBindingNavigator.Location = new System.Drawing.Point(0, 37);
            this.paymentMethodBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paymentMethodBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paymentMethodBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paymentMethodBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paymentMethodBindingNavigator.Name = "paymentMethodBindingNavigator";
            this.paymentMethodBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.paymentMethodBindingNavigator.Size = new System.Drawing.Size(469, 25);
            this.paymentMethodBindingNavigator.TabIndex = 1;
            this.paymentMethodBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // paymentMethodBindingNavigatorSaveItem
            // 
            this.paymentMethodBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paymentMethodBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentMethodBindingNavigatorSaveItem.Image")));
            this.paymentMethodBindingNavigatorSaveItem.Name = "paymentMethodBindingNavigatorSaveItem";
            this.paymentMethodBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.paymentMethodBindingNavigatorSaveItem.Text = "Save Data";
            this.paymentMethodBindingNavigatorSaveItem.Click += new System.EventHandler(this.paymentMethodBindingNavigatorSaveItem_Click);
            // 
            // paymentMethodGridControl
            // 
            this.paymentMethodGridControl.DataSource = this.paymentMethodBindingSource;
            this.paymentMethodGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.paymentMethodGridControl.EmbeddedNavigator.Name = "";
            this.paymentMethodGridControl.Location = new System.Drawing.Point(0, 62);
            this.paymentMethodGridControl.MainView = this.gridView1;
            this.paymentMethodGridControl.Name = "paymentMethodGridControl";
            this.paymentMethodGridControl.Size = new System.Drawing.Size(469, 300);
            this.paymentMethodGridControl.TabIndex = 2;
            this.paymentMethodGridControl.UseEmbeddedNavigator = true;
            this.paymentMethodGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPMID,
            this.colName,
            this.colNotes,
            this.colViewStatus});
            this.gridView1.GridControl = this.paymentMethodGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            // 
            // colPMID
            // 
            this.colPMID.Caption = "PMID";
            this.colPMID.FieldName = "PMID";
            this.colPMID.Name = "colPMID";
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colNotes
            // 
            this.colNotes.Caption = "Notes";
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 1;
            // 
            // colViewStatus
            // 
            this.colViewStatus.Caption = "View Status";
            this.colViewStatus.FieldName = "View Status";
            this.colViewStatus.Name = "colViewStatus";
            this.colViewStatus.Visible = true;
            this.colViewStatus.VisibleIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(390, 8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "&Close";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // PaymentMethod
            // 
            this.ClientSize = new System.Drawing.Size(469, 362);
            this.Controls.Add(this.paymentMethodGridControl);
            this.Controls.Add(this.paymentMethodBindingNavigator);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentMethod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment Method Administration";
            this.Load += new System.EventHandler(this.PaymentMethod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingNavigator)).EndInit();
            this.paymentMethodBindingNavigator.ResumeLayout(false);
            this.paymentMethodBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void paymentMethodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.paymentMethodBindingSource.EndEdit();
                this.paymentMethodTableAdapter.Update(this.payment.PaymentMethod);

                MessageBox.Show("Data is saved.", "System Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PaymentMethod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payment.PaymentMethod' table. You can move, or remove it, as needed.
            this.paymentMethodTableAdapter.Fill(this.payment.PaymentMethod);
            
            if (isAdmin)
            {
                gridView1.Columns["View Status"].OptionsColumn.AllowEdit = true;
            }
            else
            {
                gridView1.Columns["View Status"].OptionsColumn.AllowEdit = false;
                paymentMethodBindingSource.Filter = "[View Status] = true";

            }
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
                paymentMethodTableAdapter.Update(payment);
                MessageBox.Show("Data is saved");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool isAdmin ;
        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			InitProcess(gridView1.RowCount - 1);
		}

		private void InitProcess(int rowNumber)
		{
			gridView1.SetRowCellValue(rowNumber, gridView1.Columns["PMID"], System.Guid.NewGuid().ToString());
			gridView1.SetRowCellValue(rowNumber, gridView1.Columns["View Status"], false);
		}

		private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
		{
			InitProcess(e.RowHandle);
		}

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            for (int i = 0; i < this.payment.PaymentMethod.Rows.Count; i++)
            {
                if (this.payment.PaymentMethod.Rows[i]["Name"].ToString() == gridView1.GetRowCellDisplayText(e.RowHandle, "Name"))
                {
                    if (i != e.RowHandle)
                    {
                        e.Valid = false;
                        e.ErrorText = "Payment Method cannot duplicate";
                    }
                }
            }


            if (gridView1.GetRowCellDisplayText(e.RowHandle, "Name").Trim() == "")
            {
                e.Valid = false;
                e.ErrorText = "Field Name empty";
            }
        }


        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

