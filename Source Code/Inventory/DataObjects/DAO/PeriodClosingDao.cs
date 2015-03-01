using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Inventory.DataObjects.DAO
{
    public class PeriodClosingDao : DBInteractionBase
    {
        public DataTable SelectLastOpenPeriodData(PeriodMaster periodMaster, string periodTypeID)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "select * from PeriodMaster where Status = '" + 
                Constants.PeriodClosing.OpenStatus + "' and PeriodTypeID = '" + periodTypeID + "'";
            scmCmdToExecute.CommandType = CommandType.Text;
            DataTable dtToReturn = new DataTable("PeriodMaster");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;


            try
            {
                // Open connection.
                m_scoMainConnection.Open();
                // Execute query.
                sdaAdapter.Fill(dtToReturn);

                if (dtToReturn.Rows.Count > 0)
                {
                    periodMaster.ID = (string)dtToReturn.Rows[0]["ID"];
                    periodMaster.Description = dtToReturn.Rows[0]["Description"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Description"];
                    periodMaster.StartDate = dtToReturn.Rows[0]["StartDate"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["StartDate"];
                    periodMaster.EndDate = dtToReturn.Rows[0]["EndDate"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["EndDate"];
                    periodMaster.PeriodTypeID = dtToReturn.Rows[0]["PeriodTypeID"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["PeriodTypeID"];
                    periodMaster.Status = dtToReturn.Rows[0]["Status"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Status"];
                    periodMaster.ViewStatus = dtToReturn.Rows[0]["ViewStatus"] == System.DBNull.Value ? SqlBoolean.Null : (bool)dtToReturn.Rows[0]["ViewStatus"];
                }
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("PeriodMaster::SelectLastOpenPeriodData::Error occured.", ex);
            }
            finally
            {
                //// Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
    }
}
