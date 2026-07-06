using Library_System_train.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_System_train.Models.Configures
{
    public class BookConfigure : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> B)
        {
            B.HasKey(x => x.Id);
            B.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(200);
            B.Property(x => x.ISBN)
                .IsRequired();
            B.HasOne(x => x.author);
        }

        }
    }
