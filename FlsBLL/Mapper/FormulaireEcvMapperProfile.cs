using FlsCommon.DTO;
using FlsDAL;

namespace FlsBLL.Mapper
{
    public class FormulaireEcvMapperProfile : FormulairesMapperProfile
    {
        public FormulaireEcvMapperProfile()
        {
            CreateMap<formulaire_ecv, FormulaireEcvDto>();
            CreateMap<FormulaireEcvDto, formulaire_ecv>();
        }
    }
}
