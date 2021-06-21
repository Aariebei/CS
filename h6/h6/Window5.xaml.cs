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
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
            btnNext.Click += BtnNext_Click;
            btnCalculate.Click += BtnCalculate_Click;
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int deepLength = Convert.ToInt32(sldDeep.Value);
            int shallowLength = Convert.ToInt32(sldShallow.Value);
            double volume = (deepLength + shallowLength) / 2 * deepLength * shallowLength;
            lblVolume.Content = volume.ToString("0.0");

            cvs5.Children.Clear();
            Polygon Pool = new Polygon();
            Pool.Stroke = Brushes.Black;
            Pool.Fill = Brushes.White;
            Pool.StrokeThickness = 2;
            Pool.HorizontalAlignment = HorizontalAlignment.Left;
            Pool.VerticalAlignment = VerticalAlignment.Center;
            Point Point1 = new Point(20, 8);
            Point Point2 = new Point(20, 8 + deepLength);
            Point Point3 = new Point(110, 8 + shallowLength);
            Point Point4 = new Point(110, 8);
            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);
            myPointCollection.Add(Point4);
            Pool.Points = myPointCollection;
            cvs5.Children.Add(Pool);
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
