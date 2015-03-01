using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Inventory.DataModels;

namespace Inventory.Forms.Data
{
    /// <summary>
    /// Summary description for FilterDialog.
    /// </summary>
    public class FilterDialog : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton btnAdd;
        private DataGridView dgvFilter;
        private DataGridViewComboBoxColumn colName;
        private DataGridViewComboBoxColumn colCondition;
        private DataGridViewTextBoxColumn colValue;
        private DataGridViewComboBoxColumn colLogic;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private SimpleButton btnDelete;
        private SimpleButton btnOK;
        private SimpleButton btnPreview;
        private Label lblFilter;
        private SimpleButton btnClose;

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
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.dgvFilter = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colCondition = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLogic = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.dgvPreview = new System.Windows.Forms.DataGridView();
            this.btnHide = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(284, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvFilter
            // 
            this.dgvFilter.AllowUserToAddRows = false;
            this.dgvFilter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colCondition,
            this.colValue,
            this.colLogic});
            this.dgvFilter.Location = new System.Drawing.Point(12, 52);
            this.dgvFilter.Name = "dgvFilter";
            this.dgvFilter.RowHeadersWidth = 20;
            this.dgvFilter.Size = new System.Drawing.Size(438, 160);
            this.dgvFilter.TabIndex = 2;
            // 
            // colName
            // 
            this.colName.HeaderText = "Column Name";
            this.colName.Name = "colName";
            // 
            // colCondition
            // 
            this.colCondition.HeaderText = "Condition";
            this.colCondition.Items.AddRange(new object[] {
            "=",
            "<",
            ">",
            "<>",
            "like"});
            this.colCondition.Name = "colCondition";
            // 
            // colValue
            // 
            this.colValue.HeaderText = "Value";
            this.colValue.Name = "colValue";
            // 
            // colLogic
            // 
            this.colLogic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colLogic.HeaderText = "Logic";
            this.colLogic.Items.AddRange(new object[] {
            "And",
            "Or"});
            this.colLogic.Name = "colLogic";
            this.colLogic.Width = 50;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(375, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(284, 225);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(12, 225);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(13, 28);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(83, 13);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "Filter Condition:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(375, 225);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Cancel";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvPreview
            // 
            this.dgvPreview.AllowUserToAddRows = false;
            this.dgvPreview.AllowUserToDeleteRows = false;
            this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreview.Location = new System.Drawing.Point(12, 264);
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.ReadOnly = true;
            this.dgvPreview.Size = new System.Drawing.Size(438, 150);
            this.dgvPreview.TabIndex = 6;
            this.dgvPreview.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPreview_DataError);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(93, 225);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(49, 23);
            this.btnHide.TabIndex = 4;
            this.btnHide.Text = "Hide";
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // FilterDialog
            // 
            this.AcceptButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(464, 425);
            this.Controls.Add(this.dgvPreview);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.dgvFilter);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FilterDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterDialog";
            this.Load += new System.EventHandler(this.FilterDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Attributes

        private string strTableName = string.Empty;
        private DataGridView dgvPreview;
        private SimpleButton btnHide;
        DataTable dtDbTable = new DataTable();

        #endregion

        #region Properties

        public string TableName
        {
            get { return strTableName; }
        }

        #endregion

        #region Constructor

        public FilterDialog(string tableName)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.strTableName = tableName;

        }

        #endregion

        #region Event Handler

        private void FilterDialog_Load(object sender, EventArgs e)
        {
            this.CreateFilterGrid(this.strTableName);
            this.btnHide_Click(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvFilter.Rows.Add();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFilter.CurrentRow == null || dgvFilter.CurrentRow.Index < 0)
            {
                return;
            }

            dgvFilter.Rows.RemoveAt(dgvFilter.CurrentRow.Index);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (!this.ValidateData())
            {
                return;
            }

            try
            {
                this.Height = 457;
                btnHide.Enabled = true;

                string strExportSql = "SELECT * FROM {0} {1}";
                string strCondition = this.GetFilterCondition();
                if (!string.IsNullOrEmpty(strCondition))
                {
                    strCondition = "WHERE " + strCondition;
                }

                strExportSql = string.Format(strExportSql, strTableName, strCondition);
                DataTable dtExport = Mediator.GetInstance().GetTableForFilter(strExportSql);
                dgvPreview.DataSource = dtExport;
            }
            catch (Exception ex)
            {
                string strMessage = ex.Message;
                while (ex.InnerException != null)
                {
                    strMessage += Environment.NewLine + ex.InnerException.Message;
                    ex = ex.InnerException;
                }

                MessageBox.Show(strMessage, Constants.Message.MessageTitle);
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Height = 287;
            btnHide.Enabled = false;
        }

        private void dgvPreview_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // do not remove this
            // it is used to avoid the exception when the data error is occurred.
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.ValidateData())
            {
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion

        #region Private Methods
        
        private void CreateFilterGrid(string tableName)
        {
            dtDbTable = Mediator.GetInstance().GetEmptyTableForFilter(tableName);

            DataTable dtFilter = new DataTable();
            colName.Items.Clear();
            foreach(DataColumn dc in dtDbTable.Columns)
            {
                colName.Items.Add(dc.ColumnName);
            }
        }

        public string GetFilterCondition()
        {
            if (dgvFilter.Rows.Count == 0)
            {
                return ""; // no filter
            }

            string strFilter = "";
            foreach (DataGridViewRow row in dgvFilter.Rows)
            {
                string strColumn = Convert.ToString(row.Cells[colName.Name].Value);
                string strValue = Convert.ToString(row.Cells[colValue.Name].Value);
                string strCond = Convert.ToString(row.Cells[colCondition.Name].Value);
                string strLogic = Convert.ToString(row.Cells[colLogic.Name].Value);
                                
                if (dtDbTable.Columns[strColumn].DataType == typeof(string))
                {
                    strValue = "'" + strValue + "'";
                }

                if (!string.IsNullOrEmpty(strColumn) && strColumn.Contains(" "))
                {
                    strColumn = "[" + strColumn + "]";
                }
                if (row.Index != dgvFilter.Rows.Count - 1)
                {
                    strFilter += strColumn + " " + strCond + " " + strValue + " " + strLogic + " ";
                }
                else
                {
                    strFilter += strColumn + " " + strCond + " " + strValue;
                }
            }

            return strFilter;
        }

        private bool ValidateData()
        {
            Validator val = new Validator();

            foreach (DataGridViewRow row in dgvFilter.Rows)
            {
                int i = row.Index + 1;
                String strTemp = Convert.ToString(row.Cells[colName.Name].Value);
                if (!val.IsNonEmpty("Line " + i + ": Column Name", strTemp))
                {
                    return false;
                }

                strTemp = Convert.ToString(row.Cells[colCondition.Name].Value);
                if (!val.IsNonEmpty("Line " + i + ": Condition", strTemp))
                {
                    return false;
                }

                if (i != dgvFilter.Rows.Count) // do not check Logic of last row
                {
                    strTemp = Convert.ToString(row.Cells[colLogic.Name].Value);
                    if (!val.IsNonEmpty("Line " + i + ": Logic", strTemp))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            // confirm to save data
            DialogResult dlgResult = MessageBox.Show(Constants.Message.Save_Prompt, Constants.Message.MessageTitle, MessageBoxButtons.YesNo);
            if (dlgResult == DialogResult.Yes)
            {
                btnOK_Click(btnOK, EventArgs.Empty);
            }
            else
            {
                this.Close();
            }
        }
    }
}

