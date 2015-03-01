using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Inventory.Forms.Binder
{
    class XComboBinder
    {
        public void BindComboBox(DevExpress.XtraEditors.ComboBoxEdit cboBox, DataTable dt, string strDisplayColumn, string strValueColumn)
        {
            cboBox.Properties.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                cboBox.Properties.Items.Add(new XTagItem(row[strValueColumn].ToString(), row[strDisplayColumn].ToString()));
            }
        }
    }
}
