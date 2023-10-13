using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcDoll.Models
{
    public class DollBrandViewModel
    {
        public List<Doll> Dolls { get; set; }
        public SelectList Brands { get; set; }
        public string DollBrand { get; set; }
        public string SearchString { get; set; }
    }
}