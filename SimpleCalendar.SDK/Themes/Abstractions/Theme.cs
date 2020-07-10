namespace SimpleCalendar.SDK.Themes.Abstractions
{
    using System;
    using Enumerations;

    public abstract class Theme
    {
        public abstract ThemeID ThemeId { get; }
        public abstract ConsoleColor TextColor { get; }
        public abstract ConsoleColor BackgroundColor { get; }

        public void SetTheme()
        {
            SetTextColor();
            SetBackgroundColor();
        }

        private void SetTextColor() => Console.ForegroundColor = TextColor;
        private void SetBackgroundColor() => Console.BackgroundColor = BackgroundColor;
    }
}
