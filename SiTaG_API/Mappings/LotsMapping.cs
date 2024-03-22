using AutoMapper;
using SiTaG_API.DTOs;
using SiTaG_API.Entities;
namespace SiTaG_API.Mappings
{
    public class LotsMapping
    {
        public class LotsProfile : Profile
        {
            public LotsProfile()
            {
                CreateMap<Lots, ReadLotsDto>();
                CreateMap<CreateLotsDto, Lots>();
                CreateMap<UpdateLotsDto, Lots>();
            }
        }
    }
}
