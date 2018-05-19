using Xamarin.Forms;

namespace FluentForms.FluentViews.Views
{
    public class FluentLabel : Label, ITextElement
    {
        #region set text properties
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