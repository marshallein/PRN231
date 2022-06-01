using System;
using System.Collections.Generic;

namespace CodeFirstDemo.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public DateTime JoinedDate { get; set; }
        public List<PlayerInstrument> Instruments { get; set; }
    }
}
