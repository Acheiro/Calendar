namespace Calendar.Translations.Components
{
    using Abstractions;
    using Enumerations;

    /// <summary>
    ///     Represents set of names of days and months in <see cref="English"/>
    /// </summary>
    public sealed class English : Language
    {
        private string[] NamesOfDays { get; }
        private string[] NamesOfMonths { get; }

        public English() : base(LanguageID.English) 
        {
            NamesOfDays = new[]
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };

            NamesOfMonths = new[]
            {
                "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
            };
        }

        public override string[] Days => NamesOfDays;
        public override string[] Months => NamesOfMonths;
    }
}
