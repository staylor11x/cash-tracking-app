using System.ComponentModel;

namespace CashTrackingApp.ViewModels
{
    public class CashViewModel : INotifyPropertyChanged
    {
        private double _balance;

        public double Balance
        {
            get => _balance;
            set
            {
                _balance = value;
                OnPropertyChanged(nameof(Balance));
            }
        }

        public CashViewModel()
        {
            // Hard-coded balance for now
            Balance = 100.00;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
