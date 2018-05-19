using FluentForms.Demo.ViewModels;
using FluentForms.Extensions;
using Xamarin.Forms;

namespace FluentForms.Demo.Pages
{
    public class ProfilePage : ContentPage
    {
        public ProfilePage(object loginContext)
        {
            BindingContext = loginContext;
            Title = "Profile";

            //Fluent code (6 lines)
            this.StackLayoutContent(sl =>
                {
                    sl.Margin(new Thickness(5, 50));
                    sl.Add().Label().Text(size: 36, color: Color.MediumPurple).TextAlign(TextAlignment.Center)
                        .Bind(Label.TextProperty, nameof(LoginViewModel.Username), stringFormat: "Hello, {0} :)").Apply();
                });

            //Normal code (14 lines)
            //var usernameLabel = new Label
            //{
            //    FontSize = 36,
            //    TextColor = Color.MediumPurple
            //};
            //usernameLabel.SetBinding(Label.TextProperty, nameof(LoginViewModel.Username), stringFormat: "Hello, {0} :)");
            //Content = new StackLayout
            //{
            //    Margin = new Thickness(5, 50),
            //    Children =
            //    {
            //        usernameLabel
            //    }
            //};
        }
    }
}