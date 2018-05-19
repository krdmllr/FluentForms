using FluentForms.Demo.Pages;
using FluentForms.Extensions;
using Xamarin.Forms;

namespace FluentForms.Demo
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();

            //return; //uncomment this to show the calculator app :)
            MainPage = new TabbedPage
            {
                Children =
                {
                    new LoginPage(),
                    new CalculatorPage()
                    //TODO More samples
                }
            }.Title("FluentForms samples").InsideNavigationPage();
        }
    }
}
