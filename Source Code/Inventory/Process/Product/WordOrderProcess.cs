using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using Inventory.DataModels.Product;
using Inventory.DataObjects;
using Inventory.DataModels;

namespace Inventory.Process.Product
{
    class WorkOrderProcess
    {
        private WorkOrderModel model;
        private double dblDeleteNumber = 0;
        private SqlCommand objCmd;

        public WorkOrderModel DataIn
        {
            get { return model; }
            set { model = value; }
        }

        public SqlCommand DBCommand
        {
            get { return objCmd; }
            set { objCmd = value; }
        }

        public double DeleteNumber
        {
            get { return dblDeleteNumber; }
            set { dblDeleteNumber = value; }
        }

        public void NewWorkOrder()
        {
            WorkOrder masterDelv = model.GetMasterRecord();
            masterDelv.Insert(objCmd);
        }

        internal void EditWorkOrder()
        {
            WorkOrder masterDelv = model.GetMasterRecord();

            masterDelv.Update(objCmd);
        }

        internal void DeleteWorkOrder()
        {
            WorkOrder masterDelv = new WorkOrder();
            masterDelv.Number = (decimal)dblDeleteNumber;
            masterDelv.Delete(objCmd);
        }
    }
}
