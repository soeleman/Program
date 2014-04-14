namespace Dede.App.Excel360Days
{
    using System;

    internal static class FunctionInterestCalculateMethod
    {
        public static readonly Func<DateTime, DateTime, Int32> UsNasd30Per360 = (beginDate, endDate) =>
            {
                var d1 = beginDate.Day;
                var d2 = endDate.Day;

                if (beginDate.IsLastDayOfMonth() && 
                    beginDate.Month == 2)
                {
                    d1 = 30;
                }

                if (d2 == 31 && 
                    d1 >= 30)
                {
                    d2 = 30;
                }

                if (d1 == 31)
                {
                    d1 = 30;
                }

                return ((((endDate.Year * 12) + endDate.Month) * 30) + d2) -
                       ((((beginDate.Year * 12) + beginDate.Month) * 30) + d1);
            };

        public static readonly Func<DateTime, DateTime, Int32> European30Per360 = (beginDate, endDate) =>
            {
                var begin = beginDate;
                var end = endDate;

                if (endDate.Day == 31)
                {
                    end = new DateTime(endDate.Year, endDate.Month, 30);
                }

                if (beginDate.Day == 31)
                {
                    begin = new DateTime(beginDate.Year, beginDate.Month, 30);
                }

                return
                    ((((end.Year * 12) + end.Month) * 30) + end.Day) -
                    ((((begin.Year * 12) + begin.Month) * 30) + begin.Day);
            };
    }
}