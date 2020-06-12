using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RoutesExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id=50)
        {
            return Content("This is the Home controller with default param: " + id);
        }

        [Route("Hello/{firstname}/{lastname}")]
        public IActionResult Greeting(string firstname, string lastname)
        {
            return Content($"Hello {firstname} {lastname} from module 4 demo 2");
        }
    }
}
