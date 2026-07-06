using Library_System_train.Models.Configures;
using Library_System_train.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library_System_train.Data.DbContexts
{
    public class Library_SystemDbcontext : DbContext
    {
        public Library_SystemDbcontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<BorrowRecord> BorrowRecords { get; set; }

        public DbSet<Member> members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BookConfigure());
            modelBuilder.ApplyConfiguration(new AuthorConfigure());
            modelBuilder.ApplyConfiguration(new BorrowRecordConfigure());
            modelBuilder.ApplyConfiguration(new MemberConfigure());
        }
    }
}
