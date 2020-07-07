namespace Calendar.Output
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     Provides an implementation of console output manipulating via method chaining
    /// </summary>
    public sealed class ConsoleFormatter
    {
        public ConsoleFormatter BreakLine()
        {
            Console.WriteLine();
            return this;
        }

        public ConsoleFormatter PressToContinue()
        {
            Console.ReadKey();
            return this;
        }

        public ConsoleFormatter SetTitle(string title)
        {
            Console.Title = title;
            return this;
        }

        public ConsoleFormatter DisplayText(string text)
        {
            Console.WriteLine(text);
            return this;
        }

        public ConsoleFormatter DisplayText(IEnumerable<string> text)
        {
            foreach (var message in text)
                Console.WriteLine(message);

            return this;
        }

        public ConsoleFormatter DisplayTextInTheMiddle(string text)
        {
            Console.WriteLine($"{{0, {Console.WindowWidth / 2 + text.Length / 2}}}", text);
            return this;
        }

        public ConsoleFormatter DisplayTextInTheMiddle(IEnumerable<string> text)
        {
            foreach (var message in text)
                Console.WriteLine($"{{0, {Console.WindowWidth / 2 + message.Length / 2}}}", message);

            return this;
        }
    }
}
