namespace BookStore.Models
{
    using BookStore.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LibraryContext : DbContext
    {
        public LibraryContext()
            : base("name=LibraryContext")
        {
        }


        public virtual DbSet<Book> MyEntities { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<LibraryContext>(null);
            base.OnModelCreating(modelBuilder);
        }

    }

}