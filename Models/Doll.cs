//I updated my Doll.cs page  and add new attributes and characteristics of my product.

using System;
using System.ComponentModel.DataAnnotations;

namespace MvcDoll.Models 
{
    public class Doll
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Categories { get; set; }

        [DataType(DataType.Date)]
        public DateTime  Firstlaunch{ get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
    }
}
