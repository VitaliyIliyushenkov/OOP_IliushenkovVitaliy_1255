using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphic_editor
{
    internal class Triangle : Figure
    {
        public Triangle(int x, int y, int width, int height, Color lineColor, Color fillColor)
            : base(x, y, width, height, lineColor, fillColor)
        { this.x = x; this.y = y; this.width = width; this.height = height; this.lineColor = lineColor; this.fillColor = fillColor; }
        public override void Draw(Graphics gr)
        {
            Point Tri_p1 = new Point(x, y);
            Point Tri_p2 = new Point(width + x, height + y);
            Point Tri_p3 = new Point(x - width, y + height);
            Point[] Triangle_ps = { Tri_p1, Tri_p2, Tri_p3 };

            gr.DrawPolygon(new Pen(lineColor), Triangle_ps);
            gr.FillPolygon(new SolidBrush(fillColor), Triangle_ps);
        }
    }
}
