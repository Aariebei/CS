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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        private List<int> list = new List<int>();
        private Random Rnd = new Random();
        public Window3()
        {
            InitializeComponent();
            btnNext.Click += BtnNext_Click;
            btnGenerate.Click += BtnGenerate_Click;
        }

        private void BtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            int rndNum = Rnd.Next(200, 400);
            list.Add(rndNum);
            lblRandom.Content = rndNum.ToString();
            lblAverage.Content = list.Average().ToString("0.0");
            lblSum.Content = list.Sum().ToString();
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            Window4 Window = new Window4();
            Window.Show();
            this.Close();
        }
    }
}
