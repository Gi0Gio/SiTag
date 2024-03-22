using AutoMapper;
using SiTaG_API.DTOs;
using SiTaG_API.Entities;
namespace SiTaG_API.Mappings
{
    public class HealthStatusMapping
    {
        public class HealthStatusProfile : Profile
        {
            public HealthStatusProfile()
            {
                CreateMap<HealthStatuses, ReadHealthStatusDto>();
            }
        }
    }
}
