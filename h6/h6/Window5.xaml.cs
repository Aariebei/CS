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
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
