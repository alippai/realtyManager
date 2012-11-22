using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealtyManager.Models
{
    public class Realty
    {
        public int RealtyId { get; set; }
        public string Address { get; set; }
        public double Size { get; set; }
        public string Type { get; set; }
        public double Room { get; set; }
        public decimal Price { get; set; }
    }
}
