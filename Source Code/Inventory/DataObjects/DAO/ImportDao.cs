using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Inventory.DataObjects.DAO
{
    public class ImportDao : DBInteractionBase
    {
        internal int RunSql(SqlCommand objCmd, string sqlCommand)
        {
            objCmd.CommandText = sqlCommand;

            try
            {
                return objCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("ImportDao::Insert::Error occured.", ex);
            }
            finally
            {
            }
        }

        //public bool CheckExistedData(string tableName, Hashtable primaryColumnsAndValues)
        //{
        //    string strCodition = "";
        //    if(primaryColumnsAndValues.Count > 0)
        //    {
        //        strCodition += " WHERE ";
        //    }

        //    SqlCommand scmCmdToExecute = new SqlCommand();
        //    scmCmdToExecute.CommandText = "SELECT * FROM " + tableName + " where 1 = 0";
        //    scmCmdToExecute.CommandType = CommandType.Text;
        //    DataTable dtToReturn = new DataTable("ImportDao");
        //    SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

        //    // Use base class' connection object
        //    scmCmdToExecute.Connection = m_scoMainConnection;

        //    try
        //    {
        //        if (m_bMainConnectionIsCreatedLocal)
        //        {
        //            // Open connection.
        //            m_scoMainConnection.Open();
        //        }
        //        else
        //        {
        //            if (m_cpMainConnectionProvider.bIsTransactionPending)
        //            {
        //                scmCmdToExecute.Transaction = m_cpMainConnectionProvider.stCurrentTransaction;
        //            }
        //        }

        //        // Execute query.
        //        sdaAdapter.Fill(dtToReturn);
        //        return dtToReturn.Rows.Count > 0;
        //    }
        //    catch(Exception ex)
        //    {
        //        // some error occured. Bubble it to caller and encapsulate Exception object
        //        throw new Exception("ImportDao::CheckExistedData::Error occured.", ex);
        //    }
        //    finally
        //    {
        //    }
        //}
    }
}
