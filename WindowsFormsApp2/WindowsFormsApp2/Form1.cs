using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int DollCount;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DollCount = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= DollCount; i++) 
            {
                Doll doll = new Doll(Color.Black, DollCount-i+1, Convert.ToInt32(Width/(DollCount+1))*i);
                doll.Draw(this.CreateGraphics());
            }
        }
    }
}
