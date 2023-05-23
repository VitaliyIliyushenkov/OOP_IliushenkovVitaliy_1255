using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Rainbow
{
    internal class MyInt : IComparable, ISortable
    {
        int value;
        Color color;
        public int VALUE
        {
            get { return value; }
            set { this.value = value; }
        }
        public Color COLOR
        {
            get { return color; }
            set { color = value; }
        }
        public MyInt(int value) 
        {
            VALUE = value;
        }
        public int CompareTo(object o)
        {
            if (o is MyInt obj)
            {
                return VALUE.CompareTo(obj.VALUE);
            }
            else throw new ArgumentException("Некорректное значение параметра");
        }
        public Color GetColor(int min, int max)
        {
            int D = (max - min) / 5;

            int R = 255;
            int G = 0;
            int B = 0;

            for (int j = 0; j < (max - min); j += D)
            {
                for (int i = 0; i < D; i++)
                {
                    if (j == D * 0)
                        G += (255 / D);
                    else if (j == D * 1)
                        R -= (255 / D);
                    else if (j == D * 2)
                        B += (255 / D);
                    else if (j == D * 3)
                        G -= (255 / D);
                    else if (j == D * 4)
                        R += (255 / D);

                    if (j + i + min == value)
                        COLOR = Color.FromArgb(R, G, B);
                }
            }
            return COLOR;
        }
    }
}
