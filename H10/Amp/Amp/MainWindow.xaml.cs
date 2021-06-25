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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Amp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            sldMin.ValueChanged += SldMin_ValueChanged;
            sldMax.ValueChanged += SldMax_ValueChanged;
            txbMin.Text = $"{sldMin.Value}";
            txbMax.Text = $"{sldMax.Value}";
        }

        private void SldMax_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int max = Convert.ToInt32(sldMax.Value);
            int min = Convert.ToInt32(sldMin.Value);
            if (max < min)
            {
                sldMax.Value = min;
            }
            txbMax.Text =sldMax.Value.ToString("0");
        }

        private void SldMin_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int max = Convert.ToInt32(sldMax.Value);
            int min = Convert.ToInt32(sldMin.Value);
            if (min > max)
            {
                sldMin.Value = max;
            }
            txbMin.Text = sldMin.Value.ToString("0");
        }
    }
}
