namespace Dede.App.MPGOHelper
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Reflection;

    internal sealed class MPGOPreProcess
    {
        public MPGOPreProcess(
            MPGOArgument mpgoArgument)
        {
            this.MPGOArgument = mpgoArgument;
            this.MPGOArgumentByRules = (MPGOArgument)mpgoArgument.Clone();
            this.CheckCanBeProcess();
        }

        public MPGOArgument MPGOArgument { get; private set; }

        public MPGOArgument MPGOArgumentByRules { get; set; }

        public Assembly TargetAssembly { get; private set; }

        public Boolean CanProcess { get; private set; }

        public Boolean UsePath { get; private set; }

        public String WorkingPath { get; private set; }

        public MPGOPreProcess RuleMe(IMPGORule mpgoRule)
        {
            mpgoRule.Rule(this);
            return this;
        }

        private void CheckCanBeProcess()
        {
            if (AssemblyHelper.IsAssembly(this.MPGOArgument.Scenario))
            {
                this.CanProcess =
                    this.MPGOArgument.Scenario.EndsWith(@".EXE", StringComparison.CurrentCultureIgnoreCase);

                this.TargetAssembly =
                    Assembly.LoadFrom(this.MPGOArgument.Scenario);

                this.WorkingPath =
                    Path.GetDirectoryName(this.TargetAssembly.Location) ?? String.Empty;

                this.UsePath =
                    String.Concat(this.WorkingPath, @"\")
                        .ToUpper(CultureInfo.CurrentCulture)
                        .Equals(AppDomain.CurrentDomain.BaseDirectory.ToUpper(CultureInfo.CurrentCulture));
            }
            else
            {
                this.CanProcess = false;
            }
        }
    }
}