using BeeProdicts.Models;

namespace BeeProdicts.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            Name = "9-5/8\" DEEP ASSEMBLED HIVE KIT WITH FRAMES",
                            Price = 66.95,
                            Description = "This is the description of the first cinema",
                            FinishID = 9,
                            SizeID = 1,
                            ColorID = 11,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",

                         },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
