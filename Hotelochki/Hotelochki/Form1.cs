using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelochki
{
    public partial class Form1 : Form
    {
        Wisheslist wisheslist = new Wisheslist();
        MyWish selectdWish;
        bool isSelected = false;
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine(File.ReadLines("Data_Wish").Count());
            if (File.ReadLines("Data_Wish").Count() != 0)
            {
                wisheslist = Wisheslist.Restore("Data_Wish");
                RefreshlistBox();
            }

        }

        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            isSelected = true;
            selectdWish = (MyWish)listbox.SelectedItem;
            name_box.Text = selectdWish.Name; 
            description_box.Text = selectdWish.Description;
            price_box.Text = selectdWish.Price.ToString();
            pictureBox1.Image = selectdWish.Picture;
            checkBox1.Visible = true;
            pictureBox1.Refresh();
        }

        private void btn_load_picture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files(*.JPG*;*.PNG*)|*.JPG;*.PNG;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            isSelected = false;
            checkBox1.Visible = false;
            selectdWish = null;
            name_box.Text = "Новая хотелка";
            description_box.Text = "";
            price_box.Text = "";
            pictureBox1.Image = null;
            pictureBox1.Refresh();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isSelected)
            {
                selectdWish.Name = name_box.Text;
                selectdWish.Description = description_box.Text;
                selectdWish.Price = Int32.Parse(price_box.Text);
                selectdWish.Picture = (Bitmap)pictureBox1.Image;

            }
            else
            {
                MyWish newWish = new MyWish
                {
                    Name = name_box.Text,
                    Description = description_box.Text,
                    Price = Int32.Parse(price_box.Text),
                    Picture = (Bitmap)pictureBox1.Image
                };
                wisheslist.AddWish(newWish);
            }
            wisheslist.Save("Data_Wish");
            RefreshlistBox();
        }
        private void RefreshlistBox()
        {
            listbox.Items.Clear();
            foreach(MyWish wish in wisheslist.myWishes)
            {
                listbox.Items.Add(wish);
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            isSelected = false;
            if (checkBox1.Checked)
            {
                wisheslist.Remove(selectdWish);
                wisheslist.Save("Data_Wish");
                checkBox1.Checked = false;
                checkBox1.Visible = false;
                RefreshlistBox();
            }
        }
    }
}











