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
        bool isCorrecting = false;
        bool isCastingBorder, isCastingFill = false;
        bool isResize = false;

        int temp_x, temp_y, x, y, width, height;
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
        { figureType = 1; isCursor = false; isCastingBorder = false; isCastingFill = false; isCorrecting = false; }
        private void Triangle_btn_Click(object sender, EventArgs e)
        { figureType = 2; isCursor = false; isCastingBorder = false; isCastingFill = false; isCorrecting = false; }
        private void Ellipse_btn_Click(object sender, EventArgs e)
        { figureType = 3; isCursor = false; isCastingBorder = false; isCastingFill = false; isCorrecting = false; }

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
                //pictureBox1.Enabled = false;
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown =  true;

            x = e.X;
            y = e.Y;

            isResize = false;

            Update_Screen();

            if (isCursor && isCorrecting) //Выбор точки маштабирования
            {
                isResize = figures[selected_index].is_point_correcting(e.X, e.Y);
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isCorrecting && isCursor && isMouseDown && !isResize) //Переместить фигуру
            {
                isMouseMove = true;
                figures[selected_index].Relocation(e.X, e.Y, x, y);

                Update_Screen();
            }
            if (isCorrecting && isCursor && isMouseDown && isResize) //Поменять размер
            {
                isMouseMove = true;
                figures[selected_index].Resize(e.X, e.Y, x, y);

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
            if (isMouseMove && !isCursor) // Добавить фигуру
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
                if (isCastingFill) // Добавить стиль
                {
                    figures[selected_index].SetFill(colorFill_btn.BackColor.Name);
                    Update_Screen();
                }
                if (isCastingBorder)
                {
                    figures[selected_index].SetBorder(colorPen_btn.BackColor.Name, trackBar1.Value);
                    Update_Screen();
                }
                figures[selected_index].Draw_point(gr);
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
            isCastingFill = true;
            if (colorDialogFill.ShowDialog() == DialogResult.OK)
            {
                colorFill_btn.BackColor = colorDialogFill.Color;
            }
        }
        private void ColorPen_btn_Click(object sender, EventArgs e) //Граница
        {
            isCastingBorder = true;
            if (colorDialogPen.ShowDialog() == DialogResult.OK)
            {
                colorPen_btn.BackColor = colorDialogPen.Color;
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e) //Фон
        {
            isCastingBorder = true;
        }

    }
}
