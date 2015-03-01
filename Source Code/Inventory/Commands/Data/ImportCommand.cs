using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Windows.Forms;
using Inventory.Forms.Data;
using Inventory.Process.Data;

namespace Inventory.Commands.Data
{
    public class ImportCommand : Command
    {
        /// <summary>
        /// Store the table name and the correct order of tables to import.
        /// </summary>
        static string[] arrTablesOrder = null;

        Properties.Settings settings = Properties.Settings.Default;

        public override void Execute()
        {
            // INITIALIZE THE ORDER OF TABLES TO BE IMPORTED.
            if (arrTablesOrder == null)
            {
                arrTablesOrder = new string[] { 
                    settings.TB_WAREHOUSE, 
                    settings.TB_LOCATION,
                    settings.TB_PRODUCT_CATEGORY,
                    settings.TB_PRODUCT_FAMILY,
                    settings.TB_PRODUCT_SUB_CATEGORY,
                    settings.TB_UOM,
                    settings.TB_BARCODE,
                    settings.TB_PRODUCT,
                    settings.TB_CONTACT,
                    settings.TB_PAYMENT_TERM,
                    settings.TB_TAX_CODE_MASTER,
                    settings.TB_CUSTOMER,
                    settings.TB_BOM,
                    settings.TB_PAYMENT_METHOD,
                    settings.TB_ORDER_TYPE,
                    settings.TB_PURCHASE_ORDER,
                    settings.TB_PURCHASE_ORDER_DETAIL,
                    settings.TB_SHOP,
                    settings.TB_SALES_ORDER,
                    settings.TB_SALES_ORDER_DETAIL,
                    
                    settings.TB_STOCK_IN,
                    settings.TB_STOCK_IN_DETAILS,
                    settings.TB_STOCK_OUT,
                    settings.TB_STOCK_OUT_DETAILS,
                    settings.TB_PICKING_LIST,
                    settings.TB_PICKING_LIST_DETAILS,
                    settings.TB_PACKING_LIST,
                    settings.TB_PACKING_LIST_DETAILS,
                    settings.TB_DELIVERY_METHOD,
                    settings.TB_DELIVERY_NOTES,
                    settings.TB_DELIVERY_NOTES_DETAILS,
                    settings.TB_STOCK_TRANSFER,
                    settings.TB_STOCK_TRANSFER_DETAILS,
                    settings.TB_INVENTORY_ADJUSTMENT,
                    settings.TB_INVENTORY_ADJUSTMENT_DETAILS,
                    settings.TB_INVENTORY_UPDATE,
                    settings.TB_INVENTORY_UPDATE_DETAILS,
                    settings.TB_PHYSICAL_TAKE,
                    settings.TB_PHYSICAL_TAKE_DETAILS
                };
            }

            SqlCommand objCmd = null;
            try
            {
                ImportData frmImport = new ImportData();
                if (DialogResult.Cancel == frmImport.ShowDialog()) return;

                XmlDocument xmlDoc = frmImport.XmlDoc;
                ImportProcess pr = new ImportProcess();

                objCmd = NewSqlCommand();
                pr.DBCommand = objCmd;
                pr.ImportOption = frmImport.ImportType; // 2: override exist data, 1: skip exist data, 0 (is default): stop.

                // iterator on table names to get the correct order of import tables
                foreach (string strTable in arrTablesOrder)
                {
                    // if table name exist in file
                    foreach (XmlNode xmlNode in xmlDoc.DocumentElement.ChildNodes)
                    {
                        if (strTable.Equals(xmlNode.Name, StringComparison.CurrentCultureIgnoreCase))
                        {
                            XmlTextReader xmlReader = new XmlTextReader(xmlNode.OuterXml, XmlNodeType.Element, null);
                            DataSet ds = new DataSet();
                            ds.ReadXml(xmlReader);

                            if (ds.Tables.Count == 0)
                            {
                                continue;
                            }

                            int intImport = pr.ImportData(strTable, ds.Tables[0]); // import table
                            if (intImport == 0)
                            {
                                MessageBox.Show(Constants.Message.Import_DataExistStop, Constants.Message.MessageTitle);
                                return;
                            }
                        }
                    }
                }
                                
                objCmd.Transaction.Commit();
                MessageBox.Show(Constants.Message.Import_Success, Constants.Message.MessageTitle);
            }
            catch (Exception ex)
            {
                string strMessage = ex.Message;
                while (ex.InnerException != null)
                {
                    strMessage += Environment.NewLine + ex.InnerException.Message;
                    ex = ex.InnerException;
                }
                MessageBox.Show(strMessage);

                if (objCmd != null)
                {
                    objCmd.Transaction.Rollback();
                }

            }
            finally
            {
                if (objCmd != null)
                {
                    objCmd.Connection.Close();
                }
            }
        }
    }
}
