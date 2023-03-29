namespace graphic_editor
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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.triangle_btn = new System.Windows.Forms.Button();
            this.Rectangle_btn = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.color_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ellipse_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 50);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::graphic_editor.Properties.Resources._1674963165_top_fon_com_p_fon_dlya_prezentatsii_fakturnii_122;
            this.panel3.Controls.Add(this.Clear_btn);
            this.panel3.Controls.Add(this.ellipse_btn);
            this.panel3.Controls.Add(this.triangle_btn);
            this.panel3.Controls.Add(this.Rectangle_btn);
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Controls.Add(this.color_btn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 400);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 50);
            this.panel3.TabIndex = 3;
            // 
            // triangle_btn
            // 
            this.triangle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.triangle_btn.Location = new System.Drawing.Point(222, 10);
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
            this.Rectangle_btn.Location = new System.Drawing.Point(168, 10);
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
            // 
            // color_btn
            // 
            this.color_btn.Location = new System.Drawing.Point(12, 8);
            this.color_btn.Name = "color_btn";
            this.color_btn.Size = new System.Drawing.Size(30, 30);
            this.color_btn.TabIndex = 0;
            this.color_btn.UseVisualStyleBackColor = true;
            this.color_btn.Click += new System.EventHandler(this.Color_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 338);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // ellipse_btn
            // 
            this.ellipse_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ellipse_btn.Location = new System.Drawing.Point(278, 10);
            this.ellipse_btn.Name = "ellipse_btn";
            this.ellipse_btn.Size = new System.Drawing.Size(50, 30);
            this.ellipse_btn.TabIndex = 4;
            this.ellipse_btn.Text = "⬭";
            this.ellipse_btn.UseVisualStyleBackColor = true;
            this.ellipse_btn.Click += new System.EventHandler(this.Ellipse_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(688, 10);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(100, 30);
            this.Clear_btn.TabIndex = 5;
            this.Clear_btn.Text = "Очистить";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button color_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button Rectangle_btn;
        private System.Windows.Forms.Button triangle_btn;
        private System.Windows.Forms.Button ellipse_btn;
        private System.Windows.Forms.Button Clear_btn;
    }
}

