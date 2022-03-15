using Application.Models.Product;
using Domain.Enums;

namespace Application.Interfaces
{
    public interface IProductService
    {
        Task CreateProduct(ProductDto productDto);
        Task UpdateProduct(UpdateProductDto updateProductDto, int productId);
        Task DeleteProduct(int productId);
        Task<ProductDto> GetProductById(int productId);
        Task<IEnumerable<ProductDto>> GetProductsByCategory(string category);
        Task<IEnumerable<ProductDto>> GetAllProducts();
    }
}
