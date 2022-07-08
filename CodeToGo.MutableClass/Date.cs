using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeToGo.MutableClass
{
    public class Date
    {
        private static readonly int[] DaysOfMonthsNonLeap =
          { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private static readonly int[] DaysOfMonthLeap =
        { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public int Year { get; private set; }
        public int Month { get; private set; }
        public int Day { get; private set; }

        public Date(int year, int month, int day)
        {

            if (year < 1 && year > 9999)
                throw new ArgumentOutOfRangeException(nameof(year));

            if (month < 1 && month > 12)
                throw new ArgumentOutOfRangeException(nameof(month));


            int[] days = IsLeapYear(year) ? DaysOfMonthLeap : DaysOfMonthsNonLeap;

            if (day < 1 && day > days[month])
                throw new ArgumentOutOfRangeException(nameof(day));

            Year = year;
            Month = month;
            Day = day;

        }


        public void AddDays(int value)
        {
            // Cheating using DateTime
            var date = new DateTime(Year, Month, Day).AddDays(value);

            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
        }

        public void AddWeeks(int value)
        {
            AddDays(value * 7);
        }

        public void AddMonths(int value)
        {
            // Cheating using DateTime
            var date = new DateTime(Year, Month, Day).AddMonths(value);

            Year = date.Year;
            Month = date.Month;
            Day = date.Day; 
        }
        public void AddYears(int value)
        {
            // Cheating using DateTime
            var date = new DateTime(Year, Month, Day).AddYears(value);

            Year = date.Year;
            Month = date.Month;
            Day = date.Day; 
        }

        public static bool IsLeapYear(int year)
        {
            if (year < 1 || year > 9999)
            {
                throw new ArgumentOutOfRangeException(nameof(year));
            }
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }


        public override string ToString()
        {
            return $"{Year}/{Month}/{Day}";
        }
    }
}
