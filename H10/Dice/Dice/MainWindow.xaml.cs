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

namespace Dice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Die die = new Die();
        public MainWindow()
        {
            InitializeComponent();
            btnIncrement.Click += BtnIncrement_Click;
            btnRoll.Click += BtnRoll_Click;
        }

        private void BtnRoll_Click(object sender, RoutedEventArgs e)
        {
            die.Roll();
            lblDigit.Content = Convert.ToInt32(die.Digit);
        }

        private void BtnIncrement_Click(object sender, RoutedEventArgs e)
        {
            die.Increment();
            lblDigit.Content = Convert.ToInt32(die.Digit);
        }
    }
}
