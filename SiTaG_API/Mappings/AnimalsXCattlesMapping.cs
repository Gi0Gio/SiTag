using AutoMapper;
using SiTaG_API.DTOs;
using SiTaG_API.Entities;
namespace SiTaG_API.Mappings
{
    public class AnimalsXCattlesMapping
    {
        public class AnimalsXCattleProfile : Profile
        {
            public AnimalsXCattleProfile()
            {
                CreateMap<AnimalsxCattles, ReadAnimalsXCattlesDto>();
                CreateMap<CreateAnimalsXCattlesDto, AnimalsxCattles>();
                CreateMap<UpdateAnimalsXCattlesDto, AnimalsxCattles>();
            }
        }
    }
}
