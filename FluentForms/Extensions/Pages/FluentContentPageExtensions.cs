using System;
using Xamarin.Forms;

namespace FluentForms.Extensions
{
    public static class FluentContentPageExtensions
    {
        public static T Content<T>(this T page, Func<View> view, Action<View> content = null)
            where T : ContentPage
        {
            var pageContent = view();
            content?.Invoke(pageContent);
            page.Content = pageContent;
            return page;
        }

        public static T Content<T>(this T page, View view, Action<View> content = null)
            where T : ContentPage
        { 
            content?.Invoke(view);
            page.Content = view;
            return page;
        }

        public static T GridContent<T>(this T page, Action<Grid> grid = null)
            where T : ContentPage
        {
            var content = new Grid();
            grid?.Invoke(content);
            page.Content = content;
            return page;
        }

        public static T StackLayoutContent<T>(this T page, Action<StackLayout> grid = null)
            where T : ContentPage
        {
            var content = new StackLayout();
            grid?.Invoke(content);
            page.Content = content;
            return page;
        }
    }
}