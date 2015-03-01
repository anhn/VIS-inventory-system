using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;

using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Data.SqlClient;
using G8_POS.Properties;
using DevExpress.XtraEditors.Repository;

namespace G8_POS
{
    /// <summary>
    /// Summary description for XtraForm1.
    /// </summary>
    public class frmCurrency : DevExpress.XtraEditors.XtraForm
    {
        private PanelControl panelControl1;
        private SimpleButton btnCancel;
        private DevExpress.XtraGrid.GridControl grdCurrency;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkMainCurrency;
        private RepositoryItemRadioGroup radMainCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private RepositoryItemTextEdit txtExNumber;
		private SimpleButton btnOk;
		private RepositoryItemTextEdit txtCurrencyID;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmCurrency()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        private bool bAdmin;
        public bool Administrator
        {
            set { bAdmin = value; }
            get { return bAdmin; }
        }
		private string userName;
		public string UserName
		{
			set { userName = value; }
			get { return userName; }
		}
		private string userID;
		public string UserID
		{
			set { userID = value; }
			get { return userID; }
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.grdCurrency = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.chkMainCurrency = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.radMainCurrency = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.txtExNumber = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtCurrencyID = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMainCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMainCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrencyID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnOk);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(573, 30);
            this.panelControl1.TabIndex = 0;
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
            // grdCurrency
            // 
            this.grdCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCurrency.EmbeddedNavigator.Name = "";
            this.grdCurrency.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.grdCurrency_EmbeddedNavigator_ButtonClick);
            this.grdCurrency.Location = new System.Drawing.Point(0, 30);
            this.grdCurrency.MainView = this.gridView1;
            this.grdCurrency.Name = "grdCurrency";
            this.grdCurrency.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkMainCurrency,
            this.radMainCurrency,
            this.txtExNumber,
            this.txtCurrencyID});
            this.grdCurrency.Size = new System.Drawing.Size(573, 455);
            this.grdCurrency.TabIndex = 1;
            this.grdCurrency.UseEmbeddedNavigator = true;
            this.grdCurrency.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            this.grdCurrency.Click += new System.EventHandler(this.grdCurrency_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdCurrency;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // chkMainCurrency
            // 
            this.chkMainCurrency.AutoHeight = false;
            this.chkMainCurrency.Name = "chkMainCurrency";
            this.chkMainCurrency.CheckedChanged += new System.EventHandler(this.chkMainCurrency_CheckedChanged);
            this.chkMainCurrency.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.chkMainCurrency_EditValueChanging);
            // 
            // radMainCurrency
            // 
            this.radMainCurrency.Name = "radMainCurrency";
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
            this.txtExNumber.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtExNumber_EditValueChanging);
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
            // gridView2
            // 
            this.gridView2.GridControl = this.grdCurrency;
            this.gridView2.Name = "gridView2";
            // 
            // frmCurrency
            // 
            this.ClientSize = new System.Drawing.Size(573, 485);
            this.Controls.Add(this.grdCurrency);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCurrency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Currency";
            this.Load += new System.EventHandler(this.frmCurrency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMainCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMainCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrencyID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private CurrencyTable tblCurrency;
        private GridView gvCurrency;
		private string FConnection;
		private string exRateTemp;
		public string Connection
		{
			get { return FConnection; }
			set { FConnection = value; }
			
		}
        private void frmCurrency_Load(object sender, EventArgs e)
        {

            //MessageBox.Show(ConfigurationSettings.AppSettings["dbConnection"]);
            
            //tblCurrency = new CurrencyTable(new SqlConnection(Settings.Default.dbConnection));
			tblCurrency = new CurrencyTable(new SqlConnection(this.FConnection));
			//tblCurrency.ReSelect("SELECT dbo.Currency.*, dbo.t_User.UserName FROM dbo.Currency  LEFT OUTER JOIN dbo.t_User ON dbo.Currency.UserID = dbo.t_User.UserID");
            //Liem
            tblCurrency.ReSelect("SELECT CurrencyID as OldID,CurrencyID,CurrencyName,ExRate,IsMainCurrency,Currency.ViewStatus,Currency.UserID,LastUpdateDate, dbo.t_User.UserName FROM dbo.Currency  LEFT OUTER JOIN dbo.t_User ON dbo.Currency.UserID = dbo.t_User.UserID");
            grdCurrency.DataSource = tblCurrency;
            gvCurrency = (GridView)grdCurrency.Views[0];
			gvCurrency.Columns["IsMainCurrency"].ColumnEdit = chkMainCurrency;
			gvCurrency.Columns["CurrencyID"].ColumnEdit = txtCurrencyID;
            gvCurrency.Columns["ExRate"].ColumnEdit = txtExNumber;
			gvCurrency.Columns["UserID"].Visible = false;
            gvCurrency.Columns["OldID"].Visible = false;
			gvCurrency.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(gvCurrency_ValidateRow);
			tblCurrency.RowChanged += new DataRowChangeEventHandler(tblCurrency_RowChanged);
            // hide column
            gvCurrency.Columns["ViewStatus"].Visible = bAdmin;
            // filter
            if (!bAdmin)
            {
                gvCurrency.Columns["ViewStatus"].FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
                gvCurrency.Columns["ViewStatus"].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo(true);
                grdCurrency.UseEmbeddedNavigator = false;
            }
            
            
        }

		void gvCurrency_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
		{
			DataRowView row = (DataRowView)e.Row;

			if (row["CurrencyID"].ToString().Trim().Length != 3)
				e.Valid = false;
		}
		private bool isChanging = false;
		void tblCurrency_RowChanged(object sender, DataRowChangeEventArgs e)
		{
			if (isChanging) return;
			isChanging = true;
			e.Row["LastUpdateDate"] = DateTime.Now;
			e.Row["UserID"] = userID;
			e.Row["UserName"] = userName;
			isChanging = false;

			//throw new Exception("The method or operation is not implemented.");
		}

       


        private void chkMainCurrency_CheckedChanged(object sender, EventArgs e)
        {

           
        }

        private void chkMainCurrency_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
			
            if ((bool)e.NewValue == true)
            {
				
				if ((bool)e.NewValue == true)
				{
					//foreach (DataRow row in tblCurrency.Rows)
					//    row["IsMainCurrency"] = false;
					for (int i = 0; i < gvCurrency.RowCount; i++)
					{
						if (tblCurrency.Rows[i]["IsMainCurrency"].ToString() == "True" && exRateTemp != null && exRateTemp.Length != 0)
						{
							tblCurrency.Rows[i]["ExRate"] = exRateTemp;
							
						}
	
						tblCurrency.Rows[i]["IsMainCurrency"] = false;
					}
					int r = gvCurrency.GetSelectedRows()[0];
					DataRow row2 = ((DataRowView)gvCurrency.GetRow(r)).Row;
					exRateTemp = row2["ExRate"].ToString();
					row2["ExRate"] = 1.00;
				
				}
				else
				{
					if ((bool)e.OldValue && (!(bool)e.NewValue))
						e.NewValue = true;
				}
               
            }
            else
            {
				for (int i = 0; i < gvCurrency.RowCount; i++)
				{
					tblCurrency.Rows[i]["IsMainCurrency"] = false;
				}
                if ((bool)e.OldValue && (!(bool)e.NewValue))
                    e.NewValue = true;
            }
        }

        private void txtExNumber_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(e.NewValue) < 0)
                    e.Cancel = true;               
            }
            catch { e.Cancel = true; }
			int r = gvCurrency.GetSelectedRows()[0];
			DataRow row2 = ((DataRowView)gvCurrency.GetRow(r)).Row;
			if (row2["IsMainCurrency"].ToString()== "True")
				e.Cancel=true;
        }
		bool isCheck;
        private void btnOk_Click(object sender, EventArgs e)
        {
            // Check if exist duplicate currency CurrencyID
            for (int nFirst = 0; nFirst < gvCurrency.RowCount - 1; nFirst++)
            {
                string strFisrt = ((DataRowView)gvCurrency.GetRow(nFirst)).Row["CurrencyID"].ToString();
                for (int nSecond = nFirst + 1; nSecond < gvCurrency.RowCount; nSecond++)
                {
                    string strSecond = ((DataRowView)gvCurrency.GetRow(nSecond)).Row["CurrencyID"].ToString();
                    if (strFisrt.Equals(strSecond))
                    {
                        MessageBox.Show(String.Format("Duplicated Currency Name '{0}' is inputted.", strFisrt));
                        return;
                    }
                }
            }
		
            // Implement
			for (int i = 0; i < gvCurrency.RowCount; i++)
			{
				if(((DataRowView)gvCurrency.GetRow(i)).Row["IsMainCurrency"].ToString()=="True")
				isCheck = true;		
			}

			if (isCheck)
			{
				//tblCurrency.Update();
                UpdateData();
				this.Close();
			}
			else
				MessageBox.Show("Need One CurrencyMain in this table");			
        }

        /// <summary>
        /// This method is to update data change of gridview instead of using tblCurrency.Update()
        /// </summary>
        private void UpdateData()
        {
            for (int nCount = 0; nCount < gvCurrency.RowCount; nCount++)
            {
                string strOldID = ((DataRowView)gvCurrency.GetRow(nCount)).Row["OldID"].ToString();
                string strCurrencyID = ((DataRowView)gvCurrency.GetRow(nCount)).Row["CurrencyID"].ToString();
                
                // Get currency data from UI
                string strCurrencyName = ((DataRowView)gvCurrency.GetRow(nCount)).Row["CurrencyName"].ToString();
                string strExRate = ((DataRowView)gvCurrency.GetRow(nCount)).Row["ExRate"].ToString();
                string bIsMainCurrency = ((DataRowView)gvCurrency.GetRow(nCount)).Row["IsMainCurrency"].ToString();
                if (strExRate.Equals("")) strExRate = "0.00";
                if (bIsMainCurrency.Equals(""))
                {
                    bIsMainCurrency = "False";
                }
                string bStatus = ((DataRowView)gvCurrency.GetRow(nCount)).Row["ViewStatus"].ToString();
                if (bStatus.Equals(""))
                {
                    bStatus = "False";
                }
                string strUserID = userID;
                string strDate = ((DataRowView)gvCurrency.GetRow(nCount)).Row["LastUpdateDate"].ToString();

                // Update or create currency data
                if (!strCurrencyID.Equals(strOldID))
                {
                    if (strOldID.Equals(""))
                    {
                        // Create new currency into Currency table
                        string strSQL = String.Format("Insert into [Currency] Values ('{0}','{1}',{2},'{3}','{4}','{5}','{6}')",
                            strCurrencyID, strCurrencyName, strExRate, bIsMainCurrency, bStatus, strUserID, strDate);

                        ExecuteSQL(strSQL);
                    }
                    else
                    {
                        // Create new currency into Currency table
                        string strSQL = String.Format("Insert into [Currency] Values ('{0}','{1}',{2},'{3}','{4}','{5}','{6}')",
                            strCurrencyID, strCurrencyName, strExRate, bIsMainCurrency, bStatus, strUserID, strDate);
                        ExecuteSQL(strSQL);                        

                        // Update ProductMaster table
                        strSQL = String.Format("Update ProductMaster Set CurrencyID='{0}' Where CurrencyID='{1}'", strCurrencyID, strOldID);
                        ExecuteSQL(strSQL);

                        // Update t_CasherDetail table
                        strSQL = String.Format("Update t_CasherDetail Set CurrencyID='{0}' Where CurrencyID='{1}'", strCurrencyID, strOldID);
                        ExecuteSQL(strSQL);

                        // Update t_OrderMaster table
                        strSQL = String.Format("Update t_OrderMaster Set CurrencyID='{0}' Where CurrencyID='{1}'", strCurrencyID, strOldID);
                        ExecuteSQL(strSQL);

                        // Delete the old one
                        strSQL = String.Format("Delete [Currency] Where CurrencyID='{0}'", strOldID);
                        ExecuteSQL(strSQL);                        
                    }
                }
                else
                {
                    // Update data of currency only, noy ID
                    // Update existing currency
                    string strSQL = String.Format("Update [Currency] Set CurrencyName='{0}',ExRate={1},IsMainCurrency='{2}',ViewStatus='{3}',UserID='{4}',LastUpdateDate='{5}' Where CurrencyID='{6}'",
                        strCurrencyName, strExRate, bIsMainCurrency, bStatus, strUserID, strDate, strCurrencyID);
                    ExecuteSQL(strSQL);
                }
            }
        }

        /// <summary>
        /// This is to implement SQL command
        /// </summary>
        /// <param name="strSQL"></param>
        private void ExecuteSQL(string strSQL)
        {
            SqlCommand oCommand = new SqlCommand();
            oCommand.CommandText = strSQL;
            oCommand.Connection = new SqlConnection(this.FConnection);
            oCommand.Connection.Open();
            SqlTransaction oTransaction = oCommand.Connection.BeginTransaction();
            oCommand.Transaction = oTransaction;
            oCommand.ExecuteNonQuery();
            oTransaction.Commit();
            oCommand.Connection.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void grdCurrency_Click(object sender, EventArgs e)
        {

        }

		private void grdCurrency_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
		{
			if (e.Button.ButtonType == NavigatorButtonType.Append)
			{
				
			}
            else if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                DataRow r = gvCurrency.GetDataRow(gvCurrency.GetSelectedRows()[0]);
                if (bool.Parse(r["IsMainCurrency"].ToString()))
                {
                    MessageBox.Show("This is main currency and it could not be deleted.");
                    e.Handled = true;
                    return;
                }

                String sql = "SELECT * FROM t_OrderMaster WHERE CurrencyId = '" + r["CurrencyId"].ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, Connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("This record cannot be deleted. This record may be using in other form");
                    e.Handled = true;
                }
            }
		}

  
    }
}

