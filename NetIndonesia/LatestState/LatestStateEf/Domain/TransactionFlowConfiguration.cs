namespace Dede.App.LatestStateEf.Domain
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    using Dede.App.LatestStateEf.Models;

    public class TransactionFlowConfiguration
        : EntityTypeConfiguration<TransactionFlow>
    {
        public TransactionFlowConfiguration()
        {
            this.HasKey(ke => ke.Id);

            this.Property(pe => pe.Status).IsRequired().HasMaxLength(10);
            this.Property(pe => pe.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}