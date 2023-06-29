using BeeProdicts.Models;

namespace BeeProdicts.Interface
{
    public interface IProduct
    {
        Task<IEnumerable<Product>> GetAll();
        Task<IEnumerable<Product>> GetAllByID(int id);
        Task<Product> GetByIdAsync(int id);
        Task<List<Color>> GetColor();
        Task<List<Finish>> GetFinish();
        Task<List<Size>> GetSize();
        Task<List<TypeProduct>> GetTypes();
        Task<Color> AddColor(int colorName);
        Task<int> Add(Product product);
        bool Save();
    }
}
