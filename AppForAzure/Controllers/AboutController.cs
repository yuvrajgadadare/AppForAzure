using Microsoft.AspNetCore.Mvc;

namespace AppForAzure.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
          public IActionResult Show()
        {
            return View();
        }
    }
}
