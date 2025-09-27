namespace LoginPage.Views.Users;
public partial class InitialPage : ContentPage
{
	public InitialPage()
	{
		InitializeComponent();
	}

   

    private async void login_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}