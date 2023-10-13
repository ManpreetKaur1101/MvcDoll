//I updated my Doll.cs page  and add new attributes and characteristics of my product.

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcDoll.Models 
{
    public class Doll
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required] 
        public string Name { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Categories { get; set; }

        [Display(Name = "First launch")]
        [DataType(DataType.Date)]
        
        public DateTime  Firstlaunch{ get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string Brand { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }
    }
}
