namespace Dede.App.LatestStateEf
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    using Dede.App.LatestStateEf.Domain;

    internal sealed class Program
    {
        static void Main()
        {
            InitDb.InitTables();

            var ctx = new ApplicationDbContext();

            var query =
                ctx.TransactionFlows
                    .Select(s => new { s.TransactionId, s.Status, StateLevel = ctx.TranscationStates.FirstOrDefault(p => p.State.Equals(s.Status)).Level })
                    .GroupBy(f => f.TransactionId)
                    .Select(grp => new { grp, MaxState = grp.Max(s => s.StateLevel) })
                    .SelectMany(sc => sc.grp, (k, g) => new { k, g })
                    .Where(p => p.g.StateLevel.Equals(p.k.MaxState))
                    .Select(s => new { Id = s.g.TransactionId, Customer = ctx.Customers.FirstOrDefault(p => p.Id.Equals(s.g.TransactionId)).Name, s.g.Status });

            Debug.WriteLine(query.ToString());
            var results = query.ToList();

            results.ForEach(a =>
                Console.WriteLine(
                    @"Id = {0}, Customer = {1}, Status = {2}",
                    a.Id,
                    a.Customer,
                    a.Status));
        }
    }
}