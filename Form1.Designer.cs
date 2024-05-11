namespace WindowsFormsApp1
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
            this.ClearButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.purpl = new System.Windows.Forms.Button();
            this.blueOcean = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.yel = new System.Windows.Forms.Button();
            this.orange = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.Pallete = new System.Windows.Forms.Button();
            this.black = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Thickness = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Line = new System.Windows.Forms.Button();
            this.eraser = new System.Windows.Forms.Button();
            this.romb = new System.Windows.Forms.Button();
            this.par = new System.Windows.Forms.Button();
            this.fill = new System.Windows.Forms.Button();
            this.pen = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.angle = new System.Windows.Forms.TextBox();
            this.figure = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.Location = new System.Drawing.Point(7, 621);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(113, 25);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Location = new System.Drawing.Point(7, 497);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(113, 25);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save EMF";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.purpl);
            this.panel1.Controls.Add(this.blueOcean);
            this.panel1.Controls.Add(this.blue);
            this.panel1.Controls.Add(this.green);
            this.panel1.Controls.Add(this.yel);
            this.panel1.Controls.Add(this.orange);
            this.panel1.Controls.Add(this.red);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Controls.Add(this.Pallete);
            this.panel1.Controls.Add(this.black);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 201);
            this.panel1.TabIndex = 2;
            // 
            // purpl
            // 
            this.purpl.BackColor = System.Drawing.Color.Fuchsia;
            this.purpl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purpl.Location = new System.Drawing.Point(75, 3);
            this.purpl.Name = "purpl";
            this.purpl.Size = new System.Drawing.Size(30, 30);
            this.purpl.TabIndex = 8;
            this.purpl.UseVisualStyleBackColor = false;
            this.purpl.Click += new System.EventHandler(this.purpl_Click);
            // 
            // blueOcean
            // 
            this.blueOcean.BackColor = System.Drawing.Color.Blue;
            this.blueOcean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blueOcean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueOcean.Location = new System.Drawing.Point(39, 75);
            this.blueOcean.Name = "blueOcean";
            this.blueOcean.Size = new System.Drawing.Size(30, 30);
            this.blueOcean.TabIndex = 7;
            this.blueOcean.UseVisualStyleBackColor = false;
            this.blueOcean.Click += new System.EventHandler(this.blueOcean_Click);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Cyan;
            this.blue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blue.Location = new System.Drawing.Point(3, 75);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(30, 30);
            this.blue.TabIndex = 6;
            this.blue.UseVisualStyleBackColor = false;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Lime;
            this.green.Cursor = System.Windows.Forms.Cursors.Hand;
            this.green.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.green.Location = new System.Drawing.Point(75, 39);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(30, 30);
            this.green.TabIndex = 5;
            this.green.UseVisualStyleBackColor = false;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // yel
            // 
            this.yel.BackColor = System.Drawing.Color.Yellow;
            this.yel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yel.Location = new System.Drawing.Point(39, 39);
            this.yel.Name = "yel";
            this.yel.Size = new System.Drawing.Size(30, 30);
            this.yel.TabIndex = 4;
            this.yel.UseVisualStyleBackColor = false;
            this.yel.Click += new System.EventHandler(this.yel_Click);
            // 
            // orange
            // 
            this.orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orange.Location = new System.Drawing.Point(3, 39);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(30, 30);
            this.orange.TabIndex = 3;
            this.orange.UseVisualStyleBackColor = false;
            this.orange.Click += new System.EventHandler(this.orange_Click);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.Cursor = System.Windows.Forms.Cursors.Hand;
            this.red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.red.Location = new System.Drawing.Point(39, 3);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(30, 30);
            this.red.TabIndex = 2;
            this.red.UseVisualStyleBackColor = false;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Location = new System.Drawing.Point(14, 136);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(91, 30);
            this.pic_color.TabIndex = 1;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // Pallete
            // 
            this.Pallete.BackColor = System.Drawing.Color.White;
            this.Pallete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pallete.Location = new System.Drawing.Point(75, 75);
            this.Pallete.Name = "Pallete";
            this.Pallete.Size = new System.Drawing.Size(30, 30);
            this.Pallete.TabIndex = 1;
            this.Pallete.UseVisualStyleBackColor = false;
            this.Pallete.Click += new System.EventHandler(this.Pallete_Click);
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.black.Cursor = System.Windows.Forms.Cursors.Hand;
            this.black.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.black.Location = new System.Drawing.Point(3, 3);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(30, 30);
            this.black.TabIndex = 0;
            this.black.UseVisualStyleBackColor = false;
            this.black.Click += new System.EventHandler(this.black_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Thickness);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 255);
            this.panel2.TabIndex = 3;
            // 
            // Thickness
            // 
            this.Thickness.AutoSize = true;
            this.Thickness.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thickness.Location = new System.Drawing.Point(26, 11);
            this.Thickness.Name = "Thickness";
            this.Thickness.Size = new System.Drawing.Size(68, 18);
            this.Thickness.TabIndex = 1;
            this.Thickness.Text = "Толщина";
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(3, 32);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(125, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // Line
            // 
            this.Line.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.line1;
            this.Line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Line.Location = new System.Drawing.Point(70, 396);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(50, 50);
            this.Line.TabIndex = 4;
            this.Line.UseVisualStyleBackColor = true;
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // eraser
            // 
            this.eraser.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.eraser;
            this.eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraser.Location = new System.Drawing.Point(14, 396);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(50, 50);
            this.eraser.TabIndex = 4;
            this.eraser.UseVisualStyleBackColor = true;
            this.eraser.Click += new System.EventHandler(this.eraser_Click);
            // 
            // romb
            // 
            this.romb.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.romb;
            this.romb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.romb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.romb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.romb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.romb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.romb.Location = new System.Drawing.Point(14, 340);
            this.romb.Name = "romb";
            this.romb.Size = new System.Drawing.Size(50, 50);
            this.romb.TabIndex = 4;
            this.romb.UseVisualStyleBackColor = true;
            this.romb.Click += new System.EventHandler(this.romb_Click);
            // 
            // par
            // 
            this.par.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.par;
            this.par.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.par.Cursor = System.Windows.Forms.Cursors.Hand;
            this.par.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.par.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.par.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.par.Location = new System.Drawing.Point(70, 340);
            this.par.Name = "par";
            this.par.Size = new System.Drawing.Size(50, 50);
            this.par.TabIndex = 4;
            this.par.UseVisualStyleBackColor = true;
            this.par.Click += new System.EventHandler(this.par_Click);
            // 
            // fill
            // 
            this.fill.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.fill;
            this.fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fill.Location = new System.Drawing.Point(70, 284);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(50, 50);
            this.fill.TabIndex = 4;
            this.fill.UseVisualStyleBackColor = true;
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // pen
            // 
            this.pen.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pen;
            this.pen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pen.Location = new System.Drawing.Point(14, 284);
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(50, 50);
            this.pen.TabIndex = 4;
            this.pen.UseVisualStyleBackColor = true;
            this.pen.Click += new System.EventHandler(this.pen_Click);
            // 
            // pic
            // 
            this.pic.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic.Location = new System.Drawing.Point(131, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(669, 677);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(7, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save BMP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // import
            // 
            this.import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.import.Location = new System.Drawing.Point(7, 559);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(113, 25);
            this.import.TabIndex = 1;
            this.import.Text = "Import BMP";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // angle
            // 
            this.angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.angle.Location = new System.Drawing.Point(29, 462);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(65, 29);
            this.angle.TabIndex = 5;
            this.angle.TextChanged += new System.EventHandler(this.angle_TextChanged);
            this.angle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.angle_KeyPress);
            // 
            // figure
            // 
            this.figure.Location = new System.Drawing.Point(7, 590);
            this.figure.Name = "figure";
            this.figure.Size = new System.Drawing.Size(113, 25);
            this.figure.TabIndex = 6;
            this.figure.Text = "Import Figure";
            this.figure.UseVisualStyleBackColor = true;
            this.figure.Click += new System.EventHandler(this.figure_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 677);
            this.Controls.Add(this.figure);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.eraser);
            this.Controls.Add(this.romb);
            this.Controls.Add(this.par);
            this.Controls.Add(this.fill);
            this.Controls.Add(this.pen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.import);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.pic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button purpl;
        private System.Windows.Forms.Button blueOcean;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button green;
        private System.Windows.Forms.Button yel;
        private System.Windows.Forms.Button orange;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button Pallete;
        private System.Windows.Forms.Button black;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Thickness;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button pen;
        private System.Windows.Forms.Button fill;
        private System.Windows.Forms.Button par;
        private System.Windows.Forms.Button romb;
        private System.Windows.Forms.Button eraser;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.TextBox angle;
        private System.Windows.Forms.Button figure;
    }
}

