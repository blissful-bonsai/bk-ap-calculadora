using System.Collections.Generic;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form
    {
        private Calculator calculator = new Calculator();
        private List<RichTextBox> richTextBoxes = new List<RichTextBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (Add.Checked)
            {
                decimal firstValueBoxDecimal = decimal.Parse(firstValueBox.Text);
                decimal secondValueBoxDecimal = decimal.Parse(secondValueBox.Text);
                decimal result;
                if (!string.IsNullOrEmpty(resultBox.Text))
                {
                    result = calculator.Sum(decimal.Parse(resultBox.Text), secondValueBoxDecimal);
                    resultBox.Text = result.ToString();
                }
                else
                {
                    result = calculator.Sum(firstValueBoxDecimal, secondValueBoxDecimal);
                    resultBox.Text = result.ToString();
                }
            }

            if (Sub.Checked)
            {
                decimal firstValueBoxDecimal = decimal.Parse(firstValueBox.Text);
                decimal secondValueBoxDecimal = decimal.Parse(secondValueBox.Text);
                decimal result;
                if (!string.IsNullOrEmpty(resultBox.Text))
                {
                    result = calculator.Sub(decimal.Parse(resultBox.Text), secondValueBoxDecimal);
                    resultBox.Text = result.ToString();
                }
                else
                {
                    result = calculator.Sub(firstValueBoxDecimal, secondValueBoxDecimal);
                    resultBox.Text = result.ToString();
                }
            }

            if (Mult.Checked)
            {
                decimal firstValueBoxDecimal = decimal.Parse(firstValueBox.Text);
                decimal secondValueBoxDecimal = decimal.Parse(secondValueBox.Text);
                decimal result;
                if (!string.IsNullOrEmpty(resultBox.Text))
                {
                    result = calculator.Multiplication(decimal.Parse(resultBox.Text), secondValueBoxDecimal);
                    resultBox.Text = result.ToString();
                }
                else
                {
                    result = calculator.Multiplication(firstValueBoxDecimal, secondValueBoxDecimal);
                    resultBox.Text = result.ToString();
                }
            }
            if (Div.Checked)
            {
                decimal firstValueBoxDecimal = decimal.Parse(firstValueBox.Text);
                decimal secondValueBoxDecimal = decimal.Parse(secondValueBox.Text);
                decimal result;
                if (resultBox.Text != "0")
                {
                    if (!string.IsNullOrEmpty(resultBox.Text))
                    {
                        result = calculator.Division(decimal.Parse(resultBox.Text), secondValueBoxDecimal);
                        resultBox.Text = result.ToString();
                    }
                    else
                    {
                        result = calculator.Division(firstValueBoxDecimal, secondValueBoxDecimal);
                        resultBox.Text = result.ToString();
                    }
                }
            }

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            //foreach (RichTextBox richTextBox in richTextBoxes)
            //{
            //    richTextBox.Text = "";
            //}
            resultBox.Text = "";
        }
    }
}
