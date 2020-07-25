namespace SimpleCalendar.SDK.Calendars.Components
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Abstractions;
    using Extensions;
    using Languages.Abstractions;

    public sealed class GregorianCalendar : Calendar
    {
        private string[] Layout { get; }

        public GregorianCalendar() => Layout = new string[42];

        public override void DisplayDate()
            => Console.WriteLine($"{Language.GetFormattedDate(DateTime.Now)}\n");

        private void FillLayout(int month, int year)
        {
            // The day index
            var dayIndex = 1;

            // The array index
            var layoutIndex = 0;

            // Gets the amount of the days in the month
            var numberOfDays = DateTime.DaysInMonth(year, month);

            // Gets the index of the first day in the month
            var firstDayOfTheMonth = (int) new DateTime(year, month, 1).DayOfWeek;

            // Repeat until all of the indexes are processed
            while (layoutIndex++ < Layout.Length)
                // Fill the array only if we passed the first day in the month and the day has not exceeded the total amount of days
                if (layoutIndex >= firstDayOfTheMonth && dayIndex <= numberOfDays)
                    // Filling the index
                    Layout[layoutIndex - 1] = $"{dayIndex++}";
        }

        public override void DisplayCalendar(int month, int year, ConsoleChainer chainer)
        {
            // Fills the calendar layout
            FillLayout(month, year);

            // Merges days shortcuts with the calendar layout
            var calendarLayout = Language.GetDaysShortcuts(3).Concat(Layout).ToList();

            // Print the calendar layout in 7 sequences
            for (var i = 0; i < 7; i++)
                // In first sequence take first the days shortcuts, in the rest skip all past items and take next 7
                chainer.DisplayTextInRow(i == 0 ? calendarLayout.Take(7).Append("\n") : calendarLayout.Skip(7 * i).Take(7).Append("\n"), $"{{0, 14}}");

            // Clears the layout data
            for (var i = 0; i < Layout.Length; i++)
                Layout[i] = null;
        }
    }
}