using Microsoft.AspNetCore.Mvc;

namespace BeeProdicts.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
