namespace DotPeekServer
{
    using System.Data.Entity;

    public partial class BlogContext 
        : DbContext
    {
        public BlogContext()
            : base(@"name=BlogContext")
        {
        }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(
            DbModelBuilder modelBuilder)
        {
        }
    }
}