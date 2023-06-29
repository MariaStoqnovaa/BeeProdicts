using BeeProdicts.Data;
using BeeProdicts.Interface;
using BeeProdicts.Models;
using BeeProdicts.Repository;
using Grpc.Core;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BeeProdicts.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProduct _context;
        private readonly IPhotoService _photoService;

        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(IProduct context, IPhotoService photoService, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _photoService = photoService;
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            var colors = new SelectList(await _context.GetColor(), "ColorID", "ColorName");
            var finish = new SelectList(await _context.GetFinish(), "FinishID", "FinishName");
            var size = new SelectList(await _context.GetSize(), "SizeID", "SizeName");
            var type = new SelectList(await _context.GetTypes(), "TypeId", "Name");

            var viewModel = new CreateProductViewModel(colors, finish, size,type);

            return View(viewModel);
        }
        public async Task<IActionResult> ShopAll()
        {
            IEnumerable<Product> products = await _context.GetAll();
            return View(products);
        }
        public async Task<IActionResult> Types(int id)
        {

            IEnumerable<Product> products = await _context.GetAllByID(id);
            return View(products);
        }
      

        public async Task<IActionResult> Create(CreateProductViewModel productViewModel)
        {
            string path = Path.Combine(_webHostEnvironment.WebRootPath, "uploadFolder", productViewModel.Image.FileName);
            
            using (var stream = new FileStream(path, FileMode.Create))
            {
                productViewModel.product.Image = "/uploadfolder/" + productViewModel.Image.FileName;
                await productViewModel.Image.CopyToAsync(stream);
            }

            int id = await _context.Add(productViewModel.product);
            return RedirectToAction("ShopAll");
        }
    }
}
