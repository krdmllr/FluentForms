using FluentForms.FluentViews.Views;
using Xamarin.Forms;

namespace FluentForms.Extensions
{
    public static class FluentTextExtensions
    {
        public static T Text<T>(this T builder, string text = null, double? size = null, Color? color = null, FontAttributes? fontAttribute = null, string fontFamily = null)
            where T : VisualElement, ITextElement
        {
            //Set text
            if(!string.IsNullOrEmpty(text))
                builder.SetText(text);

            //Set font size
            if(size.HasValue)
                builder.SetFontSize(size.Value);

            //Set font family
            if(!string.IsNullOrEmpty(fontFamily))
                builder.SetFontFamily(fontFamily);

            //Set font family font attribute
            if (fontAttribute.HasValue)
                builder.SetFontAttribute(fontAttribute.Value);

            //Set text color
            if (color.HasValue)
                builder.SetTextColor(color.Value);
            return builder;
        }
    }
}