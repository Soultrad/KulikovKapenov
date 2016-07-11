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

      

        private void plus_Click_1(object sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(textBox1.Text);
            double value2 = Convert.ToDouble(textBox2.Text);

            double result = value1 + value2;

            textBox3.Text = Convert.ToString(result);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(textBox1.Text);
            double value2 = Convert.ToDouble(textBox2.Text);

            double result = value1 - value2;

            textBox3.Text = Convert.ToString(result);
        }

        private void delenie_Click(object sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(textBox1.Text);
            double value2 = Convert.ToDouble(textBox2.Text);

            double result = value1 / value2;

            textBox3.Text = Convert.ToString(result);
        }

        private void ymno_Click(object sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(textBox1.Text);
            double value2 = Convert.ToDouble(textBox2.Text);

            double result = value1 * value2;

            textBox3.Text = Convert.ToString(result);
        }
    }
}
