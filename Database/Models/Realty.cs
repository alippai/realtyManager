using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Database.Models
{
    public class Realty
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public double Size { get; set; }
        public double Room { get; set; }
        public decimal Price { get; set; }
        public int ownerId { get; set; }
        public virtual Profile Owner { get; set; }
    }
}
