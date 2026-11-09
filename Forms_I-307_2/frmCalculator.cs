using System;
using System.Windows.Forms;

namespace Forms_I_307_2
{
    public partial class frmCalculator : Form
    {
        double num1 = 0;
        double num2 = 0;
        string znak = "";
        double result = 0;
        bool flag = true;

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (flag)
            {
                textBox1.Text = btn.Text;
                flag = false;
            }
            else
            {
                textBox1.Text += btn.Text;
            }
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                textBox1.Text = "0,";
                flag = false;
            }
            else if (!textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = double.Parse(textBox1.Text.Replace(".", ","));
                znak = "+";
                textBox1.Text = "";
                flag = true;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = double.Parse(textBox1.Text.Replace(".", ","));
                znak = "-";
                textBox1.Text = "";
                flag = true;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = double.Parse(textBox1.Text.Replace(".", ","));
                znak = "*";
                textBox1.Text = "";
                flag = true;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = double.Parse(textBox1.Text.Replace(".", ","));
                znak = "/";
                textBox1.Text = "";
                flag = true;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && znak != "")
            {
                num2 = double.Parse(textBox1.Text.Replace(".", ","));

                if (znak == "+") { result = num1 + num2; }
                else if (znak == "-") { result = num1 - num2; }
                else if (znak == "*") { result = num1 * num2; }
                else if (znak == "/")
                {
                    if (num2 == 0)
                    {
                        textBox1.Text = "Ошибка";
                        flag = true;
                        return;
                    }
                    result = num1 / num2;
                }

                textBox1.Text = result.ToString().Replace(".", ",");
                flag = true;
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num2 = double.Parse(textBox1.Text.Replace(".", ","));
                result = num2 / 100;
                textBox1.Text = result.ToString().Replace(".", ",");
                flag = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            num1 = 0;
            num2 = 0;
            znak = "";
            result = 0;
            flag = true;
        }
    }
}
