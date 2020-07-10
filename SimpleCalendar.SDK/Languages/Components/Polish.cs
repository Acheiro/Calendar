namespace SimpleCalendar.SDK.Languages.Components
{
    using System;
    using Abstractions;
    using Enumerations;

    public sealed class Polish : Language
    {
        public Polish() : base(LanguageID.Polish)
        {
            NamesOfDays = new[]
            {
                "Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela"
            };

            NamesOfMonths = new[]
            {
                "Styczeń", "Luty", "Marzec", "Kwiecień", "Maj", "Czerwiec", "Lipiec", "Sierpień", "Wrzesień", "Październik", "Listopad", "Grudzień"
            };
        }

        public override void DisplayDate(DateTime date)
            => Console.WriteLine($"Dzisiaj jest {GetNameOfDayByNumber(date.Day)}, {date.Day} {GetNameOfMonthByNumber(date.Month)} {date.Year}");
    }
}
