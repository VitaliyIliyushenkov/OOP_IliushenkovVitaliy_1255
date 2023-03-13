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
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Rational r1 = new Rational(Convert.ToInt32(textBox1.Text),
                Convert.ToInt32(textBox2.Text));
            Rational r2 = new Rational(Convert.ToInt32(textBox3.Text),
                Convert.ToInt32(textBox4.Text));

            Rational result = r1.Plus(r2);
            result = result.Euclids();

            numerator.Text = result.ToString().Split('/')[0];
            denominator.Text = result.ToString().Split('/')[1];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rational r1 = new Rational(Convert.ToInt32(textBox1.Text),
                            Convert.ToInt32(textBox2.Text));
            Rational r2 = new Rational(Convert.ToInt32(textBox3.Text),
                Convert.ToInt32(textBox4.Text));

            Rational result = r1.Minus(r2);
            result = result.Euclids();

            numerator.Text = result.ToString().Split('/')[0];
            denominator.Text = result.ToString().Split('/')[1];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rational r1 = new Rational(Convert.ToInt32(textBox1.Text),
                            Convert.ToInt32(textBox2.Text));
            Rational r2 = new Rational(Convert.ToInt32(textBox3.Text),
                Convert.ToInt32(textBox4.Text));

            Rational result = r1.Multiply(r2);
            result = result.Euclids();

            numerator.Text = result.ToString().Split('/')[0];
            denominator.Text = result.ToString().Split('/')[1];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rational r1 = new Rational(Convert.ToInt32(textBox1.Text),
                            Convert.ToInt32(textBox2.Text));
            Rational r2 = new Rational(Convert.ToInt32(textBox3.Text),
                Convert.ToInt32(textBox4.Text));

            Rational result = r1.Division(r2);
            result = result.Euclids();

            numerator.Text = result.ToString().Split('/')[0];
            denominator.Text = result.ToString().Split('/')[1];
        }
    }
}
