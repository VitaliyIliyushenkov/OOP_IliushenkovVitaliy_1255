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
        public int x, y, width, height;
        protected Pen pen;
        protected Color fillColor;

        public Figure(int x, int y, int width, int height, Pen pen, Color fillColor)
        { this.x = x; this.y = y; this.width = width; this.height = height;
            this.pen = pen; this.fillColor = fillColor; }
        public virtual void Draw(Graphics gr) { }
    }
}
