using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Rainbow
{
    public partial class Form1 : Form
    {
        Graphics g;
        List<MyInt> objects = new List<MyInt>();
        int min, max;

        Sorter sorter;
        MyIntsCreator myIntsCreator = new MyIntsCreator();
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }
        private void btn_draw_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            objects.Clear();

            min = (int)numericUpDown1.Value;
            max = (int)numericUpDown2.Value;

            objects = myIntsCreator.CreateMyInts(min, max);
            sorter = new Sorter(min, max, objects);

            sorter.Draw(g);
        }
        private void btn_sort_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);

            sorter.Sort();
            sorter.Draw(g);
        }
    }
}
