using Microsoft.AspNetCore.Mvc;

namespace BeeProdicts.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
