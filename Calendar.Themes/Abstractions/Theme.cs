namespace Calendar.Themes.Abstractions
{
    using System;

    /// <summary>
    ///     Provides implementation for various console themes
    /// </summary>
    public abstract class Theme
    {
        public abstract ConsoleColor TextColor { get; }
        public abstract ConsoleColor BackgroundColor { get; }
    }
}
