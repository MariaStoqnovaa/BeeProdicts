using BeeProdicts.Interface;
using BeeProdicts.Models;
using BeeProdicts.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BeeProdicts.Controllers
{
    public class DetailsController : Controller
    {
        private readonly IProduct _context;

        public DetailsController(IProduct context)
        {
            _context = context;
           
        }
        
        public async Task< IActionResult> Details(int id)
        {
            var colors = new SelectList(await _context.GetColor(), "ColorID", "ColorName");
            var finish = new SelectList(await _context.GetFinish(), "FinishID", "FinishName");
            var size = new SelectList(await _context.GetSize(), "SizeID", "SizeName");

            var product = await _context.GetByIdAsync(id);

            var viewModel = new DetailsViewModel(colors, finish, size, product);

            return View(viewModel); 

        }


    }
}
