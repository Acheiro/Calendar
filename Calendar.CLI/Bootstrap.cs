namespace Calendar.CLI
{
    using System.Collections.Generic;
    using Enumerations;
    using Extensions;
    using Themes.Components;
    using Themes.Abstractions;
    using Translations.Abstractions;
    using Translations.Components;
    using System;

    internal static class Bootstrap
    {
        private static readonly ConsoleUtility Formatter = new ConsoleUtility();

        private static void Main()
        {
            var themes = new List<Theme>
            {
                new DarkTheme(), new LightTheme()
            };

            var languages = new List<Language>
            {
                new Polish(), new English()
            };

            var themeId = Formatter
                .DisplayText($"Please choose a theme: {string.Join(" / ", typeof(ThemeID).GetEnumNames())}")
                .RetriveInput(out var unparsedThemeId)
                .ParseInput<ThemeID>(ref unparsedThemeId, Enum.TryParse);

            var languageId = Formatter
                .DisplayText($"\nPlease choose a language: {string.Join(" / ", typeof(LanguageID).GetEnumNames())}")
                .RetriveInput(out var unparsedLanguageId)
                .ParseInput<LanguageID>(ref unparsedLanguageId, Enum.TryParse);


        }
    }
}
