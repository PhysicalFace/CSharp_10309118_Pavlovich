using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laba_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected List<int> lst = new List<int>();
        protected int[,] matrix;
        protected int _x, _y;

        protected const int min_range = -100;
        protected const int max_range = 100;
        

        public MainWindow()
        {
            InitializeComponent();
        }

        #region Формирование
        private void b_Create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _x = Int32.Parse(tB_Columns.Text);
                _y = Int32.Parse(tB_Rows.Text);

                matrix = new int[_x, _y];
                Random rand = new Random();

                for (int i = 0; i < _x; i++)
                    for (int j = 0; j < _y; j++)
                        matrix[i, j] = rand.Next(min_range, max_range);

                DataTable dt = new DataTable();

                for (int i = 0; i < _x; i++)
                {
                    dt.Columns.Add();
                }

                for (int i = 0; i < _y; i++)
                {
                    var r = dt.NewRow();
                    for (int j = 0; j < _x; j++)
                    {
                        r[j] = matrix[j, i];
                    }
                    dt.Rows.Add(r);
                }

                dg_Table.DataContext = dt;
            }
            catch (FormatException) { MessageBox.Show("Введите числовое значение!", "Error", MessageBoxButton.OK, MessageBoxImage.Error); }
        }
        #endregion

        #region Расчёт 
        private void b_Action_Click(object sender, RoutedEventArgs e)
        {
            lst.Clear();
            for (int i = 0; i < _x; i++)
            {
                int average = 0;
                int count = 0;
                for (int j = 0; j < _y; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        count++;
                        average += matrix[i, j];
                    }
                }
                lst.Add( count != 0 ? average/count : 0 );
            }

            string str_result = null;
            foreach (int i in lst)
            {
                str_result += (i.ToString() + "; ");
            }

            tB_Result.Text = str_result;
        }
        #endregion

        #region Сортировка методом Шелла
        private void b_Sort_Click(object sender, RoutedEventArgs e)
        {
            int[] arr = lst.ToArray();
            int n = arr.Length;
            double d = n - 1;

            while (d > 0)
            {
                for (double j = 1; j < n; j += d)
                {
                    for (int i = 0; i < n - j; i++)
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            int t = arr[i];
                            arr[i] = arr[i + 1];
                            arr[i + 1] = t;
                        }
                    }
                }
                d = (d - 1) * 0.5;
            }

            string str_result = null;
            foreach (int i in arr)
            {
                str_result += (i.ToString() + "; ");
            }

            tB_Sort.Text = str_result;
        }
        #endregion

        #region Выход из приложения
        private void b_Quit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        #endregion
    }
}
