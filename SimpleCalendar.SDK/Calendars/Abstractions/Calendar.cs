namespace SimpleCalendar.SDK.Calendars.Abstractions
{
    using Extensions;
    using Languages.Abstractions;

    public abstract class Calendar
    {
        protected Language Language { get; private set; }

        public abstract void DisplayDate();
        
        public void AssignLanguage(Language language) => Language = language;
        
        public abstract void DisplayCalendar(int month, int year, ConsoleChainer chainer);
    }
}