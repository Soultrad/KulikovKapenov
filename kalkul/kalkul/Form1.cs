using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            double value1 = Convert.ToDouble(textBox1.Text);
            double value2 = Convert.ToDouble(textBox2.Text);
            ITwoArgCalculator calculator = TwoArgumentFactory.CreateCalculator(((Button) sender).Name);
            double result=calculator.Calculate(value1,value2);
            switch (((Button)sender).Name)
            {
                case "plus":
                    result = value1 + value2;
                    break;
                case "minus":
                    result = value1 - value2;
                    break;
                case "ymno":
                    result = value1 * value2;
                    break;
                case "delenie":
                    result = value1 / value2;
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }


            textBox3.Text = Convert.ToString(result);
        }
    }
}
