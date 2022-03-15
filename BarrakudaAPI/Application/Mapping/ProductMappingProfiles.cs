using Application.Models.Product;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping
{
    public class ProductMappingProfiles : Profile
    {
        public ProductMappingProfiles()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<CreateProductDto, Product>();
        }
    }
}
