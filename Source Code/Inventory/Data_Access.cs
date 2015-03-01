using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;


namespace Inventory
{
    public class Data_Access
    {
        /// <remarks>
        /// Thiet lap ket noi toi CSDL
        /// Neu thanh cong, tra ve tru
        /// Neu that bai, tra ve false
        /// </remarks>

        private static System.Data.SqlClient.SqlConnection dbConn = null;
        private static DataSet dtsResult = null;
        public static SqlConnection getConnection()
        {
            if (dbConn == null) Connect();           
            return dbConn;
        }
        public static bool Connect()
        {                         
            try
            {

                /***************************************************
                 * Modified by: Nguyen Thai Duong
                 * Date: 20/3/2007
                 * 
                 ***************************************************/
                if (dbConn != null)
                {
                    if (dbConn.State == ConnectionState.Open) return true;
                    dbConn.ConnectionString = Globals.strVISConnection;                    
                } else
                    dbConn = new System.Data.SqlClient.SqlConnection(Globals.strVISConnection);
                dbConn.Open();

                /***************************************************                 
                 * End Modified.
                 ***************************************************/
            }
            catch
            {
                dbConn = null;
                throw;
            }

            return true;
            //throw new System.NotImplementedException();
        }

        /// <remarks>
        /// Ngat ket noi toi CSDL
        /// tra ve true neu thanh cong
        /// false neu that bai
        /// </remarks>
        public static bool Disconnect()
        {
            if (dbConn == null)
                return false;
            try
            {
                dbConn.Close();
            }
            catch
            {
                return false;
            }

            return true;
            //throw new System.NotImplementedException();
        }

        /// <remarks>
        /// Thuc hien mot cau lenh SQL
        /// gia tri tra ve:
        /// true neu thanh cong
        /// false neu that bai
        /// </remarks>
        public static bool DoSqlCommand(string command)
        {
            if (dbConn == null)
                Connect();
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            if (command == null || command == "")
                return false;


            /***************************************************
             * Modified by: Nguyen Thai Duong
             * Date: 20/3/2007
             * 
             ***************************************************/
            command = command.Trim();
            Boolean isSelect = command.StartsWith("s") | command.StartsWith("S");            

            try
            {
                if (dtsResult == null) dtsResult = new DataSet();
                dtsResult.Tables.Clear();
                dtsResult.Clear();
                if (isSelect)
                {
                    // select command%
                    System.Data.SqlClient.SqlDataAdapter adt = new SqlDataAdapter(command, dbConn);
                    adt.Fill(dtsResult);
                }
                else
                {
                    System.Data.SqlClient.SqlCommand cmd = new SqlCommand(command, dbConn);
                    dtsResult = null;
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                dtsResult = null;
                return false;
            }

            return true;
            //throw new System.NotImplementedException();
        }

        /// <remarks>
        /// Lay ve dataset la ket qua cua cau lenh SQL command gan nhat
        /// tra ve 1 dataset neu cau lenh SQL gan nhat thanh cong va la lenh SELECT
        /// tra ve null neu lenh SQL gan nhat that bai hoac khong phai lenh SELECt
        /// </remarks>
        public static DataSet GetDataSet()
        {
            return dtsResult;
            //throw new System.NotImplementedException();
        }
    }
}
