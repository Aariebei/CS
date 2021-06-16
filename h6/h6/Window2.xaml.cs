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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private int count = 1;
        public Window2()
        {
            InitializeComponent();
            btnNext.Click += BtnNext_Click;
            lblCount.Content = count.ToString();
            btnIncrement.Click += BtnIncrement_Click;
        }

        private void BtnIncrement_Click(object sender, RoutedEventArgs e)
        {
            count = count + 1;
            lblCount.Content = count.ToString();
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            Window3 Window = new Window3();
            Window.Show();
            this.Close();
        }
    }
}
