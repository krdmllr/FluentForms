using FluentForms.FluentViews.Views;
using Xamarin.Forms;

namespace FluentForms.FluentViews
{
    public class FluentEntry : Entry, ITextElement
    {
        #region text element
        public void SetFontFamily(string font)
        {
            FontFamily = font;
        }

        public void SetFontAttribute(FontAttributes attribute)
        {
            FontAttributes = attribute;
        }

        public void SetFontSize(double size)
        {
            FontSize = size;
        }

        public void SetTextColor(Color color)
        {
            TextColor = color;
        }

        public void SetText(string text)
        {
            Text = text;
        }
        #endregion
    }
}