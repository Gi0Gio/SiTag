using AutoMapper;
using SiTaG_API.DTOs;
using SiTaG_API.Entities;

namespace SiTaG_API.Mappings
{
    public class AnimalMapping
    {
        public class AnimalProfile : Profile
        {
            public AnimalProfile()
            {
                CreateMap<Animals, ReadAnimalDto>();
                CreateMap<AnimalCreateDto, Animals>();
                CreateMap<AnimalUpdateDto, Animals>();
            }
        }
    }
}
