namespace SimpleCalendar.SDK.Languages.Abstractions
{
    using System;
    using System.Linq;
    using Enumerations;

    public abstract class Language
    {
        protected abstract string[] NamesOfDays { get; }

        protected abstract string[] NamesOfMonths { get; }
        
        internal string GetNameOfDayByNumber(int dayOfTheWeek)
        {
            if (dayOfTheWeek > NamesOfDays.Length)
                throw new IndexOutOfRangeException($"Provided invalid day index: {dayOfTheWeek}");

            return NamesOfDays[dayOfTheWeek - 1];
        }

        internal string GetNameOfMonthByNumber(int monthInTheYear)
        {
            if (monthInTheYear > NamesOfMonths.Length)
                throw new IndexOutOfRangeException($"Provided invalid month index: {monthInTheYear}");

            return NamesOfMonths[monthInTheYear - 1];
        }

        internal string[] GetDaysShortcuts(int range) 
            => NamesOfDays.Select(x => x.Substring(0, range)).ToArray();

        internal string GetFormattedDate(DateTime date) 
            => $"{GetNameOfDayByNumber((int)date.DayOfWeek)}, {date.Day}/{GetNameOfMonthByNumber(date.Month)}/{date.Year}";
    }
}
