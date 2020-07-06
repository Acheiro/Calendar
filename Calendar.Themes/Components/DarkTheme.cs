namespace Calendar.Themes.Components
{
    using System;
    using Abstractions;

    public sealed class DarkTheme : Theme
    {
        public override ConsoleColor TextColor => ConsoleColor.Yellow;
        public override ConsoleColor BackgroundColor => ConsoleColor.Black;
    }
}
