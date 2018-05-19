using System;
using FluentForms.FluentViews;
using FluentForms.FluentViews.Views;
using Xamarin.Forms;

namespace FluentForms.Builder
{
    public class FluentLayoutBuilder
    {
        private readonly Action<View> _view;

        public FluentLayoutBuilder(Action<View> view)
        {
            _view = view;
        }

        public T View<T>(Func<T> viewCreation, Action<T> viewInstance = null)
            where T : View
        {
            var view = viewCreation();
            viewInstance?.Invoke(view);
            _view(view);
            return view;
        }

        public T View<T>(T view, Action<T> viewInstance = null)
            where T : View
        {
            viewInstance?.Invoke(view);
            _view(view);
            return view;
        }

        #region views


        public FluentEntry Entry(Action<FluentEntry> viewInstance = null)
        {
            var entry = new FluentEntry();
            viewInstance?.Invoke(entry);
            _view(entry);
            return entry;
        }

        public FluentLabel Label(Action<FluentLabel> viewInstance = null)
        {
            var builder = new FluentLabel();
            viewInstance?.Invoke(builder);
            _view(builder);
            return builder;
        }

        public FluentButton Button(Action<FluentButton> viewInstance = null)
        {
            var builder = new FluentButton();
            viewInstance?.Invoke(builder);
            _view(builder);
            return builder;
        }
        #endregion
    }
}