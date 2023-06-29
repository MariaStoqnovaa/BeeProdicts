using BeeProdicts.Models;

namespace BeeProdicts.Interface
{
    public interface IProductFromBee
    {
        Task<IEnumerable<ProductFromBee>> GetAll();

        Task<IEnumerable<ProductFromBee>> GetAllByID(int id);
        Task<ProductFromBee> GetByIdAsync(int id);
        Task<List<Color>> GetColor();
        Task<List<Finish>> GetFinish();
        Task<List<Size>> GetSize();
        Task<List<TypeProduct>> GetTypes();
        Task<Color> AddColor(int colorName);
        Task<int> Add(ProductFromBee product);
        bool Save();
    }
}
