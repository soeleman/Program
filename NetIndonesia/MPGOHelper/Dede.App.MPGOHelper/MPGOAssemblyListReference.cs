namespace Dede.App.MPGOHelper
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    internal sealed class MPGOAssemblyListReference
        : IMPGORule
    {
        public void Rule(
            MPGOPreProcess mpgoPreProcess)
        {
            if (!mpgoPreProcess.CanProcess)
            {
                return;
            }

            if (mpgoPreProcess.MPGOArgument.AssemblyList.Count >= 1)
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
                    .Select(Assembly.LoadFrom)
                    .Where(workingPathAssembly =>
                           mpgoPreProcess.TargetAssembly.GetReferencedAssemblies().Any(referenceAssembly =>
                                                                                       referenceAssembly.FullName.Equals(workingPathAssembly.FullName)))
                    .Select(assemblyRef =>
                            mpgoPreProcess.UsePath
                                ? Path.GetFileName(assemblyRef.Location)
                                : assemblyRef.Location));
        }
    }
}