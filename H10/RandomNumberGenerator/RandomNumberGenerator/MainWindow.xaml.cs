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

namespace RandomNumberGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NumberGenerator num_gen = new NumberGenerator(42);
        public MainWindow()
        {
            InitializeComponent();
            btnGenerate.Click += BtnGenerate_Click;
        }

        private void BtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            
            int random = num_gen.nextRandomNumber();
            MessageBox.Show($"Volgende getal is: {random}");
        }
    }
}
