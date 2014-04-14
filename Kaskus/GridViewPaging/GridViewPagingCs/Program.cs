namespace Dede.App.GridViewPaging
{
    using System;
    using System.Windows.Forms;

    using Dede.App.GridViewPaging.Forms;

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}