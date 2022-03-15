using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IProductRepository
    {
        Task CreateProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(int productId);
        Task<Product> GetProductById(int productId);
        Task<IEnumerable<Product>> GetProductsByCategory(ECategory category);
        Task<IEnumerable<Product>> GetAllProducts();
    }
}
