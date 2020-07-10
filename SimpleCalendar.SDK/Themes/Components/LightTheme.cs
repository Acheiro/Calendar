namespace SimpleCalendar.SDK.Themes.Components
{
    using System;
    using Abstractions;
    using Enumerations;

    public sealed class LightTheme : Theme
    {
        public override ThemeID ThemeId => ThemeID.Light;
        public override ConsoleColor TextColor => ConsoleColor.Black;
        public override ConsoleColor BackgroundColor => ConsoleColor.White;
    }
}
