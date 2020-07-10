namespace SimpleCalendar.SDK.Languages.Components
{
    using System;
    using Abstractions;
    using Enumerations;

    public sealed class English : Language
    {
        public English() : base(LanguageID.English)
        {
            NamesOfDays = new[]
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };

            NamesOfMonths = new[]
            {
                "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
            };
        }

        public override void DisplayDate(DateTime date)
            => Console.WriteLine($"Today is {GetNameOfDayByNumber(date.Day)}, {date.Day} {GetNameOfMonthByNumber(date.Month)} {date.Year}");
    }
}