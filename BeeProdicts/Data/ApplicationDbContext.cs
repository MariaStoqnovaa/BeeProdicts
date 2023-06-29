using BeeProdicts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;

namespace BeeProdicts.Data
{

    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        //public DbSet<ProductFromBee> ProductFromBee { get; set; }
        public DbSet<BlogPosts> BlogPosts { get; set; }  
        public DbSet<Address> Address { get; set; }
        public DbSet<Size> Size { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<Finish> Finish { get; set; }
        public DbSet<TypeProduct> TypesSupplies { get; set; }
       
    }
}
