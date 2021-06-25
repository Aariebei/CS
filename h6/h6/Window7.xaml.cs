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

namespace h6
{
    /// <summary>
    /// Interaction logic for Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        private Random rnd = new Random();
        public Window7()
        {
            InitializeComponent();
            btnDraw.Click += BtnDraw_Click;
            btnStart.Click += btnStart_Click;
            btnNext.Click += BtnNext_Click;
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            Window8 Window = new Window8();
            Window.Show();
            this.Close();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            cvs7a.Children.Clear();
            drawRandomCircle();
            drawRandomCircle();
            drawRandomCircle();
            btnDraw.Visibility = Visibility.Visible;
        }

        private void BtnDraw_Click(object sender, RoutedEventArgs e)
        {
            cvs7b.Children.Clear();
            Ellipse circle = new Ellipse();
            circle.Stroke = new SolidColorBrush(Colors.Black);
            circle.HorizontalAlignment = HorizontalAlignment.Left;
            circle.VerticalAlignment = VerticalAlignment.Center;
            circle.Height = sldRadius.Value;
            circle.Width = sldRadius.Value;
            sldHorizontal.Maximum = cvs7b.Width - circle.Width;
            sldVertical.Maximum = cvs7b.Height - circle.Height;
            circle.Margin = new Thickness(sldHorizontal.Value, sldVertical.Value, 0, 0);
            cvs7b.Children.Add(circle);

        }
         private void drawRandomCircle()
        {
            int x = rnd.Next(0, 350 - 50);
            int y = rnd.Next(0, 350 - 50);
            Ellipse circle = new Ellipse();
            circle.Fill = new SolidColorBrush(Colors.Black);
            circle.HorizontalAlignment = HorizontalAlignment.Left;
            circle.VerticalAlignment = VerticalAlignment.Center;
            circle.Height = 50;
            circle.Width = 50;
            circle.Margin = new Thickness(x, y, 0, 0);
            cvs7a.Children.Add(circle);
        }
    }
}
