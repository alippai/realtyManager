using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using PagedList;


namespace Realty.Models
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

        [Required]
        public string Address { get; set; }

        [Required]
        public double Size { get; set; }
        public TypeNames Type { get; set; }

        [Required]
        public double Room { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string Description { get; set; }
        
        [DataType(DataType.Url)]
        public string VideoLink { get; set; }
        public virtual UserProfile Owner { get; set; }

        public string youtubeID(string url)
        {
            Match regex = Regex.Match(url, "^[^v]+v=(.{11}).*", RegexOptions.IgnoreCase);
            if (regex.Success)
            {
                return "http://www.youtube.com/v/" + regex.Groups[1].Value;
            }
            return url;
        }


    }
}
