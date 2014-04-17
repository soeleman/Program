namespace Dede.App.LatestStateEf.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    using Dede.App.LatestStateEf.Models;

    internal static class InitDb
    {
        public static void InitTables()
        {
            Database.SetInitializer(new DropCreateDatabaseTables());

            using (var context = new ApplicationDbContext())
            {
                context.Customers.AddRange(
                    new List<Customer>
                        {
                            new Customer { Id = 1, Name = @"ABC" },
                            new Customer { Id = 2, Name = @"DEF" }
                        });

                context.TransactionFlows.AddRange(
                    new List<TransactionFlow>
                        {
                            new TransactionFlow { Id = 1, Date = new DateTime(2000, 1, 1), TransactionId = 1, Status = "Submit" },
                            new TransactionFlow { Id = 2, Date = new DateTime(2000, 1, 1), TransactionId = 2, Status = "Submit" },
                            new TransactionFlow { Id = 3, Date = new DateTime(2000, 2, 1), TransactionId = 1, Status = "Process" },
                            new TransactionFlow { Id = 4, Date = new DateTime(2000, 2, 1), TransactionId = 2, Status = "Process" },
                            new TransactionFlow { Id = 5, Date = new DateTime(2000, 3, 1), TransactionId = 2, Status = "Finish" }
                        });

                context.TranscationStates.AddRange(
                    new List<TranscationState>
                    {
                        new TranscationState { Level = 1, State = "Submit" },
                        new TranscationState { Level = 3, State = "Process" },
                        new TranscationState { Level = 9, State = "Finish" }
                    });

                context.SaveChanges();
            }
        }
    }
}