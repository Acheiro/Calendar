namespace Calendar.Themes.Abstractions
{
    using System;
    using Enumerations;

    /// <summary>
    ///     Provides implementation for various console themes
    /// </summary>
    public abstract class Theme
    {
        public abstract ThemeID ThemeId { get; }
        public abstract ConsoleColor TextColor { get; }
        public abstract ConsoleColor BackgroundColor { get; }
        
        public void SetTheme()
        {
            Console.ForegroundColor = TextColor;
            Console.BackgroundColor = BackgroundColor;
        }
    }
}
