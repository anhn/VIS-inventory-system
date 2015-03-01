using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Forms.Warehouse;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using Inventory.DataModels.Product;
using Inventory.Process.Product;
using Inventory.Forms.Product;
using System.Data.SqlClient;

namespace Inventory.Commands.Product
{
    public class EditWorkOrderCommand : Command
    {
        private double dblNumber = 0;

        public double Number
        {
            set { dblNumber = value; }
        }

        public override void Execute()
        {
            SqlCommand objCmd = null;
            try
            {
                WorkOrderModel dm = new WorkOrderModel();
                dm.Number = dblNumber;
                dm.LoadDataFromDataBase();

                WorkOrder frmWorkOrder = new WorkOrder();
                frmWorkOrder.BindData(dm);
                if (DialogResult.Cancel == frmWorkOrder.ShowDialog())
                {
                    return;
                }

                objCmd = NewSqlCommand();
                WorkOrderProcess pr = new WorkOrderProcess();
                pr.DBCommand = objCmd;
                pr.DataIn = frmWorkOrder.DataModel;

                pr.EditWorkOrder();

                objCmd.Transaction.Commit();
                MessageBox.Show(Constants.Message.Save_Success, Constants.Message.MessageTitle);
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
