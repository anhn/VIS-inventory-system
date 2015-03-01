using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frmAddEditUOM : Form
    {
        public frmAddEditUOM()
        {
            InitializeComponent();
        }
        #region Variable
        #endregion
        #region Method
        private void LoadData()
        {
            if (!ProTypeAdd)
            {
                txtNote.EditValue = ProRow["Note"];
                chkViewStatus.EditValue = ProRow["ViewStatus"];
                //txtNote.Enabled = false;
            }
            else
            {
                chkViewStatus.EditValue = true;
                //txtNote.Enabled = true;
            }
        }
        private bool CheckExistName()
        {
            for (int i = 0; i < Globals.dtUOM.Rows.Count; i++)
            {
                if (Globals.dtUOM.Rows[i]["Note"].ToString() == txtNote.Text && Globals.dtUOM.Rows[i]["UOMID"].ToString()!=ProRow["UOMID"].ToString())
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckValidated()
        {
            if (txtNote.Text.Trim() == "")
            {
                MessageBox.Show("Field UOM empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNote.Focus();
                return false;   
            }
        
                if (CheckExistName())
                {
                    MessageBox.Show("There is a same name of UOM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNote.Text = ProRow["Note"].ToString();
                    txtNote.Focus();
                    return false;
                }

            return true;
        }
    
        #endregion
        #region Property
        bool strTypeAdd;
        public bool ProTypeAdd
        {
            get
            {
                return this.strTypeAdd;
            }
            set
            {
                strTypeAdd = value; 
            }

        }
        DataRow row;
        public DataRow ProRow
        {
            get
            {
                return this.row;
            }
            set
            {
                row = value;
                LoadData();
            }
        }

        #endregion
        #region Event
        private void frmAddEditUOM_Load(object sender, EventArgs e)
        {
            txtNote.Select();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!CheckValidated())
                return;
            ProRow["Note"] = txtNote.EditValue;
            ProRow["ViewStatus"] = chkViewStatus.EditValue;
            if (ProTypeAdd)
            {
                ProRow["UOMID"] = System.Guid.NewGuid();
                Globals.dtUOM.Rows.Add(ProRow);
                Globals.dtUOM.Update();
            }
            else
            {

            }
            this.DialogResult = DialogResult.OK;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}