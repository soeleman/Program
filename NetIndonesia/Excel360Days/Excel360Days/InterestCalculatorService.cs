namespace Dede.App.Excel360Days
{
    using System;

    internal sealed class InterestCalculatorService
    {
        private readonly Func<DateTime, DateTime, Int32> method;

        private readonly DateTime beginDate;
        private readonly DateTime endDate;

        public InterestCalculatorService(
            DateTime beginDate,
            DateTime endDate)
        {
            this.method = FunctionInterestCalculateMethod.UsNasd30Per360;
            this.beginDate = beginDate;
            this.endDate = endDate;
        }

        public InterestCalculatorService(
            Func<DateTime, DateTime, Int32> interestCalculateMethod,
            DateTime beginDate,
            DateTime endDate)
        {
            this.method = interestCalculateMethod;
            this.beginDate = beginDate;
            this.endDate = endDate;
        }

        public Int32 Calculate()
        {
            return this.method.Invoke(
                this.beginDate,
                this.endDate);
        }
    }
}