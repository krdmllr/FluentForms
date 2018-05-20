using FluentForms.Extensions;
using FluentForms.FluentViews.Views;
using Xamarin.Forms;

namespace FluentForms.Demo.Pages
{
    public class CalculatorPage : ContentPage
    {
        int _currentState = 1;
        string _mathOperator;
        double _firstNumber, _secondNumber;
        Label _resultLabel;

        public CalculatorPage()
        {
            this.BackgroundColor(Color.Black).Title("Calculator").Padding(3)
                .GridContent(grid =>
                {
                    Button AddNumberButton(string number, int x, int y, int columnSpan = 1) => grid.Add(x, y, columnSpan: columnSpan).Button()
                        .Text(text: number, size: 36)
                        .BackgroundColor(Color.White).OnClicked(NumberSelected);

                    Button AddOperatorButton(string operator_, int x, int y, int columnSpan = 1) => grid.Add(x, y, columnSpan: columnSpan).Button()
                        .Text(text: operator_, size: 36)
                        .BackgroundColor(Color.FromRgb(0xff, 0xa5, 0)).OnClicked(OperatorSelected);

                    var test = new FluentButton().Margin(0);

                    grid.Add(columnSpan: 4).Label()
                        .Margin(5)
                        .TextAlign(hAlign: TextAlignment.End, vAlign: TextAlignment.Center)
                        .Text("0", size: 48, fontAttribute: FontAttributes.Bold, color: Color.White)
                        .Reference(out _resultLabel); //Row 0
                    AddNumberButton("7", 1, 0); //Row 1
                    AddNumberButton("8", 1, 1);
                    AddNumberButton("9", 1, 2);
                    AddOperatorButton("÷", 1, 3);
                    AddNumberButton("4", 2, 0); //Row 2
                    AddNumberButton("5", 2, 1);
                    AddNumberButton("6", 2, 2);
                    AddOperatorButton("x", 2, 3);
                    AddNumberButton("1", 3, 0); //Row 3
                    AddNumberButton("2", 3, 1);
                    AddNumberButton("3", 3, 2);
                    AddOperatorButton("-", 3, 3);
                    AddNumberButton("0", 4, 0, columnSpan: 3); //Row 4
                    AddOperatorButton("+", 4, 3);
                    AddOperatorButton("C", 5, 0).BackgroundColor(Color.LightGray); //Row 5
                    AddOperatorButton("=", 5, 1, columnSpan: 3);
                });
        }

        void NumberSelected(Button btn)
        {
            if (_resultLabel.Text == "0" || _currentState < 0)
            {
                _resultLabel.Text = "";
                if (_currentState < 0)
                    _currentState *= -1;
            }

            _resultLabel.Text += btn.Text;

            if (double.TryParse(_resultLabel.Text, out var number))
            {
                _resultLabel.Text = number.ToString("N0");
                if (_currentState == 1)
                    _firstNumber = number;
                else
                    _secondNumber = number;
            }
        }

        void OperatorSelected(Button btn)
        {
            switch (btn.Text)
            {
                case "C":
                    _currentState = 1;
                    _resultLabel.Text = "0";
                    break;
                case "=":
                    _firstNumber = Calculate(_firstNumber, _secondNumber, _mathOperator);
                    _resultLabel.Text = _firstNumber.ToString();
                    _currentState = -1;
                    break;
                default:
                    _currentState = -2;
                    _mathOperator = btn.Text;
                    break;
            }
        }

        private double Calculate(double value1, double value2, string mathOperator)
        {
            switch (mathOperator)
            {
                case "÷":
                    return value1 / value2;
                case "x":
                    return value1 * value2;
                case "+":
                    return value1 + value2;
                case "-":
                    return value1 - value2;
            }
            return 0;
        }
    }
}