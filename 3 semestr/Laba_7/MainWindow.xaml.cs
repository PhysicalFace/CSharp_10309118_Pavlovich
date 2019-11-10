using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Drawing;
using System.Windows.Threading;
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

namespace Laba_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool canAnalyze = false;

        public MainWindow()
        {
            InitializeComponent();

            // Инициализация таймера
            DispatcherTimer MyTimer = new DispatcherTimer();
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Interval = new TimeSpan(100000);
            MyTimer.Start();

            // Инициализация событий
            timelineSlider.AddHandler(MouseLeftButtonDownEvent, new MouseButtonEventHandler(Slider_MouseLeftButtonDown), true);
            timelineSlider.AddHandler(MouseLeftButtonUpEvent, new MouseButtonEventHandler(Slider_MouseLeftButtonUp), true);
            speedSlider.AddHandler(MouseLeftButtonDownEvent, new MouseButtonEventHandler(Slider_MouseLeftButtonDown), true);
            speedSlider.AddHandler(MouseLeftButtonUpEvent, new MouseButtonEventHandler(Slider_MouseLeftButtonUp), true);
        }

        #region Кнопки
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            media.Play();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            media.Stop();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            media.Pause();
        }
        
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            canAnalyze = !canAnalyze;
        }
        #endregion

        #region Ползунки
        private void ChangeMediaPosition(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            media.Position = TimeSpan.FromSeconds(timelineSlider.Value);
        }

        private void ChangeMediaVolume(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            media.Volume = (double)volumeSlider.Value;
        }

        private void ChangeSpeedRatio(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            media.SpeedRatio = (double)speedSlider.Value;
        }
        #endregion

        #region Таймер
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            if (canAnalyze)
            {
                var imageSource = new RenderTargetBitmap(media.NaturalVideoWidth, media.NaturalVideoHeight, 96, 96, PixelFormats.Default);
                imageSource.Render(media);

                BitmapSource bs = (BitmapSource)imageSource;

                byte[] pixels = BitmapSourceToArray(bs);

                int sum_red = 0, sum_green = 0, sum_blue = 0;
                for (int i = 0; i < pixels.Length - 3; i += 3)
                {
                    try
                    {
                        sum_red += pixels[i];
                        sum_green += pixels[i + 1];
                        sum_blue += pixels[i + 2];
                    }
                    catch { }
                }

                if (sum_blue > sum_red && sum_blue > sum_green)
                {
                    lb_frames.Items.Add(media.Position.TotalSeconds);
                }
            }

            timelineSlider.Value = media.Position.TotalSeconds;
            Label1.Content = "position: " + media.Position.TotalSeconds.ToString();
        }

        private byte[] BitmapSourceToArray(BitmapSource bitmapSource)
        {
            int stride = (int)bitmapSource.PixelWidth * (bitmapSource.Format.BitsPerPixel / 8);
            byte[] pixels = new byte[(int)bitmapSource.PixelHeight * stride];

            bitmapSource.CopyPixels(pixels, stride, 0);

            return pixels;
        }
        #endregion

        #region События ползунков
        private void Slider_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            media.Pause();
        }

        private void Slider_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            media.Play();
        }
        #endregion

        #region События MediaOpened и MediaEnded
        private void MediaOpened(object sender, EventArgs e)
        {
            timelineSlider.Maximum = media.NaturalDuration.TimeSpan.TotalSeconds;
        }

        private void MediaEnded(object sender, EventArgs e)
        {
            media.Stop();
            timelineSlider.Value = 0;
        }
        #endregion     
    }
}
