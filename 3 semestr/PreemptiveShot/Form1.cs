using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreemptiveShot
{
    public partial class Form1 : Form
    {
        // Координаты объектов
        public double
            Xa,
            Ya,
            Xr,
            Yr;

        // Скорости объектов
        public double
            VXa,
            VYa,
            Vr,
            VXr,
            VYr;

        // Некоторые постоянные
        public const int
            mapLimit = 400,
            distanceLimit = 60,
            sizeTank = 16,
            sizeAntitank = 16,
            sizeBullet = 8;

        // Инструменты рисования
        Graphics g;
        Pen pen;
        SolidBrush sb;

        // Цвета объектов
        Color
            colorMap = Color.Silver,
            colorTank = Color.Maroon,
            colorAntitank = Color.Green,
            colorBullet = Color.DarkOrange,
            colorVectorTank = Color.FromArgb(64, 0, 0),
            colorVectorAntitank = Color.DarkGreen;

        public Form1()
        {
            InitializeComponent();
        }

        #region Кнопка генерации объектов
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                // Присваиваем координаты объектов
                Xa = Double.Parse(textBoxXa.Text);
                Ya = Double.Parse(textBoxYa.Text);
                Xr = Double.Parse(textBoxXr.Text);
                Yr = Double.Parse(textBoxYr.Text);

                // Присваиваем скорости объектов
                Vr = Double.Parse(textBoxVr.Text);
                VXa = Double.Parse(textBoxXVa.Text);
                VYa = Double.Parse(textBoxYVa.Text);

                // Проверка присвоенных значений
                if (
                    Xa >= 0 && Xa <= mapLimit && Ya >= 0 && Ya <= mapLimit &&
                    Xr >= 0 && Xr <= mapLimit && Yr >= 0 && Yr <= mapLimit &&
                    Math.Abs(Xa - Xr) + Math.Abs(Ya - Yr) >= distanceLimit
                    )
                {
                    // Всё в порядке!
                }
                else
                {
                    // Ошибка в значениях
                    throw new ArgumentOutOfRangeException();
                }

                // Создание карты с координатами
                g = panelMap.CreateGraphics();
                g.Clear(colorMap);

                // Отрисовка местоположений объектов
                sb = new SolidBrush(colorTank);
                g.FillRectangle(sb, (float)(Xa - sizeTank / 2), (float)(Ya - sizeTank / 2), // танк
                    sizeTank, sizeTank);

                sb = new SolidBrush(colorAntitank);
                g.FillRectangle(sb, (float)(Xr - sizeAntitank / 2), (float)(Yr - sizeAntitank / 2), // пушка
                    sizeAntitank, sizeAntitank);

                // Отрисовка вектора скорости танка
                pen = new Pen(colorVectorTank);
                pen.Width = 3;
                g.DrawLine(
                    pen,
                    (float)Xa, (float)Ya,
                    (float)(Xa + VXa), (float)(Ya + VYa)
                    );

                buttonFindSolution.Enabled = true;
                buttonStartAnimation.Enabled = false;
            }
            catch (Exception exc)
            {
                textBoxLog.AppendText(exc.Message + Environment.NewLine);
            }
        }
        #endregion

        #region Кнопка нахождения решения
        private void buttonFindSolution_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Xa - Xr;
                double b = Xr * VYa - Xa * VYa;
                double c = Ya - Yr;
                double d = Yr * VXa - Ya * VXa;

                double K = (1 + (Math.Pow(c, 2) / Math.Pow(a, 2)));
                double L = (2 * c * (d - b) / Math.Pow(a, 2));
                double M = (Math.Pow((d - b), 2) / Math.Pow(a, 2) - Math.Pow(Vr, 2));

                // Находим проекцию как корень квадратного уравнения
                VXr = (-L + Math.Sign(Xa - Xr) * Math.Sqrt(Math.Pow(L, 2) - 4 * K * M)) / (2 * K);

                // Находим другую проекцию через теорему Пифагора
                VYr = Math.Sign(Ya - Yr - Math.Sign(a * b)) * Math.Sqrt(Math.Pow(Vr, 2) - Math.Pow(VXr, 2));

                // Переопределяем K, L, M, VXr и VYr если танк с пушкой находятся на оси ординат
                if (a == 0)
                {
                    K = (1 + (Math.Pow(a, 2) / Math.Pow(c, 2)));
                    L = (2 * a * (b - d) / Math.Pow(c, 2));
                    M = (Math.Pow((b - d), 2) / Math.Pow(c, 2) - Math.Pow(Vr, 2));

                    VYr = (-L + Math.Sign(Ya - Yr) * Math.Sqrt(Math.Pow(L, 2) - 4 * K * M)) / (2 * K);

                    VXr = Math.Sign(Xa - Xr - Math.Sign(c * d)) * Math.Sqrt(Math.Pow(Vr, 2) - Math.Pow(VYr, 2));
                }

                // Расчёт времени столкновения
                double t1 = (Yr - Ya) / (VYa - VYr);
                double t2 = (Xr - Xa) / (VXa - VXr);

                // Отображение времени столкновения
                labelSpeedBullet.Text = (!double.IsNaN(t1) && !double.IsInfinity(t1) && t1 > 0)
                    ? "Время до столкновения: " + t1.ToString()
                    : (!double.IsNaN(t2) && !double.IsInfinity(t2) && t2 > 0)
                    ? "Время до столкновения: " + t2.ToString()
                    : "Столкновения не произойдёт!";

                double t = Double.Parse(labelSpeedBullet.Text.Substring(23));
                double x = Xa + t * VXa;
                double y = Ya + t * VYa;
                if (
                    x < 0 || x > mapLimit || y < 0 || y > mapLimit
                    )
                    textBoxLog.AppendText("Танк выйдет за пределы карты раньше времени!" + Environment.NewLine);

                // Если столкновение произойдёт
                if (labelSpeedBullet.Text != "Столкновения не произойдёт!")
                {
                    // Отрисовка вектора скорости снаряда пушки
                    pen = new Pen(colorVectorAntitank);
                    pen.Width = 3;
                    g.DrawLine(
                        pen,
                        (float)Xr, (float)Yr,
                        (float)(Xr + VXr), (float)(Yr + VYr)
                        );

                    // Вывод проекций скоростей снаряда пушки в textBox'ы
                    textBoxVXr.Text = VXr.ToString();
                    textBoxVYr.Text = VYr.ToString();

                    buttonStartAnimation.Enabled = true; // включение кнопки анимации
                }
            }
            catch (Exception exc)
            {
                textBoxLog.AppendText(exc.Message + Environment.NewLine);
            }
        }
        #endregion

        #region Кнопка старта анимации
        private void buttonStartAnimation_Click(object sender, EventArgs e)
        {
            // Деактивация кнопок во время анимации
            buttonGenerate.Enabled = false;
            buttonFindSolution.Enabled = false;
            buttonStartAnimation.Enabled = false;

            Timer timer = new Timer();
            timer.Interval = 50; // каждые 50 миллисекунд (1/20 секунды)

            double xr = Xr;
            double yr = Yr;
            double xa = Xa;
            double ya = Ya;
            double xb = Xr;
            double yb = Yr;
            double vxa = VXa * (1 / (1000 / (double)timer.Interval));
            double vya = VYa * (1 / (1000 / (double)timer.Interval));
            double vxb = VXr * (1 / (1000 / (double)timer.Interval));
            double vyb = VYr * (1 / (1000 / (double)timer.Interval)); 

            double count = 0;
            double max = double.Parse(labelSpeedBullet.Text.Substring(23));

            // Создание карты с координатами
            Graphics g = panelMap.CreateGraphics();
            g.Clear(colorMap);

            // Отрисовка местоположений объектов
            sb = new SolidBrush(colorTank);
            g.FillRectangle(sb, (float)(xa - sizeTank / 2), (float)(ya - sizeTank / 2), // танк
                sizeTank, sizeTank);

            sb = new SolidBrush(colorAntitank);
            g.FillRectangle(sb, (float)(xr - sizeAntitank / 2), (float)(yr - sizeAntitank / 2), // пушка
                sizeAntitank, sizeAntitank);

            sb = new SolidBrush(colorBullet);
            g.FillEllipse(sb, (float)(xb - sizeBullet / 2), (float)(yb - sizeBullet / 2), // снаряд
                sizeBullet, sizeBullet);

            // Запуск обработчика при тиканье таймера
            timer.Tick += new EventHandler((o, ev) =>
            {
                xa += vxa;
                ya += vya;
                xb += vxb;
                yb += vyb;

                // Очистка поля рисования
                g.Clear(colorMap);

                // Отрисовка местоположений объектов
                sb = new SolidBrush(colorTank);
                g.FillRectangle(sb, (float)(xa - sizeTank / 2), (float)(ya - sizeTank / 2), // танк
                    sizeTank, sizeTank);

                sb = new SolidBrush(colorAntitank);
                g.FillRectangle(sb, (float)(xr - sizeAntitank / 2), (float)(yr - sizeAntitank / 2), // пушка
                    sizeAntitank, sizeAntitank);

                sb = new SolidBrush(colorBullet);
                g.FillEllipse(sb, (float)(xb - sizeBullet / 2), (float)(yb - sizeBullet / 2), // снаряд
                    sizeBullet, sizeBullet);

                count += (1 / (1000 / (double)timer.Interval));

                if (count >= max)
                {
                    Timer t = o as Timer; // можно тут просто воспользоваться timer
                    t.Stop();

                    buttonGenerate.Enabled = true;
                    buttonStartAnimation.Enabled = true;
                }
            });

            timer.Start();   // запустили, а остановится он сам  
        }

        // Тоже самое при нажатии "пробел"
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                if (buttonStartAnimation.Enabled)
                    buttonStartAnimation_Click(buttonStartAnimation, null);
        }
        #endregion
   
        #region Кнопка очистки логов
        private void buttonCleatLogs_Click(object sender, EventArgs e)
        {
            textBoxLog.Clear();
            textBoxLog.AppendText(
                "Введите все необходимые данные:" + Environment.NewLine +
                "-Координаты объектов;" + Environment.NewLine +
                "-Скорости танка и снаряда пушки." + Environment.NewLine +
                "Диапазон координат: 0 - " + mapLimit.ToString() + ";" + Environment.NewLine +
                "Расстояние между танком и пушкой: не менее " + distanceLimit.ToString() + "." + Environment.NewLine +
                "--------------------------------------" + Environment.NewLine
                    );
        }
        #endregion
    }
}
