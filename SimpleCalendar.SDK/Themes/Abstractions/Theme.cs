namespace SimpleCalendar.SDK.Themes.Abstractions
{
    using System;

    public abstract class Theme
    {
        protected abstract ConsoleColor TextColor { get; }
        
        protected abstract ConsoleColor BackgroundColor { get; }

        private void SetTextColor() => Console.ForegroundColor = TextColor;
        
        private void SetBackgroundColor() => Console.BackgroundColor = BackgroundColor;

        public void SetTheme()
        {
            SetTextColor();
            SetBackgroundColor();
        }
    }
}
