namespace Calendar.Themes.Components
{
    using System;
    using Abstractions;

    public sealed class LightTheme : Theme
    {
        public override ConsoleColor TextColor => ConsoleColor.Black;
        public override ConsoleColor BackgroundColor => ConsoleColor.White;
    }
}
