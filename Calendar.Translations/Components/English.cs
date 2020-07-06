namespace Calendar.Translations.Components
{
    using Abstractions;
    using Enumerations;

    /// <summary>
    ///     Represents set of names of days and months in <see cref="English"/>
    /// </summary>
    public sealed class English : Language
    {
        public override Languages Title => Languages.English;

        public override string[] Days => new[]
        {
            "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
        };

        public override string[] Months => new[]
        {
            "January", "February", "March", "April", "June", "July", "August", "September", "October", "November", "December"
        };
    }
}
