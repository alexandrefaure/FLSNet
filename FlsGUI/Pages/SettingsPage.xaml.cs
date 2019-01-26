using System.Windows.Controls;
using FLS.ViewModels;

namespace FLS.Pages
{
    /// <summary>
    /// Logique d'interaction pour SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : UserControl
    {
        public SettingsPage()
        {
            InitializeComponent();
            var settingsViewModel = new SettingsViewModel();
            //foreach (var themeColor in settingsViewModel.ThemeColors)
            //{
            //    Combobox.Items.Add(themeColor);
            //}

       
            DataContext = settingsViewModel;
        }
    }
}
