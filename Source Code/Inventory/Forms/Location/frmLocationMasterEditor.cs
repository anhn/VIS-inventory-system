using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;

using System.Xml;
using System.Data;
using System.Data.SqlClient;

using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Columns;
using System.Collections.Generic;

using System.Drawing.Printing;
using DevExpress.Utils;




namespace Inventory
{
	/// <summary>
	/// Summary description for frmLocationMasterEditor.
	/// </summary>
	public class frmLocationMasterEditor : DevExpress.XtraEditors.XtraForm
	{
		private GroupControl grbCenter;
        private TextEdit txtSequence;
		private SimpleButton btnCancel;
		private SimpleButton btnOk;
		private TextEdit txtLocation;
        private Label label12;
        private Label label4;
        private Label label1;
        private ComboBoxEdit cboParent;
        private ComboBoxEdit cboWarehouse;
        private Label label2;
        private MemoEdit memNotes;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmLocationMasterEditor()
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
            this.grbCenter = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            this.memNotes = new DevExpress.XtraEditors.MemoEdit();
            this.cboWarehouse = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboParent = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.txtLocation = new DevExpress.XtraEditors.TextEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSequence = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grbCenter)).BeginInit();
            this.grbCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboWarehouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboParent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequence.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCenter
            // 
            this.grbCenter.Controls.Add(this.label2);
            this.grbCenter.Controls.Add(this.memNotes);
            this.grbCenter.Controls.Add(this.cboWarehouse);
            this.grbCenter.Controls.Add(this.cboParent);
            this.grbCenter.Controls.Add(this.btnCancel);
            this.grbCenter.Controls.Add(this.btnOk);
            this.grbCenter.Controls.Add(this.txtLocation);
            this.grbCenter.Controls.Add(this.label12);
            this.grbCenter.Controls.Add(this.label4);
            this.grbCenter.Controls.Add(this.label1);
            this.grbCenter.Controls.Add(this.txtSequence);
            this.grbCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbCenter.Location = new System.Drawing.Point(0, 0);
            this.grbCenter.Name = "grbCenter";
            this.grbCenter.ShowCaption = false;
            this.grbCenter.Size = new System.Drawing.Size(331, 287);
            this.grbCenter.TabIndex = 0;
            this.grbCenter.Text = "groupControl4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Notes:";
            // 
            // memNotes
            // 
            this.memNotes.Location = new System.Drawing.Point(115, 179);
            this.memNotes.Name = "memNotes";
            this.memNotes.Size = new System.Drawing.Size(141, 52);
            this.memNotes.TabIndex = 3;
            // 
            // cboWarehouse
            // 
            this.cboWarehouse.Location = new System.Drawing.Point(115, 99);
            this.cboWarehouse.Name = "cboWarehouse";
            this.cboWarehouse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboWarehouse.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboWarehouse.Size = new System.Drawing.Size(141, 20);
            this.cboWarehouse.TabIndex = 1;
            this.cboWarehouse.SelectedIndexChanged += new System.EventHandler(this.cboWarehouse_SelectedIndexChanged);
            // 
            // cboParent
            // 
            this.cboParent.Location = new System.Drawing.Point(115, 138);
            this.cboParent.Name = "cboParent";
            this.cboParent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboParent.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboParent.Size = new System.Drawing.Size(141, 20);
            this.cboParent.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(181, 252);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(100, 252);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "&Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(115, 65);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Properties.MaxLength = 36;
            this.txtLocation.Size = new System.Drawing.Size(141, 20);
            this.txtLocation.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Location Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parent:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Warehouse:";
            // 
            // txtSequence
            // 
            this.txtSequence.Location = new System.Drawing.Point(115, 65);
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.Properties.DisplayFormat.FormatString = "n0";
            this.txtSequence.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSequence.Properties.EditFormat.FormatString = "n0";
            this.txtSequence.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSequence.Properties.Mask.EditMask = "n0";
            this.txtSequence.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSequence.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSequence.Properties.MaxLength = 5;
            this.txtSequence.Size = new System.Drawing.Size(10, 20);
            this.txtSequence.TabIndex = 4;
            // 
            // frmLocationMasterEditor
            // 
            this.ClientSize = new System.Drawing.Size(331, 287);
            this.Controls.Add(this.grbCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLocationMasterEditor";
            this.Text = "Location Master Editor";
            this.Load += new System.EventHandler(this.frmLocationMasterEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grbCenter)).EndInit();
            this.grbCenter.ResumeLayout(false);
            this.grbCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboWarehouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboParent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequence.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        #region Variable
        #endregion
        #region Method
        private bool CheckDuplicateName()
        {
            
            DataRow[] arrRow = Globals.dtLocation_Master.Select("True");
            for (int i = 0; i < arrRow.Length; i++)
            {
                if (arrRow[i]["Bin_location_id"].ToString() == txtLocation.Text)
                {
                    return true;
                }
            }
            return false;
        }
        private void LoadText()
        {
            if (ProRow["Bin_location_id"].ToString() != "")
            {
                txtLocation.EditValue = ProRow["Bin_location_id"];
                //txtSequence.EditValue = ProRow["Sequence"];
                cboWarehouse.Enabled = false;
                cboParent.Enabled = false;
                txtLocation.Enabled = false;
                memNotes.EditValue = ProRow["Notes"];
            }
            else
            {
                txtLocation.Enabled = true;
                cboWarehouse.Enabled=true;
                //txtSequence.EditValue=0;
                cboParent.Enabled=true;
            }
        }
        private void LoadCboWarehouse()
        {
            DataRow[] arrRow = Globals.dtWarehouse_Master.Select("True");
            for (int i = 0; i < arrRow.Length; i++)
            {
                cboWarehouse.Properties.Items.Add(
                    new TabItem(arrRow[i]["Warehouse_id"].ToString(),
                    arrRow[i]["Description"].ToString()));
            }
            cboWarehouse.SelectedIndex=0;
            if (cboWarehouse.Properties.Items.Count > 0)
            {
                for (int i = 0; i < cboWarehouse.Properties.Items.Count; i++)
                {
                    if (((TabItem)cboWarehouse.Properties.Items[i]).ItemID == ProRow["Warehouse_id"].ToString())
                    {
                        cboWarehouse.SelectedIndex = i;
                        return;
                    }
                }
            }

        }
        private void LoadCboParent()
        {
            cboParent.Properties.Items.Clear();
            cboParent.Properties.Items.Add("");
     
            DataRow[] arrRow = Globals.dtLocation_Master.Select("True");
            for (int i = 0; i < arrRow.Length; i++)
            {
                if (arrRow[i]["Bin_location_id"].ToString() != ProRow["Bin_location_id"].ToString())
                {
                    if (arrRow[i]["Warehouse_id"].ToString() == ((TabItem)cboWarehouse.Properties.Items[cboWarehouse.SelectedIndex]).ItemID)
                    {
                        cboParent.Properties.Items.Add(arrRow[i]["Bin_location_id"].ToString());
                    }
                }
            }

            for (int i = 0; i < cboParent.Properties.Items.Count; i++)
            {
                if (cboParent.Properties.Items[i].ToString()== ProRow["Parent_location_id"].ToString()&&cboParent.Properties.Items[i]!="")
                {
                    cboParent.SelectedIndex = i;
                    return;
                }
            }
            cboParent.SelectedIndex = 0;
         }

        private bool CheckValidated()
        {
            Validator val = new Validator();
            if (txtLocation.Enabled == true)
            {
                if (CheckDuplicateName())
                {
                    MessageBox.Show("This name is already avaiable, please select another one.", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLocation.Focus();
                    return false;
                }
            }
            if (txtLocation.Text.Trim() == "")
            {
                MessageBox.Show("Field  Location Name empty.", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLocation.Focus();
                return false;
            }
           
            return true;
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
        #endregion

        


        #region Event
        private void frmLocationMasterEditor_Load(object sender, EventArgs e)
        {
            cboParent.Properties.Items.Add("");
            cboParent.SelectedIndex = 0;
            LoadCboWarehouse();
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!CheckValidated())
                return;
            ProRow["Bin_location_id"] = txtLocation.Text;
            ProRow["Notes"] = memNotes.EditValue;
            ProRow["Warehouse_id"] = ((TabItem)cboWarehouse.Properties.Items[cboWarehouse.SelectedIndex]).ItemID;
            ProRow["Parent_location_id"] = cboParent.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCboParent();
        }

        #endregion



       
	}
}

