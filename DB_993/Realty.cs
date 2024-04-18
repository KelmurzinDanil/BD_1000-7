using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_993
{
    internal class Realty
    {
        [Key]
        public int Id { get; set; }
        public string? NameRealty { get; set; }
        public byte[]? PhotoRealty { get; set; }
        public decimal? Price { get; set; }
        public string? Address { get; set; }
        public int Square { get; set; }
        public int Floor { get; set; }
        public int Mark { get; set; }
        public int Rooms { get; set; }


    }
}
