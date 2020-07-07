namespace Calendar.Themes.Components
{
    using System;
    using Abstractions;
    using Enumerations;

    /// <summary>
    ///     Represents a premade dark theme for the console
    /// </summary>
    public sealed class DarkTheme : Theme
    {
        public override ThemeID ThemeId => ThemeID.Dark;
        public override ConsoleColor TextColor => ConsoleColor.Yellow;
        public override ConsoleColor BackgroundColor => ConsoleColor.Black;
    }
}
