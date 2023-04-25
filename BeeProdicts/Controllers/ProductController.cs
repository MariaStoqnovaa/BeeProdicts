using BeeProdicts.Interface;
using BeeProdicts.Models;
using BeeProdicts.Repository;
using BeeProdicts.ViewModels;
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

        public ProductController(IProduct context, IPhotoService photoService)
        {
            _context = context;
            _photoService = photoService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> ShopAll()
        {
            IEnumerable<Product> products = await _context.GetAll();
            return View(products);
        }
        public IActionResult Foundation()
        {
            return View();
        }
        public IActionResult Frames()
        {
            return View();
        }

        public IActionResult Hives()
        {
            return View();
        }

        public async Task<IActionResult> Create(Product product, CreateProductViewModel file)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Colors = new SelectList(await _context.GetColor(), "ColorID", "ColorName");
                return View(product);
            }
            else
            {
                int id = await _context.Add(product);
                if (id > 0)
                {
                    return RedirectToAction(nameof(Create), new { isSuccess = true, bookId = id });
                }
            }

            ViewBag.Colors = new SelectList(await _context.GetColor(), "ColorID", "ColorName");

            if (ModelState.IsValid)
            {
                var result = await _photoService.AddPhotoAsync(file.Image);

                var itame = new Product
                {
                    Image = result.Url.ToString()
                };

            }

            
            _context.Save();
            return RedirectToAction("ShopAll");

            //if (!ModelState.IsValid)
            //{
            //    ViewBag.Colors = new SelectList(await _context.GetColor(), "ColorID", "ColorName");
            //    return View(product);
            //}

            //var color = await _context.AddColor(product.ColorID);

            //if (color == null)
            //{
            //    ModelState.AddModelError(string.Empty, "Invalid color selected");
            //    ViewBag.Colors = new SelectList(await _context.GetColor(), "ColorID", "ColorName");
            //    return View(product);
            //}



            //if (ModelState.IsValid)
            //{
            //    //var image = await _photoService.AddPhotoAsync(productVM.Image);

            //    var newProduct = new Product()
            //    {
            //        Name = product.Name,
            //        Price = product.Price,
            //        Description = product.Description,
            //        ColorID = product.ColorID,
            //        FinishID = product.FinishID,
            //        SizeID = product.SizeID,
            //        Image = product.Image,
            //    };

            //    _context.Add(newProduct);
            //}   
            //    _context.Save();

            //    return RedirectToAction("ShopAll");



        }

    }

}
