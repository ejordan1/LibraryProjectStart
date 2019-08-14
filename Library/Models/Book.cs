using System.Collections.Generic;

namespace Library.Models
{
    public class Book
    {
        public Book()
        {
            this.Genres = new HashSet<GenreBook>();
        }

        public int BookId { get; set; }
        public string Title { get; set; }

        public ICollection<GenreBook> Genres { get; }
    }
}