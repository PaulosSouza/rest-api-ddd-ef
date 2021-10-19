using AutoMapper;
using RestAPIDDD.Domain;

namespace RestAPIDDD.Application
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>();

            CreateMap<ProductDto, Product>();
        }
    }
}