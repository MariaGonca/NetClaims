using AssessmentNet.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Encodings.Web;

namespace AssessmentNet.Controllers
{
    public class HomeController : Controller
    {
        // 
        // GET: /HelloWorld/
        /*public string Index()
        {
            return "This is my default action...";
        }*/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/

        /*public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }*/
    }
}