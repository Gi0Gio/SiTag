using AutoMapper;
using SiTaG_API.DTOs;
using SiTaG_API.Entities;
namespace SiTaG_API.Mappings
{
    public class ApplicationMapping
    {
        public class ApplicationProfile : Profile
        {
            public ApplicationProfile()
            {
                CreateMap<ApplicationMethods, ReadApplicationDto>();
            }
        }
    }
}
