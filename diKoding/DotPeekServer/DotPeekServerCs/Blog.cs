namespace DotPeekServer
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table(@"Blogs")]
    public sealed class Blog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }

        [StringLength(150)]
        public String Title { get; set; }

        public DateTime PostAt { get; set; }

        [StringLength(50)]
        public String PostBy { get; set; }

        public override String ToString()
        {
            return String.Format(
                @"{0}-{1}-{2}-{3}",
                this.Id,
                this.Title,
                this.PostAt,
                this.PostBy);            
        }
    }
}