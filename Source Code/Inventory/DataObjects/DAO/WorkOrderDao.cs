using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Inventory.DataObjects.DAO
{
    public class WorkOrderDao : DBInteractionBase
    {
        internal double GetMaxNumber()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "Select Max(Number) from WorkOrder";
            //scmCmdToExecute.CommandText = "Select ProductName, ProductId from ProductMaster ";
            scmCmdToExecute.CommandType = CommandType.Text;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Open connection.
                    m_scoMainConnection.Open();
                }
                else
                {
                    if (m_cpMainConnectionProvider.bIsTransactionPending)
                    {
                        scmCmdToExecute.Transaction = m_cpMainConnectionProvider.stCurrentTransaction;
                    }
                }

                // Execute query.
                object number = scmCmdToExecute.ExecuteScalar();
                if (number == DBNull.Value)
                {
                    return 0;
                }

                return Convert.ToDouble(number);
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("WorkOrder::GetNewNumber::Error occured.", ex);
            }
            finally
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    m_scoMainConnection.Close();
                }
                scmCmdToExecute.Dispose();
            }
        }
    }
}
