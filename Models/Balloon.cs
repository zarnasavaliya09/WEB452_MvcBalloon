using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBalloon.Models
{
    public class Balloon
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Occassion { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Shape { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
    }
}
