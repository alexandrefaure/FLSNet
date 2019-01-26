using System.Windows.Controls;
using FLS.ViewModels.Statistiques;

namespace FLS.Pages.Statistiques
{
    /// <summary>
    /// Logique d'interaction pour UsersPage.xaml
    /// </summary>
    public partial class ChartPieForm : UserControl
    {
        public ChartPieForm()
        {
            InitializeComponent();
            DataContext = ChartPieFormViewModel.Instance;
        }
    }
}
