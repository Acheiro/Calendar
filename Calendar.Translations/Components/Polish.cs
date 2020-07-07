namespace Calendar.Translations.Components
{
    using Abstractions;
    using Enumerations;

    /// <summary>
    ///     Represents set of names of days and months in <see cref="Polish"/>
    /// </summary>
    public sealed class Polish : Language
    {
        private string[] NamesOfDays { get; }
        private string[] NamesOfMonths { get; }

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

        public override string[] Days => NamesOfDays;
        public override string[] Months => NamesOfMonths;
    }
}
