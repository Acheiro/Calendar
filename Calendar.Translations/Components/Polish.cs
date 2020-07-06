namespace Calendar.Translations.Components
{
    using Abstractions;
    using Enumerations;

    /// <summary>
    ///     Represents set of names of days and months in <see cref="Polish"/>
    /// </summary>
    public sealed class Polish : Language
    {
        public override Languages Title => Languages.Polish;

        public override string[] Days => new[] 
        { 
            "Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela" 
        };

        public override string[] Months => new[] 
        {
            "Styczeń", "Luty", "Marzec", "Kwiecień", "Maj", "Czerwiec", "Lipiec", "Sierpień", "Wrzesień", "Październik", "Listopad", "Grudzień"
        };
    }
}
