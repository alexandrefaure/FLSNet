using System.Windows.Input;
using FlsCommon.Utils;
using FLS.ViewModels.Dossiers;
using FLS.Windows;

namespace FLS.ViewModels.Statistiques
{
    public class PrononciationPhraseViewModel : BaseViewModel
    {
        private static PrononciationPhraseViewModel _instance = new PrononciationPhraseViewModel();

        public static PrononciationPhraseViewModel Instance
        {
            get
            {
                return _instance;
            }
        }
        private readonly DialogService _dialogService;
        public PrononciationPhraseViewModel()
        {
            _dialogService = new DialogService();
            //InitializeApplicationViewModels();
        }

        private object _selectedViewModel;

        public object SelectedViewModel

        {
            get
            {
                return _selectedViewModel;
            }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged("SelectedViewModel");
            }
        }

        private ICommand _exportCommand;

        public ICommand ExportCommand
        {
            get
            {
                return _exportCommand ?? (_exportCommand =
                           new SimpleCommand { CanExecuteDelegate = x => true, ExecuteDelegate = Export });
            }
        }



        private void Export(object obj)
        {
            //var selectedViewModel = SelectedViewModel as BaseChartViewModel;
            //if (selectedViewModel != null)
            //{
            //    selectedViewModel.ExportToExcel();
            //}
        }
    }
}
