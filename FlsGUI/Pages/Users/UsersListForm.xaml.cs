using System.Windows.Controls;
using FLS.ViewModels.Users;

namespace FLS.Pages.Users
{
    /// <summary>
    /// Logique d'interaction pour UsersPage.xaml
    /// </summary>
    public partial class UsersListForm : UserControl
    {
        public UsersListForm()
        {
            InitializeComponent();
            DataContext = UsersListFormViewModel.Instance;
        }
    }
}
