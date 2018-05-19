using System;
using Xamarin.Forms;

namespace FluentForms.Extensions
{
    public static class FluentButtonExtensions
    {
        //public static Button Foo(this Button view)
        //{
        //    return view;
        //}

        public static Button Border(this Button view, int? radius = 0, Color? color = null, double? width = null)
        {
            //Set corner radius
            if (radius.HasValue)
                view.CornerRadius = radius.Value;

            //Set border color
            if (color.HasValue)
                view.BorderColor = color.Value;

            //Set border color
            if (width.HasValue)
                view.BorderWidth = width.Value;
            return view;
        }

        public static Button OnClicked(this Button view, Action<Button> handler)
        {
            view.Command = new Command(() => handler(view));
            return view;
        }
        
        public static Button OnClicked(this Button view, EventHandler handler)
        {
            view.Clicked += handler;
            return view;
        }
    }
}