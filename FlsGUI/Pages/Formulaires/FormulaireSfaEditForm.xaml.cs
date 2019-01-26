using FLS.ViewModels.Formulaires;
using MahApps.Metro.Controls;

namespace FLS.Pages.Formulaires
{
    /// <summary>
    /// Logique d'interaction pour MedecinAppelantAddWindow.xaml
    /// </summary>
    public partial class FormulaireSfaEditForm : MetroWindow
    {
        public FormulaireSfaEditForm()
        {
            InitializeComponent();
            var viewModel = FormulaireSfaEditFormViewModel.Instance;
            DataContext = viewModel;
            viewModel.ClosingRequest += (sender, e) => Close();
        }
    }
}
