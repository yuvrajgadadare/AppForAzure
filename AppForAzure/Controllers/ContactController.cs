using Microsoft.AspNetCore.Mvc;

namespace AppForAzure.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
