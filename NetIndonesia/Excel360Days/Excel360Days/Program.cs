// History: 
// 2012.07.01 -- Tested again Office 2010 -- the result same, even the bug
// 2012.06.17 -- Initial
// this is implement mimic the way of ms excel (97-2007) function work (even can emulate the bug too). 
// remember there is a bug in excel version 97, 2000, 2003 and 2007. http://support.microsoft.com/kb/916004
namespace Dede.App.Excel360Days
{
    using System;

    internal sealed class Program
    {
        public static void Main()
        {
            TestDays360(new DateTime(2012, 1, 31), new DateTime(2012, 12, 31), 330, 330);
            TestDays360(new DateTime(2010, 2, 28), new DateTime(2012, 2, 29), 719, 721);
            TestDays360(new DateTime(2010, 2, 28), new DateTime(2011, 2, 28), 358, 360);
            TestDays360(new DateTime(2010, 2, 1), new DateTime(2011, 2, 28), 387, 387);
            TestDays360(new DateTime(2010, 2, 28), new DateTime(2011, 3, 1), 361, 363);
            TestDays360(new DateTime(2012, 1, 5), new DateTime(2012, 3, 10), 65, 65);
            TestDays360(new DateTime(2012, 2, 5), new DateTime(2012, 2, 10), 5, 5);
            TestDays360(new DateTime(2012, 2, 29), new DateTime(2012, 3, 5), 5, 6);
            TestDays360(new DateTime(2012, 2, 29), new DateTime(2013, 2, 28), 358, 359);
            TestDays360(new DateTime(2012, 2, 29), new DateTime(2014, 1, 1), 661, 662);
            TestDays360(new DateTime(2012, 1, 31), new DateTime(2012, 3, 5), 35, 35);
            TestDays360(new DateTime(2012, 1, 31), new DateTime(2013, 1, 31), 360, 360);
            TestDays360(new DateTime(2012, 3, 5), new DateTime(2013, 1, 31), 326, 325);

            // bug: KB916004
            TestDays360(new DateTime(2006, 2, 28), new DateTime(2006, 3, 28), 28, 30);
        }

        public static void TestDays360(
            DateTime startDate,
            DateTime endDate,
            Int32 excelResultFalse,
            Int32 excelResultTrue)
        {
            var resultUsNasd = startDate.ExcelDays360(endDate, false);
            var resultEuropean = startDate.ExcelDays360(endDate, true);

            Console.WriteLine("{0:d} to {1:d} is {2} ({3}) [US NASD]", startDate, endDate, resultUsNasd, excelResultFalse);
            Console.WriteLine("{0:d} to {1:d} is {2} ({3}) [European]", startDate, endDate, resultEuropean, excelResultTrue);
            Console.WriteLine();
        }
    }
}
