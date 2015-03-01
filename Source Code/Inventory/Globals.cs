using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Inventory.Properties;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

namespace Inventory
{
    public class TabItem
    {
        public string ItemID;
        public string ItemName;
        public TabItem(string ID, string _name)
        {
            ItemID = ID;
            ItemName = _name;

        }
        public override string ToString()
        {
            return ItemName;
        }

        static public TabItem GetItemById(CollectionBase tabCollection, string strID)
        {
            foreach (TabItem item in tabCollection)
            {
                if (item.ItemID.Equals(strID))
                {
                    return item;
                }
            }

            return null;
        }
    }
    #region G8soft\Kiendd\200070729
    class Validator
    {
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
    #endregion
    public class Globals
    {
        #region G8soft\KienDD\VendorPayment20070728
        public static DA_DataTable dtVendorPayment = new DA_DataTable("Select * from VendorPayment  Order By VendorPaymentNo Desc", false);
        public static DA_DataTable dtCustomerPayment = new DA_DataTable("Select * from CustomerPayment  Order By CustomerPaymentNo Desc", false);
        public static DA_DataTable dtUOM = new DA_DataTable("Select * from UOM", false);
        public static DA_DataTable dtSaleReturnMaster = new DA_DataTable("Select * from SaleReturnMaster", false);
        #endregion        
        #region G8soft\KienDD\FixWarehouse\20070729

        public static DA_DataTable dtWarehouse_Master = new DA_DataTable("Select * from Warehouse_Master Order By Warehouse_code", false);
        public static DA_DataTable dtLocation_Master = new DA_DataTable("Select * from Location_Master", false);
        public static DA_DataTable dtProductLocation = new DA_DataTable("select * from ProductLocation", false);

        public static DA_DataTable dtProductMaster = new DA_DataTable("Select * from ProductMaster", false);
        #endregion

        #region KienPD\Delivery Method Management\20070804
        public static DA_DataTable dtDeliveryMethod = new DA_DataTable("Select * from DeliveryMethod", false);
        public static DA_DataTable dtShipViaMethod = new DA_DataTable("Select * from ShipVia", false);
        public static DA_DataTable dtPackageType = new DA_DataTable("Select * from [Package Type Master]", false);
        public static DA_DataTable dtOperationPeriod = new DA_DataTable("Select * from PeriodMaster", false);
        #endregion

        public static string strVISConnection = Settings.Default.ConnectionString;
        public static string UserID;
        public static string UserName;
        public static bool isAdministrator;
        public static bool canExit = true;
        public static void SetDefaultFont(Control ctrl)
        {
            ctrl.Font = Settings.Default.cfgDefaultFont;
            foreach (Control ct in ctrl.Controls)
            {
                SetDefaultFont(ct);
            }
        }
        public static t_Purchase_Order_DetailTable purchaseOrderDetailTable = new t_Purchase_Order_DetailTable(Data_Access.getConnection());
        public static t_Purchase_Order_HeaderTable purchaseOrderHeaderTable = new t_Purchase_Order_HeaderTable(Data_Access.getConnection());
        public static t_Sales_Order_DetailTable salesOrderDetailTable = new t_Sales_Order_DetailTable(Data_Access.getConnection());
        public static t_Sales_Order_HeaderTable salesOrderHeaderTable = new t_Sales_Order_HeaderTable(Data_Access.getConnection());
        public static OrderTypeTable tblOrderType = new OrderTypeTable(Data_Access.getConnection());
        
        public static DA_Supplier daSupplier = new DA_Supplier();
        public static DA_Customer daCustomer = new DA_Customer();
        public static Payment_Term_MasterTable paymentTermMasterTable = new Payment_Term_MasterTable(Data_Access.getConnection());
        public static Tax_code_masterTable taxCodeMasterTable = new Tax_code_masterTable(Data_Access.getConnection());
        public static t_ShopTable shopTable = new t_ShopTable(Data_Access.getConnection());

        private static CultureInfo cul = new CultureInfo("en-US", false);
        private static NumberFormatInfo num = new NumberFormatInfo();
        public static NumberFormatInfo getNumberFormat()
        {
            if (Settings.Default.cfgNumberFormat == 0)
            {
                num.NumberGroupSeparator = " ";
                num.NumberDecimalSeparator = ".";
                num.NumberGroupSeparator = ",";
            }
            else if (Settings.Default.cfgNumberFormat == 1)
            {
                num.NumberGroupSeparator = " ";
                num.NumberDecimalSeparator = ",";
                num.NumberGroupSeparator = ".";
            }
            return num;
        }
        public static CultureInfo getCulture()
        {
            
            cul.NumberFormat = getNumberFormat();
            cul.DateTimeFormat.LongDatePattern = Settings.Default.cfgDateFormat;
            cul.DateTimeFormat.LongTimePattern = Settings.Default.cfgTimeFormat;
            cul.DateTimeFormat.ShortDatePattern = Settings.Default.cfgDateFormat;
            cul.DateTimeFormat.ShortTimePattern = Settings.Default.cfgTimeFormat;
            return cul;
        }
        public static bool CheckAccessRights(string strLoginID, string functionID, bool blnAlarmMessage)
        {
            bool blnHasRights = false;

            string strSQL = "SELECT * FROM VUserSecurity WHERE UserID = '" + strLoginID + "' AND FunctionID = '" + functionID + "'";

            SqlConnection cnContactMgmt = new SqlConnection(Globals.strVISConnection);

            if (cnContactMgmt.State == ConnectionState.Closed)
                cnContactMgmt.Open();

            SqlCommand cmdSelect = new SqlCommand(strSQL, cnContactMgmt);

            SqlDataReader drReader = cmdSelect.ExecuteReader();

            if (drReader.HasRows)
            {
                blnHasRights = true;
            }

            drReader.Close();
            cnContactMgmt.Close();


            if (blnHasRights)
            {
                return true;
            }
            else
            {
                if (blnAlarmMessage)
                {
                    MessageBox.Show("You don't have rights to access this function, please contact to administrator.", "System Information");
                }
                return false;
            }


        }
    }
    
}
