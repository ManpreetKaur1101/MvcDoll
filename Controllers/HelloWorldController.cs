using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcDoll.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        // I replace the index with the following code 
        public IActionResult Index()
        {
            return View();
        } 

        // 
        // GET: /HelloWorld/Welcome/ 

        // I updated my welcome message with the below code
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }

    }
}