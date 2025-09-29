using LoginPage.ViewModels.Users;
using LoginPage.Views.Musicians;
using System.Threading.Tasks;

namespace LoginPage.Views.Users;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = new LoginPageViewModel();
		
	}

    private async void confirm_button_Clicked(object sender, EventArgs e)
    {
        try
        {
           await Shell.Current.GoToAsync("///MusicianHomePage");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}