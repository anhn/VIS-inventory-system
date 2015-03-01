using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VIS.ControlSetting
{
    public class ControlSetting
    {
        /*---------------------------------------------------------------------------------
         * Developed By: Sun
         * Date: 3/3/2007
         * 
         * Description: Fill the first column of data to the ComboBoxEdit
         * Parameters:  1. cboObject - The ComboBoxEdit object
         *              2. drReader - The data to be listed in the ComboBoxEdit 
         * -------------------------------------------------------------------------------*/
        public static void FillComboBoxEdit(ComboBoxEdit cboObject, SqlDataReader drReader)
        {
            try
            {
                while (drReader.Read())
                    cboObject.Properties.Items.Add(drReader.GetValue(0).ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FillLookupEdit(LookUpEdit lueObject, DataTable dtGeneral, string displayField, string valueField)
        {
            if (dtGeneral != null)
            {
                lueObject.DataBindings.Add("EditValue", dtGeneral, valueField);
                lueObject.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(valueField));
                lueObject.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(displayField));
                lueObject.Properties.DataSource = dtGeneral;
                lueObject.Properties.DisplayMember = displayField;
                lueObject.Properties.ValueMember = valueField;
            }

                foreach (DevExpress.XtraEditors.Controls.LookUpColumnInfo columnInfo in lueObject.Properties.Columns)
                    if (columnInfo.FieldName == valueField)
                        columnInfo.Visible = false;
        }
    }
}
