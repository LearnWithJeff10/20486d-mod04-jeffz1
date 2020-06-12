using Microsoft.AspNetCore.Mvc;
using ControllersExample.Models;

namespace ControllersExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ExampleModel model = new ExampleModel()
            {
                Sentence = "Welcome to module 4 demo 1"
            };
            return View(model);
        }
    }
}
