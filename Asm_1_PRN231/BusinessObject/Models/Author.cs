using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject.Models
{
    public class Author
    {
        public Author()
        {
            BookAuthors = new HashSet<BookAuthor>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Author_id { get; set; }

        [Required(ErrorMessage ="ko dc de trong")]
        public string First_name { get; set; }
        [Required]
        public string Last_name { get; set; }
        public string Phone { get; set; }
        [MaxLength(255)]
        public string Address { get; set; }
        public string City { get; set; }
        public string Email_address { get; set; }

        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
    }
}