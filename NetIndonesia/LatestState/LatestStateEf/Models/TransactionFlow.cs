namespace Dede.App.LatestStateEf.Models
{
    using System;

    public class TransactionFlow
    {
        public Int32 Id { get; set; }

        public DateTime Date { get; set; }

        public Int32 TransactionId { get; set; }

        public String Status { get; set; }
    }
}