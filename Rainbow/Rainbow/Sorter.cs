using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rainbow
{
    internal class Sorter
    {
        int min, max;
        List<MyInt> objects;

        int MIN
        {
            get { return min; }
            set { min = value; }
        }
        int MAX
        {
            get { return max; }
            set { max = value; }
        }
        public Sorter(int min, int max, List<MyInt> objects)
        {
            MIN = min;
            MAX = max;
            this.objects = objects;
        }

        public void Sort()
        {
            for (int i = 0; i < objects.Count-1; i++)
            {
                for (int j = 0; j < objects.Count-i-1; j++)
                {
                    if (objects[j].CompareTo(objects[j + 1]) < 0 )
                    {
                        (objects[j + 1], objects[j]) = (objects[j], objects[j + 1]);
                    }
                }
            }
        }
        public void Draw(Graphics gr)
        {
            int width = Form1.WIDTH_SCREEN / objects.Count();
            int i = 0;
            foreach (MyInt obj in objects)
            {
                gr.FillRectangle(new SolidBrush(obj.GetColor(MIN,MAX)), i * width, 10, width, 100);
                i++;
            }
        }
    }
}
