using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphic_editor
{
    internal class Rectangle: Figure
    {
        public Rectangle(int x, int y, int width, int height, Pen pen, Color fillColor)
            :base(x, y, width,height, pen, fillColor)
        { this.x = x; this.y = y; this.width = width; this.height = height; this.pen = pen; this.fillColor = fillColor; }
        public override void Draw(Graphics gr)
        {
            gr.FillRectangle(new SolidBrush(fillColor), x, y, width, height);
            gr.DrawRectangle(pen, x, y, width, height);
        }
    }
}
