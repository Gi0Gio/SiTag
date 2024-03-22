using AutoMapper;
using SiTaG_API.DTOs;
using SiTaG_API.Entities;
namespace SiTaG_API.Mappings
{
    public class CattleXDivisionMapping
    {
        public class CattleXDivisionProfile : Profile
        {
            public CattleXDivisionProfile()
            {
                CreateMap<CattlesxDivision, ReadCattleXDivision>();
                CreateMap<CreateCattleXDivision, CattlesxDivision>();
                CreateMap<UpdateCattleXDivision, CattlesxDivision>();
            }
        }
    }
    
}
