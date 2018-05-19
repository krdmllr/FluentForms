using System;
using System.Globalization;
using Xamarin.Forms;

namespace FluentForms
{
    internal class GenericValueConverter<TIn, TOut> : IValueConverter
    {
        private readonly Func<TIn, TOut> _convert;

        public GenericValueConverter(Func<TIn, TOut> convert)
        {
            _convert = convert;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            if (value is TIn inValue)
            {
                return _convert(inValue);
            }
            throw new InvalidCastException($"Fluent value convertion failed {value.GetType()} is not a valid value to be converted.");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}