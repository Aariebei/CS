using System;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace h6
{
    /// <summary>
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        private int sec;
        public Window6()
        {
            InitializeComponent();
            btnStart.Click += BtnStart_Click;
            btnNext.Click += BtnNext_Click;
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            Window7 Window = new Window7();
            Window.Show();
            this.Close();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            //  DispatcherTimer setup
            DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += new EventHandler(dispatcherTimer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            sec++;
            cvs6.Children.Clear();
            int seconds = sec % 60;
            int minutes = sec / 60;
            Rectangle myRect = new Rectangle();
            myRect.Stroke = Brushes.Black;
            myRect.Fill = Brushes.SkyBlue;
            myRect.HorizontalAlignment = HorizontalAlignment.Left;
            myRect.VerticalAlignment = VerticalAlignment.Center;
            myRect.Height = seconds * 2;
            myRect.Width = 20;
            myRect.Margin = new Thickness(90, 0, 0, 0);
            cvs6.Children.Add(myRect);

            Rectangle myRect2 = new Rectangle();
            myRect2.Stroke = Brushes.Black;
            myRect2.Fill = Brushes.SkyBlue;
            myRect2.HorizontalAlignment = HorizontalAlignment.Left;
            myRect2.VerticalAlignment = VerticalAlignment.Center;
            myRect2.Height = minutes * 2;
            myRect2.Width = 20;
            myRect2.Margin = new Thickness(120, 0, 0, 0);
            cvs6.Children.Add(myRect2);
        }
    }
}
