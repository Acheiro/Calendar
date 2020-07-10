namespace SimpleCalendar.SDK.Themes.Components
{
    using System;
    using Abstractions;
    using Enumerations;

    public sealed class DarkTheme : Theme
    {
        public override ThemeID ThemeId => ThemeID.Dark;
        public override ConsoleColor TextColor => ConsoleColor.Yellow;
        public override ConsoleColor BackgroundColor => ConsoleColor.Black;
    }
}
