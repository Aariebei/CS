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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        private double fuck = 0;
        public Window4()
        {
            InitializeComponent();
            btnConvert.Click += BtnConvert_Click;
            btnCalculate.Click += BtnCalculate_Click;
            sldCelcius.ValueChanged += SldCelcius_ValueChanged;
            btnNext.Click += BtnNext_Click;
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            Window5 Window = new Window5();
            Window.Show();
            this.Close();
        }

        private void SldCelcius_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblCelcius2.Content = sldCelcius.Value.ToString("0.0");
            fuck = sldCelcius.Value;
        }

        private void DrawRectangle(Canvas drawingArea,
                                   SolidColorBrush brushToUse,
                                   double xPosition,
                                   double yPosition,
                                   double width,
                                   double height)
        {
            Rectangle theRectangle = new Rectangle();
            theRectangle.Width = width;
            theRectangle.Height = height;
            theRectangle.Margin = new Thickness(xPosition, yPosition, 0, 0);
            theRectangle.Fill = brushToUse;
            drawingArea.Children.Add(theRectangle);
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int c = Convert.ToInt32(sldCelcius.Value);
            double f = c * 9 / 5 + 32;
            SolidColorBrush brush = new SolidColorBrush(Colors.Black);
            cvsGraph.Children.Clear();
            DrawRectangle(cvsGraph, brush, 80, 0, 5, sldCelcius.Value / 3 * 2);
            DrawRectangle(cvsGraph, brush, 60, 0, 5, f / 3 * 2);
        }

        private void BtnConvert_Click(object sender, RoutedEventArgs e)
        {
            int c = Convert.ToInt32(txbCelcius.Text);
            double f = c * 9 / 5 + 32;
            lblFahrenheit.Content = f.ToString("0.0");
        }
    }
}
