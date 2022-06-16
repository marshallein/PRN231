using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace HomeworkAPI.Models
{
    public partial class ReservationType
    {
        public ReservationType()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int TypeId { get; set; }
        public string Type { get; set; }
        [JsonIgnore]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
