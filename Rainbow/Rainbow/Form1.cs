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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Rainbow
{
    public partial class Form1 : Form
    {
        Graphics g;
        List<ISortable> objects = new List<ISortable>();
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

            int width = Form1.WIDTH_SCREEN / objects.Count();
            int i = 0;

            foreach (MyInt obj in objects.Cast<MyInt>())
            {
                System.Threading.Thread.Sleep(1);
                g.FillRectangle(new SolidBrush(obj.GetColor(objects.Min(), objects.Max())), i * width, 10, width, 100);
                i++;
            }
        }
        private void btn_sort_Click(object sender, EventArgs e)
        {
            if (domainUpDown1.SelectedIndex == 0)
                sorter = new Buble();
            else if (domainUpDown1.SelectedIndex == 1)
                sorter = new Shaker();
            else if (domainUpDown1.SelectedIndex == 2)
                sorter = new Selection();
            else if (domainUpDown1.SelectedIndex == 3)
                sorter = new Insert();

            sorter.OBJECTS = myIntsCreator.CreateMyInts(min, max);
            sorter.Sort_and_Draw(g);
        }
    }
}
