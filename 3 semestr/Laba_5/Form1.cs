using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_5
{
    public partial class Form1 : Form
    {
        // Команды передвижения примитива
        enum Direction { Up, Down, Left, Right }
        Direction dir = Direction.Right;

        //Константы
        private const int width = 16; // ширина примитива
        private const int height = 16; // длина примитива
        private const int _xstart = 320 / 2 - width - 8; // начало координаты х примитива
        private const int _ystart = 320 / 2 - height - 8; // начало координаты у примитива
        private const int _x1limit = -_xstart; // левый предел прорисовки примитива
        private const int _y1limit = -_ystart; // верхний предел прорисовки примитива
        private const int _x2limit = 287 - _xstart; // правый предел прорисовки примитива
        private const int _y2limit = 264 - _ystart; // нижний предел прорисовки примитива

        // Координаты примитива
        private int _xpos = 0;
        private int _ypos = 0;

        // Отрисовка примитива
        private bool can_draw = false;

        //Объекты
        Graphics g;
        Point _point;
        Timer timer1;
        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
            b_Animate.Enabled = false;
            b_Choose.Enabled = false;
            b_Stop.Enabled = false;
        }

        #region Show
        private void b_Show_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.TranslateTransform(_point.X, _point.Y);
            Pen pen = new Pen(Color.Red);
            g.DrawRectangle(pen, _xstart, _ystart, width, height);

            can_draw = true;

            b_Choose.Enabled = true;
            b_Show.Enabled = false;
        }
        #endregion    

        #region Choose
        private void b_Choose_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
            b_Animate.Enabled = true;
        }
        #endregion

        #region Animate
        private void b_Animate_Click(object sender, EventArgs e)
        {
            timer1 = new Timer { Interval = Int32.Parse(form2.tB_speed.Text) };
            timer1.Tick += timer1_Tick;
            timer1.Enabled = true;

            b_Choose.Enabled = false;
            b_Animate.Enabled = false;
            b_Stop.Enabled = true;
        }
        #endregion

        #region Stop
        private void b_Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            b_Choose.Enabled = true;
            b_Animate.Enabled = true;
            b_Stop.Enabled = false;
        }
        #endregion

        #region Quit
        private void b_Quit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion       

        // Прорисовка примитива
        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (can_draw == true)
            {
                g = e.Graphics;
                g.TranslateTransform(_point.X, _point.Y);
                Pen pen = new Pen(Color.Red);
                g.DrawRectangle(pen, _xstart, _ystart, width, height);
            }
        }

        // Таймер прорисовки
        private void timer1_Tick(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red);

            switch (dir)
            {
                case Direction.Right:
                    _point = new Point(_xpos, _ypos);
                    Invalidate();
                    _xpos++;
                    break;

                case Direction.Down:
                    _point = new Point(_xpos, _ypos);
                    Invalidate();
                    _ypos++;
                    break;

                case Direction.Left:
                    _point = new Point(_xpos, _ypos);
                    Invalidate();
                    _xpos--;
                    break;

                case Direction.Up:
                    _point = new Point(_xpos, _ypos);
                    Invalidate();
                    _ypos--;
                    break;
            }

            if (_xpos >= _x2limit && dir == Direction.Right)
                dir = Direction.Down;
            if (_ypos >= _y2limit && dir == Direction.Down)
                dir = Direction.Left;
            if (_xpos <= _x1limit && dir == Direction.Left)
                dir = Direction.Up;
            if (_ypos <= _y1limit && dir == Direction.Up)
                dir = Direction.Right;
        }
    }
}
