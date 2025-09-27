using LoginPage.ViewModels.Users;

namespace LoginPage.Views.Users;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = new LoginPageViewModel();
		
	}
}