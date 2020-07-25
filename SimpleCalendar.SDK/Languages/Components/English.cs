namespace SimpleCalendar.SDK.Languages.Components
{
    using Abstractions;

    public sealed class English : Language
    {
        protected override string[] NamesOfDays => new[]
        {
            "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
        };

        protected override string[] NamesOfMonths => new[]
        {
            "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
        };
    }
}