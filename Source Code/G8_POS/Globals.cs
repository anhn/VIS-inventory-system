using System;
using System.Collections.Generic;
using System.Text;
using G8_POS.Properties;

namespace G8_POS
{
	public class Globals
	{
		public static void SetConnectionString(string conn)
		{
            Settings.Default.dbConnection = conn;
            Settings.Default.VIS_POSConnectionString = conn;
			Settings.Default.Save();
		}

	}
}
