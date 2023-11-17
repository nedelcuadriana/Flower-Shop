namespace ProiectAe.Models.Interfaces
{
    public interface IProductRepository
    {
        //all products
        IEnumerable<Product> GetAllProducts();
        //best selling products
        IEnumerable<Product> GetTrendingProducts();
        //one single product
        Product? GetProductDetail(int id);
    }
}
