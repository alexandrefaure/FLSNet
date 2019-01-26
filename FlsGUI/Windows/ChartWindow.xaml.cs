using FLS.ViewModels.Statistiques;
using MahApps.Metro.Controls;

namespace FLS.Windows
{
    /// <summary>
    ///     Logique d'interaction pour Window.xaml
    /// </summary>
    public partial class ChartWindow : MetroWindow
    {
        public ChartWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            var viewModel = ChartWindowViewModel.Instance;
            DataContext = viewModel;
            //Closing += viewModel.OnWindowClosing;
        }

        //private void CloseCommandHandler(object sender, ExecutedRoutedEventArgs e)
        //{
        //    Close();
        //}
    }
}