using Application.Exceptions;
using Application.Interfaces;
using Application.Models.Product;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using Microsoft.Extensions.Logging;

namespace Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductService> _logger;
        public ProductService(IProductRepository productRepository,
            IMapper mapper,
            ILogger<ProductService> logger)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task CreateProduct(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);

            await _productRepository.CreateProduct(product);
        }

        public async Task DeleteProduct(int productId)
        {
            _logger.LogInformation($"Comment with id: {productId} DELETE action invoked");
            await _productRepository.DeleteProduct(productId);
        }

        public async Task<IEnumerable<ProductDto>> GetAllProducts()
        {
            var products = await _productRepository.GetAllProducts();
            var productsDto = _mapper.Map<IEnumerable<ProductDto>>(products);

            return productsDto;
        }

        public async Task<ProductDto> GetProductById(int productId)
        {
            var product = await _productRepository.GetProductById(productId);
            if (product is null)
            {
                throw new NotFoundException("product not found");
            }
            var productDto = _mapper.Map<ProductDto>(product);
            return productDto;
        }

        public async Task<IEnumerable<ProductDto>> GetProductsByCategory(string category)
        {
            var myEnum = (ECategory)default;
            try
            {
                myEnum = (ECategory)Enum.Parse(typeof(ECategory), category);
            }
            catch (Exception)
            {
                throw new NotFoundException("product not found");
            }

            var product = await _productRepository.GetProductsByCategory(myEnum);

            var productDto = _mapper.Map<IEnumerable<ProductDto>>(product);
            return productDto;
        }

        public async Task UpdateProduct(UpdateProductDto updateProductDto, int productId)
        {
            var product = await _productRepository.GetProductById(productId);
            if (product is null)
            {
                throw new NotFoundException("product not found");
            }

            var productDto = _mapper.Map<Product>(updateProductDto);

            await _productRepository.UpdateProduct(product, productId);
        }
    }
}
