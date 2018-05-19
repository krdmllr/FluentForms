using Xamarin.Forms;

namespace FluentForms.Extensions
{
    public static class FluentLabelExtensions
    {
        //public static Label Foo(this Label view)
        //{
        //    return view;
        //}

        public static T TextAlign<T>(this T view, TextAlignment? hAlign = null, TextAlignment? vAlign = null)
            where T : Label
        {
            //Set horizontal alignment
            if (hAlign.HasValue)
                view.HorizontalTextAlignment = hAlign.Value;

            //Set vertical alignment
            if (vAlign.HasValue)
                view.VerticalTextAlignment = vAlign.Value;

            return view;
        }
}
}