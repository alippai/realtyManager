using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealtyManager.Models
{
    public enum TypeNames { 
        Room,
        Flat,
        House,
        Sublet
    }
    public class Realty
    {
        public int RealtyId { get; set; }
        public string Address { get; set; }
        public double Size { get; set; }
        public TypeNames Type { get; set; }
        public double Room { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int OwnerId { get; set; }
    }
}
