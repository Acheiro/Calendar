namespace SimpleCalendar.SDK.Languages.Components
{
    using Abstractions;

    public sealed class Polish : Language
    {
        protected override string[] NamesOfDays => new[]
        {
            "Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela"
        };

        protected override string[] NamesOfMonths => new[]
        {
            "Styczeń", "Luty", "Marzec", "Kwiecień", "Maj", "Czerwiec", "Lipiec", "Sierpień", "Wrzesień", "Październik", "Listopad", "Grudzień"
        };
    }
}
