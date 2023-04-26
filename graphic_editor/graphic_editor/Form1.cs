using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Text.Json.Nodes;

namespace graphic_editor
{
    public partial class Form1 : Form
    {
        Graphics gr;
        string path;
        string[] json_string = new string[] { };

        Figure f;
        List<Figure> figures;
        enum Type : int
        {
            Rectangle,
            Triangle,
            Ellipse
        }

        bool isMouseDown, isMouseMove = false;

        bool isCursor = true;
        bool isCasting, isCorrecting = false;

        List<bool> Resize_Point = new List<bool>() { false, false, false, false};
        bool isResize = false;

        int temp_x, temp_y, x, y, width, height;
        int f_x_select, f_y_select, f_w_select, f_h_select;
        int figureType;
        int selected_index;

        public Form1()
        {
            InitializeComponent();
            gr = pictureBox1.CreateGraphics();
            pictureBox1.BackColor = Color.White;
            figures = new List<Figure>();

            colorDialogFill.Color = Color.Transparent;
            colorDialogPen.Color = Color.Black;
        }
        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            Update_Screen();
        }
        private void Update_Screen() // Обновить экран
        {
            gr.Clear(Color.White);
            foreach (Figure f in figures)
            {
                f.Draw(gr);
            }
        }

        public void Rectangle_btn_Click(object sender, EventArgs e)
        { figureType = 1; isCursor = false; isCasting = false; isCorrecting = false; }
        private void Triangle_btn_Click(object sender, EventArgs e)
        { figureType = 2; isCursor = false; isCasting = false; isCorrecting = false; }
        private void Ellipse_btn_Click(object sender, EventArgs e)
        { figureType = 3; isCursor = false; isCasting = false; isCorrecting = false; }

        private void save_btn_Click(object sender, EventArgs e)
        {
            json_string = new string[figures.Count];

            OpenFileDialog od = new OpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
            {
                path = od.FileName;
            }
            for (int i = 0; i < figures.Count; i++)
            {
                json_string[i] = JsonSerializer.Serialize(figures[i]);
            }
            File.AppendAllLines(path, json_string);
        }

        private void donwload_button_Click(object sender, EventArgs e)
        {

            OpenFileDialog od = new OpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
            {
                path = od.FileName;
            }

            json_string = File.ReadAllLines(path);

            gr.Clear(Color.White);
            figures.Clear();

            for (int i = 0; i < json_string.Length; i++)
            {
                switch (json_string[i][15])
                {
                    case ('0'):
                        figures.Add(JsonSerializer.Deserialize<Rectangle>(json_string[i]));
                        break;

                    case ('1'):
                        figures.Add(JsonSerializer.Deserialize<Triangle>(json_string[i]));
                        break;

                    case ('2'):
                        figures.Add(JsonSerializer.Deserialize<Ellipse>(json_string[i]));
                        break;
                }
                Update_Screen();
                pictureBox1.Enabled = false;
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown =  true;

            x = e.X;
            y = e.Y;

            isResize = false;
            for (int r_p = 0; r_p < Resize_Point.Count; r_p++)
            {
                Resize_Point[r_p] = false;
            }

            Update_Screen();

            if (isCursor && isCorrecting) //Выбор точки маштабирования
            { 
                if (figures[selected_index].x-5 <= e.X && e.X <= figures[selected_index].x+5)
                {
                    isResize = true;
                    if (figures[selected_index].y-5 <= e.Y && e.Y <= figures[selected_index].y+5)
                    {
                        Resize_Point[0] = true;
                    }
                    if (figures[selected_index].y + figures[selected_index].height -5 <= e.Y
                                        && e.Y <= figures[selected_index].y + figures[selected_index].height+5)
                    {
                        Resize_Point[3] = true;
                    }
                }
                if (figures[selected_index].x+ figures[selected_index].width-5 <= e.X
                                        && e.X <= figures[selected_index].x + figures[selected_index].width+5)
                {
                    isResize = true;
                    if (figures[selected_index].y-5 <= e.Y && e.Y <= figures[selected_index].y+5)
                    {
                        Resize_Point[1] = true;
                    }
                    if (figures[selected_index].y + figures[selected_index].height-5 <= e.Y
                                        && e.Y <= figures[selected_index].y + figures[selected_index].height+5)
                    {
                        Resize_Point[2] = true;
                    }
                }
            }
            if (isCorrecting)
            {
                f_x_select = figures[selected_index].x;
                f_y_select = figures[selected_index].y;
                f_w_select = figures[selected_index].width;
                f_h_select = figures[selected_index].height;
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isCorrecting && isCursor && isMouseDown && !isResize) //Переместить фигуру
            {
                isMouseMove = true;
                figures[selected_index].x = e.X + f_x_select - x;
                figures[selected_index].y = e.Y + f_y_select - y;

                Update_Screen();
            }
            if (isCorrecting && isCursor && isMouseDown && isResize) //Поменять размер
            {
                isMouseMove = true;
                if (Resize_Point[0])
                {
                    figures[selected_index].x = e.X;
                    figures[selected_index].y = e.Y;
                    figures[selected_index].width = f_w_select + (x - e.X);
                    figures[selected_index].height = (y - e.Y) + f_h_select;
                }
                if (Resize_Point[1])
                {
                    figures[selected_index].y = e.Y;
                    figures[selected_index].width = f_w_select + (e.X - x);
                    figures[selected_index].height = f_h_select + (y - e.Y);
                }
                if (Resize_Point[2])
                {
                    figures[selected_index].width = e.X - figures[selected_index].x;
                    figures[selected_index].height = e.Y - figures[selected_index].y;
                }
                if (Resize_Point[3])
                {
                    figures[selected_index].x = e.X;
                    figures[selected_index].width = f_w_select + (x - e.X);
                    figures[selected_index].height = f_h_select + (e.Y - y);
                }

                Update_Screen();
            }

            else if (isMouseDown && !isCursor) //Нарисовать фигуру
            {
                isMouseMove = true;

                Update_Screen();
                
                temp_x = x;
                temp_y = y;
                width = Math.Abs(e.X - temp_x);
                height = Math.Abs(e.Y - temp_y);

                switch (figureType)
                {
                    case 1:
                        if (e.X < x) temp_x = e.X;
                        if (e.Y < y) temp_y = e.Y;
                        f = new Rectangle((int)Type.Rectangle, temp_x, temp_y, width, height, colorDialogPen.Color.Name, trackBar1.Value, colorDialogFill.Color.Name);
                        break;
                    case 2:
                        if (e.X < x) temp_x = e.X;
                        if (e.Y < y) temp_y = e.Y;
                        f = new Triangle((int)Type.Triangle, temp_x, temp_y, width, height, colorDialogPen.Color.Name, trackBar1.Value, colorDialogFill.Color.Name);
                        break;
                    case 3:
                        if (e.X < x) temp_x = e.X;
                        if (e.Y < y) temp_y = e.Y;
                        f = new Ellipse((int)Type.Ellipse, temp_x, temp_y, width, height, colorDialogPen.Color.Name, trackBar1.Value, colorDialogFill.Color.Name);
                        break;
                }
                f.Draw(gr);
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseMove) // Добавить фигуру
            {
                figures.Add(f);
            }
            if (!isMouseMove) // Выбрать фигуру
            {
                isCursor = true;

                int item = 0;
                bool flag = false;

                foreach (Figure fi in figures)
                {
                    if ((fi.x <= e.X) && (e.X <= fi.x + fi.width))
                    {
                        if ((fi.y <= e.Y) && (e.Y <= fi.y + fi.height))
                        {
                            flag = true;
                            isCorrecting = true;
                            selected_index = item;
                        }
                    }
                    item++;
                }
                if (!flag) {isCorrecting = false;}
            }
            
            if (isCorrecting)
            {
                if (isCasting) // Добавить стиль
                {
                    //figures[selected_index].pen = pen;
                    figures[selected_index].fillColor = colorDialogFill.Color.Name;
                    Update_Screen();
                }

                // Добавить точки маштабирования выбранной фигуры
                Point R1 = new Point(figures[selected_index].x, figures[selected_index].y);
                Point R2 = new Point(figures[selected_index].x + figures[selected_index].width, figures[selected_index].y);
                Point R3 = new Point(figures[selected_index].x + figures[selected_index].width, figures[selected_index].y + figures[selected_index].height);
                Point R4 = new Point(figures[selected_index].x, figures[selected_index].y + figures[selected_index].height);

                Point[] pointR = { R1, R2, R3, R4 };
                Pen penR = new Pen(Color.Red, 10);

                foreach (Point r in pointR)
                {
                    gr.DrawEllipse(penR, r.X, r.Y, 1, 1);
                }
            }
            
            isMouseDown = false;
            isMouseMove = false;
        }

        private void Clear_btn_Click(object sender, EventArgs e) // Очистить форму
        {
            pictureBox1.Enabled = true;
            gr.Clear(Color.White);
            figures = new List<Figure>();
        }

        private void Color_btn_Click(object sender, EventArgs e) //Заливка
        {
            isCasting = true;
            if (colorDialogFill.ShowDialog() == DialogResult.OK)
            {
                colorFill_btn.BackColor = colorDialogFill.Color;
            }
        }
        private void ColorPen_btn_Click(object sender, EventArgs e) //Граница
        {
            isCasting = true;
            if (colorDialogPen.ShowDialog() == DialogResult.OK)
            {
                colorPen_btn.BackColor = colorDialogPen.Color;
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e) //Фон
        {
            isCasting = true;
        }

    }
}
