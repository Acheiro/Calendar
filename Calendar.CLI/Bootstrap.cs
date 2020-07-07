namespace Calendar.CLI
{
    using System;
    using Core;
    using Extensions;
    using Enumerations;

    internal static class Bootstrap
    {
        private static readonly ConsoleUtility Formatter = new ConsoleUtility();

        static Bootstrap() => Formatter.SetTitle("Calendar By Mariusz Mocarz");

        private static void Main()
        {
            var themeId = Formatter
                .DisplayTextInColumn($"Please choose a theme: {string.Join(" / ", typeof(ThemeID).GetEnumNames())}")
                .RetriveInput(out var unparsedThemeId)
                .ParseInput<ThemeID>(ref unparsedThemeId, Enum.TryParse);

            var languageId = Formatter
                .DisplayTextInColumn($"\nPlease choose a language: {string.Join(" / ", typeof(LanguageID).GetEnumNames())}")
                .RetriveInput(out var unparsedLanguageId)
                .ParseInput<LanguageID>(ref unparsedLanguageId, Enum.TryParse);

            var calendar = new SimpleCalendar(themeId, languageId, Formatter)
                .SetupTheme()
                .DisplayCurrentDate()
                .DisplayCalendar();
        }
    }
}
