using coffeeshop.Models.Interfaces;
using coffeeshop.Models;
using Coffeeshop1.Models.Services; // Thêm using này để sử dụng Product

namespace CoffeeshopTH.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly CoffeeshopDbContext dbContext;

        public ProductRepository(CoffeeshopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return dbContext.Products.Cast<Product>(); // Ensure proper casting  
        }

        public Product? GetProductDetail(int id)
        {
            return dbContext.Products.Cast<Product>().FirstOrDefault(p => p.Id == id); // Ensure proper casting  
        }

        public IEnumerable<Product> GetTrendingProducts()
        {
            return dbContext.Products.Cast<Product>().Where(p => p.IsTrendingProduct); // Ensure proper casting  
        }
    }
}
