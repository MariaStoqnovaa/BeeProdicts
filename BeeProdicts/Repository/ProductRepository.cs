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
            try
            {
                _context.Add(product);
                _context.SaveChanges();
                return 0;
            }
            catch (Exception ex)
            {
                return 1;
            }

        }


        public async Task<Color> AddColor(int colorName)
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
        public async Task<List<Size>> GetSize()
        {
            return await _context.Size.Select(c => new Size()
            {
                SizeID = c.SizeID,
                SizeName = c.SizeName
            }).ToListAsync();
        }

        public async Task<List<TypeProduct>> GetTypes()
        {
            return await _context.TypesSupplies.Select(c => new TypeProduct()
            {
                TypeId = c.TypeId,
                Name = c.Name
            }).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<IEnumerable<Product>> GetAllByID(int id)
        {
            return await _context.Products.Where(p => p.TypeId == id).ToListAsync();
        }
    }
}
