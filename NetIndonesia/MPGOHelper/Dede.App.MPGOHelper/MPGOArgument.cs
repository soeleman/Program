namespace Dede.App.MPGOHelper
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal sealed class MPGOArgument
        : ICloneable
    {
        public MPGOArgument()
        {
            this.NoClean =
                this.Assembly64Bit =
                this.LeaveNativeImages =
                this.RemoveNativeImage = false;

            this.ExeConfig = String.Empty;
            this.AssemblyList = new List<String>();
            this.AssemblyListFile = new List<String>();
        }

        public String Scenario { get; set; }

        public String OutputDirectory { get; set; }

        public List<String> AssemblyList { get; set; }

        public List<String> AssemblyListFile { get; set; }

        public String ExeConfig { get; set; }

        public Boolean NoClean { get; set; }

        public Boolean Assembly64Bit { get; set; }

        public Boolean Reset { get; set; }

        public Boolean LeaveNativeImages { get; set; }

        public Boolean RemoveNativeImage { get; set; }

        public override String ToString()
        {
            var argBuilder = new StringBuilder();

            argBuilder.AppendFormat(@"-Scenario ""{0}"" ", this.Scenario);
            argBuilder.AppendFormat(@"-OutDir ""{0}"" ", this.OutputDirectory);

            if (this.AssemblyList.Count >= 1)
            {
                argBuilder.Append(@"-AssemblyList ");

                foreach (var assembly in this.AssemblyList)
                {
                    argBuilder.AppendFormat(@"""{0}"" ", assembly);
                }
            }

            if (this.AssemblyListFile.Count >= 1)
            {
                argBuilder.Append(@"-AssemblyListFile ");

                foreach (var assembly in this.AssemblyListFile)
                {
                    argBuilder.AppendFormat(@"""{0}"" ", assembly);
                }
            }

            if (!String.IsNullOrEmpty(this.ExeConfig))
            {
                argBuilder.AppendFormat(@"-ExeConfig ""{0}"" ", this.ExeConfig);
            }

            if (this.NoClean)
            {
                argBuilder.Append(@"-NoClean ");
            }

            if (this.Assembly64Bit)
            {
                argBuilder.Append(@"-64bit ");
            }

            if (this.Reset)
            {
                argBuilder.Append(@"-Reset ");
            }

            if (this.LeaveNativeImages)
            {
                argBuilder.Append(@"-LeaveNativeImages ");
            }

            if (this.RemoveNativeImage)
            {
                argBuilder.Append(@"-RemoveNativeImages ");
            }

            return argBuilder.ToString();
        }

        public Object Clone()
        {
            var clone = new MPGOArgument()
                            {
                                Scenario = this.Scenario,
                                OutputDirectory = this.OutputDirectory,
                                ExeConfig = this.ExeConfig,
                                NoClean = this.NoClean,
                                Reset = this.Reset,
                                LeaveNativeImages = this.LeaveNativeImages,
                                RemoveNativeImage = this.RemoveNativeImage,
                                Assembly64Bit = this.Assembly64Bit
                            };

            clone.AssemblyList.AddRange(this.AssemblyList);
            clone.AssemblyListFile.AddRange(this.AssemblyListFile);

            return clone;
        }
    }
}