namespace SimpleCalendar.SDK.Themes.Components
{
    using System;
    using Abstractions;

    public sealed class DarkTheme : Theme
    {
        protected override ConsoleColor TextColor => ConsoleColor.Yellow;

        protected override ConsoleColor BackgroundColor => ConsoleColor.Black;
    }
}
