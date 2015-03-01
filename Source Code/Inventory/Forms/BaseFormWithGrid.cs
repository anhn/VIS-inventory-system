using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;
using Inventory.DataModels.Warehouse;
using Inventory.DataModels;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using Inventory.Utils;
using DevExpress.XtraGrid.Columns;
using Inventory.Properties;
using System.IO;

namespace Inventory.Forms
{
    /// <summary>
    /// This class does not actually contains any GridView
    /// The reason is that .Net does not support inherittance
    /// for Controls with Collection
    /// It only contains the datatable used for binding data with the GridView
    /// The gridView would be added in design of the final form.
    /// It also contains a definition for a GridView that will be assigned at runtime
    /// After the grid is bounded with the datatable: gridView = grid.Views[0]
    /// </summary>
    public class BaseFormWithGrid : DevExpress.XtraEditors.XtraForm
    {
        
        protected SimpleButton btnAdd;
        protected SimpleButton btnDelete;
        protected SimpleButton btnSave;
        protected SimpleButton btnClose;
        protected DateEdit dtmDateCreated;

        protected DataTable dtDetails = new DataTable();

        protected GridView gridView = null;
        protected Label label1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.Container components = null;
        
        public BaseFormWithGrid()
        {
            //
            // Required for Windows Form Designer support
            //
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
        protected void InitializeComponent()
        {
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.dtmDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDateCreated.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(275, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "&Add Item";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(372, 68);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "&Delete Item";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(195, 271);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(305, 271);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtmDateCreated
            // 
            this.dtmDateCreated.EditValue = new System.DateTime(2007, 5, 11, 0, 0, 0, 0);
            this.dtmDateCreated.Location = new System.Drawing.Point(376, 17);
            this.dtmDateCreated.Name = "dtmDateCreated";
            this.dtmDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtmDateCreated.Size = new System.Drawing.Size(175, 20);
            this.dtmDateCreated.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Date Created";
            // 
            // BaseFormWithGrid
            // 
            this.AcceptButton = this.btnSave;
            this.ClientSize = new System.Drawing.Size(572, 301);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtmDateCreated);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BaseFormWithGrid";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dtmDateCreated.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //Set Default value for the row
            DataRow dr = dtDetails.NewRow();
            for (int i = 0; i < dr.ItemArray.Length; i++)
            {
                if (dtDetails.Columns[i].DataType == typeof(String))
                {
                    dr[i] = String.Empty;
                }
                else if (dtDetails.Columns[i].DataType == typeof(Decimal))
                {
                    dr[i] = 0;
                }
                else
                {
                    dr[i] = DBNull.Value;
                }
            }
            dtDetails.Rows.Add(dr);
        }

        protected DataRow GetSelectedRow()
        {
            if (gridView == null) return null;
            int[] selectedRows = gridView.GetSelectedRows();
            if (selectedRows == null || selectedRows.Length == 0) return null;
            int i = selectedRows[0];
            DataRow row = dtDetails.Rows[i];
            return row;
        }


        protected int GetSelectedRowIndex()
        {
            if (gridView != null)
            {
                gridView.TopRowIndex = 0;
                return gridView.FocusedRowHandle;
            }
            else
            {
                return -1;
            }
        }


        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete the selected Row
            int i = GetSelectedRowIndex();
            if (i < 0) return;
            dtDetails.Rows.RemoveAt(i);
        }

        protected virtual bool Validate()
        {
            return false;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validate()) return;
            ReadToDataModel();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        protected virtual void ReadToDataModel()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            // confirm to save data
            DialogResult dlgResult = MessageBox.Show(Constants.Message.Save_Prompt, Constants.Message.MessageTitle, MessageBoxButtons.YesNo);
            if (dlgResult == DialogResult.Yes)
            {
                btnSave_Click(btnSave, EventArgs.Empty);
            }
            else
            {
                this.Close();
            }
        }
     
    }
}

