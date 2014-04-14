namespace Dede.App.MPGOHelper
{
    using System;
    using System.IO;
    using System.Reflection;

    internal static class AssemblyHelper
    {
        public static Boolean IsAssembly(
            String assemblyFile)
        {
            try
            {
                AssemblyName.GetAssemblyName(assemblyFile);
                return true;
            }
            catch (FileNotFoundException)
            {
                return false;
            }
            catch (BadImageFormatException)
            {
                return false;
            }
        }
    }
}