using PerfectPay.MVVM.ViewModels;

namespace PerfectPay.MVVM.Views;

public partial class PerfectPayPage : ContentPage
{
	public PerfectPayPage()
	{
		InitializeComponent();

		BindingContext = new  PerfectPayVM();
	}
}