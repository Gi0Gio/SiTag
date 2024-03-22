using AutoMapper;
using SiTaG_API.DTOs;
using SiTaG_API.Entities;

namespace SiTaG_API.Mappings
{
    public class DivisionsXLotsMapping
    {
        public class DivisionsXLotsProfile : Profile
        {
            public DivisionsXLotsProfile()
            {
                CreateMap<DivisionxLots, ReadDivisionsXLotsDto>();
                CreateMap<CreateDivisionsXLotsDto, DivisionxLots>();
                CreateMap<UpdateDivisionsXLotsDto, DivisionxLots>();
            }
        }
    }
}
