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
            int MIN = ((MyInt)min).VALUE;
            int MAX = ((MyInt)max).VALUE;

            int D = (MAX - MIN) / 5;

            if (VALUE <= MIN + D)
                return Color.FromArgb(255, 0 + 255 * (VALUE - MIN) / D, 0);
            if (VALUE > MIN + D & VALUE <= MIN + 2 * D)
                return Color.FromArgb(255 - (255 * ((VALUE - MIN) - D)) / D, 255, 0);
            if (VALUE > MIN + 2 * D & VALUE <= MIN + 3 * D)
                return Color.FromArgb(0, 255, 0 + (255 * ((VALUE - MIN) - 2 * D)) / D);
            if (VALUE > MIN + 3 * D & VALUE <= MIN + 4 * D)
                return Color.FromArgb(0, 255 - (255 * ((VALUE - MIN) - 3 * D)) / D, 255);
            if (VALUE > MIN + 4 * D & VALUE <= MIN + 5 * D)
                return Color.FromArgb(0 + (255 * ((VALUE - MIN) - 4 * D)) / D, 0, 255);
            return Color.FromArgb(255, 0, 255);
        }
    }
}
