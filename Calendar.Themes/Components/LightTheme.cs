namespace Calendar.Themes.Components
{
    using System;
    using Abstractions;
    using Enumerations;

    /// <summary>
    ///     Represents a premade light theme for the console
    /// </summary>
    public sealed class LightTheme : Theme
    {
        public override ThemeID ThemeId => ThemeID.Light;
        public override ConsoleColor TextColor => ConsoleColor.Black;
        public override ConsoleColor BackgroundColor => ConsoleColor.White;
    }
}
