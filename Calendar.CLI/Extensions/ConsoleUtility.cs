namespace Calendar.CLI.Extensions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     Provides an implementation of console output manipulating via method chaining
    /// </summary>
    internal sealed class ConsoleUtility
    {
        internal ConsoleUtility BreakLine()
        {
            Console.WriteLine();
            return this;
        }

        internal ConsoleUtility PressToContinue()
        {
            Console.ReadKey();
            return this;
        }

        internal ConsoleUtility SetTitle(string title)
        {
            Console.Title = title;
            return this;
        }

        internal ConsoleUtility DisplayText(string text)
        {
            Console.WriteLine(text);
            return this;
        }

        internal ConsoleUtility DisplayText(IEnumerable<string> text)
        {
            foreach (var message in text)
                Console.WriteLine(message);

            return this;
        }

        internal ConsoleUtility DisplayTextInTheMiddle(string text)
        {
            Console.WriteLine($"{{0, {Console.WindowWidth / 2 + text.Length / 2}}}", text);
            return this;
        }

        internal ConsoleUtility DisplayTextInTheMiddle(IEnumerable<string> text)
        {
            foreach (var message in text)
                Console.WriteLine($"{{0, {Console.WindowWidth / 2 + message.Length / 2}}}", message);

            return this;
        }

        internal ConsoleUtility RetriveInput(out string input)
        {
            Console.Write("Enter value: ");
            
            input = Console.ReadLine();
            
            return this;
        }

        internal T ParseInput<T>(ref string text, Validator<T> validator)
        {
            if (validator.Invoke(text, true, out var value))
                return value;

            throw new ArgumentException($"Provided parameter did not match any of the enum values | {string.Join(", ", typeof(T).GetEnumNames())}");
        }

        internal delegate bool Validator<T>(string? value, bool ignoreCase, out T enumValue);
    }
}
