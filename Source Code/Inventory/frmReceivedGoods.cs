using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using Inventory.Forms.Binder;

namespace Inventory
{
    /// <summary>
    /// Summary description for frmReceivedGoods.
    /// </summary>
    public class frmReceivedGoods : DevExpress.XtraEditors.XtraForm
    {
        private Label label1;
        private DevExpress.XtraGrid.GridControl gridProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView grvReceivedGood;
        private SimpleButton btnClose;
        private SimpleButton btnSave;
        private TextEdit txtPONo;
        private GroupBox groupBox1;
        private RadioGroup rdoStatus;
        private TextEdit txtCost;
        private TextEdit txtQuantity;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private SimpleButton btnAdd;
        private DateTimePicker dtmDate;
        private ComboBoxEdit cboProduct;

        private DataTable m_oProductIDTable = new DataTable();
        private DataTable m_oProductTable = new DataTable();
        private string m_strReceivedFoodID = "";
        private ComboBoxEdit cboPONo;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmReceivedGoods()
        {
            InitializeComponent();
        }

        public frmReceivedGoods(string strReceivedID)
        {
            InitializeComponent();
            m_strReceivedFoodID = strReceivedID;            
            btnAdd.Visible = false;
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridProduct = new DevExpress.XtraGrid.GridControl();
            this.grvReceivedGood = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtPONo = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboProduct = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtmDate = new System.Windows.Forms.DateTimePicker();
            this.rdoStatus = new DevExpress.XtraEditors.RadioGroup();
            this.txtCost = new DevExpress.XtraEditors.TextEdit();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.cboPONo = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvReceivedGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPONo.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPONo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PO No:";
            // 
            // gridProduct
            // 
            this.gridProduct.EmbeddedNavigator.Name = "";
            this.gridProduct.Location = new System.Drawing.Point(12, 194);
            this.gridProduct.MainView = this.grvReceivedGood;
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.Size = new System.Drawing.Size(620, 215);
            this.gridProduct.TabIndex = 10;
            this.gridProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvReceivedGood});
            this.gridProduct.Click += new System.EventHandler(this.gridProduct_Click);
            // 
            // grvReceivedGood
            // 
            this.grvReceivedGood.GridControl = this.gridProduct;
            this.grvReceivedGood.Name = "grvReceivedGood";
            this.grvReceivedGood.OptionsView.ShowGroupPanel = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(557, 165);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(476, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPONo
            // 
            this.txtPONo.Location = new System.Drawing.Point(108, 18);
            this.txtPONo.Name = "txtPONo";
            this.txtPONo.Size = new System.Drawing.Size(218, 20);
            this.txtPONo.TabIndex = 10;
            this.txtPONo.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboProduct);
            this.groupBox1.Controls.Add(this.dtmDate);
            this.groupBox1.Controls.Add(this.rdoStatus);
            this.groupBox1.Controls.Add(this.txtCost);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 107);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product detail";
            // 
            // cboProduct
            // 
            this.cboProduct.Location = new System.Drawing.Point(96, 49);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboProduct.Size = new System.Drawing.Size(218, 20);
            this.cboProduct.TabIndex = 3;
            // 
            // dtmDate
            // 
            this.dtmDate.CustomFormat = "mm/dd/yyyy";
            this.dtmDate.Location = new System.Drawing.Point(96, 22);
            this.dtmDate.Name = "dtmDate";
            this.dtmDate.Size = new System.Drawing.Size(218, 20);
            this.dtmDate.TabIndex = 2;
            // 
            // rdoStatus
            // 
            this.rdoStatus.Location = new System.Drawing.Point(367, 21);
            this.rdoStatus.Name = "rdoStatus";
            this.rdoStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Received"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Returned"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Receivable"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Returnable")});
            this.rdoStatus.Size = new System.Drawing.Size(233, 47);
            this.rdoStatus.TabIndex = 5;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(367, 75);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(233, 20);
            this.txtCost.TabIndex = 6;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(96, 75);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(218, 20);
            this.txtQuantity.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Product ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Received date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Product list:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(341, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Add new  product";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboPONo
            // 
            this.cboPONo.Location = new System.Drawing.Point(108, 18);
            this.cboPONo.Name = "cboPONo";
            this.cboPONo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPONo.Size = new System.Drawing.Size(218, 20);
            this.cboPONo.TabIndex = 1;
            this.cboPONo.SelectedIndexChanged += new System.EventHandler(this.cboPONo_SelectedIndexChanged);
            // 
            // frmReceivedGoods
            // 
            this.ClientSize = new System.Drawing.Size(644, 421);
            this.Controls.Add(this.cboPONo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPONo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridProduct);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReceivedGoods";
            this.RightToLeftLayout = true;
            this.Text = "Received Goods";
            this.Load += new System.EventHandler(this.frmReceivedGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvReceivedGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPONo.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPONo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Set_Enable_Control(true);
        }

        private void Set_Enable_Control(bool bDisplay)
        {
            txtCost.Enabled = bDisplay;
            txtPONo.Enabled = bDisplay;
            cboPONo.Enabled = bDisplay;
            txtQuantity.Enabled = bDisplay;
            cboProduct.Enabled = bDisplay;
            dtmDate.Enabled = bDisplay;
            btnAdd.Enabled = !bDisplay;
            btnSave.Enabled = bDisplay;
        }

        private bool IsDataValid()
        {
            try
            {
               /*
                if (txtPONo.Text.Trim().Length == 0)
                {
                    throw new Exception("Purchase Order Number can not be blank.");
                }
                */
                if (cboPONo.SelectedIndex < 0)
                {
                    throw new Exception("Purchase Order Number can not be blank.");
                }

                if (cboProduct.SelectedIndex < 0)
                {
                    throw new Exception("No product has been selected.");
                }                

                Int32.Parse(txtQuantity.Text.Trim());
                Decimal.Parse(txtCost.Text.Trim());
            }
            catch (Exception oExc)
            {
                MessageBox.Show(oExc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (m_strReceivedFoodID.Equals(""))
            {
                Set_Enable_Control(false);
            }

            // Validate input value
            if (!IsDataValid())
            {
                return;
            }

            // Insert new Receive Goodxt
            string strProductID = ((XTagItem)cboProduct.SelectedItem).Value;
            string strSQL = "";

            // Check ADD or Update mode
            if (m_strReceivedFoodID.Equals(""))
            {
               strSQL = String.Format("Insert Into inv_ReceivedGood Values ('{0}','{1}','{2}','{3}',{4},{5},{6})",
                                        Guid.NewGuid().ToString(), DateTime.Parse(dtmDate.Text).ToString("MM/dd/yyyy"), cboPONo.SelectedItem.ToString(), strProductID, txtQuantity.Text, 
                                        rdoStatus.EditValue.ToString(), txtCost.Text);
            }
            else
            {
                GridView oView = (GridView)gridProduct.Views[0];
                DataRow oRow = oView.GetDataRow(oView.GetSelectedRows()[0]);
                string strReceivedID = oRow["ID"].ToString();

                strSQL = String.Format("Update inv_ReceivedGood Set ReceivedDate='{0}',PONo='{1}',OrderProductID='{2}',Quantity={3},Type={4},Cost={5} Where inv_ReceivedGood.ID = '{6}'",
                                        DateTime.Parse(dtmDate.Text).ToString("MM/dd/yyyy"), cboPONo.SelectedItem.ToString(), strProductID, txtQuantity.Text, 
                                        rdoStatus.EditValue.ToString(), txtCost.Text, strReceivedID);
            }

            Execute(strSQL);

            // Refresh data
            frmReceivedGoods_Load(sender, e);
            btnSave.Enabled = false;
        }

        private void Execute(string strSQL)
        {
            SqlConnection oConnection = new SqlConnection(Globals.strVISConnection);
            oConnection.Open();
            SqlCommand oCommand = new SqlCommand();
            oCommand.CommandText = strSQL;
            oCommand.Connection = oConnection;
            oCommand.Transaction = oConnection.BeginTransaction();
            oCommand.ExecuteNonQuery();
            oCommand.Transaction.Commit();
            oConnection.Close();
        }

        private DataTable GetTable(string strSQL)
        {
            SqlConnection oConnection = new SqlConnection(Globals.strVISConnection);
            oConnection.Open();
            DataTable oTable = new DataTable();
            SqlDataAdapter oAdapter = new SqlDataAdapter(strSQL, oConnection);
            oAdapter.Fill(oTable);
            oConnection.Close();

            return oTable;
        }

        private void frmReceivedGoods_Load(object sender, EventArgs e)
        {
            // Check if Add mode so load and set corresponding status for UI
            DataTable tempTable = GetTable("Select PONo From t_Purchase_Order_Header Where ViewStatus = 'true' order by PONo");
            cboPONo.Properties.Items.Clear();
            for (int i = 0; i < tempTable.Rows.Count; i++)
                cboPONo.Properties.Items.Add(tempTable.Rows[i][0].ToString());

            // Check to set control of UI

            if (m_strReceivedFoodID.Equals(""))
            {
                rdoStatus.SelectedIndex = 0;
                Set_Enable_Control(false);
            }
            else
            {
                GridView oView = (GridView)gridProduct.Views[0];
                // If Edit mode
                if (oView.SelectedRowsCount <= 0)
                {
                    DisplayReceivedGood(m_strReceivedFoodID);
                }
                else
                {
                    DataRow oRow = oView.GetDataRow(oView.GetSelectedRows()[0]);
                    string strReceivedID = oRow["ID"].ToString();
                    DisplayReceivedGood(strReceivedID);
                }
            }
            
            m_oProductTable.Rows.Clear();
            string strCurrentPONo = "";
            
            // Get selected PO number
            if (cboPONo.SelectedIndex >= 0)
            {
                strCurrentPONo = cboPONo.SelectedItem.ToString();
            }

            // Load product list for combo
            LoadProductList(strCurrentPONo);

            // Load data for grid
            if (strCurrentPONo.Equals(""))
            {                
                m_oProductTable = GetTable("Select inv_ReceivedGood.ID,PONo, ReceivedDate,ProductMaster.ProductName,inv_ReceivedGood.Type,inv_ReceivedGood.Quantity,inv_ReceivedGood.Cost, (inv_ReceivedGood.Cost*inv_ReceivedGood.Quantity) As Amount From inv_ReceivedGood, ProductMaster Where inv_ReceivedGood.OrderProductID = ProductMaster.ProductID Order By inv_ReceivedGood.ReceivedDate");
            }
            else
            {
                m_oProductTable = GetTable(String.Format("Select inv_ReceivedGood.ID,PONo, ReceivedDate,ProductMaster.ProductName,inv_ReceivedGood.Type,inv_ReceivedGood.Quantity,inv_ReceivedGood.Cost, (inv_ReceivedGood.Cost*inv_ReceivedGood.Quantity) As Amount From inv_ReceivedGood, ProductMaster Where inv_ReceivedGood.OrderProductID = ProductMaster.ProductID And PONo = '{0}' Order By inv_ReceivedGood.ReceivedDate", strCurrentPONo));
            }

            gridProduct.DataSource = m_oProductTable;
            ((GridView)gridProduct.Views[0]).Columns["ID"].Visible = false;
            ((GridView)gridProduct.Views[0]).Columns["ProductName"].Caption = "Product Name";
            ((GridView)gridProduct.Views[0]).Columns["ReceivedDate"].Caption = "Received Date";
            
            // Display again for combo
            if (!m_strReceivedFoodID.Equals(""))
            {
                DisplayReceivedGood(m_strReceivedFoodID);
            }

            // Temporary do not allow user edit on details grid            
        }
        private void LoadProductList(string PONo)
        {
            cboProduct.Properties.Items.Clear();
            DataTable temTable;

            if (PONo.Equals(""))
            {
                temTable = GetTable("Select ProductID,ProductName From ProductMaster Where ProductID in (Select POProductID from t_Purchase_Order_Detail)");
            }
            else
            {
                temTable = GetTable("Select ProductID,ProductName From ProductMaster Where ProductID in (Select POProductID from t_Purchase_Order_Detail Where PONo = '" + PONo + "')");
            }

            for (int nCount = 0; nCount < temTable.Rows.Count; nCount++)
            {
                cboProduct.Properties.Items.Add(new XTagItem(temTable.Rows[nCount][0].ToString(),temTable.Rows[nCount][1].ToString()));
            }
        }

        /// <summary>
        /// This method is to display general received good information of PO
        /// </summary>
        /// <param name="strReceivedID"></param>
        private void DisplayReceivedGood(string strReceivedID)
        {
            DataTable oTable = GetTable(String.Format("Select inv_ReceivedGood.ID,PONo, ReceivedDate,ProductMaster.ProductID,inv_ReceivedGood.Quantity,inv_ReceivedGood.Type,inv_ReceivedGood.Cost From inv_ReceivedGood, ProductMaster Where inv_ReceivedGood.OrderProductID = ProductMaster.ProductID And inv_ReceivedGood.ID = '{0}'", strReceivedID));            
            for (int i= 0; i< cboPONo.Properties.Items.Count;i++)
            {
                if (cboPONo.Properties.Items[i].ToString() == oTable.Rows[0].ItemArray[1].ToString())
                {
                    cboPONo.SelectedIndex = i;
                    break;
                }
            }
            //txtPONo.Text = oTable.Rows[0].ItemArray[1].ToString();
            dtmDate.Text = oTable.Rows[0].ItemArray[2].ToString();

            int nProductID = 0;
            for (int nCount = 0; nCount < m_oProductIDTable.Rows.Count; nCount++)
            {
                if (m_oProductIDTable.Rows[nCount].ItemArray[0].ToString().Trim().Equals(oTable.Rows[0].ItemArray[3].ToString().Trim()))
                {
                    nProductID = nCount;
                }
            }
            cboProduct.SelectedIndex = nProductID;

            txtQuantity.Text = oTable.Rows[0].ItemArray[4].ToString();
            rdoStatus.EditValue = Int32.Parse(oTable.Rows[0].ItemArray[5].ToString());
            txtCost.Text = oTable.Rows[0].ItemArray[6].ToString();
        }

        private void gridProduct_Click(object sender, EventArgs e)
        {
            GridView oView = (GridView)gridProduct.Views[0];

            if (oView.SelectedRowsCount <= 0) return;

            DataRow oRow = oView.GetDataRow(oView.GetSelectedRows()[0]);
            string strReceivedID = oRow["ID"].ToString();
            DisplayReceivedGood(strReceivedID);
            btnSave.Enabled = true;
        }

        private void cboPONo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadProductList(cboPONo.SelectedItem.ToString());

            // Re-display details table and combo box
            string strCurrentPONo = "";

            // Get selected PO number
            if (cboPONo.SelectedIndex >= 0)
            {
                strCurrentPONo = cboPONo.SelectedItem.ToString();
            }

            // Load product list for combo
            LoadProductList(strCurrentPONo);

            // Load data for grid
            if (strCurrentPONo.Equals(""))
            {
                m_oProductTable = GetTable("Select inv_ReceivedGood.ID,PONo, ReceivedDate,ProductMaster.ProductName,inv_ReceivedGood.Type,inv_ReceivedGood.Quantity,inv_ReceivedGood.Cost, (inv_ReceivedGood.Cost*inv_ReceivedGood.Quantity) As Amount From inv_ReceivedGood, ProductMaster Where inv_ReceivedGood.OrderProductID = ProductMaster.ProductID Order By inv_ReceivedGood.ReceivedDate");
            }
            else
            {
                m_oProductTable = GetTable(String.Format("Select inv_ReceivedGood.ID,PONo, ReceivedDate,ProductMaster.ProductName,inv_ReceivedGood.Type,inv_ReceivedGood.Quantity,inv_ReceivedGood.Cost, (inv_ReceivedGood.Cost*inv_ReceivedGood.Quantity) As Amount From inv_ReceivedGood, ProductMaster Where inv_ReceivedGood.OrderProductID = ProductMaster.ProductID And PONo = '{0}' Order By inv_ReceivedGood.ReceivedDate", strCurrentPONo));
            }

            gridProduct.DataSource = m_oProductTable;
            ((GridView)gridProduct.Views[0]).Columns["ID"].Visible = false;
            ((GridView)gridProduct.Views[0]).Columns["ProductName"].Caption = "Product Name";
            ((GridView)gridProduct.Views[0]).Columns["ReceivedDate"].Caption = "Received Date";
        }
    }
}

