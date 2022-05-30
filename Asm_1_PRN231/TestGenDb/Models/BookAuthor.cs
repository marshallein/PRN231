using System;
using System.Collections.Generic;

#nullable disable

namespace TestGenDb.Models
{
    public partial class BookAuthor
    {
        public int AuthorId { get; set; }
        public int BookId { get; set; }
        public DateTime AuthorOrder { get; set; }
        public int? RoyaltyPercentage { get; set; }

        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }
    }
}
