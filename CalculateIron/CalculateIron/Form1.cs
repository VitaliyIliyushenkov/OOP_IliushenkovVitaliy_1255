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
        Rational r1;
        Rational r2;
        Rational result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item is Button)
                    ((Button)item).Click += CommonBtn_Click;
            }
        }
        private void CommonBtn_Click(object sender, EventArgs e)
        {
            numerator.Text = result.Numerator.ToString();
            denominator.Text = result.Denominator.ToString();
        }

        private void Set_Value()
        {
            r1 = new Rational(Convert.ToInt32(textBox1.Text),
                Convert.ToInt32(textBox2.Text));
            r2 = new Rational(Convert.ToInt32(textBox3.Text),
                Convert.ToInt32(textBox4.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Set_Value();
            result = r1 + r2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Set_Value();
            result = r1 - r2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Set_Value();
            result = r1 * r2;
        }

        private void button4_Click(object sender, EventArgs e)
        {   
            Set_Value();
            result = r1 / r2;
        }

    }
}
