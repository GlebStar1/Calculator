using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{


    public partial class Calc_Form : Form
    {
        Double result_value = 0;
        String operator_perf = "";
        bool boloperator_perf = false;
        bool infinity_check = false;
        bool equalclick = false;
        bool cannot_div_by_zero = false;

        public Calc_Form()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }


        private void Button_Click(object sender, EventArgs e)
        {
            if (!infinity_check)
            {

                if ((TxtBox.Text == "0") || (boloperator_perf))
                    TxtBox.Clear();
                boloperator_perf = false;
                Button output = (Button)sender;

                if (output.Text == ".")
                {
                    if (!TxtBox.Text.Contains("."))
                        TxtBox.Text = TxtBox.Text + output.Text;
                }
                else if (equalclick == true && result_value >= 0 && cannot_div_by_zero == true)
                {
                    Global_Clr.PerformClick();
                    result_value = 0;
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
            if (!infinity_check)
            {
                Button output = (Button)sender;

                if (result_value != 0)
                {
                    Equal.PerformClick();
                    operator_perf = output.Text;
                    Label_Show.Text = result_value + " " + operator_perf;
                    boloperator_perf = true;

                }
                else if (TxtBox.Text.Length <= 0)
                {
                    TxtBox.Text = "0";
                    result_value = 0;
                }
                else
                {
                    operator_perf = output.Text;
                    result_value = Double.Parse(TxtBox.Text);
                    Label_Show.Text = result_value + " " + operator_perf;
                    boloperator_perf = true;
                }
            }
            else
            { Global_Clr.PerformClick(); }
        }

        private void Clr_Entry_Click(object sender, EventArgs e)
        {
            TxtBox.Text = "0";
        }

        private void Global_Clr_Click(object sender, EventArgs e)
        {
            infinity_check = false;
            TxtBox.Text = "0";
            result_value = 0;
            Label_Show.Text = "";
        }

        private void Equal_Click(object sender, EventArgs e)
        {

            if (!infinity_check)
            {
                switch (operator_perf)
                {

                    case "+":
                        TxtBox.Text = (result_value + Double.Parse(TxtBox.Text)).ToString();
                        break;
                    case "-":
                        TxtBox.Text = (result_value - Double.Parse(TxtBox.Text)).ToString();
                        break;
                    case "÷":
                        if (Double.Parse(TxtBox.Text) == 0)
                        {
                            TxtBox.Text = "Cannot divide by zero";
                            infinity_check = true;
                            cannot_div_by_zero = true;
                        }
                        else
                            TxtBox.Text = (result_value / Double.Parse(TxtBox.Text)).ToString();
                        break;
                    case "×":
                        TxtBox.Text = (result_value * Double.Parse(TxtBox.Text)).ToString();
                        break;
                    case "%":
                        TxtBox.Text = (result_value % Double.Parse(TxtBox.Text)).ToString();
                        break;
                    default:
                        break;
                     

                }
            }
            else
            {
                result_value = 0;
                TxtBox.Text = "0";
            } equalclick = true;


        }

        private void PlusMinus_Sign_Click(object sender, EventArgs e)
        {
            result_value = Double.Parse(TxtBox.Text) * -1;
            Label_Show.Text = "";
            TxtBox.Text = result_value.ToString();
        }

        private void Square_Root_Click(object sender, EventArgs e)
        {
            result_value = Math.Sqrt(Double.Parse(TxtBox.Text));
            Label_Show.Text = "√(" + TxtBox.Text + ")";
            TxtBox.Text = result_value.ToString();
        }

        private void Square_Click(object sender, EventArgs e)
        {
            result_value = (Double.Parse(TxtBox.Text) * (Double.Parse(TxtBox.Text)));
            Label_Show.Text = "Sqr(" + TxtBox.Text + ")";
            TxtBox.Text = result_value.ToString();
        }

        private void Multiplication_Inverse_Click(object sender, EventArgs e)
        {
            result_value = 1 / Double.Parse(TxtBox.Text);
            Label_Show.Text = "1/(" + TxtBox.Text + ")";
            TxtBox.Text = result_value.ToString();
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
