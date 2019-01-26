using System.Windows.Controls;
using FLS.ViewModels;

namespace FLS.Pages
{
    /// <summary>
    /// Logique d'interaction pour SettingsPage.xaml
    /// </summary>
    public partial class AboutPage : UserControl
    {
        public AboutPage()
        {
            InitializeComponent();
            //var settingsViewModel = new SettingsViewModel();
            //DataContext = settingsViewModel;
            DataContext = new AboutPageViewModel();
        }
    }
}
