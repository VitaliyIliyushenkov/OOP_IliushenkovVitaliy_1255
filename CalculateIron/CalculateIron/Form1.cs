using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateIron
{
    public partial class Form1 : Form
    {
        int[] result = new int[2];
        int del;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = "Error";
            else if (textBox4.Text == "0")
                textBox4.Text = "Error";
            else
            {
                result[0] = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox4.Text)
                                + Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox2.Text);
                result[1] = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox4.Text);
                do
                {
                    del = Euclids_algorithm(result[0], result[1]);
                    result[0] /= del;
                    result[1] /= del;
                }
                while (del != 1);
                numerator.Text = result[0].ToString();
                denominator.Text = result[1].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = "Error";
            else if (textBox4.Text == "0")
                textBox4.Text = "Error";
            else
            {
                result[0] = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox4.Text)
                                    - Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox2.Text);
                result[1] = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox4.Text);
                do
                {
                    del = Euclids_algorithm(result[0], result[1]);
                    result[0] /= del;
                    result[1] /= del;
                }
                while (del != 1);
                numerator.Text = result[0].ToString();
                denominator.Text = result[1].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = "Error";
            else if (textBox4.Text == "0")
                textBox4.Text = "Error";
            else
            {
                result[0] = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox3.Text);
                result[1] = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox4.Text);
                do
                {
                    del = Euclids_algorithm(result[0], result[1]);
                    result[0] /= del;
                    result[1] /= del;
                }
                while (del != 1);
                numerator.Text = result[0].ToString();
                denominator.Text = result[1].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = "Error";
            else if (textBox4.Text == "0")
                textBox4.Text = "Error";
            else
            {
                result[0] = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox4.Text);
                result[1] = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox3.Text);
                do
                {
                    del = Euclids_algorithm(result[0], result[1]);
                    result[0] /= del;
                    result[1] /= del;
                }
                while (del != 1);
                numerator.Text = result[0].ToString();
                denominator.Text = result[1].ToString();
            }
        }
        static int Euclids_algorithm(int numerator, int denominator)
        {
            int max;
            int min;
            int ost;

            if (numerator > denominator)
            {
                max = numerator; min = denominator;
            }
            else
            {
                max = denominator; min = numerator;

            }

            if (max % min == 0)
            {
                ost = min;
            }
            else
            {
                ost = max % min;
                int ost2 = min % ost;
                while (ost2 != 0)
                {
                    int p = ost;
                    ost = ost2;
                    ost2 = p % ost2;
                }
            }
            return ost;
        }
    }
}
