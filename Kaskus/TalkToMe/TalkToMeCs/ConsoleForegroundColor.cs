namespace Dede.App.TalkToMe
{
    using System;

    internal sealed class ConsoleForegroundColor 
        : IDisposable
    {
        public ConsoleForegroundColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public void Dispose()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}