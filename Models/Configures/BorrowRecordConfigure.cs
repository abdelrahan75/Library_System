using Library_System_train.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_System_train.Models.Configures
{
    public class BorrowRecordConfigure : IEntityTypeConfiguration<BorrowRecord>
    {
        public void Configure(EntityTypeBuilder<BorrowRecord> B)
        {
            B.HasKey(x => x.Id);
            B.HasOne(x => x.Book);
            B.HasOne(x => x.Member);

        }
    }
    }
