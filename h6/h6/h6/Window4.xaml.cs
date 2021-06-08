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
        public Window4()
        {
            InitializeComponent();
            btnConvert.Click += BtnConvert_Click;
            btnCalculate.Click += BtnCalculate_Click;
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int c = Convert.ToInt32(sldCelcius.Value);
            double f = c * 9 / 5 + 32;
        }

        private void BtnConvert_Click(object sender, RoutedEventArgs e)
        {
            int c = Convert.ToInt32(txbCelcius.Text);
            double f = c * 9 / 5 + 32;
            lblFahrenheit.Content = f.ToString("0.0");
        }
    }
}
