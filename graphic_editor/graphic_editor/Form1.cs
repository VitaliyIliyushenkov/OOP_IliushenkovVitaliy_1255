using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphic_editor
{
    public partial class Form1 : Form
    {
        Graphics gr;
        Figure f;
        List<Figure> figures;
        bool flag = false;

        int temp_x, temp_y, x, y, width, height;
        int figureType;
        Pen pen;



        public Form1()
        {
            InitializeComponent();
            gr = pictureBox1.CreateGraphics();
            pictureBox1.BackColor = Color.White;
            figures = new List<Figure>();

            colorDialogFill.Color = Color.Transparent;
            colorDialogPen.Color = Color.Black;
            pen = new Pen(colorDialogPen.Color, trackBar1.Value);
        }

        public void Rectangle_btn_Click(object sender, EventArgs e)
        { figureType = 1; }
        private void Triangle_btn_Click(object sender, EventArgs e)
        { figureType = 2; }
        private void Ellipse_btn_Click(object sender, EventArgs e)
        { figureType = 3; }


        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                gr.Clear(Color.White);
                Painting();
                temp_x = x;
                temp_y = y;
                width = Math.Abs(e.X - temp_x);
                height = Math.Abs(e.Y - temp_y);

                switch (figureType)
                {
                    case 1:
                        if (e.X < x) temp_x = e.X;
                        if (e.Y < y) temp_y = e.Y;
                        f = new Rectangle(temp_x, temp_y, width, height, pen, colorDialogFill.Color);
                        break;
                    case 2:
                        if (e.Y < y) height = -height;
                        f = new Triangle(x, y, width, height, pen, colorDialogFill.Color);
                        break;
                    case 3:
                        if (e.X < x) temp_x = e.X;
                        if (e.Y < y) temp_y = e.Y;
                        f = new Ellipse(temp_x, temp_y, width, height, pen, colorDialogFill.Color);
                        break;
                }
                f.Draw(gr);
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
            figures.Add(f);
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            gr.Clear(Color.White);
            figures = new List<Figure>();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Painting();
        }
        public void Painting()
        {
            foreach (Figure f in figures)
            {
                f.Draw(gr);
            }
        }

        private void Color_btn_Click(object sender, EventArgs e)
        {
            if (colorDialogFill.ShowDialog() == DialogResult.OK)
            {
                colorFill_btn.BackColor = colorDialogFill.Color;
            }
        }
        private void ColorPen_btn_Click(object sender, EventArgs e)
        {
            if (colorDialogPen.ShowDialog() == DialogResult.OK)
            {
                colorPen_btn.BackColor = colorDialogPen.Color;
                pen = new Pen(colorDialogPen.Color, trackBar1.Value);
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen = new Pen(colorDialogPen.Color, trackBar1.Value);
        }
    }
}
