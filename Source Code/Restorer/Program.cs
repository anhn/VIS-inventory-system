using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Restorer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //frmMain frm = new frmMain();
            //frm.Show();
            //frm.Update();
            StreamReader file = new StreamReader(Application.StartupPath + "\\temp.txt");
            string sql = "use [master]; restore database [" + file.ReadLine() + "] from disk = '" + file.ReadLine() + "'";

            SqlConnection con = new SqlConnection(file.ReadLine());
            file.Close();
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("Error in trying to connect to the database");

                return;
            }
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Restoring database successed");
            }
            catch
            {
                MessageBox.Show("Error in restoring database. Please close all connection before restore.");
            }
            System.Diagnostics.Process.Start(Application.StartupPath + "\\POS.ViewVB.exe");
            //Application.Exit();
        }
    }
}