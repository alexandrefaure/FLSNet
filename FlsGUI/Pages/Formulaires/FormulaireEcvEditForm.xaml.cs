using FLS.ViewModels.Formulaires;
using MahApps.Metro.Controls;

namespace FLS.Pages.Formulaires
{
    /// <summary>
    /// Logique d'interaction pour MedecinAppelantAddWindow.xaml
    /// </summary>
    public partial class FormulaireEcvEditForm : MetroWindow
    {
        public FormulaireEcvEditForm()
        {
            InitializeComponent();
            var viewModel = FormulaireEcvEditFormViewModel.Instance;
            DataContext = viewModel;
            viewModel.ClosingRequest += (sender, e) => Close();
        }
    }
}
