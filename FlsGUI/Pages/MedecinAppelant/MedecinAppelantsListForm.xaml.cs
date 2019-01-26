using System.Windows.Controls;
using FLS.ViewModels.MedecinAppelants;

namespace FLS.Pages.MedecinAppelant
{
    /// <summary>
    /// Logique d'interaction pour UsersPage.xaml
    /// </summary>
    public partial class MedecinAppelantsListForm : UserControl
    {
        public MedecinAppelantsListForm()
        {
            InitializeComponent();
            DataContext = MedecinAppelantsListFormViewModel.Instance;
        }
    }
}
