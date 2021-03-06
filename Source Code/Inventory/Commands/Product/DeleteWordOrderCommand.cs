using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Forms.Warehouse;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using Inventory.DataModels.Product;
using Inventory.Process.Product;
using System.Data.SqlClient;

namespace Inventory.Commands.Product
{
    public class DeleteWorkOrderCommand : Command
    {
        private double dblNumber = 0;

        public double Number
        {
            get { return dblNumber; }
            set { dblNumber = value; }
        }

        public override void Execute()
        {
            DialogResult dlgResult = MessageBox.Show(Properties.Settings.Default.strWarningDelete, Properties.Settings.Default.strWarningTitle, MessageBoxButtons.OKCancel);
            if (dlgResult == DialogResult.Cancel)
            {
                return;
            }

            SqlCommand objCmd = null;
            try
            {
                objCmd = NewSqlCommand();
                WorkOrderProcess pr = new WorkOrderProcess();

                pr.DBCommand = objCmd;
                pr.DeleteNumber = dblNumber;

                pr.DeleteWorkOrder();

                objCmd.Transaction.Commit();
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
