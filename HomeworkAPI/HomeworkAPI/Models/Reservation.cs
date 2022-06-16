using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
#nullable disable

namespace HomeworkAPI.Models
{
    public partial class Reservation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public int TypeId { get; set; }
       
        public virtual ReservationType Type { get; set; }
    }
}
