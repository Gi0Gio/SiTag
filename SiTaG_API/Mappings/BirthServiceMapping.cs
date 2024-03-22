using AutoMapper;
using SiTaG_API.DTOs;
using SiTaG_API.Entities;
namespace SiTaG_API.Mappings
{
    public class BirthServiceMapping
    {
        public class BirthServiceProfile : Profile
        {
            public BirthServiceProfile()
            {
                CreateMap<BirthServices, ReadBirthServicesDto>();
            }
        }
    }
}
