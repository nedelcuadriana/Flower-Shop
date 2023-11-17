using ProiectAe.Data;
using ProiectAe.Models.Interfaces;

namespace ProiectAe.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private FlowerShopDbContext dbContext;

        public ProductRepository(FlowerShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        
        public IEnumerable<Product> GetAllProducts()
        {
            return dbContext.Products;
        }

        public Product? GetProductDetail(int id)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetTrendingProducts()
        {
            return dbContext.Products.Where(p => p.IsTrendingProduct);
        }
    }
}
