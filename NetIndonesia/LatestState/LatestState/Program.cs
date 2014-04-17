namespace Dede.App.LatestState
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal sealed class Program
    {
        internal static void Main()
        {
            var customers =
                new List<Customer>
                    {
                        new Customer { Id = 1, Name = "ABC" },
                        new Customer { Id = 2, Name = "DEF" }
                    };

            var transactions =
                new List<TransactionFlow>
                    {
                        new TransactionFlow { Id = 1, Date = new DateTime(2000, 1, 1), TransactionId = 1, Status = "Submit" },
                        new TransactionFlow { Id = 2, Date = new DateTime(2000, 1, 1), TransactionId = 2, Status = "Submit" },
                        new TransactionFlow { Id = 3, Date = new DateTime(2000, 2, 1), TransactionId = 1, Status = "Process" },
                        new TransactionFlow { Id = 4, Date = new DateTime(2000, 2, 1), TransactionId = 2, Status = "Process" },
                        new TransactionFlow { Id = 5, Date = new DateTime(2000, 3, 1), TransactionId = 2, Status = "Finish" }
                    };

            var states =
                new List<TranscationState>
                    {
                        new TranscationState { Level = 1, State = "Submit" },
                        new TranscationState { Level = 3, State = "Process" },
                        new TranscationState { Level = 9, State = "Finish" }
                    };

            var results =
                transactions
                    .Select(s => new
                    {
                        s.TransactionId,
                        s.Status,
                        StateLevel = states.First(p => p.State.Equals(s.Status)).Level
                    })
                    .GroupBy(
                        ks => ks.TransactionId,
                        (k, g) => new
                        {
                            Id = k,
                            Items = g
                        })
                    .Select(g =>
                    {
                        var i = g.Items.First(p => p.StateLevel.Equals(g.Items.Max(s => s.StateLevel)));
                        return new
                        {
                            Id = i.TransactionId,
                            CustomerName = customers.First(p => p.Id.Equals(i.TransactionId)).Name,
                            i.Status
                        };
                    })
                    .ToList();

            results.ForEach(a =>
                Console.WriteLine(
                    @"Id = {0}, Customer = {1}, Status = {2}",
                    a.Id,
                    a.CustomerName,
                    a.Status));
        }
    }
}