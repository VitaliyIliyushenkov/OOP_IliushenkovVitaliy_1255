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
        readonly Graphics gr;
        Figure f;

        int x, y;
        int figureType;

        public Form1()
        {
            InitializeComponent();
            gr = pictureBox1.CreateGraphics();
        }

        public void Rectangle_btn_Click(object sender, EventArgs e)
        { figureType = 1; }
        private void Triangle_btn_Click(object sender, EventArgs e)
        { figureType = 2; }
        private void Ellipse_btn_Click(object sender, EventArgs e)
        { figureType = 3; }


        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 3);
            int width = Math.Abs(e.X - x);
            int height = Math.Abs(e.Y - y);
            switch (figureType)
            {
                case 1:
                    f = new Rectangle(x, y, width, height, blackPen.Color, colorDialog.Color);
                    break;
                case 2:
                    f = new Triangle(x, y, width, height, blackPen.Color, colorDialog.Color);
                    break;
                case 3:
                    f = new Ellipse(x, y, width, height, blackPen.Color, colorDialog.Color);
                    break;

            }
            f.Draw(gr);
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            gr.Clear(Color.White);
        }

        private void Color_btn_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color_btn.BackColor = colorDialog.Color;
            }
        }
    }
}
