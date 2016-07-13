using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using kalkul.Sorting;

namespace kalkul
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] stringArray = textBox1.Text.Split(' ');
                double[] unsortedArray = new double[stringArray.Length];
                for (int i = 0; i < stringArray.Length; i++)
                {
                    unsortedArray[i] = Convert.ToDouble(stringArray[i]);
                }
                ISort sorter = SortFactory.CreateSort(((Button)sender).Name);
                double[] result = sorter.Sort(unsortedArray);
                string stringResult = "";
                for (int i = 0; i < result.Length; i++)
                {
                    stringResult += " " + result[i];
                }
                textBox2.Text = stringResult;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Произошла ошибка:" + exc.Message);
            }
        }
    }
}
