namespace SimpleCalendar.Bootstrap.Wrappers
{
    using System;
    using System.Collections.Generic;
    using SDK.Calendars.Abstractions;
    using SDK.Calendars.Components;
    using SDK.Enumerations;
    using SDK.Extensions;
    using SDK.Languages.Abstractions;
    using SDK.Languages.Components;

    internal sealed class CalendarWrapper
    {
        private Calendar Calendar { get; }

        private Language Language { get; }

        private ConsoleChainer Chainer { get; }

        private int _year = DateTime.Now.Year;

        private int _month = DateTime.Now.Month;

        internal CalendarWrapper(CalendarID calendarId, LanguageID languageId, ConsoleChainer chainer)
        {
            var languages = new Dictionary<LanguageID, Language>
            {
                [LanguageID.Polish] = new Polish(),
                [LanguageID.English] = new English()
            };

            var calendars = new Dictionary<CalendarID, Calendar>
            {
                [CalendarID.Gregorian] = new GregorianCalendar()
            };

            Chainer = chainer;
            Calendar = calendars[calendarId];
            Language = languages[languageId];
        }

        private void SetupCalendar() => Calendar.AssignLanguage(Language);

        private void DisplayCalendar()
        {
            Calendar.DisplayDate();
            Calendar.DisplayCalendar(_month, _year, Chainer);
        }

        private void ChangeDate()
        {
            _month = Chainer
                .BreakLine()
                .RetrieveInput("\nPlease enter new month: ", out var unparsedMonth)
                .ParseInputAsInteger(ref unparsedMonth);

            _year = Chainer
                .BreakLine()
                .RetrieveInput("\nPlease enter new year: ", out var unparsedYear)
                .ParseInputAsInteger(ref unparsedYear);

            Chainer.BreakLine().PressToContinue().Clear();
        }

        internal void Run()
        {
            Chainer.Clear();
            SetupCalendar();

            while (!Environment.HasShutdownStarted)
            {
                DisplayCalendar();
                ChangeDate();
                Chainer.Clear();
            }
        }
    }
}
