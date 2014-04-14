namespace Dede.App.MPGOHelper
{
    using System;

    internal static class StringExtensions
    {
        public static void WriteLineWithBlock(
            this String message)
        {
            Console.WriteLine(
                @"{0}{1}{0}", 
                Environment.NewLine, 
                message);
        }
    }
}