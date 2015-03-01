using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Inventory.DataModels;
using Inventory.DataObjects.DAO;

namespace Inventory.Process.Data
{
    public class PurgeDataProcess
    {
        private SqlCommand objCmd;

        public SqlCommand DBCommand
        {
            get { return objCmd; }
            set { objCmd = value; }
        }

        public void PurgeData(string tableName, string dateColumn, DateTime fromDate, DateTime toDate)
        {
            string strSql = "DELETE FROM " + tableName + " WHERE " + dateColumn + " >= '" + fromDate.ToShortDateString() + "' AND " + dateColumn + " <= '" + toDate.ToShortDateString() + "'";
            objCmd.CommandText = strSql;
            objCmd.CommandType = CommandType.Text;

            objCmd.ExecuteNonQuery();
        }

        public void PurgeDependentData(string primaryTable, string primaryColumn, string foreignTable, string foreignColumn, string dateColumn, DateTime fromDate, DateTime toDate)
        {
            string strDeleteSql = "DELETE FROM {0} WHERE {1} in (SELECT {0}.{1} from {0} INNER JOIN {2} ON {0}.{1} = {2}.{3} WHERE {4} >= '{5}' AND {4} <= '{6}')";

            strDeleteSql = string.Format(strDeleteSql, foreignTable, foreignColumn, primaryTable, primaryColumn, dateColumn, fromDate.ToShortDateString(), toDate.ToShortDateString());
            objCmd.CommandText = strDeleteSql;
            objCmd.CommandType = CommandType.Text;

            objCmd.ExecuteNonQuery();
        }
    }
}
