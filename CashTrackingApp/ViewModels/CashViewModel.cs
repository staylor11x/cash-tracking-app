using CashTrackingApp.Service;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CashTrackingApp.ViewModels
{
    public class CashViewModel : INotifyPropertyChanged
    {
        private double _balance;
        private readonly ICashService _cashService;

        public event PropertyChangedEventHandler? PropertyChanged;


        public CashViewModel(ICashService cashService)
        {
            _cashService = cashService;
            Balance = _cashService.GetBalance();
        }

        public CashViewModel() { }  //Default constructor, allows app to build

        public double Balance
        {
            get => _balance;
            set
            {
                if (_balance != value)
                {
                    _balance = value;
                    OnPropertyChanged();
                }
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
