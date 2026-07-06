namespace Library_System_train.Models.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string ISBN { get; set; }

        public string Genre { get; set; }

        public int PublicYear { get; set; }

        public int TotalCopies { get; set; }

        public int AvailableCopies { get; set; }

        public int AuthorId { get; set; }

        public Author author { get; set; }
    }
}
