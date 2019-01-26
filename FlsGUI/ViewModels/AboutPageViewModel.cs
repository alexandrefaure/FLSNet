using System.ComponentModel;
using System.Runtime.CompilerServices;
using FlsCommon.FormValidation;
using FLS.Properties;

namespace FLS.ViewModels
{
    public class AboutPageViewModel : DataErrorInfo, INotifyPropertyChanged
    {
        public string LicenceExpirationDate { get; set; }
        public AboutPageViewModel()
        {
            LicenceExpirationDate = $"Expiration de la licence le : {App.LicenceExpirationDate}";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
