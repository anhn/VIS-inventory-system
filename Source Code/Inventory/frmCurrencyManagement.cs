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
    /// Summary description for frmCurrencyManagementcs.
    /// </summary>
    public class frmCurrencyManagement : DevExpress.XtraEditors.XtraForm
    {
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup radMainCurrency;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkMainCurrency;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtExNumber;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl grdCurrency;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCurrency;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtCurrencyID;
        private PanelControl panelControl1;
        private SimpleButton btnOk;
        private SimpleButton btnCancel;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkIsCurrencyMain;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmCurrencyManagement()
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
            this.radMainCurrency = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.chkMainCurrency = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.txtExNumber = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdCurrency = new DevExpress.XtraGrid.GridControl();
            this.grvCurrency = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtCurrencyID = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.chkIsCurrencyMain = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.radMainCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMainCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrencyID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsCurrencyMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radMainCurrency
            // 
            this.radMainCurrency.Name = "radMainCurrency";
            // 
            // chkMainCurrency
            // 
            this.chkMainCurrency.AutoHeight = false;
            this.chkMainCurrency.Name = "chkMainCurrency";
            // 
            // txtExNumber
            // 
            this.txtExNumber.AutoHeight = false;
            this.txtExNumber.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.txtExNumber.Mask.BeepOnError = true;
            this.txtExNumber.Mask.EditMask = "n2";
            this.txtExNumber.Mask.IgnoreMaskBlank = false;
            this.txtExNumber.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtExNumber.Mask.ShowPlaceHolders = false;
            this.txtExNumber.Mask.UseMaskAsDisplayFormat = true;
            this.txtExNumber.Name = "txtExNumber";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdCurrency;
            this.gridView2.Name = "gridView2";
            // 
            // grdCurrency
            // 
            this.grdCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCurrency.EmbeddedNavigator.Name = "";
            this.grdCurrency.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.grdCurrency_EmbeddedNavigator_ButtonClick);
            this.grdCurrency.Location = new System.Drawing.Point(0, 30);
            this.grdCurrency.MainView = this.grvCurrency;
            this.grdCurrency.Name = "grdCurrency";
            this.grdCurrency.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkMainCurrency,
            this.radMainCurrency,
            this.txtExNumber,
            this.txtCurrencyID,
            this.repositoryItemRadioGroup1,
            this.chkIsCurrencyMain});
            this.grdCurrency.Size = new System.Drawing.Size(592, 336);
            this.grdCurrency.TabIndex = 3;
            this.grdCurrency.UseEmbeddedNavigator = true;
            this.grdCurrency.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCurrency,
            this.gridView2});
            // 
            // grvCurrency
            // 
            this.grvCurrency.GridControl = this.grdCurrency;
            this.grvCurrency.Name = "grvCurrency";
            this.grvCurrency.OptionsView.ShowGroupPanel = false;
            this.grvCurrency.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvCurrency_FocusedRowChanged);
            this.grvCurrency.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grvCurrency_ValidateRow);
            this.grvCurrency.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvCurrency_CellValueChanging);
            this.grvCurrency.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvCurrency_InitNewRow);
            // 
            // txtCurrencyID
            // 
            this.txtCurrencyID.AutoHeight = false;
            this.txtCurrencyID.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.txtCurrencyID.Mask.EditMask = "[A-Za-z0-9]{3}";
            this.txtCurrencyID.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCurrencyID.Mask.PlaceHolder = '\0';
            this.txtCurrencyID.Mask.UseMaskAsDisplayFormat = true;
            this.txtCurrencyID.Name = "txtCurrencyID";
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // chkIsCurrencyMain
            // 
            this.chkIsCurrencyMain.AutoHeight = false;
            this.chkIsCurrencyMain.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.chkIsCurrencyMain.Name = "chkIsCurrencyMain";
            this.chkIsCurrencyMain.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.chkIsCurrencyMain_EditValueChanging);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnOk);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(592, 30);
            this.panelControl1.TabIndex = 2;
            this.panelControl1.Text = "panelControl1";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(416, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "&Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(496, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Close";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCurrencyManagement
            // 
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.Controls.Add(this.grdCurrency);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmCurrencyManagement";
            this.Text = "Currency Management";
            this.Load += new System.EventHandler(this.frmCurrencyManagementcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radMainCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMainCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrencyID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsCurrencyMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private void grdCurrency_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {

        }
        #region Variable
        DA_DataTable dtCurrency;
        decimal strExTemp;
        #endregion
        #region Method
        private void LoadComponent()
        {
            dtCurrency = new DA_DataTable("Select * from Currency", false);
            dtCurrency.Columns.Add("UserName", typeof(string));
            grdCurrency.DataSource = dtCurrency;
            
            
            grvCurrency.Columns["UserID"].VisibleIndex = -1;
            grvCurrency.Columns["CurrencyID"].VisibleIndex = 0;
            grvCurrency.Columns["CurrencyName"].VisibleIndex = 1;
            grvCurrency.Columns["ExRate"].VisibleIndex = 2;
            grvCurrency.Columns["IsMainCurrency"].VisibleIndex = 3;
            if (Globals.isAdministrator)
            {
                grvCurrency.Columns["ViewStatus"].VisibleIndex = 4;
            }
            else
            {
                grvCurrency.Columns["ViewStatus"].VisibleIndex = -1;
            }
            grvCurrency.Columns["UserName"].VisibleIndex = 5;

            for (int i = 0; i < grvCurrency.RowCount; i++)
            {
                grvCurrency.SetRowCellValue(i, "UserName", GetUsername(
                    grvCurrency.GetRowCellValue(i, "UserID").ToString()));
            }
            grvCurrency.Columns["IsMainCurrency"].ColumnEdit = chkIsCurrencyMain;

            grvCurrency.Columns["UserID"].OptionsColumn.ReadOnly = true;
            grvCurrency.Columns["LastUpdateDate"].OptionsColumn.ReadOnly = true;
            
        }
        private string GetUsername(string userID)
        {
            DA_DataTable dtUser=new DA_DataTable("Select * from t_User where UserID='"+userID+"'",false);
            if (dtUser.Rows.Count > 0)
            {
                return dtUser.Rows[0]["UserName"].ToString();
            }
            return "";
        }
        private bool CheckDuplicate()
        {
            for (int i = 0; i < dtCurrency.Rows.Count; i++)
            {
                if (i != grvCurrency.FocusedRowHandle)
                {
                  if(dtCurrency.Rows[i]["CurrencyID"].ToString() == grvCurrency.GetFocusedRowCellValue("CurrencyID").ToString())
                    return true;
                }
            }
            return false;   

        }
        private bool CheckDuplicateName()
        {
            for (int i = 0; i < dtCurrency.Rows.Count; i++)
            {
                if (i != grvCurrency.FocusedRowHandle)
                {
                    if (dtCurrency.Rows[i]["CurrencyName"].ToString() == grvCurrency.GetFocusedRowCellValue("CurrencyName").ToString())
                        return true;
                }
            }
            return false;

        }
        private bool CheckValidated()
        {
            for (int i = 0; i < grvCurrency.RowCount; i++)
            {
                if (grvCurrency.GetRowCellValue(i, "CurrencyID").ToString().Trim() == "")
                {
                    grvCurrency.FocusedRowHandle = i;
                    grvCurrency.FocusedColumn = grvCurrency.Columns["CurrencyID"];
                    MessageBox.Show("CurrencyID cannot Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (grvCurrency.GetRowCellValue(i, "CurrencyID").ToString().Length > 3)
                {
                    grvCurrency.FocusedRowHandle = i;
                    grvCurrency.FocusedColumn = grvCurrency.Columns["CurrencyID"];
                    MessageBox.Show("Length of Currency cannot greater than 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (grvCurrency.GetRowCellValue(i, "CurrencyName").ToString().Trim() == "")
                {
                    grvCurrency.FocusedRowHandle = i;
                    grvCurrency.FocusedColumn = grvCurrency.Columns["CurrencyName"];
                    MessageBox.Show("Currency Name cannot Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (grvCurrency.GetRowCellValue(i, "CurrencyName").ToString().Length>50)
                {
                    grvCurrency.FocusedRowHandle = i;
                    grvCurrency.FocusedColumn = grvCurrency.Columns["CurrencyName"];
                    MessageBox.Show("Length of Currency cannot greater than 50", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                
            }
            return true;
        }
        #endregion
        #region Event
        private void frmCurrencyManagementcs_Load(object sender, EventArgs e)
        {
            LoadComponent();
        }
        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!CheckValidated())
                return;
            for (int i = 0; i < dtCurrency.Rows.Count; i++)
            {
                if (dtCurrency.Rows[i].RowState != DataRowState.Unchanged)
                {
                    dtCurrency.Rows[i]["LastUpdateDate"] = DateTime.Today;
                    dtCurrency.Rows[i]["UserID"] = Globals.UserID;
                }
            }
            dtCurrency.Update();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void chkIsCurrencyMain_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if ((Boolean)e.OldValue == true)
            {
                e.NewValue = e.OldValue;
                return;
            }
            if ((Boolean)e.OldValue != true)
            {
                e.NewValue = true;
               
                for (int i = 0; i < grvCurrency.RowCount; i++)
                {
                    if (i != grvCurrency.FocusedRowHandle && grvCurrency.GetRowCellValue(i,"IsMainCurrency").ToString()=="True")
                    {
                        grvCurrency.SetRowCellValue(i, "IsMainCurrency", false);
                        grvCurrency.SetRowCellValue(i, "ExRate", strExTemp);
                    }
                    else
                    {
                        
                    }
                        
                }
                if (grvCurrency.GetFocusedRowCellValue("ExRate").ToString() != "")
                {
                    strExTemp = decimal.Parse(grvCurrency.GetFocusedRowCellValue("ExRate").ToString());
                    grvCurrency.SetRowCellValue(grvCurrency.FocusedRowHandle, "ExRate", 1);
                }
            }
        }

        private void grvCurrency_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {   
            grvCurrency.SetRowCellValue(e.RowHandle, "IsMainCurrency", false);
            grvCurrency.SetRowCellValue(e.RowHandle, "UserID", Globals.UserID);
            grvCurrency.SetRowCellValue(e.RowHandle, "ExRate", 1);
            grvCurrency.SetRowCellValue(e.RowHandle, "LastUpdatedDate", DateTime.Today);
            grvCurrency.SetRowCellValue(e.RowHandle, "ViewStatus", true);
            grvCurrency.SetRowCellValue(e.RowHandle, "UserName", Globals.UserName);
            grvCurrency.CloseEditor();
            grvCurrency.UpdateCurrentRow();
            
        }

        private void grvCurrency_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (grvCurrency.GetRowCellValue(e.RowHandle, "CurrencyID").ToString().Length > 3)
            {
                e.ErrorText = "Length of Currency cannot greater Than 3 ";
                e.Valid = false;
            }
           /* if (grvCurrency.GetRowCellDisplayText(e.RowHandle, "CurrencyID").ToString().Trim() =="")
            {
                e.ErrorText = "Currency ID cannot be empty";
                e.Valid = false;
            } */
            if (CheckDuplicate())
            {
                e.ErrorText = "CurrencyID cannot duplicate ";
                e.Valid = false;
                return;
            }
            if (CheckDuplicateName())
            {
                e.ErrorText = "Currency Name cannot duplicate ";
                e.Valid = false;
                return;
            }
            //if (grvCurrency.GetFocusedRowCellValue("CurrencyID").ToString() == "")
            //{
            //    e.ErrorText = "CurrencyID Cannot Empty ";
            //    e.Valid = false;
            //    return;
            //}
            

            
        }

        private void grvCurrency_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
        }

        private void grvCurrency_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }

    }
}

