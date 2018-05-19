using FluentForms.Builder;
using Xamarin.Forms;

namespace FluentForms.Extensions
{
    public static class FluentStackLayoutExtensions
    {
        //public static StackLayout Foo(this StackLayout layout)
        //{
        //    return layout;
        //}

        public static FluentLayoutBuilder Add(this StackLayout layout)
        {
            return new FluentLayoutBuilder(view => layout.Children.Add(view));
        }
    }
}