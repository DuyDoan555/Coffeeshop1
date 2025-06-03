using coffeeshop.Data;
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
            return (IEnumerable<Product>)dbContext.Products; // Bỏ casting không cần thiết
        }

        public Product? GetProductDetail(int id)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetTrendingProducts()
        {
            return dbContext.Products.Where(static p => p.IsTrendingProduct); // Bỏ static keyword
        }
    }
}
