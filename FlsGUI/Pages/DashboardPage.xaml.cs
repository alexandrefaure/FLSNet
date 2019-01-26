using System.Windows.Controls;
using FLS.ViewModels;

namespace FLS.Pages
{
    /// <summary>
    /// Logique d'interaction pour DashboardPage.xaml
    /// </summary>
    public partial class DashboardPage : UserControl
    {
        public DashboardPage()
        {
            InitializeComponent();
            DataContext = DashboardPageViewModel.Instance;
        }
    }
}
