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
        public Triangle(int type_figure, int x, int y, int width, int height, string color_pen, float size_pen, string fillColor)
            : base(type_figure, x, y, width, height, color_pen, size_pen, fillColor)
        { this.type_figure = type_figure; this.x = x; this.y = y; this.width = width; this.height = height; this.color_pen = color_pen; this.size_pen = size_pen; this.fillColor = fillColor; }
        public override void Draw(Graphics gr)
        {
            Point Tri_p1 = new Point(x + width / 2, y);
            Point Tri_p2 = new Point(x, y+height);
            Point Tri_p3 = new Point(x+ width, y+height);

            Point[] Triangle_ps = { Tri_p1, Tri_p2, Tri_p3 };

            gr.DrawPolygon(new Pen(Color.FromName(color_pen), size_pen), Triangle_ps);
            gr.FillPolygon(new SolidBrush(Color.FromName(fillColor)), Triangle_ps);
        }
    }
}
