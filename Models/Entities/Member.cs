namespace Library_System_train.Models.Entities
{
    public class Member
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string? Phone { get; set; }

        public string? Address { get; set; }

        public DateTime MemberSince { get; set; } = DateTime.UtcNow;

        public bool isActive { get; set; }

        public ICollection<BorrowRecord> borrowRecords { get; set; }
    }
}
