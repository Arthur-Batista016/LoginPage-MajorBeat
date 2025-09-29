using LoginPage.ViewModels.Users;

namespace LoginPage.Views.Musicians;

public partial class MusicianSearchPage : ContentPage
{
    private SearchBarViewModel Vm => BindingContext as SearchBarViewModel;
    public MusicianSearchPage()
	{
		InitializeComponent();
        BindingContext = new SearchBarViewModel();
    }

    private void searchBar_Focused(object sender, FocusEventArgs e)
    {
        Vm?.onFocus();
    }

    private void searchBar_Unfocused(object sender, FocusEventArgs e)
    {
        Vm.onUnfocus();
    }

    private async void home_page_btn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MusicianHomePage());
    }

}