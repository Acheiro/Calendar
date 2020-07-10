namespace SimpleCalendar.SDK.Calendars.Components
{
    using System;
    using Abstractions;
    using Languages.Abstractions;

    public sealed class GregorianCalendar : Calendar
    {
        public GregorianCalendar(Language preferredLanguage) : base(preferredLanguage) { }

        public override Calendar DisplayDate()
        {
            PreferredLanguage.DisplayDate(DateTime.Now);
            return this;
        }

        public override Calendar DisplayCalendar(int month, int year)
        {
            // Get amount of the days in the month
            var numberOfDays = DateTime.DaysInMonth(month, year);

            // Get the index of the first day in the month
            var firstDayOfTheMonth = (int) new DateTime(year, month, 1).DayOfWeek;

            return this;
        }
    }
}
