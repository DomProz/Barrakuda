using Application.Models.Product;

namespace Application.Interfaces
{
    public interface IProductService
    {
        Task CreateProduct(CreateProductDto productDto);
        Task UpdateProduct(UpdateProductDto updateProductDto, int productId);
        Task DeleteProduct(int productId);
        Task<CreateProductDto> GetProductById(int productId);
        Task<IEnumerable<CreateProductDto>> GetAllProducts();
    }
}
