﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject.Models
{
    public class BookAuthor
    {
        public int Author_id { get; set; }
        public int Book_id { get; set; }
        public DateTime Author_order { get; set; }
        public int? Royalty_percentage { get; set; }

        public Author Author { get; set; }
        public Book Book { get; set; }

    }
}