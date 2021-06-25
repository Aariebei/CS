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

namespace Points
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Counter counter = new Counter();
        public MainWindow()
        {
            InitializeComponent();
            btnDecrement.Click += BtnDecrement_Click;
            btnIncrement.Click += BtnIncrement_Click;
            btnReset.Click += BtnReset_Click;
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            counter.Reset();
            lblCount.Content = counter.Count;
        }

        private void BtnIncrement_Click(object sender, RoutedEventArgs e)
        {
            counter.Increment();
            lblCount.Content = counter.Count;
        }

        private void BtnDecrement_Click(object sender, RoutedEventArgs e)
        {
            counter.Decrement();
            lblCount.Content = counter.Count;
        }
    }
}
