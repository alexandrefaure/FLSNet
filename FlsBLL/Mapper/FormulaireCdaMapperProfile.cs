using FlsCommon.DTO;
using FlsDAL;

namespace FlsBLL.Mapper
{
    public class FormulaireCdaMapperProfile : FormulairesMapperProfile
    {
        public FormulaireCdaMapperProfile()
        {
            CreateMap<formulaire_cda, FormulaireCdaDto>();
            CreateMap<FormulaireCdaDto, formulaire_cda>();
        }
    }
}
