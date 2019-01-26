using FlsCommon.DTO;
using FlsDAL;

namespace FlsBLL.Mapper
{
    public class FormulaireActMapperProfile : FormulairesMapperProfile
    {
        public FormulaireActMapperProfile()
        {
            CreateMap<formulaire_act, FormulaireActDto>();
            CreateMap<FormulaireActDto, formulaire_act>();
        }
    }
}
