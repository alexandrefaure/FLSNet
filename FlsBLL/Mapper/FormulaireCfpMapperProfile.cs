using FlsCommon.DTO;
using FlsDAL;

namespace FlsBLL.Mapper
{
    public class FormulaireCfpMapperProfile : FormulairesMapperProfile
    {
        public FormulaireCfpMapperProfile()
        {
            CreateMap<formulaire_cfp, FormulaireCfpDto>();
            CreateMap<FormulaireCfpDto, formulaire_cfp>();
        }
    }
}
