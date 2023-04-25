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
        public DbSet<Address> Address { get; set; }
        public DbSet<Size> Size { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<Finish> Finish { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Color>()
        //        .HasKey(c => c.ColorID);

        //    modelBuilder.Entity<Finish>()
        //        .HasKey(f => f.FinishID);

        //    modelBuilder.Entity<Size>()
        //        .HasKey(s => s.SizeID);

        //}

    }
}
