using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
//This file was created for database management purpose
//Written by CenDoy
//Date: 13/4/2007
namespace SqlTest
{
    static class DbManager
    {
        public static string server;
        public static string database;
        public static string username;
        public static string password;
        public static SqlConnection con;
        public static SqlCommand com;
        public static SqlDataReader reader;

        //return connection string to the database include of inital database
        public static string getConnectString()
        {
            return "Data Source=" + server + ";Initial Catalog=" + database + ";User Id=" + username + ";Password=" + password + ";";
        }
        
        //connect to database
        public static void Connect()
        {
            con = new SqlConnection(getConnectString());
        }

        //open a sql command and return in reader
        public static bool OpenSQL(string sql)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Open) con.Close();
                con.Open();
                com = new SqlCommand(sql, con);
                reader = com.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occurs: " + (ex.ToString()));
                return false;
            }
        }

        //execute a sql command with non returned.
        public static bool ExeSQL(string sql)
        {
            try
            {
                if (con == null) Connect();
                if (con.State == System.Data.ConnectionState.Open) con.Close();
                con.Open();
                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occurs: " + (ex.ToString()));
                return false;
            }
        }
    }
}
