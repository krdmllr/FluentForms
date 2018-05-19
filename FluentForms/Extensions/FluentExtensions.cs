using System;
using Xamarin.Forms;

namespace FluentForms.Extensions
{
    public static class FluentExtensions
    {
        #region set binding context
        public static T BindingContext<T>(this T element, Func<object> context)
            where T : Element
        {
            element.BindingContext = context();
            return element;
        }

        public static T BindingContext<T>(this T element, object context)
            where T : Element
        {
            element.BindingContext = context;
            return element;
        }
        #endregion

        public static T BackgroundColor<T>(this T view, Color color)
            where T : VisualElement
        {
            view.BackgroundColor = color;
            return view;
        }

        public static TView Reference<TView, TRef>(this TView view, out TRef reference)
            where TView : VisualElement, TRef
        {
            reference = (TRef)view;
            return view;
        }

        #region binding
        public static Builder.VisualElementExtensions.FluentBindingBuilder<T> Bind<T>(this T view,
            BindableProperty targetProperty,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            string stringFormat = null)
            where T : VisualElement
        {
            if (targetProperty == null)
                throw new ArgumentNullException(nameof(targetProperty));
            if (path == null)
                throw new ArgumentNullException(nameof(path));

            return new Builder.VisualElementExtensions.FluentBindingBuilder<T>(view, targetProperty, path, mode, converter, stringFormat);
        }
        #endregion
    }
}