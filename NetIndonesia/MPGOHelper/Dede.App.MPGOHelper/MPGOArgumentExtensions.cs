namespace Dede.App.MPGOHelper
{
    using System;
    using System.Globalization;

    internal static class MPGOArgumentExtensions
    {
        private enum StateArgument
        {
            None,
            AssemblyList,
            AssemblyListFile
        }

        public static MPGOArgument ParseArgument(
            this MPGOArgument mpgoArgument,
            String[] arguments)
        {
            var stateArgument = StateArgument.None;

            for (var i = 0; i < arguments.Length; i++)
            {
                var argument = arguments[i];

                switch (argument.ToUpper(CultureInfo.CurrentCulture))
                {
                    case @"-SCENARIO":
                        i++;
                        mpgoArgument.Scenario = arguments[i];
                        stateArgument = StateArgument.None;
                        break;

                    case @"-OUTDIR":
                        i++;
                        mpgoArgument.OutputDirectory = arguments[i];
                        stateArgument = StateArgument.None;
                        break;

                    case @"-EXECONFIG":
                        i++;
                        mpgoArgument.ExeConfig = arguments[i];
                        stateArgument = StateArgument.None;
                        break;

                    case @"-NOCLEAN":
                        mpgoArgument.NoClean = true;
                        stateArgument = StateArgument.None;
                        break;

                    case @"-64BIT":
                        mpgoArgument.Assembly64Bit = true;
                        stateArgument = StateArgument.None;
                        break;

                    case @"-LEAVENATIVEIMAGES":
                        mpgoArgument.LeaveNativeImages = true;
                        stateArgument = StateArgument.None;
                        break;

                    case @"-REMOVENATIVEIMAGES":
                        mpgoArgument.RemoveNativeImage = true;
                        stateArgument = StateArgument.None;
                        break;

                    case @"-ASSEMBLYLIST":
                        stateArgument = StateArgument.AssemblyList;
                        break;

                    case @"-ASSEMBLYLISTFILE":
                        stateArgument = StateArgument.AssemblyListFile;
                        break;

                    default:
                        switch (stateArgument)
                        {
                            case StateArgument.AssemblyList:
                                mpgoArgument.AssemblyList.Add(argument);
                                break;

                            case StateArgument.AssemblyListFile:
                                mpgoArgument.AssemblyListFile.Add(argument);
                                break;

                            case StateArgument.None:
                                break;
                        }

                        break;
                }
            }

            return mpgoArgument;
        }
    }
}