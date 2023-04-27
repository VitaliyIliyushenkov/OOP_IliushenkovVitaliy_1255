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

        List<bool> correcting_point = new List<bool>() { false, false, false, false };

        public int f_x_select;
        public int f_y_select;
        public int f_w_select;
        public int f_h_select;

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
        public bool is_point_correcting(int X, int Y)
        {
            bool isResize = false;
            for (int r_p = 0; r_p < correcting_point.Count; r_p++)
            {
                correcting_point[r_p] = false;
            }

            if (this.x - 5 <= X && X <= this.x + 5)
            {
                isResize = true;
                if (this.y - 5 <= Y && Y <= this.y + 5)
                {
                    correcting_point[0] = true;
                }
                if (this.y + this.height - 5 <= Y
                                    && Y <= this.y + this.height + 5)
                {
                    correcting_point[3] = true;
                }
            }
            if (this.x + this.width - 5 <= X
                                    && X <= this.x + this.width + 5)
            {
                isResize = true;

                if (this.y - 5 <= Y && Y <= this.y + 5)
                {
                    correcting_point[1] = true;
                }
                if (this.y + this.height - 5 <= Y && Y <= this.y + this.height + 5)
                {
                    correcting_point[2] = true;
                }
            }
            f_x_select = this.x;
            f_y_select = this.y;
            f_w_select = this.width;
            f_h_select = this.height;
            return isResize;
        }
        public void Relocation(int X, int Y, int X0, int Y0)
        {
            this.X = X + f_x_select - X0;
            this.Y = Y + f_y_select - Y0;
        }
        public void Resize(int X, int Y, int X0, int Y0)
        {
            if (correcting_point[0])
            {
                this.x = X;
                this.y = Y;
                this.width = f_w_select + (X0 - X);
                this.height = (Y0 - Y) + f_h_select;
            }
            if (correcting_point[1])
            {
                this.y = Y;
                this.width = f_w_select + (X - X0);
                this.height = f_h_select + (Y0 - Y);
            }
            if (correcting_point[2])
            {
                this.width = X - this.x;
                this.height = Y - this.y;
            }
            if (correcting_point[3])
            {
                this.x = X;
                this.width = f_w_select + (X0 - X);
                this.height = f_h_select + (Y - Y0);
            }
        }
        public void SetFill(string Color)
        {
            this.FILLCOLOR = Color;
        }
        public void SetBorder(string Color, float Size) 
        {
            this.COLOR_PEN = Color;
            this.SIZE_PEN = Size;
        }
        public void Draw_point(Graphics gr)                // Добавить точки маштабирования выбранной фигуры
        {
            Point R1 = new Point(this.x, this.y);
            Point R2 = new Point(this.x + this.width, this.y);
            Point R3 = new Point(this.x + this.width, this.y + this.height);
            Point R4 = new Point(this.x, this.y + this.height);

            Point[] pointR = { R1, R2, R3, R4 };
            Pen penR = new Pen(Color.Red, 10);

            foreach (Point r in pointR)
            {
                gr.DrawEllipse(penR, r.X, r.Y, 1, 1);
            }
        }

        public virtual void Draw(Graphics gr) { }
    }
}
