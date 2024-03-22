using AutoMapper;
using SiTaG_API.DTOs;
using SiTaG_API.Entities;
namespace SiTaG_API.Mappings
{
    public class ServiceTypeMapping
    {
        public class ServiceTypeProfile : Profile
        {
            public ServiceTypeProfile()
            {
                CreateMap<ServiceType, ReadServiceTypeDto>();
            }
        }
    }
}
