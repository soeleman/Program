namespace Dede.App.LatestStateEf.Domain
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    using Dede.App.LatestStateEf.Models;

    public class TranscationStateConfiguration
        : EntityTypeConfiguration<TranscationState>
    {
        public TranscationStateConfiguration()
        {
            this.HasKey(ke => ke.Level);

            this.Property(pe => pe.State).IsRequired().HasMaxLength(10);
            this.Property(pe => pe.Level).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}