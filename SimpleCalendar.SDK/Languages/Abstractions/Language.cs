namespace SimpleCalendar.SDK.Languages.Abstractions
{
    using System;
    using System.Linq;
    using Enumerations;

    public abstract class Language
    {
        public LanguageID LanguageId { get; }
        protected string[] NamesOfDays { get; set; }
        protected string[] NamesOfMonths { get; set; }
        
        public Language(LanguageID languageId) => LanguageId = languageId;

        public abstract void DisplayDate(DateTime date);

        public string[] GetDaysShortcuts(int range)
            => NamesOfMonths.Select(x => x.Substring(0, range)).ToArray();

        public string GetNameOfDayByNumber(int dayOfTheWeek)
        {
            if (dayOfTheWeek > NamesOfDays.Length)
                throw new IndexOutOfRangeException($"Provided invalid day index: {dayOfTheWeek}");

            return NamesOfDays[dayOfTheWeek - 1];
        }
        
        public string GetNameOfMonthByNumber(int monthInTheYear)
        {
            if (monthInTheYear > NamesOfMonths.Length)
                throw new IndexOutOfRangeException($"Provided invalid month index: {monthInTheYear}");

            return NamesOfMonths[monthInTheYear - 1];
        }
    }
}
