using Library_System_train.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_System_train.Models.Configures
{
    public class MemberConfigure : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> M)
        {
            M.HasKey(x => x.Id);
            M.Property(x => x.FullName)
                .IsRequired();
            M.Property(x => x.Email)
                .IsRequired();
            M.HasMany(x => x.borrowRecords);
        }
    }
    }
