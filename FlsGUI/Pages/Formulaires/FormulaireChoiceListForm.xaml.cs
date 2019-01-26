using FLS.ViewModels.Formulaires;
using MahApps.Metro.Controls;

namespace FLS.Pages.Formulaires
{
    /// <summary>
    /// Logique d'interaction pour MedecinAppelantAddWindow.xaml
    /// </summary>
    public partial class FormulaireChoiceListForm : MetroWindow
    {
        public FormulaireChoiceListForm()
        {
            InitializeComponent();
            var viewModel = FormulaireChoiceListFormViewModel.Instance;
            DataContext = viewModel;
            viewModel.ClosingRequest += (sender, e) => Close();
        }
    }
}
