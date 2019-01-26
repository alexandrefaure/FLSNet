using AutoMapper;
using FlsCommon.DTO;
using FlsDAL;

namespace FlsBLL.Mapper
{
    public class MedecinAppelantDtoMapperProfile : Profile
    {
        public MedecinAppelantDtoMapperProfile()
        {
            CreateMap<appelant_medecins, MedecinAppelantDto>();
            CreateMap<MedecinAppelantDto, appelant_medecins>();
        }
    }
}
