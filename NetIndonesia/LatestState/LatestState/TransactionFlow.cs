namespace Dede.App.LatestState
{
    using System;

    public sealed class TransactionFlow
    {
        public Int32 Id { get; set; }

        public DateTime Date { get; set; }

        public Int32 TransactionId { get; set; }

        public String Status { get; set; }
    }
}