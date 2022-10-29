namespace Matgr.ProductsAPI.Profile
{
    using AutoMapper;
    using Matgr.ProductsAPI.Dtos;
    using Matgr.ProductsAPI.Models;

    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<Product, ProductDto>();

            CreateMap<ProductDto, Product>();

        }
    }
}
