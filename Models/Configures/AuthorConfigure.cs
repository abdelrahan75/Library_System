using Library_System_train.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_System_train.Models.Configures
{
    public class AuthorConfigure : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> A)
        {
            A.HasKey(x => x.Id);
            A.Property(x => x.FirstName)
                .IsRequired();
            A.Property(x => x.LastName)
                .IsRequired();

            A.HasMany(x => x.Books);
        }
    }
    }
