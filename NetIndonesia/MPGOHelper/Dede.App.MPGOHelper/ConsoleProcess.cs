namespace Dede.App.MPGOHelper
{
    using System;
    using System.Diagnostics;

    internal class ConsoleProcess
        : Process
    {
        public ConsoleProcess(
            String fileName,
            String arguments)
        {
            this.StartInfo = 
                new ProcessStartInfo
                {
                    UseShellExecute        = false,
                    RedirectStandardOutput = true,
                    Arguments              = arguments,
                    FileName               = fileName
                };
        }

        public new void Start()
        {
            base.Start();

            using (var reader = this.StandardOutput)
            {
                Console.WriteLine(reader.ReadToEnd());
            }

            this.WaitForExit();
        }

        protected override void Dispose(
            Boolean disposing)
        {
            Console.ForegroundColor = ConsoleColor.White;
            base.Dispose(disposing);
        }
    }
}