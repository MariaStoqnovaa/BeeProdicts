using BeeProdicts.Data;
using BeeProdicts.Interface;
using BeeProdicts.Models;
using Microsoft.EntityFrameworkCore;

namespace BeeProdicts.Repository
{
    public class BlogPostsRepository : IBlog
    {
        private readonly ApplicationDbContext _context;

        //bring database
        public BlogPostsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Add(BlogPosts blogPost)
        {
            try
            {
                _context.Add(blogPost);
                _context.SaveChanges();
                return 0;
            }
            catch (Exception ex)
            {
                return 1;
            }
        }

        public async Task<IEnumerable<BlogPosts>> GetAll()
        {
            return await _context.BlogPosts.ToListAsync();
        }

     
        public async Task<BlogPosts> GetByIdAsync(int id)
        {
            return await _context.BlogPosts.FirstOrDefaultAsync(i => i.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
