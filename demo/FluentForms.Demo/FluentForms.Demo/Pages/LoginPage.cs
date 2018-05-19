using FluentForms.Demo.ViewModels;
using FluentForms.Extensions;
using Xamarin.Forms;

namespace FluentForms.Demo.Pages
{
    public class LoginPage : ContentPage
    {
        public LoginPage()
        {
            this.Title("Login")
                .BindingContext(() => new LoginViewModel())
                .StackLayoutContent(sl =>
                {
                    sl.Margin(new Thickness(10, 50));
                    sl.Add().Label().Text("FluentForms", 36, fontAttribute: FontAttributes.Italic)
                        .TextAlign(TextAlignment.Center, TextAlignment.Center);
                    sl.Add().Label().Text("Username");
                    sl.Add().Entry().Placeholder("Username")
                        .Bind(Entry.TextProperty, "Username").Apply();
                    sl.Add().Label().Text("Password");
                    sl.Add().Entry().Placeholder("Password")
                        .Bind(Entry.TextProperty, nameof(LoginViewModel.Password)).Apply();
                    sl.Add().Label()
                        .Bind(Label.TextProperty, nameof(LoginViewModel.ErrorText), stringFormat: "Invalid input: {0}")
                        .Apply()
                        .Bind(Label.IsVisibleProperty, nameof(LoginViewModel.InputValid)).Convert<bool>(b => !b).Apply()
                        .Text(color: Color.DarkRed)
                        .Alignment(LayoutOptions.Center);
                    sl.Add().Button().Text("Login")
                        .OnClicked(btn => Navigation.PushAsync(new ProfilePage(BindingContext)))
                        .Bind(Button.IsEnabledProperty, nameof(LoginViewModel.InputValid)).Apply();
                });
        }
    }
}