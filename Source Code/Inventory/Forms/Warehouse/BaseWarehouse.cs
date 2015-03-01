using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System.Data;
using Inventory.DataModels;
using System.IO;

namespace Inventory.Forms.Warehouse
{
    /// <summary>
    /// Summary description for BaseWarehouse.
    /// </summary>
    public class BaseWarehouse : BaseFormWithGrid
    {
        protected RepositoryItemLookUpEdit repoWarehouseLookUp = new RepositoryItemLookUpEdit();
        protected RepositoryItemLookUpEdit repoLocationLookUp = new RepositoryItemLookUpEdit();
        protected RepositoryItemLookUpEdit repoProductLookUp = new RepositoryItemLookUpEdit();
        protected RepositoryItemLookUpEdit repoPackageLookUp = new RepositoryItemLookUpEdit();

        protected RepositoryItemLookUpEdit repoToWarehouseLookUp = new RepositoryItemLookUpEdit();
        protected RepositoryItemLookUpEdit repoToLocationLookUp = new RepositoryItemLookUpEdit();

        protected DataTable dtProducts = null;
        protected DataTable dtLocations = null;
        protected SimpleButton btnFind;
        protected DataTable dtToLocations = null;
        

        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.Container components = null;

        public BaseWarehouse()
        {
            //
            // Required for Windows Form Designer support
            //            
            InitializeComponent();
        }

        protected void InitializeDropDowGrid()
        {
            repoWarehouseLookUp.EditValueChanged += new EventHandler(repoWarehouseLookUp_EditValueChanged);
            repoWarehouseLookUp.DisplayMember = "Description";
            repoWarehouseLookUp.ValueMember = "Warehouse_id";
            repoWarehouseLookUp.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Warehouse", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            repoWarehouseLookUp.DataSource = Mediator.GetInstance().GetAllWarehouse();


            repoToWarehouseLookUp.EditValueChanged += new EventHandler(repoToWarehouseLookUp_EditValueChanged);
            repoToWarehouseLookUp.DisplayMember = "Description";
            repoToWarehouseLookUp.ValueMember = "Warehouse_id";
            repoToWarehouseLookUp.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Warehouse", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            repoToWarehouseLookUp.DataSource = Mediator.GetInstance().GetAllWarehouse();


            repoLocationLookUp.QueryPopUp += new CancelEventHandler(repoLocationLookUp_QueryPopUp);
            repoLocationLookUp.DisplayMember = "bin_location_id";
            repoLocationLookUp.ValueMember = "bin_location_id";
            repoLocationLookUp.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("bin_location_id", "Location", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            dtLocations = Mediator.GetInstance().GetAllLocations();
            repoLocationLookUp.DataSource = dtLocations;


            repoToLocationLookUp.QueryPopUp += new CancelEventHandler(repoToLocationLookUp_QueryPopUp);
            repoToLocationLookUp.DisplayMember = "bin_location_id";
            repoToLocationLookUp.ValueMember = "bin_location_id";
            repoToLocationLookUp.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("bin_location_id", "Location", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            dtToLocations = Mediator.GetInstance().GetAllLocations();
            repoToLocationLookUp.DataSource = dtToLocations;

            
            repoProductLookUp.EditValueChanged += new EventHandler(repoProductLookUp_EditValueChanged);
            repoProductLookUp.DisplayMember = "ProductName";
            repoProductLookUp.ValueMember = "ProductId";
            repoProductLookUp.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Product", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            dtProducts = Mediator.GetInstance().GetAllProductNames();
            repoProductLookUp.DataSource = dtProducts;
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
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(301, 68);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(390, 68);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(192, 301);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(295, 301);
            // 
            // dtmDateCreated
            // 
            this.dtmDateCreated.Location = new System.Drawing.Point(395, 16);
            this.dtmDateCreated.Size = new System.Drawing.Size(175, 21);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(298, 23);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(479, 68);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(87, 23);
            this.btnFind.TabIndex = 16;
            this.btnFind.Text = "Find Products";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // BaseWarehouse
            // 
            this.ClientSize = new System.Drawing.Size(578, 336);
            this.Controls.Add(this.btnFind);
            this.Name = "BaseWarehouse";
            this.Text = "BaseWarehouse";
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.dtmDateCreated, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dtmDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region EventHandlers
        protected void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if ("colWarehouse".Equals(e.Column.Name) ||
                "colProduct".Equals(e.Column.Name) ||
                "colLocation".Equals(e.Column.Name) ||
                "colQuantity".Equals(e.Column.Name))
            {
                CheckQuantityOnHand();
            }
        }

        protected void repoWarehouseLookUp_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit le = (DevExpress.XtraEditors.LookUpEdit)sender;
            String strNewWarehouse = le.EditValue.ToString();
            UpdateLocation(strNewWarehouse);

        }

        protected void repoToWarehouseLookUp_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit le = (DevExpress.XtraEditors.LookUpEdit)sender;
            String strNewWarehouse = le.EditValue.ToString();
            UpdateToLocation(strNewWarehouse);
        }

        protected void repoProductLookUp_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit le = (DevExpress.XtraEditors.LookUpEdit)sender;
            String strNewProduct = le.EditValue.ToString();
            UpdateUOM(strNewProduct);
        }

        protected void repoLocationLookUp_QueryPopUp(object sender, CancelEventArgs e)
        {
            FilterSelectionByWarehouse();
        }

        protected void repoToLocationLookUp_QueryPopUp(object sender, CancelEventArgs e)
        {
            FilterSelectionByToWarehouse();
        }


        #endregion

        #region Private Functions
        virtual protected bool CheckQuantityOnHand()
        {
            DataRow dr = GetSelectedRow();
            String strQuantity = dr["Quantity"].ToString();
            String strWarehouse = dr["Warehouse"].ToString();
            String strProduct = dr["Product"].ToString();
            String strLocation = dr["Location"].ToString();
            //If any of the field is null, no need tovalidate
            if (String.IsNullOrEmpty(strQuantity) || String.IsNullOrEmpty(strWarehouse)
                || String.IsNullOrEmpty(strLocation) || String.IsNullOrEmpty(strProduct)) return true;
            try
            {
                Decimal dQty = Convert.ToDecimal(strQuantity);
                Decimal dAvailQty = Mediator.GetInstance().GetOnHandQty(strWarehouse, strLocation, strProduct);
                if (dQty > dAvailQty)
                {
                    MessageBox.Show("Quantity is greater than available quantity", "Warning");
                    dr["Quantity"] = dAvailQty;
                    return false;
                }
                return true;
            }
            catch
            {
                return true;
            }
        }

        private void FilterSelectionByWarehouse()
        {
            DataRow dr = GetSelectedRow();
            if (dr == null) return;
            String strWarehouse = dr["Warehouse"].ToString();
            String strLocation = dr["Location"].ToString();
            StringWriter wr = new StringWriter();
            if (!String.IsNullOrEmpty(strWarehouse))
            {
                wr.Write("Warehouse_id = '" + strWarehouse + "' ");
            }

            dtLocations.DefaultView.RowFilter = wr.ToString();
        }

        private void FilterSelectionByToWarehouse()
        {
            DataRow dr = GetSelectedRow();
            if (dr == null) return;
            String strToWarehouse = dr["To Warehouse"].ToString();

            StringWriter wr = new StringWriter();
            if (!String.IsNullOrEmpty(strToWarehouse))
            {
                wr.Write("Warehouse_id = '" + strToWarehouse + "' ");
            }

            dtToLocations.DefaultView.RowFilter = wr.ToString();
        }

        /// <summary>
        /// Check if the current location match with the new warehouse, if not
        /// then clear the current value of location
        /// </summary>
        /// <param name="strWarehouse"></param>
        private void UpdateLocation(String strWarehouse)
        {

            DataRow dr = GetSelectedRow();
            if (dr == null) return;

            String strLocation = dr["Location"].ToString();

            //Don't have to care if location already empty
            if (String.IsNullOrEmpty(strLocation)) return;

            StringWriter wr = new StringWriter();
            if (!String.IsNullOrEmpty(strWarehouse))
            {
                wr.Write("Warehouse_id = '" + strWarehouse + "' ");
            }

            wr.Write(" and Bin_location_id = '" + strLocation + "' ");

            //If the warehouse and location not match then clear location
            dtLocations.DefaultView.RowFilter = wr.ToString();
            if (dtLocations.DefaultView.Count == 0)
            {
                dr["Location"] = "";
            }

        }

        private void UpdateToLocation(string strNewWarehouse)
        {
            DataRow dr = GetSelectedRow();
            if (dr == null) return;

            String strLocation = dr["To Location"].ToString();

            //Don't have to care if location already empty
            if (String.IsNullOrEmpty(strLocation)) return;

            StringWriter wr = new StringWriter();
            if (!String.IsNullOrEmpty(strNewWarehouse))
            {
                wr.Write("Warehouse_id = '" + strNewWarehouse + "' ");
            }

            wr.Write(" and Bin_location_id = '" + strLocation + "' ");

            //If the warehouse and location not match then clear location
            dtToLocations.DefaultView.RowFilter = wr.ToString();
            if (dtToLocations.DefaultView.Count == 0)
            {
                dr["To Location"] = "";
            }
        }

        private void UpdateUOM(String strProduct)
        {
            DataRow dr = GetSelectedRow();
            if (dr == null) return;

            if (String.IsNullOrEmpty(strProduct)) return;

            foreach (DataRow dtr in dtProducts.Rows)
            {
                if (dtr["ProductId"].ToString().Equals(strProduct))
                {
                    dr["UoM"] = dtr["Note"].ToString();
                    return;
                }
            }
        }

        #endregion

        #region Find Product

        private void btnFind_Click(object sender, EventArgs e)
        {
            DataRow dr = GetSelectedRow();
            if (dr == null)
            {
                MessageBox.Show(Constants.Message.FindProducts_SelectRow, Constants.Message.MessageTitle);
                return;
            }

            FindProduct frmFind = new FindProduct();
            if (DialogResult.OK != frmFind.ShowDialog())
            {
                return;
            }

            if (dr.Table.Columns.Contains("Warehouse"))
            {
                dr["Warehouse"] = frmFind.WarehouseID;
            }

            if (dr.Table.Columns.Contains("Location"))
            {
                dr["Location"] = frmFind.LocationID;
            }

            if (dr.Table.Columns.Contains("Product"))
            {
                dr["Product"] = frmFind.ProductID;
            }
        }

        #endregion

    }
}

