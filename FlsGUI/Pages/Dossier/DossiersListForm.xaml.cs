using System.Windows.Controls;
using FLS.ViewModels.Dossiers;

namespace FLS.Pages.Dossier
{
    /// <summary>
    /// Logique d'interaction pour UsersPage.xaml
    /// </summary>
    public partial class DossiersListForm : UserControl
    {
        public DossiersListForm()
        {
            InitializeComponent();
            DataContext = DossiersListFormViewModel.Instance;
        }
    }
}
