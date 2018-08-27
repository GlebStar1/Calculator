using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalcForm : Form
    {
        Double _resultValue;
        String _operatorPerf = "";
        bool _boloperatorPerf;
        bool _infinityCheck;
        bool _equalclick;
        bool _cannotDivByZero;

        public CalcForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }


        private void Button_Click(object sender, EventArgs e)
        {
            if (!_infinityCheck)
            {

                if ((TxtBox.Text == "0") || (_boloperatorPerf))
                    TxtBox.Clear();
                _boloperatorPerf = false;
                Button output = (Button)sender;

                if (output.Text == ".")
                {
                    if (!TxtBox.Text.Contains("."))
                        TxtBox.Text = TxtBox.Text + output.Text;
                }
                else if (_equalclick && _resultValue >= 0 && _cannotDivByZero)
                {
                    Global_Clr.PerformClick();
                    _resultValue = 0;
                    Label_Show.Text = "";
                    TxtBox.Text = output.Text;
                }
                else
                    TxtBox.Text = TxtBox.Text + output.Text;
            }
            else
            {
                Global_Clr.PerformClick();
            }
        }

        private void Operation_Perf(object sender, EventArgs e)
        {
            if (!_infinityCheck)
            {
                Button output = (Button)sender;

                if (_resultValue != 0)
                {
                    Equal.PerformClick();
                    _operatorPerf = output.Text;
                    Label_Show.Text = _resultValue + " " + _operatorPerf;
                    _boloperatorPerf = true;

                }
                else if (TxtBox.Text.Length <= 0)
                {
                    TxtBox.Text = "0";
                    _resultValue = 0;
                }
                else
                {
                    _operatorPerf = output.Text;
                    _resultValue = Double.Parse(TxtBox.Text);
                    Label_Show.Text = _resultValue + " " + _operatorPerf;
                    _boloperatorPerf = true;
                }
            }
            else
            {
                Global_Clr.PerformClick();
            }
        }

        private void Clr_Entry_Click(object sender, EventArgs e)
        {
            TxtBox.Text = "0";
        }

        private void Global_Clr_Click(object sender, EventArgs e)
        {
            _infinityCheck = false;
            TxtBox.Text = "0";
            _resultValue = 0;
            Label_Show.Text = "";
        }

        private void Equal_Click(object sender, EventArgs e)
        {

            if (!_infinityCheck)
            {
                switch (_operatorPerf)
                {

                    case "+":
                        TxtBox.Text = (_resultValue + Double.Parse(TxtBox.Text)).ToString();
                        break;
                    case "-":
                        TxtBox.Text = (_resultValue - Double.Parse(TxtBox.Text)).ToString();
                        break;
                    case "÷":
                        if (Double.Parse(TxtBox.Text) == 0)
                        {
                            TxtBox.Text = "Cannot divide by zero";
                            _infinityCheck = true;
                            _cannotDivByZero = true;
                        }
                        else
                            TxtBox.Text = (_resultValue / Double.Parse(TxtBox.Text)).ToString();
                        break;
                    case "×":
                        TxtBox.Text = (_resultValue * Double.Parse(TxtBox.Text)).ToString();
                        break;
                    case "%":
                        TxtBox.Text = (_resultValue % Double.Parse(TxtBox.Text)).ToString();
                        break;
                }
            }
            else
            {
                _resultValue = 0;
                TxtBox.Text = "0";
            }
            _equalclick = true;


        }

        private void PlusMinus_Sign_Click(object sender, EventArgs e)
        {
            _resultValue = Double.Parse(TxtBox.Text) * -1;
            Label_Show.Text = "";
            TxtBox.Text = _resultValue.ToString();
        }

        private void Square_Root_Click(object sender, EventArgs e)
        {
            _resultValue = Math.Sqrt(Double.Parse(TxtBox.Text));
            Label_Show.Text = "√(" + TxtBox.Text + ")";
            TxtBox.Text = _resultValue.ToString();
        }

        private void Square_Click(object sender, EventArgs e)
        {
            _resultValue = (Double.Parse(TxtBox.Text) * (Double.Parse(TxtBox.Text)));
            Label_Show.Text = "Sqr(" + TxtBox.Text + ")";
            TxtBox.Text = _resultValue.ToString();
        }

        private void Multiplication_Inverse_Click(object sender, EventArgs e)
        {
            _resultValue = 1 / Double.Parse(TxtBox.Text);
            Label_Show.Text = "1/(" + TxtBox.Text + ")";
            TxtBox.Text = _resultValue.ToString();
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text.Length <= 0)
            {
                TxtBox.Text = "0";
            }
            else
            {
                TxtBox.Text = TxtBox.Text.Remove(TxtBox.Text.Length - 1, 1);
            }
        }
    }
}
