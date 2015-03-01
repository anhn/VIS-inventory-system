using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Properties;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Inventory
{
    class LangSetting
    {
        private static SqlConnection sqlConn;

        // load language from database
        // 1 <= lang <= 4
        public static void LoadLanguage(int lang)
        {
            
            try
            {
                if (sqlConn == null)
                {
                    sqlConn = new SqlConnection(Settings.Default.ConnectionString);
                    sqlConn.Open();
                }
                // load language from database
                DataTable dtLang = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM languages", sqlConn);
                adapter.Fill(dtLang);
                foreach (DataRow row in dtLang.Rows)
                {
                    try {
                        Settings.Default[row[0].ToString()] = row[(lang % 4) + 1].ToString();
                    } catch (Exception) {}
                }

            }
            catch (Exception) { }
        }
        // nap du lieu tu file xml len database  
        // dung de khoi tao ban dau
        public static void RestoreLanguage()
        {
            try
            {
                if (sqlConn == null)
                {
                    sqlConn = new SqlConnection(Settings.Default.ConnectionString);
                    sqlConn.Open();
                }

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlConn;
                
                foreach (SettingsProperty strText in Settings.Default.Properties)
                {
                    try
                    {
                        if (strText.Name.StartsWith("str"))
                        {
                            sqlCmd.CommandText = "INSERT INTO languages(StringID, Lang1) values('" + strText.Name + "', '" + strText.DefaultValue + "')";
                            sqlCmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception) { }
                }
                
            }
            catch (Exception) { }
        }
    }
}
