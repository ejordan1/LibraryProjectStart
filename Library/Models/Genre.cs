using System.Collections.Generic;

namespace Library.Models
{
    public class Genre
    {
        public Genre()
        {
            this.Books = new HashSet<GenreBook>();
        }

        public int GenreId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<GenreBook> Books { get; set; }
    }
}