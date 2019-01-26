using FlsCommon.DTO;
using FlsDAL;

namespace FlsBLL.Mapper
{
    public class FormulaireSfaMapperProfile : FormulairesMapperProfile
    {
        public FormulaireSfaMapperProfile()
        {
            CreateMap<formulaire_sfa, FormulaireSfaDto>();
            CreateMap<FormulaireSfaDto, formulaire_sfa>();
        }
    }
}
