namespace Dede.App.LatestStateEf.Domain
{
    using System.Data.Entity;

    using Dede.App.LatestStateEf.Models;

    public class ApplicationDbContext 
        : DbContext
    {
        public ApplicationDbContext()
            : base(@"tsql")
        {
            // force using connection string
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<TransactionFlow> TransactionFlows { get; set; }

        public DbSet<TranscationState> TranscationStates { get; set; }

        protected override void OnModelCreating(
            DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new TransactionFlowConfiguration());
            modelBuilder.Configurations.Add(new TranscationStateConfiguration());
        }
    }
}