using BeeProdicts.Models;

namespace BeeProdicts.Interface
{
    public interface IBlog
    {
        Task<IEnumerable<BlogPosts>> GetAll();
        //Task<IEnumerable<BlogPost>> GetAllByID(int id);
        Task<BlogPosts> GetByIdAsync(int id);
        Task<int> Add(BlogPosts blogPost);
        bool Save();
     
    }
}
