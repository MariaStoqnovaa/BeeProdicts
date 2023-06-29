using BeeProdicts.Interface;
using BeeProdicts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BeeProdicts.Controllers
{
    public class BlogPostsController : Controller
    {
        private readonly IBlog _context;
        private readonly IPhotoService _photoService;

        private readonly IWebHostEnvironment _webHostEnvironment;

        public BlogPostsController(IBlog context, IPhotoService photoService, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _photoService = photoService;
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> HomeBlog()
        {
            IEnumerable<BlogPosts> blogPost = await _context.GetAll();
            return View(blogPost);
        }
        public async Task<IActionResult> Create(CreateBlogPostsViewModel productViewModel)
        {
            string path = Path.Combine(_webHostEnvironment.WebRootPath, "uploadFolder", productViewModel.BlogImage.FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                productViewModel.blogPosts.BlogImage = "/uploadfolder/" + productViewModel.BlogImage.FileName;
                await productViewModel.BlogImage.CopyToAsync(stream);
            }

            int id = await _context.Add(productViewModel.blogPosts);
            return RedirectToAction("HomeBlog");
        }


    }
}
