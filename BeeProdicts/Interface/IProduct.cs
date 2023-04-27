using BeeProdicts.Models;

namespace BeeProdicts.Interface
{
    public interface IProduct
    {
        Task<IEnumerable<Product>> GetAll();
        Task<List<Color>> GetColor();
        Task<List<Finish>> GetFinish();
        Task<List<Size>> GetSize();
        Task<Color> AddColor(int colorName);
        Task<int> Add(Product product);
        bool Save();
    }
}
