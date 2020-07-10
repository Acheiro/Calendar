namespace SimpleCalendar.SDK.Extensions
{
    using System;
    using System.Collections.Generic;

    public sealed class ConsoleChainer
    {
        public ConsoleChainer Clear()
        {
            Console.Clear();
            return this;
        }

        public ConsoleChainer BreakLine()
        {
            Console.WriteLine();
            return this;
        }

        public ConsoleChainer PressToContinue()
        {
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
            return this;
        }

        public ConsoleChainer SetTitle(string title)
        {
            Console.Title = title;
            return this;
        }

        public ConsoleChainer RetrieveInput(string text, out string input)
        {
            Console.Write(text);

            input = Console.ReadLine();

            return this;
        }

        public ConsoleChainer DisplayTextInRow(string text, string format = null)
        {
            Console.Write(format ?? $"{{0}}", text);
            return this;
        }

        public ConsoleChainer DisplayTextInColumn(string text, string format = null)
        {
            Console.WriteLine(format ?? $"{{0}}", text);
            return this;
        }

        public ConsoleChainer DisplayTextInRow(IEnumerable<string> text, string format = null)
        {
            foreach (var message in text)
                Console.Write(format ?? $"{{0}}", message);

            return this;
        }

        public ConsoleChainer DisplayTextInColumn(IEnumerable<string> text, string format = null)
        {
            foreach (var message in text)
                Console.WriteLine(format ?? $"{{0}}", message);

            return this;
        }

        public T ParseInputAsEnum<T>(ref string text, Validator<T> validator) where T : struct
        {
            if (validator.Invoke(text, true, out var value))
                return value;

            DisplayTextInColumn($"\nProvided parameter did not match any of the values. Will proceed with default value.");
            PressToContinue();
            return default;
        }

        public delegate bool Validator<T>(string? value, bool ignoreCase, out T enumValue);
    }
}
