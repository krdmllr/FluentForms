using FluentForms.Builder;
using Xamarin.Forms;

namespace FluentForms.Extensions
{
    public static class FluentGridLayoutExtensions
    {
        //public static Grid Foo(this Grid grid)
        //{
        //    return grid;
        //}

        public static FluentLayoutBuilder Add(this Grid grid)
        {
            var smartBuilder = new FluentLayoutBuilder(view => { grid.Children.Add(view); });
            return smartBuilder;
        }

        public static FluentLayoutBuilder Add(this Grid grid, int row = 0, int column = 0, int rowSpan = 1, int columnSpan = 1)
        {
            var smartBuilder = new FluentLayoutBuilder(view =>
            {
                grid.Children.Add(view, left: column, right: column + columnSpan, top: row, bottom: row + rowSpan);
            });
            return smartBuilder;
        }
    }
}