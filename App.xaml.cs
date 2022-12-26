using PerfectPay.MVVM.Views;

namespace PerfectPay;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new PerfectPayPage();
	}
}
