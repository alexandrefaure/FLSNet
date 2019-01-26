using System.Windows.Input;
using FLS.ViewModels.Statistiques;
using UserControl = System.Windows.Controls.UserControl;

namespace FLS.Pages.Statistiques
{
    /// <summary>
    /// Logique d'interaction pour UsersPage.xaml
    /// </summary>
    public partial class ChartsListForm : UserControl
    {
        public ChartsListForm()
        {
            InitializeComponent();
            DataContext = ChartsListFormViewModel.Instance;
        }

        private void Control_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (((ChartsListFormViewModel)DataContext).GenerateChartCommand.CanExecute(null))
            {
                ((ChartsListFormViewModel)DataContext).GenerateChartCommand.Execute(null);
            }
        }
    }
}
