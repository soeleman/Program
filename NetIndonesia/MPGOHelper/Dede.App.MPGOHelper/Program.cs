namespace Dede.App.MPGOHelper
{
    using System;

    internal class Program
    {
        private static void Main(
            String[] args)
        {
            if (args.Length == 0)
            {
                using (new MPGOProcess(String.Empty))
                {
                    return;
                }
            }

            var mpgoArgument =
                new MPGOArgument()
                    .ParseArgument(args);
#if DEBUG
            using (new ConsoleFrontColor(ConsoleColor.Yellow))
            {
                mpgoArgument.ToString().WriteLineWithBlock();
            }
#endif
            mpgoArgument =
                new MPGOPreProcess(mpgoArgument)
                    .RuleMe(new MPGOAssemblyListReference())
                    .RuleMe(new MPGOAssemblyListAll())
                    .MPGOArgumentByRules;
#if DEBUG
            using (new ConsoleFrontColor(ConsoleColor.Blue))
            {
                mpgoArgument.ToString().WriteLineWithBlock();
            }
#endif
            using (new MPGOProcess(mpgoArgument.ToString()))
            {
                @"Thank you for using this software . . .".WriteLineWithBlock();
            }
        }
    }
}