using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    public class Constants
    {
        public class Reorder
        {
            static public string CheckFrequencyConfigName = "CHK_FREQ";
            static public string DaysBeforeExpireConfigName = "EXP_TIME";
            static public string DaysKeepAlertConfigName = "ART_LIVE";
            static public string LastCheck = "LAST_CHK";
        }

        public class SysInfos
        {
            static public string MailSender = "MailSender";
            static public string MailFrom = "MailFrom";
            static public string MailTo = "MailTo";
            static public string MailHost = "MailHost";
        }

        public class Message
        {
            static public string MessageTitle = "Message";
         
            static public string Save_Prompt = "Do you want to save the data?";
            static public string Save_Success = "The data have been saved successfully.";

            static public string PeriodClosing_PreviewPeriodNotClosed = "Can not close this period because this period has been closed, or the previous period has not been closed.";
            static public string PeriodClosing_Success = "Period Closing has been done successfully.";

            static public string ProductExpiredError = "The Product Expired Alert process can not be completed.";
            static public string ReorderError = "The Reorder Alert process can not be completed.";

            static public string FindProducts_SelectRow = "Please select one row before finding product.";

            static public string Export_Success = "Export has been done successfully.";
            static public string Import_Success = "Import has been done successfully.";
            static public string Import_DataExistStop = "Import has been stopped because there is data that has been existed.";
            static public string PurgeData_NoOneSelected = "Please select at least one of Data to purge.";
            static public string PurgeData_ToDateMustGreaterThanFromDate = "The To date must be greater than the From date.";
            static public string PurgeData_Success = "Purge data has been done successfully.";
            static public string Sys_ConnectSuccess = "The connection was successfully.";
        }

        public class PeriodClosing
        {
            static public string OpenStatus = "Open";
            static public string CloseStatus = "Close";

            static public string DailyType = "Daily";
            static public string WeeklyType = "Weekly";
            static public string MonthlyType = "Monthly";
            static public string QuarterlyType = "Quarterly";
            static public string SemiAnnuallyType = "Semi-Annually";
            static public string AnnuallyType = "Annually";
        }
    }
}
