using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Inventory.Properties;
namespace Inventory
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
            //LangSetting.RestoreLanguage();
            

            Login login = new Login();
            if (login.ShowDialog() != DialogResult.OK)
            {                
                Application.Exit();
                return;
            }
            /*
            do
            {
                Globals.canExit = true;
                LangSetting.LoadLanguage(Settings.Default.cfgLanguage);
                Application.Run(new MainForm());                
                
            } while (!Globals.canExit);
             */
            //Application.Run(new Search());
            Application.Run(new MainForm());
        }
    }
}