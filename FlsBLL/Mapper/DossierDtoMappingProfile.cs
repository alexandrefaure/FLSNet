using AutoMapper;
using FlsCommon.DTO;
using FlsDAL;

namespace FlsBLL.Mapper
{
    public class DossierDtoMappingProfile : Profile
    {
        public DossierDtoMappingProfile()
        {
            CreateMap<dossiers, DossierDto>();
            CreateMap<DossierDto, dossiers>();
        }
    }
}
