using System.Collections.ObjectModel;
using FlsCommon;
using FlsCommon.DTO;
using FlsDAL.DAL;

namespace FlsBLL.BLL
{
    public class MedecinAppelantBLL
    {
        protected static MedecinAppelantBLL _current = new MedecinAppelantBLL();

        public static MedecinAppelantBLL Current
        {
            get
            {
                return _current;
            }
        }

        public ObservableCollection<MedecinAppelantDto> GetMedecinAppelantsList()
        {
            return MedecinAppelantsDAL.GetMedecinAppelantsList();
        }

        public OperationResult<MedecinAppelantDto> AddOrUpdateMedecinAppelant(MedecinAppelantDto medecinAppelant)
        {
            return MedecinAppelantsDAL.AddOrUpdateMedecinAppelant(medecinAppelant);
        }

        public OperationResult<MedecinAppelantDto> DeleteMedecinAppelant(MedecinAppelantDto medecinAppelant)
        {
            return MedecinAppelantsDAL.DeleteMedecinAppelant(medecinAppelant);
        }

        public OperationResult<MedecinAppelantDto> GetMedecinAppelantsById(int id)
        {
            return MedecinAppelantsDAL.GetMedecinAppelantById(id);
        }
    }
}