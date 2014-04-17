namespace Dede.App.LatestStateEf.Domain
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Transactions;

    public class DropCreateDatabaseTables
        : IDatabaseInitializer<ApplicationDbContext>
    {
        public void InitializeDatabase(
            ApplicationDbContext context)
        {
            Boolean isDbExists;

            using (new TransactionScope(TransactionScopeOption.Suppress))
            {
                isDbExists = context.Database.Exists();
            }

            if (isDbExists)
            {
                // remove all tables
                context.Database.ExecuteSqlCommand("EXEC sp_MSForEachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'");
                context.Database.ExecuteSqlCommand("EXEC sp_MSforeachtable @command1 = \"DROP TABLE ?\"");

                // create all tables
                var creationScript = ((IObjectContextAdapter)context).ObjectContext.CreateDatabaseScript();
                context.Database.ExecuteSqlCommand(creationScript);
                context.SaveChanges();
            }
            else
            {
                throw new ApplicationException("No database instance");
            }
        }
    }
}