using SiTaG_API.DTOs;
using SiTaG_API.Entities;
using AutoMapper;
namespace SiTaG_API.Mappings
{
    public class CattleMapping
    {
        public class CattleProfile : Profile
        {
            public CattleProfile()
            {
                CreateMap<Cattles, ReadCattleDto>();
                CreateMap<CreateCattleDto, Cattles>();
                CreateMap<UpdateCattleDto, Cattles>();
            }
        }
    }
}
