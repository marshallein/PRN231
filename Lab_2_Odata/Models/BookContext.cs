using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Lab_2_Odata.Models
{
    public class BookContext : DbContext
    {
        public BookContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Press> Presses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().OwnsOne(c => c.Address);
        }

    }
}
