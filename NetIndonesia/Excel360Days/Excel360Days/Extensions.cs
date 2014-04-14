namespace Dede.App.Excel360Days
{
    using System;

    internal static class Extensions
    {
        public static DateTime GetFirstDayOfMonth(
            this DateTime value)
        {
            return new DateTime(value.Year, value.Month, 1);
        }

        public static DateTime GetTheLastDayOfMonth(
            this DateTime value)
        {
            return GetFirstDayOfMonth(value)
                .AddMonths(1)
                .Subtract(new TimeSpan(1, 0, 0, 0, 0));
        }

        public static Boolean IsLastDayOfMonth(
            this DateTime value)
        {
            return value
                .GetTheLastDayOfMonth()
                .Day == value.Day;
        }

        public static Int32 ExcelDays360(
            this DateTime beginDate,
            DateTime endDate,
            Boolean flag = false)
        {
            return flag
                ? new InterestCalculatorService(
                        FunctionInterestCalculateMethod.European30Per360,
                        beginDate,
                        endDate).Calculate()
                : new InterestCalculatorService(
                        beginDate,
                        endDate).Calculate();
        }
    }
}