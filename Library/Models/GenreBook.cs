namespace Library.Models
{
    public class GenreBook
    {
        public int GenereBookId { get; set; }
        public int BookId { get; set; }
        public int GenreId { get; set; }
        public Book Book { get; set; }
        public Genre Genre { get; set; }
    }
}