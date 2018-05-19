using Xamarin.Forms;

namespace FluentForms.Extensions
{
    public static class FluentViewExtensions
    {
        public static T Alignment<T>(this T view, LayoutOptions? hAlign = null, LayoutOptions? vAlign = null)
            where T : View
        {
            if (hAlign.HasValue)
                view.HorizontalOptions = hAlign.Value;

            if (vAlign.HasValue)
                view.HorizontalOptions = vAlign.Value;
            return view;
        }

        public static T Margin<T>(this T view, Thickness thickness)
            where T : View
        {
            view.Margin = thickness;
            return view;
        }
    }
}