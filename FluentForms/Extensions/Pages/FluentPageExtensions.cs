using Xamarin.Forms;

namespace FluentForms.Extensions
{
    public static class FluentPageExtensions
    {
        public static T Padding<T>(this T page, Thickness thickness)
            where T : Page
        {
            page.Padding = thickness;
            return page;
        }

        public static T Title<T>(this T page, string title)
            where T : Page
        {
            page.Title = title;
            return page;
        }

        public static NavigationPage InsideNavigationPage<T>(this T page)
            where T : Page
        {
            return new NavigationPage(page);
        }
    }
}