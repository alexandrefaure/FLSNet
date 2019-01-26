using System.Windows.Controls;
using FLS.ViewModels.Statistiques;

namespace FLS.Pages.Statistiques
{
    /// <summary>
    /// Logique d'interaction pour UsersPage.xaml
    /// </summary>
    public partial class ChartHistogramForm : UserControl
    {
        public ChartHistogramForm()
        {
            InitializeComponent();
            DataContext = ChartHistogramFormViewModel.Instance;
        }
    }
}
