using AutoMapper;
using SiTaG_API.DTOs;
using SiTaG_API.Entities;
namespace SiTaG_API.Mappings
{
    public class DivisionsMapping
    {
        public class DivisionProfile : Profile
        {
            public DivisionProfile()
            {
                CreateMap<Divisions, ReadDivisionDto>();
                CreateMap<CreateDivisionDto, Divisions>();
                CreateMap<UpdateDivisionDto, Divisions>();
            }
        }
    }
}
