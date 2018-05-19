using PropertyChanged;
using Xamarin.Forms;

namespace FluentForms.Demo.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        [AlsoNotifyFor(nameof(InputValid))]
        public string Password { get; set; }

        [AlsoNotifyFor(nameof(InputValid))]
        public string Username { get; set; }

        public string ErrorText { get; set; }

        public Command LoginCommand => new Command(Login);

        public bool InputValid => Validate();

        private void Login()
        {
            if (!InputValid)
                return;

            //Input valid
        }

        private bool Validate()
        {
            if (string.IsNullOrEmpty(Username))
            {
                ErrorText = "You need to set a username.";
                return false;
            }
            if (string.IsNullOrEmpty(Password))
            {
                ErrorText = "You need to set a password.";
                return false;
            }
            ErrorText = "Actually everything is fine ...";
            return true;
        }
    }
}