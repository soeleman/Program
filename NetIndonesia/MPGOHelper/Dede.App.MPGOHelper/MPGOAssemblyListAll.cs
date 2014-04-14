namespace Dede.App.MPGOHelper
{
    using System;
    using System.IO;
    using System.Linq;

    internal sealed class MPGOAssemblyListAll
        : IMPGORule
    {
        public void Rule(
            MPGOPreProcess mpgoPreProcess)
        {
            if (!mpgoPreProcess.CanProcess)
            {
                return;
            }

            if (!mpgoPreProcess.MPGOArgument.AssemblyList.Contains(@"*.*"))
            {
                return;
            }

            mpgoPreProcess.MPGOArgumentByRules.AssemblyList.Clear();

            mpgoPreProcess.MPGOArgumentByRules.AssemblyList.AddRange(
                @"*.dll|*.exe"
                    .Split('|')
                    .SelectMany(filter => Directory.GetFiles(mpgoPreProcess.WorkingPath, filter))
                    .Where(assemblyFile =>
                           !assemblyFile.EndsWith(@"VSHOST.EXE", StringComparison.CurrentCultureIgnoreCase) &&
                           AssemblyHelper.IsAssembly(assemblyFile))
                    .Select(assemblyLocation =>
                            mpgoPreProcess.UsePath
                                ? Path.GetFileName(assemblyLocation)
                                : assemblyLocation));
        }
    }
}