using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;


namespace Inventory
{
    /// <summary>
    /// Summary description for frmAddEditProductLocation.
    /// </summary>
    public class frmAddEditProductLocation : DevExpress.XtraEditors.XtraForm
    {
        private TextEdit txtQtyOnHand;
        private TextEdit txtAllocate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private SimpleButton btnOK;
        private SimpleButton btnCancel;
        private G8Control.G8Combobox cboLocation;
        private ComboBoxEdit cboProduct;
        private SimpleButton btnSearch;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmAddEditProductLocation()
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
            this.txtQtyOnHand = new DevExpress.XtraEditors.TextEdit();
            this.txtAllocate = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.cboLocation = new G8Control.G8Combobox();
            this.cboProduct = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtyOnHand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAllocate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProduct.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQtyOnHand
            // 
            this.txtQtyOnHand.EditValue = 0;
            this.txtQtyOnHand.Location = new System.Drawing.Point(125, 162);
            this.txtQtyOnHand.Name = "txtQtyOnHand";
            this.txtQtyOnHand.Properties.DisplayFormat.FormatString = "n0";
            this.txtQtyOnHand.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtQtyOnHand.Properties.Mask.EditMask = "n0";
            this.txtQtyOnHand.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQtyOnHand.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtQtyOnHand.Size = new System.Drawing.Size(183, 21);
            this.txtQtyOnHand.TabIndex = 2;
            // 
            // txtAllocate
            // 
            this.txtAllocate.EditValue = 0;
            this.txtAllocate.Location = new System.Drawing.Point(125, 203);
            this.txtAllocate.Name = "txtAllocate";
            this.txtAllocate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAllocate.Properties.Mask.EditMask = "n0";
            this.txtAllocate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAllocate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtAllocate.Size = new System.Drawing.Size(183, 21);
            this.txtAllocate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity On Hand:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantity Allocated:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Product Location Information";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(110, 242);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(201, 242);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboLocation
            // 
            this.cboLocation.DataSource = null;
            this.cboLocation.DisplayMember = "";
            this.cboLocation.Location = new System.Drawing.Point(125, 119);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.SelectedValue = null;
            this.cboLocation.Size = new System.Drawing.Size(183, 21);
            this.cboLocation.TabIndex = 1;
            this.cboLocation.ValueMember = "";
            // 
            // cboProduct
            // 
            this.cboProduct.Location = new System.Drawing.Point(125, 73);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboProduct.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboProduct.Size = new System.Drawing.Size(183, 21);
            this.cboProduct.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(314, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "&Search";
            this.btnSearch.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmAddEditProductLocation
            // 
            this.ClientSize = new System.Drawing.Size(386, 277);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboProduct);
            this.Controls.Add(this.cboLocation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAllocate);
            this.Controls.Add(this.txtQtyOnHand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditProductLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add or Edit Product Location Form";
            this.Load += new System.EventHandler(this.frmAddEditProductLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtQtyOnHand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAllocate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProduct.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Variable

        #endregion

        #region Method
        private void LoadText()
        {
            if (ProRow["ID"].ToString() != "")
            {
                txtAllocate.EditValue = ProRow["Qty_Allocated"];
                txtQtyOnHand.EditValue = ProRow["Qty_on_hand"];
            }
        }
        private void LoadCboLocation()
        {
            DA_DataTable dtLocation = Globals.dtLocation_Master;
            cboLocation.ValueMember = "Bin_location_id";
            cboLocation.DisplayMember = "Bin_location_id";
            cboLocation.DataSource = dtLocation;

            if (Globals.dtLocation_Master.Rows.Count > 0)
            {
                if (ProRow["LocationID"].ToString() != "")
                {
                    cboLocation.SelectedValue = ProRow["LocationID"].ToString();
                    cboLocation.Enabled = false;
                }
                else
                {
                    cboLocation.Enabled = true;
                }
            }
        }
        private void LoadCboProduct()
        {
            DataRow[] arrProductLocation=Globals.dtProductLocation.Select("LocationID='"+ProRow["LocationID"].ToString()+"'");
            DataRow[] arrProductMaster = Globals.dtProductMaster.Select("True");

            for (int i = 0; i < arrProductMaster.Length; i++)
            {
                cboProduct.Properties.Items.Add(new TabItem(
                    arrProductMaster[i]["ProductID"].ToString(),
                    arrProductMaster[i]["ProductName"].ToString()));
                
            }
            if (ProRow["ProductID"].ToString() != "")
            {
                for (int i = 0; i < cboProduct.Properties.Items.Count; i++)
                {
                    if (ProRow["ProductID"].ToString() == ((TabItem)cboProduct.Properties.Items[i]).ItemID)
                    {
                        cboProduct.SelectedIndex = i;
                        cboProduct.Enabled = false;
                        return;
                    }
                }
            }
            else
            {
                for (int i = 0; i < cboProduct.Properties.Items.Count; i++)
                {
                    for (int j = 0; j < arrProductLocation.Length; j++)
                    {
                        if (arrProductLocation[j]["ProductID"].ToString()
                            == ((TabItem)cboProduct.Properties.Items[i]).ItemID)
                        {
                            cboProduct.Properties.Items.RemoveAt(i);
                            break;
                        }
                    }
                }
                if (cboProduct.Properties.Items.Count > 0)
                {
                    cboProduct.SelectedIndex = 0;
                }
            }
           
     
        }
        #endregion

        #region Property
        private DataRow row;
        public DataRow ProRow
        {
            get
            {
                return this.row;
            }
            set
            {
                row = value;
                LoadText();
            }
        }
        private bool CheckValidated()
        {
            if (txtAllocate.EditValue.ToString() =="" || txtAllocate.EditValue.ToString() == "" || int.Parse(txtAllocate.EditValue.ToString()) < 0 || int.Parse(txtAllocate.EditValue.ToString()) > Int16.MaxValue)
            {

                MessageBox.Show("Quantity Allocated field cannot less than zero or greater than " + Int16.MaxValue, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAllocate.Focus();
                return false;
            }
            if (txtQtyOnHand.EditValue ==null || txtQtyOnHand.EditValue.ToString() == "" || int.Parse(txtQtyOnHand.EditValue.ToString()) < 0 || int.Parse(txtQtyOnHand.EditValue.ToString()) > Int16.MaxValue)
            {

                MessageBox.Show("Quantity On Hand field cannot less than zero or greater than " + Int16.MaxValue, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtyOnHand.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region Event
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!CheckValidated())
                return;
            ProRow["Qty_Allocated"] = txtAllocate.EditValue;
            ProRow["Qty_on_hand"] = txtQtyOnHand.EditValue;
            ProRow["ProductID"] = ((TabItem)cboProduct.SelectedItem).ItemID;
            ProRow["LocationID"] = cboLocation.SelectedValue;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboProduct_Load(object sender, EventArgs e)
        {

        }

        private void cboLocation_Load(object sender, EventArgs e)
        {

        }
        private void frmAddEditProductLocation_Load(object sender, EventArgs e)
        {
            LoadCboLocation();
            LoadCboProduct();
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Inventory.Forms.Location.frmProductLocationSelector oSelector = new Inventory.Forms.Location.frmProductLocationSelector();
            oSelector.ShowDialog();
            cboProduct.EditValue = oSelector.ProductName;
        }

       

      
    }
}

