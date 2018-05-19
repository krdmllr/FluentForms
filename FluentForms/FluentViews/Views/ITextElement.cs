using Xamarin.Forms;

namespace FluentForms.FluentViews.Views
{
    public interface ITextElement
    {
        void SetFontFamily(string font);
        void SetFontAttribute(FontAttributes attribute);
        void SetFontSize(double size);
        void SetTextColor(Color color);
        void SetText(string text);
    }
}