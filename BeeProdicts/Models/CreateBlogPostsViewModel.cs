namespace BeeProdicts.Models
{
    public class CreateBlogPostsViewModel
    {
        
        public BlogPosts blogPosts { get; set; }
        public IFormFile BlogImage { get; set; }

        //imicializirame v klasa 
        public CreateBlogPostsViewModel()
        {
            blogPosts = new BlogPosts();
        }
        //public CreateBlogPostsViewModel()
        //{

        //}
    }
}
