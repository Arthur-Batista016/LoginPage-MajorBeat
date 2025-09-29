using CommunityToolkit.Mvvm.ComponentModel;
using LoginPage.Views.Musicians;
using System.Globalization;
using System.Windows.Input;

namespace LoginPage.ViewModels.Users
{
    public partial class LoginPageViewModel:ObservableObject
    {
        [ObservableProperty]
        private string userName;

        [ObservableProperty]
        private string userEmail;

        [ObservableProperty]
        private string userPassword;

        [ObservableProperty]
        private string message;

        [ObservableProperty]
        private string message2;

        [ObservableProperty]
        private Color emptyCredential = Color.FromArgb("#4F1271");

        [ObservableProperty]
        private Color credentialFilled = Color.FromArgb("#4F1271");

        [ObservableProperty]
        private string emptyEmail = "E-mail";

        [ObservableProperty]
        private string emptyPassword = "Senha";

        [ObservableProperty]
        private bool messageVisibility = false ;

        [ObservableProperty]
        private bool visibility = true;



        [ObservableProperty]
        private string hidePasswordImage = "openeye.png";

        [ObservableProperty]
        private bool isPassword = true;

        private int count;

        public ICommand RemoveCommand { get; set; }
        public ICommand VerifyCredentialsCommand { get; set; }

        public ICommand HidePasswordCommand { get; set; }


        public LoginPageViewModel()
        {
            InicializarCommands();
        }

        public void InicializarCommands()
        {

            VerifyCredentialsCommand = new Command(async () => await VerificarCredenciais());
            HidePasswordCommand = new Command(async () => await hidePassword());
        }

        public async Task VerificarCredenciais()
        {
           

            if (UserEmail == "eduardoqueiroz@gmail.com" && UserPassword == "123456")
            {
                UserName = "Eduardo Queiroz";
                Message = "Login Realizado com sucesso!";
                Message2 = "Seja Bem Vindo Ao Major Beat! " + UserName;
                MessageVisibility = true;
                EmptyCredential = Color.FromArgb("#4F1271");
                CredentialFilled = Color.FromArgb("#4F1271");
                EmptyPassword = "Senha";
                EmptyEmail = "E-mail";

                hideEverything();
                
            }

            else if (UserEmail != "eduardoqueiroz@gmail.com" && UserPassword != "123456")
            {
                EmptyCredential = Color.FromArgb("#EA1313");
                CredentialFilled = Color.FromArgb("#EA1313");
                EmptyEmail = "Email inválido inserido!";
                EmptyPassword = "Senha incorreta";
                UserEmail = "";
                UserPassword = "";
            }

            else if(UserEmail != "eduardoqueiroz@gmail.com")
            {
                EmptyCredential = Color.FromArgb("#EA1313");
                CredentialFilled = Color.FromArgb("#4F1271");
                EmptyEmail = "Email inválido inserido!";
                EmptyPassword = "Senha";
                UserEmail = "";
                UserPassword = "";
            }

            else if(UserPassword != "123456")
            {
                EmptyCredential = Color.FromArgb("#4F1271");
                CredentialFilled = Color.FromArgb("#EA1313");
                EmptyPassword = "Senha incorreta!";
                EmptyEmail = "E-mail";
                UserPassword = "";
                UserEmail = "";
            }

         


        }

        

        public async Task hidePassword()
        {

            IsPassword = !IsPassword;

            if (isPassword)
                HidePasswordImage = "Openeye.png";
            else
                HidePasswordImage = "closedeye.png";

        }

        public async Task hideEverything()
        {
            Visibility = false;
        }


    }
}
