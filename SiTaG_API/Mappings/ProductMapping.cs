using AutoMapper;
using SiTaG_API.DTOs;
using SiTaG_API.Entities;

namespace SiTaG_API.Mappings
{
    public class ProductMapping
    {
        public class ProductProfile : Profile
        {
            public ProductProfile()
            {
                CreateMap<Products, ReadProductDto>();
                CreateMap<CreateProductDto, Products>();
                CreateMap<UpdateProductDto, Products>();
            }
        }
    }
}
