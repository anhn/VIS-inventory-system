using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Inventory.DataObjects.DAO
{
    public class InvoiceMasterDao : DBInteractionBase
    {
        public DataTable GetPeriodInvoiceMasters(DateTime startDate, DateTime endDate)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "Select InvoiceMaster.* from InvoiceMaster inner join InvoiceInfo on InvoiceMaster.InvoiceInfoID = InvoiceInfo.ID where TransactionDate >= '" + startDate + "' and TransactionDate <= '" + endDate + "'";
            DataTable dtToReturn = new DataTable("InvoiceMaster");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                sdaAdapter.Fill(dtToReturn);
                m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("InvoiceMasterDao::GetPeriodInvoiceMasters::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
    }
}
