using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Doll_Writer
{
    internal class Doll
    {
        Color doll_color;
        int scale, position_x;

        public Doll(Color doll_color, int scale, int position_x)
        {
            this.doll_color = doll_color;
            this.scale = scale;
            this.position_x = position_x;
        }
        public void Draw(Graphics gr)
        {
            string file = $@"{Environment.CurrentDirectory}\\Doll.txt";
            string[] point = File.ReadAllLines(file);

            foreach (string line in point)
            {
                string[] mean = line.Split(';');
                Console.WriteLine(line);
                for (int i = 0; i < mean.Length - 2; i += 2)
                {
                    Point point1 = new Point(Convert.ToInt32(mean[i]) * scale + position_x, Convert.ToInt32(mean[i + 1]) * scale + 200);
                    Point point2 = new Point(Convert.ToInt32(mean[i + 2]) * scale + position_x, Convert.ToInt32(mean[i + 3]) * scale + 200);
                    gr.DrawLine(new Pen(doll_color), point1, point2);
                }
            }
        }
    }
}
