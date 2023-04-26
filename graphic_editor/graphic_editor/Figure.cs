using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace graphic_editor
{
    abstract class Figure
    {
        public int type_figure;
        public int x, y, width, height;
        public string color_pen;
        public float size_pen;
        public string fillColor;
       

        public int TYPE_FIGURE
        {
            get { return type_figure; }
            set { type_figure = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int WIDTH
        {
            get { return width; }
            set { width = value; }
        }
        public int HEIGHT
        {
            get { return height; }
            set { height = value; }
        }
        public string COLOR_PEN
        {
            get { return color_pen; }
            set { color_pen = value; }
        }
        public float SIZE_PEN
        {
            get { return size_pen; }
            set { size_pen = value; }
        }
        public string FILLCOLOR
        {
            get { return fillColor; }
            set { fillColor = value; }
        }
        public Figure(int type_figure, int x, int y, int width, int height, string color_pen, float size_pen, string fillColor)
        {
            TYPE_FIGURE = type_figure;
            X = x;
            Y = y;
            WIDTH = width;
            HEIGHT = height;
            COLOR_PEN = color_pen;
            SIZE_PEN = size_pen;
            FILLCOLOR = fillColor;
        }
        public virtual void Draw(Graphics gr) { }
    }
}
