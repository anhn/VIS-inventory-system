using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Utils
{
    class DateUtils
    {
        /// <summary>
        /// Convert a string into date in the current timezone
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTime ParseDate(String str)
        {
            DateTime dt = DateTime.Parse(str);
            DateTime.SpecifyKind(dt, DateTimeKind.Local);
            return dt;
        }

        public static DateTime GetPeriodEndDate(DateTime startDate, string periodType)
        {
            DateTime dtmEndDate = DateTime.MinValue;

            if (Constants.PeriodClosing.AnnuallyType.Equals(periodType, StringComparison.CurrentCultureIgnoreCase))
            {
                dtmEndDate = startDate.AddYears(1).AddSeconds(-1);
            }
            else if (Constants.PeriodClosing.SemiAnnuallyType.Equals(periodType, StringComparison.CurrentCultureIgnoreCase))
            {
                dtmEndDate = startDate.AddMonths(6).AddSeconds(-1);
            }
            else if (Constants.PeriodClosing.QuarterlyType.Equals(periodType, StringComparison.CurrentCultureIgnoreCase))
            {
                dtmEndDate = startDate.AddMonths(3).AddSeconds(-1);
            }
            else if (Constants.PeriodClosing.MonthlyType.Equals(periodType, StringComparison.CurrentCultureIgnoreCase))
            {
                dtmEndDate = startDate.AddMonths(1).AddSeconds(-1);
            }
            else if (Constants.PeriodClosing.WeeklyType.Equals(periodType, StringComparison.CurrentCultureIgnoreCase))
            {
                dtmEndDate = startDate.AddDays(7).AddSeconds(-1);
            }
            else if (Constants.PeriodClosing.DailyType.Equals(periodType, StringComparison.CurrentCultureIgnoreCase))
            {
                dtmEndDate = startDate.AddDays(1).AddSeconds(-1);
            }

            return dtmEndDate;
        }
    }
}
