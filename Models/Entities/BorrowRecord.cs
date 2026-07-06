namespace Library_System_train.Models.Entities
{
    public class BorrowRecord
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        public int MemberID { get; set; }

        public DateTime BorrowDate { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime? ReturnTime { get; set; }

        public bool IsReturned { get; set; } = false;

        public Book Book { get; set; }

        public Member Member { get; set; }



    }
}
