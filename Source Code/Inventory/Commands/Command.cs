using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Inventory.Commands
{
    public abstract class Command
    {

        public SqlCommand NewSqlCommand ()
        {
            String strConn = Inventory.Properties.Settings.Default.ConnectionString;
            SqlConnection objConn = new SqlConnection(strConn);
            objConn.Open();
            SqlCommand objCmd = objConn.CreateCommand();
            objCmd.Transaction = objConn.BeginTransaction();
            return objCmd;
        }
        public abstract void Execute();
    }
}
