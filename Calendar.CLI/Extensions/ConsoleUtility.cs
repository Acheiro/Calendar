namespace Calendar.CLI.Extensions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     Provides an implementation of console output manipulating via method chaining
    /// </summary>
    public sealed class ConsoleUtility
    {
        public ConsoleUtility Clear()
        {
            Console.Clear();
            return this;
        }

        public ConsoleUtility BreakLine()
        {
            Console.WriteLine();
            return this;
        }

        public ConsoleUtility PressToContinue()
        {
            Console.ReadKey();
            return this;
        }

        public ConsoleUtility SetTitle(string title)
        {
            Console.Title = title;
            return this;
        }

        public ConsoleUtility RetriveInput(out string input)
        {
            Console.Write("Enter value: ");

            input = Console.ReadLine();

            return this;
        }

        public ConsoleUtility DisplayTextInRow(string text, string format = null)
        {
            Console.Write(format ?? $"{{0}}", text);
            return this;
        }

        public ConsoleUtility DisplayTextInColumn(string text, string format = null)
        {
            Console.WriteLine(format ?? $"{{0}}", text);
            return this;
        }

        public ConsoleUtility DisplayTextInRow(IEnumerable<string> text, string format = null)
        {
            foreach (var message in text)
                Console.Write(format ?? $"{{0}}", message);

            return this;
        }

        public ConsoleUtility DisplayTextInColumn(IEnumerable<string> text, string format = null)
        {
            foreach (var message in text)
                Console.WriteLine(format ?? $"{{0}}", message);

            return this;
        }

        public T ParseInput<T>(ref string text, Validator<T> validator)
        {
            if (validator.Invoke(text, true, out var value))
                return value;

            throw new ArgumentException($"Provided parameter did not match any of the enum values | {string.Join(", ", typeof(T).GetEnumNames())}");
        }

        public delegate bool Validator<T>(string? value, bool ignoreCase, out T enumValue);
    }
}
