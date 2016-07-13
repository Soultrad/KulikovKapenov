using System;
using System.Windows.Forms;
using kalkul.OneArgumentFunction;
using kalkul.TwoArgumentFunction;

namespace kalkul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                double firstValue = Convert.ToDouble(textBox1.Text.Replace(".", ","));
                double secondValue = Convert.ToDouble(textBox2.Text.Replace(".", ","));
                ITwoArgCalculator calculator = TwoArgumentFactory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(firstValue, secondValue);
                textBox3.Text = Convert.ToString(result);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Произошла ошибка:" + exc.Message);
            }
        }

        private void sin_Click(object sender, EventArgs e)
        {
            try
            {
                double firstValue = Convert.ToDouble(textBox1.Text.Replace(".", ","));
                IOneArgCalculator calculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(firstValue);
                textBox3.Text = Convert.ToString(result);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Произошла ошибка:" + exc.Message);
            }
        }
    }
}
