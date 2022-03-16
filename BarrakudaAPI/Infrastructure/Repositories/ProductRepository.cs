using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly BarrakudaDbContext _dbContext;

        public ProductRepository(BarrakudaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateProduct(Product product)
        {
            await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdateProduct(Product product, int productId)
        {
            var result = await _dbContext.Products
                .FirstOrDefaultAsync(p => p.Id == productId);

            result.Name = product.Name;
            result.Description = product.Description;
            result.Price = product.Price;
            result.Pieces = product.Pieces;

            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteProduct(int productId)
        {
            var product = await _dbContext.Products
                .FirstOrDefaultAsync(p => p.Id == productId);

            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Product> GetProductById(int productId)
        {
            var product = await _dbContext.Products
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == productId);

            return product;
        }
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var products = await _dbContext.Products
                .ToListAsync();

            return products;
        }
    }
}
