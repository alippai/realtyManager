using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace RealtyManager.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MimeType { get; set; }

        [Column(TypeName = "image")]
        public byte[] Data { get; set; }
    }
}