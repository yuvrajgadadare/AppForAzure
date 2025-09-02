using Microsoft.AspNetCore.Mvc;

namespace AppForAzure.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
