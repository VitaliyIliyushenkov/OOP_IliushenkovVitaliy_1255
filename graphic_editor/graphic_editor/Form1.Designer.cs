﻿namespace graphic_editor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialogFill = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.donwload_button = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.colorPen_btn = new System.Windows.Forms.Button();
            this.ellipse_btn = new System.Windows.Forms.Button();
            this.triangle_btn = new System.Windows.Forms.Button();
            this.Rectangle_btn = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.colorFill_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialogPen = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::graphic_editor.Properties.Resources._1674963165_top_fon_com_p_fon_dlya_prezentatsii_fakturnii_122;
            this.panel2.Controls.Add(this.donwload_button);
            this.panel2.Controls.Add(this.save_btn);
            this.panel2.Controls.Add(this.Clear_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 50);
            this.panel2.TabIndex = 3;
            // 
            // donwload_button
            // 
            this.donwload_button.Location = new System.Drawing.Point(118, 8);
            this.donwload_button.Name = "donwload_button";
            this.donwload_button.Size = new System.Drawing.Size(100, 30);
            this.donwload_button.TabIndex = 7;
            this.donwload_button.Text = "Загрузить";
            this.donwload_button.UseVisualStyleBackColor = true;
            this.donwload_button.Click += new System.EventHandler(this.donwload_button_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(12, 8);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(100, 30);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(688, 8);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(100, 30);
            this.Clear_btn.TabIndex = 5;
            this.Clear_btn.Text = "Очистить";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::graphic_editor.Properties.Resources._1674963165_top_fon_com_p_fon_dlya_prezentatsii_fakturnii_122;
            this.panel3.Controls.Add(this.colorPen_btn);
            this.panel3.Controls.Add(this.ellipse_btn);
            this.panel3.Controls.Add(this.triangle_btn);
            this.panel3.Controls.Add(this.Rectangle_btn);
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Controls.Add(this.colorFill_btn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 400);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 50);
            this.panel3.TabIndex = 3;
            // 
            // colorPen_btn
            // 
            this.colorPen_btn.Location = new System.Drawing.Point(12, 13);
            this.colorPen_btn.Name = "colorPen_btn";
            this.colorPen_btn.Size = new System.Drawing.Size(30, 27);
            this.colorPen_btn.TabIndex = 6;
            this.colorPen_btn.UseVisualStyleBackColor = true;
            this.colorPen_btn.Click += new System.EventHandler(this.ColorPen_btn_Click);
            // 
            // ellipse_btn
            // 
            this.ellipse_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ellipse_btn.Location = new System.Drawing.Point(266, 10);
            this.ellipse_btn.Name = "ellipse_btn";
            this.ellipse_btn.Size = new System.Drawing.Size(50, 30);
            this.ellipse_btn.TabIndex = 4;
            this.ellipse_btn.Text = "⬭";
            this.ellipse_btn.UseVisualStyleBackColor = true;
            this.ellipse_btn.Click += new System.EventHandler(this.Ellipse_btn_Click);
            // 
            // triangle_btn
            // 
            this.triangle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.triangle_btn.Location = new System.Drawing.Point(210, 10);
            this.triangle_btn.Name = "triangle_btn";
            this.triangle_btn.Size = new System.Drawing.Size(50, 30);
            this.triangle_btn.TabIndex = 3;
            this.triangle_btn.Text = "△";
            this.triangle_btn.UseVisualStyleBackColor = true;
            this.triangle_btn.Click += new System.EventHandler(this.Triangle_btn_Click);
            // 
            // Rectangle_btn
            // 
            this.Rectangle_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Rectangle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Rectangle_btn.Location = new System.Drawing.Point(156, 10);
            this.Rectangle_btn.Margin = new System.Windows.Forms.Padding(1);
            this.Rectangle_btn.Name = "Rectangle_btn";
            this.Rectangle_btn.Size = new System.Drawing.Size(50, 30);
            this.Rectangle_btn.TabIndex = 2;
            this.Rectangle_btn.Text = "▭";
            this.Rectangle_btn.UseVisualStyleBackColor = true;
            this.Rectangle_btn.Click += new System.EventHandler(this.Rectangle_btn_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(48, 0);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 56);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // colorFill_btn
            // 
            this.colorFill_btn.Location = new System.Drawing.Point(322, 12);
            this.colorFill_btn.Name = "colorFill_btn";
            this.colorFill_btn.Size = new System.Drawing.Size(30, 27);
            this.colorFill_btn.TabIndex = 0;
            this.colorFill_btn.UseVisualStyleBackColor = true;
            this.colorFill_btn.Click += new System.EventHandler(this.Color_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 355);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint_1);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialogFill;
        private System.Windows.Forms.Button colorFill_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button Rectangle_btn;
        private System.Windows.Forms.Button triangle_btn;
        private System.Windows.Forms.Button ellipse_btn;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button colorPen_btn;
        private System.Windows.Forms.ColorDialog colorDialogPen;
        private System.Windows.Forms.Button donwload_button;
        private System.Windows.Forms.Button save_btn;
    }
}

