using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using API2.model;

namespace API2.model
{
    public class BookDbContext : DbContext
    {
        public BookDbContext() : base() { }

        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {


             //Database.EnsureCreated();        


    }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.cre
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<API2.model.Article> Article { get; set; }

    }

}


