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
        public Ellipse(int x, int y, int width, int height, Color lineColor, Color fillColor)
            : base(x, y, width, height, lineColor, fillColor)
        { this.x = x; this.y = y; this.width = width; this.height = height; this.lineColor = lineColor; this.fillColor = fillColor; }
        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(new Pen(lineColor), x, y, width, height);
            gr.FillEllipse(new SolidBrush(fillColor), x, y, width, height);
        }
    }
}
