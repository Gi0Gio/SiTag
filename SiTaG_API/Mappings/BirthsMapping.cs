using SiTaG_API.DTOs;
using SiTaG_API.Entities;
using AutoMapper;

namespace SiTaG_API.Mappings
{
    public class BirthsMapping
    {
        public class BirthProfile : Profile
        {
            public BirthProfile()
            {
                CreateMap<Births, ReadBirthDto>();
                CreateMap<CreateBirthDto, Births>();
                CreateMap<UpdateBirthDto, Births>();
            }
        }
    }
}
