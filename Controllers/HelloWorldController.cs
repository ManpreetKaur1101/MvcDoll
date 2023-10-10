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

        // I updated my welcome message with code provided in the tutorial
        // Again I updated previous code and change the Welcome method to add a Message and NumTimes value to the ViewData dictionary.
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

    }
}