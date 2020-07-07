namespace Calendar.Translations.Abstractions
{
    using Enumerations;

    /// <summary>
    ///     Provides implementation for various languages
    /// </summary>
    public abstract class Language
    {
        public LanguageID LanguageId { get; }
        public abstract string[] Days { get; }
        public abstract string[] Months { get; }
        public Language(LanguageID languageId) => LanguageId = languageId;
    }
}
