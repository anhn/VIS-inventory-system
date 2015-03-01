using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Inventory.Process.Reorder;
using Inventory.DataObjects;

namespace Inventory.Commands.Reorder
{
    public class ReorderCommand : Command
    {
        public override void Execute()
        {
            ProductExpiredProcess prsExpire = new ProductExpiredProcess();
            try
            {
                prsExpire.Execute();
            }
            catch(Exception ex)
            {
                throw new Exception(Constants.Message.ProductExpiredError, ex);
            }

            try
            {
                ReorderLevelProcess prsReorder = new ReorderLevelProcess();
                prsReorder.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception(Constants.Message.ReorderError, ex);
            }
        }


        public void UpdateLastCheck(DateTime dtmLastCheck)
        {
            Configs objConfigs = new Configs();
            objConfigs.Name = Constants.Reorder.LastCheck;
            objConfigs.Value = dtmLastCheck.ToShortDateString();

            SqlCommand objCmd = this.NewSqlCommand();
            objConfigs.Update(objCmd);
            objCmd.Transaction.Commit();
        }
    }
}
