namespace DotPeekServer
{
    using System;
    using System.Data.Entity;
    using System.Diagnostics;

    internal class Program
    {
        internal static void Main()
        {
            using (var ctx = new BlogContext())
            {
#if DEBUG
                ctx.Database.Log += log => Debug.WriteLine(log);
#endif
                var blog =
                    new Blog
                    {
                        PostAt = DateTime.Now,
                        PostBy = @"Scully",
                        Title  = @"Missing Building"
                    };

                ctx.Blogs.Add(blog);
                ctx.SaveChanges();

                ctx.Blogs
                    .ToListAsync()
                    .Result
                    .ForEach(Console.WriteLine);
            }
        }
    }
}