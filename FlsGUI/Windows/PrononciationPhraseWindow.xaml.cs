using FLS.ViewModels.Statistiques;
using MahApps.Metro.Controls;

namespace FLS.Windows
{
    /// <summary>
    ///     Logique d'interaction pour Window.xaml
    /// </summary>
    public partial class PrononciationPhraseWindow : MetroWindow
    {
        public PrononciationPhraseWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            var viewModel = PrononciationPhraseViewModel.Instance;
            DataContext = viewModel;
        }
    }
}