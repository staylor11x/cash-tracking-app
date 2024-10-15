using CashTrackingApp.ViewModels;

namespace CashTrackingApp.Views;

public partial class CashBalancePage : ContentPage
{
    public CashBalancePage(CashViewModel cashViewModel)
    {
        InitializeComponent();
        BindingContext = cashViewModel;
    }
}
