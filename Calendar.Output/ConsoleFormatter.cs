namespace Calendar.Output
{
    using System;
    using System.Collections.Generic;

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

        public ConsoleFormatter DisplayMessage(string message)
        {
            Console.WriteLine(message);
            return this;
        }

        public ConsoleFormatter DisplayMessages(IEnumerable<string> messages)
        {
            foreach (var message in messages)
                Console.WriteLine(message);

            return this;
        }

        public ConsoleFormatter DisplayMessageInTheMiddle(string message)
        {
            Console.WriteLine($"{{0, {Console.WindowWidth / 2 + message.Length / 2}}}", message);
            return this;
        }

        public ConsoleFormatter DisplayMessagesInTheMiddle(IEnumerable<string> messages)
        {
            foreach (var message in messages)
                Console.WriteLine($"{{0, {Console.WindowWidth / 2 + message.Length / 2}}}", message);

            return this;
        }
    }
}
