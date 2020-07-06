namespace Calendar.Themes.Components
{
    using System;
    using Abstractions;

    /// <summary>
    ///     Represents a premade dark theme for the console
    /// </summary>
    public sealed class DarkTheme : Theme
    {
        public override ConsoleColor TextColor => ConsoleColor.Yellow;
        public override ConsoleColor BackgroundColor => ConsoleColor.Black;
    }
}
