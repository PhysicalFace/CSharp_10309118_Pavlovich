using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] matrix = new int[9, 9]; // создание матрицы 9х9
        int _xBase, _yBase; // координаты базы
        static int count = 0; // кол-во найденных целей

        #region Генерация карты
        private void b_Generate_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            dgv_Field.RowCount = 9;
            dgv_Field.ColumnCount = 9;

            for (int i = 0; i < 9; ++i)
                for (int j = 0; j < 9; ++j)
                {
                    matrix[i, j] = rand.Next(5);
                    dgv_Field.Rows[i].Cells[j].Value = matrix[i, j];
                    dgv_Field.Rows[i].Cells[j].Selected = false;
                }

            _xBase = rand.Next(9);
            _yBase = rand.Next(9);

            matrix[_yBase, _xBase] = 0;
            dgv_Field.Rows[_yBase].Cells[_xBase].Selected = true;
            dgv_Field.Rows[_yBase].Cells[_xBase].Value = "С";

            count = 0;
            b_StartScan.Enabled = true;
        }
        #endregion

        #region Начать разведку
        private void b_StartScan_Click(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                b_StartScan.Enabled = false;
                Scout scout = new Scout(matrix, _yBase, _xBase, ref count, ref dgv_Field, ref l_aims, ref b_StartScan, ref b_Generate);
            }
            catch { }
        }
        #endregion
    }

    class Scout
    {
        static int[,] matrix = new int[9, 9];
        static int _xStart, _yStart, count = 0;
        static DataGridView dgv;
        static Label label;

        public Thread scThread1;
        public Thread scThread2;
        public Thread scThread3;
        public Thread scThread4;

        #region Конструктор класса с автоматической многопоточностью
        public Scout(int[,] Matrix, int _ystart, int _xstart, ref int Count, ref DataGridView dgv_Field, ref Label Label, ref Button b_StartScan, ref Button b_Generate)
        {
            _xStart = _xstart;
            _yStart = _ystart;
            dgv = dgv_Field;
            count = Count;
            label = Label;

            for (int i = 0; i < 9; ++i)
                for (int j = 0; j < 9; ++j)
                    matrix[i, j] = Matrix[i, j];

            scThread1 = new Thread(new ThreadStart(Scan_yDown));
            scThread1.Start();

            scThread2 = new Thread(new ThreadStart(Scan_yUp));
            scThread2.Start();

            scThread3 = new Thread(new ThreadStart(Scan_xRight));
            scThread3.Start();

            scThread4 = new Thread(new ThreadStart(Scan_xLeft));
            scThread4.Start();
        }
        #endregion

        #region М-ды сканирования местости
        public void Scan_yDown()
        {
            try
            {
                for (int i = _yStart; i < 9; i++)
                {
                    count += matrix[i, _xStart];
                    Update(i, _xStart);
                }
            }
            catch { }
        }

        public void Scan_yUp()
        {
            try
            {
                for (int i = _yStart; i >= 0; i--)
                {
                    count += matrix[i, _xStart];
                    Update(i, _xStart);
                }
            }
            catch { }
        }

        public void Scan_xRight()
        {
            try
            {
                for (int i = _xStart; i < 9; i++)
                {
                    count += matrix[_yStart, i];
                    Update(_yStart, i);
                }
            }
            catch { }
        }

        public void Scan_xLeft()
        {
            try
            {
                for (int i = _xStart; i >= 0; i--)
                {
                    count += matrix[_yStart, i];
                    Update(_yStart, i);
                }
            }
            catch { }
        }

        static void Update(int a, int b)
        {
            dgv.Rows[a].Cells[b].Selected = true;
            label.BeginInvoke((MethodInvoker)(() => label.Text = "Обнаружено целей:" + Environment.NewLine + count.ToString()));
            Thread.Sleep(400);
        }
        #endregion
    }
}
