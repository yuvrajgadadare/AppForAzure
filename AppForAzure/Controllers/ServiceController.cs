using Microsoft.AspNetCore.Mvc;

namespace AppForAzure.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
