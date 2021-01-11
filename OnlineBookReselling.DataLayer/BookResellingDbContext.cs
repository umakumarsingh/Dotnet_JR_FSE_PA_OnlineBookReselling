using Microsoft.EntityFrameworkCore;
using OnlineBookReselling.Entities;
using System;

namespace OnlineBookReselling.DataLayer
{
    public class BookResellingDbContext : DbContext
    {
        public BookResellingDbContext(DbContextOptions<BookResellingDbContext> dbContextOptions)
            :base(dbContextOptions)
        {
            //Database.Migrate();
        }
        /// <summary>
        /// Creating DbSet for Table
        /// </summary>
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        /// <summary>
        /// While Model or Table creating Applaying Primary key to Table
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>()
                .HasKey(x => x.UserId);
            modelBuilder.Entity<Book>()
                .HasKey(x => x.BookId);
            modelBuilder.Entity<BookType>()
                .HasKey(x => x.BookTypeId);
            modelBuilder.Entity<Order>()
                .HasKey(x => x.OrderId);
            modelBuilder.Entity<Publisher>()
                .HasKey(x => x.PublisherId);
            base.OnModelCreating(modelBuilder);

        }
    }
}
