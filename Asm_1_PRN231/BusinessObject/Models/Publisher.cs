using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject.Models
{
    public class Publisher
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Pub_id { get; set; }
        public string Publisher_name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }

        public ICollection<User> Users { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}