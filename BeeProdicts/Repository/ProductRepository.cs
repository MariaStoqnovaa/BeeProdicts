using BeeProdicts.Data;
using BeeProdicts.Interface;
using BeeProdicts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BeeProdicts.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly ApplicationDbContext _context;

        //bring database
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }
        public async Task<int> Add(Product product)
        {
            //_context.Add(product);
            //return Save();

            var newProduct = new Product()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                ColorID = product.ColorID,
                FinishID = product.FinishID,
                SizeID = product.SizeID,
                Image = product.Image,
            };

            _context.Add(product);
           
            return newProduct.Id;
        }

        public async Task<Color> AddColor (int colorName)
        {
            return await _context.Color.FirstOrDefaultAsync(c => c.ColorID == colorName);
        }

        public async Task<List<Color>> GetColor()
        {
            return await _context.Color.Select(c => new Color()
            {
                ColorID = c.ColorID,
                ColorName = c.ColorName
            }).ToListAsync();
        }
          public async Task<List<Finish>> GetFinish()
        {
            return await _context.Finish.Select(c => new Finish()
            {
                FinishID = c.FinishID,
                FinishName = c.FinishName
            }).ToListAsync();
        }


        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
