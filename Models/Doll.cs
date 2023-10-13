//I updated my Doll.cs page  and add new attributes and characteristics of my product.

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcDoll.Models 
{
    public class Doll
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Categories { get; set; }

        [Display(Name = "First launch")]
        [DataType(DataType.Date)]
        
        public DateTime  Firstlaunch{ get; set; }
        public string Brand { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string Rating { get; set; }
    }
}
