using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int User_id { get; set; }
        [Required]
        public string Email_address { get; set; }
        [Required]
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Source { get; set; }

        [MaxLength(30)]
        public string First_name { get; set; }
        [MaxLength(30)]
        public string Middle_name { get; set; }
        [MaxLength(30)]
        public string Last_name { get; set; }
        public DateTime Hire_date { get; set; }

        public Role Role { get; set; }
        public Publisher Pub { get; set; }
    }
}
