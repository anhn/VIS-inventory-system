using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Inventory.DataModels.StockTake;
using Inventory.DataModels;
using Inventory.Properties;

namespace Inventory.Forms.StockTake
{
    public partial class PhysicalTake : Inventory.Forms.Warehouse.BaseWarehouse
    {
        public PhysicalTake()
        {
            InitializeComponent();
        }

        //Stock Transfer Model
        private PhysicalTakeModel model = new PhysicalTakeModel();

        /// <summary>
        /// Get/set data model StockTransfer 
        /// </summary>
        public PhysicalTakeModel DataModel
        {
            get { return model; }
            set { model = value; }
        }

        /// <summary>
        /// Binding data to dialog
        /// </summary>
        /// <param name="objModel">ProductCategoryModel</param>
        public void BindData(PhysicalTakeModel objModel)
        {
            //In case of adding new packing list, initialize the grid with nodata
            if (objModel == null)
            {
                model = new PhysicalTakeModel();
                model.Details = Mediator.GetInstance().GetEmptyPhysicalTakeDetails();
            }
            else
            {
                model = objModel;
            }

            this.txtName.Text = model.Name;
            this.txtNotes.Text = model.Note;
            dtmDateCreated.DateTime = model.DateCreated;
            this.dtDetails = model.Details;
            this.chkViewStatus.Checked = model.ViewStatus;

            grdDetails.DataSource = dtDetails;

            //Get grid view
            gridView = (GridView)this.grdDetails.Views[0];

            foreach (GridColumn cl in gridView.Columns)
            {
                //cl.Visible = false;
                cl.MinWidth = 10;
                cl.AppearanceHeader.Font = Settings.Default.cfgDefaultFont;
                cl.AppearanceCell.Font = Settings.Default.cfgDefaultFont;
            }

            this.InitializeDropDowGrid();

            //Setting up columns
            gridView.Columns["ID"].Visible = false;
            gridView.Columns["PhysicalTakeID"].Visible = false;
            gridView.Columns["Warehouse"].ColumnEdit = repoWarehouseLookUp;
            gridView.Columns["Location"].ColumnEdit = repoLocationLookUp;
            gridView.Columns["Product"].ColumnEdit = repoProductLookUp;

            gridView.Columns["Warehouse"].Width = 100;
            gridView.Columns["Location"].Width = 90;
            gridView.Columns["Product"].Width = 100;
            gridView.Columns["Current Qty"].Width = 100;
            gridView.Columns["Count Qty"].Width = 100;

            gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridView_CellValueChanged);
            dtDetails.AcceptChanges();

        }

        /// <summary>
        /// Implement Validate data
        /// </summary>
        /// <returns></returns>
        protected override bool Validate()
        {
            Validator objValidator = new Validator();

            if (!objValidator.IsNonEmpty("Physical Name", txtName.Text))
            {
                txtName.Focus();
                return false;
            }
            if (Toolkit.DbToolKit.IsDataOfSqlExists("SELECT ID,Name FROM PhysicalTakeMaster WHERE Name = '" + txtName.Text + "' AND ID <> '" + this.DataModel.ID + "'"))
            {
                MessageBox.Show("This name is already available, please select another one");
                txtName.Focus();
                return false;
            }
            if (!objValidator.IsDateTime("Created Date", this.dtmDateCreated.Text))
            {
                dtmDateCreated.Focus();
                return false;
            }
            if (dtDetails.Rows.Count <= 0)
            {
                MessageBox.Show("Please add the product item in the grid");
                btnAdd.Focus();
                return false;
            }
            foreach (DataRow dr in dtDetails.Rows)
            {
                int i = dtDetails.Rows.IndexOf(dr) + 1;
                String strTemp = dr["Location"].ToString();
                if (!objValidator.IsNonEmpty("Line " + i + " :location", strTemp))
                {
                    return false;
                }
                strTemp = dr["Product"].ToString();
                if (!objValidator.IsNonEmpty("Line " + i + " :product", strTemp))
                {
                    return false;
                }
                strTemp = dr["Current Qty"].ToString();
                if (!objValidator.IsDecimal("Line " + i + " :current quantity", strTemp))
                {
                    return false;
                }
                strTemp = dr["Count Qty"].ToString();
                if (!objValidator.IsDecimal("Line " + i + " :count quantity", strTemp))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Implement ReadToDataModel
        /// </summary>
        protected override void ReadToDataModel()
        {
            model.Name = txtName.Text;
            model.DateCreated = dtmDateCreated.DateTime;
            model.Note = txtNotes.Text;
            model.ViewStatus = chkViewStatus.Checked;
            
        }

        override protected bool CheckQuantityOnHand()
        {
            //DataRow dr = GetSelectedRow();
            //String strQuantity = dr["Quantity"].ToString();
            //String strWarehouse = dr["Warehouse"].ToString();
            //String strProduct = dr["Product"].ToString();
            //String strLocation = dr["Location"].ToString();
            ////If any of the field is null, no need tovalidate
            //if (String.IsNullOrEmpty(strQuantity) || String.IsNullOrEmpty(strWarehouse)
            //    || String.IsNullOrEmpty(strLocation) || String.IsNullOrEmpty(strProduct)) return true;
            //try
            //{
            //    Decimal dQty = Convert.ToDecimal(strQuantity);
            //    Decimal dAvailQty = Mediator.GetInstance().GetOnHandQty(strWarehouse, strLocation, strProduct);
            //    if (dQty < 0 && System.Math.Abs(dQty) > dAvailQty)
            //    {
            //        MessageBox.Show("Reduction quantity is greater than available quantity", "Warning");
            //        dr["Quantity"] = -dAvailQty;
            //        return false;
            //    }
            //    return true;
            //}
            //catch
            //{
            return true;
            //}
        }

        private void PhysicalTake_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }
    }
}

