#region References
using System;
#endregion

#region Namespace
namespace Cart.Common
{
    public static class DateFormatHandler
    {
        /// <summary>
        /// Dates the time format.
        /// </summary>
        /// <param name="datetime">The datetime.</param>
        /// <returns></returns>
        public static DateTime DateTimeFormat(this DateTime datetime)
        {
            string format = "yyyy-MM-dd HH:mm:ss";

            DateTime dateVal = DateTime.Parse(datetime.ToString(format));

            return dateVal;
        }

        /// <summary>
        /// Gets the timestamp.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static String GetTimestamp(this DateTime value)
        {
            return value.ToString("yyyyMMddHHmmss");
        }

        /// <summary>
        /// Converts to local date time.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public static DateTime? ConvertToLocalDateTime(DateTime? date)
        {
            if (date != null)
            {
                var datePassed = (DateTime)date;
                var SriLankaTime = TimeZoneInfo.FindSystemTimeZoneById("Sri Lanka Standard Time");
                var SriLankaUTCTime = TimeZoneInfo.ConvertTimeFromUtc(datePassed, SriLankaTime);

                return SriLankaUTCTime;
            }
            return null;
        }

        /// <summary>
        /// Converts to local date time manually.
        /// </summary>
        /// <returns></returns>
        public static DateTime ConvertToLocalDateTimeManually()
        {
            DateTime dueDate = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Sri Lanka Standard Time"));
            DateTime duedateInUtc = TimeZoneInfo.ConvertTimeToUtc(dueDate.Date, TimeZoneInfo.FindSystemTimeZoneById("Sri Lanka Standard Time"));
            return duedateInUtc;
        }

        /// <summary>
        /// Converts the date time to ddmmyyyy.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public static string ConvertDateTimeToDDMMYYYY(DateTime? date)
        {
            return !date.HasValue ? "" : date.Value.ToString("dd/MM/yyyy");
        }

        /// <summary>
        /// Converts the time to HHMMTT.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <returns></returns>
        public static string ConvertTimeToHHMMTT(DateTime? time)
        {
            return !time.HasValue ? "" : time.Value.ToString("hh:mm tt");
        }
    }
}
#endregion