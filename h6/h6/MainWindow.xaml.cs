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

namespace h6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnNext.Click += BtnNext_Click;
            btnStart.Click += BtnStart_Click;
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Window10 Window = new Window10();
            Window.Show();
            this.Close();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            lblMax.Content = txbMax.Text;
            lblMin.Content = txbMin.Text;
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            Window2 Window = new Window2();
            Window.Show();
            this.Close();
        }
    }
}
