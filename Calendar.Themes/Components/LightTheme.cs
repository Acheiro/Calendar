namespace Calendar.Themes.Components
{
    using System;
    using Abstractions;

    /// <summary>
    ///     Represents a premade light theme for the console
    /// </summary>
    public sealed class LightTheme : Theme
    {
        public override ConsoleColor TextColor => ConsoleColor.Black;
        public override ConsoleColor BackgroundColor => ConsoleColor.White;
    }
}
