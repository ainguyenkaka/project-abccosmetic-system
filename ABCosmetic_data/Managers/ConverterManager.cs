using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCosmetic_data.Managers
{
    public class ConverterManager
    {

        public static int GetWeek(DateTime date)
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            Calendar ca = dfi.Calendar;
            var week = ca.GetWeekOfYear(date, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
            return week;
        }
    }
}
