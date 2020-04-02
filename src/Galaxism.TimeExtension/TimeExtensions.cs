using System;

namespace Galaxism.TimeExtension
{
    public static class TimeExtensions
    {
        /// <summary>
        /// Returns a new System.DateTime that adds the specified number of days to the value of this instance. This method is in ticks precision instead of millisecond precision.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="days">A number of whole and fractional days. The value parameter can be negative or positive.</param>
        /// <returns>An object whose value is the sum of the date and time represeted by this instance and the number of days represented by value</returns>
        public static DateTime AddPreciseDays(this DateTime dateTime, double days)
        {
            return dateTime.AddTicks((long)(days * TimeSpan.TicksPerDay));
        }

        /// <summary>
        /// Returns a new System.DateTime that adds the specified number of hours to the value of this instance. This method is in ticks precision instead of millisecond precision.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="hours">A number of whole and fractional hours. The value parameter can be negative or positive.</param>
        /// <returns></returns>
        public static DateTime AddPreciseHours(this DateTime dateTime, double hours)
        {
            return dateTime.AddTicks((long)(hours * TimeSpan.TicksPerHour));
        }

        /// <summary>
        /// Returns a new System.DateTime that adds the specified number of minutes to the value of this instance. This method is in ticks precision instead of millisecond precision.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="minutes">A number of whole and fractional minutes. The value parameter can be negative or positive.</param>
        /// <returns></returns>
        public static DateTime AddPreciseMinutes(this DateTime dateTime, double minutes)
        {
            return dateTime.AddTicks((long)(minutes * TimeSpan.TicksPerMinute));
        }

        /// <summary>
        /// Returns a new System.DateTime that adds the specified number of seconds to the value of this instance. This method is in ticks precision instead of millisecond precision.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="seconds">A number of whole and fractional seconds. The value parameter can be negative or positive.</param>
        /// <returns></returns>
        public static DateTime AddPreciseSeconds(this DateTime dateTime, double seconds)
        {
            return dateTime.AddTicks((long)(seconds * TimeSpan.TicksPerSecond));
        }

        /// <summary>
        /// Returns a new System.DateTime that adds the specified number of milliseconds to the value of this instance. This method is in ticks precision instead of millisecond precision.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="milliseconds">>A number of whole and fractional milliseconds. The value parameter can be negative or positive.</param>
        /// <returns></returns>
        public static DateTime AddPreciseMilliseconds(this DateTime dateTime, double milliseconds)
        {
            return dateTime.AddTicks((long)(milliseconds * TimeSpan.TicksPerMillisecond));
        }

        /// <summary>
        /// Returns a new System.DateTime that adds the specified number of milliseconds to the value of this instance. This method is in ticks precision instead of millisecond precision.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="microseconds">A number of whole and fractional microseconds. The value parameter can be negative or positive.</param>
        /// <returns></returns>
        public static DateTime AddMicroseconds(this DateTime dateTime, double microseconds)
        {
            return dateTime.AddTicks((long)(microseconds * 10));
        }

        public static int GetMicroseconds(this DateTime dateTime)
        {
            return (int)(dateTime.Ticks % 10000) / 10;
        }

        public static int Microseconds(this TimeSpan span)
        {
            return (int)(span.Ticks % 10000) / 10;
        }

        public static double TotalMicroseconds(this TimeSpan span)
        {
            return span.Ticks / 10.0;
        }
    }
}
