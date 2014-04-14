namespace Dede.App.MPGOHelper
{
    using System;

    internal sealed class MPGOProcess
        : ConsoleProcess
    {
        public MPGOProcess(
            String arguments)
            : base(@"mpgo.exe", arguments)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            this.Start();
        }
    }
}