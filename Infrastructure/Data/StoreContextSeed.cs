using System.Text.Json;
using Core.Entities;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context)
        {
            if (!context.ProductBrands.Any())
            {
                var brandsFile = "../Infrastructure/Data/SeedData/brands.json";
                var brandsData = File.ReadAllText(brandsFile);
                var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);
                
                context.ProductBrands.AddRange(brands);
            }

            if (!context.ProductTypes.Any())
            {
                var typesFile = "../Infrastructure/Data/SeedData/types.json";
                var typesData = File.ReadAllText(typesFile);
                var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);
                
                context.ProductTypes.AddRange(types);
            }

            if (!context.Products.Any())
            {
                var productsFile = "../Infrastructure/Data/SeedData/products.json";
                var productsData = File.ReadAllText(productsFile);
                var products = JsonSerializer.Deserialize<List<Product>>(productsData);
                
                context.Products.AddRange(products);
            }

            if (context.ChangeTracker.HasChanges())
            {
                await context.SaveChangesAsync();
            }
        }
    }
}