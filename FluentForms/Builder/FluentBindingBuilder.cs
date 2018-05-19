using System;
using Xamarin.Forms;

namespace FluentForms.Builder
{
    public static partial class VisualElementExtensions
    {
        public class FluentBindingBuilder<T>
            where T : VisualElement
        {
            private readonly T _view;
            private readonly BindableProperty _targetProperty;
            private readonly string _path;
            private readonly BindingMode _mode;
            private IValueConverter _converter;
            private readonly string _stringFormat;

            public FluentBindingBuilder(T view,
                BindableProperty targetProperty,
                string path,
                BindingMode mode = BindingMode.Default,
                IValueConverter converter = null,
                string stringFormat = null)
            {
                _view = view;
                _targetProperty = targetProperty;
                _path = path;
                _mode = mode;
                _converter = converter;
                _stringFormat = stringFormat;
            }

            public FluentBindingBuilder<T> Convert<TIn>(Func<TIn, object> convert)
            {
                if (_converter != null)
                {
                    throw new Exception(
                        $"Failed to create converter for binding {_path}, value converter is already set.");
                }
                _converter = new GenericValueConverter<TIn, object>(convert);
                return this;
            }

            public FluentBindingBuilder<T> Convert(Func<object, object> convert)
            {
                if (_converter != null)
                {
                    throw new Exception(
                        $"Failed to create converter for binding {_path}, value converter is already set.");
                }
                _converter = new GenericValueConverter<object, object>(convert);
                return this;
            }

            public T Apply()
            {
                _view.SetBinding(_targetProperty, _path, _mode, _converter, _stringFormat);
                return _view;
            }
        }
    }
}