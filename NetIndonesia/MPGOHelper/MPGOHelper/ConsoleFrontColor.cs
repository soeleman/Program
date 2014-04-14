namespace Dede.App.MPGOHelper
{
    using System;

    internal sealed class ConsoleFrontColor
        : IDisposable
    {
        public ConsoleFrontColor(
            ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
        }

        public void Dispose()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}