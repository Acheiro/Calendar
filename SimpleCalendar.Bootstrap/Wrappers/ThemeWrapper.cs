namespace SimpleCalendar.Bootstrap.Wrappers
{
    using System.Collections.Generic;
    using SDK.Enumerations;
    using SDK.Themes.Abstractions;
    using SDK.Themes.Components;

    internal static class ThemeWrapper
    {
        internal static void Initialize(ThemeID themeId) => Themes[themeId].SetTheme();

        private static readonly Dictionary<ThemeID, Theme> Themes = new Dictionary<ThemeID, Theme>
        {
            [ThemeID.Dark] = new DarkTheme(),
            [ThemeID.Light] = new LightTheme()
        };
    }
}
