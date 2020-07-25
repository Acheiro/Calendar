namespace SimpleCalendar.SDK.Themes.Components
{
    using System;
    using Abstractions;

    public sealed class LightTheme : Theme
    {
        protected override ConsoleColor TextColor => ConsoleColor.Black;

        protected override ConsoleColor BackgroundColor => ConsoleColor.White;
    }
}
