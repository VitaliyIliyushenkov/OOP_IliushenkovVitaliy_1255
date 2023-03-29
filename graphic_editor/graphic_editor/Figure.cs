using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphic_editor
{
    internal class Figure
    {
        protected int x, y, width, height;
        protected Color lineColor;
        protected Color fillColor;

        public Figure(int x, int y, int width, int height, Color lineColor, Color fillColor)
        { this.x = x; this.y = y; this.width = width; this.height = height;
            this.lineColor = lineColor; this.fillColor = fillColor; }
        public virtual void Draw(Graphics gr) { }
    }
}
