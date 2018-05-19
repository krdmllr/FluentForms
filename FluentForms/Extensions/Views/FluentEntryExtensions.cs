using Xamarin.Forms;

namespace FluentForms.Extensions
{
    public static class FluentEntryExtensions
    {
        //public static Entry Foo(this Entry view)
        //{
        //    return view;
        //}

        public static T HorizontalAlign<T>(this T view, TextAlignment alignment)
            where T : Entry
        {
            //Set horizontal alignment
            view.HorizontalTextAlignment = alignment;
            return view;
        }

        public static T Placeholder<T>(this T view, string placeholder)
            where T : Entry
        {
            view.Placeholder = placeholder;
            return view;
        }
    }
}