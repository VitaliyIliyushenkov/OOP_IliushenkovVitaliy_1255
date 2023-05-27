using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Rainbow
{
    internal class MyInt : ISortable
    {
        int value;
        public int VALUE
        {
            get { return value; }
            set { this.value = value; }
        }

        public int CompareTo(object o)
        {
            MyInt obj = (MyInt)o;
                return VALUE.CompareTo(obj.value);
        }

        public Color GetColor(ISortable min, ISortable max)
        {
            Color color = new Color();

            int MIN = ((MyInt)min).VALUE;
            int MAX = ((MyInt)max).VALUE;

            int D = (MAX - MIN) / 5;

            int R = 255;
            int G = 0;
            int B = 0;

            for (int j = 0; j < (MAX - MIN+1); j += D)
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

                    if (j + i + MIN == VALUE)
                        color =  Color.FromArgb(R, G, B);
                }
            }
            return color;
        }
    }
}
