namespace Dede.App.LatestStateEf
{
    using System;
    using System.Linq;

    using Dede.App.LatestStateEf.Domain;

    internal sealed class Program
    {
        static void Main()
        {
            InitDb.InitTables();

            var ctx = new ApplicationDbContext();

            ctx.TransactionFlows
                .Select(s =>
                    new
                    {
                        s.TransactionId,
                        s.Status,
                        StateLevel = ctx.TranscationStates.FirstOrDefault(p => p.State.Equals(s.Status)).Level
                    })
                .GroupBy(ks =>
                    ks.TransactionId)
                .Select(sg =>
                    new
                    {
                        sg,
                        MaxState = sg.Max(s => s.StateLevel)
                    })
                .SelectMany(
                    sc => sc.sg,
                    (k, g) => new { k, g })
                .Where(p =>
                    p.g.StateLevel.Equals(p.k.MaxState))
                .Select(s =>
                    new
                    {
                        Id = s.g.TransactionId,
                        Customer = ctx.Customers.FirstOrDefault(p => p.Id.Equals(s.g.TransactionId)).Name,
                        s.g.Status
                    })
                .ToList()
                .ForEach(a =>
                    Console.WriteLine(
                        @"Id = {0}, Customer = {1}, Status = {2}",
                        a.Id,
                        a.Customer,
                        a.Status));

            (
                from g in 
                    (
                        from tf in ctx.TransactionFlows 
                        select new
                        {
                            tf.TransactionId, 
                            tf.Status, 
                            StateLevel = ctx.TranscationStates.FirstOrDefault(p => p.State.Equals(tf.Status)).Level
                        }
                    )
                group g by g.TransactionId into grp
                let maxState = grp.Max(s => s.StateLevel)
                from p in grp
                where p.StateLevel.Equals(maxState)
                select new
                {
                    Id = p.TransactionId, 
                    Customer = ctx.Customers.FirstOrDefault(c => c.Id.Equals(p.TransactionId)).Name, 
                    p.Status
                }
            )
            .ToList()
            .ForEach(a =>
                Console.WriteLine(
                    @"Id = {0}, Customer = {1}, Status = {2}",
                    a.Id,
                    a.Customer,
                    a.Status));
        }
    }
}