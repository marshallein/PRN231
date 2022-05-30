using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Models
{
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Book_id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Type { get; set; }

        public Publisher Pub { get; set; }
        [Required]
        public int Price { get; set; }
        public int Advance { get; set; }
        public bool Royalty { get; set; } = false;
        public DateTime Ytd_sales { get; set; }
        [MaxLength(100)]
        public string Notes { get; set; }
        public DateTime Publisher_date { get; set; }
        [ForeignKey("Pub")]
        public int Pub_id { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }


    }
}
