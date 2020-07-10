namespace SimpleCalendar.SDK.Calendars.Abstractions
{
    using Languages.Abstractions;

    public abstract class Calendar
    {
        protected Language PreferredLanguage { get; }

        public Calendar(Language preferredLanguage) => PreferredLanguage = preferredLanguage;

        public abstract Calendar DisplayDate();

        public abstract Calendar DisplayCalendar(int month, int year);
    }
}
