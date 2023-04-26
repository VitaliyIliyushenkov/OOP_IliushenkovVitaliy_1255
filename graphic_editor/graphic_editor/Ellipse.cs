using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphic_editor
{
    internal class Ellipse : Figure
    {
        public Ellipse(int type_figure, int x, int y, int width, int height, string color_pen, float size_pen, string fillColor)
            : base(type_figure, x, y, width, height, color_pen, size_pen, fillColor)
        { this.type_figure = type_figure; this.x = x; this.y = y; this.width = width; this.height = height; this.color_pen = color_pen; this.size_pen = size_pen; this.fillColor = fillColor; }
        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(new Pen(Color.FromName(color_pen), size_pen), x, y, width, height);
            gr.FillEllipse(new SolidBrush(Color.FromName(fillColor)), x, y, width, height);
        }
    }
}
