using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Inventory.Forms
{
    class Validator
    {
        public bool IsNonEmpty(String propertyName, String value,bool isShowMessage)
        {
            if (String.IsNullOrEmpty(value.Trim()))
            {
                if (isShowMessage) MessageBox.Show("Field " + propertyName + " empty", "Error");
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool IsNonEmpty(String propertyName, String value)
        {
            if (String.IsNullOrEmpty(value.Trim()))
            {
                MessageBox.Show("Field " + propertyName + " empty", "Error");
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool IsDecimal(String propertyName, String value)
        {
            try
            {
                Convert.ToDecimal(value);
                return true;
            }
            catch
            {
                MessageBox.Show("Field " + propertyName + " is not a valid Decimal", "Error");
                return false;
            }
        }

        public bool IsPositiveDecimal(String propertyName, String value)
        {
            try
            {
                
                Decimal d = Convert.ToDecimal(value);
                
                //Int32.Parse(value);
                //Try to convert value to Integer
                int i = Convert.ToInt32(d);
                Decimal d1 = new Decimal(i);
                if (d.CompareTo(d1) != 0)
                {
                    MessageBox.Show("Field " + propertyName + " is not a valid Integer", "Error");
                    return false;
                }
                if (d.CompareTo(0) >= 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Field " + propertyName + " is not a positive Integer", "Error");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Field " + propertyName + " is not a valid Integer", "Error");
                return false;
            }
        }

        public bool IsNotNull(String propertyName, object value)
        {
            if (value == null)
            {
                MessageBox.Show("Field " + propertyName + " is not entered", "Error");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsDateTime(String propertyName, String value)
        {
            try
            {
                DateTime.Parse(value);
                return true;
            }
            catch
            {
                MessageBox.Show("Field " + propertyName + " is not a valid DateTime", "Error");
                return false;
            }
        }

        
    }
}
