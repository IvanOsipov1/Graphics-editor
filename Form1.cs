using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool _isDown = false;
        private Bitmap _bitmap;
        private Graphics _graphics;
        private Point px, py;


        private Pen _pen = new Pen(Color.Black, 3);
        private Pen _eraser = new Pen(Color.White, 10);

        private int _index = 1;
        private int x, y, sX, sY, cX, cY;
        private int lx, rx, ux, dx, ly, ry, uy, dy;
        private Point[] _points = new Point[9];

        private ColorDialog _cd = new ColorDialog();
        private Color new_color;
      
        private Point startPoint;
        private Point currentPoint;
        private double _angleDegrees = 10.0;

        private Point[] pointsArray = new Point[4];


        public Form1()
        {
            InitializeComponent();

            this.Width = 900;
            this.Height = 700;
            _bitmap = new Bitmap(pic.Width, pic.Height);
            _graphics = Graphics.FromImage(_bitmap);
            _graphics.Clear(Color.White);
            pic.Image = _bitmap;
            _pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            _eraser.StartCap = System.Drawing.Drawing2D.LineCap.Round;
           
            pic_color.BackColor = Color.Black ;
            new_color = Color.Black;



        }

        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }

        public void Fill(Bitmap bm, int x, int y, Color new_color)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_color);
            if (old_color == new_color)
            {
                return;
            }

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_color);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_color);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_color);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_color);
                }
            }
        }

        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (_index == 7)
            {
                Point point = set_point(pic, e.Location);
                Fill(_bitmap, point.X, point.Y, new_color);
            }
        }
        private void pen_Click(object sender, EventArgs e)
        {
            _index = 1;
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            _index = 2;
        }
        private void romb_Click(object sender, EventArgs e)
        {
            _index = 3;
        }

        private void Line_Click(object sender, EventArgs e)
        {
            _index = 4;
        }
        private void fill_Click(object sender, EventArgs e)
        {
            _index = 7;
        }

      

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.Emf)|*.Emf|(*.*|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = _bitmap.Clone(new Rectangle(0, 0, pic.Width, pic.Height), _bitmap.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Emf);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.Bmp)|*.Bmp|(*.*|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = _bitmap.Clone(new Rectangle(0, 0, pic.Width, pic.Height), _bitmap.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Bmp);
            }
        }

        private void import_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog();
            fd.Filter = "Bitmap Files (*.bmp)|*.bmp|All Files (*.*)|*.*";
            fd.FilterIndex = 1;
            fd.RestoreDirectory = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                _bitmap = new Bitmap(fd.FileName);
                pic.Image = _bitmap;
                _graphics = Graphics.FromImage(_bitmap);
            }
            

        }





        private void ClearButton_Click(object sender, EventArgs e)
        {
            _graphics.Clear(Color.White);
            pic.Image = _bitmap;
            _index = 0;
        }

        private void par_Click(object sender, EventArgs e)
        {
            _index = 8;
        }

        private void Pallete_Click(object sender, EventArgs e)
        {
            _cd.ShowDialog();
            new_color = _cd.Color;
            pic_color.BackColor = _cd.Color;
            _pen.Color = _cd.Color;
        }

        private void angle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '-') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Проверяем, что знак минус находится в начале строки
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > 0))
            {
                e.Handled = true;
            }

            // Проверяем, что знак десятичной точки вводится только один раз
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > 0))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            angle.Text = 45.ToString();
        }

        private void angle_TextChanged(object sender, EventArgs e)
        {
            if (angle.Text != "-" && angle.Text != "" && angle.Text != null && angle.Text != "0")
            {
                _angleDegrees = Convert.ToDouble(angle.Text);
                _angleDegrees = _angleDegrees + 90;
            }
            
        }

        private void figure_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Получаем путь к выбранному файлу
                string filePath = openFileDialog.FileName;

                // Читаем первые 4 строки из файла
                try
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            // Читаем строку из файла
                            string line = reader.ReadLine();

                            if (line != null)
                            {
                                // Разделяем строку на подстроки по пробелу
                                string[] substrings = line.Split(' ');

                                if (substrings.Length >= 2)
                                {
                                    // Проверяем, можно ли преобразовать подстроки в дробные числа
                                    if (double.TryParse(substrings[0], out double x) && double.TryParse(substrings[1], out double y))
                                    {
                                        // Создаем точку Point с координатами x и y и сохраняем в массив
                                        pointsArray[i] = new Point((int)x, (int)y);

                                        // Используем точку по вашему усмотрению
                                        //MessageBox.Show($"Строка {i + 1}: Точка: {pointsArray[i]}");
                                    }
                                    else
                                    {
                                        //MessageBox.Show($"Строка {i + 1} содержит некорректные данные для создания точки.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show($"Строка {i + 1} содержит менее двух подстрок, разделенных пробелом.");
                                }
                            }
                        }
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            if (pointsArray != null)
            {
                if (pointsArray[0].Y == pointsArray[2].Y && pointsArray[1].X == pointsArray[3].X)
                {
                    Point center = new Point((pointsArray[2].X - pointsArray[0].X) / 2 + pointsArray[0].X, pointsArray[0].Y);
                    if (pointsArray[1].X == center.X)
                    {
                        if (pointsArray[3].X == pointsArray[1].X && Math.Abs(center.Y - pointsArray[1].Y) == Math.Abs(center.Y - pointsArray[3].Y))
                        {
                            _graphics.DrawPolygon(_pen, pointsArray);
                        }
                    }
                } else if (pointsArray[1].Y == pointsArray[2].Y && pointsArray[0].X - pointsArray[1].X == pointsArray[3].X - pointsArray[2].X)
                {
                    if (pointsArray[0].Y == pointsArray[3].Y)
                    {
                        _graphics.DrawPolygon(_pen, pointsArray);
                    }
                }
                else
                {
                    MessageBox.Show($"Не является ромбом или квадратом");
                }
                
            }
            //_graphics.DrawPolygon(_pen, pointsArray);
        }

       
        private void black_Click(object sender, EventArgs e)
        {
            _pen.Color = ((Button)sender).BackColor;
            pic_color.BackColor = ((Button)sender).BackColor;
            new_color = ((Button)sender).BackColor;
        }

        private void red_Click(object sender, EventArgs e)
        {
            _pen.Color = ((Button)sender).BackColor;
            pic_color.BackColor = ((Button)sender).BackColor;
            new_color = ((Button)sender).BackColor;
        }

        private void purpl_Click(object sender, EventArgs e)
        {
            _pen.Color = ((Button)sender).BackColor;
            pic_color.BackColor = ((Button)sender).BackColor;
            new_color = ((Button)sender).BackColor;
        }

        private void orange_Click(object sender, EventArgs e)
        {
            _pen.Color = ((Button)sender).BackColor;
            pic_color.BackColor = ((Button)sender).BackColor;
            new_color = ((Button)sender).BackColor;
        }

        private void yel_Click(object sender, EventArgs e)
        {
            _pen.Color = ((Button)sender).BackColor;
            pic_color.BackColor = ((Button)sender).BackColor;
            new_color = ((Button)sender).BackColor;
        }

        private void green_Click(object sender, EventArgs e)
        {
            _pen.Color = ((Button)sender).BackColor;
            pic_color.BackColor = ((Button)sender).BackColor;
            new_color = ((Button)sender).BackColor;
        }

       
        private void blue_Click(object sender, EventArgs e)
        {
            _pen.Color = ((Button)sender).BackColor;
            pic_color.BackColor = ((Button)sender).BackColor;
            new_color = ((Button)sender).BackColor;
        }

        private void blueOcean_Click(object sender, EventArgs e)
        {
            _pen.Color = ((Button)sender).BackColor;
            pic_color.BackColor = ((Button)sender).BackColor;
            new_color = ((Button)sender).BackColor;
        }

       

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            _isDown = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;

            lx = e.X;
            ly = e.Y;
            startPoint = e.Location;
            currentPoint = startPoint;



        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (_isDown)
            {
                if (_index == 3)
                {
                    g.DrawPolygon(_pen, _points); ;
                }

                if (_index == 4)
                {
                    g.DrawLine(_pen, cX, cY, x, y);
                }

                if (_index == 8)
                {
                    int width = currentPoint.X - startPoint.X;
                    int height = currentPoint.Y - startPoint.Y;

                    double angleRadians = _angleDegrees * Math.PI / 180.0;

                    Point[] parallelogramPoints =
                    {
                         startPoint,                                           // Верхний левый угол
                        new Point(startPoint.X + width, startPoint.Y),       // Верхний правый угол
                        new Point(startPoint.X + width + (int)(height * Math.Tan(angleRadians)), currentPoint.Y), // Нижний правый угол
                        new Point(startPoint.X + (int)(height * Math.Tan(angleRadians)), currentPoint.Y)      // Нижний левый угол
                    };
                    _points = parallelogramPoints;
                    g.DrawPolygon(_pen, parallelogramPoints);
                }
            }
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            _isDown = false;

            sX = x - cX;
            sY = y - cY;



            if (_index == 3)
            {
                //_graphics.DrawLine(_pen, ux, uy, dx, dy);
                _graphics.DrawPolygon(_pen, _points);
            }

            if (_index == 4)
            {
                _graphics.DrawLine(_pen, cX, cY, x, y);
            }

            if (_index == 8)
            {
                int width = currentPoint.X - startPoint.X;
                int height = currentPoint.Y - startPoint.Y;

                double angleRadians = _angleDegrees * Math.PI / 180.0;

                Point[] parallelogramPoints =
                {
                         startPoint,                                           // Верхний левый угол
                        new Point(startPoint.X + width, startPoint.Y),       // Верхний правый угол
                        new Point(startPoint.X + width + (int)(height * Math.Tan(angleRadians)), currentPoint.Y), // Нижний правый угол
                        new Point(startPoint.X + (int)(height * Math.Tan(angleRadians)), currentPoint.Y)      // Нижний левый угол
                    };
                _points = parallelogramPoints;
                _graphics.DrawPolygon(_pen, parallelogramPoints);
            }

        }

      

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            _pen.Width = trackBar1.Value;
            _eraser.Width = trackBar1.Value;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDown)
            {
                if (_index == 1)
                {
                    px = e.Location;
                    _graphics.DrawLine(_pen, px, py);
                    py = px;
                }
                if (_index == 3)
                {
                    px = e.Location;
                    //_graphics.DrawLine(_pen, ux, uy, dx, dy);
                    //_graphics.DrawLine(_pen, lx, ly, rx, ry);
                    py = px;
                }

                if (_index == 2)
                {
                    px = e.Location;
                    _graphics.DrawLine(_eraser, px, py);
                    py = px;
                }
            }
            pic.Refresh();

            x = e.X;
            y = e.Y;


            sX = e.X - cX;
            sY = e.Y - cY;

            ry = ly;
            rx = e.X;
            if (_index == 3)
            {
                int width = e.X - lx;
                int height = e.Y - ly;

                Point[] diamond =
                   {
                    new Point(startPoint.X + width / 2, startPoint.Y),           // Верхний центр
                    new Point(startPoint.X + width, startPoint.Y + height / 2),   // Правый центр
                    new Point(startPoint.X + width / 2, startPoint.Y + height),   // Нижний центр
                    new Point(startPoint.X, startPoint.Y + height / 2) };       // Левый центр


                _points = diamond;
            }
            if (_index == 8)
            {

                currentPoint = e.Location;
                pic.Refresh();
            }
           
        }
        
       
    }
}
