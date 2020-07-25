namespace SimpleCalendar.Bootstrap
{
    using SDK.Enumerations;
    using SDK.Extensions;
    using Wrappers;

    public static class Bootstrap
    {
        private static readonly ConsoleChainer Chainer = new ConsoleChainer();

        private static void Main()
        {            
            var themeId = Chainer
                .DisplayTextInColumn($"Available themes: {string.Join(" / ", typeof(ThemeID).GetEnumNames())}")
                .RetrieveInput("Please choose theme: ", out var unparsedThemeId)
                .ParseInputAsEnum<ThemeID>(ref unparsedThemeId);

            var languageId = Chainer
                .DisplayTextInColumn($"\nAvailable languages: {string.Join(" / ", typeof(LanguageID).GetEnumNames())}")
                .RetrieveInput("Please choose language: ", out var unparsedLanguageId)
                .ParseInputAsEnum<LanguageID>(ref unparsedLanguageId);

            var calendarId = Chainer
                .DisplayTextInColumn($"\nAvailable caledars: {string.Join(" / ", typeof(CalendarID).GetEnumNames())}")
                .RetrieveInput("Please choose calendar: ", out var unparsedCalendarId)
                .ParseInputAsEnum<CalendarID>(ref unparsedCalendarId);

            ThemeWrapper.Initialize(themeId);

            var calendarWrapper = new CalendarWrapper(calendarId, languageId, Chainer);

            calendarWrapper.Run();
        }
    }
}